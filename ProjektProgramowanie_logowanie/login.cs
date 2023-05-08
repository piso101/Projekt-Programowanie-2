using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace projektProgramowanie_logowanie
{
    public partial class login : UserControl
    {
        public login()
        {
            InitializeComponent();
        }

        SqlConnection sqlcon = new SqlConnection(@"Server=tcp:onlinegradebook.database.windows.net,1433;Initial Catalog=StoMaToLogiczne;Persist Security Info=False;User ID=theedziu;Password=Kacper123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
        SqlCommand cmd;
        SqlDataReader dr;
        public string booklogin;
		public int user_id;

		private void registerButton_Click(object sender, EventArgs e)
        {
            register register = new register(); //nadajemy instancje
            this.Parent.Controls.Add(register); // user control(login) jest rodzicem wzglédem registera
            register.BringToFront(); //po kliknieciu wybierze go  na front i odda miejsce w hierarchi dla registera
            this.Parent.Controls.Remove(this);
        }

        private void passworduserBox_TextChanged(object sender, EventArgs e)
        {
            passworduserBox.UseSystemPasswordChar = true;
        }

        private void zalogujButton_Click(object sender, EventArgs e)
        {
            string passwordt = passworduserBox.Text;
            string logint = loginuserBox.Text;

            try
            {
                
                cmd = new SqlCommand ("SELECT * FROM Users WHERE  login = @LOGIN AND password = @PASSWORD", sqlcon);
                cmd.Parameters.AddWithValue("@LOGIN" , logint );
                cmd.Parameters.AddWithValue("@PASSWORD", passwordt);

                sqlcon.Open();

                dr = cmd.ExecuteReader();


                if (dr.HasRows)
                {


                    MessageBox.Show("Witaj!");
                    user_id = Userd_id(logint, passwordt);
					ProjektProgramowanie_MainPage.Form1 f2 = new ProjektProgramowanie_MainPage.Form1();
					Form1 f1 = new Form1();
					f1.Close();
                    f2.Id(user_id);
					f2.Show();




				}
                else
                {
                    MessageBox.Show("nieprawidłowy login lub hasło", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    passworduserBox.Clear();

                }
            }
            catch
            {
                MessageBox.Show("Brak połączenia.");
            }
            finally
            { 
                sqlcon.Close(); 
            }
            
        }
		public int Userd_id(string c, string d)
		{
			try
			{
				sqlcon.Close();
				string user_name = c.ToString();
				string user_password = d.ToString();
				string command = "SELECT id FROM Users WHERE login = '" + user_name + "' AND password = '" + user_password + "'";
				sqlcon.Open();
				SqlCommand cmd = new SqlCommand(command, sqlcon);
				SqlDataReader reader;
				reader = cmd.ExecuteReader();
				string userid = "";

				while (reader.Read())
				{
					userid = reader["id"].ToString();
				}

				int id = int.Parse(userid);
				reader.Close();
				sqlcon.Close();
				Console.WriteLine(id);
                return id;

			}
			catch (Exception ex)
			{
				Console.WriteLine("id błąd "+ex);
                return -1;
			}

		}
		
	}
}
