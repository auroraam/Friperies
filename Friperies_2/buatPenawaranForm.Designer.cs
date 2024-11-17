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
            btnBuatpenawaran = new Button();
            btnPenawaranbatal = new Button();
            tbOfferprice = new TextBox();
            lblOfferprice = new Label();
            lblMakeOfferpage = new Label();
            tbHargaawal = new TextBox();
            tbOffernamaitem = new TextBox();
            lblOfferhargaitem = new Label();
            lblOffernamaitem = new Label();
            btnHome = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.BackgroundImage = Properties.Resources.Screenshot_2024_10_20_at_17_40_01_removebg_preview__1_;
            panel3.Location = new Point(10, 10);
            panel3.Margin = new Padding(2);
            panel3.Name = "panel3";
            panel3.Size = new Size(205, 52);
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
            panel2.Size = new Size(1000, 700);
            panel2.TabIndex = 7;
            // 
            // btnBuatpenawaran
            // 
            btnBuatpenawaran.BackColor = Color.White;
            btnBuatpenawaran.Location = new Point(518, 459);
            btnBuatpenawaran.Margin = new Padding(4, 4, 4, 4);
            btnBuatpenawaran.Name = "btnBuatpenawaran";
            btnBuatpenawaran.Size = new Size(165, 41);
            btnBuatpenawaran.TabIndex = 14;
            btnBuatpenawaran.Text = "Buat Penawaran";
            btnBuatpenawaran.UseVisualStyleBackColor = false;
            btnBuatpenawaran.Click += btnBuatpenawaran_Click;
            // 
            // btnPenawaranbatal
            // 
            btnPenawaranbatal.BackColor = Color.FromArgb(255, 128, 128);
            btnPenawaranbatal.Location = new Point(280, 459);
            btnPenawaranbatal.Margin = new Padding(4, 4, 4, 4);
            btnPenawaranbatal.Name = "btnPenawaranbatal";
            btnPenawaranbatal.Size = new Size(199, 41);
            btnPenawaranbatal.TabIndex = 13;
            btnPenawaranbatal.Text = "Batalkan Penawaran";
            btnPenawaranbatal.UseVisualStyleBackColor = false;
            btnPenawaranbatal.Click += btnPenawaranbatal_Click;
            // 
            // tbOfferprice
            // 
            tbOfferprice.Location = new Point(249, 369);
            tbOfferprice.Margin = new Padding(4, 4, 4, 4);
            tbOfferprice.Name = "tbOfferprice";
            tbOfferprice.Size = new Size(433, 31);
            tbOfferprice.TabIndex = 12;
            // 
            // lblOfferprice
            // 
            lblOfferprice.AutoSize = true;
            lblOfferprice.ForeColor = SystemColors.ControlText;
            lblOfferprice.Location = new Point(75, 369);
            lblOfferprice.Margin = new Padding(4, 0, 4, 0);
            lblOfferprice.Name = "lblOfferprice";
            lblOfferprice.Size = new Size(158, 25);
            lblOfferprice.TabIndex = 11;
            lblOfferprice.Text = "Harga Penawaran :";
            // 
            // lblMakeOfferpage
            // 
            lblMakeOfferpage.AutoSize = true;
            lblMakeOfferpage.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblMakeOfferpage.Location = new Point(75, 164);
            lblMakeOfferpage.Margin = new Padding(4, 0, 4, 0);
            lblMakeOfferpage.Name = "lblMakeOfferpage";
            lblMakeOfferpage.Size = new Size(227, 38);
            lblMakeOfferpage.TabIndex = 10;
            lblMakeOfferpage.Text = "Buat Penawaran";
            // 
            // tbHargaawal
            // 
            tbHargaawal.Location = new Point(249, 308);
            tbHargaawal.Margin = new Padding(4, 4, 4, 4);
            tbHargaawal.Name = "tbHargaawal";
            tbHargaawal.Size = new Size(433, 31);
            tbHargaawal.TabIndex = 6;
            // 
            // tbOffernamaitem
            // 
            tbOffernamaitem.Location = new Point(249, 245);
            tbOffernamaitem.Margin = new Padding(4, 4, 4, 4);
            tbOffernamaitem.Name = "tbOffernamaitem";
            tbOffernamaitem.Size = new Size(433, 31);
            tbOffernamaitem.TabIndex = 5;
            // 
            // lblOfferhargaitem
            // 
            lblOfferhargaitem.AutoSize = true;
            lblOfferhargaitem.ForeColor = SystemColors.ControlText;
            lblOfferhargaitem.Location = new Point(75, 308);
            lblOfferhargaitem.Margin = new Padding(4, 0, 4, 0);
            lblOfferhargaitem.Name = "lblOfferhargaitem";
            lblOfferhargaitem.Size = new Size(112, 25);
            lblOfferhargaitem.TabIndex = 4;
            lblOfferhargaitem.Text = "Harga Awal :";
            // 
            // lblOffernamaitem
            // 
            lblOffernamaitem.AutoSize = true;
            lblOffernamaitem.Location = new Point(75, 245);
            lblOffernamaitem.Margin = new Padding(4, 0, 4, 0);
            lblOffernamaitem.Name = "lblOffernamaitem";
            lblOffernamaitem.Size = new Size(130, 25);
            lblOffernamaitem.TabIndex = 3;
            lblOffernamaitem.Text = "Nama Produk :";
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
            // buatPenawaranForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 700);
            Controls.Add(panel1);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 4, 4, 4);
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