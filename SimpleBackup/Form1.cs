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
                    "Error", 
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );
            }
            Console.WriteLine("Drive {0}", autoSelectTarget);
            
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

        private bool checkDrives()
        {
            DriveInfo[] allDrives = DriveInfo.GetDrives();
            var i = 0;
            var isPresent = false;
            string[] extDrive = new string[10] ;
            
            foreach (DriveInfo d in allDrives)
            {
                if (d.DriveType.ToString() == "Removable")
                {
                    extDrive[i] = d.Name;
                    isPresent = true;
                    i++;
                }
            }

            if (isPresent)
                this.externalDiscName = extDrive;

            return isPresent;
        }
    }
}