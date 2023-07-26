namespace EtutOtomasyonu
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.anasayfaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eTÜTOluşturmaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bugünkiEtütlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tümEtütlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.etütOluşturmaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.dersİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.öğretmenİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.öğrenciİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sınıfİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayarlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.excelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.anasayfaToolStripMenuItem,
            this.eTÜTOluşturmaToolStripMenuItem,
            this.dersİşlemleriToolStripMenuItem,
            this.öğretmenİşlemleriToolStripMenuItem,
            this.öğrenciİşlemleriToolStripMenuItem,
            this.sınıfİşlemleriToolStripMenuItem,
            this.ayarlarToolStripMenuItem,
            this.excelToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1350, 56);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // anasayfaToolStripMenuItem
            // 
            this.anasayfaToolStripMenuItem.Image = global::EtutOtomasyonu.Properties.Resources.home_icon;
            this.anasayfaToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.anasayfaToolStripMenuItem.Name = "anasayfaToolStripMenuItem";
            this.anasayfaToolStripMenuItem.Size = new System.Drawing.Size(131, 52);
            this.anasayfaToolStripMenuItem.Text = "Anasayfa";
            this.anasayfaToolStripMenuItem.Click += new System.EventHandler(this.anasayfaToolStripMenuItem_Click);
            // 
            // eTÜTOluşturmaToolStripMenuItem
            // 
            this.eTÜTOluşturmaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bugünkiEtütlerToolStripMenuItem,
            this.tümEtütlerToolStripMenuItem,
            this.etütOluşturmaToolStripMenuItem1});
            this.eTÜTOluşturmaToolStripMenuItem.Image = global::EtutOtomasyonu.Properties.Resources.etutpng;
            this.eTÜTOluşturmaToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.eTÜTOluşturmaToolStripMenuItem.Name = "eTÜTOluşturmaToolStripMenuItem";
            this.eTÜTOluşturmaToolStripMenuItem.Size = new System.Drawing.Size(165, 52);
            this.eTÜTOluşturmaToolStripMenuItem.Text = "ETÜT İşlemleri";
            // 
            // bugünkiEtütlerToolStripMenuItem
            // 
            this.bugünkiEtütlerToolStripMenuItem.Image = global::EtutOtomasyonu.Properties.Resources._1;
            this.bugünkiEtütlerToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.bugünkiEtütlerToolStripMenuItem.Name = "bugünkiEtütlerToolStripMenuItem";
            this.bugünkiEtütlerToolStripMenuItem.Size = new System.Drawing.Size(220, 54);
            this.bugünkiEtütlerToolStripMenuItem.Text = "Bugünki Etütler";
            this.bugünkiEtütlerToolStripMenuItem.Click += new System.EventHandler(this.bugünkiEtütlerToolStripMenuItem_Click);
            // 
            // tümEtütlerToolStripMenuItem
            // 
            this.tümEtütlerToolStripMenuItem.Image = global::EtutOtomasyonu.Properties.Resources._2;
            this.tümEtütlerToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tümEtütlerToolStripMenuItem.Name = "tümEtütlerToolStripMenuItem";
            this.tümEtütlerToolStripMenuItem.Size = new System.Drawing.Size(220, 54);
            this.tümEtütlerToolStripMenuItem.Text = "Tüm Etütler";
            this.tümEtütlerToolStripMenuItem.Click += new System.EventHandler(this.tümEtütlerToolStripMenuItem_Click);
            // 
            // etütOluşturmaToolStripMenuItem1
            // 
            this.etütOluşturmaToolStripMenuItem1.Image = global::EtutOtomasyonu.Properties.Resources.Places_user_home_icon;
            this.etütOluşturmaToolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.etütOluşturmaToolStripMenuItem1.Name = "etütOluşturmaToolStripMenuItem1";
            this.etütOluşturmaToolStripMenuItem1.Size = new System.Drawing.Size(220, 54);
            this.etütOluşturmaToolStripMenuItem1.Text = "Etüt Oluşturma";
            this.etütOluşturmaToolStripMenuItem1.Click += new System.EventHandler(this.etütOluşturmaToolStripMenuItem1_Click);
            // 
            // dersİşlemleriToolStripMenuItem
            // 
            this.dersİşlemleriToolStripMenuItem.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dersİşlemleriToolStripMenuItem.Image = global::EtutOtomasyonu.Properties.Resources.pencil;
            this.dersİşlemleriToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.dersİşlemleriToolStripMenuItem.Name = "dersİşlemleriToolStripMenuItem";
            this.dersİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(161, 52);
            this.dersİşlemleriToolStripMenuItem.Text = "Ders İşlemleri";
            this.dersİşlemleriToolStripMenuItem.Click += new System.EventHandler(this.dersİşlemleriToolStripMenuItem_Click);
            // 
            // öğretmenİşlemleriToolStripMenuItem
            // 
            this.öğretmenİşlemleriToolStripMenuItem.Image = global::EtutOtomasyonu.Properties.Resources.ogretmen;
            this.öğretmenİşlemleriToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.öğretmenİşlemleriToolStripMenuItem.Name = "öğretmenİşlemleriToolStripMenuItem";
            this.öğretmenİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(198, 52);
            this.öğretmenİşlemleriToolStripMenuItem.Text = "Öğretmen İşlemleri";
            this.öğretmenİşlemleriToolStripMenuItem.Click += new System.EventHandler(this.öğretmenİşlemleriToolStripMenuItem_Click);
            // 
            // öğrenciİşlemleriToolStripMenuItem
            // 
            this.öğrenciİşlemleriToolStripMenuItem.Image = global::EtutOtomasyonu.Properties.Resources.ogrenci;
            this.öğrenciİşlemleriToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.öğrenciİşlemleriToolStripMenuItem.Name = "öğrenciİşlemleriToolStripMenuItem";
            this.öğrenciİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(183, 52);
            this.öğrenciİşlemleriToolStripMenuItem.Text = "Öğrenci İşlemleri";
            this.öğrenciİşlemleriToolStripMenuItem.Click += new System.EventHandler(this.öğrenciİşlemleriToolStripMenuItem_Click);
            // 
            // sınıfİşlemleriToolStripMenuItem
            // 
            this.sınıfİşlemleriToolStripMenuItem.Image = global::EtutOtomasyonu.Properties.Resources.sinif;
            this.sınıfİşlemleriToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.sınıfİşlemleriToolStripMenuItem.Name = "sınıfİşlemleriToolStripMenuItem";
            this.sınıfİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(160, 52);
            this.sınıfİşlemleriToolStripMenuItem.Text = "Sınıf İşlemleri";
            this.sınıfİşlemleriToolStripMenuItem.Click += new System.EventHandler(this.sınıfİşlemleriToolStripMenuItem_Click);
            // 
            // ayarlarToolStripMenuItem
            // 
            this.ayarlarToolStripMenuItem.Image = global::EtutOtomasyonu.Properties.Resources.Settings_icon;
            this.ayarlarToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ayarlarToolStripMenuItem.Name = "ayarlarToolStripMenuItem";
            this.ayarlarToolStripMenuItem.Size = new System.Drawing.Size(118, 52);
            this.ayarlarToolStripMenuItem.Text = "Ayarlar";
            this.ayarlarToolStripMenuItem.Click += new System.EventHandler(this.ayarlarToolStripMenuItem_Click);
            // 
            // excelToolStripMenuItem
            // 
            this.excelToolStripMenuItem.Name = "excelToolStripMenuItem";
            this.excelToolStripMenuItem.Size = new System.Drawing.Size(117, 52);
            this.excelToolStripMenuItem.Text = "               Excel";
            this.excelToolStripMenuItem.Click += new System.EventHandler(this.excelToolStripMenuItem_Click_1);
            // 
            // menuStrip2
            // 
            this.menuStrip2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Location = new System.Drawing.Point(0, 582);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(1350, 24);
            this.menuStrip2.TabIndex = 9;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1278, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(56, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1350, 606);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menü Ekranı";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Menu_FormClosed);
            this.Load += new System.EventHandler(this.Menu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem anasayfaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eTÜTOluşturmaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bugünkiEtütlerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tümEtütlerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem etütOluşturmaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem dersİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem öğretmenİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem öğrenciİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sınıfİşlemleriToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem ayarlarToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem excelToolStripMenuItem;
    }
}