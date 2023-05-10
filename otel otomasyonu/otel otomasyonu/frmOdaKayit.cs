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
using TextBox = System.Windows.Forms.TextBox;

namespace otel_otomasyonu
{
    public partial class frmOdaKayit : Form
    {
        Otel_Otomasyonu otel_otomasyonu = new Otel_Otomasyonu();
        public frmOdaKayit()
        {
            InitializeComponent();
        }

        private void btnFotografEkle_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pictureBox1.ImageLocation = openFileDialog1.FileName;
        }

        private void btnİptal_Click(object sender, EventArgs e)
        {
            DialogResult result1 = MessageBox.Show("Cikmak istdiginize emin miziniz?", "", MessageBoxButtons.YesNo);
            if (result1 == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {

            }
        }

        private void btnKayit_Click(object sender, EventArgs e)
        {
            string cumle = "insert into OdaK(Odalar,Kat,OdaNo,BanyoSayisi,YatakSayisi,Ucret,Fotograf) values(@Odalar,@Kat,@OdaNo,@BanyoSayisi,@YatakSayisi,@Ucret,@Fotograf)";
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
            foreach (Control item in Controls) if (item is TextBox) item.Text = "";
            foreach (Control item in Controls) if (item is System.Windows.Forms.ComboBox) item.Text = "";
            pictureBox1.Image = null;
            pictureBox1.Invalidate();
        }

        private void frmOdaKayit_Load(object sender, EventArgs e)
        {

        }
    }
}
