using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;


namespace DisKlingiOtomasyonu
{
    internal class ConnectionString
    {
        public SqlConnection GetCon()
        {
            SqlConnection baglanti= new SqlConnection();
            baglanti.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\umays\OneDrive\Belgeler\DentalIDb.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=True";
            return baglanti; 
        }
    }
}
