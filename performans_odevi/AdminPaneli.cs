using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient; //mysql bag

namespace performans_odevi
{
    public partial class AdminPaneli : Form
    {
        string baglantiKumesi = "Server=localhost;Database=hastane;Uid=root;Pwd=;"; 
        MySqlDataAdapter da;  //tabldoa listeleem ıcın
        DataTable dt;  //tabloya gonderme ıcın

        public AdminPaneli()
        {
            InitializeComponent();
        }

        private void AdminPaneli_Load(object sender, EventArgs e)  //comboboxunkıler 
        {
            tabloSec.Items.Add("hastalar");
            tabloSec.Items.Add("randevular");
            tabloSec.Items.Add("sikayetler");
            tabloSec.Items.Add("personeller");
            tabloSec.Items.Add("odalar");
            tabloSec.Items.Add("depo");
        }

        private void tabloSec_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            VerileriGetir();  //secılen tabloyu getırmk ıcın 
        }

        private void VerileriGetir()
        {
            if (tabloSec.SelectedItem == null) return;  //tabloda secılme yapılmadıysa hata vermeın dıye bu 

            string secilenTablo = tabloSec.SelectedItem.ToString(); // comboboxdakını secılen tabloya atma 

            try  //güvenlık duvarı
            {
                using (MySqlConnection baglanti = new MySqlConnection(baglantiKumesi))  
                {
                    baglanti.Open();
                    string sorgu = $"SELECT * FROM {secilenTablo}";  
                    da = new MySqlDataAdapter(sorgu, baglanti);
                    dt = new DataTable();  //verileriş vermek ıcın bos tablo uretlır
                    da.Fill(dt);  //verileri doldurur
                    dataGridView1.DataSource = dt;  //yerlestırme
                    dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;  //düzenlı olması
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veriler yüklenirken hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
        private void btnsil_Click_1(object sender, EventArgs e)
        {
            if (tabloSec.SelectedItem == null)  //secılmedıyse
            {
                MessageBox.Show("Lütfen önce yukarıdan bir tablo seçin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string secilenTablo = tabloSec.SelectedItem.ToString();  //secılen ı alır
            string silinecekID = idsilme.Text.Trim();  //kutudakı yazıyı alır

            if (string.IsNullOrEmpty(silinecekID))  //seılmısmı secılmemısmı
            {
                MessageBox.Show("Lütfen silmek istediğiniz kaydın ID numarasını girin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (dt == null || dt.Columns.Count == 0)  //tablo bosmu kontrolu
            {
                MessageBox.Show("Önce tablodan verileri yükleyin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Tablonun ilk sütun adını (ID sütunu) otomatik yakalıyoruz
            string idSutunAdi = dt.Columns[0].ColumnName;  

            try
            {
                using (MySqlConnection baglanti = new MySqlConnection(baglantiKumesi))
                {
                    baglanti.Open();
                    string sorgu = $"DELETE FROM {secilenTablo} WHERE {idSutunAdi} = @id";
                    using (MySqlCommand komut = new MySqlCommand(sorgu, baglanti))
                    {
                        komut.Parameters.AddWithValue("@id", silinecekID);  //eslestır
                        int etkilenenSatir = komut.ExecuteNonQuery();  //calıstır

                        if (etkilenenSatir > 0)  //id 0 dan büyükse
                        {
                            MessageBox.Show("Kayıt başarıyla silindi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            idsilme.Clear();
                            VerileriGetir(); //ekranda goster
                        }
                        else
                        {
                            MessageBox.Show("Bu ID numarasına ait bir kayıt bulunamadı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Silme sırasında hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            Form1 anaForm = new Form1();
            this.Hide(); 
            anaForm.ShowDialog(); // Ana formu aç vde bekle bıtene  kadar

            this.Show(); // İşlem bitip ana form kapanınca Admin panelini tekrar göster
            VerileriGetir(); 
        }

        private void depoekle_Click(object sender, EventArgs e)
        {
            depoyaekle ekleFormu = new depoyaekle();  //iş bitinc eheömen bu form  gerı acma
            this.Hide(); 
            ekleFormu.ShowDialog(); 
            this.Show(); // Depo ekle formu kapanınca admin panelini tekrar göster
            VerileriGetir(); 
        }

        private void btnyeniisci_Click(object sender, EventArgs e)
        {
            yeniisci isciformu = new yeniisci();
            this.Hide(); 
            isciformu.ShowDialog(); 
            this.Show(); // Form kapanınca admin panelini tekrar göster
            VerileriGetir(); 
        }

        private void btnoda_Click(object sender, EventArgs e)
        {
            odaekle odaFormu = new odaekle();
            this.Hide(); 
            odaFormu.ShowDialog(); 
            this.Show(); // Form kapanınca admin panelini tekrar göster
            VerileriGetir(); 
        }
    }
}