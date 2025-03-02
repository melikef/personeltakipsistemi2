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
            // Kullanýcýnýn girdiði bilgileri al
            string girilenKullaniciAdi = txtboxKullaniciAd.Text;
            string girilenSifre = txtboxSifre.Text;

            // SQL baðlantý dizesini tanýmla (kendi veritabaný bilgilerini ekle!)
            string connectionString = "Server=DESKTOP-0HPF63K;Database=personeltakipsistemi;Integrated Security=True;";

            // SQL sorgusu: Kullanýcý adý ve þifreyi kontrol et
            string query = "SELECT COUNT(*) FROM girisekran WHERE kullaniciad = @kullaniciad AND sifre = @sifre";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    // Kullanýcý girdilerini parametre olarak ekle (SQL Injection korumasý için)
                    cmd.Parameters.AddWithValue("@kullaniciad", Class1.HashSifre(girilenKullaniciAdi)); // Kullanýcý adýný da hash'le
                    cmd.Parameters.AddWithValue("@sifre", Class1.HashSifre(girilenSifre)); // Hashlenmiþ þifreyi SQL'e gönder


                    try
                    {
                        conn.Open();
                        int count = Convert.ToInt32(cmd.ExecuteScalar());

                        if (count > 0)
                        {
                            // Giriþ baþarýlý, yeni formu aç
                            this.Hide(); // Form1'i gizle
                            personel form2 = new personel(); // Yeni form nesnesini oluþtur
                            form2.ShowDialog(); // Form2'yi aç ve kullanýcý etkileþimini bekle
                            this.Show(); // Form2 kapatýldýðýnda tekrar Form1'i göster
                        }
                        else
                        {
                            // Hatalý giriþ mesajý göster
                            MessageBox.Show("Kullanýcý adý veya þifre hatalý!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Baðlantý hatasý: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kullanýcý adý veya þifre hatalý!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}