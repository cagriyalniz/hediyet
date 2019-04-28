using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
namespace hediyet
{
    class dbislemleri
    {
       public DataTable tablo ;
        public SqlDataAdapter adaptor;
        public SqlConnection cnn;

        //string yol = ConfigurationManager.ConnectionStrings["Dbs..."].ConnectionString;
        static string connetionString = @"Data Source=DESKTOP-I5C70L2\CAGRI;Initial Catalog=hediyet;User ID=admin;Password=admin123456;";
        

        public void Baglan()
        {
         cnn = new SqlConnection(connetionString);

            if (cnn.State != ConnectionState.Open)
            {
                cnn.Open();
            }
        }
        public void DbConnect()
        {

            //cnn.Open();
            //Console.WriteLine(".......db ye bağlanıldı. ");
            

            
        }



        public DataTable dytsynList()
        {

            //DataGridView dataGridView1 = new DataGridView();
            Baglan();
            SqlCommand komut = new SqlCommand("SELECT * FROM tbl_diyetisyen", cnn);
            komut.CommandType = CommandType.Text;
            komut.ExecuteNonQuery();
            tablo = new DataTable();
            adaptor = new SqlDataAdapter(komut);
            adaptor.Fill(tablo);
          
           // dataGridView1.DataSource = tablo;

            cnn.Close();
            cnn.Dispose();


            return tablo;
        }


        public bool Uyekontrol(string kadi, string sifre)
        {
            Baglan();

            SqlCommand kmt = new SqlCommand("Select * from tbl_uye Where kadi=@k and sifre=@s", cnn);

            kmt.Parameters.AddWithValue("@k", kadi);
            kmt.Parameters.AddWithValue("@s", sifre);
            

            SqlDataReader oku = kmt.ExecuteReader();

            if (oku.Read())
            {
                cnn.Close(); //Eğer veri döndüyse bağlantımızı kapatıyoruz 
                cnn.Dispose();
                return true; //ve oluşturduğumuz bool değişkeninin değerini true olarak döndürüyoruz yani giris değişkenimizin değeri true oluyor.
            }
            else
            {
                cnn.Close(); //Eğer veri dönmediyse bağlantımızı kapatıyoruz.Kapatmadığımız takdirde kullanıcı 2. kez üyeliğe girmeyi denediğinde hata ile karşılaşacaktır.
                cnn.Dispose();
                return false; //ve oluşturduğumuz bool değişkeninin değerini false olarak döndürüyoruz yani giris değişkenimizin değeri false oluyor.
            }

            
           
        }

    }
}
