namespace Friperies_2
{
    partial class penawaranSellerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(penawaranSellerForm));
            panel1 = new Panel();
            btnExit = new Button();
            btnBack = new Button();
            panel3 = new Panel();
            panel2 = new Panel();
            tbHargaPenawaran = new TextBox();
            label1 = new Label();
            lblOfferpage = new Label();
            btnOfferload = new Button();
            btnOffertolak = new Button();
            btnOfferterima = new Button();
            tbOfferhargaitem = new TextBox();
            tbOffernamaitem = new TextBox();
            lblOfferhargaitem = new Label();
            lblOffernamaitem = new Label();
            dataGridView1 = new DataGridView();
            btnHome = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
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
            btnExit.Click += btnExit_Click_1;
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
            panel2.Controls.Add(tbHargaPenawaran);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(lblOfferpage);
            panel2.Controls.Add(btnOfferload);
            panel2.Controls.Add(btnOffertolak);
            panel2.Controls.Add(btnOfferterima);
            panel2.Controls.Add(tbOfferhargaitem);
            panel2.Controls.Add(tbOffernamaitem);
            panel2.Controls.Add(lblOfferhargaitem);
            panel2.Controls.Add(lblOffernamaitem);
            panel2.Controls.Add(dataGridView1);
            panel2.Controls.Add(btnHome);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new Size(1000, 700);
            panel2.TabIndex = 6;
            // 
            // tbHargaPenawaran
            // 
            tbHargaPenawaran.Location = new Point(312, 230);
            tbHargaPenawaran.Margin = new Padding(4);
            tbHargaPenawaran.Name = "tbHargaPenawaran";
            tbHargaPenawaran.ReadOnly = true;
            tbHargaPenawaran.Size = new Size(263, 31);
            tbHargaPenawaran.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(132, 234);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(162, 25);
            label1.TabIndex = 11;
            label1.Text = "Harga Ditawarkan :";
            // 
            // lblOfferpage
            // 
            lblOfferpage.AutoSize = true;
            lblOfferpage.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblOfferpage.Location = new Point(15, 99);
            lblOfferpage.Margin = new Padding(4, 0, 4, 0);
            lblOfferpage.Name = "lblOfferpage";
            lblOfferpage.Size = new Size(160, 38);
            lblOfferpage.TabIndex = 10;
            lblOfferpage.Text = "Penawaran";
            // 
            // btnOfferload
            // 
            btnOfferload.Location = new Point(701, 512);
            btnOfferload.Margin = new Padding(4);
            btnOfferload.Name = "btnOfferload";
            btnOfferload.Size = new Size(184, 39);
            btnOfferload.TabIndex = 9;
            btnOfferload.Text = "Muat Penawaran";
            btnOfferload.UseVisualStyleBackColor = true;
            btnOfferload.Click += btnOfferload_Click_1;
            // 
            // btnOffertolak
            // 
            btnOffertolak.Location = new Point(649, 214);
            btnOffertolak.Margin = new Padding(4);
            btnOffertolak.Name = "btnOffertolak";
            btnOffertolak.Size = new Size(149, 42);
            btnOffertolak.TabIndex = 8;
            btnOffertolak.Text = "Tolak";
            btnOffertolak.UseVisualStyleBackColor = true;
            btnOffertolak.Click += btnOffertolak_Click;
            // 
            // btnOfferterima
            // 
            btnOfferterima.Location = new Point(649, 164);
            btnOfferterima.Margin = new Padding(4);
            btnOfferterima.Name = "btnOfferterima";
            btnOfferterima.Size = new Size(149, 42);
            btnOfferterima.TabIndex = 7;
            btnOfferterima.Text = "Terima";
            btnOfferterima.UseVisualStyleBackColor = true;
            btnOfferterima.Click += btnOfferterima_Click_1;
            // 
            // tbOfferhargaitem
            // 
            tbOfferhargaitem.Location = new Point(312, 191);
            tbOfferhargaitem.Margin = new Padding(4);
            tbOfferhargaitem.Name = "tbOfferhargaitem";
            tbOfferhargaitem.ReadOnly = true;
            tbOfferhargaitem.Size = new Size(263, 31);
            tbOfferhargaitem.TabIndex = 6;
            // 
            // tbOffernamaitem
            // 
            tbOffernamaitem.Location = new Point(312, 152);
            tbOffernamaitem.Margin = new Padding(4);
            tbOffernamaitem.Name = "tbOffernamaitem";
            tbOffernamaitem.ReadOnly = true;
            tbOffernamaitem.Size = new Size(263, 31);
            tbOffernamaitem.TabIndex = 5;
            // 
            // lblOfferhargaitem
            // 
            lblOfferhargaitem.AutoSize = true;
            lblOfferhargaitem.ForeColor = SystemColors.ControlText;
            lblOfferhargaitem.Location = new Point(132, 195);
            lblOfferhargaitem.Margin = new Padding(4, 0, 4, 0);
            lblOfferhargaitem.Name = "lblOfferhargaitem";
            lblOfferhargaitem.Size = new Size(112, 25);
            lblOfferhargaitem.TabIndex = 4;
            lblOfferhargaitem.Text = "Harga Awal :";
            // 
            // lblOffernamaitem
            // 
            lblOffernamaitem.AutoSize = true;
            lblOffernamaitem.Location = new Point(132, 156);
            lblOffernamaitem.Margin = new Padding(4, 0, 4, 0);
            lblOffernamaitem.Name = "lblOffernamaitem";
            lblOffernamaitem.Size = new Size(130, 25);
            lblOffernamaitem.TabIndex = 3;
            lblOffernamaitem.Text = "Nama Produk :";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(134, 290);
            dataGridView1.Margin = new Padding(4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(751, 201);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellClick += dataGridView1_CellClick;
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
            // penawaranSellerForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 700);
            Controls.Add(panel1);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "penawaranSellerForm";
            Text = "penawaranForm";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
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
        private DataGridView dataGridView1;
        private Label lblOfferhargaitem;
        private Label lblOffernamaitem;
        private TextBox tbOfferhargaitem;
        private TextBox tbOffernamaitem;
        private Button btnOffertolak;
        private Button btnOfferterima;
        private Button btnOfferload;
        private Label lblOfferpage;
        private TextBox tbHargaPenawaran;
        private Label label1;
    }
}