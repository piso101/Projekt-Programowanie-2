
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace ProjektProgramowanie2Dentysta
{
    public partial class Form2 : Form
    {
		public static int user_id;
		public static int doctor_id;
		public static string picked_date;
		public static string picked_time;
		static bool date_bool = false;
		static bool time_bool = false;
		static bool who_bool = false;
		static bool msg_bool = false;
		SqlConnection cn = new SqlConnection(@"Server=tcp:onlinegradebook.database.windows.net,1433;Initial Catalog=StoMaToLogiczne;Persist Security Info=False;User ID=theedziu;Password=Kacper123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
		public Form2()
        {
            InitializeComponent();
		}
		public void Userd_id(int id)
		{
			user_id = id;
		}
		public void Doctor_id(int id)
		{
			doctor_id = id;
		}
		private void main_btn_Click(object sender, EventArgs e)
		{

			this.Close();
		}

		private void book_btn_Click(object sender, EventArgs e)
		{
			try
			{
				cn.Open();
				SqlCommand cmdcount = new SqlCommand();
				cmdcount.CommandText = "SELECT COUNT(*) FROM Users";
				cmdcount.Connection = cn;
				string selectStatement = "SELECT TOP 1 id FROM Orders ORDER BY ID DESC";
				SqlCommand selectCommand = new SqlCommand(selectStatement, cn);
				int lastId = Convert.ToInt32(selectCommand.ExecuteScalar());
				int newId = lastId + 1;
				cn.Close();
				if(time_bool==false)
				{
					MessageBox.Show("Proszę wybrać godzinę wizyty.");
					return;

				}
				else if(date_bool==false)
				{
					MessageBox.Show("Proszę wybrać datę.");
					return;
				}
				else if (who_bool == false)
				{
					MessageBox.Show("Proszę wpisać imię i nazwisko.");
					return;
				}
				cn.Open();
				SqlCommand cmdinsert = new SqlCommand();
				cmdinsert.Connection = cn;
				cmdinsert.CommandText = "INSERT INTO Orders (id,user_id,doctor_id,who,meeting_date,meeting_time,message) Values (@pam1,@pam2,@pam3,@pam4,@pam5,@pam6,@pam7)";
				//dodajemy wartości do komendy sql
				cmdinsert.Parameters.AddWithValue("@pam1", newId);
				cmdinsert.Parameters.AddWithValue("@pam2", user_id);
				cmdinsert.Parameters.AddWithValue("@pam3", doctor_id);
				cmdinsert.Parameters.AddWithValue("@pam4", name_box.Text);
				cmdinsert.Parameters.AddWithValue("@pam5", picked_date);
				cmdinsert.Parameters.AddWithValue("@pam6", picked_time);
				if(msg_bool==false)
				{
					cmdinsert.Parameters.AddWithValue("@pam7", "brak");
				}
				else
				{
					cmdinsert.Parameters.AddWithValue("@pam7", message_box.Text);
				}				
				cmdinsert.CommandType = CommandType.Text;
				cmdinsert.ExecuteNonQuery();//wykonujemy komende dodania rekordu w tablicy zabukowane
				cn.Close();
				MessageBox.Show("Wizyta została umówiona.");
				this.Close();
			} 
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message);
				cn.Close();
			}


		}

		private void Form2_Load(object sender, EventArgs e)
		{
			
		}

		private void date_box_ValueChanged(object sender, EventArgs e)
		{ 
			picked_date = date_box.Text.ToString();
			date_bool = true;
			if (DateTime.Parse(picked_date) <= DateTime.Now)
			{
				MessageBox.Show("Proszę wybrać poprawną datę.");
				return;
			}
			else
			{
				ArrayList godziny = new ArrayList();
				ArrayList godziny_dostepne = new ArrayList();
				SqlCommand cmddt = new SqlCommand();
				cmddt.Connection = cn;
				cmddt.CommandText = "SELECT meeting_time FROM Orders WHERE meeting_date=@pam1 AND doctor_id=@pam2";
				cmddt.Parameters.AddWithValue("@pam1", picked_date);
				cmddt.Parameters.AddWithValue("@pam2", doctor_id);
				SqlDataReader reader;
				cn.Open();
				reader = cmddt.ExecuteReader();
				string hour = "";

				while (reader.Read())
				{
					hour = reader["meeting_time"].ToString();
					Console.WriteLine(hour);
					godziny.Add(hour);
				}
				reader.Close();
				cn.Close();
				string[] godziny_comp = { "08:00", "08:30", "09:00", "09:30", "10:00", "10:30", "11:00", "11:30", "12:00", "12:30", "13:00", "13:30", "14:00", "14:30", "15:00", "15:30", "16:00", "16:30", "17:00", "17:30", "18:00", "18:30" };
				foreach (string x in godziny_comp)
				{
					int check = 1;
					foreach (string y in godziny)
					{
						if (x == y) check = 0;
					}
					if (check == 1)
					{
						godziny_dostepne.Add(x);

					}
				}
				hour_box.Items.Clear();
				foreach (string x in godziny_dostepne)
				{
					hour_box.Items.Add(x);
				}
			}
			
				
		}

		private void hour_box_SelectedIndexChanged(object sender, EventArgs e)
		{
			picked_time = hour_box.SelectedItem.ToString();
			if(picked_time != "Proszę wybrać datę.") time_bool = true;
		}

		private void name_box_TextChanged(object sender, EventArgs e)
		{
			if (name_box.Text != "Imię i nazwisko") who_bool = true;
		}

		private void message_box_TextChanged(object sender, EventArgs e)
		{
			msg_bool = true;
		}
	}
}
