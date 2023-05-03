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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.stoMaToLogiczneDataSet = new ProjektProgramowanie_MainPage.StoMaToLogiczneDataSet();
            this.doctorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.doctorTableAdapter = new ProjektProgramowanie_MainPage.StoMaToLogiczneDataSetTableAdapters.doctorTableAdapter();
            this.tableAdapterManager = new ProjektProgramowanie_MainPage.StoMaToLogiczneDataSetTableAdapters.TableAdapterManager();
            this.doctorDataGridView = new System.Windows.Forms.DataGridView();
            this.doctorBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.doctorBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.Combobox_miasta = new System.Windows.Forms.ComboBox();
            this.Szukajbtn = new System.Windows.Forms.Button();
            this.Umowionespotkaniabtn = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Wybieram = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.stoMaToLogiczneDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // stoMaToLogiczneDataSet
            // 
            this.stoMaToLogiczneDataSet.DataSetName = "StoMaToLogiczneDataSet";
            this.stoMaToLogiczneDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // doctorBindingSource
            // 
            this.doctorBindingSource.DataMember = "doctor";
            this.doctorBindingSource.DataSource = this.stoMaToLogiczneDataSet;
            // 
            // doctorTableAdapter
            // 
            this.doctorTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.doctorTableAdapter = this.doctorTableAdapter;
            this.tableAdapterManager.UpdateOrder = ProjektProgramowanie_MainPage.StoMaToLogiczneDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // doctorDataGridView
            // 
            this.doctorDataGridView.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.doctorDataGridView.AllowUserToAddRows = false;
            this.doctorDataGridView.AllowUserToDeleteRows = false;
            this.doctorDataGridView.AllowUserToResizeColumns = false;
            this.doctorDataGridView.AllowUserToResizeRows = false;
            this.doctorDataGridView.AutoGenerateColumns = false;
            this.doctorDataGridView.BackgroundColor = System.Drawing.Color.SkyBlue;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.doctorDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.doctorDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.Wybieram});
            this.doctorDataGridView.DataSource = this.doctorBindingSource;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.doctorDataGridView.DefaultCellStyle = dataGridViewCellStyle8;
            this.doctorDataGridView.Location = new System.Drawing.Point(-2, 139);
            this.doctorDataGridView.Name = "doctorDataGridView";
            this.doctorDataGridView.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.doctorDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.doctorDataGridView.RowTemplate.ReadOnly = true;
            this.doctorDataGridView.Size = new System.Drawing.Size(745, 312);
            this.doctorDataGridView.TabIndex = 1;
            this.doctorDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.doctorDataGridView_CellContentClick);
            // 
            // doctorBindingSource1
            // 
            this.doctorBindingSource1.DataMember = "doctor";
            this.doctorBindingSource1.DataSource = this.stoMaToLogiczneDataSet;
            // 
            // doctorBindingSource2
            // 
            this.doctorBindingSource2.DataMember = "doctor";
            this.doctorBindingSource2.DataSource = this.stoMaToLogiczneDataSet;
            // 
            // Combobox_miasta
            // 
            this.Combobox_miasta.BackColor = System.Drawing.SystemColors.Control;
            this.Combobox_miasta.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Combobox_miasta.FormattingEnabled = true;
            this.Combobox_miasta.Location = new System.Drawing.Point(243, 103);
            this.Combobox_miasta.Name = "Combobox_miasta";
            this.Combobox_miasta.Size = new System.Drawing.Size(141, 21);
            this.Combobox_miasta.TabIndex = 2;
            // 
            // Szukajbtn
            // 
            this.Szukajbtn.BackColor = System.Drawing.Color.Transparent;
            this.Szukajbtn.FlatAppearance.BorderSize = 0;
            this.Szukajbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Szukajbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Szukajbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Szukajbtn.Location = new System.Drawing.Point(411, 96);
            this.Szukajbtn.Name = "Szukajbtn";
            this.Szukajbtn.Size = new System.Drawing.Size(92, 37);
            this.Szukajbtn.TabIndex = 3;
            this.Szukajbtn.UseVisualStyleBackColor = false;
            this.Szukajbtn.Click += new System.EventHandler(this.Szukajbtn_Click);
            // 
            // Umowionespotkaniabtn
            // 
            this.Umowionespotkaniabtn.BackColor = System.Drawing.Color.Transparent;
            this.Umowionespotkaniabtn.FlatAppearance.BorderSize = 0;
            this.Umowionespotkaniabtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Umowionespotkaniabtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Umowionespotkaniabtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Umowionespotkaniabtn.Location = new System.Drawing.Point(65, 12);
            this.Umowionespotkaniabtn.Name = "Umowionespotkaniabtn";
            this.Umowionespotkaniabtn.Size = new System.Drawing.Size(124, 37);
            this.Umowionespotkaniabtn.TabIndex = 4;
            this.Umowionespotkaniabtn.UseVisualStyleBackColor = false;
            this.Umowionespotkaniabtn.Click += new System.EventHandler(this.Umowionespotkaniabtn_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn1.HeaderText = "id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "first_name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Imię";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "last_name";
            this.dataGridViewTextBoxColumn3.HeaderText = "Nazwisko";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "email";
            this.dataGridViewTextBoxColumn4.HeaderText = "email";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "phone";
            this.dataGridViewTextBoxColumn5.HeaderText = "Telefon";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "specialization";
            this.dataGridViewTextBoxColumn6.HeaderText = "Specjalizacja";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "city";
            this.dataGridViewTextBoxColumn7.HeaderText = "Miasto";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // Wybieram
            // 
            this.Wybieram.DataPropertyName = "Wybieram";
            this.Wybieram.HeaderText = "Wybieram";
            this.Wybieram.Name = "Wybieram";
            this.Wybieram.ReadOnly = true;
            this.Wybieram.Text = "Wybieram";
            this.Wybieram.ToolTipText = "Kliknij by wybrać";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(549, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackgroundImage = global::ProjektProgramowanie_MainPage.Properties.Resources.Strona_Głowna;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(748, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Umowionespotkaniabtn);
            this.Controls.Add(this.Szukajbtn);
            this.Controls.Add(this.Combobox_miasta);
            this.Controls.Add(this.doctorDataGridView);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.stoMaToLogiczneDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private StoMaToLogiczneDataSet stoMaToLogiczneDataSet;
        private System.Windows.Forms.BindingSource doctorBindingSource;
        private StoMaToLogiczneDataSetTableAdapters.doctorTableAdapter doctorTableAdapter;
        private StoMaToLogiczneDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView doctorDataGridView;
        private System.Windows.Forms.BindingSource doctorBindingSource1;
        private System.Windows.Forms.BindingSource doctorBindingSource2;
        private System.Windows.Forms.ComboBox Combobox_miasta;
        private System.Windows.Forms.Button Szukajbtn;
        private System.Windows.Forms.Button Umowionespotkaniabtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewButtonColumn Wybieram;
        private System.Windows.Forms.Label label1;
    }
}

