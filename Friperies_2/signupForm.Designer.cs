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
            pnlLogo = new Panel();
            btnSignIn = new Button();
            btnSignUp = new Button();
            tbPassword = new TextBox();
            tbUsername = new TextBox();
            lblPassword = new Label();
            lblUsername = new Label();
            pnlFriperies = new Panel();
            lblEmail = new Label();
            tbEmail = new TextBox();
            lblAlamat = new Label();
            tbAlamat = new TextBox();
            btnExit = new Button();
            SuspendLayout();
            // 
            // pnlLogo
            // 
            pnlLogo.Anchor = AnchorStyles.Top;
            pnlLogo.BackgroundImage = Properties.Resources.logo__1_;
            pnlLogo.Location = new Point(388, 44);
            pnlLogo.Name = "pnlLogo";
            pnlLogo.Size = new Size(145, 150);
            pnlLogo.TabIndex = 11;
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
            btnSignIn.TabIndex = 24;
            btnSignIn.Text = "Sudah punya akun? Masuk ke akunmu, klik disini.";
            btnSignIn.UseVisualStyleBackColor = false;
            btnSignIn.Click += btnSignIn_Click;
            // 
            // btnSignUp
            // 
            btnSignUp.BackColor = Color.FromArgb(192, 192, 255);
            btnSignUp.Font = new Font("Verdana", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSignUp.Location = new Point(389, 535);
            btnSignUp.Name = "btnSignUp";
            btnSignUp.Size = new Size(145, 42);
            btnSignUp.TabIndex = 23;
            btnSignUp.Text = "Sign Up";
            btnSignUp.UseVisualStyleBackColor = false;
            btnSignUp.Click += this.btnSignUp_Click;
            // 
            // tbPassword
            // 
            tbPassword.Location = new Point(245, 431);
            tbPassword.Name = "tbPassword";
            tbPassword.Size = new Size(491, 31);
            tbPassword.TabIndex = 22;
            tbPassword.UseSystemPasswordChar = true;
            // 
            // tbUsername
            // 
            tbUsername.BackColor = Color.White;
            tbUsername.Location = new Point(245, 305);
            tbUsername.Name = "tbUsername";
            tbUsername.Size = new Size(491, 31);
            tbUsername.TabIndex = 21;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Verdana", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPassword.Location = new Point(245, 402);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(123, 26);
            lblPassword.TabIndex = 20;
            lblPassword.Text = "Password:";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Verdana", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUsername.Location = new Point(245, 276);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(132, 26);
            lblUsername.TabIndex = 19;
            lblUsername.Text = "Username:";
            // 
            // pnlFriperies
            // 
            pnlFriperies.BackgroundImage = Properties.Resources.friperies__4_;
            pnlFriperies.Location = new Point(350, 200);
            pnlFriperies.Name = "pnlFriperies";
            pnlFriperies.Size = new Size(227, 64);
            pnlFriperies.TabIndex = 18;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Verdana", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEmail.Location = new Point(245, 339);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(82, 26);
            lblEmail.TabIndex = 25;
            lblEmail.Text = "Email:";
            // 
            // tbEmail
            // 
            tbEmail.BackColor = Color.White;
            tbEmail.Location = new Point(245, 368);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(491, 31);
            tbEmail.TabIndex = 26;
            // 
            // lblAlamat
            // 
            lblAlamat.AutoSize = true;
            lblAlamat.Font = new Font("Verdana", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAlamat.Location = new Point(245, 465);
            lblAlamat.Name = "lblAlamat";
            lblAlamat.Size = new Size(99, 26);
            lblAlamat.TabIndex = 27;
            lblAlamat.Text = "Alamat:";
            // 
            // tbAlamat
            // 
            tbAlamat.BackColor = Color.White;
            tbAlamat.Location = new Point(245, 494);
            tbAlamat.Name = "tbAlamat";
            tbAlamat.Size = new Size(491, 31);
            tbAlamat.TabIndex = 28;
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
            btnExit.TabIndex = 29;
            btnExit.Text = " ";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += this.btnExit_Click;
            // 
            // signupForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1000, 700);
            Controls.Add(btnExit);
            Controls.Add(lblAlamat);
            Controls.Add(tbAlamat);
            Controls.Add(lblEmail);
            Controls.Add(tbEmail);
            Controls.Add(pnlLogo);
            Controls.Add(btnSignUp);
            Controls.Add(pnlFriperies);
            Controls.Add(tbPassword);
            Controls.Add(lblUsername);
            Controls.Add(tbUsername);
            Controls.Add(lblPassword);
            Controls.Add(btnSignIn);
            FormBorderStyle = FormBorderStyle.None;
            Name = "signupForm";
            Text = "signupForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlLogo;
        private Button btnSignIn;
        private Button btnSignUp;
        private TextBox tbPassword;
        private TextBox tbUsername;
        private Label lblPassword;
        private Label lblUsername;
        private Panel pnlFriperies;
        private Label lblEmail;
        private TextBox tbEmail;
        private Label lblAlamat;
        private TextBox tbAlamat;
        private Button btnExit;
    }
}