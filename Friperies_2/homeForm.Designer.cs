namespace Friperies_2
{
    partial class homeForm
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
            panel1 = new Panel();
            panel2 = new Panel();
            btnHome = new Button();
            btnUnggah = new Button();
            btnKategori = new Button();
            btnPenawaran = new Button();
            btnPesanan = new Button();
            btnProfil = new Button();
            pnlSideHome = new Panel();
            pnlSideUnggah = new Panel();
            pnlSideKategori = new Panel();
            pnlSidePenawaran = new Panel();
            pnlSidePesanan = new Panel();
            pnlSideProfil = new Panel();
            panel3 = new Panel();
            btnLogout = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(224, 224, 224);
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(btnLogout);
            panel1.Controls.Add(panel3);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1000, 74);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(pnlSideProfil);
            panel2.Controls.Add(pnlSidePesanan);
            panel2.Controls.Add(pnlSidePenawaran);
            panel2.Controls.Add(pnlSideKategori);
            panel2.Controls.Add(pnlSideUnggah);
            panel2.Controls.Add(pnlSideHome);
            panel2.Controls.Add(btnProfil);
            panel2.Controls.Add(btnPesanan);
            panel2.Controls.Add(btnPenawaran);
            panel2.Controls.Add(btnKategori);
            panel2.Controls.Add(btnUnggah);
            panel2.Controls.Add(btnHome);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 74);
            panel2.Name = "panel2";
            panel2.Size = new Size(250, 626);
            panel2.TabIndex = 1;
            // 
            // btnHome
            // 
            btnHome.FlatAppearance.BorderSize = 0;
            btnHome.FlatStyle = FlatStyle.Flat;
            btnHome.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnHome.Image = Properties.Resources.house_10723029__1_;
            btnHome.ImageAlign = ContentAlignment.MiddleLeft;
            btnHome.Location = new Point(17, 16);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(241, 55);
            btnHome.TabIndex = 2;
            btnHome.Text = "  Home";
            btnHome.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnHome.UseVisualStyleBackColor = true;
            // 
            // btnUnggah
            // 
            btnUnggah.FlatAppearance.BorderSize = 0;
            btnUnggah.FlatStyle = FlatStyle.Flat;
            btnUnggah.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnUnggah.Image = Properties.Resources.uploading_3305741__1_;
            btnUnggah.ImageAlign = ContentAlignment.MiddleLeft;
            btnUnggah.Location = new Point(17, 77);
            btnUnggah.Name = "btnUnggah";
            btnUnggah.Size = new Size(241, 55);
            btnUnggah.TabIndex = 3;
            btnUnggah.Text = "  Unggah Produk";
            btnUnggah.TextAlign = ContentAlignment.MiddleLeft;
            btnUnggah.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnUnggah.UseVisualStyleBackColor = true;
            // 
            // btnKategori
            // 
            btnKategori.FlatAppearance.BorderSize = 0;
            btnKategori.FlatStyle = FlatStyle.Flat;
            btnKategori.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnKategori.Image = Properties.Resources.baby_toy_3299976__1_;
            btnKategori.ImageAlign = ContentAlignment.MiddleLeft;
            btnKategori.Location = new Point(17, 138);
            btnKategori.Name = "btnKategori";
            btnKategori.Size = new Size(241, 55);
            btnKategori.TabIndex = 4;
            btnKategori.Text = "  Kategori Produk";
            btnKategori.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnKategori.UseVisualStyleBackColor = true;
            // 
            // btnPenawaran
            // 
            btnPenawaran.FlatAppearance.BorderSize = 0;
            btnPenawaran.FlatStyle = FlatStyle.Flat;
            btnPenawaran.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPenawaran.Image = Properties.Resources.cargo_3045489__1_;
            btnPenawaran.ImageAlign = ContentAlignment.MiddleLeft;
            btnPenawaran.Location = new Point(17, 199);
            btnPenawaran.Name = "btnPenawaran";
            btnPenawaran.Size = new Size(241, 55);
            btnPenawaran.TabIndex = 5;
            btnPenawaran.Text = "  Penawaran";
            btnPenawaran.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnPenawaran.UseVisualStyleBackColor = true;
            // 
            // btnPesanan
            // 
            btnPesanan.FlatAppearance.BorderSize = 0;
            btnPesanan.FlatStyle = FlatStyle.Flat;
            btnPesanan.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPesanan.Image = Properties.Resources.pay_625548__1_;
            btnPesanan.ImageAlign = ContentAlignment.MiddleLeft;
            btnPesanan.Location = new Point(17, 260);
            btnPesanan.Name = "btnPesanan";
            btnPesanan.Size = new Size(241, 55);
            btnPesanan.TabIndex = 6;
            btnPesanan.Text = "  Pesanan";
            btnPesanan.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnPesanan.UseVisualStyleBackColor = true;
            // 
            // btnProfil
            // 
            btnProfil.FlatAppearance.BorderSize = 0;
            btnProfil.FlatStyle = FlatStyle.Flat;
            btnProfil.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnProfil.Image = Properties.Resources.user_7855633__1_;
            btnProfil.ImageAlign = ContentAlignment.MiddleLeft;
            btnProfil.Location = new Point(17, 321);
            btnProfil.Name = "btnProfil";
            btnProfil.Size = new Size(241, 55);
            btnProfil.TabIndex = 3;
            btnProfil.Text = "  Profil";
            btnProfil.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnProfil.UseVisualStyleBackColor = true;
            // 
            // pnlSideHome
            // 
            pnlSideHome.BackColor = Color.FromArgb(192, 192, 255);
            pnlSideHome.BorderStyle = BorderStyle.Fixed3D;
            pnlSideHome.Location = new Point(0, 16);
            pnlSideHome.Name = "pnlSideHome";
            pnlSideHome.Size = new Size(17, 55);
            pnlSideHome.TabIndex = 2;
            // 
            // pnlSideUnggah
            // 
            pnlSideUnggah.BackColor = Color.FromArgb(192, 192, 255);
            pnlSideUnggah.BorderStyle = BorderStyle.Fixed3D;
            pnlSideUnggah.Location = new Point(0, 77);
            pnlSideUnggah.Name = "pnlSideUnggah";
            pnlSideUnggah.Size = new Size(17, 55);
            pnlSideUnggah.TabIndex = 3;
            // 
            // pnlSideKategori
            // 
            pnlSideKategori.BackColor = Color.FromArgb(192, 192, 255);
            pnlSideKategori.BorderStyle = BorderStyle.Fixed3D;
            pnlSideKategori.Location = new Point(0, 138);
            pnlSideKategori.Name = "pnlSideKategori";
            pnlSideKategori.Size = new Size(17, 55);
            pnlSideKategori.TabIndex = 3;
            // 
            // pnlSidePenawaran
            // 
            pnlSidePenawaran.BackColor = Color.FromArgb(192, 192, 255);
            pnlSidePenawaran.BorderStyle = BorderStyle.Fixed3D;
            pnlSidePenawaran.Location = new Point(0, 199);
            pnlSidePenawaran.Name = "pnlSidePenawaran";
            pnlSidePenawaran.Size = new Size(17, 55);
            pnlSidePenawaran.TabIndex = 3;
            // 
            // pnlSidePesanan
            // 
            pnlSidePesanan.BackColor = Color.FromArgb(192, 192, 255);
            pnlSidePesanan.BorderStyle = BorderStyle.Fixed3D;
            pnlSidePesanan.Location = new Point(0, 260);
            pnlSidePesanan.Name = "pnlSidePesanan";
            pnlSidePesanan.Size = new Size(17, 55);
            pnlSidePesanan.TabIndex = 3;
            // 
            // pnlSideProfil
            // 
            pnlSideProfil.BackColor = Color.FromArgb(192, 192, 255);
            pnlSideProfil.BorderStyle = BorderStyle.Fixed3D;
            pnlSideProfil.Location = new Point(0, 321);
            pnlSideProfil.Name = "pnlSideProfil";
            pnlSideProfil.Size = new Size(17, 55);
            pnlSideProfil.TabIndex = 3;
            // 
            // panel3
            // 
            panel3.BackgroundImage = Properties.Resources.WhatsApp_Image_2024_10_20_at_15_59_51_removebg_preview__1_;
            panel3.Location = new Point(10, 10);
            panel3.Name = "panel3";
            panel3.Size = new Size(200, 55);
            panel3.TabIndex = 2;
            // 
            // btnLogout
            // 
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogout.Image = Properties.Resources.logout_4032999__1_;
            btnLogout.Location = new Point(932, 8);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(55, 55);
            btnLogout.TabIndex = 7;
            btnLogout.Text = " ";
            btnLogout.UseVisualStyleBackColor = true;
            // 
            // homeForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 700);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "homeForm";
            Text = "loginForm";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Button btnProfil;
        private Button btnPesanan;
        private Button btnPenawaran;
        private Button btnKategori;
        private Button btnUnggah;
        private Button btnHome;
        private Panel pnlSideProfil;
        private Panel pnlSidePesanan;
        private Panel pnlSidePenawaran;
        private Panel pnlSideKategori;
        private Panel pnlSideUnggah;
        private Panel pnlSideHome;
        private Panel panel3;
        private Button btnLogout;
    }
}