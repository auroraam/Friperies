using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace Friperies_2
{
    public partial class signupForm : Form
    {
        public signupForm()
        {
            InitializeComponent();
        }

        private void signupForm_Load(object sender, EventArgs e)
        {

        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            this.Hide();
            signinForm signinForm = new signinForm();
            signinForm.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            string userName = tbUsername.Text;
            string userEmail = tbEmail.Text;
            string userPass = tbPassword.Text;
            string userAddress = tbAlamat.Text;

            if (string.IsNullOrWhiteSpace(userName) || string.IsNullOrWhiteSpace(userEmail) || string.IsNullOrWhiteSpace(userPass) || string.IsNullOrWhiteSpace(userAddress))
            {
                MessageBox.Show("Semua field harus diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string connString = "Host=localhost;Port=5432;Username=postgres;Password=xxx;Database=friperiesfix";
            using (NpgsqlConnection conn = new NpgsqlConnection(connString))
            {
                try
                {
                    conn.Open();

                    string checkQuery = @"SELECT COUNT(*) FROM public.""User"" WHERE ""UserEmail"" = @UserEmail";
                    using (NpgsqlCommand checkCmd = new NpgsqlCommand(checkQuery, conn))
                    {
                        checkCmd.Parameters.AddWithValue("@UserEmail", userEmail);
                        int emailCount = Convert.ToInt32(checkCmd.ExecuteScalar());

                        if (emailCount > 0)
                        {
                            MessageBox.Show("Email sudah terdaftar. Gunakan email lain.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        else
                        {
                            // Query insert dengan UserID yang auto-generate menggunakan serial/sequence
                            string query = @"
                            INSERT INTO public.""User"" (""UserName"", ""UserEmail"", ""UserPass"", ""UserAddress"")
                            VALUES (@UserName, @UserEmail, @UserPass, @UserAddress)";

                            using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                            {
                                cmd.Parameters.AddWithValue("@UserName", userName);
                                cmd.Parameters.AddWithValue("@UserEmail", userEmail);
                                cmd.Parameters.AddWithValue("@UserPass", userPass);
                                cmd.Parameters.AddWithValue("@UserAddress", userAddress);
                                cmd.ExecuteNonQuery();

                                MessageBox.Show("Sign up berhasil!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Hide();
                                signinForm signinForm = new signinForm();
                                signinForm.Show();
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
