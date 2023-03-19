using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projektProgramowanie_logowanie
{
    public partial class login : UserControl
    {
        public login()
        {
            InitializeComponent();
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            register register = new register(); //nadajemy instancje
            this.Parent.Controls.Add(register); // user control(login) jest rodzicem wzglédem registera
            register.BringToFront(); //po kliknieciu wybierze go  na front i odda miejsce w hierarchi dla registera
            this.Parent.Controls.Remove(this);
        }
    }
}
