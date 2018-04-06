using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace UUNotsis
{
    using System.Data.SqlClient;

    public partial class OgrenciDuzenle : Form
    {
        public OgrenciDuzenle()
        {
            InitializeComponent();
        }

        private void OgrenciDuzenle_Load(object sender, EventArgs e)
        {
            Listele();

        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=UUNOTSIS;Integrated Security=True");

        void Listele()
        {
            SqlDataAdapter dataAdapter = new SqlDataAdapter("Select * From Ogrenci", baglanti);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            dataGridView.DataSource = dataTable;

        }

        private void buttonKaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand(
                "insert into Ogrenci (Ad, Soyad, Numara, Sifre) values (@ad, @soyad, @numara, @sifre)",
                baglanti);
            komut.Parameters.AddWithValue("@ad", textBoxAd.Text);
            komut.Parameters.AddWithValue("@soyad", textBoxSoyAd.Text);
            komut.Parameters.AddWithValue("@numara", maskedTextBoxNumara.Text);
            komut.Parameters.AddWithValue("@sifre", textBoxSifre.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Öğrenci Kaydı Tamamlandı", "UUNOTSIS Bildirim", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Listele();
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView.SelectedCells[0].RowIndex;
            maskedTextBoxNumara.Text = dataGridView.Rows[secilen].Cells[3].Value.ToString();
            textBoxAd.Text = dataGridView.Rows[secilen].Cells[1].Value.ToString();
            textBoxSoyAd.Text = dataGridView.Rows[secilen].Cells[2].Value.ToString();
            textBoxSifre.Text = dataGridView.Rows[secilen].Cells[4].Value.ToString();

            textBoxSinav1.Text = dataGridView.Rows[secilen].Cells[5].Value.ToString();
            textBoxSinav2.Text = dataGridView.Rows[secilen].Cells[6].Value.ToString();
            textBoxSinav3.Text = dataGridView.Rows[secilen].Cells[7].Value.ToString();
            textBoxOrtalama.Text = dataGridView.Rows[secilen].Cells[8].Value.ToString();
            textBoxDurum.Text = dataGridView.Rows[secilen].Cells[9].Value.ToString();
        }

        private void buttonGuncelle_Click(object sender, EventArgs e)
        {

            // Ortalama hesaplama
            double s1, s2, s3, ort;
            s1 = Convert.ToDouble(textBoxSinav1.Text);
            s2 = Convert.ToDouble(textBoxSinav2.Text);
            s3 = Convert.ToDouble(textBoxSinav3.Text);

            ort = (s1 + s2 + s3) / 3;

            textBoxOrtalama.Text = ort.ToString("#.##");

            // Durum kontrolü
            if (ort >= 50)
            {
                textBoxDurum.Text = "Geçti";
            }
            else
            {
                textBoxDurum.Text = "Kaldı";
            }

            // Güncelleme İşlemi

            baglanti.Open();
            var komut = new SqlCommand("Update Ogrenci set Ad=@ad, Soyad=@soyad, sifre=@sifre, Sinav1=@s1, Sinav2=@s2, Sinav3=@s3, Ortalama=@ort, Durum=@durum where numara=@no", baglanti);
            komut.Parameters.AddWithValue("@ad", textBoxAd.Text);
            komut.Parameters.AddWithValue("@soyad", textBoxSoyAd.Text);
            komut.Parameters.AddWithValue("@sifre", textBoxSifre.Text);
            komut.Parameters.AddWithValue("@s1", int.Parse(textBoxSinav1.Text));
            komut.Parameters.AddWithValue("@s2", int.Parse(textBoxSinav2.Text));
            komut.Parameters.AddWithValue("@s3", int.Parse(textBoxSinav3.Text));
            komut.Parameters.AddWithValue("@ort", decimal.Parse(textBoxOrtalama.Text));
            komut.Parameters.AddWithValue("@no", maskedTextBoxNumara.Text);

            if (textBoxDurum.Text == "Geçti")
            {
                komut.Parameters.AddWithValue("@durum", true);
            }
            else
            {
                komut.Parameters.AddWithValue("@durum", false);
            }

            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Notlar Güncellendi", "Notsis Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Listele();

        }
    }
}
