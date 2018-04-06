using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace UUNotsis
{
    public partial class Giris : Form
    {
        public Giris()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=UUNOTSIS;Integrated Security=True");

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * From Ogrenci Where Numara=@no and Sifre=@sifre", baglanti);

            komut.Parameters.AddWithValue("@no", maskedTextBoxNumara.Text);
            komut.Parameters.AddWithValue("@sifre", textBoxSifre.Text);

            SqlDataReader dataReader = komut.ExecuteReader();

            if (dataReader.Read())
            {
                OgrenciDurum ogrenciDurum = new OgrenciDurum();
                ogrenciDurum.numara = maskedTextBoxNumara.Text;
                ogrenciDurum.Show();
            }
            else
            {
                MessageBox.Show(
                    "Kullanıcı adı şifre hatalı",
                    "Notsis Bilgilendirme",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }

            baglanti.Close();
        }

        private void textBoxSifre_TextChanged(object sender, EventArgs e)
        {
            if (textBoxSifre.Text == "00000")
            {
                OgrenciDuzenle ogrenciDuzenle = new OgrenciDuzenle();
                ogrenciDuzenle.Show();
                Hide();
            }
        }
    }
}
