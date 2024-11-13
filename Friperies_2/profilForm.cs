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
    public partial class profilForm : Form
    {
        public User loggedInUser;
        public profilForm(User user)
        {
            InitializeComponent();
            loggedInUser = user;
            tbUsername.Text = loggedInUser.userName;
        }

        private void tbUsername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                MessageBox.Show("Username telah diubah. Apakah Anda setuju untuk mengubah Username?", "Ubah Username", MessageBoxButtons.YesNo);
                if (DialogResult == DialogResult.Yes)
                {
                    string newUsername = tbUsername.Text;
                    int userId = loggedInUser.userID; // Ganti dengan ID atau data spesifik pengguna

                    MessageBox.Show("UserID: " + userId + ", New Username: " + newUsername);
                    // String koneksi PostgreSQL
                    string connectionString = "Host=5432;Username=postgres;Password=feather0325;Database=friperiesfix";

                    using (NpgsqlConnection conn = new NpgsqlConnection(connectionString))
                    {
                        try
                        {
                            conn.Open();
                            string query = @"UPDATE public.""User"" SET ""UserName"" = @UserName WHERE ""UserID"" = @UserID";
                            using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                            {
                                cmd.Parameters.AddWithValue("@UserName", newUsername);
                                cmd.Parameters.AddWithValue("@UserID", userId);

                                int rowsAffected = cmd.ExecuteNonQuery();
                                MessageBox.Show("Rows affected: " + rowsAffected.ToString());
                                if (rowsAffected > 0)
                                {
                                    MessageBox.Show("Username berhasil diubah.");
                                }
                                else
                                {
                                    MessageBox.Show("Gagal mengubah Username.");
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Terjadi kesalahan: " + ex.Message);
                        }
                    }
                }
            }
        }

        private void tbEmail_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                MessageBox.Show("Ubah Email", "Email telah diubah. Apakah Anda setuju untuk mengubah Email?", MessageBoxButtons.YesNo);
                if (DialogResult == DialogResult.Yes)
                {
                    //ubah email di db
                }
            }
        }

        private void tbPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                MessageBox.Show("Ubah Password", "Password telah diubah. Apakah Anda setuju untuk mengubah Username?", MessageBoxButtons.YesNo);
                if (DialogResult == DialogResult.Yes)
                {
                    //ubah password di db
                }
            }
        }

        private void tbAlamat_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                MessageBox.Show("Ubah Alamat", "Alamat telah diubah. Apakah Anda setuju untuk mengubah Username?", MessageBoxButtons.YesNo);
                if (DialogResult == DialogResult.Yes)
                {
                    //ubah alamat di db
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            homePageForm homePageForm = new homePageForm(loggedInUser);
            homePageForm.Show();
        }

        private void btProduk_Click(object sender, EventArgs e)
        {
            this.Hide();
            produkSellerForm produkSeller = new produkSellerForm();
            produkSeller.Show();
        }

        private void btPenawaran_Click(object sender, EventArgs e)
        {
            this.Hide();
            penawaranBuyerForm penawaranBuyer = new penawaranBuyerForm();
            penawaranBuyer.Show();
        }

        private void btPesanan_Click(object sender, EventArgs e)
        {
            this.Hide();
            pesananBuyerForm pesananBuyerForm = new pesananBuyerForm();
            pesananBuyerForm.Show();
        }

        private void tbAlamat_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            homePageForm homePageForm = new homePageForm(loggedInUser);
            homePageForm.Show();
        }
    }
}
