namespace performans_odevi
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.adi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.soyadi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tcsi = new System.Windows.Forms.TextBox();
            this.telefonu = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.sorunu = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.sikayet = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.gonder = new System.Windows.Forms.Button();
            this.yonetici_girisi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(140)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(574, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(486, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "SAMET SAĞLIK MERKEZİ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(100)))));
            this.label2.Location = new System.Drawing.Point(21, 100);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(241, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Randevu Oluşturma";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.label3.Location = new System.Drawing.Point(21, 162);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Adınız:";
            // 
            // adi
            // 
            this.adi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.adi.Location = new System.Drawing.Point(161, 158);
            this.adi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.adi.Name = "adi";
            this.adi.Size = new System.Drawing.Size(259, 28);
            this.adi.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.label4.Location = new System.Drawing.Point(21, 211);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 24);
            this.label4.TabIndex = 4;
            this.label4.Text = "Soyadınız:";
            // 
            // soyadi
            // 
            this.soyadi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.soyadi.Location = new System.Drawing.Point(161, 207);
            this.soyadi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.soyadi.Name = "soyadi";
            this.soyadi.Size = new System.Drawing.Size(259, 28);
            this.soyadi.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.label5.Location = new System.Drawing.Point(21, 260);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 24);
            this.label5.TabIndex = 6;
            this.label5.Text = "TC niz:";
            // 
            // tcsi
            // 
            this.tcsi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.tcsi.Location = new System.Drawing.Point(161, 257);
            this.tcsi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tcsi.Name = "tcsi";
            this.tcsi.Size = new System.Drawing.Size(259, 28);
            this.tcsi.TabIndex = 7;
            // 
            // telefonu
            // 
            this.telefonu.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.telefonu.Location = new System.Drawing.Point(161, 306);
            this.telefonu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.telefonu.Name = "telefonu";
            this.telefonu.Size = new System.Drawing.Size(259, 28);
            this.telefonu.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.label6.Location = new System.Drawing.Point(21, 309);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 24);
            this.label6.TabIndex = 9;
            this.label6.Text = "Tel nonuz:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.label7.Location = new System.Drawing.Point(21, 359);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 24);
            this.label7.TabIndex = 10;
            this.label7.Text = "Şikayetiniz:";
            // 
            // sorunu
            // 
            this.sorunu.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.sorunu.Location = new System.Drawing.Point(161, 355);
            this.sorunu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.sorunu.Multiline = true;
            this.sorunu.Name = "sorunu";
            this.sorunu.Size = new System.Drawing.Size(259, 79);
            this.sorunu.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(21, 457);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(400, 59);
            this.button1.TabIndex = 12;
            this.button1.Text = "Randevu Oluştur";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // sikayet
            // 
            this.sikayet.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.sikayet.Location = new System.Drawing.Point(1438, 54);
            this.sikayet.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.sikayet.Multiline = true;
            this.sikayet.Name = "sikayet";
            this.sikayet.Size = new System.Drawing.Size(399, 215);
            this.sikayet.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(100)))));
            this.label8.Location = new System.Drawing.Point(1549, 21);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(184, 29);
            this.label8.TabIndex = 14;
            this.label8.Text = "Şikayet Kutusu";
            // 
            // gonder
            // 
            this.gonder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.gonder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gonder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.gonder.ForeColor = System.Drawing.Color.White;
            this.gonder.Location = new System.Drawing.Point(1437, 290);
            this.gonder.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gonder.Name = "gonder";
            this.gonder.Size = new System.Drawing.Size(400, 59);
            this.gonder.TabIndex = 15;
            this.gonder.Text = "Gönder";
            this.gonder.UseVisualStyleBackColor = false;
            this.gonder.Click += new System.EventHandler(this.gonder_Click);
            // 
            // yonetici_girisi
            // 
            this.yonetici_girisi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.yonetici_girisi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.yonetici_girisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.yonetici_girisi.ForeColor = System.Drawing.Color.White;
            this.yonetici_girisi.Location = new System.Drawing.Point(21, 21);
            this.yonetici_girisi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.yonetici_girisi.Name = "yonetici_girisi";
            this.yonetici_girisi.Size = new System.Drawing.Size(167, 47);
            this.yonetici_girisi.TabIndex = 16;
            this.yonetici_girisi.Text = "Yönetici Girişi";
            this.yonetici_girisi.UseVisualStyleBackColor = false;
            this.yonetici_girisi.Click += new System.EventHandler(this.yonetici_girisi_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(244)))), ((int)(((byte)(248)))));
            this.BackgroundImage = global::performans_odevi.Properties.Resources.Gemini_Generated_Image_spknurspknurspkn;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1829, 672);
            this.Controls.Add(this.yonetici_girisi);
            this.Controls.Add(this.gonder);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.sikayet);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.sorunu);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.telefonu);
            this.Controls.Add(this.tcsi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.soyadi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.adi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Samet Sağlık Merkezi - Otomasyon";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox adi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox soyadi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tcsi;
        private System.Windows.Forms.TextBox telefonu;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox sorunu;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox sikayet;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button gonder;
        private System.Windows.Forms.Button yonetici_girisi;
    }
}