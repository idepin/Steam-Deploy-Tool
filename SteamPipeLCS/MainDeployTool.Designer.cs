
namespace SteamPipeLCS
{
    partial class MainDeployTool
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainDeployTool));
            this.label1 = new System.Windows.Forms.Label();
            this.txtAppId = new System.Windows.Forms.TextBox();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSteamSDK = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBrowseFolderBuildOutput = new System.Windows.Forms.Button();
            this.folderBrowserBuildOuputDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.btnGameBuildSourceChange = new System.Windows.Forms.Button();
            this.txtGameBuildSource = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDepotId = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnDepotIdChange = new System.Windows.Forms.Button();
            this.btnAppIdChange = new System.Windows.Forms.Button();
            this.txtVersion = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSteamAccount = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCreate = new System.Windows.Forms.Button();
            this.comboDeployType = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.steampipeBuild = new System.Windows.Forms.LinkLabel();
            this.label9 = new System.Windows.Forms.Label();
            this.comboSetLive = new System.Windows.Forms.ComboBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.serverSettingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F);
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(13, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "App Id";
            // 
            // txtAppId
            // 
            this.txtAppId.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtAppId.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList;
            this.txtAppId.Location = new System.Drawing.Point(16, 103);
            this.txtAppId.Name = "txtAppId";
            this.txtAppId.ReadOnly = true;
            this.txtAppId.Size = new System.Drawing.Size(316, 20);
            this.txtAppId.TabIndex = 1;
            this.txtAppId.Text = "1613860";
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(16, 199);
            this.txtDesc.Multiline = true;
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(397, 76);
            this.txtDesc.TabIndex = 4;
            this.txtDesc.Text = "Build Version 1.1.x";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F);
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(13, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Description";
            // 
            // txtSteamSDK
            // 
            this.txtSteamSDK.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtSteamSDK.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList;
            this.txtSteamSDK.Location = new System.Drawing.Point(16, 302);
            this.txtSteamSDK.Name = "txtSteamSDK";
            this.txtSteamSDK.ReadOnly = true;
            this.txtSteamSDK.Size = new System.Drawing.Size(316, 20);
            this.txtSteamSDK.TabIndex = 6;
            this.txtSteamSDK.Text = "C:\\sdk";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F);
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(13, 280);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Steam SDK";
            // 
            // btnBrowseFolderBuildOutput
            // 
            this.btnBrowseFolderBuildOutput.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnBrowseFolderBuildOutput.Location = new System.Drawing.Point(338, 300);
            this.btnBrowseFolderBuildOutput.Name = "btnBrowseFolderBuildOutput";
            this.btnBrowseFolderBuildOutput.Size = new System.Drawing.Size(75, 23);
            this.btnBrowseFolderBuildOutput.TabIndex = 7;
            this.btnBrowseFolderBuildOutput.Text = "Browse";
            this.btnBrowseFolderBuildOutput.UseVisualStyleBackColor = true;
            this.btnBrowseFolderBuildOutput.Click += new System.EventHandler(this.btnBrowseFolderBuildOutput_Click);
            // 
            // btnGameBuildSourceChange
            // 
            this.btnGameBuildSourceChange.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnGameBuildSourceChange.Location = new System.Drawing.Point(338, 353);
            this.btnGameBuildSourceChange.Name = "btnGameBuildSourceChange";
            this.btnGameBuildSourceChange.Size = new System.Drawing.Size(75, 23);
            this.btnGameBuildSourceChange.TabIndex = 13;
            this.btnGameBuildSourceChange.Text = "Browse";
            this.btnGameBuildSourceChange.UseVisualStyleBackColor = true;
            this.btnGameBuildSourceChange.Click += new System.EventHandler(this.btnGameBuildSourceChange_Click);
            // 
            // txtGameBuildSource
            // 
            this.txtGameBuildSource.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtGameBuildSource.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList;
            this.txtGameBuildSource.Location = new System.Drawing.Point(16, 355);
            this.txtGameBuildSource.Name = "txtGameBuildSource";
            this.txtGameBuildSource.ReadOnly = true;
            this.txtGameBuildSource.Size = new System.Drawing.Size(316, 20);
            this.txtGameBuildSource.TabIndex = 12;
            this.txtGameBuildSource.Text = "C:\\4Happy Data\\Export\\lmo-build";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F);
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(13, 333);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Game Build Source";
            // 
            // txtDepotId
            // 
            this.txtDepotId.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtDepotId.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList;
            this.txtDepotId.Location = new System.Drawing.Point(16, 153);
            this.txtDepotId.Name = "txtDepotId";
            this.txtDepotId.ReadOnly = true;
            this.txtDepotId.Size = new System.Drawing.Size(316, 20);
            this.txtDepotId.TabIndex = 15;
            this.txtDepotId.Text = "1613861";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9.75F);
            this.label6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label6.Location = new System.Drawing.Point(13, 131);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 16);
            this.label6.TabIndex = 14;
            this.label6.Text = "Depot Id";
            // 
            // btnDepotIdChange
            // 
            this.btnDepotIdChange.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnDepotIdChange.Location = new System.Drawing.Point(338, 151);
            this.btnDepotIdChange.Name = "btnDepotIdChange";
            this.btnDepotIdChange.Size = new System.Drawing.Size(75, 23);
            this.btnDepotIdChange.TabIndex = 16;
            this.btnDepotIdChange.Text = "Change";
            this.btnDepotIdChange.UseVisualStyleBackColor = true;
            this.btnDepotIdChange.Click += new System.EventHandler(this.btnDepotIdChange_Click);
            // 
            // btnAppIdChange
            // 
            this.btnAppIdChange.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnAppIdChange.Location = new System.Drawing.Point(338, 101);
            this.btnAppIdChange.Name = "btnAppIdChange";
            this.btnAppIdChange.Size = new System.Drawing.Size(75, 23);
            this.btnAppIdChange.TabIndex = 17;
            this.btnAppIdChange.Text = "Change";
            this.btnAppIdChange.UseVisualStyleBackColor = true;
            this.btnAppIdChange.Click += new System.EventHandler(this.btnAppIdChange_Click);
            // 
            // txtVersion
            // 
            this.txtVersion.AutoSize = true;
            this.txtVersion.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            this.txtVersion.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.txtVersion.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtVersion.Location = new System.Drawing.Point(316, 38);
            this.txtVersion.Name = "txtVersion";
            this.txtVersion.Size = new System.Drawing.Size(30, 14);
            this.txtVersion.TabIndex = 18;
            this.txtVersion.Text = "v.1.1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 8.25F);
            this.label7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label7.Location = new System.Drawing.Point(12, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(184, 14);
            this.label7.TabIndex = 19;
            this.label7.Text = "Developed by Idepin - 4Happy Studio";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.label7);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 576);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(437, 55);
            this.panel1.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(104, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(214, 23);
            this.label4.TabIndex = 23;
            this.label4.Text = "SteamPipe Deploy Tool";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txtVersion);
            this.panel2.Controls.Add(this.menuStrip1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(437, 78);
            this.panel2.TabIndex = 24;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSettings,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(437, 24);
            this.menuStrip1.TabIndex = 24;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripSettings
            // 
            this.toolStripSettings.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.toolStripSettings.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSteamAccount,
            this.serverSettingToolStripMenuItem});
            this.toolStripSettings.Name = "toolStripSettings";
            this.toolStripSettings.Size = new System.Drawing.Size(61, 20);
            this.toolStripSettings.Text = "Settings";
            // 
            // toolStripSteamAccount
            // 
            this.toolStripSteamAccount.Name = "toolStripSteamAccount";
            this.toolStripSteamAccount.Size = new System.Drawing.Size(180, 22);
            this.toolStripSteamAccount.Text = "Steam Account";
            this.toolStripSteamAccount.Click += new System.EventHandler(this.toolStripSteamAccount_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnCreate.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCreate.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnCreate.Location = new System.Drawing.Point(16, 455);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(397, 46);
            this.btnCreate.TabIndex = 2;
            this.btnCreate.Text = "Deploy";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnDeploy_Click);
            // 
            // comboDeployType
            // 
            this.comboDeployType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboDeployType.FormattingEnabled = true;
            this.comboDeployType.Items.AddRange(new object[] {
            "Local",
            "Online"});
            this.comboDeployType.Location = new System.Drawing.Point(16, 415);
            this.comboDeployType.Name = "comboDeployType";
            this.comboDeployType.Size = new System.Drawing.Size(118, 21);
            this.comboDeployType.TabIndex = 25;
            this.comboDeployType.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 9.75F);
            this.label8.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label8.Location = new System.Drawing.Point(13, 388);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 16);
            this.label8.TabIndex = 26;
            this.label8.Text = "Deploy Type";
            // 
            // steampipeBuild
            // 
            this.steampipeBuild.AutoSize = true;
            this.steampipeBuild.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.steampipeBuild.Location = new System.Drawing.Point(13, 554);
            this.steampipeBuild.Name = "steampipeBuild";
            this.steampipeBuild.Size = new System.Drawing.Size(88, 13);
            this.steampipeBuild.TabIndex = 27;
            this.steampipeBuild.TabStop = true;
            this.steampipeBuild.Text = "Steampipe Builds";
            this.steampipeBuild.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.steampipeBuild_LinkClicked);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 9.75F);
            this.label9.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label9.Location = new System.Drawing.Point(219, 388);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(193, 16);
            this.label9.TabIndex = 29;
            this.label9.Text = "Set Live on non-Default Branch :";
            // 
            // comboSetLive
            // 
            this.comboSetLive.FormattingEnabled = true;
            this.comboSetLive.Items.AddRange(new object[] {
            "alpha"});
            this.comboSetLive.Location = new System.Drawing.Point(295, 415);
            this.comboSetLive.Name = "comboSetLive";
            this.comboSetLive.Size = new System.Drawing.Size(118, 21);
            this.comboSetLive.TabIndex = 30;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::SteamPipeLCS.Properties.Resources.Steam_icon_logo_svg;
            this.pictureBox2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox2.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.InitialImage")));
            this.pictureBox2.Location = new System.Drawing.Point(301, 517);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(31, 31);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 22;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SteamPipeLCS.Properties.Resources.Logo_4Happy_Studio_Berwarna;
            this.pictureBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(338, 517);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(75, 31);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // serverSettingToolStripMenuItem
            // 
            this.serverSettingToolStripMenuItem.Name = "serverSettingToolStripMenuItem";
            this.serverSettingToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.serverSettingToolStripMenuItem.Text = "Server Setting";
            this.serverSettingToolStripMenuItem.Click += new System.EventHandler(this.serverSettingToolStripMenuItem_Click);
            // 
            // MainDeployTool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 631);
            this.Controls.Add(this.comboSetLive);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.steampipeBuild);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.comboDeployType);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnAppIdChange);
            this.Controls.Add(this.btnDepotIdChange);
            this.Controls.Add(this.txtDepotId);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnGameBuildSourceChange);
            this.Controls.Add(this.txtGameBuildSource);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnBrowseFolderBuildOutput);
            this.Controls.Add(this.txtSteamSDK);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDesc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.txtAppId);
            this.Controls.Add(this.label1);
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MainDeployTool";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SteamPipe LCS Deploy Tool";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainDeployTool_FormClosing);
            this.Load += new System.EventHandler(this.MainDeployTool_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAppId;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSteamSDK;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnBrowseFolderBuildOutput;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserBuildOuputDialog;
        private System.Windows.Forms.Button btnGameBuildSourceChange;
        private System.Windows.Forms.TextBox txtGameBuildSource;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDepotId;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnDepotIdChange;
        private System.Windows.Forms.Button btnAppIdChange;
        private System.Windows.Forms.Label txtVersion;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox comboDeployType;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.LinkLabel steampipeBuild;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboSetLive;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripSettings;
        private System.Windows.Forms.ToolStripMenuItem toolStripSteamAccount;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serverSettingToolStripMenuItem;
    }
}

