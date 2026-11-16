using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient; //myaql bag

namespace performans_odevi
{
    public partial class depoyaekle : Form
    {
       
        string baglantiKumesi = "Server=localhost;Database=hastane;Uid=root;Pwd=;";

        public depoyaekle()
        {
            InitializeComponent();
        }

        private void depoyaekle_Load(object sender, EventArgs e)
        {

        }

        
        private void btnekle_Click(object sender, EventArgs e)
        {
            // Boş alan kontrolü
            if (string.IsNullOrEmpty(txtadi.Text) || string.IsNullOrEmpty(txtadedi.Text) || string.IsNullOrEmpty(txtrecetesi.Text))//kutular bosmu
            {
                MessageBox.Show("Lütfen tüm alanları doldurun!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (MySqlConnection baglanti = new MySqlConnection(baglantiKumesi))
                {
                    baglanti.Open();
                   
                    string sorgu = "INSERT INTO depo (ilac_adi, adedi, recetesi) VALUES (@adi, @adedi, @recetesi)";

                    using (MySqlCommand komut = new MySqlCommand(sorgu, baglanti))
                    {
                        komut.Parameters.AddWithValue("@adi", txtadi.Text.Trim()); // eslesstırme
                        komut.Parameters.AddWithValue("@adedi", txtadedi.Text.Trim());
                        komut.Parameters.AddWithValue("@recetesi", txtrecetesi.Text.Trim());

                        komut.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Malzeme depoya başarıyla eklendi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                
                this.Close(); 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kayıt eklenirken hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}