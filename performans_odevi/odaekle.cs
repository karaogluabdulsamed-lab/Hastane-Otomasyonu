using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient; 

namespace performans_odevi
{
    public partial class odaekle : Form
    {
       
        string baglantiKumesi = "Server=localhost;Database=hastane;Uid=root;Pwd=;";

        public odaekle()
        {
            InitializeComponent();
        }

        private void odaekle_Load(object sender, EventArgs e)
        {

        }

       
        private void btnkaydet_Click(object sender, EventArgs e)
        {
         
            if (string.IsNullOrEmpty(txtadi.Text) || string.IsNullOrEmpty(txtkati.Text))  //kutular bosmu
            {
                MessageBox.Show("Lütfen tüm alanları doldurun!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (MySqlConnection baglanti = new MySqlConnection(baglantiKumesi))
                {
                    baglanti.Open();
                
                    string sorgu = "INSERT INTO odalar (adi, kati) VALUES (@adi, @kati)";

                    using (MySqlCommand komut = new MySqlCommand(sorgu, baglanti))
                    {
                        komut.Parameters.AddWithValue("@adi", txtadi.Text.Trim());
                        komut.Parameters.AddWithValue("@kati", txtkati.Text.Trim());

                        komut.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Oda başarıyla eklendi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

               
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kayıt eklenirken hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}