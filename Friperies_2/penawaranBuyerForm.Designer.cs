namespace Friperies_2
{
    partial class penawaranBuyerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(penawaranBuyerForm));
            panel3 = new Panel();
            panel1 = new Panel();
            btnExit = new Button();
            btnBack = new Button();
            btnHome = new Button();
            lblPenawaran = new Label();
            panel2 = new Panel();
            btLoad = new Button();
            btCheckOut = new Button();
            btnDelete = new Button();
            tbHarga = new TextBox();
            label2 = new Label();
            tbNamaProduk = new TextBox();
            label1 = new Label();
            tbIdPenawaran = new TextBox();
            lblIdPenawaran = new Label();
            dgvPenawaran = new DataGridView();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPenawaran).BeginInit();
            SuspendLayout();
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
            panel1.TabIndex = 6;
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
            btnBack.Click += btnBack_Click;
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
            // lblPenawaran
            // 
            lblPenawaran.AutoSize = true;
            lblPenawaran.Font = new Font("Segoe UI Semibold", 13.2000008F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblPenawaran.Location = new Point(32, 96);
            lblPenawaran.Margin = new Padding(4, 0, 4, 0);
            lblPenawaran.Name = "lblPenawaran";
            lblPenawaran.Size = new Size(225, 37);
            lblPenawaran.TabIndex = 3;
            lblPenawaran.Text = "Penawaran Anda";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(192, 192, 255);
            panel2.Controls.Add(btLoad);
            panel2.Controls.Add(btCheckOut);
            panel2.Controls.Add(btnDelete);
            panel2.Controls.Add(tbHarga);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(tbNamaProduk);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(tbIdPenawaran);
            panel2.Controls.Add(lblIdPenawaran);
            panel2.Controls.Add(dgvPenawaran);
            panel2.Controls.Add(lblPenawaran);
            panel2.Controls.Add(btnHome);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new Size(1000, 700);
            panel2.TabIndex = 7;
            // 
            // btLoad
            // 
            btLoad.Location = new Point(814, 542);
            btLoad.Margin = new Padding(2);
            btLoad.Name = "btLoad";
            btLoad.Size = new Size(162, 46);
            btLoad.TabIndex = 21;
            btLoad.Text = "Muat Penawaran";
            btLoad.UseVisualStyleBackColor = true;
            btLoad.Click += btLoad_Click;
            // 
            // btCheckOut
            // 
            btCheckOut.Location = new Point(600, 148);
            btCheckOut.Margin = new Padding(2);
            btCheckOut.Name = "btCheckOut";
            btCheckOut.Size = new Size(175, 109);
            btCheckOut.TabIndex = 20;
            btCheckOut.Text = "Buat Pesanan (Check Out)";
            btCheckOut.UseVisualStyleBackColor = true;
            btCheckOut.Click += btCheckOut_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(791, 148);
            btnDelete.Margin = new Padding(2);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(185, 109);
            btnDelete.TabIndex = 19;
            btnDelete.Text = "Hapus Penawaran";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // tbHarga
            // 
            tbHarga.BackColor = Color.White;
            tbHarga.Location = new Point(205, 225);
            tbHarga.Margin = new Padding(4, 4, 4, 4);
            tbHarga.Name = "tbHarga";
            tbHarga.ReadOnly = true;
            tbHarga.Size = new Size(270, 31);
            tbHarga.TabIndex = 18;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 228);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(163, 25);
            label2.TabIndex = 17;
            label2.Text = "Harga Penawaran : ";
            // 
            // tbNamaProduk
            // 
            tbNamaProduk.BackColor = Color.White;
            tbNamaProduk.Location = new Point(205, 186);
            tbNamaProduk.Margin = new Padding(4, 4, 4, 4);
            tbNamaProduk.Name = "tbNamaProduk";
            tbNamaProduk.ReadOnly = true;
            tbNamaProduk.Size = new Size(270, 31);
            tbNamaProduk.TabIndex = 16;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 189);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(135, 25);
            label1.TabIndex = 15;
            label1.Text = "Nama Produk : ";
            // 
            // tbIdPenawaran
            // 
            tbIdPenawaran.BackColor = Color.White;
            tbIdPenawaran.Location = new Point(205, 148);
            tbIdPenawaran.Margin = new Padding(4, 4, 4, 4);
            tbIdPenawaran.Name = "tbIdPenawaran";
            tbIdPenawaran.ReadOnly = true;
            tbIdPenawaran.Size = new Size(270, 31);
            tbIdPenawaran.TabIndex = 14;
            // 
            // lblIdPenawaran
            // 
            lblIdPenawaran.AutoSize = true;
            lblIdPenawaran.Location = new Point(32, 150);
            lblIdPenawaran.Margin = new Padding(4, 0, 4, 0);
            lblIdPenawaran.Name = "lblIdPenawaran";
            lblIdPenawaran.Size = new Size(133, 25);
            lblIdPenawaran.TabIndex = 5;
            lblIdPenawaran.Text = "ID Penawaran : ";
            // 
            // dgvPenawaran
            // 
            dgvPenawaran.AllowUserToAddRows = false;
            dgvPenawaran.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPenawaran.Location = new Point(32, 280);
            dgvPenawaran.Margin = new Padding(2);
            dgvPenawaran.Name = "dgvPenawaran";
            dgvPenawaran.ReadOnly = true;
            dgvPenawaran.RowHeadersWidth = 62;
            dgvPenawaran.Size = new Size(944, 252);
            dgvPenawaran.TabIndex = 4;
            // 
            // penawaranBuyerForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 700);
            Controls.Add(panel1);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "penawaranBuyerForm";
            Text = "penawaranBuyer";
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
        private Button btnHome;
        private Label lblPenawaran;
        private Panel panel2;
        private DataGridView dgvPenawaran;
        private Label lblIdPenawaran;
        private Button btnDelete;
        private TextBox tbHarga;
        private Label label2;
        private TextBox tbNamaProduk;
        private Label label1;
        private TextBox tbIdPenawaran;
        private Button btCheckOut;
        private Button btLoad;
    }
}