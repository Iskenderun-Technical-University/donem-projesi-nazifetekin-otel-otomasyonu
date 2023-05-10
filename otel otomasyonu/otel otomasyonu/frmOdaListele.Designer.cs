namespace otel_otomasyonu
{
    partial class frmOdaListele
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOdaListele));
            btnFotografEkle = new Button();
            btnİptal = new Button();
            btnKayit = new Button();
            pictureBox1 = new PictureBox();
            comboBoxKat = new ComboBox();
            comboBoxOdalar = new ComboBox();
            textBoxUcret = new TextBox();
            textBoxYatakSayisi = new TextBox();
            textBoxBanyoSayisi = new TextBox();
            textBoxOdaNo = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            btnSil = new Button();
            openFileDialog1 = new OpenFileDialog();
            ımageList1 = new ImageList(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnFotografEkle
            // 
            btnFotografEkle.ImageAlign = ContentAlignment.MiddleLeft;
            btnFotografEkle.ImageIndex = 0;
            btnFotografEkle.ImageList = ımageList1;
            btnFotografEkle.Location = new Point(520, 241);
            btnFotografEkle.Name = "btnFotografEkle";
            btnFotografEkle.Size = new Size(145, 52);
            btnFotografEkle.TabIndex = 31;
            btnFotografEkle.Text = "Fotoğraf Ekle";
            btnFotografEkle.TextAlign = ContentAlignment.MiddleRight;
            btnFotografEkle.UseVisualStyleBackColor = true;
            btnFotografEkle.Click += btnFotografEkle_Click;
            // 
            // btnİptal
            // 
            btnİptal.ImageAlign = ContentAlignment.MiddleLeft;
            btnİptal.ImageIndex = 2;
            btnİptal.ImageList = ımageList1;
            btnİptal.Location = new Point(397, 241);
            btnİptal.Name = "btnİptal";
            btnİptal.Size = new Size(105, 52);
            btnİptal.TabIndex = 30;
            btnİptal.Text = "İptal";
            btnİptal.TextAlign = ContentAlignment.MiddleRight;
            btnİptal.UseVisualStyleBackColor = true;
            btnİptal.Click += btnİptal_Click;
            // 
            // btnKayit
            // 
            btnKayit.ImageAlign = ContentAlignment.MiddleLeft;
            btnKayit.ImageIndex = 10;
            btnKayit.ImageList = ımageList1;
            btnKayit.Location = new Point(272, 241);
            btnKayit.Name = "btnKayit";
            btnKayit.Size = new Size(105, 52);
            btnKayit.TabIndex = 29;
            btnKayit.Text = "Güncelle";
            btnKayit.TextAlign = ContentAlignment.MiddleRight;
            btnKayit.UseVisualStyleBackColor = true;
            btnKayit.Click += btnKayit_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(392, 29);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(333, 206);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 28;
            pictureBox1.TabStop = false;
            // 
            // comboBoxKat
            // 
            comboBoxKat.FormattingEnabled = true;
            comboBoxKat.Items.AddRange(new object[] { "1.", "2.", "3.", "4." });
            comboBoxKat.Location = new Point(174, 67);
            comboBoxKat.Name = "comboBoxKat";
            comboBoxKat.Size = new Size(151, 28);
            comboBoxKat.TabIndex = 27;
            // 
            // comboBoxOdalar
            // 
            comboBoxOdalar.FormattingEnabled = true;
            comboBoxOdalar.Items.AddRange(new object[] { "Tek kişilik ", "Çift kişilik ", "Üç kişilik ", "Dört kişilik ", "Aile odası" });
            comboBoxOdalar.Location = new Point(174, 29);
            comboBoxOdalar.Name = "comboBoxOdalar";
            comboBoxOdalar.Size = new Size(151, 28);
            comboBoxOdalar.TabIndex = 26;
            // 
            // textBoxUcret
            // 
            textBoxUcret.Location = new Point(174, 203);
            textBoxUcret.Name = "textBoxUcret";
            textBoxUcret.Size = new Size(151, 27);
            textBoxUcret.TabIndex = 25;
            // 
            // textBoxYatakSayisi
            // 
            textBoxYatakSayisi.Location = new Point(174, 170);
            textBoxYatakSayisi.Name = "textBoxYatakSayisi";
            textBoxYatakSayisi.Size = new Size(151, 27);
            textBoxYatakSayisi.TabIndex = 24;
            // 
            // textBoxBanyoSayisi
            // 
            textBoxBanyoSayisi.Location = new Point(174, 134);
            textBoxBanyoSayisi.Name = "textBoxBanyoSayisi";
            textBoxBanyoSayisi.Size = new Size(151, 27);
            textBoxBanyoSayisi.TabIndex = 23;
            // 
            // textBoxOdaNo
            // 
            textBoxOdaNo.Location = new Point(174, 101);
            textBoxOdaNo.Name = "textBoxOdaNo";
            textBoxOdaNo.Size = new Size(151, 27);
            textBoxOdaNo.TabIndex = 22;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(97, 203);
            label6.Name = "label6";
            label6.Size = new Size(47, 20);
            label6.TabIndex = 21;
            label6.Text = "Ücret:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(56, 169);
            label5.Name = "label5";
            label5.Size = new Size(88, 20);
            label5.TabIndex = 20;
            label5.Text = "Yatak Sayisi:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(50, 137);
            label4.Name = "label4";
            label4.Size = new Size(94, 20);
            label4.TabIndex = 19;
            label4.Text = "Banyo Sayisi:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(80, 101);
            label3.Name = "label3";
            label3.Size = new Size(64, 20);
            label3.TabIndex = 18;
            label3.Text = "Oda No:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(110, 66);
            label2.Name = "label2";
            label2.Size = new Size(34, 20);
            label2.TabIndex = 17;
            label2.Text = "Kat:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(87, 29);
            label1.Name = "label1";
            label1.Size = new Size(57, 20);
            label1.TabIndex = 16;
            label1.Text = "Odalar:";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(50, 312);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(675, 115);
            dataGridView1.TabIndex = 32;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
            // 
            // btnSil
            // 
            btnSil.ImageAlign = ContentAlignment.MiddleLeft;
            btnSil.ImageIndex = 5;
            btnSil.ImageList = ımageList1;
            btnSil.Location = new Point(148, 241);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(105, 52);
            btnSil.TabIndex = 33;
            btnSil.Text = "Sil";
            btnSil.TextAlign = ContentAlignment.MiddleRight;
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // ımageList1
            // 
            ımageList1.ColorDepth = ColorDepth.Depth32Bit;
            ımageList1.ImageStream = (ImageListStreamer)resources.GetObject("ımageList1.ImageStream");
            ımageList1.TransparentColor = Color.Transparent;
            ımageList1.Images.SetKeyName(0, "png-transparent-new-folder-add-create-files-and-folders-icon-thumbnail.png");
            ımageList1.Images.SetKeyName(1, "New_user_icon-01.svg.png");
            ımageList1.Images.SetKeyName(2, "png-transparent-incorrect-delete-remove-cancel-red-sign-symbol-cross-wrong.png");
            ımageList1.Images.SetKeyName(3, "png-clipart-office-supplies-computer-icons-iconfinder-calculation-calculator-icon-text-rectangle.png");
            ımageList1.Images.SetKeyName(4, "png-transparent-material-icon-plus-icon-add-symbol-material-flat.png");
            ımageList1.Images.SetKeyName(5, "kisspng-waste-container-recycling-icon-trash-can-5a6b59b7ccaa89.9639306415169847598383.jpg");
            ımageList1.Images.SetKeyName(6, "çiftkişi.jpg");
            ımageList1.Images.SetKeyName(7, "kaya-palazzo-golf.jpeg");
            ımageList1.Images.SetKeyName(8, "kisspng-bedroom-computer-icons-living-room-icons-download-bedroom-png-5ab0bfa766d277.5562319615215328394212.jpg");
            ımageList1.Images.SetKeyName(9, "png-clipart-calculator-maths-computer-icons-calculation-calculator-electronics-logo.png");
            ımageList1.Images.SetKeyName(10, "png-clipart-computer-icons-computer-software-free-software-upgrade-computer-program-others-text-logo.png");
            ımageList1.Images.SetKeyName(11, "18-titanic-business-kartal-superior-room_standard.jpg");
            // 
            // frmOdaListele
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.mirage_park_resort_genel_9939c935_967d_4c59_8495_0c60f4715333;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSil);
            Controls.Add(dataGridView1);
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
            Name = "frmOdaListele";
            Text = "frmAracListele";
            Load += frmOdaListele_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnFotografEkle;
        private Button btnİptal;
        private Button btnKayit;
        private PictureBox pictureBox1;
        private ComboBox comboBoxKat;
        private ComboBox comboBoxOdalar;
        private TextBox textBoxUcret;
        private TextBox textBoxYatakSayisi;
        private TextBox textBoxBanyoSayisi;
        private TextBox textBoxOdaNo;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private DataGridView dataGridView1;
        private Button btnSil;
        private OpenFileDialog openFileDialog1;
        private ImageList ımageList1;
    }
}