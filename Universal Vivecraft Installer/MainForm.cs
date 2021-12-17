using Bluscream;

namespace UniversalVivecraftInstaller
{
    public partial class MainForm : Form
    {
        internal const string GH_USERNAME = "jrbudda";
        internal const string GH_SPIGOT_REPO = "Vivecraft_Spigot_Extensions";
        internal const int CURSEFORGE_PROJECTID = 325360;
        private static readonly NLog.Logger Logger = NLog.LogManager.GetCurrentClassLogger();
        public static GitHubClient ghClient = new GitHubClient(new ProductHeaderValue("vivecraft-universal-installer"));
        internal List<VivecraftVersion> versions = new List<VivecraftVersion>();
        internal CurseForge.Models.ModInfo forgeMod = new CurseForge.Models.ModInfo();
        internal IReadOnlyList<Release> spigotReleases = new List<Release>().AsReadOnly();

        public MainForm()
        {
            forgeMod = CurseForgeClient.GetModInfoFromWidget(CURSEFORGE_PROJECTID);
            spigotReleases = GithubCl.GetAllReleasesForRepository(MainForm.ghClient, GH_USERNAME, GH_SPIGOT_REPO);
            GetVersions();

            InitializeComponent();
            lst_versions.DataSource = bnd_versions;
            bnd_versions.DataSource = versions;
            lst_versions.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            lst_versions.Columns[lst_versions.Columns.Count - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            /*if (lst_versions.Rows.Count > 0)
            {
                lst_versions.Rows[0].Selected = true;
                lst_versions.FirstDisplayedScrollingRowIndex = lst_versions.Rows[0].Index;
            }*/
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // var user = ghClient.User.Get(GH_USERNAME).Result;
            // .WriteLine(versions.ToJson(true));
            // var releases = ghClient.Repository.Release.GetAll(GH_USERNAME, "octokit.net").Result;
        }

        private List<VivecraftVersion> GetVersions(bool force = false)
        {
            if (!force && versions.Count < 1)
            {
                versions.Clear();
                var repos = GithubCl.GetAllRepositoriesForUser(ghClient, GH_USERNAME);

                foreach (var ver in repos.Where(r => r.Description != null && r.Description.StartsWith("VR mod for Minecraft")))
                    versions.Add(new VivecraftVersion(ver));

                versions.Reverse();
            }

            return versions;
        }

        private void lst_versions_Unselected()
        {
            txt_description.Clear();
            btn_install.Enabled = false;
            btn_installvr.Enabled = false;
        }

        private int lastSelectedRow;

        private void lst_versions_SelectionChanged(object sender, EventArgs e)
        {
            if (lst_versions.SelectedRows.Count != 1)
            {
                lst_versions_Unselected(); return;
            }

            var row = lst_versions.SelectedRows[0];

            if (row is null)
            {
                lst_versions_Unselected(); ; return;
            }

            if (row.Index == lastSelectedRow) return;
            lastSelectedRow = row.Index;
            var version = row.DataBoundItem as VivecraftVersion;
            txt_description.Clear();

            foreach (var release in version.Releases) // .Reverse()
            {
                txt_description.SelectionFont = new Font(txt_description.Font, FontStyle.Bold);
                txt_description.AppendText(release.Name + Environment.NewLine);
                txt_description.SelectionFont = new Font(txt_description.Font, FontStyle.Regular);
                txt_description.AppendText(release.Body + Environment.NewLine);
            }
            // txt_description.Text = string.Join("\n\n", version.Releases.Select(v => v.Body).Reverse());

            var has_releases = version.Releases.Count > 0;
            var assets = version.Releases[0]?.Assets.Count;
            btn_install.Enabled = has_releases && assets > 1;
            btn_installvr.Enabled = has_releases && assets > 0;

            var has_spigot = spigotReleases.Where(t => t.Name.Contains(version._MCVersion.ToString(2)));

            if (has_spigot != null && has_spigot.Count() > 0 && (version._MCVersion > new Version(1, 9))) btn_spigotserverplugin_install.Enabled = true;
            else btn_spigotserverplugin_install.Enabled = false;

            // Get curseforge url
            if (forgeMod.GetDownload(version._MCVersion) != null) btn_forgeservermod_install.Enabled = true;
            else btn_forgeservermod_install.Enabled = false;
        }

        private void btn_install_Click(object sender, EventArgs e)
        {
            var version = lst_versions.SelectedRows[0].DataBoundItem as VivecraftVersion;
            DownloadAndRunInstaller(new Uri(version.NonVRInstaller.BrowserDownloadUrl), version.NonVRInstaller.Name);
        }

        private void btn_installvr_Click(object sender, EventArgs e)
        {
            var version = lst_versions.SelectedRows[0].DataBoundItem as VivecraftVersion;
            DownloadAndRunInstaller(new Uri(version.VRInstaller.BrowserDownloadUrl), version.VRInstaller.Name);
        }

        private void DownloadAndRunInstaller(Uri url, string filename)
        {
            var outFile = new DirectoryInfo(Path.GetTempPath()).CombineFile(filename);

            try
            {
                if (!outFile.Exists)
                {
                    using (WebClient wc = new WebClient())
                        // wc.Headers[HttpRequestHeader.ContentType] = "application/x-www-form-urlencoded";
                        wc.DownloadFile(url.AbsoluteUri, outFile.FullName);
                }

                System.Diagnostics.Process.Start(outFile.FullName);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void btn_spigotserverplugin_install_Click(object sender, EventArgs e)
        {
            Logger.Debug("btn_spigotserverplugin_install_Click");
            var version = lst_versions.SelectedRows[0].DataBoundItem as VivecraftVersion;
            var has_release = spigotReleases.Where(t => t.Name.Contains(version._MCVersion.ToString(2)));

            if (has_release is null || has_release.Count() < 1)
            {
                btn_spigotserverplugin_install.Enabled = false;
                return;
            }

            var release_url = new Uri(has_release.First().HtmlUrl);

            try
            {
                release_url.OpenInBrowser();
            }
            catch (Exception ex) { Logger.Error(ex); }

            var has_asset = has_release.First().Assets.Where(t => t.Name.Contains(version._MCVersion.ToString(2)));

            if (has_asset != null && has_release.Count() > 0)
            {
                var asset_url = new Uri(has_asset.First().BrowserDownloadUrl);
                MessageBox.Show($"Copied URL\n\n{asset_url}");
                Clipboard.SetText(asset_url.ToString());
            }
        }

        private void btn_forgeservermod_install_Click_1(object sender, EventArgs e)
        {
            Logger.Debug("btn_forgeservermod_install_Click");
            var version = lst_versions.SelectedRows[0].DataBoundItem as VivecraftVersion;
            var fmod = forgeMod.GetDownload(version._MCVersion);

            if (fmod is null)
            {
                btn_forgeservermod_install.Enabled = false;
                return;
            }

            Logger.Info($"{fmod.Item2}: {fmod.Item1}");
            fmod.Item1.OpenInBrowser();
            // DownloadAndRunInstaller(fmod.Item1, fmod.Item2);
        }
    }
}