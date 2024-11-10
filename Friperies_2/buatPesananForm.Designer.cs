namespace Friperies_2
{
    partial class buatPesananForm
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
            btnPesananterima = new Button();
            btnPesananbatal = new Button();
            tbPesananstskirim = new TextBox();
            tbPesananstsbayar = new TextBox();
            tbPesananitem = new TextBox();
            dgvPesanan = new DataGridView();
            lblPesananstskirim = new Label();
            lblPesananstsbayar = new Label();
            lblPesananitem = new Label();
            lblPesanan = new Label();
            btnHome = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPesanan).BeginInit();
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
            panel3.Size = new Size(208, 52);
            panel3.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(192, 192, 255);
            panel2.Controls.Add(btnPesananterima);
            panel2.Controls.Add(btnPesananbatal);
            panel2.Controls.Add(tbPesananstskirim);
            panel2.Controls.Add(tbPesananstsbayar);
            panel2.Controls.Add(tbPesananitem);
            panel2.Controls.Add(dgvPesanan);
            panel2.Controls.Add(lblPesananstskirim);
            panel2.Controls.Add(lblPesananstsbayar);
            panel2.Controls.Add(lblPesananitem);
            panel2.Controls.Add(lblPesanan);
            panel2.Controls.Add(btnHome);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new Size(1000, 700);
            panel2.TabIndex = 6;
            // 
            // btnPesananterima
            // 
            btnPesananterima.BackColor = Color.White;
            btnPesananterima.Location = new Point(301, 499);
            btnPesananterima.Margin = new Padding(4, 4, 4, 4);
            btnPesananterima.Name = "btnPesananterima";
            btnPesananterima.Size = new Size(165, 41);
            btnPesananterima.TabIndex = 11;
            btnPesananterima.Text = "Pesanan Diterima";
            btnPesananterima.UseVisualStyleBackColor = false;
            btnPesananterima.Click += btnPesananterima_Click;
            // 
            // btnPesananbatal
            // 
            btnPesananbatal.BackColor = Color.FromArgb(255, 128, 128);
            btnPesananbatal.Location = new Point(51, 499);
            btnPesananbatal.Margin = new Padding(4, 4, 4, 4);
            btnPesananbatal.Name = "btnPesananbatal";
            btnPesananbatal.Size = new Size(165, 41);
            btnPesananbatal.TabIndex = 10;
            btnPesananbatal.Text = "Batalkan Pesanan";
            btnPesananbatal.UseVisualStyleBackColor = false;
            // 
            // tbPesananstskirim
            // 
            tbPesananstskirim.Location = new Point(229, 342);
            tbPesananstskirim.Margin = new Padding(4, 4, 4, 4);
            tbPesananstskirim.Name = "tbPesananstskirim";
            tbPesananstskirim.Size = new Size(236, 31);
            tbPesananstskirim.TabIndex = 9;
            // 
            // tbPesananstsbayar
            // 
            tbPesananstsbayar.Location = new Point(229, 279);
            tbPesananstsbayar.Margin = new Padding(4, 4, 4, 4);
            tbPesananstsbayar.Name = "tbPesananstsbayar";
            tbPesananstsbayar.Size = new Size(236, 31);
            tbPesananstsbayar.TabIndex = 8;
            // 
            // tbPesananitem
            // 
            tbPesananitem.Location = new Point(229, 218);
            tbPesananitem.Margin = new Padding(4, 4, 4, 4);
            tbPesananitem.Name = "tbPesananitem";
            tbPesananitem.Size = new Size(236, 31);
            tbPesananitem.TabIndex = 7;
            // 
            // dgvPesanan
            // 
            dgvPesanan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPesanan.Location = new Point(520, 196);
            dgvPesanan.Margin = new Padding(4, 4, 4, 4);
            dgvPesanan.Name = "dgvPesanan";
            dgvPesanan.RowHeadersWidth = 51;
            dgvPesanan.Size = new Size(364, 344);
            dgvPesanan.TabIndex = 6;
            // 
            // lblPesananstskirim
            // 
            lblPesananstskirim.AutoSize = true;
            lblPesananstskirim.Location = new Point(51, 346);
            lblPesananstskirim.Margin = new Padding(4, 0, 4, 0);
            lblPesananstskirim.Name = "lblPesananstskirim";
            lblPesananstskirim.Size = new Size(162, 25);
            lblPesananstskirim.TabIndex = 5;
            lblPesananstskirim.Text = "Status Pengiriman :";
            // 
            // lblPesananstsbayar
            // 
            lblPesananstsbayar.AutoSize = true;
            lblPesananstsbayar.Location = new Point(51, 282);
            lblPesananstsbayar.Margin = new Padding(4, 0, 4, 0);
            lblPesananstsbayar.Name = "lblPesananstsbayar";
            lblPesananstsbayar.Size = new Size(171, 25);
            lblPesananstsbayar.TabIndex = 4;
            lblPesananstsbayar.Text = "Status Pembayaran :";
            // 
            // lblPesananitem
            // 
            lblPesananitem.AutoSize = true;
            lblPesananitem.Location = new Point(51, 221);
            lblPesananitem.Margin = new Padding(4, 0, 4, 0);
            lblPesananitem.Name = "lblPesananitem";
            lblPesananitem.Size = new Size(78, 25);
            lblPesananitem.TabIndex = 3;
            lblPesananitem.Text = "Produk :";
            // 
            // lblPesanan
            // 
            lblPesanan.AutoSize = true;
            lblPesanan.Font = new Font("Segoe UI Semibold", 13.2000008F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblPesanan.Location = new Point(51, 118);
            lblPesanan.Margin = new Padding(4, 0, 4, 0);
            lblPesanan.Name = "lblPesanan";
            lblPesanan.Size = new Size(120, 37);
            lblPesanan.TabIndex = 2;
            lblPesanan.Text = "Pesanan";
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
            // 
            // pesananForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 700);
            Controls.Add(panel1);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "pesananForm";
            Text = "pesananForm";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPesanan).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnExit;
        private Button btnLogout;
        private Panel panel3;
        private Panel panel2;
        private Button btnHome;
        private Label lblPesananstskirim;
        private Label lblPesananstsbayar;
        private Label lblPesananitem;
        private Label lblPesanan;
        private Button btnPesananbatal;
        private TextBox tbPesananstskirim;
        private TextBox tbPesananstsbayar;
        private TextBox tbPesananitem;
        private DataGridView dgvPesanan;
        private Button btnPesananterima;
    }
}