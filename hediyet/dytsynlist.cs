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
    public partial class dytsynlist : Form
    {
        public dytsynlist()
        {
          
            InitializeComponent();
          
        }

        private void button1_Click(object sender, EventArgs e)
        {

            //dbislemleri baglanma = new dbislemleri();
            //baglanma.DbConnect();
            try
            {
                dbislemleri dytsynlisteleme = new dbislemleri();
                dataGridView1.DataSource = dytsynlisteleme.dytsynList();
            }
            catch (Exception hata)
            {

                //label_Message.Text = hata.Message;
            }

            
            
            
            

        }

        private void pictureBox1_Click(object sender, EventArgs e)
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
    }
}
