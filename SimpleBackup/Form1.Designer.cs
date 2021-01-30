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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(f_main));
            this.lbl_explain = new System.Windows.Forms.Label();
            this.bnt_sDir = new System.Windows.Forms.Button();
            this.txt_sDir_out = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbl_explain
            // 
            this.lbl_explain.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lbl_explain.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_explain.Location = new System.Drawing.Point(12, 9);
            this.lbl_explain.Name = "lbl_explain";
            this.lbl_explain.Size = new System.Drawing.Size(462, 23);
            this.lbl_explain.TabIndex = 0;
            this.lbl_explain.Text = "Bitte wählen Sie ein verzeichnes aus";
            // 
            // bnt_sDir
            // 
            this.bnt_sDir.Location = new System.Drawing.Point(12, 35);
            this.bnt_sDir.Name = "bnt_sDir";
            this.bnt_sDir.Size = new System.Drawing.Size(75, 23);
            this.bnt_sDir.TabIndex = 1;
            this.bnt_sDir.Text = "...";
            this.bnt_sDir.UseVisualStyleBackColor = true;
            this.bnt_sDir.Click += new System.EventHandler(this.bnt_sDir_Click);
            // 
            // txt_sDir_out
            // 
            this.txt_sDir_out.Location = new System.Drawing.Point(93, 38);
            this.txt_sDir_out.Name = "txt_sDir_out";
            this.txt_sDir_out.Size = new System.Drawing.Size(381, 20);
            this.txt_sDir_out.TabIndex = 2;
            // 
            // f_main
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(486, 450);
            this.Controls.Add(this.txt_sDir_out);
            this.Controls.Add(this.bnt_sDir);
            this.Controls.Add(this.lbl_explain);
            this.Icon = ((System.Drawing.Icon) (resources.GetObject("$this.Icon")));
            this.Name = "f_main";
            this.Text = "Simple Backup";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button bnt_sDir;
        private System.Windows.Forms.TextBox txt_sDir_out;

        private System.Windows.Forms.Label lbl_explain;

        #endregion
    }
}