using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace performans_odevi
{
    public partial class GirisFormu : Form
    {
        public GirisFormu()
        {
            InitializeComponent();
        }

        private void GirisFormu_Load(object sender, EventArgs e)
        {

        }

       
        private void giris_Click(object sender, EventArgs e)
        {
            // Kullanıcı adı ve şifre kontrolü
            if (kadi.Text == "samet" && sifre.Text == "1907")
            {
                MessageBox.Show("Giriş başarılı! Yönetim paneline yönlendiriliyorsunuz.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // admin p. ac
                AdminPaneli panel = new AdminPaneli();
                panel.Show();

                // bura kapa
                this.Close();
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre hatalı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                kadi.Clear();
                sifre.Clear();
                kadi.Focus();
            }
        }
    }
}