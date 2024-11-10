namespace Friperies_2
{
    partial class produkSellerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(produkSellerForm));
            panel3 = new Panel();
            panel1 = new Panel();
            btnExit = new Button();
            btnBack = new Button();
            panel2 = new Panel();
            btLoad = new Button();
            tbKategori = new TextBox();
            label3 = new Label();
            btnDelete = new Button();
            tbHarga = new TextBox();
            label2 = new Label();
            tbNamaProduk = new TextBox();
            label1 = new Label();
            tbIdProduk = new TextBox();
            lblIdProduk = new Label();
            dgvPenawaran = new DataGridView();
            lblProduk = new Label();
            btnHome = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPenawaran).BeginInit();
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
            panel1.TabIndex = 7;
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
            panel2.Controls.Add(tbKategori);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(btnDelete);
            panel2.Controls.Add(tbHarga);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(tbNamaProduk);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(tbIdProduk);
            panel2.Controls.Add(lblIdProduk);
            panel2.Controls.Add(dgvPenawaran);
            panel2.Controls.Add(lblProduk);
            panel2.Controls.Add(btnHome);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 560);
            panel2.TabIndex = 8;
            // 
            // btLoad
            // 
            btLoad.Location = new Point(671, 434);
            btLoad.Margin = new Padding(2);
            btLoad.Name = "btLoad";
            btLoad.Size = new Size(110, 37);
            btLoad.TabIndex = 24;
            btLoad.Text = "Muat Produk";
            btLoad.UseVisualStyleBackColor = true;
            // 
            // tbKategori
            // 
            tbKategori.BackColor = Color.White;
            tbKategori.Location = new Point(199, 211);
            tbKategori.Name = "tbKategori";
            tbKategori.ReadOnly = true;
            tbKategori.Size = new Size(217, 27);
            tbKategori.TabIndex = 22;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(26, 214);
            label3.Name = "label3";
            label3.Size = new Size(127, 20);
            label3.TabIndex = 21;
            label3.Text = "Kategori Produk : ";
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(649, 118);
            btnDelete.Margin = new Padding(2);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(132, 118);
            btnDelete.TabIndex = 19;
            btnDelete.Text = "Hapus Produk";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // tbHarga
            // 
            tbHarga.BackColor = Color.White;
            tbHarga.Location = new Point(199, 180);
            tbHarga.Name = "tbHarga";
            tbHarga.ReadOnly = true;
            tbHarga.Size = new Size(217, 27);
            tbHarga.TabIndex = 18;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 182);
            label2.Name = "label2";
            label2.Size = new Size(173, 20);
            label2.TabIndex = 17;
            label2.Text = "Harga Penawaran Awal : ";
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
            // tbIdProduk
            // 
            tbIdProduk.BackColor = Color.White;
            tbIdProduk.Location = new Point(199, 118);
            tbIdProduk.Name = "tbIdProduk";
            tbIdProduk.ReadOnly = true;
            tbIdProduk.Size = new Size(217, 27);
            tbIdProduk.TabIndex = 14;
            // 
            // lblIdProduk
            // 
            lblIdProduk.AutoSize = true;
            lblIdProduk.Location = new Point(26, 120);
            lblIdProduk.Name = "lblIdProduk";
            lblIdProduk.Size = new Size(85, 20);
            lblIdProduk.TabIndex = 5;
            lblIdProduk.Text = "ID Produk : ";
            // 
            // dgvPenawaran
            // 
            dgvPenawaran.AllowUserToAddRows = false;
            dgvPenawaran.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPenawaran.Location = new Point(26, 251);
            dgvPenawaran.Margin = new Padding(2);
            dgvPenawaran.Name = "dgvPenawaran";
            dgvPenawaran.ReadOnly = true;
            dgvPenawaran.RowHeadersWidth = 62;
            dgvPenawaran.Size = new Size(755, 174);
            dgvPenawaran.TabIndex = 4;
            // 
            // lblProduk
            // 
            lblProduk.AutoSize = true;
            lblProduk.Font = new Font("Segoe UI Semibold", 13.2000008F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblProduk.Location = new Point(26, 77);
            lblProduk.Name = "lblProduk";
            lblProduk.Size = new Size(148, 31);
            lblProduk.TabIndex = 3;
            lblProduk.Text = "Produk Anda";
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
            // produkSellerForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 560);
            Controls.Add(panel1);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "produkSellerForm";
            Text = "produkSeller";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPenawaran).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel3;
        private Panel panel1;
        private Button btnExit;
        private Button btnBack;
        private Panel panel2;
        private TextBox tbKategori;
        private Label label3;
        private Button btnDelete;
        private TextBox tbHarga;
        private Label label2;
        private TextBox tbNamaProduk;
        private Label label1;
        private TextBox tbIdProduk;
        private Label lblIdProduk;
        private DataGridView dgvPenawaran;
        private Label lblProduk;
        private Button btnHome;
        private Button btLoad;
    }
}