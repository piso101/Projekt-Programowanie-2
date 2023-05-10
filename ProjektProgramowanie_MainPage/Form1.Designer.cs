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
			this.doctorDataGridView = new System.Windows.Forms.DataGridView();
			this.Combobox_miasta = new System.Windows.Forms.ComboBox();
			this.Umowionespotkaniabtn = new System.Windows.Forms.Button();
			this.Szukaj_btn = new System.Windows.Forms.Button();
			this.umowione_wizyty1 = new ProjektProgramowanie_MainPage.Umowione_wizyty();
			((System.ComponentModel.ISupportInitialize)(this.doctorDataGridView)).BeginInit();
			this.SuspendLayout();
			// 
			// doctorDataGridView
			// 
			this.doctorDataGridView.BackgroundColor = System.Drawing.SystemColors.Window;
			this.doctorDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.doctorDataGridView.Location = new System.Drawing.Point(14, 160);
			this.doctorDataGridView.Name = "doctorDataGridView";
			this.doctorDataGridView.RowHeadersWidth = 51;
			this.doctorDataGridView.Size = new System.Drawing.Size(742, 272);
			this.doctorDataGridView.TabIndex = 1;
			this.doctorDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.doctorDataGridView_CellContentClick);
			// 
			// Combobox_miasta
			// 
			this.Combobox_miasta.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.Combobox_miasta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Combobox_miasta.FormattingEnabled = true;
			this.Combobox_miasta.Location = new System.Drawing.Point(254, 103);
			this.Combobox_miasta.Name = "Combobox_miasta";
			this.Combobox_miasta.Size = new System.Drawing.Size(144, 21);
			this.Combobox_miasta.TabIndex = 2;
			this.Combobox_miasta.SelectedIndexChanged += new System.EventHandler(this.Combobox_miasta_SelectedIndexChanged);
			// 
			// Umowionespotkaniabtn
			// 
			this.Umowionespotkaniabtn.BackColor = System.Drawing.Color.Transparent;
			this.Umowionespotkaniabtn.FlatAppearance.BorderSize = 0;
			this.Umowionespotkaniabtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.Umowionespotkaniabtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.Umowionespotkaniabtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Umowionespotkaniabtn.Location = new System.Drawing.Point(65, 18);
			this.Umowionespotkaniabtn.Name = "Umowionespotkaniabtn";
			this.Umowionespotkaniabtn.Size = new System.Drawing.Size(128, 32);
			this.Umowionespotkaniabtn.TabIndex = 4;
			this.Umowionespotkaniabtn.UseVisualStyleBackColor = false;
			this.Umowionespotkaniabtn.Click += new System.EventHandler(this.Umowionespotkaniabtn_Click);
			// 
			// Szukaj_btn
			// 
			this.Szukaj_btn.BackColor = System.Drawing.Color.Transparent;
			this.Szukaj_btn.FlatAppearance.BorderSize = 0;
			this.Szukaj_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.Szukaj_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.Szukaj_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Szukaj_btn.Location = new System.Drawing.Point(422, 96);
			this.Szukaj_btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.Szukaj_btn.Name = "Szukaj_btn";
			this.Szukaj_btn.Size = new System.Drawing.Size(104, 36);
			this.Szukaj_btn.TabIndex = 6;
			this.Szukaj_btn.UseVisualStyleBackColor = false;
			this.Szukaj_btn.Click += new System.EventHandler(this.Szukaj_btn_Click);
			// 
			// umowione_wizyty1
			// 
			this.umowione_wizyty1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("umowione_wizyty1.BackgroundImage")));
			this.umowione_wizyty1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.umowione_wizyty1.Location = new System.Drawing.Point(-2, -1);
			this.umowione_wizyty1.Margin = new System.Windows.Forms.Padding(4);
			this.umowione_wizyty1.Name = "umowione_wizyty1";
			this.umowione_wizyty1.Size = new System.Drawing.Size(775, 443);
			this.umowione_wizyty1.TabIndex = 0;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::ProjektProgramowanie_MainPage.Properties.Resources.Strona_Głowna1;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(774, 444);
			this.Controls.Add(this.Szukaj_btn);
			this.Controls.Add(this.Umowionespotkaniabtn);
			this.Controls.Add(this.Combobox_miasta);
			this.Controls.Add(this.doctorDataGridView);
			this.Controls.Add(this.umowione_wizyty1);
			this.DoubleBuffered = true;
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.doctorDataGridView)).EndInit();
			this.ResumeLayout(false);

        }

		#endregion

		private Umowione_wizyty umowione_wizyty1;
		private System.Windows.Forms.DataGridView doctorDataGridView;
		private System.Windows.Forms.ComboBox Combobox_miasta;
		private System.Windows.Forms.Button Umowionespotkaniabtn;
        private System.Windows.Forms.Button Szukaj_btn;
    }
}

