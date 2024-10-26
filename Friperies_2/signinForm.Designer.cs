namespace Friperies_2
{
    partial class signinForm
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
            lblPassword = new Label();
            tbUsername = new TextBox();
            tbPassword = new TextBox();
            btSignIn = new Button();
            btSignUp = new Button();
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
            btnExit.TabIndex = 9;
            btnExit.Text = " ";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += this.btnExit_Click;
            // 
            // pnlLogo
            // 
            pnlLogo.Anchor = AnchorStyles.Top;
            pnlLogo.BackgroundImage = Properties.Resources.logo__1_;
            pnlLogo.Location = new Point(388, 44);
            pnlLogo.Name = "pnlLogo";
            pnlLogo.Size = new Size(145, 150);
            pnlLogo.TabIndex = 10;
            // 
            // pnlFriperies
            // 
            pnlFriperies.BackgroundImage = Properties.Resources.friperies__4_;
            pnlFriperies.Location = new Point(350, 200);
            pnlFriperies.Name = "pnlFriperies";
            pnlFriperies.Size = new Size(227, 64);
            pnlFriperies.TabIndex = 11;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUsername.Location = new Point(246, 296);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(145, 29);
            lblUsername.TabIndex = 12;
            lblUsername.Text = "Username:";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPassword.Location = new Point(246, 373);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(137, 29);
            lblPassword.TabIndex = 13;
            lblPassword.Text = "Password:";
            // 
            // tbUsername
            // 
            tbUsername.BackColor = Color.White;
            tbUsername.Location = new Point(246, 328);
            tbUsername.Name = "tbUsername";
            tbUsername.Size = new Size(491, 31);
            tbUsername.TabIndex = 14;
            // 
            // tbPassword
            // 
            tbPassword.Location = new Point(246, 405);
            tbPassword.Name = "tbPassword";
            tbPassword.Size = new Size(491, 31);
            tbPassword.TabIndex = 15;
            tbPassword.UseSystemPasswordChar = true;
            // 
            // btSignIn
            // 
            btSignIn.BackColor = Color.FromArgb(192, 192, 255);
            btSignIn.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btSignIn.Location = new Point(389, 462);
            btSignIn.Name = "btSignIn";
            btSignIn.Size = new Size(140, 49);
            btSignIn.TabIndex = 16;
            btSignIn.Text = "Sign In";
            btSignIn.UseVisualStyleBackColor = false;
            // 
            // btSignUp
            // 
            btSignUp.BackColor = Color.White;
            btSignUp.FlatAppearance.BorderSize = 0;
            btSignUp.FlatStyle = FlatStyle.Flat;
            btSignUp.Font = new Font("Verdana", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btSignUp.Location = new Point(115, 517);
            btSignUp.Name = "btSignUp";
            btSignUp.Size = new Size(742, 49);
            btSignUp.TabIndex = 17;
            btSignUp.Text = "Belum punya akun? Daftarkan akunmu sekarang, klik disini.";
            btSignUp.UseVisualStyleBackColor = false;
            // 
            // signinForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1000, 700);
            Controls.Add(btSignUp);
            Controls.Add(btSignIn);
            Controls.Add(tbPassword);
            Controls.Add(tbUsername);
            Controls.Add(lblPassword);
            Controls.Add(lblUsername);
            Controls.Add(pnlLogo);
            Controls.Add(btnExit);
            Controls.Add(pnlFriperies);
            FormBorderStyle = FormBorderStyle.None;
            Name = "signinForm";
            Text = "signupForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnExit;
        private Panel pnlLogo;
        private Panel pnlFriperies;
        private Label lblUsername;
        private Label lblPassword;
        private TextBox tbUsername;
        private TextBox tbPassword;
        private Button btSignIn;
        private Button btSignUp;
    }
}