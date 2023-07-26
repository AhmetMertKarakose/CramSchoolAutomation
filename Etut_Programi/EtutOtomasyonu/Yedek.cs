using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EtutOtomasyonu
{
    public partial class Yedek : Form
    {
        public Yedek()
        {
            InitializeComponent();
        }
        sqlbaglantisi sqlbaglantisi = new sqlbaglantisi();

        private void BtnDosyaKonum_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "Yedek Dosyası | *.bak";
            fileDialog.CheckFileExists = false;
            fileDialog.Title = "Yedek dosyası seçiniz";
            fileDialog.FileName = "ETUTyedek.bak";
            fileDialog.ShowDialog();
            if (fileDialog.FileName != "ETUTyedek.bak")
            {
                TxtDosya.Text = fileDialog.FileName;
            }
        }

        private void BtnYedekle_Click_1(object sender, EventArgs e)
        {
            if (TxtDosya.Text.Count() > 0)
            {
                String komut = $@"BACKUP DATABASE [EtütOtomasyonu] TO DISK = N'{TxtDosya.Text}' WITH NOFORMAT, NOINIT, NAME = N'EtütOtomasyonu-Full Database Backup', SKIP, NOREWIND, NOUNLOAD,  STATS = 10";
                SqlCommand yedekle = new SqlCommand(komut, sqlbaglantisi.baglanti());
                yedekle.ExecuteNonQuery();
                MessageBox.Show("Yedekleme Başarılı", "Yedekleme",
               MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            sqlbaglantisi.baglanti().Close();
        }

        private void BtnGeriDön_Click_1(object sender, EventArgs e)
        {
            String komut = $@"USE [master]
RESTORE DATABASE [{textBox1.Text}] FROM  DISK = N'C:\Users\ahmet mert\OneDrive\Masaüstü\ETUTyedek.bak' WITH  FILE = 1,  MOVE N'EtütOtomasyonu' TO N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\{textBox1.Text}.mdf',  MOVE N'EtütOtomasyonu_log' TO N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\{textBox1.Text}_log.ldf',  NOUNLOAD,  STATS = 5
";
            SqlCommand sorgu = new SqlCommand(komut, sqlbaglantisi.baglanti());
            sorgu.ExecuteNonQuery();
            MessageBox.Show("Geri Yükleme Başarılı", "Geri Yükleme",
           MessageBoxButtons.OK, MessageBoxIcon.Information);
            sqlbaglantisi.baglanti().Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Yedek_Load(object sender, EventArgs e)
        {

        }
    }
}

