namespace projektProgramowanie_logowanie
{
    partial class Form1
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

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.login1 = new projektProgramowanie_logowanie.login();
            this.register1 = new projektProgramowanie_logowanie.register();
            this.SuspendLayout();
            // 
            // login1
            // 
            this.login1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("login1.BackgroundImage")));
            this.login1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.login1.Location = new System.Drawing.Point(1, -1);
            this.login1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.login1.Name = "login1";
            this.login1.Size = new System.Drawing.Size(797, 452);
            this.login1.TabIndex = 0;
            this.login1.Load += new System.EventHandler(this.login1_Load);
            // 
            // register1
            // 
            this.register1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("register1.BackgroundImage")));
            this.register1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.register1.Location = new System.Drawing.Point(1, -1);
            this.register1.Name = "register1";
            this.register1.Size = new System.Drawing.Size(797, 452);
            this.register1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.login1);
            this.Controls.Add(this.register1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private login login1;
        private register register1;
    }
}

