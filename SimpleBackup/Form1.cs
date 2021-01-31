using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleBackup
{
    public partial class Form1 : Form
    {
        public string  externalDiscName;
        public bool isExternalDrive;
        public DialogResult autoSelectTarget;
        
        public Form1()
        {
            InitializeComponent();
            isExternalDrive = checkDrives();

            if (isExternalDrive)
            {
               autoSelectTarget = MessageBox.Show(
                    "Wir haben erkannt, dass Sie ein Externes Speichermedium angeschlossen haben. \n Möchten Sie dieses automatisch als Speicherort auswählen ?",
                    "wäschd beschäd", 
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );
               
               if (autoSelectTarget == DialogResult.Yes)
                   txt_tDir_cp.Text = externalDiscName;
               
               
            }
            Console.WriteLine("Drive {0}", autoSelectTarget);
            
        }

        private void bnt_sDir_Click(object sender, EventArgs e)
        {

            using(var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();
                var sDir = "";
                
                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    sDir = fbd.SelectedPath;
                    var files = Directory.GetFiles(fbd.SelectedPath);
                }
                
                this.txt_sDir_out.Text = sDir;
            }
        }

        private void bnt_tDir_Click(object sender, EventArgs e)
        {
            using(var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();
                var tDir = "";
                
                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    tDir = fbd.SelectedPath;
                    var files = Directory.GetFiles(fbd.SelectedPath);
                }
                
                this.txt_tDir_cp.Text = tDir;
            }
        }

        private void bnt_start_Click(object sender, EventArgs e)
        {
            var sDir = this.txt_sDir_out.Text;
            var tDir = this.txt_tDir_cp.Text;
            this.bnt_start.Enabled = false;
            
            this.errorHandler(sDir, tDir);
            createZipFromTarget(sDir, tDir);
            
            this.bnt_start.Enabled = true;
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

        private bool checkDrives()
        {
            DriveInfo[] allDrives = DriveInfo.GetDrives();
            var i = 0;
            var isPresent = false;
            string extDrive = "" ;
            
            foreach (DriveInfo d in allDrives)
            {
                if (d.DriveType.ToString() == "Removable")
                {
                    extDrive = d.Name;
                    isPresent = true;
                    i++;
                }
            }

            if (isPresent)
                this.externalDiscName = extDrive;

            return isPresent;
        }

        private void createZipFromTarget(string sDir, string tDir)
        {
            DateTime date       =  DateTime.Now;
            
            string startPath    = sDir;
            string zipName      = date.ToString("yyyy-MM-dd") + ".zip";
            string zipPath      = tDir + "\\" + zipName;
            string messageBody  = "Backup " + zipName + " wurde erfolgreich unter \n\n" + zipPath + "\n\n" +
                             "abgelegt. Viel Spaß weiterhin!";

            try
            {
                ZipFile.CreateFromDirectory(startPath, zipPath, CompressionLevel.Fastest, true);
                MessageBox.Show(
                    messageBody,
                    "TATATADDDDAAAAAA", 
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
                
            }
            catch (Exception e)
            {
                MessageBox.Show(
                    e.ToString(),
                    "WAT DA FACK", 
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                throw;
            }
        }
    }
}