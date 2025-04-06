using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PersonelTakipSistemi
{
    public partial class personel : Form
    {
        SqlConnection baglanti = new SqlConnection("Server=.;Database=personel;Trusted_Connection=True;");

        public personel()
        {
            InitializeComponent();
        }
            
        
        private void buttonKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("INSERT INTO personelliste (ID, AD, SOYAD, DEPARTMAN) VALUES (@ID, @Ad, @Soyad, @Departman)", baglanti);
                komut.Parameters.AddWithValue("@ID", txtboxId.Text);
                komut.Parameters.AddWithValue("@Ad", txtboxAd.Text);
                komut.Parameters.AddWithValue("@Soyad", txtboxSoyad.Text);
                komut.Parameters.AddWithValue("@Departman", txtboxDepartman.Text);
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Personel başarıyla eklendi.");
                Listele();
                Temizle();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
                baglanti.Close();
            }
        }

        private void buttonListele_Click(object sender, EventArgs e)
        {
            Listele();
        }

        private void Listele()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM personelliste", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void buttonSil_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("DELETE FROM personelliste WHERE ID=@ID", baglanti);
                komut.Parameters.AddWithValue("@ID", txtboxId.Text);
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Personel silindi.");
                Listele();
                Temizle();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
                baglanti.Close();
            }
        }

        private void buttonGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("UPDATE personelliste SET AD=@Ad, SOYAD=@Soyad, DEPARTMAN=@Departman WHERE ID=@ID", baglanti);
                komut.Parameters.AddWithValue("@Ad", txtboxAd.Text);
                komut.Parameters.AddWithValue("@Soyad", txtboxSoyad.Text);
                komut.Parameters.AddWithValue("@Departman", txtboxDepartman.Text);
                komut.Parameters.AddWithValue("@ID", txtboxId.Text);
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Personel bilgisi güncellendi.");
                Listele();
                Temizle();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
                baglanti.Close();
            }
        }

        private void buttonTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void Temizle()
        {
            txtboxId.Clear();
            txtboxAd.Clear();
            txtboxSoyad.Clear();
            txtboxDepartman.Clear();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txtboxId.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            txtboxAd.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txtboxSoyad.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            txtboxDepartman.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}

