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
    public partial class frmRezervasyonOlusturma : Form
    {
        public frmRezervasyonOlusturma()
        {
            InitializeComponent();
        }
        Otel_Otomasyonu otel = new Otel_Otomasyonu();
        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void labelCikisTarihi_Click(object sender, EventArgs e)
        {

        }

        private void frmRezervasyonOlusturma_Load(object sender, EventArgs e)
        {
            Yenile();

        }

        private void Yenile()
        {
            string sorgu3 = "select * from RezervasyonO";
            SqlDataAdapter adtr2 = new SqlDataAdapter();
            dataGridView1.DataSource = otel.listele(adtr2, sorgu3);
        }

        private void textBoxTc_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxTcAra_TextChanged(object sender, EventArgs e)
        {
            foreach (Control item in groupBoxOdaBilgi.Controls) if (item.GetType() == typeof(System.Windows.Forms.TextBox)) item.Text = "";
            string sorgu2 = "select * from MusteriB where Tc like '" + textBoxTcAra.Text + "'";
            otel.Tc_Ara(textBoxTcAra, textBoxTc, textBoxAd, textBoxSoyad, textBoxTelefon, textBoxEmail, textBoxAdres, sorgu2);

        }

        private void comboBoxOdalar_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sorgu2 = "select * from OdaK where Odalar like '" + comboBoxOdalar.Text + "'";
            otel.CombodanGetir(comboBoxOdalar, comboBoxKat, textBoxOdaNo, textBoxBanyoSayisi, textBoxYatakSayisi, sorgu2);
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            TimeSpan gun = DateTime.Parse(dateCikisTarihi.Text) - DateTime.Parse(dateGirisTarihi.Text);
            int gun2 = gun.Days;
            textBoxGun.Text = gun2.ToString();
            textBoxTutar.Text = (gun2 * int.Parse(textBoxUcret.Text)).ToString();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void Temizle()
        {
            this.dateGirisTarihi.Value = DateTime.Now;
            this.dateCikisTarihi.Value = DateTime.Now;

            textBoxUcret.Text = "";
            textBoxGun.Text = "";
            textBoxTutar.Text = ";";
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            string sorgu2 = "insert into RezervasyonO(Ad, Soyad, Tc, Email, Telefon,  Adres, Odalar, Kat, OdaNo, BanyoSayisi, YatakSayisi, Ucret, Tutar,GirisTatihi, CikisTarihi) values(@Ad, @Soyad, @Tc, @Email, @Telefon,  @Adres, @Odalar, @Kat, @OdaNo, @BanyoSayisi, @YatakSayisi, @Ucret, @Tutar, @GirisTatihi, @CikisTarihi)";
            SqlCommand komut2 = new SqlCommand();

            komut2.Parameters.AddWithValue("@Ad", textBoxAd.Text);
            komut2.Parameters.AddWithValue("@Soyad", textBoxSoyad.Text);
            komut2.Parameters.AddWithValue("@Tc", textBoxTc.Text);
            komut2.Parameters.AddWithValue("@Email", textBoxEmail.Text);
            komut2.Parameters.AddWithValue("@Telefon", textBoxTelefon.Text);
            komut2.Parameters.AddWithValue("@Adres", textBoxAdres.Text);
            komut2.Parameters.AddWithValue("@Odalar", comboBoxOdalar.Text);
            komut2.Parameters.AddWithValue("@Kat", comboBoxKat.Text);
            komut2.Parameters.AddWithValue("@OdaNo", textBoxOdaNo.Text);
            komut2.Parameters.AddWithValue("@BanyoSayisi", textBoxBanyoSayisi.Text);
            komut2.Parameters.AddWithValue("@YatakSayisi", textBoxYatakSayisi.Text);
            komut2.Parameters.AddWithValue("@Ucret", int.Parse(textBoxUcret.Text));
            komut2.Parameters.AddWithValue("@Tutar", int.Parse(textBoxTutar.Text));
            komut2.Parameters.AddWithValue("@GirisTatihi", dateGirisTarihi.Text);
            komut2.Parameters.AddWithValue("@CikisTarihi", dateCikisTarihi.Text);
            otel.ekle_sil_güncelle(komut2, sorgu2);
            comboBoxOdalar.Items.Clear();
            Yenile();
            comboBoxOdalar.Text = "";
            Temizle();
            MessageBox.Show("Rezervasyon Yapıldı");
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            string sorgu2 = "update RezervasyonO set Ad=@Ad, Soyad=@Soyad, Tc=@Tc, Email=@Email, Telefon=@Telefon,  Adres=@Adres, Kat=@Kat, OdaNo=@OdaNo, BanyoSayisi=@BanyoSayisi, YatakSayisi=@YatakSayisi, Ucret=@Ucret, Tutar=@Tutar,GirisTatihi=@GirisTatihi, CikisTarihi=@CikisTarihi where Odalar=@Odalar";
            SqlCommand komut2 = new SqlCommand();

            komut2.Parameters.AddWithValue("@Ad", textBoxAd.Text);
            komut2.Parameters.AddWithValue("@Soyad", textBoxSoyad.Text);
            komut2.Parameters.AddWithValue("@Tc", textBoxTc.Text);
            komut2.Parameters.AddWithValue("@Email", textBoxEmail.Text);
            komut2.Parameters.AddWithValue("@Telefon", textBoxTelefon.Text);
            komut2.Parameters.AddWithValue("@Adres", textBoxAdres.Text);
            komut2.Parameters.AddWithValue("@Odalar", comboBoxOdalar.Text);
            komut2.Parameters.AddWithValue("@Kat", comboBoxKat.Text);
            komut2.Parameters.AddWithValue("@OdaNo", textBoxOdaNo.Text);
            komut2.Parameters.AddWithValue("@BanyoSayisi", textBoxBanyoSayisi.Text);
            komut2.Parameters.AddWithValue("@YatakSayisi", textBoxYatakSayisi.Text);
            komut2.Parameters.AddWithValue("@Ucret", int.Parse(textBoxUcret.Text));
            komut2.Parameters.AddWithValue("@Tutar", int.Parse(textBoxTutar.Text));
            komut2.Parameters.AddWithValue("@GirisTatihi", dateGirisTarihi.Text);
            komut2.Parameters.AddWithValue("@CikisTarihi", dateCikisTarihi.Text);
            otel.ekle_sil_güncelle(komut2, sorgu2);
            comboBoxOdalar.Items.Clear();
            Yenile();
            foreach (Control item in groupBox1.Controls) if (item.GetType() == typeof(System.Windows.Forms.TextBox)) item.Text = "";
            foreach (Control item in groupBoxOdaBilgi.Controls) if (item.GetType() == typeof(System.Windows.Forms.TextBox)) item.Text = "";
            comboBoxOdalar.Text = "";
            Temizle();
            MessageBox.Show("Güncelleme Yapıldı");
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow satır = dataGridView1.CurrentRow;
            textBoxTc.Text = satır.Cells[0].Value.ToString();
            textBoxAd.Text = satır.Cells[1].Value.ToString();
            textBoxSoyad.Text = satır.Cells[2].Value.ToString();
            textBoxTelefon.Text = satır.Cells[3].Value.ToString();
            textBoxEmail.Text = satır.Cells[4].Value.ToString();
            comboBoxOdalar.Text = satır.Cells[5].Value.ToString();
            textBoxAdres.Text = satır.Cells[6].Value.ToString();
            comboBoxKat.Text = satır.Cells[7].Value.ToString();
            textBoxOdaNo.Text = satır.Cells[8].Value.ToString();
            textBoxBanyoSayisi.Text = satır.Cells[9].Value.ToString();
            textBoxYatakSayisi.Text = satır.Cells[10].Value.ToString();
            textBoxGun.Text = satır.Cells[11].Value.ToString();
            textBoxUcret.Text = satır.Cells[12].Value.ToString();
            textBoxTutar.Text = satır.Cells[13].Value.ToString();
            dateCikisTarihi.Text = satır.Cells[14].ToString();
            dateGirisTarihi.Text = satır.Cells[15].Value.ToString();


        }
    }
}
