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

                    projektProgramowanie_logowanie.Form1 f1 = new projektProgramowanie_logowanie.Form1();
                    ProjektProgramowanie_MainPage.Form1 f2 = new ProjektProgramowanie_MainPage.Form1();
                    f1.Hide();
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
    }
}
