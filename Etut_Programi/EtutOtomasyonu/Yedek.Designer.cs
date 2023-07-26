namespace EtutOtomasyonu
{
    partial class Yedek
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Yedek));
            this.BtnDosyaKonum = new System.Windows.Forms.Button();
            this.BtnYedekle = new System.Windows.Forms.Button();
            this.BtnGeriDön = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TxtDosya = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnDosyaKonum
            // 
            this.BtnDosyaKonum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BtnDosyaKonum.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnDosyaKonum.Location = new System.Drawing.Point(83, 277);
            this.BtnDosyaKonum.Name = "BtnDosyaKonum";
            this.BtnDosyaKonum.Size = new System.Drawing.Size(254, 58);
            this.BtnDosyaKonum.TabIndex = 0;
            this.BtnDosyaKonum.Text = "Dosya Konumunu Seç";
            this.BtnDosyaKonum.UseVisualStyleBackColor = false;
            this.BtnDosyaKonum.Click += new System.EventHandler(this.BtnDosyaKonum_Click_1);
            // 
            // BtnYedekle
            // 
            this.BtnYedekle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BtnYedekle.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnYedekle.Location = new System.Drawing.Point(83, 357);
            this.BtnYedekle.Name = "BtnYedekle";
            this.BtnYedekle.Size = new System.Drawing.Size(254, 53);
            this.BtnYedekle.TabIndex = 1;
            this.BtnYedekle.Text = "YEDEKLE";
            this.BtnYedekle.UseVisualStyleBackColor = false;
            this.BtnYedekle.Click += new System.EventHandler(this.BtnYedekle_Click_1);
            // 
            // BtnGeriDön
            // 
            this.BtnGeriDön.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BtnGeriDön.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnGeriDön.Location = new System.Drawing.Point(459, 357);
            this.BtnGeriDön.Name = "BtnGeriDön";
            this.BtnGeriDön.Size = new System.Drawing.Size(254, 53);
            this.BtnGeriDön.TabIndex = 3;
            this.BtnGeriDön.Text = "YEDEKTEN DÖN";
            this.BtnGeriDön.UseVisualStyleBackColor = false;
            this.BtnGeriDön.Click += new System.EventHandler(this.BtnGeriDön_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(282, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(254, 248);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // TxtDosya
            // 
            this.TxtDosya.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.TxtDosya.Location = new System.Drawing.Point(413, 281);
            this.TxtDosya.Multiline = true;
            this.TxtDosya.Name = "TxtDosya";
            this.TxtDosya.Size = new System.Drawing.Size(345, 54);
            this.TxtDosya.TabIndex = 5;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Azure;
            this.textBox1.Location = new System.Drawing.Point(553, 229);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(180, 31);
            this.textBox1.TabIndex = 6;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Yedek
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.TxtDosya);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BtnGeriDön);
            this.Controls.Add(this.BtnYedekle);
            this.Controls.Add(this.BtnDosyaKonum);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Yedek";
            this.Text = "Yedek";
            this.Load += new System.EventHandler(this.Yedek_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnDosyaKonum;
        private System.Windows.Forms.Button BtnYedekle;
        private System.Windows.Forms.Button BtnGeriDön;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox TxtDosya;
        private System.Windows.Forms.TextBox textBox1;
    }
}