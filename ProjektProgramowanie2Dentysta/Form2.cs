
using System;
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
		public static string user_name;
		public static string user_password;
		public static int id;
		public static int doctor_id;
		public static string picked_date;
		public static string picked_time;
		SqlConnection cn = new SqlConnection(@"Server=tcp:onlinegradebook.database.windows.net,1433;Initial Catalog=StoMaToLogiczne;Persist Security Info=False;User ID=theedziu;Password=Kacper123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
		SqlCommand cmd;
		SqlDataReader rd;
		public Form2()
        {
            InitializeComponent();
		}
		public void Userd_id(string c, string d)
		{
			try
			{
				user_name = c.ToString();
				user_password = d.ToString();
				string command = "SELECT id FROM Users WHERE login = '" + user_name + "' AND password = '" + user_password + "'";
				cn.Open();
				SqlCommand cmd = new SqlCommand(command, cn);
				SqlDataReader reader;
				reader = cmd.ExecuteReader();
				string userid = "";

				while (reader.Read())
				{
					userid = reader["id"].ToString();
				}

				id = int.Parse(userid);
				reader.Close();
				
			}
			catch 
			{ 
				Console.WriteLine("Błąd_book");
			}

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
				cmdcount.CommandText = "SELECT COUNT(*) FROM Orders";
				cmdcount.Connection = cn;
				cmdcount.CommandType = CommandType.Text;
				int order_id = cmdcount.ExecuteNonQuery();
				doctor_id = 1; //doctor id (do zmiany)
				id = 1; // id (do zmiany)
				string meeting_date = picked_date + " " + picked_time+":00";
				//DateTime date = meeting_date;
				SqlCommand cmdinsert = new SqlCommand();
				cmdinsert.Connection = cn;
				
				cmdinsert.CommandText = "INSERT INTO Orders (id,user_id,doctor_id,meeting_date) Values (@pam4,@pam1,@pam2,@pam3)";
				//dodajemy wartości do komendy sql
				cmdinsert.Parameters.AddWithValue("@pam1", id);
				cmdinsert.Parameters.AddWithValue("@pam2", doctor_id);
				cmdinsert.Parameters.AddWithValue("@pam3", meeting_date);
				cmdinsert.Parameters.AddWithValue("@pam4", order_id);
				cmdinsert.CommandType = CommandType.Text;
				cmdinsert.ExecuteNonQuery();//wykonujemy komende dodania rekordu w tablicy zabukowane
				cn.Close();
			} 
			catch(Exception ex)
			{
				Console.WriteLine(ex.Message + "LOL");
				cn.Close();
			}

		}

		private void Form2_Load(object sender, EventArgs e)
		{

		}

		private void date_box_ValueChanged(object sender, EventArgs e)
		{
			picked_date = date_box.Text.ToString();
		}

		private void hour_box_SelectedIndexChanged(object sender, EventArgs e)
		{
			picked_time = hour_box.Text.ToString();
		}
	}
}
