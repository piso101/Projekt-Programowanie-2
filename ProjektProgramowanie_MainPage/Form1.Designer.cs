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
			this.label1 = new System.Windows.Forms.Label();
			this.Umowionespotkaniabtn = new System.Windows.Forms.Button();
			this.umow_wizyte_btn = new System.Windows.Forms.Button();
			this.umowione_wizyty1 = new ProjektProgramowanie_MainPage.Umowione_wizyty();
			((System.ComponentModel.ISupportInitialize)(this.doctorDataGridView)).BeginInit();
			this.SuspendLayout();
			// 
			// doctorDataGridView
			// 
			this.doctorDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.doctorDataGridView.Location = new System.Drawing.Point(26, 75);
			this.doctorDataGridView.Name = "doctorDataGridView";
			this.doctorDataGridView.Size = new System.Drawing.Size(219, 162);
			this.doctorDataGridView.TabIndex = 1;
			// 
			// Combobox_miasta
			// 
			this.Combobox_miasta.FormattingEnabled = true;
			this.Combobox_miasta.Location = new System.Drawing.Point(39, 290);
			this.Combobox_miasta.Name = "Combobox_miasta";
			this.Combobox_miasta.Size = new System.Drawing.Size(205, 21);
			this.Combobox_miasta.TabIndex = 2;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(39, 25);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(35, 13);
			this.label1.TabIndex = 3;
			this.label1.Text = "label1";
			// 
			// Umowionespotkaniabtn
			// 
			this.Umowionespotkaniabtn.Location = new System.Drawing.Point(52, 360);
			this.Umowionespotkaniabtn.Name = "Umowionespotkaniabtn";
			this.Umowionespotkaniabtn.Size = new System.Drawing.Size(121, 21);
			this.Umowionespotkaniabtn.TabIndex = 4;
			this.Umowionespotkaniabtn.Text = "umowione spotkania";
			this.Umowionespotkaniabtn.UseVisualStyleBackColor = true;
			this.Umowionespotkaniabtn.Click += new System.EventHandler(this.Umowionespotkaniabtn_Click);
			// 
			// umow_wizyte_btn
			// 
			this.umow_wizyte_btn.Location = new System.Drawing.Point(52, 387);
			this.umow_wizyte_btn.Name = "umow_wizyte_btn";
			this.umow_wizyte_btn.Size = new System.Drawing.Size(121, 21);
			this.umow_wizyte_btn.TabIndex = 5;
			this.umow_wizyte_btn.Text = "umow wizyte";
			this.umow_wizyte_btn.UseVisualStyleBackColor = true;
			this.umow_wizyte_btn.Click += new System.EventHandler(this.umow_wizyte_btn_Click);
			// 
			// umowione_wizyty1
			// 
			this.umowione_wizyty1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("umowione_wizyty1.BackgroundImage")));
			this.umowione_wizyty1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.umowione_wizyty1.Location = new System.Drawing.Point(-3, -2);
			this.umowione_wizyty1.Name = "umowione_wizyty1";
			this.umowione_wizyty1.Size = new System.Drawing.Size(778, 444);
			this.umowione_wizyty1.TabIndex = 0;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(774, 444);
			this.Controls.Add(this.umow_wizyte_btn);
			this.Controls.Add(this.Umowionespotkaniabtn);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.Combobox_miasta);
			this.Controls.Add(this.doctorDataGridView);
			this.Controls.Add(this.umowione_wizyty1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.doctorDataGridView)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

		#endregion

		private Umowione_wizyty umowione_wizyty1;
		private System.Windows.Forms.DataGridView doctorDataGridView;
		private System.Windows.Forms.ComboBox Combobox_miasta;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button Umowionespotkaniabtn;
		private System.Windows.Forms.Button umow_wizyte_btn;
	}
}

