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
    public partial class signinForm : Form
    {
        public signinForm()
        {
            InitializeComponent();
        }

        public User loggedInUser = new User();

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btSignIn_Click_1(object sender, EventArgs e)
        {
            string userName = tbUsername.Text;
            string userPass = tbPassword.Text;

            if (string.IsNullOrWhiteSpace(userName) || string.IsNullOrWhiteSpace(userPass))
            {
                MessageBox.Show("Username dan Password harus diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string connString = dbConfig.ConnectionString;
            using (NpgsqlConnection conn = new NpgsqlConnection(connString))
            {
                try
                {
                    conn.Open();
                    string query = @"SELECT * FROM public.""User"" WHERE ""UserName"" = @UserName AND ""UserPass"" = @UserPass";
                    using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@UserName", userName);
                        cmd.Parameters.AddWithValue("@UserPass", userPass);

                        using (NpgsqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Jika berhasil login, simpan informasi pengguna
                                loggedInUser.userID = reader.GetInt32(reader.GetOrdinal("UserID"));
                                loggedInUser.userEmail = reader.GetString(reader.GetOrdinal("UserEmail"));

                                // Set informasi login pada objek loggedInUser
                                loggedInUser.userName = userName;
                                loggedInUser.userPass = userPass;

                                // Pindah ke homeForm setelah berhasil sign in
                                this.Hide();
                                homePageForm homePageForm = new homePageForm(loggedInUser);
                                homePageForm.Show();
                            }
                            else
                            {
                                MessageBox.Show("Username atau Password salah. Coba lagi.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void btSignUp_Click(object sender, EventArgs e)
        {
            this.Hide();
            signupForm signupForm = new signupForm();
            signupForm.Show();
        }

        private void signinForm_Load(object sender, EventArgs e)
        {

        }
    }
}
