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
    public partial class BiletSecim : Form
    {
        public BiletSecim()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            KullaniciBilgisi frmShow = new KullaniciBilgisi();
            frmShow.ShowDialog();
        }
    }
}
