using System;
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
    public partial class dytsyn_first_page : Form
    {
        public dytsyn_first_page()
        {
            InitializeComponent();
        }


        private void pictureBox4_Click(object sender, EventArgs e)
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

      

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            dytoner f1 = new dytoner();

            f1.FormClosing += F1_FormClosing;
            f1.ShowDialog();
        }

        private void list_button_Click(object sender, EventArgs e)
        {
            try
            {
                dbislemleri danisanlisteleme = new dbislemleri();
                dataGridView1.DataSource = danisanlisteleme.danisan();  
            }
            catch (Exception hata)
            {

                //label_Message.Text = hata.Message;
            }

        }
    }
}
