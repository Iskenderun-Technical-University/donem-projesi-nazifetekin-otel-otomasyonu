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
    public partial class frmMusteriListele : Form
    {
        Otel_Otomasyonu otel_otomasyonu = new Otel_Otomasyonu();
        public frmMusteriListele()
        {
            InitializeComponent();
        }

        private void frmMusteriListele_Load(object sender, EventArgs e)
        {
            Yenilelistele();
        }

        private void Yenilelistele()
        {
            string cümle = "select * from MusteriB";
            SqlDataAdapter adtr2 = new SqlDataAdapter();
            dataGridView1.DataSource = otel_otomasyonu.listele(adtr2, cümle);
            dataGridView1.Columns[0].HeaderText = "AD";
            dataGridView1.Columns[1].HeaderText = "SOYAD";
            dataGridView1.Columns[3].HeaderText = "TC";
            dataGridView1.Columns[4].HeaderText = "ADRES";
            dataGridView1.Columns[5].HeaderText = "TELEFON";
            dataGridView1.Columns[6].HeaderText = "EMAİL";
           
        }

        private void btnİptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow satır = dataGridView1.CurrentRow;
            textBoxAd.Text = satır.Cells[0].Value.ToString();
            textBoxSoyad.Text = satır.Cells[1].Value.ToString();
            textBoxTc.Text = satır.Cells[2].Value.ToString();
            textBoxAdres.Text = satır.Cells[3].Value.ToString();
            textBoxTelefon.Text = satır.Cells[4].Value.ToString();
            textBoxEmail.Text = satır.Cells[5].Value.ToString();

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            string cümle = "update MusteriB set Ad=@Ad,Soyad=@Soyad,Adres=@Adres,Telefon=@Telefon,Mail=@Mail, where TC=@TC";
            SqlCommand komut2 = new SqlCommand();
            komut2.Parameters.AddWithValue("@Ad", textBoxAd.Text);
            komut2.Parameters.AddWithValue("@Soyad", textBoxSoyad.Text);
            komut2.Parameters.AddWithValue("@Tc", textBoxTc.Text);
            komut2.Parameters.AddWithValue("@Adres", textBoxAdres.Text);
            komut2.Parameters.AddWithValue("@Telefon", textBoxTelefon.Text);
            komut2.Parameters.AddWithValue("@Email", textBoxEmail.Text);
            otel_otomasyonu.ekle_sil_güncelle(komut2, cümle);
            foreach (Control item in Controls) if (item is TextBox) item.Text = "";
            Yenilelistele();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string cümle = "select * from MusteriB where tc like'%\"+textBox1.Text+\"%'\";";
            SqlDataAdapter adtr2 = new SqlDataAdapter();
            dataGridView1.DataSource = otel_otomasyonu.listele(adtr2, cümle);
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            DataGridViewRow satır = dataGridView1.CurrentRow;
            string cumle = "delete from MusterB where Tc='" + satır.Cells["Tc"].Value.ToString() + "'";
            SqlCommand komut2 = new SqlCommand();
            otel_otomasyonu.ekle_sil_güncelle(komut2, cumle);
            foreach (Control item in Controls) if (item is TextBox) item.Text = "";
            Yenilelistele();
        }
    }
}
