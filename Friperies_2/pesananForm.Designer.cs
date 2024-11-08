namespace Friperies_2
{
    partial class pesananForm
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
            btnHome = new Button();
            lblPesanan = new Label();
            lblPesananitem = new Label();
            lblPesananstsbayar = new Label();
            lblPesananstskirim = new Label();
            dgvPesanan = new DataGridView();
            tbPesananitem = new TextBox();
            tbPesananstsbayar = new TextBox();
            tbPesananstskirim = new TextBox();
            btnPesananbatal = new Button();
            btnPesananterima = new Button();
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
            // panel3
            // 
            panel3.BackgroundImage = Properties.Resources.Screenshot_2024_10_20_at_17_40_01_removebg_preview__1_;
            panel3.Location = new Point(8, 8);
            panel3.Margin = new Padding(2);
            panel3.Name = "panel3";
            panel3.Size = new Size(166, 42);
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
            panel2.Margin = new Padding(2, 2, 2, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 560);
            panel2.TabIndex = 6;
            // 
            // btnHome
            // 
            btnHome.BackColor = Color.FromArgb(192, 192, 255);
            btnHome.FlatAppearance.BorderSize = 3;
            btnHome.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnHome.Image = Properties.Resources.house_10723029__1_;
            btnHome.Location = new Point(718, 478);
            btnHome.Margin = new Padding(2, 2, 2, 2);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(62, 62);
            btnHome.TabIndex = 1;
            btnHome.TextAlign = ContentAlignment.BottomCenter;
            btnHome.TextImageRelation = TextImageRelation.ImageAboveText;
            btnHome.UseVisualStyleBackColor = false;
            // 
            // lblPesanan
            // 
            lblPesanan.AutoSize = true;
            lblPesanan.Font = new Font("Segoe UI Semibold", 13.2000008F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblPesanan.Location = new Point(41, 94);
            lblPesanan.Name = "lblPesanan";
            lblPesanan.Size = new Size(102, 31);
            lblPesanan.TabIndex = 2;
            lblPesanan.Text = "Pesanan";
            // 
            // lblPesananitem
            // 
            lblPesananitem.AutoSize = true;
            lblPesananitem.Location = new Point(41, 177);
            lblPesananitem.Name = "lblPesananitem";
            lblPesananitem.Size = new Size(62, 20);
            lblPesananitem.TabIndex = 3;
            lblPesananitem.Text = "Produk :";
            // 
            // lblPesananstsbayar
            // 
            lblPesananstsbayar.AutoSize = true;
            lblPesananstsbayar.Location = new Point(41, 226);
            lblPesananstsbayar.Name = "lblPesananstsbayar";
            lblPesananstsbayar.Size = new Size(141, 20);
            lblPesananstsbayar.TabIndex = 4;
            lblPesananstsbayar.Text = "Status Pembayaran :";
            // 
            // lblPesananstskirim
            // 
            lblPesananstskirim.AutoSize = true;
            lblPesananstskirim.Location = new Point(41, 277);
            lblPesananstskirim.Name = "lblPesananstskirim";
            lblPesananstskirim.Size = new Size(134, 20);
            lblPesananstskirim.TabIndex = 5;
            lblPesananstskirim.Text = "Status Pengiriman :";
            // 
            // dgvPesanan
            // 
            dgvPesanan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPesanan.Location = new Point(416, 157);
            dgvPesanan.Name = "dgvPesanan";
            dgvPesanan.RowHeadersWidth = 51;
            dgvPesanan.Size = new Size(291, 275);
            dgvPesanan.TabIndex = 6;
            // 
            // tbPesananitem
            // 
            tbPesananitem.Location = new Point(183, 174);
            tbPesananitem.Name = "tbPesananitem";
            tbPesananitem.Size = new Size(190, 27);
            tbPesananitem.TabIndex = 7;
            // 
            // tbPesananstsbayar
            // 
            tbPesananstsbayar.Location = new Point(183, 223);
            tbPesananstsbayar.Name = "tbPesananstsbayar";
            tbPesananstsbayar.Size = new Size(190, 27);
            tbPesananstsbayar.TabIndex = 8;
            // 
            // tbPesananstskirim
            // 
            tbPesananstskirim.Location = new Point(183, 274);
            tbPesananstskirim.Name = "tbPesananstskirim";
            tbPesananstskirim.Size = new Size(190, 27);
            tbPesananstskirim.TabIndex = 9;
            // 
            // btnPesananbatal
            // 
            btnPesananbatal.BackColor = Color.FromArgb(255, 128, 128);
            btnPesananbatal.Location = new Point(41, 399);
            btnPesananbatal.Name = "btnPesananbatal";
            btnPesananbatal.Size = new Size(132, 33);
            btnPesananbatal.TabIndex = 10;
            btnPesananbatal.Text = "Batalkan Pesanan";
            btnPesananbatal.UseVisualStyleBackColor = false;
            // 
            // btnPesananterima
            // 
            btnPesananterima.BackColor = Color.White;
            btnPesananterima.Location = new Point(241, 399);
            btnPesananterima.Name = "btnPesananterima";
            btnPesananterima.Size = new Size(132, 33);
            btnPesananterima.TabIndex = 11;
            btnPesananterima.Text = "Pesanan Diterima";
            btnPesananterima.UseVisualStyleBackColor = false;
            // 
            // pesananForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 560);
            Controls.Add(panel1);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2, 2, 2, 2);
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