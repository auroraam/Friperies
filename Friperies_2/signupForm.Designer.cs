namespace Friperies_2
{
    partial class signupForm
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
            btnExit = new Button();
            pnlLogo = new Panel();
            pnlFriperies = new Panel();
            lblUsername = new Label();
            tbUsername = new TextBox();
            lblAlamat = new Label();
            tbAlamat = new TextBox();
            lblEmail = new Label();
            tbEmail = new TextBox();
            tbPassword = new TextBox();
            lblPassword = new Label();
            btnSignUp = new Button();
            btnSignIn = new Button();
            SuspendLayout();
            // 
            // btnExit
            // 
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnExit.Image = Properties.Resources.cancel_5697779__1_;
            btnExit.Location = new Point(933, 8);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(55, 55);
            btnExit.TabIndex = 30;
            btnExit.Text = " ";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // pnlLogo
            // 
            pnlLogo.Anchor = AnchorStyles.Top;
            pnlLogo.BackgroundImage = Properties.Resources.logo__1_;
            pnlLogo.Location = new Point(388, 44);
            pnlLogo.Name = "pnlLogo";
            pnlLogo.Size = new Size(145, 150);
            pnlLogo.TabIndex = 31;
            // 
            // pnlFriperies
            // 
            pnlFriperies.BackgroundImage = Properties.Resources.friperies__4_;
            pnlFriperies.Location = new Point(350, 200);
            pnlFriperies.Name = "pnlFriperies";
            pnlFriperies.Size = new Size(227, 64);
            pnlFriperies.TabIndex = 19;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Verdana", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUsername.Location = new Point(245, 276);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(132, 26);
            lblUsername.TabIndex = 32;
            lblUsername.Text = "Username:";
            // 
            // tbUsername
            // 
            tbUsername.BackColor = Color.White;
            tbUsername.Location = new Point(245, 305);
            tbUsername.Name = "tbUsername";
            tbUsername.Size = new Size(491, 31);
            tbUsername.TabIndex = 33;
            // 
            // lblAlamat
            // 
            lblAlamat.AutoSize = true;
            lblAlamat.Font = new Font("Verdana", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAlamat.Location = new Point(245, 464);
            lblAlamat.Name = "lblAlamat";
            lblAlamat.Size = new Size(99, 26);
            lblAlamat.TabIndex = 38;
            lblAlamat.Text = "Alamat:";
            // 
            // tbAlamat
            // 
            tbAlamat.BackColor = Color.White;
            tbAlamat.Location = new Point(245, 493);
            tbAlamat.Name = "tbAlamat";
            tbAlamat.Size = new Size(491, 31);
            tbAlamat.TabIndex = 39;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Verdana", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEmail.Location = new Point(245, 338);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(82, 26);
            lblEmail.TabIndex = 36;
            lblEmail.Text = "Email:";
            // 
            // tbEmail
            // 
            tbEmail.BackColor = Color.White;
            tbEmail.Location = new Point(245, 367);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(491, 31);
            tbEmail.TabIndex = 37;
            // 
            // tbPassword
            // 
            tbPassword.Location = new Point(245, 430);
            tbPassword.Name = "tbPassword";
            tbPassword.Size = new Size(491, 31);
            tbPassword.TabIndex = 35;
            tbPassword.UseSystemPasswordChar = true;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Verdana", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPassword.Location = new Point(245, 401);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(123, 26);
            lblPassword.TabIndex = 34;
            lblPassword.Text = "Password:";
            // 
            // btnSignUp
            // 
            btnSignUp.BackColor = Color.FromArgb(192, 192, 255);
            btnSignUp.Font = new Font("Verdana", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSignUp.Location = new Point(389, 535);
            btnSignUp.Name = "btnSignUp";
            btnSignUp.Size = new Size(145, 42);
            btnSignUp.TabIndex = 40;
            btnSignUp.Text = "Sign Up";
            btnSignUp.UseVisualStyleBackColor = false;
            btnSignUp.Click += btnSignUp_Click;
            // 
            // btnSignIn
            // 
            btnSignIn.BackColor = Color.White;
            btnSignIn.FlatAppearance.BorderSize = 0;
            btnSignIn.FlatStyle = FlatStyle.Flat;
            btnSignIn.Font = new Font("Verdana", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSignIn.Location = new Point(120, 574);
            btnSignIn.Name = "btnSignIn";
            btnSignIn.Size = new Size(742, 49);
            btnSignIn.TabIndex = 41;
            btnSignIn.Text = "Sudah punya akun? Masuk ke akunmu, klik disini.";
            btnSignIn.UseVisualStyleBackColor = false;
            btnSignIn.Click += btnSignIn_Click;
            // 
            // signupForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1000, 700);
            Controls.Add(btnSignUp);
            Controls.Add(btnSignIn);
            Controls.Add(lblAlamat);
            Controls.Add(tbAlamat);
            Controls.Add(lblEmail);
            Controls.Add(tbEmail);
            Controls.Add(tbPassword);
            Controls.Add(lblPassword);
            Controls.Add(tbUsername);
            Controls.Add(lblUsername);
            Controls.Add(pnlFriperies);
            Controls.Add(pnlLogo);
            Controls.Add(btnExit);
            FormBorderStyle = FormBorderStyle.None;
            Name = "signupForm";
            Text = "signupForm";
            Load += signupForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnExit;
        private Panel pnlLogo;
        private Panel pnlFriperies;
        private Label lblUsername;
        private TextBox tbUsername;
        private Label lblAlamat;
        private TextBox tbAlamat;
        private Label lblEmail;
        private TextBox tbEmail;
        private TextBox tbPassword;
        private Label lblPassword;
        private Button btnSignUp;
        private Button btnSignIn;
    }
}