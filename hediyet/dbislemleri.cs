using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace hediyet
{
    class dbislemleri
    {

        public string DbConnect()
        {


            string connetionString;
            SqlConnection cnn;
            connetionString = @"Data Source=DESKTOP-I5C70L2\CAGRI;
            Initial Catalog=hediyet;
            User ID=admin;
            Password=admin123456;";
            cnn = new SqlConnection(connetionString);
            cnn.Open();
            Console.WriteLine(".......db ye bağlanıldı. ");
            cnn.Close();

            string mesaj = "islem tamam";
            return mesaj;
        }



        public void dytsynList()
        {
          




            
            
            

            
        }
    }
}
