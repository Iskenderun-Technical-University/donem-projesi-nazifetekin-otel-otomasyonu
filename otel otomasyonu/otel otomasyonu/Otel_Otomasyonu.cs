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

        internal void Tc_Ara(TextBox TcAra, TextBox Tc, TextBox Ad, TextBox Soyad, TextBox Telefon, TextBox Email, TextBox Adres, string sorgu)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                Tc.Text = read["Tc"].ToString();
                Ad.Text = read["Ad"].ToString();
                Soyad.Text = read["Soyad"].ToString();
                Telefon.Text = read["Telefon"].ToString();
                Email.Text = read["Email"].ToString();
                Adres.Text = read["Adres"].ToString();
            }
            baglanti.Close();

            
        }
        public void CombodanGetir(ComboBox Odalar, ComboBox Kat, TextBox OdaNo, TextBox BanyoSayisi, TextBox YatakSayisi, string sorgu)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                Kat.Text = read["kat"].ToString();
                OdaNo.Text = read["OdaNo"].ToString();
                BanyoSayisi.Text = read["BanyoSayisi"].ToString();
                YatakSayisi.Text = read["YatakSayisi"].ToString();
            }
            baglanti.Close();
        }
        public void Ucret_Hesapla(TextBox ucret, string sorgu)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            SqlDataReader read = komut.ExecuteReader();
           
            baglanti.Close();
        }
    }
}
