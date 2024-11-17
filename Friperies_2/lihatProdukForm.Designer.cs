namespace Friperies_2
{
    partial class lihatProdukForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(lihatProdukForm));
            panel1 = new Panel();
            btnExit = new Button();
            btnBack = new Button();
            panel3 = new Panel();
            panel2 = new Panel();
            btnBuatPenawaran = new Button();
            btnMuatproduk = new Button();
            lblUnggahhargaitem = new Label();
            lblUnggahktgitem = new Label();
            lblUnggahnamaitem = new Label();
            tbHargaitem = new TextBox();
            tbKtgitem = new TextBox();
            tbNamaitem = new TextBox();
            pbUnggahitem = new PictureBox();
            dataGridView1 = new DataGridView();
            lblLihatitem = new Label();
            btnHome = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbUnggahitem).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
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
            // btnBack
            // 
            btnBack.FlatAppearance.BorderSize = 0;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBack.Image = (Image)resources.GetObject("btnBack.Image");
            btnBack.Location = new Point(881, 8);
            btnBack.Margin = new Padding(2);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(55, 55);
            btnBack.TabIndex = 7;
            btnBack.Text = " ";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click_1;
            // 
            // panel3
            // 
            panel3.BackgroundImage = Properties.Resources.Screenshot_2024_10_20_at_17_40_01_removebg_preview__1_;
            panel3.Location = new Point(10, 10);
            panel3.Margin = new Padding(2);
            panel3.Name = "panel3";
            panel3.Size = new Size(254, 52);
            panel3.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(192, 192, 255);
            panel2.Controls.Add(btnBuatPenawaran);
            panel2.Controls.Add(btnMuatproduk);
            panel2.Controls.Add(lblUnggahhargaitem);
            panel2.Controls.Add(lblUnggahktgitem);
            panel2.Controls.Add(lblUnggahnamaitem);
            panel2.Controls.Add(tbHargaitem);
            panel2.Controls.Add(tbKtgitem);
            panel2.Controls.Add(tbNamaitem);
            panel2.Controls.Add(pbUnggahitem);
            panel2.Controls.Add(dataGridView1);
            panel2.Controls.Add(lblLihatitem);
            panel2.Controls.Add(btnHome);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new Size(1000, 700);
            panel2.TabIndex = 6;
            // 
            // btnBuatPenawaran
            // 
            btnBuatPenawaran.Location = new Point(689, 269);
            btnBuatPenawaran.Margin = new Padding(4);
            btnBuatPenawaran.Name = "btnBuatPenawaran";
            btnBuatPenawaran.Size = new Size(162, 36);
            btnBuatPenawaran.TabIndex = 22;
            btnBuatPenawaran.Text = "Buat Penawaran";
            btnBuatPenawaran.UseVisualStyleBackColor = true;
            btnBuatPenawaran.Click += btnBuatPenawaran_Click;
            // 
            // btnMuatproduk
            // 
            btnMuatproduk.Location = new Point(708, 639);
            btnMuatproduk.Margin = new Padding(4);
            btnMuatproduk.Name = "btnMuatproduk";
            btnMuatproduk.Size = new Size(144, 36);
            btnMuatproduk.TabIndex = 21;
            btnMuatproduk.Text = "Muat Produk";
            btnMuatproduk.UseVisualStyleBackColor = true;
            btnMuatproduk.Click += btnMuatproduk_Click_1;
            // 
            // lblUnggahhargaitem
            // 
            lblUnggahhargaitem.AutoSize = true;
            lblUnggahhargaitem.Location = new Point(238, 279);
            lblUnggahhargaitem.Margin = new Padding(4, 0, 4, 0);
            lblUnggahhargaitem.Name = "lblUnggahhargaitem";
            lblUnggahhargaitem.Size = new Size(69, 25);
            lblUnggahhargaitem.TabIndex = 20;
            lblUnggahhargaitem.Text = "Harga :";
            // 
            // lblUnggahktgitem
            // 
            lblUnggahktgitem.AutoSize = true;
            lblUnggahktgitem.Location = new Point(238, 220);
            lblUnggahktgitem.Margin = new Padding(4, 0, 4, 0);
            lblUnggahktgitem.Name = "lblUnggahktgitem";
            lblUnggahktgitem.Size = new Size(92, 25);
            lblUnggahktgitem.TabIndex = 19;
            lblUnggahktgitem.Text = "Kategori : ";
            // 
            // lblUnggahnamaitem
            // 
            lblUnggahnamaitem.AutoSize = true;
            lblUnggahnamaitem.Location = new Point(238, 165);
            lblUnggahnamaitem.Margin = new Padding(4, 0, 4, 0);
            lblUnggahnamaitem.Name = "lblUnggahnamaitem";
            lblUnggahnamaitem.Size = new Size(130, 25);
            lblUnggahnamaitem.TabIndex = 18;
            lblUnggahnamaitem.Text = "Nama Produk :";
            // 
            // tbHargaitem
            // 
            tbHargaitem.Location = new Point(386, 270);
            tbHargaitem.Margin = new Padding(4);
            tbHargaitem.Name = "tbHargaitem";
            tbHargaitem.Size = new Size(275, 31);
            tbHargaitem.TabIndex = 17;
            // 
            // tbKtgitem
            // 
            tbKtgitem.Location = new Point(386, 220);
            tbKtgitem.Margin = new Padding(4);
            tbKtgitem.Name = "tbKtgitem";
            tbKtgitem.Size = new Size(275, 31);
            tbKtgitem.TabIndex = 16;
            // 
            // tbNamaitem
            // 
            tbNamaitem.Location = new Point(386, 165);
            tbNamaitem.Margin = new Padding(4);
            tbNamaitem.Name = "tbNamaitem";
            tbNamaitem.Size = new Size(275, 31);
            tbNamaitem.TabIndex = 15;
            // 
            // pbUnggahitem
            // 
            pbUnggahitem.BackColor = Color.White;
            pbUnggahitem.BorderStyle = BorderStyle.Fixed3D;
            pbUnggahitem.Location = new Point(80, 144);
            pbUnggahitem.Margin = new Padding(4);
            pbUnggahitem.Name = "pbUnggahitem";
            pbUnggahitem.Size = new Size(130, 174);
            pbUnggahitem.SizeMode = PictureBoxSizeMode.StretchImage;
            pbUnggahitem.TabIndex = 14;
            pbUnggahitem.TabStop = false;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(80, 351);
            dataGridView1.Margin = new Padding(4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(771, 268);
            dataGridView1.TabIndex = 8;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // lblLihatitem
            // 
            lblLihatitem.AutoSize = true;
            lblLihatitem.Font = new Font("Segoe UI Semibold", 13.2000008F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblLihatitem.Location = new Point(26, 91);
            lblLihatitem.Margin = new Padding(4, 0, 4, 0);
            lblLihatitem.Name = "lblLihatitem";
            lblLihatitem.Size = new Size(171, 37);
            lblLihatitem.TabIndex = 2;
            lblLihatitem.Text = "Lihat Produk";
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
            // lihatProdukForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 700);
            Controls.Add(panel1);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "lihatProdukForm";
            Text = "lihatProdukForm";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbUnggahitem).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnExit;
        private Button btnBack;
        private Panel panel3;
        private Panel panel2;
        private Button btnHome;
        private Label lblLihatitem;
        private DataGridView dataGridView1;
        private Label lblUnggahhargaitem;
        private Label lblUnggahktgitem;
        private Label lblUnggahnamaitem;
        private TextBox tbHargaitem;
        private TextBox tbKtgitem;
        private TextBox tbNamaitem;
        private PictureBox pbUnggahitem;
        private Button btnMuatproduk;
        private Button btnBuatPenawaran;
    }
}