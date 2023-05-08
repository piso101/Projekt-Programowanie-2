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
using System.Diagnostics;

namespace ProjektProgramowanie_MainPage
{
    public partial class Form1 : Form
    {
        public static int user_id;
		private SqlConnection con = new SqlConnection(@"Server=tcp:onlinegradebook.database.windows.net,1433;Initial Catalog=StoMaToLogiczne;Persist Security Info=False;User ID=theedziu;Password=Kacper123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
		public Form1()
        {
            InitializeComponent();
			
		}


		private void Form1_Load(object sender, EventArgs e)
		{
			umowione_wizyty1.Hide();
		}
        public void Id(int id)
        {
            user_id = id;
        }

		private void umow_wizyte_btn_Click(object sender, EventArgs e)
		{
			ProjektProgramowanie2Dentysta.Form2 fbook = new ProjektProgramowanie2Dentysta.Form2();
			fbook.Userd_id(user_id);
			fbook.Show();//tą i 2 wcześniejsze linijki przenieść do przycisku otwierającego umawianie wizyt
			Console.WriteLine("form1 " + user_id);
		}

		private void Umowionespotkaniabtn_Click(object sender, EventArgs e)
		{
			umowione_wizyty1.Show();
			umowione_wizyty1.BringToFront();
		}
	}

}
