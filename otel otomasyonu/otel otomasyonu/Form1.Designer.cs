namespace otel_otomasyonu
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            button5 = new Button();
            btnMusteriEkle = new Button();
            btnOdaListele = new Button();
            btnOdaKayit = new Button();
            btnMusteriListele = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(button5);
            panel1.Controls.Add(btnMusteriEkle);
            panel1.Controls.Add(btnOdaListele);
            panel1.Controls.Add(btnOdaKayit);
            panel1.Controls.Add(btnMusteriListele);
            panel1.Location = new Point(74, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(658, 117);
            panel1.TabIndex = 0;
            // 
            // button5
            // 
            button5.Location = new Point(529, 20);
            button5.Name = "button5";
            button5.Size = new Size(112, 78);
            button5.TabIndex = 4;
            button5.Text = "Çıkış";
            button5.TextAlign = ContentAlignment.BottomCenter;
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // btnMusteriEkle
            // 
            btnMusteriEkle.Location = new Point(23, 20);
            btnMusteriEkle.Name = "btnMusteriEkle";
            btnMusteriEkle.Size = new Size(112, 78);
            btnMusteriEkle.TabIndex = 0;
            btnMusteriEkle.Text = "Müsteri Ekle";
            btnMusteriEkle.TextAlign = ContentAlignment.BottomCenter;
            btnMusteriEkle.UseVisualStyleBackColor = true;
            btnMusteriEkle.Click += btnMusteriEkle_Click;
            // 
            // btnOdaListele
            // 
            btnOdaListele.Location = new Point(411, 20);
            btnOdaListele.Name = "btnOdaListele";
            btnOdaListele.Size = new Size(112, 78);
            btnOdaListele.TabIndex = 3;
            btnOdaListele.Text = "Oda Listele";
            btnOdaListele.TextAlign = ContentAlignment.BottomCenter;
            btnOdaListele.UseVisualStyleBackColor = true;
            // 
            // btnOdaKayit
            // 
            btnOdaKayit.Location = new Point(278, 20);
            btnOdaKayit.Name = "btnOdaKayit";
            btnOdaKayit.Size = new Size(112, 78);
            btnOdaKayit.TabIndex = 2;
            btnOdaKayit.Text = "Oda Kayit";
            btnOdaKayit.TextAlign = ContentAlignment.BottomCenter;
            btnOdaKayit.UseVisualStyleBackColor = true;
            // 
            // btnMusteriListele
            // 
            btnMusteriListele.Location = new Point(150, 20);
            btnMusteriListele.Name = "btnMusteriListele";
            btnMusteriListele.Size = new Size(112, 78);
            btnMusteriListele.TabIndex = 1;
            btnMusteriListele.Text = "Müsteri Listele";
            btnMusteriListele.TextAlign = ContentAlignment.BottomCenter;
            btnMusteriListele.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.mirage_park_resort_plaj_ve_havuz_3bab2e97_9ebb_4550_bb74_5f1d254b4682;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button5;
        private Button btnMusteriEkle;
        private Button btnOdaListele;
        private Button btnOdaKayit;
        private Button btnMusteriListele;
    }
}