namespace Friperies_2
{
    partial class profilForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(profilForm));
            panel1 = new Panel();
            btnExit = new Button();
            btnLogout = new Button();
            panel3 = new Panel();
            panel2 = new Panel();
            btProduk = new Button();
            btPenawaran = new Button();
            btPesanan = new Button();
            lblUsername = new Label();
            lblEmail = new Label();
            lblPass = new Label();
            lblAlamat = new Label();
            tbIdUser = new TextBox();
            tbUsername = new TextBox();
            tbEmail = new TextBox();
            tbPassword = new TextBox();
            tbAlamat = new TextBox();
            lblIdUser = new Label();
            lblProfil = new Label();
            btnHome = new Button();
            btnProfillogout = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
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
            panel1.TabIndex = 5;
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
            btnExit.Click += btnExit_Click;
            // 
            // btnLogout
            // 
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogout.Image = (Image)resources.GetObject("btnLogout.Image");
            btnLogout.Location = new Point(705, 6);
            btnLogout.Margin = new Padding(2);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(44, 44);
            btnLogout.TabIndex = 7;
            btnLogout.Text = " ";
            btnLogout.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            panel3.BackgroundImage = Properties.Resources.Screenshot_2024_10_20_at_17_40_01_removebg_preview__1_;
            panel3.Location = new Point(8, 8);
            panel3.Margin = new Padding(2);
            panel3.Name = "panel3";
            panel3.Size = new Size(205, 42);
            panel3.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(192, 192, 255);
            panel2.Controls.Add(btnProfillogout);
            panel2.Controls.Add(btProduk);
            panel2.Controls.Add(btPenawaran);
            panel2.Controls.Add(btPesanan);
            panel2.Controls.Add(lblUsername);
            panel2.Controls.Add(lblEmail);
            panel2.Controls.Add(lblPass);
            panel2.Controls.Add(lblAlamat);
            panel2.Controls.Add(tbIdUser);
            panel2.Controls.Add(tbUsername);
            panel2.Controls.Add(tbEmail);
            panel2.Controls.Add(tbPassword);
            panel2.Controls.Add(tbAlamat);
            panel2.Controls.Add(lblIdUser);
            panel2.Controls.Add(lblProfil);
            panel2.Controls.Add(btnHome);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 560);
            panel2.TabIndex = 6;
            // 
            // btProduk
            // 
            btProduk.Location = new Point(495, 171);
            btProduk.Margin = new Padding(2);
            btProduk.Name = "btProduk";
            btProduk.Size = new Size(129, 27);
            btProduk.TabIndex = 20;
            btProduk.Text = "Produk Anda";
            btProduk.UseVisualStyleBackColor = true;
            btProduk.Click += btProduk_Click;
            // 
            // btPenawaran
            // 
            btPenawaran.Location = new Point(495, 214);
            btPenawaran.Margin = new Padding(2);
            btPenawaran.Name = "btPenawaran";
            btPenawaran.Size = new Size(129, 27);
            btPenawaran.TabIndex = 19;
            btPenawaran.Text = "Penawaran Anda";
            btPenawaran.UseVisualStyleBackColor = true;
            btPenawaran.Click += btPenawaran_Click;
            // 
            // btPesanan
            // 
            btPesanan.Location = new Point(495, 259);
            btPesanan.Margin = new Padding(2);
            btPesanan.Name = "btPesanan";
            btPesanan.Size = new Size(129, 27);
            btPesanan.TabIndex = 18;
            btPesanan.Text = "Pesanan Anda";
            btPesanan.UseVisualStyleBackColor = true;
            btPesanan.Click += btPesanan_Click;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Location = new Point(53, 214);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(82, 20);
            lblUsername.TabIndex = 5;
            lblUsername.Text = "Username :";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(53, 259);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(53, 20);
            lblEmail.TabIndex = 6;
            lblEmail.Text = "Email :";
            // 
            // lblPass
            // 
            lblPass.AutoSize = true;
            lblPass.Location = new Point(53, 302);
            lblPass.Name = "lblPass";
            lblPass.Size = new Size(77, 20);
            lblPass.TabIndex = 7;
            lblPass.Text = "Password :";
            // 
            // lblAlamat
            // 
            lblAlamat.AutoSize = true;
            lblAlamat.Location = new Point(53, 351);
            lblAlamat.Name = "lblAlamat";
            lblAlamat.Size = new Size(64, 20);
            lblAlamat.TabIndex = 8;
            lblAlamat.Text = "Alamat :";
            // 
            // tbIdUser
            // 
            tbIdUser.Location = new Point(153, 171);
            tbIdUser.Name = "tbIdUser";
            tbIdUser.Size = new Size(264, 27);
            tbIdUser.TabIndex = 13;
            // 
            // tbUsername
            // 
            tbUsername.Location = new Point(153, 214);
            tbUsername.Name = "tbUsername";
            tbUsername.Size = new Size(264, 27);
            tbUsername.TabIndex = 14;
            tbUsername.KeyDown += tbUsername_KeyDown;
            // 
            // tbEmail
            // 
            tbEmail.Location = new Point(153, 259);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(264, 27);
            tbEmail.TabIndex = 15;
            tbEmail.KeyDown += tbEmail_KeyDown;
            // 
            // tbPassword
            // 
            tbPassword.Location = new Point(153, 302);
            tbPassword.Name = "tbPassword";
            tbPassword.Size = new Size(264, 27);
            tbPassword.TabIndex = 16;
            tbPassword.UseSystemPasswordChar = true;
            tbPassword.TextChanged += tbPassword_TextChanged;
            tbPassword.KeyDown += tbPassword_KeyDown;
            // 
            // tbAlamat
            // 
            tbAlamat.Location = new Point(153, 348);
            tbAlamat.Name = "tbAlamat";
            tbAlamat.Size = new Size(264, 27);
            tbAlamat.TabIndex = 17;
            tbAlamat.TextChanged += tbAlamat_TextChanged;
            tbAlamat.KeyDown += tbAlamat_KeyDown;
            // 
            // lblIdUser
            // 
            lblIdUser.AutoSize = true;
            lblIdUser.Location = new Point(53, 171);
            lblIdUser.Name = "lblIdUser";
            lblIdUser.Size = new Size(64, 20);
            lblIdUser.TabIndex = 4;
            lblIdUser.Text = "ID User :";
            // 
            // lblProfil
            // 
            lblProfil.AutoSize = true;
            lblProfil.Font = new Font("Segoe UI Semibold", 13.2000008F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblProfil.Location = new Point(53, 108);
            lblProfil.Name = "lblProfil";
            lblProfil.Size = new Size(72, 31);
            lblProfil.TabIndex = 3;
            lblProfil.Text = "Profil";
            // 
            // btnHome
            // 
            btnHome.BackColor = Color.FromArgb(192, 192, 255);
            btnHome.FlatAppearance.BorderSize = 3;
            btnHome.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnHome.Image = Properties.Resources.house_10723029__1_;
            btnHome.Location = new Point(718, 478);
            btnHome.Margin = new Padding(2);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(62, 62);
            btnHome.TabIndex = 1;
            btnHome.TextAlign = ContentAlignment.BottomCenter;
            btnHome.TextImageRelation = TextImageRelation.ImageAboveText;
            btnHome.UseVisualStyleBackColor = false;
            btnHome.Click += btnHome_Click;
            // 
            // btnProfillogout
            // 
            btnProfillogout.BackColor = Color.FromArgb(255, 128, 128);
            btnProfillogout.Location = new Point(495, 302);
            btnProfillogout.Margin = new Padding(2);
            btnProfillogout.Name = "btnProfillogout";
            btnProfillogout.Size = new Size(129, 27);
            btnProfillogout.TabIndex = 21;
            btnProfillogout.Text = "Log Out";
            btnProfillogout.UseVisualStyleBackColor = false;
            // 
            // profilForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 560);
            Controls.Add(panel1);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "profilForm";
            Text = "profilForm";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnExit;
        private Button btnLogout;
        private Panel panel3;
        private Panel panel2;
        private Button btnHome;
        private Label lblProfil;
        private Label lblIdUser;
        private Label lblAlamat;
        private Label lblPass;
        private Label lblEmail;
        private Label lblUsername;
        private Label lblIdUser2;
        private Label label1;
        private Label lblemail2;
        private Label lblUsername2;
        private TextBox tbIdUser;
        private TextBox tbAlamat;
        private TextBox tbPassword;
        private TextBox tbEmail;
        private TextBox tbUsername;
        private Button btProduk;
        private Button btPenawaran;
        private Button btPesanan;
        private Button btnProfillogout;
    }
}