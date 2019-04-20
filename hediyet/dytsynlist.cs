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

            string connetionString;
            SqlConnection cnn;
            connetionString = @"Data Source=DESKTOP-I5C70L2\CAGRI;
            Initial Catalog=hediyet;
            User ID=admin;
            Password=admin123456;";
            cnn = new SqlConnection(connetionString);
            cnn.Open();
            SqlCommand komut = new SqlCommand("SELECT * FROM tbl_diyetisyen", cnn);
            SqlDataReader veriyukle = komut.ExecuteReader();
            DataTable tablo = new DataTable();
            tablo.Load(veriyukle);
            dataGridView1.DataSource = tablo;
            cnn.Close();

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
