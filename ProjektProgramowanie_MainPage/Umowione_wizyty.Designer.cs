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
			this.hide_btn = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.wizyty_view)).BeginInit();
			this.SuspendLayout();
			// 
			// wizyty_view
			// 
			this.wizyty_view.AllowUserToAddRows = false;
			this.wizyty_view.AllowUserToDeleteRows = false;
			this.wizyty_view.AllowUserToResizeColumns = false;
			this.wizyty_view.AllowUserToResizeRows = false;
			this.wizyty_view.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.wizyty_view.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
			this.wizyty_view.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.wizyty_view.Location = new System.Drawing.Point(16, 131);
			this.wizyty_view.Name = "wizyty_view";
			this.wizyty_view.ReadOnly = true;
			this.wizyty_view.ShowCellToolTips = false;
			this.wizyty_view.ShowEditingIcon = false;
			this.wizyty_view.Size = new System.Drawing.Size(800, 440);
			this.wizyty_view.TabIndex = 0;
			// 
			// hide_btn
			// 
			this.hide_btn.BackColor = System.Drawing.Color.Transparent;
			this.hide_btn.FlatAppearance.BorderSize = 0;
			this.hide_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.hide_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.hide_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.hide_btn.ForeColor = System.Drawing.Color.Transparent;
			this.hide_btn.Location = new System.Drawing.Point(15, 13);
			this.hide_btn.Name = "hide_btn";
			this.hide_btn.Size = new System.Drawing.Size(58, 56);
			this.hide_btn.TabIndex = 1;
			this.hide_btn.UseVisualStyleBackColor = false;
			this.hide_btn.Click += new System.EventHandler(this.hide_btn_Click);
			// 
			// Umowione_wizyty
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.Controls.Add(this.hide_btn);
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
		private System.Windows.Forms.Button hide_btn;
	}
}
