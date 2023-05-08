namespace ProjektProgramowanie_MainPage
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
			this.umowione_wizyty1 = new ProjektProgramowanie_MainPage.Umowione_wizyty();
			this.SuspendLayout();
			// 
			// umowione_wizyty1
			// 
			this.umowione_wizyty1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("umowione_wizyty1.BackgroundImage")));
			this.umowione_wizyty1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.umowione_wizyty1.Location = new System.Drawing.Point(-4, 0);
			this.umowione_wizyty1.Name = "umowione_wizyty1";
			this.umowione_wizyty1.Size = new System.Drawing.Size(778, 444);
			this.umowione_wizyty1.TabIndex = 0;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(774, 444);
			this.Controls.Add(this.umowione_wizyty1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);

        }

		#endregion

		private Umowione_wizyty umowione_wizyty1;
	}
}

