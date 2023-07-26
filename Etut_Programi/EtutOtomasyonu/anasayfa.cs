using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace EtutOtomasyonu
{
    public partial class anasayfa : Form
    {
        public anasayfa()
        {
            InitializeComponent();
        }

        private sqlbaglantisi bgl = new sqlbaglantisi();

        
        void ButunDersler()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * From TBL_DERSLER", bgl.baglanti());
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        void ButunSiniflar()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * From TBL_SINIFLAR", bgl.baglanti());
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView2.DataSource = dt;
        }

        void ButunOgretmenler()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select OGRETMENID,ADSOYAD,TELEFON,MAIL,DERSADI From TBL_OGRETMEN inner join TBL_DERSLER on TBL_OGRETMEN.BRANS = TBL_DERSLER.DERSID", bgl.baglanti());
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView3.DataSource = dt;
        }
        
        
        void ButunOgrenciler()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select OGRENCIID,ADSOYAD,TELEFON,MAIL,SINIFADI From TBL_OGRENCI inner join TBL_SINIFLAR on TBL_OGRENCI.SINIFID = TBL_SINIFLAR.SINIFID", bgl.baglanti());
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView4.DataSource = dt;
        }

        
        void SonEklenenEtutler()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select Top 5 TBL_OGRETMEN.ADSOYAD as 'Öğretmen Adı',TBL_OGRENCI.ADSOYAD as 'Öğrenci Adı' From TBL_ETUT inner join TBL_OGRETMEN on TBL_ETUT.OGRETMENID = TBL_OGRETMEN.OGRETMENID inner join TBL_OGRENCI on TBL_ETUT.OGRENCIID = TBL_OGRENCI.OGRENCIID  order by ID desc", bgl.baglanti());
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView5.DataSource = dt;
        }

       
        void ToplamOgrenciSayisi()
        {
            SqlCommand komut = new SqlCommand("Select Count(OGRENCIID) From TBL_OGRENCI", bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                LblToplamOgrenci.Text = dr[0].ToString();
            }
            bgl.baglanti().Close();
        }

        void ToplamOgretmenSayisi()
        {
            SqlCommand komut = new SqlCommand("Select Count(OGRETMENID) From TBL_OGRETMEN", bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                LblToplamOgretmen.Text = dr[0].ToString();
            }
            bgl.baglanti().Close();
        }
      
       
        void ToplamSinifSayisi()
        {
            SqlCommand komut = new SqlCommand("Select Count(SINIFID) From TBL_SINIFLAR", bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                LblToplamSinif.Text = dr[0].ToString();
            }
            bgl.baglanti().Close();
        }
        
        void ToplamEtutSayisi()
        {
            SqlCommand komut = new SqlCommand("Select Count(ID) From TBL_ETUT", bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                LblToplamEtut.Text = dr[0].ToString();
            }
            bgl.baglanti().Close();
        }

        private void anasayfa_Load(object sender, EventArgs e)
        {
            
            ButunDersler();
            ButunSiniflar();
            ButunOgretmenler();
            ButunOgrenciler();
            SonEklenenEtutler();

            ToplamOgrenciSayisi();
            ToplamOgretmenSayisi();
            ToplamSinifSayisi();
            ToplamEtutSayisi();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           
            LblTarih.Text = DateTime.Now.ToShortDateString();
            LblSaat.Text = DateTime.Now.ToLongTimeString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            RaporlamaEkranı form1 = new RaporlamaEkranı();
            form1.ShowDialog(); 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Yedek fr = new Yedek();
            fr.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Yedek fr = new Yedek();
            fr.ShowDialog();
        }
    }
}
