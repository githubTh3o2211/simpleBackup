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
        public string get_uName;
        public string get_uPassword;
        public string get_uSwiftAcitve;
        public IEnumerable<XElement> get_uEndpoints;

        public void getXMLsettings()
        {
            this.loadXMLconfig();

            IEnumerable<string> uPassword    =  from item in uSettings.Descendants("password")
                select (string) item.Value;
            IEnumerable<string> uName        = from item in uSettings.Descendants("user")
                select (string) item.Value;
            IEnumerable<string> uSwiftActive = from item in uSettings.Descendants("swiftEnables")
                select (string) item.Value;
            IEnumerable<XElement> uEndpoints = from item in uSettings.Descendants("point") select item;

            this.get_uPassword  = uPassword.FirstOrDefault();
            this.get_uName      = uName.FirstOrDefault();
            this.get_uSwiftAcitve = uSwiftActive.FirstOrDefault();
            this.get_uEndpoints =  uEndpoints;
            
        }
        
        public settings(bool eMode=false)
        {
            if (!eMode)
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
                IEnumerable<XElement> uEndpoints = from item in uSettings.Descendants("point") select item;


                foreach (var e in uEndpoints)
                {
                    listEndpoints.Items.Add(e.Value);
                }
                var swiftBox = uSwiftActive.FirstOrDefault();
                var sBool = swiftBox != "false";
                
                /*
                 * checks if box is check and thrown a waring for user
                 */
                this.costAlert(sBool);
                
                
                /*
                 * Settings form values load from LINQ result
                 */
                this.chbox.Text             = sBool ? "SwiftClient aktiviert" : "SwiftClient deaktiviert";
                this.chbox.Checked          = sBool;
                this.txtPassword.Enabled    = sBool;
                this.bntDel.Enabled         = sBool;
                this.bntAdd.Enabled         = sBool;
                this.txtPassword.Text       = uPassword.FirstOrDefault();
                this.txtUsername.Text       = uName.FirstOrDefault();
                this.txtUsername.Enabled    = sBool;
                this.listEndpoints.Enabled  = sBool;
            
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
            XElement configFile = new XElement(
                "swiftConfig",
                new XElement("user", "default"),
                new XElement("password", "default"),
                new XElement("swiftEnables", "false"),
                new XElement("Endpoints",
                    new XElement("point", "storage.de1.cloud.ovh.net")
                    )
            );
            
            configFile.Save(configPath); 
        }
        
        private void chbox_CheckedChanged(object sender, EventArgs e)
        {
            var chStatus = this.chbox.Checked;
            var txtPassStatus = this.txtPassword.Enabled;
            var txtUserStatus = this.txtUsername.Enabled;

            this.costAlert(chStatus);
            
            this.chbox.Text = chStatus == true ? "SwiftClient aktiviert" : "SwiftClient deaktiviert";

            this.txtPassword.Enabled    = chStatus;
            this.txtUsername.Enabled    = chStatus;
            this.listEndpoints.Enabled  = chStatus;
            this.bntAdd.Enabled         = chStatus;
            this.bntDel.Enabled         = chStatus;
            


        }

        public void costAlert(bool chBox)
        {
            if (chBox)
            {
                string messageBody = "Bitte beachten Sie, dass beim aktivieren dieser option zusätzliche Kosten beim  " + 
                                     "Storageanbieter entstehenentstehen!";
                
                MessageBox.Show(
                    messageBody,
                    "Warnung",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
            }
        }
    }
}