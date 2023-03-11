namespace ProjektProgramowanie_logowanie
{
    partial class register
    {
        /// <summary> 
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod wygenerowany przez Projektanta składników

        /// <summary> 
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować 
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.newlogin = new System.Windows.Forms.TextBox();
            this.newpassword = new System.Windows.Forms.TextBox();
            this.newemail = new System.Windows.Forms.TextBox();
            this.phonenmbr = new System.Windows.Forms.TextBox();
            this.newregisterButton = new System.Windows.Forms.Button();
            this.backbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // newlogin
            // 
            this.newlogin.BackColor = System.Drawing.SystemColors.MenuBar;
            this.newlogin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.newlogin.Location = new System.Drawing.Point(320, 168);
            this.newlogin.Name = "newlogin";
            this.newlogin.Size = new System.Drawing.Size(176, 15);
            this.newlogin.TabIndex = 2;
            // 
            // newpassword
            // 
            this.newpassword.BackColor = System.Drawing.SystemColors.MenuBar;
            this.newpassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.newpassword.Location = new System.Drawing.Point(320, 211);
            this.newpassword.Name = "newpassword";
            this.newpassword.Size = new System.Drawing.Size(176, 15);
            this.newpassword.TabIndex = 3;
            // 
            // newemail
            // 
            this.newemail.BackColor = System.Drawing.SystemColors.MenuBar;
            this.newemail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.newemail.Location = new System.Drawing.Point(320, 255);
            this.newemail.Name = "newemail";
            this.newemail.Size = new System.Drawing.Size(176, 15);
            this.newemail.TabIndex = 4;
            // 
            // phonenmbr
            // 
            this.phonenmbr.BackColor = System.Drawing.SystemColors.MenuBar;
            this.phonenmbr.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.phonenmbr.Location = new System.Drawing.Point(320, 301);
            this.phonenmbr.Name = "phonenmbr";
            this.phonenmbr.Size = new System.Drawing.Size(176, 15);
            this.phonenmbr.TabIndex = 5;
            // 
            // newregisterButton
            // 
            this.newregisterButton.Location = new System.Drawing.Point(295, 352);
            this.newregisterButton.Name = "newregisterButton";
            this.newregisterButton.Size = new System.Drawing.Size(213, 27);
            this.newregisterButton.TabIndex = 6;
            this.newregisterButton.Text = "rejestracja";
            this.newregisterButton.UseVisualStyleBackColor = true;
            this.newregisterButton.Click += new System.EventHandler(this.newregisterButton_Click);
            // 
            // backbutton
            // 
            this.backbutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.backbutton.Location = new System.Drawing.Point(103, 419);
            this.backbutton.Name = "backbutton";
            this.backbutton.Size = new System.Drawing.Size(75, 23);
            this.backbutton.TabIndex = 7;
            this.backbutton.Text = "Cofnij";
            this.backbutton.UseVisualStyleBackColor = true;
            this.backbutton.Click += new System.EventHandler(this.backbutton_Click);
            // 
            // register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProjektProgramowanie_logowanie.Properties.Resources.Rejestracja;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Controls.Add(this.backbutton);
            this.Controls.Add(this.newregisterButton);
            this.Controls.Add(this.phonenmbr);
            this.Controls.Add(this.newemail);
            this.Controls.Add(this.newpassword);
            this.Controls.Add(this.newlogin);
            this.DoubleBuffered = true;
            this.Name = "register";
            this.Size = new System.Drawing.Size(801, 451);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox newlogin;
        private System.Windows.Forms.TextBox newpassword;
        private System.Windows.Forms.TextBox newemail;
        private System.Windows.Forms.TextBox phonenmbr;
        private System.Windows.Forms.Button newregisterButton;
        private System.Windows.Forms.Button backbutton;
    }
}
