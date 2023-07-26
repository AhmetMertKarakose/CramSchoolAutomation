using System;
using System.Drawing;
using System.Windows.Forms;

namespace EtutOtomasyonu
{
    public partial class Menu : Form
    {
        public static Color anasayfaarkaplanrengi = anasayfa.DefaultBackColor;
        public static Font anasayfafont = anasayfa.DefaultFont;

        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            MdiParentOlarakAc(new anasayfa());
        }

        private void MdiParentOlarakAc(Form form)
        {
            form.MdiParent = this;
            form.Show();
        }

        private void anasayfaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            anasayfa ChildForm = new anasayfa();
            ChildForm.BackColor = anasayfaarkaplanrengi;
            ChildForm.Font = anasayfafont;

            MdiParentOlarakAc(ChildForm);
        }

        private void dersİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MdiParentOlarakAc(new dersler_Sayfasi());
        }

        private void sınıfİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MdiParentOlarakAc(new sinif_Islemleri());
        }

        private void öğretmenİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MdiParentOlarakAc(new ogretmenler_Sayfasi());
        }

        private void öğrenciİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MdiParentOlarakAc(new ogrenci_Sayfasi());
        }

        private void etütOluşturmaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MdiParentOlarakAc(new etut_Sayfasi());
        }

        private void bugünkiEtütlerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MdiParentOlarakAc(new bugunki_Etutler());
        }

        private void tümEtütlerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MdiParentOlarakAc(new tum_Etutler());
        }

        private void ayarlarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MdiParentOlarakAc(new Ayarlar());
        }

        private void Menu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.GirisEkrani.Close();
        }



        private void excelToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            ExcelVeriÇekme form3 = new ExcelVeriÇekme();
            form3.ShowDialog();
        }
    }
}