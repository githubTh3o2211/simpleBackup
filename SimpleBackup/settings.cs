using System;
using System.IO;
using System.Windows.Forms;
using System.Xml.Linq;

namespace SimpleBackup
{
    public partial class settings : Form
    {
        private Label lblUsername;
        private XElement uSettings;

        public settings()
        {
            InitializeComponent();
            this.loadXMLconfig();
            
            // TODO: This attributes has to load from the settings 
            
            
            this.chbox.Text = "SwiftClient deaktiviert";
            this.txtPassword.Enabled = false;
            this.txtPassword.Text = uSettings.Element("password").ToString();
            this.txtUsername.Enabled = false;
            this.listEndpoints.Enabled = false;
            
            if (listEndpoints.Items.Count <= 0 )
            {
                listEndpoints.Items.Add("none");
            }

        }

        private void loadXMLconfig()
        {
            var settingsFile = "userconfig.config.xml";
            var currentDir = Directory.GetCurrentDirectory();
            var configFilePath = Path.Combine(currentDir, settingsFile);
            
            if (!File.Exists(configFilePath))
                this.createXMLconfig(configFilePath);

            uSettings = XElement.Load(configFilePath);

        }
        
        private void createXMLconfig(string configPath)
        {
            //File.Create(configPath);

            XElement configFile = new XElement(
                "swiftConfig",
                new XElement("user", "default"),
                new XElement("password", "default"),
                new XElement("swiftEnables", "false"),
                new XElement("Endpoints",
                    new XElement("DE", "storage.de1.cloud.ovh.net")
                    )
            );
            
            configFile.Save(configPath); 
        }
        
        private void chbox_CheckedChanged(object sender, EventArgs e)
        {
            var chStatus = this.chbox.Checked;
            var txtPassStatus = this.txtPassword.Enabled;
            var txtUserStatus = this.txtUsername.Enabled;
            
            this.chbox.Text = chStatus == true ? "SwiftClient aktiviert" : "SwirftClient deaktiviert";
            
            this.txtPassword.Enabled = chStatus == true ? true : false;
            this.txtUsername.Enabled = chStatus == true ? true : false;
            this.listEndpoints.Enabled = chStatus == true ? true : false;
            


        }
    }
}