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
            panel1 = new Panel();
            btnExit = new Button();
            btnLogout = new Button();
            panel3 = new Panel();
            panel2 = new Panel();
            btnHome = new Button();
            dataGridView1 = new DataGridView();
            lblOffernamaitem = new Label();
            lblOfferhargaitem = new Label();
            tbOffernamaitem = new TextBox();
            tbOfferhargaitem = new TextBox();
            btnOfferterima = new Button();
            btnOffertolak = new Button();
            btnOfferload = new Button();
            lblOfferpage = new Label();
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
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(107, 232);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(601, 161);
            dataGridView1.TabIndex = 2;
            // 
            // lblOffernamaitem
            // 
            lblOffernamaitem.AutoSize = true;
            lblOffernamaitem.Location = new Point(107, 134);
            lblOffernamaitem.Name = "lblOffernamaitem";
            lblOffernamaitem.Size = new Size(106, 20);
            lblOffernamaitem.TabIndex = 3;
            lblOffernamaitem.Text = "Nama Produk :";
            // 
            // lblOfferhargaitem
            // 
            lblOfferhargaitem.AutoSize = true;
            lblOfferhargaitem.ForeColor = SystemColors.ControlText;
            lblOfferhargaitem.Location = new Point(107, 174);
            lblOfferhargaitem.Name = "lblOfferhargaitem";
            lblOfferhargaitem.Size = new Size(107, 20);
            lblOfferhargaitem.TabIndex = 4;
            lblOfferhargaitem.Text = "Harga Produk :";
            // 
            // tbOffernamaitem
            // 
            tbOffernamaitem.Location = new Point(251, 131);
            tbOffernamaitem.Name = "tbOffernamaitem";
            tbOffernamaitem.Size = new Size(211, 27);
            tbOffernamaitem.TabIndex = 5;
            // 
            // tbOfferhargaitem
            // 
            tbOfferhargaitem.Location = new Point(251, 171);
            tbOfferhargaitem.Name = "tbOfferhargaitem";
            tbOfferhargaitem.Size = new Size(211, 27);
            tbOfferhargaitem.TabIndex = 6;
            // 
            // btnOfferterima
            // 
            btnOfferterima.Location = new Point(519, 131);
            btnOfferterima.Name = "btnOfferterima";
            btnOfferterima.Size = new Size(119, 34);
            btnOfferterima.TabIndex = 7;
            btnOfferterima.Text = "Terima";
            btnOfferterima.UseVisualStyleBackColor = true;
            // 
            // btnOffertolak
            // 
            btnOffertolak.Location = new Point(519, 171);
            btnOffertolak.Name = "btnOffertolak";
            btnOffertolak.Size = new Size(119, 34);
            btnOffertolak.TabIndex = 8;
            btnOffertolak.Text = "Tolak";
            btnOffertolak.UseVisualStyleBackColor = true;
            btnOffertolak.Click += btnOffertolak_Click;
            // 
            // btnOfferload
            // 
            btnOfferload.Location = new Point(561, 410);
            btnOfferload.Name = "btnOfferload";
            btnOfferload.Size = new Size(147, 31);
            btnOfferload.TabIndex = 9;
            btnOfferload.Text = "Muat Penawaran";
            btnOfferload.UseVisualStyleBackColor = true;
            // 
            // lblOfferpage
            // 
            lblOfferpage.AutoSize = true;
            lblOfferpage.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblOfferpage.Location = new Point(12, 79);
            lblOfferpage.Name = "lblOfferpage";
            lblOfferpage.Size = new Size(131, 31);
            lblOfferpage.TabIndex = 10;
            lblOfferpage.Text = "Penawaran";
            // 
            // penawaranForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 560);
            Controls.Add(panel1);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2, 2, 2, 2);
            Name = "penawaranForm";
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
        private Button btnLogout;
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
    }
}