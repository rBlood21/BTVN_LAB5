using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BTVN_LAB5
{
    public partial class Trangchinh : Form
    {
        public Trangchinh()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Bài2BTVN b2 = new Bài2BTVN();
            b2.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            BTNangCao nc = new BTNangCao();
            nc.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Bai3BTVN b3 = new Bai3BTVN();
            b3.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Bai1BTVN b1 = new Bai1BTVN();
            b1.ShowDialog();
        }
    }
}
