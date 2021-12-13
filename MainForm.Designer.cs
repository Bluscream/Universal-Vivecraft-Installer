
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
            this.btn_install = new System.Windows.Forms.Button();
            this.btn_installvr = new System.Windows.Forms.Button();
            this.bnd_versions = new System.Windows.Forms.BindingSource(this.components);
            this.btn_dlforge = new System.Windows.Forms.Button();
            this.btn_dlspigot = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.lst_versions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bnd_versions)).BeginInit();
            this.SuspendLayout();
            // 
            // lst_versions
            // 
            this.lst_versions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lst_versions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lst_versions.Location = new System.Drawing.Point(0, 0);
            this.lst_versions.MultiSelect = false;
            this.lst_versions.Name = "lst_versions";
            this.lst_versions.ReadOnly = true;
            this.lst_versions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.lst_versions.Size = new System.Drawing.Size(321, 450);
            this.lst_versions.TabIndex = 0;
            this.lst_versions.SelectionChanged += new System.EventHandler(this.lst_versions_SelectionChanged);
            // 
            // txt_description
            // 
            this.txt_description.Dock = System.Windows.Forms.DockStyle.Top;
            this.txt_description.Location = new System.Drawing.Point(0, 0);
            this.txt_description.Name = "txt_description";
            this.txt_description.Size = new System.Drawing.Size(475, 413);
            this.txt_description.TabIndex = 1;
            this.txt_description.Text = "";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.lst_versions);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.btn_dlspigot);
            this.splitContainer1.Panel2.Controls.Add(this.btn_dlforge);
            this.splitContainer1.Panel2.Controls.Add(this.btn_install);
            this.splitContainer1.Panel2.Controls.Add(this.btn_installvr);
            this.splitContainer1.Panel2.Controls.Add(this.txt_description);
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 321;
            this.splitContainer1.TabIndex = 2;
            // 
            // btn_install
            // 
            this.btn_install.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_install.Enabled = false;
            this.btn_install.Location = new System.Drawing.Point(279, 419);
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
            this.btn_installvr.Location = new System.Drawing.Point(374, 419);
            this.btn_installvr.Name = "btn_installvr";
            this.btn_installvr.Size = new System.Drawing.Size(89, 23);
            this.btn_installvr.TabIndex = 2;
            this.btn_installvr.Text = "Install VR";
            this.btn_installvr.UseVisualStyleBackColor = true;
            this.btn_installvr.Click += new System.EventHandler(this.btn_installvr_Click);
            // 
            // btn_dlforge
            // 
            this.btn_dlforge.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_dlforge.Enabled = false;
            this.btn_dlforge.Location = new System.Drawing.Point(3, 419);
            this.btn_dlforge.Name = "btn_dlforge";
            this.btn_dlforge.Size = new System.Drawing.Size(58, 23);
            this.btn_dlforge.TabIndex = 4;
            this.btn_dlforge.Text = "Forge";
            this.btn_dlforge.UseVisualStyleBackColor = true;
            this.btn_dlforge.Click += new System.EventHandler(this.btn_dlforge_Click);
            // 
            // btn_dlspigot
            // 
            this.btn_dlspigot.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_dlspigot.Enabled = false;
            this.btn_dlspigot.Location = new System.Drawing.Point(67, 419);
            this.btn_dlspigot.Name = "btn_dlspigot";
            this.btn_dlspigot.Size = new System.Drawing.Size(58, 23);
            this.btn_dlspigot.TabIndex = 5;
            this.btn_dlspigot.Text = "Spigot";
            this.btn_dlspigot.UseVisualStyleBackColor = true;
            this.btn_dlspigot.Click += new System.EventHandler(this.btn_dlspigot_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Universal Vivecraft Installer";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lst_versions)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bnd_versions)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView lst_versions;
        private System.Windows.Forms.RichTextBox txt_description;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btn_install;
        private System.Windows.Forms.Button btn_installvr;
        internal System.Windows.Forms.BindingSource bnd_versions;
        private System.Windows.Forms.Button btn_dlspigot;
        private System.Windows.Forms.Button btn_dlforge;
    }
}

