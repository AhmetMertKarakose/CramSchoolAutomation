namespace EtutOtomasyonu
{
    partial class ÇıktıEkranı
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ÇıktıEkranı));
            this.tBLOGRENCIBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.etütOtomasyonuDataSet = new EtutOtomasyonu.EtütOtomasyonuDataSet();
            this.tBLETUTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer2 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tBL_ETUTTableAdapter = new EtutOtomasyonu.EtütOtomasyonuDataSetTableAdapters.TBL_ETUTTableAdapter();
            this.tBLDERSLERBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tBL_DERSLERTableAdapter = new EtutOtomasyonu.EtütOtomasyonuDataSetTableAdapters.TBL_DERSLERTableAdapter();
            this.tBLSILINENETUTKAYITLARIBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tBL_SILINENETUTKAYITLARITableAdapter = new EtutOtomasyonu.EtütOtomasyonuDataSetTableAdapters.TBL_SILINENETUTKAYITLARITableAdapter();
            this.tBLSINIFLARBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tBL_SINIFLARTableAdapter = new EtutOtomasyonu.EtütOtomasyonuDataSetTableAdapters.TBL_SINIFLARTableAdapter();
            this.adminKAdıBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.adminK_AdıTableAdapter = new EtutOtomasyonu.EtütOtomasyonuDataSetTableAdapters.AdminK_AdıTableAdapter();
            this.dersBulmaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dersBulmaTableAdapter = new EtutOtomasyonu.EtütOtomasyonuDataSetTableAdapters.DersBulmaTableAdapter();
            this.etutDurumGosterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.etutDurumGosterTableAdapter = new EtutOtomasyonu.EtütOtomasyonuDataSetTableAdapters.EtutDurumGosterTableAdapter();
            this.ogrenciBulmaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ogrenciBulmaTableAdapter = new EtutOtomasyonu.EtütOtomasyonuDataSetTableAdapters.OgrenciBulmaTableAdapter();
            this.sınıflarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sınıflarTableAdapter = new EtutOtomasyonu.EtütOtomasyonuDataSetTableAdapters.SınıflarTableAdapter();
            this.tBL_OGRENCITableAdapter = new EtutOtomasyonu.EtütOtomasyonuDataSetTableAdapters.TBL_OGRENCITableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tBLOGRENCIBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.etütOtomasyonuDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLETUTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLDERSLERBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLSILINENETUTKAYITLARIBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLSINIFLARBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminKAdıBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dersBulmaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.etutDurumGosterBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrenciBulmaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sınıflarBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tBLOGRENCIBindingSource
            // 
            this.tBLOGRENCIBindingSource.DataMember = "TBL_OGRENCI";
            this.tBLOGRENCIBindingSource.DataSource = this.etütOtomasyonuDataSet;
            // 
            // etütOtomasyonuDataSet
            // 
            this.etütOtomasyonuDataSet.DataSetName = "EtütOtomasyonuDataSet";
            this.etütOtomasyonuDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tBLETUTBindingSource
            // 
            this.tBLETUTBindingSource.DataMember = "TBL_ETUT";
            this.tBLETUTBindingSource.DataSource = this.etütOtomasyonuDataSet;
            // 
            // reportViewer2
            // 
            this.reportViewer2.Location = new System.Drawing.Point(829, 0);
            this.reportViewer2.Name = "reportViewer2";
            this.reportViewer2.ServerReport.BearerToken = null;
            this.reportViewer2.Size = new System.Drawing.Size(8, 24);
            this.reportViewer2.TabIndex = 1;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.tBLOGRENCIBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "EtutOtomasyonu.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1131, 444);
            this.reportViewer1.TabIndex = 2;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // tBL_ETUTTableAdapter
            // 
            this.tBL_ETUTTableAdapter.ClearBeforeFill = true;
            // 
            // tBLDERSLERBindingSource
            // 
            this.tBLDERSLERBindingSource.DataMember = "TBL_DERSLER";
            this.tBLDERSLERBindingSource.DataSource = this.etütOtomasyonuDataSet;
            // 
            // tBL_DERSLERTableAdapter
            // 
            this.tBL_DERSLERTableAdapter.ClearBeforeFill = true;
            // 
            // tBLSILINENETUTKAYITLARIBindingSource
            // 
            this.tBLSILINENETUTKAYITLARIBindingSource.DataMember = "TBL_SILINENETUTKAYITLARI";
            this.tBLSILINENETUTKAYITLARIBindingSource.DataSource = this.etütOtomasyonuDataSet;
            // 
            // tBL_SILINENETUTKAYITLARITableAdapter
            // 
            this.tBL_SILINENETUTKAYITLARITableAdapter.ClearBeforeFill = true;
            // 
            // tBLSINIFLARBindingSource
            // 
            this.tBLSINIFLARBindingSource.DataMember = "TBL_SINIFLAR";
            this.tBLSINIFLARBindingSource.DataSource = this.etütOtomasyonuDataSet;
            // 
            // tBL_SINIFLARTableAdapter
            // 
            this.tBL_SINIFLARTableAdapter.ClearBeforeFill = true;
            // 
            // adminKAdıBindingSource
            // 
            this.adminKAdıBindingSource.DataMember = "AdminK_Adı";
            this.adminKAdıBindingSource.DataSource = this.etütOtomasyonuDataSet;
            // 
            // adminK_AdıTableAdapter
            // 
            this.adminK_AdıTableAdapter.ClearBeforeFill = true;
            // 
            // dersBulmaBindingSource
            // 
            this.dersBulmaBindingSource.DataMember = "DersBulma";
            this.dersBulmaBindingSource.DataSource = this.etütOtomasyonuDataSet;
            // 
            // dersBulmaTableAdapter
            // 
            this.dersBulmaTableAdapter.ClearBeforeFill = true;
            // 
            // etutDurumGosterBindingSource
            // 
            this.etutDurumGosterBindingSource.DataMember = "EtutDurumGoster";
            this.etutDurumGosterBindingSource.DataSource = this.etütOtomasyonuDataSet;
            // 
            // etutDurumGosterTableAdapter
            // 
            this.etutDurumGosterTableAdapter.ClearBeforeFill = true;
            // 
            // ogrenciBulmaBindingSource
            // 
            this.ogrenciBulmaBindingSource.DataMember = "OgrenciBulma";
            this.ogrenciBulmaBindingSource.DataSource = this.etütOtomasyonuDataSet;
            // 
            // ogrenciBulmaTableAdapter
            // 
            this.ogrenciBulmaTableAdapter.ClearBeforeFill = true;
            // 
            // sınıflarBindingSource
            // 
            this.sınıflarBindingSource.DataMember = "Sınıflar";
            this.sınıflarBindingSource.DataSource = this.etütOtomasyonuDataSet;
            // 
            // sınıflarTableAdapter
            // 
            this.sınıflarTableAdapter.ClearBeforeFill = true;
            // 
            // tBL_OGRENCITableAdapter
            // 
            this.tBL_OGRENCITableAdapter.ClearBeforeFill = true;
            // 
            // ÇıktıEkranı
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1131, 444);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.reportViewer2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ÇıktıEkranı";
            this.Text = "Çıktı Ekranı";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tBLOGRENCIBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.etütOtomasyonuDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLETUTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLDERSLERBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLSILINENETUTKAYITLARIBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLSINIFLARBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminKAdıBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dersBulmaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.etutDurumGosterBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrenciBulmaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sınıflarBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer2;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private EtütOtomasyonuDataSet etütOtomasyonuDataSet;
        private System.Windows.Forms.BindingSource tBLETUTBindingSource;
        private EtütOtomasyonuDataSetTableAdapters.TBL_ETUTTableAdapter tBL_ETUTTableAdapter;
        private System.Windows.Forms.BindingSource tBLDERSLERBindingSource;
        private EtütOtomasyonuDataSetTableAdapters.TBL_DERSLERTableAdapter tBL_DERSLERTableAdapter;
        private System.Windows.Forms.BindingSource tBLSILINENETUTKAYITLARIBindingSource;
        private EtütOtomasyonuDataSetTableAdapters.TBL_SILINENETUTKAYITLARITableAdapter tBL_SILINENETUTKAYITLARITableAdapter;
        private System.Windows.Forms.BindingSource tBLSINIFLARBindingSource;
        private EtütOtomasyonuDataSetTableAdapters.TBL_SINIFLARTableAdapter tBL_SINIFLARTableAdapter;
        private System.Windows.Forms.BindingSource adminKAdıBindingSource;
        private EtütOtomasyonuDataSetTableAdapters.AdminK_AdıTableAdapter adminK_AdıTableAdapter;
        private System.Windows.Forms.BindingSource dersBulmaBindingSource;
        private EtütOtomasyonuDataSetTableAdapters.DersBulmaTableAdapter dersBulmaTableAdapter;
        private System.Windows.Forms.BindingSource etutDurumGosterBindingSource;
        private EtütOtomasyonuDataSetTableAdapters.EtutDurumGosterTableAdapter etutDurumGosterTableAdapter;
        private System.Windows.Forms.BindingSource ogrenciBulmaBindingSource;
        private EtütOtomasyonuDataSetTableAdapters.OgrenciBulmaTableAdapter ogrenciBulmaTableAdapter;
        private System.Windows.Forms.BindingSource sınıflarBindingSource;
        private EtütOtomasyonuDataSetTableAdapters.SınıflarTableAdapter sınıflarTableAdapter;
        private System.Windows.Forms.BindingSource tBLOGRENCIBindingSource;
        private EtütOtomasyonuDataSetTableAdapters.TBL_OGRENCITableAdapter tBL_OGRENCITableAdapter;
    }
}