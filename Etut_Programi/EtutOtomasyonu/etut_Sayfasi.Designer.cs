namespace EtutOtomasyonu
{
    partial class etut_Sayfasi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(etut_Sayfasi));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtSaat = new System.Windows.Forms.MaskedTextBox();
            this.TxtOgrenci = new System.Windows.Forms.ComboBox();
            this.TxtOgretmen = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.TxtSilinecek = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.TxtDers = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtTarih = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.TxtSaat);
            this.groupBox1.Controls.Add(this.TxtOgrenci);
            this.groupBox1.Controls.Add(this.TxtOgretmen);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.TxtSilinecek);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.TxtDers);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.TxtTarih);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.TxtId);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.groupBox1.Location = new System.Drawing.Point(22, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(405, 585);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Etüt İşlemleri";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(207, 385);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 34);
            this.label6.TabIndex = 23;
            this.label6.Text = "Saat :";
            // 
            // TxtSaat
            // 
            this.TxtSaat.Font = new System.Drawing.Font("Tahoma", 16.2F);
            this.TxtSaat.Location = new System.Drawing.Point(282, 382);
            this.TxtSaat.Mask = "00:00";
            this.TxtSaat.Name = "TxtSaat";
            this.TxtSaat.Size = new System.Drawing.Size(62, 40);
            this.TxtSaat.TabIndex = 22;
            this.TxtSaat.ValidatingType = typeof(System.DateTime);
            // 
            // TxtOgrenci
            // 
            this.TxtOgrenci.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TxtOgrenci.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtOgrenci.FormattingEnabled = true;
            this.TxtOgrenci.Location = new System.Drawing.Point(55, 309);
            this.TxtOgrenci.Margin = new System.Windows.Forms.Padding(2);
            this.TxtOgrenci.Name = "TxtOgrenci";
            this.TxtOgrenci.Size = new System.Drawing.Size(289, 41);
            this.TxtOgrenci.TabIndex = 21;
            // 
            // TxtOgretmen
            // 
            this.TxtOgretmen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TxtOgretmen.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtOgretmen.FormattingEnabled = true;
            this.TxtOgretmen.Location = new System.Drawing.Point(55, 226);
            this.TxtOgretmen.Margin = new System.Windows.Forms.Padding(2);
            this.TxtOgretmen.Name = "TxtOgretmen";
            this.TxtOgretmen.Size = new System.Drawing.Size(289, 41);
            this.TxtOgretmen.TabIndex = 20;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(104)))), ((int)(((byte)(191)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Verdana", 11.25F);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Image = global::EtutOtomasyonu.Properties.Resources.reload_icon;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.button2.Location = new System.Drawing.Point(6, 506);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(200, 58);
            this.button2.TabIndex = 19;
            this.button2.Text = "Düzenleme İşlemi";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // TxtSilinecek
            // 
            this.TxtSilinecek.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(54)))), ((int)(((byte)(12)))));
            this.TxtSilinecek.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TxtSilinecek.Font = new System.Drawing.Font("Verdana", 11.25F);
            this.TxtSilinecek.ForeColor = System.Drawing.Color.White;
            this.TxtSilinecek.Image = global::EtutOtomasyonu.Properties.Resources.Button_Close_icon;
            this.TxtSilinecek.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.TxtSilinecek.Location = new System.Drawing.Point(212, 506);
            this.TxtSilinecek.Name = "TxtSilinecek";
            this.TxtSilinecek.Size = new System.Drawing.Size(187, 58);
            this.TxtSilinecek.TabIndex = 18;
            this.TxtSilinecek.Text = "Etüt Sil";
            this.TxtSilinecek.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.TxtSilinecek.UseVisualStyleBackColor = false;
            this.TxtSilinecek.Click += new System.EventHandler(this.TxtSilinecek_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(96)))), ((int)(((byte)(15)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Verdana", 11.25F);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = global::EtutOtomasyonu.Properties.Resources.Button_Add_icon;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.button1.Location = new System.Drawing.Point(93, 442);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(215, 58);
            this.button1.TabIndex = 17;
            this.button1.Text = "Yeni Etüt Oluştur";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TxtDers
            // 
            this.TxtDers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TxtDers.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtDers.FormattingEnabled = true;
            this.TxtDers.Location = new System.Drawing.Point(55, 146);
            this.TxtDers.Margin = new System.Windows.Forms.Padding(2);
            this.TxtDers.Name = "TxtDers";
            this.TxtDers.Size = new System.Drawing.Size(289, 41);
            this.TxtDers.TabIndex = 6;
            this.TxtDers.SelectedIndexChanged += new System.EventHandler(this.TxtDers_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(5, 385);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 34);
            this.label5.TabIndex = 16;
            this.label5.Text = "Tarih :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(92, 280);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(169, 34);
            this.label4.TabIndex = 14;
            this.label4.Text = "Etüt Öğrenci";
            // 
            // TxtTarih
            // 
            this.TxtTarih.Font = new System.Drawing.Font("Tahoma", 16.2F);
            this.TxtTarih.Location = new System.Drawing.Point(85, 382);
            this.TxtTarih.Mask = "00/00/0000";
            this.TxtTarih.Name = "TxtTarih";
            this.TxtTarih.Size = new System.Drawing.Size(105, 40);
            this.TxtTarih.TabIndex = 13;
            this.TxtTarih.ValidatingType = typeof(System.DateTime);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(88, 197);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(198, 34);
            this.label3.TabIndex = 12;
            this.label3.Text = "Etüt Öğretmen";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(88, 117);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 34);
            this.label2.TabIndex = 10;
            this.label2.Text = "Etüt Ders";
            // 
            // TxtId
            // 
            this.TxtId.Enabled = false;
            this.TxtId.Font = new System.Drawing.Font("Tahoma", 16.2F);
            this.TxtId.Location = new System.Drawing.Point(55, 64);
            this.TxtId.Multiline = true;
            this.TxtId.Name = "TxtId";
            this.TxtId.Size = new System.Drawing.Size(289, 36);
            this.TxtId.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(88, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 34);
            this.label1.TabIndex = 2;
            this.label1.Text = "Etüt Numara";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.groupBox2.Location = new System.Drawing.Point(457, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(716, 574);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sistemde Kayıtlı Etütler";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 20);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(643, 551);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // etut_Sayfasi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1185, 609);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "etut_Sayfasi";
            this.Text = "Etüt İşlemleri";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.etut_Sayfasi_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button TxtSilinecek;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox TxtDers;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox TxtTarih;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox TxtOgretmen;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox TxtSaat;
        private System.Windows.Forms.ComboBox TxtOgrenci;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}