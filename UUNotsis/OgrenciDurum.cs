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

    public partial class OgrenciDurum : Form
    {
        public OgrenciDurum()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(
            @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=UUNOTSIS;Integrated Security=True");

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void labelAdSoyad_Click(object sender, EventArgs e)
        {

        }

        public string numara;

        private void OgrenciDurum_Load(object sender, EventArgs e)
        {
            labelNumara.Text = numara;

            // Öğrenci verilerini getirme

            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * from Ogrenci where Numara=@no", baglanti);
            komut.Parameters.AddWithValue("@no", labelNumara.Text);

            SqlDataReader dataReader = komut.ExecuteReader();

            string durum;

            while (dataReader.Read())
            {
                labelAdSoyad.Text = dataReader[1].ToString() + " " + dataReader[2].ToString();
                labelSinav1.Text = dataReader[5].ToString();
                labelSinav2.Text = dataReader[6].ToString();
                labelSinav3.Text = dataReader[7].ToString();
                labelOrtalama.Text = dataReader[8].ToString();

                durum = dataReader[9].ToString();

                if (durum == "True")
                {
                    labelDurum.Text = "Geçti";
                }
                else
                {
                    labelDurum.Text = "Kaldi";
                }


            }
            baglanti.Close();

        }

        private void button_Click(object sender, EventArgs e)
        {
            Mesajlar mesajlar = new Mesajlar();
            mesajlar.numara = numara;
            mesajlar.Show();

        }
    }
}
