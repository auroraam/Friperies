namespace Friperies_2
{
    partial class homePageForm
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
            panel2 = new Panel();
            btnLihatProduk = new Button();
            btnProfil = new Button();
            btnUnggahProduk = new Button();
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
            panel3.Size = new Size(255, 52);
            panel3.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(btnExit);
            panel1.Controls.Add(panel3);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1000, 74);
            panel1.TabIndex = 1;
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
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(192, 192, 255);
            panel2.Controls.Add(btnLihatProduk);
            panel2.Controls.Add(btnProfil);
            panel2.Controls.Add(btnUnggahProduk);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new Size(1000, 700);
            panel2.TabIndex = 2;
            // 
            // btnLihatProduk
            // 
            btnLihatProduk.FlatAppearance.BorderSize = 3;
            btnLihatProduk.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLihatProduk.Image = Properties.Resources.cargo_3045489__1_;
            btnLihatProduk.ImageAlign = ContentAlignment.TopCenter;
            btnLihatProduk.Location = new Point(372, 294);
            btnLihatProduk.Margin = new Padding(2);
            btnLihatProduk.Name = "btnLihatProduk";
            btnLihatProduk.Size = new Size(235, 142);
            btnLihatProduk.TabIndex = 5;
            btnLihatProduk.Text = "Lihat Produk";
            btnLihatProduk.TextAlign = ContentAlignment.BottomCenter;
            btnLihatProduk.TextImageRelation = TextImageRelation.ImageAboveText;
            btnLihatProduk.UseVisualStyleBackColor = true;
            btnLihatProduk.Click += btnLihatProduk_Click;
            // 
            // btnProfil
            // 
            btnProfil.FlatAppearance.BorderSize = 3;
            btnProfil.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnProfil.Image = Properties.Resources.user_7855633__1_;
            btnProfil.ImageAlign = ContentAlignment.TopCenter;
            btnProfil.Location = new Point(658, 294);
            btnProfil.Margin = new Padding(2);
            btnProfil.Name = "btnProfil";
            btnProfil.Size = new Size(235, 142);
            btnProfil.TabIndex = 4;
            btnProfil.Text = "Profil";
            btnProfil.TextAlign = ContentAlignment.BottomCenter;
            btnProfil.TextImageRelation = TextImageRelation.ImageAboveText;
            btnProfil.UseVisualStyleBackColor = true;
            btnProfil.Click += btnProfil_Click;
            // 
            // btnUnggahProduk
            // 
            btnUnggahProduk.FlatAppearance.BorderSize = 3;
            btnUnggahProduk.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnUnggahProduk.Image = Properties.Resources.uploading_3305741__1___3_;
            btnUnggahProduk.ImageAlign = ContentAlignment.TopCenter;
            btnUnggahProduk.Location = new Point(82, 294);
            btnUnggahProduk.Margin = new Padding(2);
            btnUnggahProduk.Name = "btnUnggahProduk";
            btnUnggahProduk.Size = new Size(235, 142);
            btnUnggahProduk.TabIndex = 0;
            btnUnggahProduk.Text = "Unggah Produk";
            btnUnggahProduk.TextAlign = ContentAlignment.BottomCenter;
            btnUnggahProduk.TextImageRelation = TextImageRelation.ImageAboveText;
            btnUnggahProduk.UseVisualStyleBackColor = true;
            btnUnggahProduk.Click += btnUnggahProduk_Click;
            // 
            // homePageForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 700);
            Controls.Add(panel1);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "homePageForm";
            Text = "homePageForm";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel3;
        private Panel panel1;
        private Button btnExit;
        private Panel panel2;
        private Button btnUnggahProduk;
        private Button btnLihatProduk;
        private Button btnProfil;
    }
}