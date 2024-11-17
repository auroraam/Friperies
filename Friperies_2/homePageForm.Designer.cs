namespace Friperies_2
{
    partial class homePageForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(homePageForm));
            panel3 = new Panel();
            panel1 = new Panel();
            btnExit = new Button();
            panel2 = new Panel();
            label2 = new Label();
            label1 = new Label();
            lblOfferpage = new Label();
            pictureBox1 = new PictureBox();
            btnLihatProduk = new Button();
            btnProfil = new Button();
            btnUnggahProduk = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.BackgroundImage = Properties.Resources.Screenshot_2024_10_20_at_17_40_01_removebg_preview__1_;
            panel3.Location = new Point(10, 10);
            panel3.Margin = new Padding(2);
            panel3.Name = "panel3";
            panel3.Size = new Size(202, 52);
            panel3.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(btnExit);
            panel1.Controls.Add(panel3);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1000, 74);
            panel1.TabIndex = 1;
            // 
            // btnExit
            // 
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnExit.Image = Properties.Resources.cancel_5697779__1_;
            btnExit.Location = new Point(932, 8);
            btnExit.Margin = new Padding(2);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(55, 55);
            btnExit.TabIndex = 8;
            btnExit.Text = " ";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(192, 192, 255);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(lblOfferpage);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(btnLihatProduk);
            panel2.Controls.Add(btnProfil);
            panel2.Controls.Add(btnUnggahProduk);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new Size(1000, 700);
            panel2.TabIndex = 2;
            // 
            // label2
            // 
            label2.Location = new Point(511, 252);
            label2.Name = "label2";
            label2.Size = new Size(477, 128);
            label2.TabIndex = 13;
            label2.Text = "Temukan berbagai pilihan pakaian bayi berkualitas dengan harga terjangkau! Dukung gaya hidup berkelanjutan dengan menjual, membeli, atau menawar harga pakaian preloved untuk si kecil.";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(511, 209);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(477, 38);
            label1.TabIndex = 12;
            label1.Text = "dan Ramah Lingkungan di Friperies!";
            // 
            // lblOfferpage
            // 
            lblOfferpage.AutoSize = true;
            lblOfferpage.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblOfferpage.Location = new Point(511, 171);
            lblOfferpage.Margin = new Padding(4, 0, 4, 0);
            lblOfferpage.Name = "lblOfferpage";
            lblOfferpage.Size = new Size(305, 38);
            lblOfferpage.TabIndex = 11;
            lblOfferpage.Text = "Belanja Pintar, Hemat,";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(72, 119);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(400, 300);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // btnLihatProduk
            // 
            btnLihatProduk.FlatAppearance.BorderSize = 3;
            btnLihatProduk.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLihatProduk.Image = Properties.Resources.cargo_3045489__1_;
            btnLihatProduk.ImageAlign = ContentAlignment.TopCenter;
            btnLihatProduk.Location = new Point(375, 474);
            btnLihatProduk.Margin = new Padding(2);
            btnLihatProduk.Name = "btnLihatProduk";
            btnLihatProduk.Size = new Size(235, 142);
            btnLihatProduk.TabIndex = 5;
            btnLihatProduk.Text = "Lihat Produk";
            btnLihatProduk.TextAlign = ContentAlignment.BottomCenter;
            btnLihatProduk.TextImageRelation = TextImageRelation.ImageAboveText;
            btnLihatProduk.UseVisualStyleBackColor = true;
            btnLihatProduk.Click += btnLihatProduk_Click;
            // 
            // btnProfil
            // 
            btnProfil.FlatAppearance.BorderSize = 3;
            btnProfil.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnProfil.Image = Properties.Resources.user_7855633__1_;
            btnProfil.ImageAlign = ContentAlignment.TopCenter;
            btnProfil.Location = new Point(661, 474);
            btnProfil.Margin = new Padding(2);
            btnProfil.Name = "btnProfil";
            btnProfil.Size = new Size(235, 142);
            btnProfil.TabIndex = 4;
            btnProfil.Text = "Profil";
            btnProfil.TextAlign = ContentAlignment.BottomCenter;
            btnProfil.TextImageRelation = TextImageRelation.ImageAboveText;
            btnProfil.UseVisualStyleBackColor = true;
            btnProfil.Click += btnProfil_Click;
            // 
            // btnUnggahProduk
            // 
            btnUnggahProduk.FlatAppearance.BorderSize = 3;
            btnUnggahProduk.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnUnggahProduk.Image = Properties.Resources.uploading_3305741__1___3_;
            btnUnggahProduk.ImageAlign = ContentAlignment.TopCenter;
            btnUnggahProduk.Location = new Point(85, 474);
            btnUnggahProduk.Margin = new Padding(2);
            btnUnggahProduk.Name = "btnUnggahProduk";
            btnUnggahProduk.Size = new Size(235, 142);
            btnUnggahProduk.TabIndex = 0;
            btnUnggahProduk.Text = "Unggah Produk";
            btnUnggahProduk.TextAlign = ContentAlignment.BottomCenter;
            btnUnggahProduk.TextImageRelation = TextImageRelation.ImageAboveText;
            btnUnggahProduk.UseVisualStyleBackColor = true;
            btnUnggahProduk.Click += btnUnggahProduk_Click;
            // 
            // homePageForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 700);
            Controls.Add(panel1);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "homePageForm";
            Text = "homePageForm";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel3;
        private Panel panel1;
        private Button btnExit;
        private Panel panel2;
        private Button btnUnggahProduk;
        private Button btnLihatProduk;
        private Button btnProfil;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label1;
        private Label lblOfferpage;
    }
}