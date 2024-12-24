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
    public partial class OdemeEkrani : Form
    {
        public OdemeEkrani()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BiletEkrani frmShow = new BiletEkrani();
            frmShow.ShowDialog();
        }
    }
}
