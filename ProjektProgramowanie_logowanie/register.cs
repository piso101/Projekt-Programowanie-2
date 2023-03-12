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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProjektProgramowanie_logowanie
{
    public partial class register : UserControl
    {
        public register()
        {
            InitializeComponent();
        }



       // private SqlConnection sqlcon = new SqlConnection(@"Server=tcp:onlinegradebook.database.windows.net,1433;Initial Catalog=StoMaToLogicznie;Persist Security Info=False;User ID=theedziu;Password=Kacper123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
        
        
        
        private bool IsValidEmail(string email)
        {
            var trimmedEmail = email.Trim();
            if (trimmedEmail.EndsWith("."))
            {
                return false;
            }
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == trimmedEmail;
            }
            catch
            {
                return false;
            }
        }

        private void newregisterButton_Click(object sender, EventArgs e)
        {
            string login = newlogin.Text;
            string password = newpassword.Text;
            string email = newemail.Text;
            string number = phonenmbr.Text;

            try
            {
                SqlConnection sqlcon = new SqlConnection(@"Server=tcp:onlinegradebook.database.windows.net,1433;Initial Catalog=StoMaToLogicznie;Persist Security Info=False;User ID=theedziu;Password=Kacper123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");


                sqlcon.Open();
                SqlCommand command = sqlcon.CreateCommand();
                command.CommandText = "Select login from Users where login=@Login";
                command.Parameters.AddWithValue("@Login", login);
                SqlDataAdapter sda = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                sqlcon.Close();

                if (dt.Rows.Count <= 0)
                {

                    if ((login != "") && (password != "") && (password.Length > 8) && (email != "") && (number != "") && IsValidEmail(email) == true)
                    {
                        SqlCommand cmd = new SqlCommand("INSERT INTO Users(login,password,email,phone) VALUES('" + login + "','" + password + "','" + email + "'," + number + ")", sqlcon);
                        sqlcon.Open();
                        var x = cmd.ExecuteNonQuery();

                        sqlcon.Close();

                        if (x != 0)
                        {
                            MessageBox.Show("Zarejestrowano pomyślnie", "Zarejestrowano", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Nieprawidłowe dane logowania. Hasło musi mieć przynajmniej osiem znaków");
                    }
                }
                else
                {
                    MessageBox.Show("Podany login istnieje.");
                }
            }
            catch
            {
                MessageBox.Show("An error occurred while connecting to the database");
            }


        }

        private void backbutton_Click(object sender, EventArgs e)
        {
            login login = new login();

            this.Parent.Controls.Add(login);
            login.BringToFront();
            this.Parent.Controls.Remove(this);
        }

        private void phonenmbr_TextChanged(object sender, EventArgs e)
        {
        
        }

        private void phonenmbr_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void newpassword_TextChanged(object sender, EventArgs e)
        {
            newpassword.UseSystemPasswordChar = true;

        }
    }
}
