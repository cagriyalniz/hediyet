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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            dytsynlist f2 = new dytsynlist();

            f2.FormClosing += F2_FormClosing;
            f2.ShowDialog();
                                          
        }

        private void F2_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Close();
        }

        private void dnsn_button_Click(object sender, EventArgs e)
        {

            dbislemleri Danisangirisi = new dbislemleri();
            Console.WriteLine("db bağlı");

            bool girisislemi = Danisangirisi.Danisankontrol(kadi_textBox.Text, sifre_textBox.Text);


            if (girisislemi == true)
            {
                MessageBox.Show("Giriş Başarılı Hoş Geldiniz");

                this.Hide();
                dnsn_first_page f4 = new dnsn_first_page(2);

                f4.FormClosing += F2_FormClosing;
                f4.ShowDialog();

                

            }
            else
            {
                MessageBox.Show("Bilgileriniz Hatalı Lütfen Tekrar Deneyin");
            }
        }

        
        private void dyt_button_Click(object sender, EventArgs e)
        {

            dbislemleri Uyegirisi = new dbislemleri();
            Console.WriteLine("db bağlı");
           
            bool girisislemi = Uyegirisi.Uyekontrol(kadi_textBox.Text, sifre_textBox.Text);
            

            if (girisislemi == true)
            {
               
               MessageBox.Show("Giriş Başarılı Hoş Geldiniz");

                this.Hide();
                dytsyn_first_page f3 = new dytsyn_first_page();

                f3.FormClosing += F2_FormClosing;
                f3.ShowDialog();

            }
            else
            {
                MessageBox.Show("Bilgileriniz Hatalı Lütfen Tekrar Deneyin");
            }
        }

        private void kyt_button_Click(object sender, EventArgs e)
        {

            this.Hide();
            Kayit f4 = new Kayit();

            f4.FormClosing += F2_FormClosing;
            f4.ShowDialog();

        }

        private void kadi_textBox_Click(object sender, EventArgs e)
        {


        }

        private void sifre_textBox_Click(object sender, EventArgs e)
        {


        }


        private void label1_Click(object sender, EventArgs e)
        {
            

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

      

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void kadi_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void sifre_textBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
