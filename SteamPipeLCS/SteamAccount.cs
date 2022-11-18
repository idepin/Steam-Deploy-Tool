using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SteamPipeLCS
{
    public partial class SteamAccount : Form
    {
        public SteamAccount()
        {
            InitializeComponent();
        }

        private void SteamAccount_Load(object sender, EventArgs e)
        {
            txtUsername.Text = Properties.Settings.Default.username;
            txtPassword.Text = Properties.Settings.Default.password;
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.username = txtUsername.Text;
            Properties.Settings.Default.password = txtPassword.Text;
            Properties.Settings.Default.Save();
            Dispose();
        }
    }
}
