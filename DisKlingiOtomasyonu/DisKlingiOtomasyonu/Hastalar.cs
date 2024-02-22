using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;
using System.Data;

namespace DisKlingiOtomasyonu
{
    internal class Hastalar
    {
        public void HastaEkle(string query)
        {
            ConnectionString MyConnection=new ConnectionString();
            SqlConnection baglanti=MyConnection.GetCon();
            SqlCommand komut=new SqlCommand();
            komut.Connection = baglanti;
            baglanti.Open();
            komut.CommandText=query;
            komut.ExecuteNonQuery();
            baglanti.Close();
        } 
        public void HastaSil(string query) 
        {
            ConnectionString MyConnection = new ConnectionString();
            SqlConnection baglanti = MyConnection.GetCon();
            SqlCommand komut = new SqlCommand();
            komut.Connection = baglanti;
            baglanti.Open();
            komut.CommandText = query;
            komut.ExecuteNonQuery();
            baglanti.Close();
        }
       
        public DataSet ShowHasta(string query)
        {
            ConnectionString MyConnection = new ConnectionString();
            SqlConnection baglanti = MyConnection.GetCon();
            SqlCommand komut = new SqlCommand();
            komut.Connection = baglanti;
            komut.CommandText=query;
            SqlDataAdapter sda=new SqlDataAdapter(komut);
            DataSet ds=new DataSet();
            sda.Fill(ds);
            return ds;
        }
    }
}
