namespace otel_otomasyonu
{
    partial class frmMusteriEkle
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
            textBoxAd = new TextBox();
            textBoxSoyad = new TextBox();
            textBoxTc = new TextBox();
            textBoxEmail = new TextBox();
            textBoxTelefon = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            textBoxAdres = new TextBox();
            btnEkle = new Button();
            btnİptal = new Button();
            SuspendLayout();
            // 
            // textBoxAd
            // 
            textBoxAd.Location = new Point(172, 85);
            textBoxAd.Name = "textBoxAd";
            textBoxAd.Size = new Size(144, 27);
            textBoxAd.TabIndex = 0;
            // 
            // textBoxSoyad
            // 
            textBoxSoyad.Location = new Point(172, 130);
            textBoxSoyad.Name = "textBoxSoyad";
            textBoxSoyad.Size = new Size(144, 27);
            textBoxSoyad.TabIndex = 1;
            // 
            // textBoxTc
            // 
            textBoxTc.Location = new Point(172, 170);
            textBoxTc.Name = "textBoxTc";
            textBoxTc.Size = new Size(144, 27);
            textBoxTc.TabIndex = 2;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(172, 218);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(144, 27);
            textBoxEmail.TabIndex = 3;
            // 
            // textBoxTelefon
            // 
            textBoxTelefon.Location = new Point(172, 262);
            textBoxTelefon.Name = "textBoxTelefon";
            textBoxTelefon.Size = new Size(144, 27);
            textBoxTelefon.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(115, 89);
            label1.Name = "label1";
            label1.Size = new Size(31, 20);
            label1.TabIndex = 5;
            label1.Text = "Ad:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(93, 137);
            label2.Name = "label2";
            label2.Size = new Size(53, 20);
            label2.TabIndex = 6;
            label2.Text = "Soyad:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(120, 181);
            label3.Name = "label3";
            label3.Size = new Size(26, 20);
            label3.TabIndex = 7;
            label3.Text = "Tc:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(100, 229);
            label4.Name = "label4";
            label4.Size = new Size(46, 20);
            label4.TabIndex = 8;
            label4.Text = "Email";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(85, 269);
            label5.Name = "label5";
            label5.Size = new Size(61, 20);
            label5.TabIndex = 9;
            label5.Text = "Telefon:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(96, 321);
            label6.Name = "label6";
            label6.Size = new Size(50, 20);
            label6.TabIndex = 11;
            label6.Text = "Adres:";
            // 
            // textBoxAdres
            // 
            textBoxAdres.Location = new Point(172, 314);
            textBoxAdres.Name = "textBoxAdres";
            textBoxAdres.Size = new Size(144, 27);
            textBoxAdres.TabIndex = 10;
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(106, 367);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(94, 50);
            btnEkle.TabIndex = 12;
            btnEkle.Text = "Kayit";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // btnİptal
            // 
            btnİptal.Location = new Point(222, 367);
            btnİptal.Name = "btnİptal";
            btnİptal.Size = new Size(94, 50);
            btnİptal.TabIndex = 13;
            btnİptal.Text = "İptal";
            btnİptal.UseVisualStyleBackColor = true;
            btnİptal.Click += btnİptal_Click;
            // 
            // frmMusteriEkle
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.mirage_park_resort_genel_9939c935_967d_4c59_8495_0c60f4715333;
            ClientSize = new Size(490, 450);
            Controls.Add(btnİptal);
            Controls.Add(btnEkle);
            Controls.Add(label6);
            Controls.Add(textBoxAdres);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxTelefon);
            Controls.Add(textBoxEmail);
            Controls.Add(textBoxTc);
            Controls.Add(textBoxSoyad);
            Controls.Add(textBoxAd);
            Name = "frmMusteriEkle";
            Text = "frmMusteriEkle";
            Load += frmMusteriEkle_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxAd;
        private TextBox textBoxSoyad;
        private TextBox textBoxTc;
        private TextBox textBoxEmail;
        private TextBox textBoxTelefon;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox textBoxAdres;
        private Button btnEkle;
        private Button btnİptal;
    }
}