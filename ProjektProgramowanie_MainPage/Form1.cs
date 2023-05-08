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
        public static int user_id;
        public Form1()
        {
            InitializeComponent();
			
		}
       

		private void Form1_Load(object sender, EventArgs e)
		{
			ProjektProgramowanie2Dentysta.Form2 fbook = new ProjektProgramowanie2Dentysta.Form2();
            fbook.Userd_id(user_id);
			fbook.Show();//tą i 2 wcześniejsze linijki przenieść do przycisku otwierającego umawianie wizyt
            Console.WriteLine("form1 " + user_id);
		}
        public void Id(int id)
        {
            user_id = id;
        }
	}
}
