using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace UcakRezervasyon
{
    public partial class Ucuslar : Form
    {
        
        public bool iptaledildimi { get; private set; } = false;

        public Ucuslar()
        {
            InitializeComponent();
            instance = this;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            iptaledildimi = true;
            button1.Enabled = false;

           

        }

        private void button2_Click(object sender, EventArgs e)
        {
            iptaledildimi = true;
            button2.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            iptaledildimi = true;
            button3.Enabled = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            iptaledildimi = true;
            button4.Enabled = false;
        }
    }
}
