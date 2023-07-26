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
    public partial class Ayarlar : Form
    {
        public Ayarlar()
        {
            InitializeComponent();
        }
        
        sqlbaglantisi bag = new sqlbaglantisi();
        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult tus;
            tus = colorDialog1.ShowDialog();
            if (tus == DialogResult.OK)
            {

                EtutOtomasyonu.Menu.anasayfaarkaplanrengi = colorDialog1.Color;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult tus;
            tus = fontDialog1.ShowDialog();
            if (tus == DialogResult.OK)
            {

                EtutOtomasyonu.Menu.anasayfafont = fontDialog1.Font;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                

                SqlCommand komut = new SqlCommand("insert into TBL_ADMINLISTESI(K_ADI,SIFRE)   values('" + textBox1.Text + "','" + textBox2.Text + "') ", bag.baglanti());
                komut.ExecuteNonQuery();
                MessageBox.Show("Başarılı Admin Ekleme İşlemi !");
                textBox1.Text = "";
                textBox2.Text = "";
            }
            catch (Exception hata)
            {

                MessageBox.Show(hata.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                

                SqlCommand komut = new SqlCommand("delete from TBL_ADMINLISTESI where K_ADI='" + textBox4.Text + "'and SIFRE='" + textBox3.Text + "'  ", bag.baglanti());
                komut.ExecuteNonQuery();
                MessageBox.Show("Başarılı Admin Silme İşlemi !");
                textBox3.Text = "";
                textBox4.Text = "";
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message);
            }
        }
        private void Ayarlar_Load(object sender, EventArgs e)
        {

        }
    }
}
