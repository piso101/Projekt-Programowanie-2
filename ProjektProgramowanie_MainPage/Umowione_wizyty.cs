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

namespace ProjektProgramowanie_MainPage
{
	public partial class Umowione_wizyty : UserControl
	{
		public static int user_id;
		
		SqlConnection cn = new SqlConnection(@"Server=tcp:onlinegradebook.database.windows.net,1433;Initial Catalog=StoMaToLogiczne;Persist Security Info=False;User ID=theedziu;Password=Kacper123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
		public Umowione_wizyty()
		{
			InitializeComponent();
		}

		private void Umowione_wizyty_Load(object sender, EventArgs e)
		{
			user_id = Form1.user_id;
			wizyty_view_load();
		}
		private void wizyty_view_load()
		{
			cn.Open();
			SqlCommand cmd = new SqlCommand();
			cmd.Connection = cn;
			cmd.CommandText = "SELECT Orders.who,Orders.meeting_date,Orders.meeting_time,doctor.first_name,doctor.last_name,doctor.specialization,doctor.city FROM Orders INNER JOIN doctor ON doctor.id=Orders.doctor_id WHERE user_id=@pam1 ";
			cmd.Parameters.AddWithValue("@pam1", user_id);
			Console.WriteLine("umow id: " + user_id);
			//tworze baze danych wewnetrzna zeby miec gdzie tymczasowo przetrzymac te informacje od bazy danych
			DataTable data = new DataTable();
			//adapter uzupelnia tymczasowa baze danych
			SqlDataAdapter adapter = new SqlDataAdapter(cmd);
			adapter.Fill(data);
			//pokazuje baze danych w datagridview
			wizyty_view.DataSource = data;
			this.wizyty_view.Columns["specialization"].HeaderText = "Specializacja";
			this.wizyty_view.Columns["who"].HeaderText = "Osoba";
			this.wizyty_view.Columns["meeting_date"].HeaderText = "Data wizyty";
			this.wizyty_view.Columns["meeting_time"].HeaderText = "Godzina wizyty";
			this.wizyty_view.Columns["first_name"].HeaderText = "Imię lekarza";
			this.wizyty_view.Columns["last_name"].HeaderText = "Nazwisko lekarza";
			this.wizyty_view.Columns["city"].HeaderText = "Miasto";
			cn.Close();
		}

		private void hide_btn_Click(object sender, EventArgs e)
		{
			this.Hide();
		}
	}
}
