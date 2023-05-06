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

namespace otel_otomasyonu
{
    public partial class frmMusteriEkle : Form
    {
        Otel_Otomasyonu otel_otomasyonu = new Otel_Otomasyonu();
        public frmMusteriEkle()
        {
            InitializeComponent();
        }

        private void btnİptal_Click(object sender, EventArgs e)
        {
            // thisClose;
            DialogResult result1 = MessageBox.Show("Cikmak istdiginize emin miziniz?", "", MessageBoxButtons.YesNo);
            if (result1 == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {

            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            string cumle = "insert into MusteriB(Ad,Soyad,TC,Email,Telefon,Adres) values(@Ad,@Soyad,@Tc,@Email,@Telefon,@Adres)";
            SqlCommand komut2 = new SqlCommand();
            komut2.Parameters.AddWithValue("@Ad", textBoxAd.Text);
            komut2.Parameters.AddWithValue("@Soyad", textBoxSoyad.Text);
            komut2.Parameters.AddWithValue("@Tc", textBoxTc.Text);
            komut2.Parameters.AddWithValue("@Email", textBoxEmail.Text);
            komut2.Parameters.AddWithValue("@Telefon", textBoxTelefon.Text);
            komut2.Parameters.AddWithValue("@Adres", textBoxAdres.Text);
            otel_otomasyonu.ekle_sil_güncelle(komut2, cumle);
            foreach (Control item in Controls) if (item is TextBox) item.Text = "";
        }
    }
}
