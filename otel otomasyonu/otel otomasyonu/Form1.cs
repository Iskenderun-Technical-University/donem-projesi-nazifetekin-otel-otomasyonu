namespace otel_otomasyonu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
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

        private void btnMusteriEkle_Click(object sender, EventArgs e)
        {
            frmMusteriEkle ekle = new frmMusteriEkle();
            ekle.ShowDialog();
        }

        private void btnMusteriListele_Click(object sender, EventArgs e)
        {
            frmMusteriListele listele = new frmMusteriListele();
            listele.ShowDialog();
        }

        private void btnOdaKayit_Click(object sender, EventArgs e)
        {
            frmOdaKayit Kayit = new frmOdaKayit();
            Kayit.ShowDialog();
        }

        private void btnOdaListele_Click(object sender, EventArgs e)
        {
            frmOdaListele listele = new frmOdaListele();
            listele.ShowDialog();
        }

        private void btnRezervasyon_Click(object sender, EventArgs e)
        {

            frmRezervasyonOlusturma olusturma = new frmRezervasyonOlusturma();
            olusturma.ShowDialog();
        }
    }
}