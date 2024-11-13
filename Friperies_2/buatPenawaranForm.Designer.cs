namespace Friperies_2
{
    partial class buatPenawaranForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(buatPenawaranForm));
            panel3 = new Panel();
            panel1 = new Panel();
            btnExit = new Button();
            btnBack = new Button();
            panel2 = new Panel();
            lblMakeOfferpage = new Label();
            tbHargaawal = new TextBox();
            tbOffernamaitem = new TextBox();
            lblOfferhargaitem = new Label();
            lblOffernamaitem = new Label();
            btnHome = new Button();
            tbOfferprice = new TextBox();
            lblOfferprice = new Label();
            btnBuatpenawaran = new Button();
            btnPenawaranbatal = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.BackgroundImage = Properties.Resources.Screenshot_2024_10_20_at_17_40_01_removebg_preview__1_;
            panel3.Location = new Point(8, 8);
            panel3.Margin = new Padding(2);
            panel3.Name = "panel3";
            panel3.Size = new Size(204, 42);
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
            panel1.TabIndex = 6;
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
            btnBack.Click += btnBack_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(192, 192, 255);
            panel2.Controls.Add(btnBuatpenawaran);
            panel2.Controls.Add(btnPenawaranbatal);
            panel2.Controls.Add(tbOfferprice);
            panel2.Controls.Add(lblOfferprice);
            panel2.Controls.Add(lblMakeOfferpage);
            panel2.Controls.Add(tbHargaawal);
            panel2.Controls.Add(tbOffernamaitem);
            panel2.Controls.Add(lblOfferhargaitem);
            panel2.Controls.Add(lblOffernamaitem);
            panel2.Controls.Add(btnHome);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 560);
            panel2.TabIndex = 7;
            // 
            // lblMakeOfferpage
            // 
            lblMakeOfferpage.AutoSize = true;
            lblMakeOfferpage.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblMakeOfferpage.Location = new Point(60, 131);
            lblMakeOfferpage.Name = "lblMakeOfferpage";
            lblMakeOfferpage.Size = new Size(185, 31);
            lblMakeOfferpage.TabIndex = 10;
            lblMakeOfferpage.Text = "Buat Penawaran";
            // 
            // tbHargaawal
            // 
            tbHargaawal.Location = new Point(199, 246);
            tbHargaawal.Name = "tbHargaawal";
            tbHargaawal.Size = new Size(347, 27);
            tbHargaawal.TabIndex = 6;
            // 
            // tbOffernamaitem
            // 
            tbOffernamaitem.Location = new Point(199, 196);
            tbOffernamaitem.Name = "tbOffernamaitem";
            tbOffernamaitem.Size = new Size(347, 27);
            tbOffernamaitem.TabIndex = 5;
            // 
            // lblOfferhargaitem
            // 
            lblOfferhargaitem.AutoSize = true;
            lblOfferhargaitem.ForeColor = SystemColors.ControlText;
            lblOfferhargaitem.Location = new Point(60, 246);
            lblOfferhargaitem.Name = "lblOfferhargaitem";
            lblOfferhargaitem.Size = new Size(94, 20);
            lblOfferhargaitem.TabIndex = 4;
            lblOfferhargaitem.Text = "Harga Awal :";
            // 
            // lblOffernamaitem
            // 
            lblOffernamaitem.AutoSize = true;
            lblOffernamaitem.Location = new Point(60, 196);
            lblOffernamaitem.Name = "lblOffernamaitem";
            lblOffernamaitem.Size = new Size(106, 20);
            lblOffernamaitem.TabIndex = 3;
            lblOffernamaitem.Text = "Nama Produk :";
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
            // tbOfferprice
            // 
            tbOfferprice.Location = new Point(199, 295);
            tbOfferprice.Name = "tbOfferprice";
            tbOfferprice.Size = new Size(347, 27);
            tbOfferprice.TabIndex = 12;
            // 
            // lblOfferprice
            // 
            lblOfferprice.AutoSize = true;
            lblOfferprice.ForeColor = SystemColors.ControlText;
            lblOfferprice.Location = new Point(60, 295);
            lblOfferprice.Name = "lblOfferprice";
            lblOfferprice.Size = new Size(132, 20);
            lblOfferprice.TabIndex = 11;
            lblOfferprice.Text = "Harga Penawaran :";
            // 
            // btnBuatpenawaran
            // 
            btnBuatpenawaran.BackColor = Color.White;
            btnBuatpenawaran.Location = new Point(414, 367);
            btnBuatpenawaran.Name = "btnBuatpenawaran";
            btnBuatpenawaran.Size = new Size(132, 33);
            btnBuatpenawaran.TabIndex = 14;
            btnBuatpenawaran.Text = "Buat Penawaran";
            btnBuatpenawaran.UseVisualStyleBackColor = false;
            btnBuatpenawaran.Click += btnBuatpenawaran_Click;
            // 
            // btnPenawaranbatal
            // 
            btnPenawaranbatal.BackColor = Color.FromArgb(255, 128, 128);
            btnPenawaranbatal.Location = new Point(224, 367);
            btnPenawaranbatal.Name = "btnPenawaranbatal";
            btnPenawaranbatal.Size = new Size(159, 33);
            btnPenawaranbatal.TabIndex = 13;
            btnPenawaranbatal.Text = "Batalkan Penawaran";
            btnPenawaranbatal.UseVisualStyleBackColor = false;
            btnPenawaranbatal.Click += btnPenawaranbatal_Click;
            // 
            // buatPenawaranForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 560);
            Controls.Add(panel1);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "buatPenawaranForm";
            Text = "buatPenawaranForm";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel3;
        private Panel panel1;
        private Button btnExit;
        private Button btnBack;
        private Panel panel2;
        private TextBox tbOfferprice;
        private Label lblOfferprice;
        private Label lblMakeOfferpage;
        private TextBox tbHargaawal;
        private TextBox tbOffernamaitem;
        private Label lblOfferhargaitem;
        private Label lblOffernamaitem;
        private Button btnHome;
        private Button btnBuatpenawaran;
        private Button btnPenawaranbatal;
    }
}