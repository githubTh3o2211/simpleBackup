using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleBackup
{
    public partial class Form1 : Form
    {
        public string[]  externalDiscName; 
        
        public Form1()
        {
            InitializeComponent();
            this.checkDrives();
        }

        private void bnt_sDir_Click(object sender, EventArgs e)
        {

            using(var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();
                var sDir = "C:\\";
                
                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    sDir = fbd.SelectedPath;
                    var files = Directory.GetFiles(fbd.SelectedPath);
                    
                    // System.Windows.Forms.MessageBox.Show("Files found: " + files.Length.ToString(), "Message");
                }
                
                this.txt_sDir_out.Text = sDir;
            }
        }

        private void bnt_tDir_Click(object sender, EventArgs e)
        {
            using(var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();
                var tDir = "C:\\";
                
                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    tDir = fbd.SelectedPath;
                    var files = Directory.GetFiles(fbd.SelectedPath);
                    
                    // System.Windows.Forms.MessageBox.Show("Files found: " + files.Length.ToString(), "Message");
                }
                
                this.txt_tDir_cp.Text = tDir;
            }
        }

        private void bnt_start_Click(object sender, EventArgs e)
        {
            var sDir = this.txt_sDir_out.Text;
            var tDir = this.txt_tDir_cp.Text;
            
            this.errorHandler(sDir, tDir);

        }

        private void errorHandler(string sDir, string tDir, string option = "DIR")
        {
            switch (option)
            {
                case "DIR" :
                    if (!Directory.Exists(sDir) || !Directory.Exists(tDir) ) 
                        MessageBox.Show(
                            "Bitte wählen Sie ein Ziel und Start Verzeichnis aus",
                            "Error", 
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error
                        );
                    if (sDir == tDir)
                        MessageBox.Show(
                            "Ziel und Startverzeichnis dürfen nicht idetisch sein",
                            "Error", 
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error
                        );
                    
                    break;
                case "FILE":
                    break;
            }
        }

        private void checkDrives()
        {
            DriveInfo[] allDrives = DriveInfo.GetDrives();
            int i = 0;
            
            foreach (DriveInfo d in allDrives)
            {
                if (d.DriveType.ToString() == "Removable")
                {
                    this.externalDiscName[i] = d.Name;
                    i++;
                }
                
                Console.WriteLine("Drive {0}, Type {1}", d.Name, d.DriveType);
            }
        }
    }
}