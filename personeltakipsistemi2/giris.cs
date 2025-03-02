using Microsoft.Data.SqlClient;
using personeltakipsistemi2;
using System;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;




namespace personeltakipsistemi2
{
    public partial class giris : Form
    {
        public giris()
        {
            InitializeComponent();
        }

      
        private void buttonGiris_Click(object sender, EventArgs e)
        {
            // Kullan�c�n�n girdi�i bilgileri al
            string girilenKullaniciAdi = txtboxKullaniciAd.Text;
            string girilenSifre = txtboxSifre.Text;

            // SQL ba�lant� dizesini tan�mla (kendi veritaban� bilgilerini ekle!)
            string connectionString = "Server=DESKTOP-0HPF63K;Database=personeltakipsistemi;Integrated Security=True;";

            // SQL sorgusu: Kullan�c� ad� ve �ifreyi kontrol et
            string query = "SELECT COUNT(*) FROM girisekran WHERE kullaniciad = @kullaniciad AND sifre = @sifre";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    // Kullan�c� girdilerini parametre olarak ekle (SQL Injection korumas� i�in)
                    cmd.Parameters.AddWithValue("@kullaniciad", Class1.HashSifre(girilenKullaniciAdi)); // Kullan�c� ad�n� da hash'le
                    cmd.Parameters.AddWithValue("@sifre", Class1.HashSifre(girilenSifre)); // Hashlenmi� �ifreyi SQL'e g�nder


                    try
                    {
                        conn.Open();
                        int count = Convert.ToInt32(cmd.ExecuteScalar());

                        if (count > 0)
                        {
                            // Giri� ba�ar�l�, yeni formu a�
                            this.Hide(); // Form1'i gizle
                            personel form2 = new personel(); // Yeni form nesnesini olu�tur
                            form2.ShowDialog(); // Form2'yi a� ve kullan�c� etkile�imini bekle
                            this.Show(); // Form2 kapat�ld���nda tekrar Form1'i g�ster
                        }
                        else
                        {
                            // Hatal� giri� mesaj� g�ster
                            MessageBox.Show("Kullan�c� ad� veya �ifre hatal�!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ba�lant� hatas�: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kullan�c� ad� veya �ifre hatal�!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}