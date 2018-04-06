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

    public partial class Mesajlar : Form
    {
        public Mesajlar()
        {
            InitializeComponent();
        }

        public string numara;
        private void buttonGonder_Click(object sender, EventArgs e)
        {
            baglanti.Open();

            SqlCommand komut = new SqlCommand("insert into Mesajlar (gonderen,alici,baslik,icerik) values (@gon,@alici,@baslik,@icerik)", baglanti);
            komut.Parameters.AddWithValue("@gon", numara);
            komut.Parameters.AddWithValue("@alici", maskedTextBoxAlici.Text);
            komut.Parameters.AddWithValue("@baslik", textBoxBaslik.Text);
            komut.Parameters.AddWithValue("@icerik", richTextBoxMesaj.Text);

            komut.ExecuteNonQuery();
            baglanti.Close();

            MessageBox.Show("Mesajınız İletildi", "Notsis Bilgilendirme");
            Listele();

        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=UUNOTSIS;Integrated Security=True");

        void Listele()
        {
            baglanti.Open();

            SqlCommand komut = new SqlCommand("select * from Mesajlar where alici=@alici", baglanti);
            komut.Parameters.AddWithValue("@alici", numara);

            SqlDataAdapter dataAdapter = new SqlDataAdapter(komut);

            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            dataGridView.DataSource = dataTable;

            baglanti.Close();

        }

        private void Mesajlar_Load(object sender, EventArgs e)
        {
            Listele();
        }
    }
}
