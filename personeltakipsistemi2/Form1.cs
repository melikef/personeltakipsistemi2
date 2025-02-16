using personeltakipsistemi2;
using System;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace personeltakipsistemi2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Hashleme fonksiyonu: Girilen þifreyi SHA256 ile hashler
        private string SifreHashle(string sifre)
        {
            using (SHA256 sha256 = SHA256.Create()) // SHA256 nesnesi oluþtur
            {
                byte[] sifreBytes = Encoding.UTF8.GetBytes(sifre); // Þifreyi byte dizisine çevir
                byte[] hashBytes = sha256.ComputeHash(sifreBytes); // Hash hesapla
                return BitConverter.ToString(hashBytes).Replace("-", "").ToLower(); // Hex formatýna çevir ve döndür
            }
        }

        private void buttonGiris_Click_1(object sender, EventArgs e)
        {
            string dogruKullaniciAdi = "Melike ERDOÐAN";
            string dogruSifreHash = SifreHashle("Melike123456"); // Gerçek þifrenin hashlenmiþ hali

            string girilenKullaniciAdi = txtboxKullaniciAd.Text;
            string girilenSifreHash = SifreHashle(txtboxSifre.Text); // Kullanýcýnýn girdiði þifreyi hashle

            if (girilenKullaniciAdi == dogruKullaniciAdi && girilenSifreHash == dogruSifreHash)
            {
                // Giriþ baþarýlý, Form2'ye geçiþ yap
                this.Hide(); // Form1'i gizle
                Form2 form2 = new Form2(); // Yeni Form2 nesnesi oluþtur
                form2.ShowDialog(); // Form2'yi göster ve kullanýcý etkileþimini bekle
                this.Show(); // Form2 kapatýldýðýnda Form1'i tekrar göster

            }
            else
            {
                // Hatalý giriþ mesajý göster
                MessageBox.Show("Kullanýcý adý veya þifre hatalý!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
    }
}
