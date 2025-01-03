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
    public partial class KullaniciBilgisi : Form
    {
        public KullaniciBilgisi()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BiletEkrani frmShow = new BiletEkrani();
            frmShow.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
