using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace performans_odevi
{
    public partial class GuncelleFormu : Form
    {
        string gelenID, gelenTablo;
        string baglantiKumesi = "Server=localhost;Database=hastane;Uid=root;Pwd=;";

        public GuncelleFormu(string id, string adi, string soyadi, string telefonu, string tcsi, string sorunu, string tabloAdi)
        {
            InitializeComponent();

            gelenID = id;
            gelenTablo = tabloAdi;

            // Verileri kutulara yazdırıyoruz
            txtAdi.Text = adi;
            txtSoyadi.Text = soyadi;
            txtTelefon.Text = telefonu;
            txtTc.Text = tcsi;
            txtSorun.Text = sorunu;
        }

        private void GuncelleFormu_Load(object sender, EventArgs e)
        {
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            using (MySqlConnection baglanti = new MySqlConnection(baglantiKumesi))
            {
                try
                {
                    baglanti.Open();

                    string sorgu = "";

                    // Tabloların sütun farkına göre doğru güncelleme cümlesini kuruyoruz
                    if (gelenTablo == "hastalar")
                    {
                        // Hastalar tablosunda T.C. sütununun adı 'tcsi'
                        sorgu = "UPDATE hastalar SET ad = @ad, soyad = @soyad, telefon = @telefon, tcsi = @tc, sorun = @sorun WHERE id = @id";
                    }
                    else if (gelenTablo == "randevular")
                    {
                        // Randevular tablosunda T.C. sütununun adı 'tcsi'
                        sorgu = "UPDATE randevular SET ad = @ad, soyad = @soyad, telefon = @telefon, tcsi = @tc, sorun = @sorun WHERE id = @id";
                    }
                    else
                    {
                        // Depo, odalar, personeller, sikayetler tablosunda TC sütunu yok, ID'ye göre güncellenir
                        sorgu = "UPDATE " + gelenTablo + " SET ad = @ad, soyad = @soyad, telefon = @telefon, sorun = @sorun WHERE id = @id";
                    }

                    MySqlCommand komut = new MySqlCommand(sorgu, baglanti);
                    komut.Parameters.AddWithValue("@ad", txtAdi.Text);
                    komut.Parameters.AddWithValue("@soyad", txtSoyadi.Text);
                    komut.Parameters.AddWithValue("@telefon", txtTelefon.Text);
                    komut.Parameters.AddWithValue("@tc", txtTc.Text);
                    komut.Parameters.AddWithValue("@sorun", txtSorun.Text);
                    komut.Parameters.AddWithValue("@id", gelenID);

                    komut.ExecuteNonQuery();

                    MessageBox.Show("Kayıt başarıyla güncellendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Güncelleme sırasında hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnguncelle_Click_1(object sender, EventArgs e)
        {
            btnguncelle_Click(sender, e);
        }
    }
}