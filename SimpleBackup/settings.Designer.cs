using System.ComponentModel;

namespace SimpleBackup
{
    partial class settings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(settings));
            this.swiftEnable = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listEndpoints = new System.Windows.Forms.ListBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.chbox = new System.Windows.Forms.CheckBox();
            this.bntSave = new System.Windows.Forms.Button();
            this.bntClose = new System.Windows.Forms.Button();
            this.bntDel = new System.Windows.Forms.Button();
            this.bntAdd = new System.Windows.Forms.Button();
            this.swiftEnable.SuspendLayout();
            this.SuspendLayout();
            // 
            // swiftEnable
            // 
            this.swiftEnable.Controls.Add(this.bntAdd);
            this.swiftEnable.Controls.Add(this.bntDel);
            this.swiftEnable.Controls.Add(this.label1);
            this.swiftEnable.Controls.Add(this.listEndpoints);
            this.swiftEnable.Controls.Add(this.txtPassword);
            this.swiftEnable.Controls.Add(this.lblPassword);
            this.swiftEnable.Controls.Add(this.txtUsername);
            this.swiftEnable.Controls.Add(this.lblUsername);
            this.swiftEnable.Controls.Add(this.chbox);
            this.swiftEnable.Location = new System.Drawing.Point(12, 12);
            this.swiftEnable.Name = "swiftEnable";
            this.swiftEnable.Size = new System.Drawing.Size(411, 385);
            this.swiftEnable.TabIndex = 0;
            this.swiftEnable.TabStop = false;
            this.swiftEnable.Text = "SwiftClient Konfiguration";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(6, 198);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 6;
            this.label1.Text = "Swift Endpoints";
            // 
            // listEndpoints
            // 
            this.listEndpoints.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.listEndpoints.FormattingEnabled = true;
            this.listEndpoints.ItemHeight = 15;
            this.listEndpoints.Location = new System.Drawing.Point(6, 224);
            this.listEndpoints.Name = "listEndpoints";
            this.listEndpoints.Size = new System.Drawing.Size(231, 94);
            this.listEndpoints.TabIndex = 5;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(6, 157);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(225, 20);
            this.txtPassword.TabIndex = 4;
            // 
            // lblPassword
            // 
            this.lblPassword.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblPassword.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblPassword.Location = new System.Drawing.Point(6, 137);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(399, 17);
            this.lblPassword.TabIndex = 3;
            this.lblPassword.Text = "Bitte geben Sie ihr Passwort ein";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(6, 92);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(225, 20);
            this.txtUsername.TabIndex = 2;
            // 
            // lblUsername
            // 
            this.lblUsername.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblUsername.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblUsername.Location = new System.Drawing.Point(6, 69);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(399, 20);
            this.lblUsername.TabIndex = 1;
            this.lblUsername.Text = "Geben Sie bitte den Benutzernamen ein";
            // 
            // chbox
            // 
            this.chbox.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.chbox.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.chbox.Location = new System.Drawing.Point(6, 29);
            this.chbox.Name = "chbox";
            this.chbox.Size = new System.Drawing.Size(399, 24);
            this.chbox.TabIndex = 0;
            this.chbox.Text = "checkbox";
            this.chbox.UseVisualStyleBackColor = true;
            this.chbox.CheckedChanged += new System.EventHandler(this.chbox_CheckedChanged);
            // 
            // bntSave
            // 
            this.bntSave.Location = new System.Drawing.Point(12, 403);
            this.bntSave.Name = "bntSave";
            this.bntSave.Size = new System.Drawing.Size(61, 22);
            this.bntSave.TabIndex = 1;
            this.bntSave.Text = "Speichern";
            this.bntSave.UseVisualStyleBackColor = true;
            // 
            // bntClose
            // 
            this.bntClose.Location = new System.Drawing.Point(79, 403);
            this.bntClose.Name = "bntClose";
            this.bntClose.Size = new System.Drawing.Size(61, 22);
            this.bntClose.TabIndex = 2;
            this.bntClose.Text = "Abbrechen";
            this.bntClose.UseVisualStyleBackColor = true;
            // 
            // bntDel
            // 
            this.bntDel.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.bntDel.ForeColor = System.Drawing.Color.Red;
            this.bntDel.Location = new System.Drawing.Point(243, 224);
            this.bntDel.Name = "bntDel";
            this.bntDel.Size = new System.Drawing.Size(53, 22);
            this.bntDel.TabIndex = 7;
            this.bntDel.Text = "-";
            this.bntDel.UseVisualStyleBackColor = true;
            // 
            // bntAdd
            // 
            this.bntAdd.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.bntAdd.ForeColor = System.Drawing.Color.OliveDrab;
            this.bntAdd.Location = new System.Drawing.Point(243, 252);
            this.bntAdd.Name = "bntAdd";
            this.bntAdd.Size = new System.Drawing.Size(53, 22);
            this.bntAdd.TabIndex = 8;
            this.bntAdd.Text = "+";
            this.bntAdd.UseVisualStyleBackColor = true;
            // 
            // settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(435, 437);
            this.Controls.Add(this.bntClose);
            this.Controls.Add(this.bntSave);
            this.Controls.Add(this.swiftEnable);
            this.Icon = ((System.Drawing.Icon) (resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "settings";
            this.Text = "Einstellungen";
            this.swiftEnable.ResumeLayout(false);
            this.swiftEnable.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button bntDel;
        private System.Windows.Forms.Button bntAdd;

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.ListBox listEndpoints;

        private System.Windows.Forms.TextBox txtPassword;

        private System.Windows.Forms.Label lblPassword;

        private System.Windows.Forms.TextBox txtUsername;

        private System.Windows.Forms.Button bntClose;
        private System.Windows.Forms.Button bntSave;

        private System.Windows.Forms.CheckBox chbox;
        private System.Windows.Forms.GroupBox swiftEnable;

        #endregion
    }
}