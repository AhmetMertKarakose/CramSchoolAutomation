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
    public partial class etut_Sayfasi : Form
    {
        sqlbaglantisi bgl = new sqlbaglantisi();

        TimeSpan fark;
        double farkGun;
        public etut_Sayfasi()
        {
            InitializeComponent();
        }
        void Listele()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select Top 20 ID,DERSADI as 'Ders Adı',TBL_OGRETMEN.ADSOYAD as 'Öğretmen Adı',TBL_OGRENCI.ADSOYAD as 'Öğrenci Adı',TARIH,SAAT,DURUM From TBL_ETUT inner join TBL_DERSLER on TBL_ETUT.DERSID = TBL_DERSLER.DERSID inner join TBL_OGRETMEN on TBL_ETUT.OGRETMENID = TBL_OGRETMEN.OGRETMENID inner join TBL_OGRENCI on TBL_ETUT.OGRENCIID = TBL_OGRENCI.OGRENCIID  order by ID desc", bgl.baglanti());
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        void DersListele()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * From TBL_DERSLER", bgl.baglanti());
            DataTable dt = new DataTable();
            da.Fill(dt);
            TxtDers.ValueMember = "DERSID";
            TxtDers.DisplayMember = "DERSADI";
            TxtDers.DataSource = dt;
        }

        void OgrenciListele()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * From TBL_OGRENCI", bgl.baglanti());
            DataTable dt = new DataTable();
            da.Fill(dt);
            TxtOgrenci.ValueMember = "OGRENCIID";
            TxtOgrenci.DisplayMember = "ADSOYAD";
            TxtOgrenci.DataSource = dt;
        }
        void Renklendir()
        {
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                fark = Convert.ToDateTime(dataGridView1.Rows[i].Cells[4].Value.ToString()) - Convert.ToDateTime(DateTime.Now.ToShortDateString());
                farkGun = fark.TotalDays;
                if (farkGun <= 0)
                {
                    dataGridView1.Rows[i].Cells[6].Value = true;
                    dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                }
                else
                {
                    dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Yellow;
                }

            }
        }
        private void etut_Sayfasi_Load(object sender, EventArgs e)
        {

            Listele();
            Renklendir();
            DersListele();
            OgrenciListele();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult secim = MessageBox.Show("Yeni Etüt Oluşturmak İstiyor Musun ?", "Soru Kutusu", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (secim == DialogResult.Yes)
            {
                if (TxtTarih.Text == "" || TxtSaat.Text == "")
                {
                    MessageBox.Show("Boş Alanı Doldurunuz...", "Bilgi Kutusu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    try
                    {
                        SqlCommand komut = new SqlCommand("insert into TBL_ETUT(DERSID,OGRETMENID,OGRENCIID,TARIH,SAAT) values (@P1,@P2,@P3,@P4,@P5)", bgl.baglanti());
                        komut.Parameters.AddWithValue("@P1", TxtDers.SelectedValue);
                        komut.Parameters.AddWithValue("@P2", TxtOgretmen.SelectedValue);
                        komut.Parameters.AddWithValue("@P3", TxtOgrenci.SelectedValue);
                        komut.Parameters.AddWithValue("@P4", TxtTarih.Text);
                        komut.Parameters.AddWithValue("@P5", TxtSaat.Text);
                        komut.ExecuteNonQuery();
                        bgl.baglanti().Close();
                        MessageBox.Show("Yeni Etüt Sisteme Başarıyla Eklendi...", "Bilgi Kutusu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Listele();
                        TxtTarih.Text = "";
                        TxtSaat.Text = "";
                        TxtId.Text = "";
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

        private void TxtDers_SelectedIndexChanged(object sender, EventArgs e)
        {

            SqlDataAdapter da = new SqlDataAdapter("Select * From TBL_OGRETMEN where BRANS=" + TxtDers.SelectedValue, bgl.baglanti());
            DataTable dt = new DataTable();
            da.Fill(dt);
            TxtOgretmen.ValueMember = "OGRETMENID";
            TxtOgretmen.DisplayMember = "ADSOYAD";
            TxtOgretmen.DataSource = dt;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult secim = MessageBox.Show("Etüt Düzenlemek İstiyor Musun ?", "Soru Kutusu", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (secim == DialogResult.Yes)
            {
                if (TxtTarih.Text == "" || TxtSaat.Text == "")
                {
                    MessageBox.Show("Boş Alanı Doldurunuz...", "Bilgi Kutusu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    try
                    {
                        SqlCommand komut = new SqlCommand("Update TBL_ETUT set DERSID=@P1,OGRETMENID=@P2,OGRENCIID=@P3,TARIH=@P4,SAAT=@P5 where ID=@P6", bgl.baglanti());
                        komut.Parameters.AddWithValue("@P1", TxtDers.SelectedValue);
                        komut.Parameters.AddWithValue("@P2", TxtOgretmen.SelectedValue);
                        komut.Parameters.AddWithValue("@P3", TxtOgrenci.SelectedValue);
                        komut.Parameters.AddWithValue("@P4", TxtTarih.Text);
                        komut.Parameters.AddWithValue("@P5", TxtSaat.Text);
                        komut.Parameters.AddWithValue("@P6", TxtId.Text);
                        komut.ExecuteNonQuery();
                        bgl.baglanti().Close();
                        MessageBox.Show("Etüt Başarıyla Güncellendi...", "Bilgi Kutusu", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

            DialogResult secim = MessageBox.Show("Etütü Silmek İstiyor Musun ?", "Soru Kutusu", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (secim == DialogResult.Yes)
            {
                if (TxtTarih.Text == "" || TxtSaat.Text == "")
                {
                    MessageBox.Show("Boş Alanı Doldurunuz...", "Bilgi Kutusu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    try
                    {
                        SqlCommand komut = new SqlCommand("Delete From TBL_ETUT where ID=@P1", bgl.baglanti());
                        komut.Parameters.AddWithValue("@P1", TxtId.Text);
                        komut.ExecuteNonQuery();
                        bgl.baglanti().Close();
                        TxtId.Text = "";
                        TxtTarih.Text = "";
                        TxtSaat.Text = "";
                        MessageBox.Show("Etüt Başarıyla Silindi...", "Bilgi Kutusu", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                TxtDers.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                TxtOgretmen.Text = dataGridView1.Rows[number].Cells[2].Value.ToString();
                TxtOgrenci.Text = dataGridView1.Rows[number].Cells[3].Value.ToString();
                TxtTarih.Text = dataGridView1.Rows[number].Cells[4].Value.ToString();
                TxtSaat.Text = dataGridView1.Rows[number].Cells[5].Value.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Hata Oluştu...", "Bilgi Kutusu", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


    }
}
