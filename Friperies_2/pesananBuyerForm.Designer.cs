namespace Friperies_2
{
    partial class pesananBuyerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(pesananBuyerForm));
            panel3 = new Panel();
            panel1 = new Panel();
            btnExit = new Button();
            btnBack = new Button();
            panel2 = new Panel();
            btLoad = new Button();
            tbStatus = new TextBox();
            label3 = new Label();
            btnDone = new Button();
            tbTanggal = new TextBox();
            label2 = new Label();
            tbNamaProduk = new TextBox();
            label1 = new Label();
            tbIdPesanan = new TextBox();
            lblIdPesanan = new Label();
            dgvPesanan = new DataGridView();
            lblProduk = new Label();
            btnHome = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPesanan).BeginInit();
            SuspendLayout();
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
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(btnExit);
            panel1.Controls.Add(btnBack);
            panel1.Controls.Add(panel3);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 60);
            panel1.TabIndex = 8;
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
            // btnBack
            // 
            btnBack.FlatAppearance.BorderSize = 0;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBack.Image = (Image)resources.GetObject("btnBack.Image");
            btnBack.Location = new Point(705, 6);
            btnBack.Margin = new Padding(2);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(44, 44);
            btnBack.TabIndex = 7;
            btnBack.Text = " ";
            btnBack.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(192, 192, 255);
            panel2.Controls.Add(btLoad);
            panel2.Controls.Add(tbStatus);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(btnDone);
            panel2.Controls.Add(tbTanggal);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(tbNamaProduk);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(tbIdPesanan);
            panel2.Controls.Add(lblIdPesanan);
            panel2.Controls.Add(dgvPesanan);
            panel2.Controls.Add(lblProduk);
            panel2.Controls.Add(btnHome);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 560);
            panel2.TabIndex = 9;
            // 
            // btLoad
            // 
            btLoad.Location = new Point(651, 434);
            btLoad.Margin = new Padding(2);
            btLoad.Name = "btLoad";
            btLoad.Size = new Size(130, 37);
            btLoad.TabIndex = 23;
            btLoad.Text = "Muat Pesanan";
            btLoad.UseVisualStyleBackColor = true;
            // 
            // tbStatus
            // 
            tbStatus.BackColor = Color.White;
            tbStatus.Location = new Point(199, 211);
            tbStatus.Name = "tbStatus";
            tbStatus.ReadOnly = true;
            tbStatus.Size = new Size(217, 27);
            tbStatus.TabIndex = 22;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(26, 214);
            label3.Name = "label3";
            label3.Size = new Size(117, 20);
            label3.TabIndex = 21;
            label3.Text = "Status Pesanan : ";
            // 
            // btnDone
            // 
            btnDone.Location = new Point(649, 118);
            btnDone.Margin = new Padding(2);
            btnDone.Name = "btnDone";
            btnDone.Size = new Size(132, 118);
            btnDone.TabIndex = 19;
            btnDone.Text = "Pesanan sudah diterima";
            btnDone.UseVisualStyleBackColor = true;
            // 
            // tbTanggal
            // 
            tbTanggal.BackColor = Color.White;
            tbTanggal.Location = new Point(199, 180);
            tbTanggal.Name = "tbTanggal";
            tbTanggal.ReadOnly = true;
            tbTanggal.Size = new Size(217, 27);
            tbTanggal.TabIndex = 18;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 182);
            label2.Name = "label2";
            label2.Size = new Size(150, 20);
            label2.TabIndex = 17;
            label2.Text = "Tanggal Pemesanan : ";
            // 
            // tbNamaProduk
            // 
            tbNamaProduk.BackColor = Color.White;
            tbNamaProduk.Location = new Point(199, 149);
            tbNamaProduk.Name = "tbNamaProduk";
            tbNamaProduk.ReadOnly = true;
            tbNamaProduk.Size = new Size(217, 27);
            tbNamaProduk.TabIndex = 16;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 151);
            label1.Name = "label1";
            label1.Size = new Size(110, 20);
            label1.TabIndex = 15;
            label1.Text = "Nama Produk : ";
            // 
            // tbIdPesanan
            // 
            tbIdPesanan.BackColor = Color.White;
            tbIdPesanan.Location = new Point(199, 118);
            tbIdPesanan.Name = "tbIdPesanan";
            tbIdPesanan.ReadOnly = true;
            tbIdPesanan.Size = new Size(217, 27);
            tbIdPesanan.TabIndex = 14;
            // 
            // lblIdPesanan
            // 
            lblIdPesanan.AutoSize = true;
            lblIdPesanan.Location = new Point(26, 120);
            lblIdPesanan.Name = "lblIdPesanan";
            lblIdPesanan.Size = new Size(92, 20);
            lblIdPesanan.TabIndex = 5;
            lblIdPesanan.Text = "ID Pesanan : ";
            // 
            // dgvPesanan
            // 
            dgvPesanan.AllowUserToAddRows = false;
            dgvPesanan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPesanan.Location = new Point(26, 251);
            dgvPesanan.Margin = new Padding(2);
            dgvPesanan.Name = "dgvPesanan";
            dgvPesanan.ReadOnly = true;
            dgvPesanan.RowHeadersWidth = 62;
            dgvPesanan.Size = new Size(755, 170);
            dgvPesanan.TabIndex = 4;
            // 
            // lblProduk
            // 
            lblProduk.AutoSize = true;
            lblProduk.Font = new Font("Segoe UI Semibold", 13.2000008F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblProduk.Location = new Point(26, 77);
            lblProduk.Name = "lblProduk";
            lblProduk.Size = new Size(162, 31);
            lblProduk.TabIndex = 3;
            lblProduk.Text = "Pesanan Anda";
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
            // pesananBuyerForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 560);
            Controls.Add(panel1);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "pesananBuyerForm";
            Text = "pesananBuyerForm";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPesanan).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel3;
        private Panel panel1;
        private Button btnExit;
        private Button btnBack;
        private Panel panel2;
        private TextBox tbStatus;
        private Label label3;
        private Button btnDone;
        private TextBox tbTanggal;
        private Label label2;
        private TextBox tbNamaProduk;
        private Label label1;
        private TextBox tbIdPesanan;
        private Label lblIdPesanan;
        private DataGridView dgvPesanan;
        private Label lblProduk;
        private Button btnHome;
        private Button btLoad;
    }
}