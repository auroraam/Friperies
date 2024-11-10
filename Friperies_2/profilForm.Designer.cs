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
            panel1.Size = new Size(1000, 74);
            panel1.TabIndex = 5;
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
            // btnLogout
            // 
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogout.Image = Properties.Resources.logout_4032999__1___1_;
            btnLogout.Location = new Point(881, 8);
            btnLogout.Margin = new Padding(2);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(55, 55);
            btnLogout.TabIndex = 7;
            btnLogout.Text = " ";
            btnLogout.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            panel3.BackgroundImage = Properties.Resources.Screenshot_2024_10_20_at_17_40_01_removebg_preview__1_;
            panel3.Location = new Point(10, 10);
            panel3.Margin = new Padding(2);
            panel3.Name = "panel3";
            panel3.Size = new Size(256, 52);
            panel3.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(192, 192, 255);
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
            panel2.Size = new Size(1000, 700);
            panel2.TabIndex = 6;
            // 
            // btProduk
            // 
            btProduk.Location = new Point(543, 152);
            btProduk.Name = "btProduk";
            btProduk.Size = new Size(140, 34);
            btProduk.TabIndex = 20;
            btProduk.Text = "Produk Anda";
            btProduk.UseVisualStyleBackColor = true;
            // 
            // btPenawaran
            // 
            btPenawaran.Location = new Point(543, 205);
            btPenawaran.Name = "btPenawaran";
            btPenawaran.Size = new Size(161, 34);
            btPenawaran.TabIndex = 19;
            btPenawaran.Text = "Penawaran Anda";
            btPenawaran.UseVisualStyleBackColor = true;
            // 
            // btPesanan
            // 
            btPesanan.Location = new Point(543, 261);
            btPesanan.Name = "btPesanan";
            btPesanan.Size = new Size(140, 34);
            btPesanan.TabIndex = 18;
            btPesanan.Text = "Pesanan Anda";
            btPesanan.UseVisualStyleBackColor = true;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Location = new Point(32, 205);
            lblUsername.Margin = new Padding(4, 0, 4, 0);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(100, 25);
            lblUsername.TabIndex = 5;
            lblUsername.Text = "Username :";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(32, 250);
            lblEmail.Margin = new Padding(4, 0, 4, 0);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(63, 25);
            lblEmail.TabIndex = 6;
            lblEmail.Text = "Email :";
            // 
            // lblPass
            // 
            lblPass.AutoSize = true;
            lblPass.Location = new Point(32, 300);
            lblPass.Margin = new Padding(4, 0, 4, 0);
            lblPass.Name = "lblPass";
            lblPass.Size = new Size(96, 25);
            lblPass.TabIndex = 7;
            lblPass.Text = "Password :";
            // 
            // lblAlamat
            // 
            lblAlamat.AutoSize = true;
            lblAlamat.Location = new Point(32, 351);
            lblAlamat.Margin = new Padding(4, 0, 4, 0);
            lblAlamat.Name = "lblAlamat";
            lblAlamat.Size = new Size(77, 25);
            lblAlamat.TabIndex = 8;
            lblAlamat.Text = "Alamat :";
            // 
            // tbIdUser
            // 
            tbIdUser.Location = new Point(142, 152);
            tbIdUser.Margin = new Padding(4);
            tbIdUser.Name = "tbIdUser";
            tbIdUser.Size = new Size(270, 31);
            tbIdUser.TabIndex = 13;
            // 
            // tbUsername
            // 
            tbUsername.Location = new Point(142, 201);
            tbUsername.Margin = new Padding(4);
            tbUsername.Name = "tbUsername";
            tbUsername.Size = new Size(270, 31);
            tbUsername.TabIndex = 14;
            tbUsername.KeyDown += tbUsername_KeyDown;
            // 
            // tbEmail
            // 
            tbEmail.Location = new Point(142, 246);
            tbEmail.Margin = new Padding(4);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(270, 31);
            tbEmail.TabIndex = 15;
            tbEmail.KeyDown += tbEmail_KeyDown;
            // 
            // tbPassword
            // 
            tbPassword.Location = new Point(142, 296);
            tbPassword.Margin = new Padding(4);
            tbPassword.Name = "tbPassword";
            tbPassword.Size = new Size(270, 31);
            tbPassword.TabIndex = 16;
            tbPassword.UseSystemPasswordChar = true;
            tbPassword.KeyDown += tbPassword_KeyDown;
            // 
            // tbAlamat
            // 
            tbAlamat.Location = new Point(142, 348);
            tbAlamat.Margin = new Padding(4);
            tbAlamat.Name = "tbAlamat";
            tbAlamat.Size = new Size(270, 31);
            tbAlamat.TabIndex = 17;
            tbAlamat.KeyDown += tbAlamat_KeyDown;
            // 
            // lblIdUser
            // 
            lblIdUser.AutoSize = true;
            lblIdUser.Location = new Point(32, 156);
            lblIdUser.Margin = new Padding(4, 0, 4, 0);
            lblIdUser.Name = "lblIdUser";
            lblIdUser.Size = new Size(79, 25);
            lblIdUser.TabIndex = 4;
            lblIdUser.Text = "ID User :";
            // 
            // lblProfil
            // 
            lblProfil.AutoSize = true;
            lblProfil.Font = new Font("Segoe UI Semibold", 13.2000008F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblProfil.Location = new Point(32, 96);
            lblProfil.Margin = new Padding(4, 0, 4, 0);
            lblProfil.Name = "lblProfil";
            lblProfil.Size = new Size(83, 37);
            lblProfil.TabIndex = 3;
            lblProfil.Text = "Profil";
            // 
            // btnHome
            // 
            btnHome.BackColor = Color.FromArgb(192, 192, 255);
            btnHome.FlatAppearance.BorderSize = 3;
            btnHome.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnHome.Image = Properties.Resources.house_10723029__1_;
            btnHome.Location = new Point(898, 598);
            btnHome.Margin = new Padding(2);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(78, 78);
            btnHome.TabIndex = 1;
            btnHome.TextAlign = ContentAlignment.BottomCenter;
            btnHome.TextImageRelation = TextImageRelation.ImageAboveText;
            btnHome.UseVisualStyleBackColor = false;
            btnHome.Click += btnHome_Click;
            // 
            // profilForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 700);
            Controls.Add(panel1);
            Controls.Add(panel2);
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
    }
}