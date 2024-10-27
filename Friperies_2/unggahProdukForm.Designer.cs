namespace Friperies_2
{
    partial class unggahProdukForm
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
            panel3 = new Panel();
            panel1 = new Panel();
            btnExit = new Button();
            btnLogout = new Button();
            panel2 = new Panel();
            btnHome = new Button();
            pbUnggahitem = new PictureBox();
            tbNamaitem = new TextBox();
            rtbDesitem = new RichTextBox();
            tbKtgitem = new TextBox();
            tbHargaitem = new TextBox();
            lblUnggahnamaitem = new Label();
            lblUnggahdesitem = new Label();
            lblUnggahktgitem = new Label();
            lblUnggahhargaitem = new Label();
            btnUnggahitem = new Button();
            lblUploadpage = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbUnggahitem).BeginInit();
            SuspendLayout();
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
            panel1.TabIndex = 3;
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
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(192, 192, 255);
            panel2.Controls.Add(lblUploadpage);
            panel2.Controls.Add(btnUnggahitem);
            panel2.Controls.Add(lblUnggahhargaitem);
            panel2.Controls.Add(lblUnggahktgitem);
            panel2.Controls.Add(lblUnggahdesitem);
            panel2.Controls.Add(lblUnggahnamaitem);
            panel2.Controls.Add(tbHargaitem);
            panel2.Controls.Add(tbKtgitem);
            panel2.Controls.Add(rtbDesitem);
            panel2.Controls.Add(tbNamaitem);
            panel2.Controls.Add(pbUnggahitem);
            panel2.Controls.Add(btnHome);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(2, 2, 2, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 560);
            panel2.TabIndex = 4;
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
            // pbUnggahitem
            // 
            pbUnggahitem.Location = new Point(69, 152);
            pbUnggahitem.Name = "pbUnggahitem";
            pbUnggahitem.Size = new Size(150, 200);
            pbUnggahitem.TabIndex = 5;
            pbUnggahitem.TabStop = false;
            // 
            // tbNamaitem
            // 
            tbNamaitem.Location = new Point(428, 152);
            tbNamaitem.Name = "tbNamaitem";
            tbNamaitem.Size = new Size(221, 27);
            tbNamaitem.TabIndex = 6;
            // 
            // rtbDesitem
            // 
            rtbDesitem.Location = new Point(428, 196);
            rtbDesitem.Name = "rtbDesitem";
            rtbDesitem.Size = new Size(221, 68);
            rtbDesitem.TabIndex = 7;
            rtbDesitem.Text = "";
            rtbDesitem.TextChanged += rtbDesitem_TextChanged;
            // 
            // tbKtgitem
            // 
            tbKtgitem.Location = new Point(428, 285);
            tbKtgitem.Name = "tbKtgitem";
            tbKtgitem.Size = new Size(221, 27);
            tbKtgitem.TabIndex = 8;
            // 
            // tbHargaitem
            // 
            tbHargaitem.Location = new Point(428, 325);
            tbHargaitem.Name = "tbHargaitem";
            tbHargaitem.Size = new Size(221, 27);
            tbHargaitem.TabIndex = 9;
            // 
            // lblUnggahnamaitem
            // 
            lblUnggahnamaitem.AutoSize = true;
            lblUnggahnamaitem.Location = new Point(263, 152);
            lblUnggahnamaitem.Name = "lblUnggahnamaitem";
            lblUnggahnamaitem.Size = new Size(106, 20);
            lblUnggahnamaitem.TabIndex = 10;
            lblUnggahnamaitem.Text = "Nama Produk :";
            // 
            // lblUnggahdesitem
            // 
            lblUnggahdesitem.AutoSize = true;
            lblUnggahdesitem.Location = new Point(263, 196);
            lblUnggahdesitem.Name = "lblUnggahdesitem";
            lblUnggahdesitem.Size = new Size(76, 20);
            lblUnggahdesitem.TabIndex = 11;
            lblUnggahdesitem.Text = "Deskripsi :";
            // 
            // lblUnggahktgitem
            // 
            lblUnggahktgitem.AutoSize = true;
            lblUnggahktgitem.Location = new Point(263, 285);
            lblUnggahktgitem.Name = "lblUnggahktgitem";
            lblUnggahktgitem.Size = new Size(77, 20);
            lblUnggahktgitem.TabIndex = 12;
            lblUnggahktgitem.Text = "Kategori : ";
            lblUnggahktgitem.Click += lblUnggahktgitem_Click;
            // 
            // lblUnggahhargaitem
            // 
            lblUnggahhargaitem.AutoSize = true;
            lblUnggahhargaitem.Location = new Point(263, 332);
            lblUnggahhargaitem.Name = "lblUnggahhargaitem";
            lblUnggahhargaitem.Size = new Size(57, 20);
            lblUnggahhargaitem.TabIndex = 13;
            lblUnggahhargaitem.Text = "Harga :";
            // 
            // btnUnggahitem
            // 
            btnUnggahitem.Location = new Point(541, 377);
            btnUnggahitem.Name = "btnUnggahitem";
            btnUnggahitem.Size = new Size(108, 36);
            btnUnggahitem.TabIndex = 14;
            btnUnggahitem.Text = "Unggah";
            btnUnggahitem.UseVisualStyleBackColor = true;
            // 
            // lblUploadpage
            // 
            lblUploadpage.AutoSize = true;
            lblUploadpage.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblUploadpage.Location = new Point(24, 84);
            lblUploadpage.Name = "lblUploadpage";
            lblUploadpage.Size = new Size(175, 31);
            lblUploadpage.TabIndex = 15;
            lblUploadpage.Text = "Unggah Produk";
            // 
            // unggahProdukForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 560);
            Controls.Add(panel1);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2, 2, 2, 2);
            Name = "unggahProdukForm";
            Text = "unggahProdukForm";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbUnggahitem).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel3;
        private Panel panel1;
        private Button btnExit;
        private Button btnLogout;
        private Panel panel2;
        private Button btnHome;
        private PictureBox pbUnggahitem;
        private TextBox tbHargaitem;
        private TextBox tbKtgitem;
        private RichTextBox rtbDesitem;
        private TextBox tbNamaitem;
        private Label lblUnggahhargaitem;
        private Label lblUnggahktgitem;
        private Label lblUnggahdesitem;
        private Label lblUnggahnamaitem;
        private Button btnUnggahitem;
        private Label lblUploadpage;
    }
}