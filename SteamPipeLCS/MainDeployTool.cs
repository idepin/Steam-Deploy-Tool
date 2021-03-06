using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace SteamPipeLCS
{
    public partial class MainDeployTool : Form
    {
        public MainDeployTool()
        {
            InitializeComponent();
            comboDeployType.SelectedIndex = 0;
        }
        public string script_template, depotConfig;

        private void label2_Click(object sender, EventArgs e)
        {

        }
        #region Browse Folder
        private void btnBrowseFolderBuildOutput_Click(object sender, EventArgs e)
        {
            folderBrowserBuildOuputDialog.SelectedPath = txtSteamSDK.Text;
            folderBrowserBuildOuputDialog.ShowDialog();
            txtSteamSDK.Text = folderBrowserBuildOuputDialog.SelectedPath;
        }


        private void btnGameBuildSourceChange_Click(object sender, EventArgs e)
        {
            folderBrowserBuildOuputDialog.SelectedPath = txtGameBuildSource.Text;
            folderBrowserBuildOuputDialog.ShowDialog();
            txtGameBuildSource.Text = folderBrowserBuildOuputDialog.SelectedPath;
        }
        #endregion

        private void btnDepotIdChange_Click(object sender, EventArgs e)
        {
            if (txtDepotId.ReadOnly)
            {
                txtDepotId.ReadOnly = false;
                btnDepotIdChange.Text = "Apply";
            }
            else
            {
                txtDepotId.ReadOnly = true;
                btnDepotIdChange.Text = "Change";
            }
            
        }

        private void btnAppIdChange_Click(object sender, EventArgs e)
        {
            if (txtAppId.ReadOnly)
            {
                txtAppId.ReadOnly = false;
                btnAppIdChange.Text = "Apply";
            }
            else
            {
                txtAppId.ReadOnly = true;
                btnAppIdChange.Text = "Change";
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if(comboDeployType.SelectedIndex == 0)
            {
                InitAppBuildScript(true);
                InitDepotConfig();
                CreateScript("app_build_" + txtAppId.Text + "_Local.vdf", script_template);
                CreateScript("depot_" + txtDepotId.Text + ".vdf", depotConfig);
            }
            else
            {
                InitAppBuildScript(false);
                InitDepotConfig();
                CreateScript("app_build_" + txtAppId.Text + "_Online.vdf", script_template);
                CreateScript("depot_" + txtDepotId.Text + ".vdf", depotConfig);
            }
            
        }

        

        private void Deploy(string scriptPath)
        {
            var p = new ProcessStartInfo();
            p.UseShellExecute = true;
            p.FileName = txtSteamSDK.Text + @"\tools\ContentBuilder\builder\steamcmd.exe";
            p.Arguments = "+login "+Properties.Settings.Default.username+" "+Properties.Settings.Default.password+" +run_app_build " + scriptPath;
            Process.Start(p);
        }
        private void InitAppBuildScript(bool isLocal)
        {
            string local;
            if (isLocal)
            {
                local = txtSteamSDK.Text + "\\tools\\ContentServer\\htdocs";
            }
            else
            {
                local = "";
            }
            
            script_template = "\"appbuild\"" +
            "\n{\n" +
            "\t\"appid\" \"" + txtAppId.Text + "\"\n" +
            "\t\"desc\" \"" + txtDesc.Text + "\"\n" +
            "\t\"buildoutput\" \"" + txtSteamSDK.Text + "\\tools\\ContentBuilder\\output" + "\"\n" +
            "\t\"contentroot\" \"" + "" + "\"\n" +
            "\t\"setlive\" \"" + comboSetLive.Text + "\"\n" +
            "\t\"preview\" \"" + "0" + "\"\n" +
            "\t\"local\" \"" + local + "\"\n" +
            "\t\"depots\"\n" +
            "\t{\n" +
            "\t\t\"" + txtDepotId.Text + "\"\t\"" + "C:\\sdk\\tools\\ContentBuilder\\scripts\\depot_" + txtDepotId.Text + ".vdf" + "\"" +
            "\n\t}\n" +
            "}\n";
        }
        private void InitDepotConfig()
        {
            depotConfig = "\"DepotBuildConfig\"" +
            "\n{\n" +
            "\t\"DepotID\" \"" + txtDepotId.Text + "\"\n" +
            "\t\"contentroot\" \"" + txtGameBuildSource.Text + "\"\n" +
            "\t\"FileMapping\"\n" +
            "\t{\n" +
            "\t\t\"LocalPath\" \"*\"\n"+
            "\t\t\"DepotPath\" \".\"\n" +
            "\t\t\"recursive\" \"1\"\n" +
            "\t}\n" +
            "\t\"FileExclusion\" \"" + "*.pdb\"\n"+
            "}\n";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboDeployType.SelectedIndex == 0)
            {
                comboSetLive.Text = "";
                comboSetLive.Enabled = false;
            }
            else
            {
                comboSetLive.Enabled = true;
            }
        }

        private void steampipeBuild_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Specify that the link was visited.
            steampipeBuild.LinkVisited = true;

            // Navigate to a URL.
            Process.Start("https://partner.steamgames.com/apps/builds/"+txtAppId.Text);
        }

        private void toolStripSteamAccount_Click(object sender, EventArgs e)
        {
            SteamAccount steamAccount = new SteamAccount();
            steamAccount.ShowDialog();
        }

        private void MainDeployTool_Load(object sender, EventArgs e)
        {
            if(Properties.Settings.Default.username == "")
            {
                SteamAccount steamAccount = new SteamAccount();
                steamAccount.ShowDialog();
            }
        }

        private void CreateScript(string path, string content)
        {
            string scriptPath = txtSteamSDK.Text + "\\tools\\ContentBuilder\\scripts\\";

            scriptPath = Path.Combine(scriptPath, path);
            if (!File.Exists(scriptPath)) // If file does not exists
            {
                File.Create(scriptPath).Close(); // Create file
                using (StreamWriter sw = File.AppendText(scriptPath))
                {
                    sw.WriteLine(content); // Write text to .txt file
                    if (path.Contains("app_build"))
                    {
                        Deploy(scriptPath);
                    }
                }
            }
            else // If file already exists
            {
                File.WriteAllText(scriptPath, String.Empty); // Clear file
                using (StreamWriter sw = File.AppendText(scriptPath))
                {
                    sw.WriteLine(content); // Write text to .txt file
                    if (path.Contains("app_build"))
                    {
                        Deploy(scriptPath);
                    }
                }
            }
        }


    }
}
