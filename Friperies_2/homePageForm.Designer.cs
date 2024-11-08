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
            panel3 = new Panel();
            panel1 = new Panel();
            btnExit = new Button();
            btnLogout = new Button();
            panel2 = new Panel();
            btnLihatProduk = new Button();
            btnProfil = new Button();
            btnPesanan = new Button();
            btnPenawaran = new Button();
            btnUnggahProduk = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.BackgroundImage = Properties.Resources.Screenshot_2024_10_20_at_17_40_01_removebg_preview__1_;
            panel3.Location = new Point(8, 8);
            panel3.Margin = new Padding(2);
            panel3.Name = "panel3";
            panel3.Size = new Size(204, 42);
            panel3.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(btnExit);
            panel1.Controls.Add(btnLogout);
            panel1.Controls.Add(panel3);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 60);
            panel1.TabIndex = 1;
            // 
            // btnExit
            // 
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnExit.Image = Properties.Resources.cancel_5697779__1_;
            btnExit.Location = new Point(746, 6);
            btnExit.Margin = new Padding(2);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(44, 44);
            btnExit.TabIndex = 8;
            btnExit.Text = " ";
            btnExit.UseVisualStyleBackColor = true;
            // 
            // btnLogout
            // 
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogout.Image = Properties.Resources.logout_4032999__1___1_;
            btnLogout.Location = new Point(705, 6);
            btnLogout.Margin = new Padding(2);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(44, 44);
            btnLogout.TabIndex = 7;
            btnLogout.Text = " ";
            btnLogout.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(192, 192, 255);
            panel2.Controls.Add(btnLihatProduk);
            panel2.Controls.Add(btnProfil);
            panel2.Controls.Add(btnPesanan);
            panel2.Controls.Add(btnPenawaran);
            panel2.Controls.Add(btnUnggahProduk);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(2, 2, 2, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 560);
            panel2.TabIndex = 2;
            // 
            // btnLihatProduk
            // 
            btnLihatProduk.FlatAppearance.BorderSize = 3;
            btnLihatProduk.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLihatProduk.Image = Properties.Resources.cargo_3045489__1_;
            btnLihatProduk.ImageAlign = ContentAlignment.TopCenter;
            btnLihatProduk.Location = new Point(300, 326);
            btnLihatProduk.Margin = new Padding(2, 2, 2, 2);
            btnLihatProduk.Name = "btnLihatProduk";
            btnLihatProduk.Size = new Size(188, 114);
            btnLihatProduk.TabIndex = 5;
            btnLihatProduk.Text = "Lihat Produk";
            btnLihatProduk.TextAlign = ContentAlignment.BottomCenter;
            btnLihatProduk.TextImageRelation = TextImageRelation.ImageAboveText;
            btnLihatProduk.UseVisualStyleBackColor = true;
            // 
            // btnProfil
            // 
            btnProfil.FlatAppearance.BorderSize = 3;
            btnProfil.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnProfil.Image = Properties.Resources.user_7855633__1_;
            btnProfil.ImageAlign = ContentAlignment.TopCenter;
            btnProfil.Location = new Point(521, 326);
            btnProfil.Margin = new Padding(2, 2, 2, 2);
            btnProfil.Name = "btnProfil";
            btnProfil.Size = new Size(188, 114);
            btnProfil.TabIndex = 4;
            btnProfil.Text = "Profil";
            btnProfil.TextAlign = ContentAlignment.BottomCenter;
            btnProfil.TextImageRelation = TextImageRelation.ImageAboveText;
            btnProfil.UseVisualStyleBackColor = true;
            // 
            // btnPesanan
            // 
            btnPesanan.FlatAppearance.BorderSize = 3;
            btnPesanan.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPesanan.Image = Properties.Resources.pay_625548__1_;
            btnPesanan.ImageAlign = ContentAlignment.TopCenter;
            btnPesanan.Location = new Point(82, 326);
            btnPesanan.Margin = new Padding(2, 2, 2, 2);
            btnPesanan.Name = "btnPesanan";
            btnPesanan.Size = new Size(188, 114);
            btnPesanan.TabIndex = 3;
            btnPesanan.Text = "Pesanan";
            btnPesanan.TextAlign = ContentAlignment.BottomCenter;
            btnPesanan.TextImageRelation = TextImageRelation.ImageAboveText;
            btnPesanan.UseVisualStyleBackColor = true;
            // 
            // btnPenawaran
            // 
            btnPenawaran.FlatAppearance.BorderSize = 3;
            btnPenawaran.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPenawaran.Image = Properties.Resources.cargo_3045489__1_;
            btnPenawaran.ImageAlign = ContentAlignment.TopCenter;
            btnPenawaran.Location = new Point(434, 154);
            btnPenawaran.Margin = new Padding(2, 2, 2, 2);
            btnPenawaran.Name = "btnPenawaran";
            btnPenawaran.Size = new Size(188, 114);
            btnPenawaran.TabIndex = 2;
            btnPenawaran.Text = "Penawaran";
            btnPenawaran.TextAlign = ContentAlignment.BottomCenter;
            btnPenawaran.TextImageRelation = TextImageRelation.ImageAboveText;
            btnPenawaran.UseVisualStyleBackColor = true;
            // 
            // btnUnggahProduk
            // 
            btnUnggahProduk.FlatAppearance.BorderSize = 3;
            btnUnggahProduk.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnUnggahProduk.Image = Properties.Resources.uploading_3305741__1___3_;
            btnUnggahProduk.ImageAlign = ContentAlignment.TopCenter;
            btnUnggahProduk.Location = new Point(203, 154);
            btnUnggahProduk.Margin = new Padding(2, 2, 2, 2);
            btnUnggahProduk.Name = "btnUnggahProduk";
            btnUnggahProduk.Size = new Size(188, 114);
            btnUnggahProduk.TabIndex = 0;
            btnUnggahProduk.Text = "Unggah Produk";
            btnUnggahProduk.TextAlign = ContentAlignment.BottomCenter;
            btnUnggahProduk.TextImageRelation = TextImageRelation.ImageAboveText;
            btnUnggahProduk.UseVisualStyleBackColor = true;
            // 
            // homePageForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 560);
            Controls.Add(panel1);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2, 2, 2, 2);
            Name = "homePageForm";
            Text = "homePageForm";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel3;
        private Panel panel1;
        private Button btnExit;
        private Button btnLogout;
        private Panel panel2;
        private Button btnUnggahProduk;
        private Button btnPesanan;
        private Button btnPenawaran;
        private Button btnLihatProduk;
        private Button btnProfil;
    }
}