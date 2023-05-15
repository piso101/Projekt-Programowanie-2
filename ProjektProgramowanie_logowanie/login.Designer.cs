namespace projektProgramowanie_logowanie
{
    partial class login
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
            this.registerButton = new System.Windows.Forms.Button();
            this.zalogujButton = new System.Windows.Forms.Button();
            this.loginuserBox = new System.Windows.Forms.TextBox();
            this.passworduserBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // registerButton
            // 
            this.registerButton.BackColor = System.Drawing.Color.Transparent;
            this.registerButton.FlatAppearance.BorderSize = 0;
            this.registerButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.registerButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.registerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.registerButton.Location = new System.Drawing.Point(426, 318);
            this.registerButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(112, 33);
            this.registerButton.TabIndex = 0;
            this.registerButton.UseVisualStyleBackColor = false;
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
            // 
            // zalogujButton
            // 
            this.zalogujButton.BackColor = System.Drawing.Color.Transparent;
            this.zalogujButton.FlatAppearance.BorderSize = 0;
            this.zalogujButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.zalogujButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.zalogujButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.zalogujButton.Location = new System.Drawing.Point(265, 318);
            this.zalogujButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.zalogujButton.Name = "zalogujButton";
            this.zalogujButton.Size = new System.Drawing.Size(112, 33);
            this.zalogujButton.TabIndex = 1;
            this.zalogujButton.UseVisualStyleBackColor = false;
            this.zalogujButton.Click += new System.EventHandler(this.zalogujButton_Click);
            // 
            // loginuserBox
            // 
            this.loginuserBox.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.loginuserBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.loginuserBox.Location = new System.Drawing.Point(309, 188);
            this.loginuserBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.loginuserBox.Name = "loginuserBox";
            this.loginuserBox.Size = new System.Drawing.Size(200, 15);
            this.loginuserBox.TabIndex = 2;
            // 
            // passworduserBox
            // 
            this.passworduserBox.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.passworduserBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passworduserBox.Location = new System.Drawing.Point(309, 243);
            this.passworduserBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.passworduserBox.Name = "passworduserBox";
            this.passworduserBox.Size = new System.Drawing.Size(200, 15);
            this.passworduserBox.TabIndex = 3;
            this.passworduserBox.TextChanged += new System.EventHandler(this.passworduserBox_TextChanged);
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::projektProgramowanie_logowanie.Properties.Resources.Logowanie;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.passworduserBox);
            this.Controls.Add(this.loginuserBox);
            this.Controls.Add(this.zalogujButton);
            this.Controls.Add(this.registerButton);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "login";
            this.Size = new System.Drawing.Size(797, 452);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button registerButton;
        private System.Windows.Forms.Button zalogujButton;
        private System.Windows.Forms.TextBox loginuserBox;
        private System.Windows.Forms.TextBox passworduserBox;
    }
}
