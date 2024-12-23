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
    public partial class Giris : Form
    {
        public Giris()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Giris_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;

            if ( username == "admin" && password == "123456")
            {
                AdminPanel frmShow = new AdminPanel();
                frmShow.ShowDialog();
                this.Hide();
            }

            else if ( username == "fatma" && password == "123456")
            {
                BiletSecim frmShow = new BiletSecim();
                frmShow.ShowDialog();
                this.Hide();
            }

            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre hatalı.");
            }


        }
    }
}
