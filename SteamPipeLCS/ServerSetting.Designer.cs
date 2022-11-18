namespace SteamPipeLCS
{
    partial class ServerSetting
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
            this.label3 = new System.Windows.Forms.Label();
            this.btnApply = new System.Windows.Forms.Button();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.btnGameBuildSourceChange = new System.Windows.Forms.Button();
            this.txtSteamPath = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.steamInstallationfolderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.btnSetMyIP = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSkip = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtStatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(31, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 19);
            this.label3.TabIndex = 9;
            this.label3.Text = "Local Server Setting";
            // 
            // btnApply
            // 
            this.btnApply.BackColor = System.Drawing.SystemColors.GrayText;
            this.btnApply.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApply.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnApply.Location = new System.Drawing.Point(35, 263);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(397, 44);
            this.btnApply.TabIndex = 8;
            this.btnApply.Text = "Create Config File";
            this.btnApply.UseVisualStyleBackColor = false;
            this.btnApply.Click += new System.EventHandler(this.btnCreateConfig_Click);
            // 
            // txtIP
            // 
            this.txtIP.Location = new System.Drawing.Point(35, 226);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(316, 20);
            this.txtIP.TabIndex = 7;
            this.txtIP.Text = "192.168.0.5";
            // 
            // btnGameBuildSourceChange
            // 
            this.btnGameBuildSourceChange.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnGameBuildSourceChange.Location = new System.Drawing.Point(357, 160);
            this.btnGameBuildSourceChange.Name = "btnGameBuildSourceChange";
            this.btnGameBuildSourceChange.Size = new System.Drawing.Size(75, 23);
            this.btnGameBuildSourceChange.TabIndex = 16;
            this.btnGameBuildSourceChange.Text = "Browse";
            this.btnGameBuildSourceChange.UseVisualStyleBackColor = true;
            this.btnGameBuildSourceChange.Click += new System.EventHandler(this.btnGameBuildSourceChange_Click);
            // 
            // txtSteamPath
            // 
            this.txtSteamPath.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtSteamPath.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList;
            this.txtSteamPath.Location = new System.Drawing.Point(35, 162);
            this.txtSteamPath.Name = "txtSteamPath";
            this.txtSteamPath.ReadOnly = true;
            this.txtSteamPath.Size = new System.Drawing.Size(316, 20);
            this.txtSteamPath.TabIndex = 15;
            this.txtSteamPath.Text = "C:\\Program Files (x86)\\Steam";
            this.txtSteamPath.TextChanged += new System.EventHandler(this.txtSteamPath_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F);
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(32, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 16);
            this.label5.TabIndex = 14;
            this.label5.Text = "Steam Installation Path";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F);
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(32, 207);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 16);
            this.label1.TabIndex = 17;
            this.label1.Text = "Server IP Address";
            // 
            // btnSetMyIP
            // 
            this.btnSetMyIP.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSetMyIP.Location = new System.Drawing.Point(357, 224);
            this.btnSetMyIP.Name = "btnSetMyIP";
            this.btnSetMyIP.Size = new System.Drawing.Size(75, 23);
            this.btnSetMyIP.TabIndex = 18;
            this.btnSetMyIP.Text = "Set my IP";
            this.btnSetMyIP.UseVisualStyleBackColor = true;
            this.btnSetMyIP.Click += new System.EventHandler(this.btnSetMyIP_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 8.75F);
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(32, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 15);
            this.label2.TabIndex = 19;
            // 
            // btnSkip
            // 
            this.btnSkip.BackColor = System.Drawing.SystemColors.Control;
            this.btnSkip.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSkip.Location = new System.Drawing.Point(35, 313);
            this.btnSkip.Name = "btnSkip";
            this.btnSkip.Size = new System.Drawing.Size(397, 25);
            this.btnSkip.TabIndex = 20;
            this.btnSkip.Text = "Skip";
            this.btnSkip.UseVisualStyleBackColor = false;
            this.btnSkip.Click += new System.EventHandler(this.btnSkip_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(32, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(303, 30);
            this.label4.TabIndex = 21;
            this.label4.Text = "Here are some requirements for local content servers, \r\nwe have to create a confi" +
    "g file for Steam first";
            // 
            // txtStatus
            // 
            this.txtStatus.AutoSize = true;
            this.txtStatus.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStatus.ForeColor = System.Drawing.SystemColors.Desktop;
            this.txtStatus.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtStatus.Location = new System.Drawing.Point(32, 97);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(126, 15);
            this.txtStatus.TabIndex = 22;
            this.txtStatus.Text = "Config File Not Found";
            // 
            // ServerSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 361);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnSkip);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSetMyIP);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGameBuildSourceChange);
            this.Controls.Add(this.txtSteamPath);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.txtIP);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ServerSetting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ServerSetting";
            this.Load += new System.EventHandler(this.ServerSetting_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.Button btnGameBuildSourceChange;
        private System.Windows.Forms.TextBox txtSteamPath;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FolderBrowserDialog steamInstallationfolderBrowserDialog;
        private System.Windows.Forms.Button btnSetMyIP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSkip;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label txtStatus;
    }
}