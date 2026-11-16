namespace performans_odevi
{
    partial class AdminPaneli
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
            this.tabloSec = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idsilme = new System.Windows.Forms.TextBox();
            this.btnsil = new System.Windows.Forms.Button();
            this.btnekle = new System.Windows.Forms.Button();
            this.depoekle = new System.Windows.Forms.Button();
            this.btnyeniisci = new System.Windows.Forms.Button();
            this.btnoda = new System.Windows.Forms.Button();
            this.labelBaslik = new System.Windows.Forms.Label();
            this.labelSecim = new System.Windows.Forms.Label();
            this.labelSil = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabloSec
            // 
            this.tabloSec.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tabloSec.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tabloSec.FormattingEnabled = true;
            this.tabloSec.Location = new System.Drawing.Point(827, 37);
            this.tabloSec.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabloSec.Name = "tabloSec";
            this.tabloSec.Size = new System.Drawing.Size(345, 33);
            this.tabloSec.TabIndex = 0;
            this.tabloSec.SelectedIndexChanged += new System.EventHandler(this.tabloSec_SelectedIndexChanged_1);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(373, 105);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(920, 591);
            this.dataGridView1.TabIndex = 1;
            // 
            // idsilme
            // 
            this.idsilme.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.idsilme.Location = new System.Drawing.Point(40, 542);
            this.idsilme.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.idsilme.Name = "idsilme";
            this.idsilme.Size = new System.Drawing.Size(292, 30);
            this.idsilme.TabIndex = 2;
            // 
            // btnsil
            // 
            this.btnsil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.btnsil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsil.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.btnsil.ForeColor = System.Drawing.Color.White;
            this.btnsil.Location = new System.Drawing.Point(40, 591);
            this.btnsil.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(293, 52);
            this.btnsil.TabIndex = 3;
            this.btnsil.Text = "Seçilen Kaydı Sil (ID)";
            this.btnsil.UseVisualStyleBackColor = false;
            this.btnsil.Click += new System.EventHandler(this.btnsil_Click_1);
            // 
            // btnekle
            // 
            this.btnekle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnekle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnekle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.btnekle.ForeColor = System.Drawing.Color.White;
            this.btnekle.Location = new System.Drawing.Point(40, 123);
            this.btnekle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnekle.Name = "btnekle";
            this.btnekle.Size = new System.Drawing.Size(293, 55);
            this.btnekle.TabIndex = 4;
            this.btnekle.Text = "Hasta / Randevu Ekle";
            this.btnekle.UseVisualStyleBackColor = false;
            this.btnekle.Click += new System.EventHandler(this.btnekle_Click);
            // 
            // depoekle
            // 
            this.depoekle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.depoekle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.depoekle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.depoekle.ForeColor = System.Drawing.Color.White;
            this.depoekle.Location = new System.Drawing.Point(40, 203);
            this.depoekle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.depoekle.Name = "depoekle";
            this.depoekle.Size = new System.Drawing.Size(293, 55);
            this.depoekle.TabIndex = 5;
            this.depoekle.Text = "Depoya Mal Ekle";
            this.depoekle.UseVisualStyleBackColor = false;
            this.depoekle.Click += new System.EventHandler(this.depoekle_Click);
            // 
            // btnyeniisci
            // 
            this.btnyeniisci.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnyeniisci.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnyeniisci.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.btnyeniisci.ForeColor = System.Drawing.Color.White;
            this.btnyeniisci.Location = new System.Drawing.Point(40, 283);
            this.btnyeniisci.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnyeniisci.Name = "btnyeniisci";
            this.btnyeniisci.Size = new System.Drawing.Size(293, 55);
            this.btnyeniisci.TabIndex = 6;
            this.btnyeniisci.Text = "Yeni İşçi Ekle";
            this.btnyeniisci.UseVisualStyleBackColor = false;
            this.btnyeniisci.Click += new System.EventHandler(this.btnyeniisci_Click);
            // 
            // btnoda
            // 
            this.btnoda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnoda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnoda.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.btnoda.ForeColor = System.Drawing.Color.White;
            this.btnoda.Location = new System.Drawing.Point(40, 363);
            this.btnoda.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnoda.Name = "btnoda";
            this.btnoda.Size = new System.Drawing.Size(293, 55);
            this.btnoda.TabIndex = 7;
            this.btnoda.Text = "Yeni Oda Ekle";
            this.btnoda.UseVisualStyleBackColor = false;
            this.btnoda.Click += new System.EventHandler(this.btnoda_Click);
            // 
            // labelBaslik
            // 
            this.labelBaslik.AutoSize = true;
            this.labelBaslik.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(100)))));
            this.labelBaslik.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.labelBaslik.ForeColor = System.Drawing.Color.White;
            this.labelBaslik.Location = new System.Drawing.Point(40, 31);
            this.labelBaslik.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelBaslik.Name = "labelBaslik";
            this.labelBaslik.Padding = new System.Windows.Forms.Padding(13, 6, 13, 6);
            this.labelBaslik.Size = new System.Drawing.Size(344, 51);
            this.labelBaslik.TabIndex = 8;
            this.labelBaslik.Text = "YÖNETİM PANELİ";
            // 
            // labelSecim
            // 
            this.labelSecim.AutoSize = true;
            this.labelSecim.BackColor = System.Drawing.Color.Transparent;
            this.labelSecim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.labelSecim.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(100)))));
            this.labelSecim.Location = new System.Drawing.Point(633, 41);
            this.labelSecim.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSecim.Name = "labelSecim";
            this.labelSecim.Size = new System.Drawing.Size(151, 25);
            this.labelSecim.TabIndex = 9;
            this.labelSecim.Text = "Tablo Seçiniz:";
            // 
            // labelSil
            // 
            this.labelSil.AutoSize = true;
            this.labelSil.BackColor = System.Drawing.Color.Transparent;
            this.labelSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.labelSil.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.labelSil.Location = new System.Drawing.Point(40, 511);
            this.labelSil.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSil.Name = "labelSil";
            this.labelSil.Size = new System.Drawing.Size(164, 20);
            this.labelSil.TabIndex = 10;
            this.labelSil.Text = "Silinecek Kayıt ID:";
            // 
            // AdminPaneli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(244)))), ((int)(((byte)(248)))));
            this.BackgroundImage = global::performans_odevi.Properties.Resources.Gemini_Generated_Image_93nnpg93nnpg93nn;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1333, 738);
            this.Controls.Add(this.labelSil);
            this.Controls.Add(this.labelSecim);
            this.Controls.Add(this.labelBaslik);
            this.Controls.Add(this.btnoda);
            this.Controls.Add(this.btnyeniisci);
            this.Controls.Add(this.depoekle);
            this.Controls.Add(this.btnekle);
            this.Controls.Add(this.btnsil);
            this.Controls.Add(this.idsilme);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tabloSec);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AdminPaneli";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Samet Sağlık Merkezi - Yönetim Paneli";
            this.Load += new System.EventHandler(this.AdminPaneli_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox tabloSec;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox idsilme;
        private System.Windows.Forms.Button btnsil;
        private System.Windows.Forms.Button btnekle;
        private System.Windows.Forms.Button depoekle;
        private System.Windows.Forms.Button btnyeniisci;
        private System.Windows.Forms.Button btnoda;
        private System.Windows.Forms.Label labelBaslik;
        private System.Windows.Forms.Label labelSecim;
        private System.Windows.Forms.Label labelSil;
    }
}