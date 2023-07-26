namespace EtutOtomasyonu
{
    partial class PersonelGirişEkranı
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PersonelGirişEkranı));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ıDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dERSIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oGRETMENIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oGRENCIIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tARIHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sAATDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dURUMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tBLETUTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.etütOtomasyonuDataSet1 = new EtutOtomasyonu.EtütOtomasyonuDataSet1();
            this.tBL_ETUTTableAdapter = new EtutOtomasyonu.EtütOtomasyonuDataSet1TableAdapters.TBL_ETUTTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLETUTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.etütOtomasyonuDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ıDDataGridViewTextBoxColumn,
            this.dERSIDDataGridViewTextBoxColumn,
            this.oGRETMENIDDataGridViewTextBoxColumn,
            this.oGRENCIIDDataGridViewTextBoxColumn,
            this.tARIHDataGridViewTextBoxColumn,
            this.sAATDataGridViewTextBoxColumn,
            this.dURUMDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tBLETUTBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1226, 450);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ıDDataGridViewTextBoxColumn
            // 
            this.ıDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.ıDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.ıDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ıDDataGridViewTextBoxColumn.Name = "ıDDataGridViewTextBoxColumn";
            this.ıDDataGridViewTextBoxColumn.ReadOnly = true;
            this.ıDDataGridViewTextBoxColumn.Width = 125;
            // 
            // dERSIDDataGridViewTextBoxColumn
            // 
            this.dERSIDDataGridViewTextBoxColumn.DataPropertyName = "DERSID";
            this.dERSIDDataGridViewTextBoxColumn.HeaderText = "DERSID";
            this.dERSIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dERSIDDataGridViewTextBoxColumn.Name = "dERSIDDataGridViewTextBoxColumn";
            this.dERSIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // oGRETMENIDDataGridViewTextBoxColumn
            // 
            this.oGRETMENIDDataGridViewTextBoxColumn.DataPropertyName = "OGRETMENID";
            this.oGRETMENIDDataGridViewTextBoxColumn.HeaderText = "OGRETMENID";
            this.oGRETMENIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.oGRETMENIDDataGridViewTextBoxColumn.Name = "oGRETMENIDDataGridViewTextBoxColumn";
            this.oGRETMENIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // oGRENCIIDDataGridViewTextBoxColumn
            // 
            this.oGRENCIIDDataGridViewTextBoxColumn.DataPropertyName = "OGRENCIID";
            this.oGRENCIIDDataGridViewTextBoxColumn.HeaderText = "OGRENCIID";
            this.oGRENCIIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.oGRENCIIDDataGridViewTextBoxColumn.Name = "oGRENCIIDDataGridViewTextBoxColumn";
            this.oGRENCIIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // tARIHDataGridViewTextBoxColumn
            // 
            this.tARIHDataGridViewTextBoxColumn.DataPropertyName = "TARIH";
            this.tARIHDataGridViewTextBoxColumn.HeaderText = "TARIH";
            this.tARIHDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tARIHDataGridViewTextBoxColumn.Name = "tARIHDataGridViewTextBoxColumn";
            this.tARIHDataGridViewTextBoxColumn.Width = 125;
            // 
            // sAATDataGridViewTextBoxColumn
            // 
            this.sAATDataGridViewTextBoxColumn.DataPropertyName = "SAAT";
            this.sAATDataGridViewTextBoxColumn.HeaderText = "SAAT";
            this.sAATDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sAATDataGridViewTextBoxColumn.Name = "sAATDataGridViewTextBoxColumn";
            this.sAATDataGridViewTextBoxColumn.Width = 125;
            // 
            // dURUMDataGridViewTextBoxColumn
            // 
            this.dURUMDataGridViewTextBoxColumn.DataPropertyName = "DURUM";
            this.dURUMDataGridViewTextBoxColumn.HeaderText = "DURUM";
            this.dURUMDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dURUMDataGridViewTextBoxColumn.Name = "dURUMDataGridViewTextBoxColumn";
            this.dURUMDataGridViewTextBoxColumn.Width = 125;
            // 
            // tBLETUTBindingSource
            // 
            this.tBLETUTBindingSource.DataMember = "TBL_ETUT";
            this.tBLETUTBindingSource.DataSource = this.etütOtomasyonuDataSet1;
            // 
            // etütOtomasyonuDataSet1
            // 
            this.etütOtomasyonuDataSet1.DataSetName = "EtütOtomasyonuDataSet1";
            this.etütOtomasyonuDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tBL_ETUTTableAdapter
            // 
            this.tBL_ETUTTableAdapter.ClearBeforeFill = true;
            // 
            // PersonelGirişEkranı
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1226, 450);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PersonelGirişEkranı";
            this.Text = "Etüt Listesi";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLETUTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.etütOtomasyonuDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private EtütOtomasyonuDataSet1 etütOtomasyonuDataSet1;
        private System.Windows.Forms.BindingSource tBLETUTBindingSource;
        private EtütOtomasyonuDataSet1TableAdapters.TBL_ETUTTableAdapter tBL_ETUTTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dERSIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oGRETMENIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oGRENCIIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tARIHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sAATDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dURUMDataGridViewTextBoxColumn;
    }
}