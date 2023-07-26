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
    public partial class PersonelGirişEkranı : Form
    {
        public PersonelGirişEkranı()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
           
            this.tBL_ETUTTableAdapter.Fill(this.etütOtomasyonuDataSet1.TBL_ETUT);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
