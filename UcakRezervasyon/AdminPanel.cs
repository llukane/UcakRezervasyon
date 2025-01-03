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
    public partial class AdminPanel : Form
    {
        public AdminPanel()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ucuslar frmShow = new Ucuslar();
            frmShow.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Yolcular frmShow = new Yolcular();
            frmShow.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            var dialogResult = MessageBox.Show("Sistemden çıkmak istediğinize emin misiniz?", "Çıkış Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                Giris frmShow = new Giris();
                frmShow.ShowDialog();
                this.Hide();
            }
        }
    }
}
