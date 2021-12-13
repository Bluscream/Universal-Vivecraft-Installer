using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Octokit;
using Bluscream;
using System.IO;
using System.Net;
using System.Reflection;
using Newtonsoft.Json;
using ForgedCurse;
using ForgedCurse.WrapperTypes;

namespace UniversalVivecraftInstaller
{
    public partial class MainForm : Form
    {
        private static readonly NLog.Logger Logger = NLog.LogManager.GetCurrentClassLogger();

        public static GitHubClient githubClient = new GitHubClient(new ProductHeaderValue("vivecraft-universal-installer"));
        public static ForgeClient forgeClient = new ForgeClient();

        internal FileInfo cacheFile = new DirectoryInfo(Path.GetTempPath()).CombineFile(Assembly.GetExecutingAssembly().GetName().Name + ".json");
        internal Cache Cache = new Cache();

        internal const string GH_USERNAME = "jrbudda";

        public MainForm()
        {
            GetVersions();
            InitializeComponent();
            lst_versions.DataSource = bnd_versions;
            bnd_versions.DataSource = Cache.Versions;
            lst_versions.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            lst_versions.Columns[lst_versions.Columns.Count - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            lst_versions.Rows[0].Selected = true;
            lst_versions.FirstDisplayedScrollingRowIndex = lst_versions.Rows[0].Index;
            lst_versions_SelectionChanged(null, null);
        }

        private void UpdateCache()
        {
            Cache.LastUpdated = DateTime.Now;
            cacheFile.WriteAllText(JsonConvert.SerializeObject(Cache, Formatting.Indented));
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // var user = ghClient.User.Get(GH_USERNAME).Result;
            // var releases = ghClient.Repository.Release.GetAll(GH_USERNAME, "octokit.net").Result;
        }

        private List<VivecraftVersion> GetVersions(bool force = false)
        {
            if (cacheFile.Exists && cacheFile.Length > 0 && cacheFile.LastWriteTime < DateTime.Now - TimeSpan.FromMinutes(30))
            {
                using (StreamReader file = cacheFile.OpenText())
                {
                    JsonSerializer serializer = new JsonSerializer();
                    Cache.Versions = ((Cache)serializer.Deserialize(file, typeof(Cache))).Versions;
                }
            }
            if (force || Cache.Versions.Count < 1)
            {
                Cache.Versions.Clear();
                foreach (var ver in GithubCl.GetAllRepositoriesForUser(githubClient, GH_USERNAME).Where(r => r.Description != null && r.Description.StartsWith("VR mod for Minecraft")))
                {
                    Logger.Info("New repository: %s", ver.FullName);
                    Cache.Versions.Add(new VivecraftVersion(ver));
                }
                Cache.Versions.Reverse();
                UpdateCache();
            }
            return Cache.Versions;
        
        }
        private void lst_versions_Unselected()
        {
            txt_description.Clear();
            btn_install.Enabled = false;
            btn_installvr.Enabled = false;
        }
        private int lastSelectedRow = 0;
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
            if (version.Releases[0].Assets.Count > 1) btn_install.Enabled = true;
            else btn_install.Enabled = false;
            btn_installvr.Enabled = true;
            btn_dlforge.Enabled = true; // TODO
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
                if (!outFile.Exists || outFile.Length < 2)
                {
                    using (WebClient wc = new WebClient())
                    {
                        // wc.Headers[HttpRequestHeader.ContentType] = "application/x-www-form-urlencoded";
                        wc.DownloadFile(url.AbsoluteUri, outFile.FullName);
                    }
                }
                System.Diagnostics.Process.Start(outFile.FullName);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void btn_dlforge_Click(object sender, EventArgs e)
        {
            Addon addon = forgeClient.GetAddon(325360);

            // Prints the first author of the mod
            MessageBox.Show(addon.Name);
            // addon.LatestFiles.Where(f => f.Versions)
        }

        private void btn_dlspigot_Click(object sender, EventArgs e)
        {

        }
    }
}