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
        
       // public string kadi;
        public void Baglan()
        {
         cnn = new SqlConnection(connetionString);

            if (cnn.State != ConnectionState.Open)
            {
                cnn.Open();
            }
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


        public bool Danisankontrol(string kadi, string sifre)
        {
            Baglan();

            SqlCommand kmt = new SqlCommand("Select k_adi, id from tb_danisan Where k_adi=@k and sifre=@s", cnn);

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

        public SqlCommand DanisanKaydi(string k_adi, string sifre, string ad, string soyad, int kilo)
        {

            Baglan();


            string uyekayit = "insert into tb_danisan(k_adi,sifre,ad,soyad,kilo) values (@kAdi_textBox1, @sifre_textBox1, @ad_textBox1, @soyad_textBox1, @weight_textBox1)" +
                                "insert into tb_kilo(adi, soyadi, guncel_kilo) values (@ad_textBox1, @soyad_textBox1, @weight_textBox1)";


           // string uyekay = "insert into tbl_kilo(adi, soyadi, guncel_kilo) values (@ad_textBox1, @soyad_textBox1, @weight_textBox1)";

            SqlCommand komut = new SqlCommand(uyekayit, cnn);
           // SqlCommand kom = new SqlCommand(uyekayit, cnn);

            komut.Parameters.AddWithValue("@kAdi_textBox1", k_adi);
            komut.Parameters.AddWithValue("@sifre_textBox1", sifre);
            komut.Parameters.AddWithValue("@ad_textBox1", ad);
            komut.Parameters.AddWithValue("@soyad_textBox1", soyad);
            komut.Parameters.AddWithValue("@weight_textBox1", kilo);


            // komut.Parameters.AddWithValue("@ad_textBox1", ad);
            // komut.Parameters.AddWithValue("@soyad_textBox1", soyad);
            //  komut.Parameters.AddWithValue("@weight_textBox1", kilo);
            komut.ExecuteNonQuery();



            MessageBox.Show("Kayıt Başarılı Hoş Geldiniz");
            return komut;


        }

        public SqlCommand Guncel_kilo (string adi, string soyadi, int kilo)
        {
            Baglan();


            string kiloekle = "insert into tb_kilo(k_id, guncel_kilo) values (@adtextBox1, @soyadtextBox1, @kilo_textBox)"; //tabloya ad ve soyadını nereden çekeceğiz



            SqlCommand komut = new SqlCommand(kiloekle, cnn);

            
            komut.Parameters.AddWithValue("@adtextBox1", adi);
            komut.Parameters.AddWithValue("@soyadtextBox1", soyadi);
            komut.Parameters.AddWithValue("@kilo_textBox", kilo);


            // komut.Parameters.AddWithValue("@ad_textBox1", ad);
            // komut.Parameters.AddWithValue("@soyad_textBox1", soyad);
            //  komut.Parameters.AddWithValue("@weight_textBox1", kilo);
            komut.ExecuteNonQuery();



            MessageBox.Show("Kilo eklendi");
            return komut;



        }


        public DataTable danisan()
        {

            //DataGridView dataGridView1 = new DataGridView();
            Baglan();
            SqlCommand komut = new SqlCommand("SELECT ad,soyad,kilo FROM tb_danisan", cnn);
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


        //private void chart(string adi)     // ne döndürecek
        //{

        //    Baglan();

        //    string sqlStr = "SELECT guncel_kilo, tarih from tb_kilo where adi = @adtextBox1 group by tarih ";

        //    SqlDataAdapter myCommand = new SqlDataAdapter(sqlStr, cnn);
        //    DataSet ds = new DataSet();
        //    myCommand.Fill(ds);

        //    DataView source = new DataView(ds.Tables[0]);

        //    chart1.DataSource = source;

        //    chart.Series[0].XValueMember = "tarih";
        //    chart.Series[0].YValueMembers = "guncel_kilo";
        //    chart.DataBind();

        //}



    }
}
