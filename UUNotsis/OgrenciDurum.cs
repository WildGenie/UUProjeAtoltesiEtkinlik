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
    public partial class OgrenciDurum : Form
    {
        public OgrenciDurum()
        {
            InitializeComponent();
        }

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
        }
    }
}
