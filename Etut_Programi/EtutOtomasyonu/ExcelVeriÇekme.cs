using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;




namespace EtutOtomasyonu
{
    public partial class ExcelVeriÇekme : Form
    {
        public ExcelVeriÇekme()
        {
            InitializeComponent();
        }

        sqlbaglantisi baglantisi = new sqlbaglantisi();
        OleDbConnection baglanti = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\ahmet mert\Desktop\Ogrenciverileri.xlsx; Extended Properties = 'Excel 12.0 xml;HDR=YES;'");

        void veriler()
        {
            OleDbDataAdapter da = new OleDbDataAdapter("Select * From [Sayfa1$]", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }



        private void Form3_Load(object sender, EventArgs e)
        {
           veriler();
        }

    }
}
