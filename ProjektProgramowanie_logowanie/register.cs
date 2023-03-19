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

namespace projektProgramowanie_logowanie
{
    public partial class register : UserControl
    {
        public register()
        {
            InitializeComponent();
        }

        SqlConnection sqlcon = new SqlConnection(@"Server=tcp:onlinegradebook.database.windows.net,1433;Initial Catalog=StoMaToLogiczne;Persist Security Info=False;User ID=theedziu;Password=Kacper123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
        
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
        private void button1_Click(object sender, EventArgs e)
        {
            login login = new login();

            this.Parent.Controls.Add(login);
            login.BringToFront();
            this.Parent.Controls.Remove(this);
        }

        private void newregisterButton_Click(object sender, EventArgs e)
        {
            string login = newlogin.Text;
            string password = newpassword.Text;
            string email = newemail.Text;
            string number = phonenmbr.Text;



                sqlcon.Open();//
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
                        sqlcon.Open();

                        string selectStatement = "SELECT TOP 1 id FROM Users ORDER BY ID DESC";
                        SqlCommand selectCommand = new SqlCommand(selectStatement, sqlcon);
                        int lastId = Convert.ToInt32(selectCommand.ExecuteScalar());

                        
                        int newId = lastId + 1;

                        
                        string insertStatement = "INSERT INTO Users (id,login,password,email,phone ) VALUES (@ID, @FirstName, @LastName, @Email, @Password)";
                        SqlCommand cmd = new SqlCommand(insertStatement, sqlcon);
                        cmd.Parameters.AddWithValue("@ID", newId);
                        cmd.Parameters.AddWithValue("@FirstName", login);
                        cmd.Parameters.AddWithValue("@LastName", password);
                        cmd.Parameters.AddWithValue("@Email", email);
                        cmd.Parameters.AddWithValue("@Password", number);

                        cmd.ExecuteNonQuery();


                        var x = cmd.ExecuteNonQuery();


                        sqlcon.Close();



                        if (x != 0)
                        {
                            MessageBox.Show("Zarejestrowano pomyślnie", "Zarejestrowano", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("coś poszło nie tak");
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

        private void phonenmbr_TextChanged(object sender, EventArgs e)
        {

        }

        private void phonenmbr_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
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
