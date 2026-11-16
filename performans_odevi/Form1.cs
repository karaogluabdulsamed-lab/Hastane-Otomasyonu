using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient; // MySQL baglantisi için

namespace performans_odevi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Boş kutu kontrolü (Randevu / Kayıt alanları)
            if (string.IsNullOrWhiteSpace(adi.Text) ||
                string.IsNullOrWhiteSpace(soyadi.Text) ||
                string.IsNullOrWhiteSpace(tcsi.Text) ||
                string.IsNullOrWhiteSpace(telefonu.Text) ||
                string.IsNullOrWhiteSpace(sorunu.Text))
            {
                MessageBox.Show("Lütfen tüm kutuları doldurun", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Eksik varsa işlemi durdur
            }

            try  // guvenlik duvarı / veritabani islemi
            {
                string baglantiKumesi = "Server=localhost;Database=hastane;Uid=root;Pwd=;";
                using (MySqlConnection baglanti = new MySqlConnection(baglantiKumesi))
                {
                    baglanti.Open(); // baglantiyi ac

                    // 1. Tablo: hastalar
                    string sorguHastalar = "INSERT INTO hastalar (adi, soyadi, tcsi, telefonu, sorunu) VALUES (@adi, @soyadi, @tcsi, @telefonu, @sorunu)";
                    using (MySqlCommand komut1 = new MySqlCommand(sorguHastalar, baglanti))  // calistirmak icin
                    {
                        komut1.Parameters.AddWithValue("@adi", adi.Text);  // verileri eslestirme
                        komut1.Parameters.AddWithValue("@soyadi", soyadi.Text);
                        komut1.Parameters.AddWithValue("@tcsi", tcsi.Text);
                        komut1.Parameters.AddWithValue("@telefonu", telefonu.Text);
                        komut1.Parameters.AddWithValue("@sorunu", sorunu.Text);

                        komut1.ExecuteNonQuery();  // calistirma
                    }

                    // 2. Tablo: randevular
                    string sorguRandevular = "INSERT INTO randevular (adi, soyadi, tcsi, telefonu, sorunu) VALUES (@adi, @soyadi, @tcsi, @telefonu, @sorunu)";
                    using (MySqlCommand komut2 = new MySqlCommand(sorguRandevular, baglanti))
                    {
                        komut2.Parameters.AddWithValue("@adi", adi.Text);  // verileri eslestirme
                        komut2.Parameters.AddWithValue("@soyadi", soyadi.Text);
                        komut2.Parameters.AddWithValue("@tcsi", tcsi.Text);
                        komut2.Parameters.AddWithValue("@telefonu", telefonu.Text);
                        komut2.Parameters.AddWithValue("@sorunu", sorunu.Text);

                        komut2.ExecuteNonQuery();  // calistirma
                    }
                }

                MessageBox.Show("Randevunuz başarıyla oluşturuldu ve ilgili tablolara kaydedildi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Kutuları temizle
                adi.Clear();
                soyadi.Clear();
                tcsi.Clear();
                telefonu.Clear();
                sorunu.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gonder_Click(object sender, EventArgs e)
        {
            // Şikayet kutusu boşluk kontrolü
            if (string.IsNullOrWhiteSpace(sikayet.Text))
            {
                MessageBox.Show("Lütfen tüm kutuları doldurun", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Eksik varsa işlemi durdur
            }

            try
            {
                string baglantiKumesi = "Server=localhost;Database=hastane;Uid=root;Pwd=;";
                using (MySqlConnection baglanti = new MySqlConnection(baglantiKumesi))
                {
                    baglanti.Open();

                    string sorgu = "INSERT INTO sikayetler (sorun, son_durum) VALUES (@sorunDegeri, 'İnceleniyor')";
                    using (MySqlCommand komut = new MySqlCommand(sorgu, baglanti))
                    {
                        komut.Parameters.AddWithValue("@sorunDegeri", sikayet.Text);  // eslestirme
                        komut.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Şikayet / öneriniz başarıyla gönderildi. Teşekkür ederiz!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Şikayet kutusunu temizle
                sikayet.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void yonetici_girisi_Click_1(object sender, EventArgs e)
        {
            GirisFormu frm = new GirisFormu();
            frm.Show(); // Giriş formunu aç
            this.Hide(); // Form1'i gizle
        }
    }
}