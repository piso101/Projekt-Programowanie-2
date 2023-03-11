using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjektProgramowanie_logowanie
{
    public partial class register : UserControl
    {
        public register()
        {
            InitializeComponent();
        }

        private void newregisterButton_Click(object sender, EventArgs e)
        {
            string login = newlogin.Text;
            string password = newpassword.Text;
            string email = newemail.Text;
            string number = phonenmbr.Text;


            
        }

        private void backbutton_Click(object sender, EventArgs e)
        {
            login login = new login();

            this.Parent.Controls.Add(login);
            login.BringToFront();
            this.Parent.Controls.Remove(this);
        }
    }
}
