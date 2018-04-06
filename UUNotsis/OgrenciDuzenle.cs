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

        readonly SqlConnection baglanti = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=UUNOTSIS;Integrated Security=True");

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
            MessageBox.Show("Öğrenci Kaydı Tamamlandı", "UUNOTSIS Bildirim",MessageBoxButtons.OK,MessageBoxIcon.Information);
            this.Listele();
        }
    }
}
