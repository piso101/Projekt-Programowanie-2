using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace ProjektProgramowanie_MainPage
{
	public partial class Form1 : Form
	{
		public static int user_id;
		public static string city;
		private SqlConnection cn = new SqlConnection(@"Server=tcp:onlinegradebook.database.windows.net,1433;Initial Catalog=StoMaToLogiczne;Persist Security Info=False;User ID=theedziu;Password=Kacper123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
		public Form1()
		{
			InitializeComponent();

		}

		private void Form1_Load(object sender, EventArgs e)
		{
			umowione_wizyty1.Hide();
			SqlCommand cmd = new SqlCommand();
			cmd.Connection = cn;
			cmd.CommandText = "SELECT DISTINCT city FROM doctor ";
			cn.Open();
			SqlDataReader reader;
			reader = cmd.ExecuteReader();

			while (reader.Read())
			{
				string city = reader["city"].ToString();
				Combobox_miasta.Items.Add(city);
			}
			reader.Close();
			cn.Close();
		}
		public void Id(int id)
		{
			user_id = id;
		}

		private void umow_wizyte_btn_Click(object sender, EventArgs e)
		{

		}

		private void Umowionespotkaniabtn_Click(object sender, EventArgs e)
		{
			umowione_wizyty1.wizyty_view_load();
			umowione_wizyty1.Show();
			umowione_wizyty1.BringToFront();
		}

		private void Szukaj_btn_Click(object sender, EventArgs e)
		{
			cn.Open();
			SqlCommand cmd = new SqlCommand();
			cmd.Connection = cn;
			cmd.CommandText = "SELECT first_name, last_name, id, specialization FROM doctor WHERE city=@pam1";
			cmd.Parameters.AddWithValue("@pam1", city);
			DataTable data = new DataTable();
			SqlDataAdapter adapter = new SqlDataAdapter(cmd);
			adapter.Fill(data);
			doctorDataGridView.DataSource = data;
			DataGridViewButtonColumn wybierz = new DataGridViewButtonColumn();
			wybierz.Name = "Umów";
			wybierz.Text = "Umów";
			wybierz.UseColumnTextForButtonValue = true;
			int len = doctorDataGridView.Columns.Count; // sprawdza ile kolumn zanim doda przycisk
			if (doctorDataGridView.Columns.Contains("Umów")==false)
			{
				doctorDataGridView.Columns.Insert(len, wybierz);
			}
			this.doctorDataGridView.Columns["id"].Visible = false;
			this.doctorDataGridView.Columns["first_name"].HeaderText = "Imię lekarza";
			this.doctorDataGridView.Columns["last_name"].HeaderText = "Nazwisko lekarza";
			this.doctorDataGridView.Columns["specialization"].HeaderText = "Nazwisko lekarza";
			cn.Close();
		}

		private void Combobox_miasta_SelectedIndexChanged(object sender, EventArgs e)
		{
			city = Combobox_miasta.Text;// przypisanie z combobox do zmiennenj city
		}

		private void doctorDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			if (MessageBox.Show("Czy chcesz zarezerwować tą wizytę?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
			{


				if (e.RowIndex >= 0)
				{
					try
					{
						DataGridViewRow row = this.doctorDataGridView.Rows[e.RowIndex];
						int id = int.Parse(row.Cells["id"].Value.ToString());
						//pobieramy wartosci z datagrv
						ProjektProgramowanie2Dentysta.Form2 fbook = new ProjektProgramowanie2Dentysta.Form2();
						fbook.Userd_id(user_id);
						fbook.Doctor_id(id);
						fbook.Show();
					}
					catch (Exception ex)
					{
						Console.WriteLine(ex);
					}

				}

			}
		}

	}
}
