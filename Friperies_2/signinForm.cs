using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Friperies_2
{
    public partial class signinForm : Form
    {
        public signinForm()
        {
            InitializeComponent();
        }

        private void btSignIn_Click(object sender, EventArgs e)
        {
            User user = new User(tbUsername.Text, tbPassword.Text);
            
            if (user.SignIn(user._userName, user._userPass))
            {
                MessageBox.Show("Sign In Berhasil!");

                this.Hide();
                homeForm homeForm = new homeForm();
                homeForm.Show();
            }
            else
            {
                MessageBox.Show("Sign In Gagal.");
            }
        }

        private void btSignUp_Click(object sender, EventArgs e)
        {
            this.Hide();
            signupForm signupForm = new signupForm();
            signupForm.Show();
        }
        private void btnExit_Click (object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
