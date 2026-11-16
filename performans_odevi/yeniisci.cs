using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;  

namespace performans_odevi
{
    public partial class yeniisci : Form
    {
       
        string baglantiKumesi = "Server=localhost;Database=hastane;Uid=root;Pwd=;";

        public yeniisci()
        {
            InitializeComponent();
        }

        private void yeniisci_Load(object sender, EventArgs e)
        {

        }

        
        private void btnkaydet_Click(object sender, EventArgs e)
        {
            // Boş alan kontrolü
            if (string.IsNullOrEmpty(txtadi.Text) || string.IsNullOrEmpty(txtsoyadi.Text) || string.IsNullOrEmpty(txttelefonu.Text) || string.IsNullOrEmpty(txtrutbesi.Text))  //kutu bos mu
            {
                MessageBox.Show("Lütfen tüm alanları doldurun!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (MySqlConnection baglanti = new MySqlConnection(baglantiKumesi))
                {
                    baglanti.Open();
                   
                    string sorgu = "INSERT INTO personeller (adi, soyadi, telefonu, rutbesi) VALUES (@adi, @soyadi, @telefonu, @rutbesi)";

                    using (MySqlCommand komut = new MySqlCommand(sorgu, baglanti))
                    {
                        komut.Parameters.AddWithValue("@adi", txtadi.Text.Trim());
                        komut.Parameters.AddWithValue("@soyadi", txtsoyadi.Text.Trim());
                        komut.Parameters.AddWithValue("@telefonu", txttelefonu.Text.Trim());
                        komut.Parameters.AddWithValue("@rutbesi", txtrutbesi.Text.Trim());

                        komut.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Personel başarıyla kaydedildi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

               
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kayıt eklenirken hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}