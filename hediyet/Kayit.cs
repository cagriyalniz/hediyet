﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hediyet
{
    public partial class Kayit : Form
    {
        public Kayit()
        {
            InitializeComponent();
        }


        private void pictureBoxK_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();

            f1.FormClosing += F1_FormClosing;
            f1.ShowDialog();

        }

        private void F1_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void Kayit_Load(object sender, EventArgs e)
        {

        }
    }
}