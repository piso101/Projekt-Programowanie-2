namespace ProjektProgramowanie_MainPage
{
	partial class Umowione_wizyty
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Umowione_wizyty));
			this.wizyty_view = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.wizyty_view)).BeginInit();
			this.SuspendLayout();
			// 
			// wizyty_view
			// 
			this.wizyty_view.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.wizyty_view.Location = new System.Drawing.Point(16, 131);
			this.wizyty_view.Name = "wizyty_view";
			this.wizyty_view.Size = new System.Drawing.Size(800, 440);
			this.wizyty_view.TabIndex = 0;
			// 
			// Umowione_wizyty
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.Controls.Add(this.wizyty_view);
			this.DoubleBuffered = true;
			this.Name = "Umowione_wizyty";
			this.Size = new System.Drawing.Size(833, 583);
			this.Load += new System.EventHandler(this.Umowione_wizyty_Load);
			((System.ComponentModel.ISupportInitialize)(this.wizyty_view)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView wizyty_view;
	}
}
