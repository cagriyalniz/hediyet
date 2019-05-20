using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hediyet
{
    public partial class Kayit : Form

        
    {

        int kilo;
        public Kayit()
        {
            InitializeComponent();

            dbislemleri baglan = new dbislemleri();
            baglan.Baglan();

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

        private void name_textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void age_textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public void weight_textBox1_TextChanged(object sender, EventArgs e)
        {
            
            
           
        }

        private void size_textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void kAdi_textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void soyad_textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void sifre_textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void kyt_button1_Click(object sender, EventArgs e)
        {

            dbislemleri kayit = new dbislemleri();
            kayit.DanisanKaydi(kAdi_textBox1.Text, sifre_textBox1.Text, name_textBox1.Text, soyad_textBox1.Text, Convert.ToInt32(this.weight_textBox1.Text));
            


        }

    
    }
}
