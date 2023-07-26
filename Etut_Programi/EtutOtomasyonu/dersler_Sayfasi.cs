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
    public partial class dersler_Sayfasi : Form
    {  
        sqlbaglantisi bgl = new sqlbaglantisi();

        public dersler_Sayfasi()
        {
            InitializeComponent();
        }
        void DersListele()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select DERSID as 'Ders Numarası',DERSADI 'Dersin Adı' From TBL_DERSLER", bgl.baglanti());
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void dersler_Sayfasi_Load(object sender, EventArgs e)
        {
            DersListele();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            DialogResult secim = MessageBox.Show(TxtDers.Text + " Adlı Dersi Kaydetmek İstiyor Musun ?", "Soru Kutusu", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (secim == DialogResult.Yes)
            {
                if (TxtDers.Text == "")
                {
                    MessageBox.Show("Boş Alanı Doldurunuz...", "Bilgi Kutusu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    try
                    {
                        SqlCommand komut = new SqlCommand("insert into TBL_DERSLER(DERSADI) values (@P1)", bgl.baglanti());
                        komut.Parameters.AddWithValue("@P1", TxtDers.Text);
                        komut.ExecuteNonQuery();
                        bgl.baglanti().Close();
                        MessageBox.Show("Ders Başarıyla Eklendi...", "Bilgi Kutusu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        DersListele();
                        TxtDers.Text = "";
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Hata Oluştu...", "Bilgi Kutusu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else
            {
                DersListele();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
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
                        SqlCommand komut = new SqlCommand("Delete From TBL_DERSLER where DERSID='"+ textBox2.Text+"'", bgl.baglanti());
                      
                        komut.ExecuteNonQuery();
                        bgl.baglanti().Close();
                        DersListele();
                        TxtSilinecek.Text = "";
                        MessageBox.Show("Ders Silme Başarılı", "Bilgi Kutusu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception hata)
                    {
                        MessageBox.Show("Değeri Doğru Girdiğinize Emin Olun...Hata Mesajı: "
                            +hata.Message, "Bilgi Kutusu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    DersListele();
                }
            }
        }
    }
}
