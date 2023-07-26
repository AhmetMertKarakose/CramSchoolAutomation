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
    public partial class sinif_Islemleri : Form
    {
        public sinif_Islemleri()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        void SinifListele()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select SINIFID as 'Sınıfın Numarası',SINIFADI as 'Sınıfın Adı' From TBL_SINIFLAR", bgl.baglanti());
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void sinif_Islemleri_Load(object sender, EventArgs e)
        {
            SinifListele();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult secim = MessageBox.Show(TxtSinif.Text + " Adlı Sınıfı Kaydetmek İstiyor Musun ?", "Soru Kutusu", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (secim == DialogResult.Yes)
            {
                if (TxtSinif.Text == "")
                {
                    MessageBox.Show("Boş Alanı Doldurunuz...", "Bilgi Kutusu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    try
                    {
                        SqlCommand komut = new SqlCommand("insert into TBL_SINIFLAR(SINIFADI) values (@P1)", bgl.baglanti());
                        komut.Parameters.AddWithValue("@P1", TxtSinif.Text);
                        komut.ExecuteNonQuery();
                        bgl.baglanti().Close();
                        MessageBox.Show("Sınıf Başarıyla Eklendi...", "Bilgi Kutusu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        SinifListele();
                        TxtSinif.Text = "";
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Hata Oluştu...", "Bilgi Kutusu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else
            {
                SinifListele();
            }
        }

        private void TxtSilinecek_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Boş Alanı Doldurunuz...", "Bilgi Kutusu", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                DialogResult secim = MessageBox.Show("Silme İşlemi Yapmak İstediğinizden Emin Misiniz ?", "Soru Kutusu", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (secim == DialogResult.Yes)
                {
                    try
                    {
                        SqlCommand komut = new SqlCommand("Delete From TBL_SINIFLAR where SINIFID=@P1", bgl.baglanti());
                        komut.Parameters.AddWithValue("@P1", textBox1.Text);
                        komut.ExecuteNonQuery();
                        bgl.baglanti().Close();
                        SinifListele();
                        TxtSilinecek.Text = "";
                        MessageBox.Show("Sınıf Silme Başarılı", "Bilgi Kutusu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Değeri Doğru Girdiğinize Emin Olun...", "Bilgi Kutusu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    SinifListele();
                }
            }
        }
    }
}
