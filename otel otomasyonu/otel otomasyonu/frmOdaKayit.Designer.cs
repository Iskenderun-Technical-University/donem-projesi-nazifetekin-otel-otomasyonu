namespace otel_otomasyonu
{
    partial class frmOdaKayit
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            textBoxOdaNo = new TextBox();
            textBoxBanyoSayisi = new TextBox();
            textBoxYatakSayisi = new TextBox();
            textBoxUcret = new TextBox();
            comboBoxOdalar = new ComboBox();
            comboBoxKat = new ComboBox();
            pictureBox1 = new PictureBox();
            btnKayit = new Button();
            btnİptal = new Button();
            btnFotografEkle = new Button();
            openFileDialog1 = new OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(104, 77);
            label1.Name = "label1";
            label1.Size = new Size(57, 20);
            label1.TabIndex = 0;
            label1.Text = "Odalar:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(127, 114);
            label2.Name = "label2";
            label2.Size = new Size(34, 20);
            label2.TabIndex = 1;
            label2.Text = "Kat:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(97, 149);
            label3.Name = "label3";
            label3.Size = new Size(64, 20);
            label3.TabIndex = 2;
            label3.Text = "Oda No:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(67, 185);
            label4.Name = "label4";
            label4.Size = new Size(94, 20);
            label4.TabIndex = 3;
            label4.Text = "Banyo Sayisi:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(73, 217);
            label5.Name = "label5";
            label5.Size = new Size(88, 20);
            label5.TabIndex = 4;
            label5.Text = "Yatak Sayisi:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(114, 251);
            label6.Name = "label6";
            label6.Size = new Size(47, 20);
            label6.TabIndex = 5;
            label6.Text = "Ücret:";
            // 
            // textBoxOdaNo
            // 
            textBoxOdaNo.Location = new Point(191, 149);
            textBoxOdaNo.Name = "textBoxOdaNo";
            textBoxOdaNo.Size = new Size(151, 27);
            textBoxOdaNo.TabIndex = 6;
            // 
            // textBoxBanyoSayisi
            // 
            textBoxBanyoSayisi.Location = new Point(191, 182);
            textBoxBanyoSayisi.Name = "textBoxBanyoSayisi";
            textBoxBanyoSayisi.Size = new Size(151, 27);
            textBoxBanyoSayisi.TabIndex = 7;
            // 
            // textBoxYatakSayisi
            // 
            textBoxYatakSayisi.Location = new Point(191, 218);
            textBoxYatakSayisi.Name = "textBoxYatakSayisi";
            textBoxYatakSayisi.Size = new Size(151, 27);
            textBoxYatakSayisi.TabIndex = 8;
            // 
            // textBoxUcret
            // 
            textBoxUcret.Location = new Point(191, 251);
            textBoxUcret.Name = "textBoxUcret";
            textBoxUcret.Size = new Size(151, 27);
            textBoxUcret.TabIndex = 9;
            // 
            // comboBoxOdalar
            // 
            comboBoxOdalar.FormattingEnabled = true;
            comboBoxOdalar.Items.AddRange(new object[] { "Tek kişilik ", "Çift kişilik ", "Üç kişilik ", "Dört kişilik ", "Aile odası" });
            comboBoxOdalar.Location = new Point(191, 77);
            comboBoxOdalar.Name = "comboBoxOdalar";
            comboBoxOdalar.Size = new Size(151, 28);
            comboBoxOdalar.TabIndex = 10;
            // 
            // comboBoxKat
            // 
            comboBoxKat.FormattingEnabled = true;
            comboBoxKat.Items.AddRange(new object[] { "1.", "2.", "3.", "4." });
            comboBoxKat.Location = new Point(191, 115);
            comboBoxKat.Name = "comboBoxKat";
            comboBoxKat.Size = new Size(151, 28);
            comboBoxKat.TabIndex = 11;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(409, 77);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(333, 206);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // btnKayit
            // 
            btnKayit.Location = new Point(221, 312);
            btnKayit.Name = "btnKayit";
            btnKayit.Size = new Size(105, 53);
            btnKayit.TabIndex = 13;
            btnKayit.Text = "Kayıt";
            btnKayit.UseVisualStyleBackColor = true;
            btnKayit.Click += btnKayit_Click;
            // 
            // btnİptal
            // 
            btnİptal.Location = new Point(346, 312);
            btnİptal.Name = "btnİptal";
            btnİptal.Size = new Size(105, 53);
            btnİptal.TabIndex = 14;
            btnİptal.Text = "İptal";
            btnİptal.UseVisualStyleBackColor = true;
            btnİptal.Click += btnİptal_Click;
            // 
            // btnFotografEkle
            // 
            btnFotografEkle.Location = new Point(469, 312);
            btnFotografEkle.Name = "btnFotografEkle";
            btnFotografEkle.Size = new Size(105, 53);
            btnFotografEkle.TabIndex = 15;
            btnFotografEkle.Text = "Fotoğraf Ekle";
            btnFotografEkle.UseVisualStyleBackColor = true;
            btnFotografEkle.Click += btnFotografEkle_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // frmOdaKayit
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.mirage_park_resort_genel_3af754be_e7f8_4ccc_aa87_d9890f425721;
            ClientSize = new Size(800, 450);
            Controls.Add(btnFotografEkle);
            Controls.Add(btnİptal);
            Controls.Add(btnKayit);
            Controls.Add(pictureBox1);
            Controls.Add(comboBoxKat);
            Controls.Add(comboBoxOdalar);
            Controls.Add(textBoxUcret);
            Controls.Add(textBoxYatakSayisi);
            Controls.Add(textBoxBanyoSayisi);
            Controls.Add(textBoxOdaNo);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmOdaKayit";
            Text = "frmOdaKayit";
            Load += frmOdaKayit_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox textBoxOdaNo;
        private TextBox textBoxBanyoSayisi;
        private TextBox textBoxYatakSayisi;
        private TextBox textBoxUcret;
        private ComboBox comboBoxOdalar;
        private ComboBox comboBoxKat;
        private PictureBox pictureBox1;
        private Button btnKayit;
        private Button btnİptal;
        private Button btnFotografEkle;
        private OpenFileDialog openFileDialog1;
    }
}