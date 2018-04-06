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
            this.Listele();

        }

        readonly SqlConnection baglanti = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=UUNOTSIS;Integrated Security=True");

        void Listele()
        {
            SqlDataAdapter dataAdapter = new SqlDataAdapter("Select * From Ogrenci", this.baglanti);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            dataGridView.DataSource = dataTable;

        }

    }
}
