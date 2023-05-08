using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace otel_otomasyonu
{
    internal class Otel_Otomasyonu
    {
        //Sql bağlantimızıkuruyoruz
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-T2U3R9D\\SQLEXPRESS;Initial Catalog=Otel_Otomasyonu;Integrated Security=True");
        DataTable tablo;

        
        public void ekle_sil_güncelle(SqlCommand komut, string sorgu)
        {
            baglanti.Open();
            komut.Connection = baglanti;
            komut.CommandText = sorgu;
            komut.ExecuteNonQuery();
            baglanti.Close();
        }
        public DataTable listele(SqlDataAdapter adtr, string sorgu)
        {
            tablo = new DataTable();
            adtr = new SqlDataAdapter(sorgu, baglanti);
            adtr.Fill(tablo);
            baglanti.Close();
            return tablo;
        }
    }
}
