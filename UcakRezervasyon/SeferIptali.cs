using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UcakRezervasyon
{
    public partial class SeferIptali : Form
    {
        public SeferIptali()
        {
            InitializeComponent();
        }

        private void label29_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Text = "Sefer İptal Edildi";
            button1.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Text = "Sefer İptal Edildi";
            button2.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.Text = "Sefer İptal Edildi";
            button3.Enabled = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button4.Text = "Sefer İptal Edildi";
            button4.Enabled = false;
        }

        private void SeferIptali_Load(object sender, EventArgs e)
        {

        }
    }
}
