using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EtutOtomasyonu
{
    public partial class ÇıktıEkranı : Form
    {
        public ÇıktıEkranı()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.tBL_OGRENCITableAdapter.Fill(this.etütOtomasyonuDataSet.TBL_OGRENCI);
            this.sınıflarTableAdapter.Fill(this.etütOtomasyonuDataSet.Sınıflar);
            this.ogrenciBulmaTableAdapter.Fill(this.etütOtomasyonuDataSet.OgrenciBulma);
            this.etutDurumGosterTableAdapter.Fill(this.etütOtomasyonuDataSet.EtutDurumGoster);
            this.dersBulmaTableAdapter.Fill(this.etütOtomasyonuDataSet.DersBulma);
            this.adminK_AdıTableAdapter.Fill(this.etütOtomasyonuDataSet.AdminK_Adı);
            this.tBL_SINIFLARTableAdapter.Fill(this.etütOtomasyonuDataSet.TBL_SINIFLAR);
            this.tBL_SILINENETUTKAYITLARITableAdapter.Fill(this.etütOtomasyonuDataSet.TBL_SILINENETUTKAYITLARI);
            this.tBL_DERSLERTableAdapter.Fill(this.etütOtomasyonuDataSet.TBL_DERSLER);
            this.tBL_ETUTTableAdapter.Fill(this.etütOtomasyonuDataSet.TBL_ETUT);

            this.reportViewer1.RefreshReport();
           
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
