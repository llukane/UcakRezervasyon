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
    public partial class BiletEkrani : Form
    {

        public BiletEkrani()
        {
            InitializeComponent();
            
            string kod = "TR";
            Random random = new Random();
            int sayi = random.Next(1000, 10000);
            string ucuskodu = kod + sayi.ToString();
            label3.Text = ucuskodu;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            
        }
    }
}
