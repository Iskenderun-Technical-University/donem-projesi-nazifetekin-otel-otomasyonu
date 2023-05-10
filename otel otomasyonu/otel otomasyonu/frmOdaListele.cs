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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace otel_otomasyonu
{
    public partial class frmOdaListele : Form
    {
        Otel_Otomasyonu otel_otomasyonu = new Otel_Otomasyonu();
        public frmOdaListele()
        {
            InitializeComponent();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {

            DataGridViewRow satir = dataGridView1.CurrentRow;
            if (satir != null)
            {
                string cumle = "delete from OdaK where Kat='" + satir.Cells["Kat"].Value.ToString() + "'";
                SqlCommand komut2 = new SqlCommand();
                otel_otomasyonu.ekle_sil_güncelle(komut2, cumle);
                foreach (Control item in Controls) if (item is System.Windows.Forms.TextBox) item.Text = "";
                YenileOdaListele();
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow satir = dataGridView1.CurrentRow;
            comboBoxOdalar.Text = satir.Cells["Odalar"].Value.ToString();
            comboBoxKat.Text = satir.Cells["Kat"].Value.ToString();
            textBoxOdaNo.Text = satir.Cells["OdaNo"].Value.ToString();
            textBoxBanyoSayisi.Text = satir.Cells["BanyoSayisi"].Value.ToString();
            textBoxYatakSayisi.Text = satir.Cells["YatakSayisi"].Value.ToString();
            textBoxUcret.Text = satir.Cells["Ucret"].Value.ToString();
        }

        private void frmOdaListele_Load(object sender, EventArgs e)
        {
            YenileOdaListele();
        }

        private void YenileOdaListele()
        {
            string cumle = "select * from OdaK";
            SqlDataAdapter adtr2 = new SqlDataAdapter();
            dataGridView1.DataSource = otel_otomasyonu.listele(adtr2, cumle);
        }

        private void btnFotografEkle_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pictureBox1.ImageLocation = openFileDialog1.FileName;
        }

        private void btnKayit_Click(object sender, EventArgs e)
        {
            string cumle = "update OdaK set Odalar=@Odalar,Kat=@Kat,OdaNo=@OdaNo,BanyoSayisi=@BanyoSayisi,YatakSayisi=@YatakSayisi,Ucret=@Ucret,Fotograf=@Fotograf";
            SqlCommand komut2 = new SqlCommand();
            komut2.Parameters.AddWithValue("@Odalar", comboBoxOdalar.Text);
            komut2.Parameters.AddWithValue("@Kat", comboBoxKat.Text);
            komut2.Parameters.AddWithValue("@OdaNo", textBoxOdaNo.Text);
            komut2.Parameters.AddWithValue("@BanyoSayisi", textBoxBanyoSayisi.Text);
            komut2.Parameters.AddWithValue("@YatakSayisi", textBoxYatakSayisi.Text);
            komut2.Parameters.AddWithValue("@Ucret", int.Parse(textBoxUcret.Text));
            komut2.Parameters.AddWithValue("@Fotograf", pictureBox1.ImageLocation);
            otel_otomasyonu.ekle_sil_güncelle(komut2, cumle);
            comboBoxOdalar.Items.Clear();
            foreach (Control item in Controls) if (item is System.Windows.Forms.TextBox) item.Text = "";
            foreach (Control item in Controls) if (item is System.Windows.Forms.ComboBox) item.Text = "";
            YenileOdaListele();
            pictureBox1.Image = null;
            pictureBox1.Invalidate();
            comboBoxOdalar.Items.Clear();
            foreach (Control item in Controls) if (item is System.Windows.Forms.TextBox) item.Text = "";
            foreach (Control item in Controls) if (item is System.Windows.Forms.ComboBox) item.Text = "";
        }

        private void btnİptal_Click(object sender, EventArgs e)
        {

        }
    }
}


