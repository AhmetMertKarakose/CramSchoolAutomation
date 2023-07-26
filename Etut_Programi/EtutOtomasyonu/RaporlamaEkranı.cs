using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace EtutOtomasyonu
{
    public partial class RaporlamaEkranı : Form
    {
        public RaporlamaEkranı()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'etütOtomasyonuDataSet3.TBL_ETUT' table. You can move, or remove it, as needed.
            this.tBL_ETUTTableAdapter.Fill(this.etütOtomasyonuDataSet3.TBL_ETUT);
            SqlConnection baglantı = new SqlConnection("Data Source=AHMETMERT;Initial Catalog=EtütOtomasyonu;Integrated Security=True");
            baglantı.Open();
            SqlCommand komut = new SqlCommand("select * from TBL_ETUT", baglantı);
            komut.ExecuteNonQuery();
            SqlDataAdapter adtr = new SqlDataAdapter(komut);
            DataTable tablo = new DataTable();  
            adtr.Fill(tablo);
            dataGridView1.DataSource= tablo;
            baglantı.Close(); 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ÇıktıEkranı frm2 = new ÇıktıEkranı();
            frm2.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
