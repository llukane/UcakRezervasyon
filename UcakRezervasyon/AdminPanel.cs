﻿using System;
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
            SeferIptali frmShow = new SeferIptali();
            frmShow.ShowDialog();
        }
    }
}
