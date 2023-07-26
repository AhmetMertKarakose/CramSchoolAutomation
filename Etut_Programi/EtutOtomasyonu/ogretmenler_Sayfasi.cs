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
    public partial class ogretmenler_Sayfasi : Form
    {  
        sqlbaglantisi bgl = new sqlbaglantisi();
        public ogretmenler_Sayfasi()
        {
            InitializeComponent();
        } 
        void Listele()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select OGRETMENID,ADSOYAD,TELEFON,MAIL,DERSADI From TBL_OGRETMEN inner join TBL_DERSLER on TBL_OGRETMEN.BRANS = TBL_DERSLER.DERSID", bgl.baglanti());
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        void BransListele()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * From TBL_DERSLER", bgl.baglanti());
            DataTable dt = new DataTable();
            da.Fill(dt);
            TxtBrans.ValueMember = "DERSID";
            TxtBrans.DisplayMember = "DERSADI";
            TxtBrans.DataSource = dt;
        }

        private void ogretmenler_Sayfasi_Load(object sender, EventArgs e)
        {
            Listele();
            BransListele();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            DialogResult secim = MessageBox.Show(TxtAdSoyad.Text + " Adlı Öğretmeni Kaydetmek İstiyor Musun ?", "Soru Kutusu", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (secim == DialogResult.Yes)
            {
                if (TxtAdSoyad.Text == "")
                {
                    MessageBox.Show("Boş Alanı Doldurunuz...", "Bilgi Kutusu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    try
                    {
                 
                        SqlCommand komut = new SqlCommand("insert into TBL_OGRETMEN(ADSOYAD,TELEFON,MAIL,BRANS) values (@P1,@P2,@P3,@P4)", bgl.baglanti());
                        komut.Parameters.AddWithValue("@P1", TxtAdSoyad.Text);
                        komut.Parameters.AddWithValue("@P2", TxtTelefon.Text);
                        komut.Parameters.AddWithValue("@P3", TxtMail.Text);
                        komut.Parameters.AddWithValue("@P4", TxtBrans.SelectedValue);
                        komut.ExecuteNonQuery();
                        bgl.baglanti().Close();
                        MessageBox.Show("Öğretmen Sisteme Başarıyla Eklendi...", "Bilgi Kutusu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Listele();
                        TxtAdSoyad.Text = "";
                        TxtMail.Text = "";
                        TxtId.Text = "";
                        TxtTelefon.Text = "";
                    }
                    catch (Exception hata)
                    {
                        MessageBox.Show("Hata Oluştu... "+hata.Message, "Bilgi Kutusu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else
            {
                Listele();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            DialogResult secim = MessageBox.Show(TxtAdSoyad.Text + " Adlı Öğretmeni Düzenlemek İstiyor Musun ?", "Soru Kutusu", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (secim == DialogResult.Yes)
            {
                if (TxtAdSoyad.Text == "")
                {
                    MessageBox.Show("Boş Alanı Doldurunuz...", "Bilgi Kutusu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    try
                    {
                        SqlCommand komut = new SqlCommand("Update TBL_OGRETMEN set ADSOYAD=@P1,TELEFON=@P2,MAIL=@P3,BRANS=@P4 where OGRETMENID=@P5", bgl.baglanti());
                        komut.Parameters.AddWithValue("@P1", TxtAdSoyad.Text);
                        komut.Parameters.AddWithValue("@P2", TxtTelefon.Text);
                        komut.Parameters.AddWithValue("@P3", TxtMail.Text);
                        komut.Parameters.AddWithValue("@P4", TxtBrans.SelectedValue);
                        komut.Parameters.AddWithValue("@P5", TxtId.Text);
                        komut.ExecuteNonQuery();
                        bgl.baglanti().Close();
                        MessageBox.Show("Öğretmen Başarıyla Güncellendi...", "Bilgi Kutusu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Listele();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Hata Oluştu...", "Bilgi Kutusu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else
            {
                Listele();
            }
        }

        private void TxtSilinecek_Click(object sender, EventArgs e)
        {

            DialogResult secim = MessageBox.Show(TxtAdSoyad.Text + " Adlı Öğretmeni Silmek İstiyor Musun ?", "Soru Kutusu", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (secim == DialogResult.Yes)
            {
                if (TxtAdSoyad.Text == "")
                {
                    MessageBox.Show("Boş Alanı Doldurunuz...", "Bilgi Kutusu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    try
                    {
                        SqlCommand komut = new SqlCommand("Delete From TBL_OGRETMEN where OGRETMENID=@P1", bgl.baglanti());
                        komut.Parameters.AddWithValue("@P1", TxtId.Text);
                        komut.ExecuteNonQuery();
                        bgl.baglanti().Close();
                        TxtId.Text = "";
                        TxtAdSoyad.Text = "";
                        TxtMail.Text = "";
                        TxtTelefon.Text = "";
                        MessageBox.Show("Öğretmen Başarıyla Silindi...", "Bilgi Kutusu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Listele();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Hata Oluştu...", "Bilgi Kutusu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else
            {
                Listele();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int number = dataGridView1.SelectedCells[0].RowIndex;

            try
            {
                TxtId.Text = dataGridView1.Rows[number].Cells[0].Value.ToString();
                TxtAdSoyad.Text = dataGridView1.Rows[number].Cells[1].Value.ToString();
                TxtTelefon.Text = dataGridView1.Rows[number].Cells[2].Value.ToString();
                TxtMail.Text = dataGridView1.Rows[number].Cells[3].Value.ToString();
                TxtBrans.Text = dataGridView1.Rows[number].Cells[4].Value.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Hata Oluştu...", "Bilgi Kutusu", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void TxtBrans_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }
    }
}
