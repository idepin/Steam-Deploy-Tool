using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace SteamPipeLCS
{
    public partial class ServerSetting : Form
    {
        public ServerSetting()
        {
            InitializeComponent();
        }

        private void btnCreateConfig_Click(object sender, EventArgs e)
        {
            CreateConfig();
            Dispose();
        }

        private void CreateConfig()
        {
            string configPath = txtSteamPath.Text + "\\steam_dev.cfg";
            string content = "@LocalContentServer " + txtIP.Text;

            if (!File.Exists(configPath)) // If file does not exists
            {
                File.Create(configPath).Close(); // Create file
                using (StreamWriter sw = File.AppendText(configPath))
                {
                    sw.WriteLine(content); // Write text to file
                }
            }
            else // If file already exists
            {
                File.WriteAllText(configPath, String.Empty); // Clear file
                using (StreamWriter sw = File.AppendText(configPath))
                {
                    sw.WriteLine(content); // Write text to file
                }
            }
        }

        private void btnGameBuildSourceChange_Click(object sender, EventArgs e)
        {
            steamInstallationfolderBrowserDialog.SelectedPath = txtSteamPath.Text;
            steamInstallationfolderBrowserDialog.ShowDialog();
            txtSteamPath.Text = steamInstallationfolderBrowserDialog.SelectedPath;
            
        }


        private void btnSetMyIP_Click(object sender, EventArgs e)
        {
            txtIP.Text = GetLocalIPAddress();
        }

        public string GetLocalIPAddress()
        {
            var host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (var ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    if(txtIP.Text != ip.ToString())
                    {
                        return ip.ToString();
                    }
                }
            }
            throw new Exception("No network adapters with an IPv4 address in the system!");
        }

        private void btnSkip_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void ServerSetting_Load(object sender, EventArgs e)
        {
            CheckSteamCfg();
            txtIP.Text = GetLocalIPAddress();
        }

        private void CheckSteamCfg()
        {
            string configPath = txtSteamPath.Text + "\\steam_dev.cfg";

            if (File.Exists(configPath)) // If file exists
            {
                txtStatus.Text = "Steam_dev.cfg already exists";
                txtStatus.ForeColor = Color.Green;
            }
            else
            {
                txtStatus.Text = "Steam_dev.cfg not found";
                txtStatus.ForeColor = Color.Red;
            }
        }

        private void txtSteamPath_TextChanged(object sender, EventArgs e)
        {
            CheckSteamCfg();
        }
    }
}
