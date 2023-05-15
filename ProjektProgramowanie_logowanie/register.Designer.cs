namespace projektProgramowanie_logowanie
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
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // newlogin
            // 
            this.newlogin.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.newlogin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.newlogin.Location = new System.Drawing.Point(311, 163);
            this.newlogin.Name = "newlogin";
            this.newlogin.Size = new System.Drawing.Size(195, 15);
            this.newlogin.TabIndex = 0;
            // 
            // newpassword
            // 
            this.newpassword.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.newpassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.newpassword.Location = new System.Drawing.Point(311, 208);
            this.newpassword.Name = "newpassword";
            this.newpassword.Size = new System.Drawing.Size(195, 15);
            this.newpassword.TabIndex = 1;
            this.newpassword.TextChanged += new System.EventHandler(this.newpassword_TextChanged);
            // 
            // newemail
            // 
            this.newemail.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.newemail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.newemail.Location = new System.Drawing.Point(311, 253);
            this.newemail.Name = "newemail";
            this.newemail.Size = new System.Drawing.Size(195, 15);
            this.newemail.TabIndex = 2;
            // 
            // phonenmbr
            // 
            this.phonenmbr.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.phonenmbr.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.phonenmbr.Location = new System.Drawing.Point(311, 298);
            this.phonenmbr.Name = "phonenmbr";
            this.phonenmbr.Size = new System.Drawing.Size(195, 15);
            this.phonenmbr.TabIndex = 3;
            this.phonenmbr.TextChanged += new System.EventHandler(this.phonenmbr_TextChanged);
            this.phonenmbr.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.phonenmbr_KeyPress);
            // 
            // newregisterButton
            // 
            this.newregisterButton.BackColor = System.Drawing.Color.Transparent;
            this.newregisterButton.FlatAppearance.BorderSize = 0;
            this.newregisterButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.newregisterButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.newregisterButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newregisterButton.Location = new System.Drawing.Point(290, 351);
            this.newregisterButton.Name = "newregisterButton";
            this.newregisterButton.Size = new System.Drawing.Size(216, 29);
            this.newregisterButton.TabIndex = 4;
            this.newregisterButton.UseVisualStyleBackColor = false;
            this.newregisterButton.Click += new System.EventHandler(this.newregisterButton_Click);
            // 
            // backbutton
            // 
            this.backbutton.Location = new System.Drawing.Point(66, 458);
            this.backbutton.Name = "backbutton";
            this.backbutton.Size = new System.Drawing.Size(75, 23);
            this.backbutton.TabIndex = 5;
            this.backbutton.Text = "button1";
            this.backbutton.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("MS Reference Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(12, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(60, 55);
            this.button1.TabIndex = 6;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BackgroundImage = global::projektProgramowanie_logowanie.Properties.Resources.Rejestracja;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.backbutton);
            this.Controls.Add(this.newregisterButton);
            this.Controls.Add(this.phonenmbr);
            this.Controls.Add(this.newemail);
            this.Controls.Add(this.newpassword);
            this.Controls.Add(this.newlogin);
            this.DoubleBuffered = true;
            this.Name = "register";
            this.Size = new System.Drawing.Size(797, 452);
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
        private System.Windows.Forms.Button button1;
    }
}
