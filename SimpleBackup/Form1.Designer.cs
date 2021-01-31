namespace SimpleBackup
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lbl_explain = new System.Windows.Forms.Label();
            this.bnt_sDir = new System.Windows.Forms.Button();
            this.txt_sDir_out = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_tDir_cp = new System.Windows.Forms.TextBox();
            this.bnt_tDir = new System.Windows.Forms.Button();
            this.bnt_start = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_explain
            // 
            this.lbl_explain.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_explain.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lbl_explain.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_explain.Location = new System.Drawing.Point(3, 16);
            this.lbl_explain.Name = "lbl_explain";
            this.lbl_explain.Size = new System.Drawing.Size(541, 23);
            this.lbl_explain.TabIndex = 0;
            this.lbl_explain.Text = "Bitte wählen Sie ein verzeichnes aus, von dem ein Backup erstellt werden soll.";
            // 
            // bnt_sDir
            // 
            this.bnt_sDir.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.bnt_sDir.ForeColor = System.Drawing.SystemColors.InfoText;
            this.bnt_sDir.Location = new System.Drawing.Point(6, 64);
            this.bnt_sDir.Name = "bnt_sDir";
            this.bnt_sDir.Size = new System.Drawing.Size(75, 20);
            this.bnt_sDir.TabIndex = 1;
            this.bnt_sDir.Text = "...";
            this.bnt_sDir.UseVisualStyleBackColor = true;
            this.bnt_sDir.Click += new System.EventHandler(this.bnt_sDir_Click);
            // 
            // txt_sDir_out
            // 
            this.txt_sDir_out.Enabled = false;
            this.txt_sDir_out.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.txt_sDir_out.Location = new System.Drawing.Point(87, 65);
            this.txt_sDir_out.Name = "txt_sDir_out";
            this.txt_sDir_out.Size = new System.Drawing.Size(454, 20);
            this.txt_sDir_out.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(3, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(541, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Bitten wählen Sie das Zielverzeichnis aus, indem das Backup gespeichert werden so" + "ll";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_explain);
            this.groupBox1.Controls.Add(this.bnt_sDir);
            this.groupBox1.Controls.Add(this.txt_sDir_out);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Info;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(547, 112);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Start Verzeichnis";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_tDir_cp);
            this.groupBox2.Controls.Add(this.bnt_tDir);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.Info;
            this.groupBox2.Location = new System.Drawing.Point(12, 147);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(547, 122);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ziel Verzeichnis";
            // 
            // txt_tDir_cp
            // 
            this.txt_tDir_cp.Enabled = false;
            this.txt_tDir_cp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.txt_tDir_cp.Location = new System.Drawing.Point(87, 71);
            this.txt_tDir_cp.Name = "txt_tDir_cp";
            this.txt_tDir_cp.Size = new System.Drawing.Size(454, 20);
            this.txt_tDir_cp.TabIndex = 5;
            // 
            // bnt_tDir
            // 
            this.bnt_tDir.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.bnt_tDir.ForeColor = System.Drawing.SystemColors.InfoText;
            this.bnt_tDir.Location = new System.Drawing.Point(9, 71);
            this.bnt_tDir.Name = "bnt_tDir";
            this.bnt_tDir.Size = new System.Drawing.Size(72, 20);
            this.bnt_tDir.TabIndex = 4;
            this.bnt_tDir.Text = "...";
            this.bnt_tDir.UseVisualStyleBackColor = true;
            this.bnt_tDir.Click += new System.EventHandler(this.bnt_tDir_Click);
            // 
            // bnt_start
            // 
            this.bnt_start.Location = new System.Drawing.Point(12, 412);
            this.bnt_start.Name = "bnt_start";
            this.bnt_start.Size = new System.Drawing.Size(101, 26);
            this.bnt_start.TabIndex = 6;
            this.bnt_start.Text = "Start";
            this.bnt_start.UseVisualStyleBackColor = true;
            this.bnt_start.Click += new System.EventHandler(this.bnt_start_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 320);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(541, 29);
            this.progressBar1.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(12, 294);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 23);
            this.label2.TabIndex = 8;
            this.label2.Text = "Backup Fortschritt";
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(571, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.bnt_start);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon) (resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Simple Backup";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ProgressBar progressBar1;

        private System.Windows.Forms.Button bnt_start;

        private System.Windows.Forms.TextBox txt_tDir_cp;

        private System.Windows.Forms.Button bnt_tDir;

        private System.Windows.Forms.GroupBox groupBox2;

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.Button bnt_sDir;
        private System.Windows.Forms.TextBox txt_sDir_out;

        private System.Windows.Forms.Label lbl_explain;

        #endregion
    }
}