
namespace UniversalVivecraftInstaller
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.lst_versions = new System.Windows.Forms.DataGridView();
            this.txt_description = new System.Windows.Forms.RichTextBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btn_spigotserverplugin_install = new System.Windows.Forms.Button();
            this.btn_forgeservermod_install = new System.Windows.Forms.Button();
            this.btn_install = new System.Windows.Forms.Button();
            this.btn_installvr = new System.Windows.Forms.Button();
            this.bnd_versions = new System.Windows.Forms.BindingSource(this.components);
            this.menu_main = new System.Windows.Forms.MenuStrip();
            this.reloadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.websiteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.githubToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.discordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.climbeyMotionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.githubToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.checkForUpdatesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.status = new System.Windows.Forms.StatusStrip();
            this.getVivecraftAlphaBetaVersionsHereToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.lst_versions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bnd_versions)).BeginInit();
            this.menu_main.SuspendLayout();
            this.SuspendLayout();
            // 
            // lst_versions
            // 
            this.lst_versions.AllowUserToAddRows = false;
            this.lst_versions.AllowUserToDeleteRows = false;
            this.lst_versions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lst_versions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lst_versions.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.lst_versions.Location = new System.Drawing.Point(0, 0);
            this.lst_versions.MultiSelect = false;
            this.lst_versions.Name = "lst_versions";
            this.lst_versions.ReadOnly = true;
            this.lst_versions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.lst_versions.Size = new System.Drawing.Size(387, 487);
            this.lst_versions.TabIndex = 0;
            this.lst_versions.SelectionChanged += new System.EventHandler(this.lst_versions_SelectionChanged);
            // 
            // txt_description
            // 
            this.txt_description.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_description.Location = new System.Drawing.Point(0, 0);
            this.txt_description.Name = "txt_description";
            this.txt_description.Size = new System.Drawing.Size(574, 450);
            this.txt_description.TabIndex = 1;
            this.txt_description.Text = "";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.lst_versions);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.btn_spigotserverplugin_install);
            this.splitContainer1.Panel2.Controls.Add(this.btn_forgeservermod_install);
            this.splitContainer1.Panel2.Controls.Add(this.btn_install);
            this.splitContainer1.Panel2.Controls.Add(this.btn_installvr);
            this.splitContainer1.Panel2.Controls.Add(this.txt_description);
            this.splitContainer1.Size = new System.Drawing.Size(965, 487);
            this.splitContainer1.SplitterDistance = 387;
            this.splitContainer1.TabIndex = 2;
            // 
            // btn_spigotserverplugin_install
            // 
            this.btn_spigotserverplugin_install.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_spigotserverplugin_install.Enabled = false;
            this.btn_spigotserverplugin_install.Location = new System.Drawing.Point(98, 456);
            this.btn_spigotserverplugin_install.Name = "btn_spigotserverplugin_install";
            this.btn_spigotserverplugin_install.Size = new System.Drawing.Size(89, 23);
            this.btn_spigotserverplugin_install.TabIndex = 5;
            this.btn_spigotserverplugin_install.Text = "Spigot Plugin";
            this.btn_spigotserverplugin_install.UseVisualStyleBackColor = true;
            this.btn_spigotserverplugin_install.Click += new System.EventHandler(this.btn_spigotserverplugin_install_Click);
            // 
            // btn_forgeservermod_install
            // 
            this.btn_forgeservermod_install.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_forgeservermod_install.Enabled = false;
            this.btn_forgeservermod_install.Location = new System.Drawing.Point(3, 456);
            this.btn_forgeservermod_install.Name = "btn_forgeservermod_install";
            this.btn_forgeservermod_install.Size = new System.Drawing.Size(89, 23);
            this.btn_forgeservermod_install.TabIndex = 4;
            this.btn_forgeservermod_install.Text = "Forge Mod";
            this.btn_forgeservermod_install.UseVisualStyleBackColor = true;
            this.btn_forgeservermod_install.Click += new System.EventHandler(this.btn_forgeservermod_install_Click_1);
            // 
            // btn_install
            // 
            this.btn_install.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_install.Enabled = false;
            this.btn_install.Location = new System.Drawing.Point(378, 456);
            this.btn_install.Name = "btn_install";
            this.btn_install.Size = new System.Drawing.Size(89, 23);
            this.btn_install.TabIndex = 3;
            this.btn_install.Text = "Install Non-VR";
            this.btn_install.UseVisualStyleBackColor = true;
            this.btn_install.Click += new System.EventHandler(this.btn_install_Click);
            // 
            // btn_installvr
            // 
            this.btn_installvr.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_installvr.Enabled = false;
            this.btn_installvr.Location = new System.Drawing.Point(473, 456);
            this.btn_installvr.Name = "btn_installvr";
            this.btn_installvr.Size = new System.Drawing.Size(89, 23);
            this.btn_installvr.TabIndex = 2;
            this.btn_installvr.Text = "Install VR";
            this.btn_installvr.UseVisualStyleBackColor = true;
            this.btn_installvr.Click += new System.EventHandler(this.btn_installvr_Click);
            // 
            // menu_main
            // 
            this.menu_main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reloadToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.aboutToolStripMenuItem1,
            this.getVivecraftAlphaBetaVersionsHereToolStripMenuItem});
            this.menu_main.Location = new System.Drawing.Point(0, 0);
            this.menu_main.Name = "menu_main";
            this.menu_main.Size = new System.Drawing.Size(965, 24);
            this.menu_main.TabIndex = 3;
            // 
            // reloadToolStripMenuItem
            // 
            this.reloadToolStripMenuItem.Name = "reloadToolStripMenuItem";
            this.reloadToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.reloadToolStripMenuItem.Text = "Reload";
            this.reloadToolStripMenuItem.Click += new System.EventHandler(this.reloadToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.websiteToolStripMenuItem,
            this.githubToolStripMenuItem,
            this.discordToolStripMenuItem,
            this.toolStripSeparator1,
            this.climbeyMotionToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.aboutToolStripMenuItem.Text = "Vivecraft";
            // 
            // websiteToolStripMenuItem
            // 
            this.websiteToolStripMenuItem.Name = "websiteToolStripMenuItem";
            this.websiteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.websiteToolStripMenuItem.Tag = "http://www.vivecraft.org/";
            this.websiteToolStripMenuItem.Text = "Website";
            this.websiteToolStripMenuItem.Click += new System.EventHandler(this.websiteToolStripMenuItem_Click);
            // 
            // githubToolStripMenuItem
            // 
            this.githubToolStripMenuItem.Name = "githubToolStripMenuItem";
            this.githubToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.githubToolStripMenuItem.Tag = "https://github.com/jrbudda?tab=repositories&q=Vivecraft";
            this.githubToolStripMenuItem.Text = "Github";
            this.githubToolStripMenuItem.Click += new System.EventHandler(this.websiteToolStripMenuItem_Click);
            // 
            // discordToolStripMenuItem
            // 
            this.discordToolStripMenuItem.Name = "discordToolStripMenuItem";
            this.discordToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.discordToolStripMenuItem.Tag = "https://discord.gg/2x3QCk8qa9";
            this.discordToolStripMenuItem.Text = "Discord";
            this.discordToolStripMenuItem.Click += new System.EventHandler(this.websiteToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // climbeyMotionToolStripMenuItem
            // 
            this.climbeyMotionToolStripMenuItem.Name = "climbeyMotionToolStripMenuItem";
            this.climbeyMotionToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.climbeyMotionToolStripMenuItem.Tag = "http://www.vivecraft.org/climbeymotion/";
            this.climbeyMotionToolStripMenuItem.Text = "ClimbeyMotion";
            this.climbeyMotionToolStripMenuItem.Click += new System.EventHandler(this.websiteToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem1
            // 
            this.aboutToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.githubToolStripMenuItem1,
            this.checkForUpdatesToolStripMenuItem});
            this.aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
            this.aboutToolStripMenuItem1.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem1.Text = "About";
            // 
            // githubToolStripMenuItem1
            // 
            this.githubToolStripMenuItem1.Name = "githubToolStripMenuItem1";
            this.githubToolStripMenuItem1.Size = new System.Drawing.Size(170, 22);
            this.githubToolStripMenuItem1.Tag = "https://github.com/Bluscream/Universal-Vivecraft-Installer";
            this.githubToolStripMenuItem1.Text = "Github";
            this.githubToolStripMenuItem1.Click += new System.EventHandler(this.websiteToolStripMenuItem_Click);
            // 
            // checkForUpdatesToolStripMenuItem
            // 
            this.checkForUpdatesToolStripMenuItem.Name = "checkForUpdatesToolStripMenuItem";
            this.checkForUpdatesToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.checkForUpdatesToolStripMenuItem.Tag = "https://github.com/Bluscream/Universal-Vivecraft-Installer/releases";
            this.checkForUpdatesToolStripMenuItem.Text = "Check for updates";
            this.checkForUpdatesToolStripMenuItem.Click += new System.EventHandler(this.websiteToolStripMenuItem_Click);
            // 
            // status
            // 
            this.status.Location = new System.Drawing.Point(0, 489);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(965, 22);
            this.status.TabIndex = 4;
            this.status.Text = "statusStrip1";
            this.status.Visible = false;
            // 
            // getVivecraftAlphaBetaVersionsHereToolStripMenuItem
            // 
            this.getVivecraftAlphaBetaVersionsHereToolStripMenuItem.Name = "getVivecraftAlphaBetaVersionsHereToolStripMenuItem";
            this.getVivecraftAlphaBetaVersionsHereToolStripMenuItem.Size = new System.Drawing.Size(226, 20);
            this.getVivecraftAlphaBetaVersionsHereToolStripMenuItem.Tag = "https://discord.gg/rPcYtarABA";
            this.getVivecraftAlphaBetaVersionsHereToolStripMenuItem.Text = "Get Vivecraft Alpha / Beta versions here";
            this.getVivecraftAlphaBetaVersionsHereToolStripMenuItem.Click += new System.EventHandler(this.websiteToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 511);
            this.Controls.Add(this.status);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menu_main);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menu_main;
            this.Name = "MainForm";
            this.Text = "Universal Vivecraft Installer v2.0.2";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lst_versions)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bnd_versions)).EndInit();
            this.menu_main.ResumeLayout(false);
            this.menu_main.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView lst_versions;
        private System.Windows.Forms.RichTextBox txt_description;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btn_install;
        private System.Windows.Forms.Button btn_installvr;
        internal System.Windows.Forms.BindingSource bnd_versions;
        private System.Windows.Forms.Button btn_spigotserverplugin_install;
        private System.Windows.Forms.Button btn_forgeservermod_install;
        private System.Windows.Forms.MenuStrip menu_main;
        private System.Windows.Forms.ToolStripMenuItem reloadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem websiteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem githubToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem discordToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem climbeyMotionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem githubToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem checkForUpdatesToolStripMenuItem;
        private System.Windows.Forms.StatusStrip status;
        private System.Windows.Forms.ToolStripMenuItem getVivecraftAlphaBetaVersionsHereToolStripMenuItem;
    }
}

