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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            btnRezervasyon = new Button();
            button5 = new Button();
            btnMusteriEkle = new Button();
            btnOdaListele = new Button();
            btnOdaKayit = new Button();
            btnMusteriListele = new Button();
            ımageList1 = new ImageList(components);
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnRezervasyon);
            panel1.Controls.Add(button5);
            panel1.Controls.Add(btnMusteriEkle);
            panel1.Controls.Add(btnOdaListele);
            panel1.Controls.Add(btnOdaKayit);
            panel1.Controls.Add(btnMusteriListele);
            panel1.Location = new Point(250, 113);
            panel1.Name = "panel1";
            panel1.Size = new Size(285, 325);
            panel1.TabIndex = 0;
            // 
            // btnRezervasyon
            // 
            btnRezervasyon.Font = new Font("Nirmala UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnRezervasyon.ImageAlign = ContentAlignment.TopCenter;
            btnRezervasyon.ImageIndex = 7;
            btnRezervasyon.ImageList = ımageList1;
            btnRezervasyon.Location = new Point(23, 217);
            btnRezervasyon.Name = "btnRezervasyon";
            btnRezervasyon.Size = new Size(112, 80);
            btnRezervasyon.TabIndex = 5;
            btnRezervasyon.Text = "Rezervasyon";
            btnRezervasyon.TextAlign = ContentAlignment.BottomCenter;
            btnRezervasyon.UseVisualStyleBackColor = true;
            btnRezervasyon.Click += btnRezervasyon_Click;
            // 
            // button5
            // 
            button5.Font = new Font("Nirmala UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button5.ImageAlign = ContentAlignment.TopCenter;
            button5.ImageIndex = 4;
            button5.ImageList = ımageList1;
            button5.Location = new Point(150, 217);
            button5.Name = "button5";
            button5.Size = new Size(112, 80);
            button5.TabIndex = 4;
            button5.Text = "Çıkış";
            button5.TextAlign = ContentAlignment.BottomCenter;
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // btnMusteriEkle
            // 
            btnMusteriEkle.Font = new Font("Nirmala UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnMusteriEkle.ImageAlign = ContentAlignment.TopCenter;
            btnMusteriEkle.ImageIndex = 3;
            btnMusteriEkle.ImageList = ımageList1;
            btnMusteriEkle.Location = new Point(23, 16);
            btnMusteriEkle.Name = "btnMusteriEkle";
            btnMusteriEkle.Size = new Size(112, 84);
            btnMusteriEkle.TabIndex = 0;
            btnMusteriEkle.Text = "Müsteri Ekle";
            btnMusteriEkle.TextAlign = ContentAlignment.BottomCenter;
            btnMusteriEkle.UseVisualStyleBackColor = true;
            btnMusteriEkle.Click += btnMusteriEkle_Click;
            // 
            // btnOdaListele
            // 
            btnOdaListele.Font = new Font("Nirmala UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnOdaListele.ImageAlign = ContentAlignment.TopCenter;
            btnOdaListele.ImageIndex = 6;
            btnOdaListele.ImageList = ımageList1;
            btnOdaListele.Location = new Point(150, 116);
            btnOdaListele.Name = "btnOdaListele";
            btnOdaListele.Size = new Size(112, 84);
            btnOdaListele.TabIndex = 3;
            btnOdaListele.Text = "Oda Listele";
            btnOdaListele.TextAlign = ContentAlignment.BottomCenter;
            btnOdaListele.UseVisualStyleBackColor = true;
            btnOdaListele.Click += btnOdaListele_Click;
            // 
            // btnOdaKayit
            // 
            btnOdaKayit.Font = new Font("Nirmala UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnOdaKayit.ImageAlign = ContentAlignment.TopCenter;
            btnOdaKayit.ImageIndex = 5;
            btnOdaKayit.ImageList = ımageList1;
            btnOdaKayit.Location = new Point(23, 116);
            btnOdaKayit.Name = "btnOdaKayit";
            btnOdaKayit.Size = new Size(112, 84);
            btnOdaKayit.TabIndex = 2;
            btnOdaKayit.Text = "Oda Kayit";
            btnOdaKayit.TextAlign = ContentAlignment.BottomCenter;
            btnOdaKayit.UseVisualStyleBackColor = true;
            btnOdaKayit.Click += btnOdaKayit_Click;
            // 
            // btnMusteriListele
            // 
            btnMusteriListele.Font = new Font("Nirmala UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnMusteriListele.ImageAlign = ContentAlignment.TopCenter;
            btnMusteriListele.ImageIndex = 0;
            btnMusteriListele.ImageList = ımageList1;
            btnMusteriListele.Location = new Point(150, 16);
            btnMusteriListele.Name = "btnMusteriListele";
            btnMusteriListele.Size = new Size(112, 84);
            btnMusteriListele.TabIndex = 1;
            btnMusteriListele.Text = "Müsteri Listele";
            btnMusteriListele.TextAlign = ContentAlignment.BottomCenter;
            btnMusteriListele.UseVisualStyleBackColor = true;
            btnMusteriListele.Click += btnMusteriListele_Click;
            // 
            // ımageList1
            // 
            ımageList1.ColorDepth = ColorDepth.Depth32Bit;
            ımageList1.ImageStream = (ImageListStreamer)resources.GetObject("ımageList1.ImageStream");
            ımageList1.TransparentColor = Color.Transparent;
            ımageList1.Images.SetKeyName(0, "istockphoto-842425106-170667a.jpg");
            ımageList1.Images.SetKeyName(1, "kisspng-computer-icons-business-organization-management-list-5ac110b76f1f00.1806414815226021674552.jpg");
            ımageList1.Images.SetKeyName(2, "png-transparent-can-graphy-listing-miscellaneous-text-rectangle-thumbnail.png");
            ımageList1.Images.SetKeyName(3, "png-transparent-computer-icons-user-ios-7-add-user-share-icon-add-user-symbol-thumbnail.png");
            ımageList1.Images.SetKeyName(4, "png-transparent-exit-sign-emergency-exit-computer-icons-graphy-others-text-photography-trademark.png");
            ımageList1.Images.SetKeyName(5, "yatak-odasi-icon.png");
            ımageList1.Images.SetKeyName(6, "png-transparent-checklist-list-plan-stackfolder-strategy-todo-simpline-mix-icon.png");
            ımageList1.Images.SetKeyName(7, "png-transparent-computer-icons-computer-software-reservation-text-rectangle-logo.png");
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 36F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(207, 9);
            label1.Name = "label1";
            label1.Size = new Size(368, 81);
            label1.TabIndex = 1;
            label1.Text = "TEKİN OTEL";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.mirage_park_resort_plaj_ve_havuz_3bab2e97_9ebb_4550_bb74_5f1d254b4682;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button button5;
        private Button btnMusteriEkle;
        private Button btnOdaListele;
        private Button btnOdaKayit;
        private Button btnMusteriListele;
        private Button btnRezervasyon;
        private ImageList ımageList1;
        private Label label1;
    }
}