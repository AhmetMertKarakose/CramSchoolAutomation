using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace EtutOtomasyonu
{
    public partial class GirisEkrani : Form
    {
        sqlbaglantisi bag = new sqlbaglantisi();
        public GirisEkrani()
        {
            InitializeComponent();
        }

        private void btn_giris_Click(object sender, EventArgs e)
        {
            try
            {

                SqlCommand komut = new SqlCommand("select * from TBL_ADMINLISTESI where YETKI='Admin' and K_ADI='" + textBox1.Text + "'and SIFRE='" + textBox2.Text + "'   ", bag.baglanti());
                SqlDataReader dr = komut.ExecuteReader();
                if (dr.Read())
                {
                    new Menu().Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Hatalı giriş yaptınız.", "Giriş başarısız", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("Bağlanmaya çalıştığınız sunucu bulunamadı ya da hatalı yazdınız.", "Veritabanı bağlantısı hatalı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                SqlCommand komut = new SqlCommand("select * from TBL_ADMINLISTESI where YETKI='Personel' and K_ADI='" + textBox3.Text + "'and SIFRE='" + textBox4.Text + "'", bag.baglanti());
                SqlDataReader dr = komut.ExecuteReader();
                if (dr.Read())
                {
                    new PersonelGirişEkranı().Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Hatalı giriş yaptınız.", "Giriş başarısız", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("Bağlanmaya çalıştığınız sunucu bulunamadı ya da hatalı yazdınız.", "Veritabanı bağlantısı hatalı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message);
            }
        }

        private void GirisEkrani_Load(object sender, EventArgs e)
        {

        }
    }
}