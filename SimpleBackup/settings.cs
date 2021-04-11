using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
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

            /*
             * Get XML values to load into the form 
             */
            IEnumerable<string> uPassword    =  from item in uSettings.Descendants("password") 
                                                select (string) item.Value;
            IEnumerable<string> uName        = from item in uSettings.Descendants("user")
                                                select (string) item.Value;
            IEnumerable<string> uSwiftActive = from item in uSettings.Descendants("swiftEnables")
                                                select (string) item.Value;

            var swiftBox = uSwiftActive.FirstOrDefault(); 
            
            this.chbox.Text             = "SwiftClient deaktiviert";
            this.chbox.Checked          = swiftBox != "false";
            this.txtPassword.Enabled    = swiftBox != "false";
            this.txtPassword.Text       = uPassword.FirstOrDefault();
            this.txtUsername.Text       = uName.FirstOrDefault();
            this.txtUsername.Enabled    = swiftBox != "false";
            this.listEndpoints.Enabled  = swiftBox != "false";
            
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