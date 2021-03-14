using System;
using System.Windows.Forms;

namespace SimpleBackup
{
    public partial class settings : Form
    {
        private Label lblUsername;

        public settings()
        {
            InitializeComponent();
            
            // TODO: This attributes has to load from the settings 
            this.chbox.Text = "SwiftClient deaktiviert";
            this.txtPassword.Enabled = false;
            this.txtUsername.Enabled = false;

        }

        private void chbox_CheckedChanged(object sender, EventArgs e)
        {
            var chStatus = this.chbox.Checked;
            var txtPassStatus = this.txtPassword.Enabled;
            var txtUserStatus = this.txtUsername.Enabled;
            
            this.chbox.Text = chStatus == true ? "SwiftClient aktiviert" : "SwirftClient deaktiviert";
            this.txtPassword.Enabled = chStatus == true ? true : false;
            this.txtUsername.Enabled = chStatus == true ? true : false;


        }
    }
}