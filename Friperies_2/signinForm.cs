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

        User loggedInUser = new User();

        private void btSignIn_Click(object sender, EventArgs e)
        {
            User currentuser = new User();
            currentuser.userName = tbUsername.Text;
            currentuser.userPass = tbPassword.Text;
            if (currentuser.SignIn(tbUsername.Text, tbPassword.Text))
            {
                MessageBox.Show("Sign In Berhasil!");

                loggedInUser = currentuser;

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
