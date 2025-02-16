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

        // Hashleme fonksiyonu: Girilen �ifreyi SHA256 ile hashler
        private string SifreHashle(string sifre)
        {
            using (SHA256 sha256 = SHA256.Create()) // SHA256 nesnesi olu�tur
            {
                byte[] sifreBytes = Encoding.UTF8.GetBytes(sifre); // �ifreyi byte dizisine �evir
                byte[] hashBytes = sha256.ComputeHash(sifreBytes); // Hash hesapla
                return BitConverter.ToString(hashBytes).Replace("-", "").ToLower(); // Hex format�na �evir ve d�nd�r
            }
        }

        private void buttonGiris_Click_1(object sender, EventArgs e)
        {
            string dogruKullaniciAdi = "Melike ERDO�AN";
            string dogruSifreHash = SifreHashle("Melike123456"); // Ger�ek �ifrenin hashlenmi� hali

            string girilenKullaniciAdi = txtboxKullaniciAd.Text;
            string girilenSifreHash = SifreHashle(txtboxSifre.Text); // Kullan�c�n�n girdi�i �ifreyi hashle

            if (girilenKullaniciAdi == dogruKullaniciAdi && girilenSifreHash == dogruSifreHash)
            {
                // Giri� ba�ar�l�, Form2'ye ge�i� yap
                this.Hide(); // Form1'i gizle
                Form2 form2 = new Form2(); // Yeni Form2 nesnesi olu�tur
                form2.ShowDialog(); // Form2'yi g�ster ve kullan�c� etkile�imini bekle
                this.Show(); // Form2 kapat�ld���nda Form1'i tekrar g�ster

            }
            else
            {
                // Hatal� giri� mesaj� g�ster
                MessageBox.Show("Kullan�c� ad� veya �ifre hatal�!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
    }
}
