using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjektProgramowanie_MainPage
{
    public partial class Form1 : Form
    {
        public static string user_name;
        public static string password;
        public Form1()
        {
            InitializeComponent();
			
		}
        public void Userd_id(string c, string d)//przekazuje username i password do bookowania wizyt
        {
            try
            {
                user_name = c.ToString();
                password = d.ToString();
				ProjektProgramowanie2Dentysta.Form2 fbook = new ProjektProgramowanie2Dentysta.Form2();
				fbook.Userd_id(user_name, password);
				fbook.Show();//tą i 2 wcześniejsze linijki przenieść do przycisku otwierającego umawianie wizyt
			}
            catch
            {
                Console.Write("Błąd_main");
            }

        }
    }
}
