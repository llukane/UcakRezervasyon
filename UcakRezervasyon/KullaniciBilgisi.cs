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
           bool isAnyChecked = false;
                foreach (Control control in this.Controls)
                {
                    if (control is CheckBox && ((CheckBox)control).Checked)
                    {
                        isAnyChecked = true;
                        break;
                    }
                }
                if (!isAnyChecked)
                {
                    MessageBox.Show("Koltuk seçimi yapmalısınız!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
              else
            {
                BiletEkrani frmShow = new BiletEkrani();
                frmShow.ShowDialog();
            }

           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton13_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true; 
            }
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }
    }
}
