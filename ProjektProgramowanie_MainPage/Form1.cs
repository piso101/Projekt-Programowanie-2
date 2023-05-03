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
using DevExpress.XtraEditors;
using DevExpress.Data;
using System.Diagnostics;

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


        private void doctorBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.doctorBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.stoMaToLogiczneDataSet);

        }
        private SqlConnection con = new SqlConnection(@"Server=tcp:onlinegradebook.database.windows.net,1433;Initial Catalog=StoMaToLogiczne;Persist Security Info=False;User ID=theedziu;Password=Kacper123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");

        private void Form1_Load(object sender, EventArgs e)
        {
            
            con.Open();
            SqlDataAdapter da1 = new SqlDataAdapter("Select city FROM doctor",con);
            DataTable dt_city = new DataTable();
            da1.Fill(dt_city);
            Combobox_miasta.DataSource= dt_city;
            Combobox_miasta.DisplayMember = "city";
            Combobox_miasta.ValueMember = "city";
            con.Close();



        }


        private void Szukajbtn_Click(object sender, EventArgs e)
        {
            string miasto = Combobox_miasta.Text;
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("Select * FROM doctor WHERE city = '"+miasto+"'", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            doctorDataGridView.DataSource = dt;
            con.Close();
        }

        private void Umowionespotkaniabtn_Click(object sender, EventArgs e)
        {

        }
        private string wybranylekarz;

        private void doctorDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (doctorDataGridView.Columns[e.ColumnIndex].Name=="Wybieram")
            {
                Debug.WriteLine("Wybrano lekarza");
                wybranylekarz = doctorDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
                Debug.WriteLine(wybranylekarz);
                label1.Text = wybranylekarz;//zwracam id lekarza
            }
        }

    }

		private void Form1_Load(object sender, EventArgs e)
		{

		}
	}

}
