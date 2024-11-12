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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(buatPesananForm));
            panel1 = new Panel();
            btnExit = new Button();
            btnBack = new Button();
            panel3 = new Panel();
            panel2 = new Panel();
            tbBuatpesanankrm = new TextBox();
            lblBuatpesanankrm = new Label();
            btnBuatpesanan = new Button();
            btnPesananbatal = new Button();
            tbBuatpesanansts = new TextBox();
            tbBuatpesanantgl = new TextBox();
            tbBuatpesananitem = new TextBox();
            lblBuatpesanansts = new Label();
            lblBuatpesanantgl = new Label();
            lblBuatpesananitem = new Label();
            lblBuatPesanan = new Label();
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
            panel2.Controls.Add(tbBuatpesanankrm);
            panel2.Controls.Add(lblBuatpesanankrm);
            panel2.Controls.Add(btnBuatpesanan);
            panel2.Controls.Add(btnPesananbatal);
            panel2.Controls.Add(tbBuatpesanansts);
            panel2.Controls.Add(tbBuatpesanantgl);
            panel2.Controls.Add(tbBuatpesananitem);
            panel2.Controls.Add(lblBuatpesanansts);
            panel2.Controls.Add(lblBuatpesanantgl);
            panel2.Controls.Add(lblBuatpesananitem);
            panel2.Controls.Add(lblBuatPesanan);
            panel2.Controls.Add(btnHome);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new Size(1000, 700);
            panel2.TabIndex = 6;
            // 
            // tbBuatpesanankrm
            // 
            tbBuatpesanankrm.Location = new Point(242, 420);
            tbBuatpesanankrm.Margin = new Padding(4);
            tbBuatpesanankrm.Name = "tbBuatpesanankrm";
            tbBuatpesanankrm.Size = new Size(512, 31);
            tbBuatpesanankrm.TabIndex = 13;
            // 
            // lblBuatpesanankrm
            // 
            lblBuatpesanankrm.AutoSize = true;
            lblBuatpesanankrm.Location = new Point(69, 429);
            lblBuatpesanankrm.Margin = new Padding(4, 0, 4, 0);
            lblBuatpesanankrm.Name = "lblBuatpesanankrm";
            lblBuatpesanankrm.Size = new Size(109, 25);
            lblBuatpesanankrm.TabIndex = 12;
            lblBuatpesanankrm.Text = "Pengiriman :";
            // 
            // btnBuatpesanan
            // 
            btnBuatpesanan.BackColor = Color.White;
            btnBuatpesanan.Location = new Point(515, 536);
            btnBuatpesanan.Margin = new Padding(4);
            btnBuatpesanan.Name = "btnBuatpesanan";
            btnBuatpesanan.Size = new Size(165, 41);
            btnBuatpesanan.TabIndex = 11;
            btnBuatpesanan.Text = "Buat Pesanan";
            btnBuatpesanan.UseVisualStyleBackColor = false;
            btnBuatpesanan.Click += btnPesananterima_Click;
            // 
            // btnPesananbatal
            // 
            btnPesananbatal.BackColor = Color.FromArgb(255, 128, 128);
            btnPesananbatal.Location = new Point(311, 536);
            btnPesananbatal.Margin = new Padding(4);
            btnPesananbatal.Name = "btnPesananbatal";
            btnPesananbatal.Size = new Size(165, 41);
            btnPesananbatal.TabIndex = 10;
            btnPesananbatal.Text = "Batalkan Pesanan";
            btnPesananbatal.UseVisualStyleBackColor = false;
            // 
            // tbBuatpesanansts
            // 
            tbBuatpesanansts.Location = new Point(242, 355);
            tbBuatpesanansts.Margin = new Padding(4);
            tbBuatpesanansts.Name = "tbBuatpesanansts";
            tbBuatpesanansts.Size = new Size(512, 31);
            tbBuatpesanansts.TabIndex = 9;
            // 
            // tbBuatpesanantgl
            // 
            tbBuatpesanantgl.Location = new Point(242, 290);
            tbBuatpesanantgl.Margin = new Padding(4);
            tbBuatpesanantgl.Name = "tbBuatpesanantgl";
            tbBuatpesanantgl.Size = new Size(512, 31);
            tbBuatpesanantgl.TabIndex = 8;
            // 
            // tbBuatpesananitem
            // 
            tbBuatpesananitem.Location = new Point(242, 230);
            tbBuatpesananitem.Margin = new Padding(4);
            tbBuatpesananitem.Name = "tbBuatpesananitem";
            tbBuatpesananitem.Size = new Size(512, 31);
            tbBuatpesananitem.TabIndex = 7;
            // 
            // lblBuatpesanansts
            // 
            lblBuatpesanansts.AutoSize = true;
            lblBuatpesanansts.Location = new Point(69, 359);
            lblBuatpesanansts.Margin = new Padding(4, 0, 4, 0);
            lblBuatpesanansts.Name = "lblBuatpesanansts";
            lblBuatpesanansts.Size = new Size(138, 25);
            lblBuatpesanansts.TabIndex = 5;
            lblBuatpesanansts.Text = "Status Pesanan :";
            lblBuatpesanansts.Click += lblBuatpesanansts_Click;
            // 
            // lblBuatpesanantgl
            // 
            lblBuatpesanantgl.AutoSize = true;
            lblBuatpesanantgl.Location = new Point(69, 294);
            lblBuatpesanantgl.Margin = new Padding(4, 0, 4, 0);
            lblBuatpesanantgl.Name = "lblBuatpesanantgl";
            lblBuatpesanantgl.Size = new Size(82, 25);
            lblBuatpesanantgl.TabIndex = 4;
            lblBuatpesanantgl.Text = "Tanggal :";
            // 
            // lblBuatpesananitem
            // 
            lblBuatpesananitem.AutoSize = true;
            lblBuatpesananitem.Location = new Point(69, 234);
            lblBuatpesananitem.Margin = new Padding(4, 0, 4, 0);
            lblBuatpesananitem.Name = "lblBuatpesananitem";
            lblBuatpesananitem.Size = new Size(130, 25);
            lblBuatpesananitem.TabIndex = 3;
            lblBuatpesananitem.Text = "Nama Produk :";
            // 
            // lblBuatPesanan
            // 
            lblBuatPesanan.AutoSize = true;
            lblBuatPesanan.Font = new Font("Segoe UI Semibold", 13.2000008F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblBuatPesanan.Location = new Point(69, 141);
            lblBuatPesanan.Margin = new Padding(4, 0, 4, 0);
            lblBuatPesanan.Name = "lblBuatPesanan";
            lblBuatPesanan.Size = new Size(183, 37);
            lblBuatPesanan.TabIndex = 2;
            lblBuatPesanan.Text = "Buat Pesanan";
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
            // buatPesananForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 700);
            Controls.Add(panel1);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "buatPesananForm";
            Text = "pesananForm";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnExit;
        private Button btnBack;
        private Panel panel3;
        private Panel panel2;
        private Button btnHome;
        private Label lblBuatpesanansts;
        private Label lblBuatpesanantgl;
        private Label lblBuatpesananitem;
        private Label lblBuatPesanan;
        private Button btnPesananbatal;
        private TextBox tbBuatpesanansts;
        private TextBox tbBuatpesanantgl;
        private TextBox tbBuatpesananitem;
        private Button btnBuatpesanan;
        private TextBox tbBuatpesanankrm;
        private Label lblBuatpesanankrm;
    }
}