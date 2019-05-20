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
    public partial class dnsn_first_page : Form
    {

        int kid;
        public dnsn_first_page(int kid_)
        {
            InitializeComponent();
            kid = kid_;
        }

        dytoner oneri = new dytoner();


        private void dnsn_first_page_Load(object sender, EventArgs e)
        {

        }




        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void sabahlabel_Click(object sender, EventArgs e)
        {

        }

        private void oglelabel_Click(object sender, EventArgs e)
        {

        }

       private void kilo_button_Click(object sender, EventArgs e)
        {

           dbislemleri kiloekle = new dbislemleri();
         kiloekle.Guncel_kilo(adtextBox1.Text, soyadtextBox1.Text, Convert.ToInt32(this.kilo_textBox.Text));  // tabloya adı ve soyadını nereden ekleyeceğiz ?
       }


      

        private void kilo_textBox_TextChanged(object sender, EventArgs e)
        {

        }


        private void adtextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dnsn_first_page_Load_1(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void kilobutton_Click(object sender, EventArgs e)
        {
        //    dbislemleri grafik = new dbislemleri();
        //    chart1.DataSource = grafik.Guncel_kilo();
        }
    }
    }
