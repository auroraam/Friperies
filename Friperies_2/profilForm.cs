using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.ApplicationServices;
using Npgsql;

namespace Friperies_2
{
    public partial class profilForm : Form
    {
        public User loggedInUser;
        List<string> listKota = new List<string>();
        public profilForm(User user)
        {
            InitializeComponent();
            loggedInUser = user;
            listKota = Transaction.GetKotaList();
            foreach (string kota in listKota)
            {
                tbAlamat.AutoCompleteCustomSource.Add(kota);
                tbAlamat.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                tbAlamat.AutoCompleteSource = AutoCompleteSource.CustomSource;
            }
            tbUsername.Text = loggedInUser.userName;
            tbIdUser.Text = loggedInUser.userID.ToString();
            tbEmail.Text = loggedInUser.userEmail;
            tbPassword.Text = loggedInUser.userPass;
            tbAlamat.Text = loggedInUser.userAddress;
        }

        private void tbUsername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                DialogResult dialogResult = MessageBox.Show("Username telah diubah. Apakah Anda setuju untuk mengubah Username?", "Ubah Username", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    string newUsername = tbUsername.Text;
                    int userId = loggedInUser.userID;
                    using (NpgsqlConnection conn = new NpgsqlConnection(dbConfig.ConnectionString))
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
                                if (rowsAffected > 0)
                                {
                                    MessageBox.Show("Username berhasil diubah.");
                                    loggedInUser.userName = newUsername;
                                    tbUsername.Text = loggedInUser.userName;
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
                DialogResult dialogResult = MessageBox.Show("Email telah diubah. Apakah Anda setuju untuk mengubah Email?", "Ubah Email", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    string newEmail = tbEmail.Text;
                    int userId = loggedInUser.userID;
                    using (NpgsqlConnection conn = new NpgsqlConnection(dbConfig.ConnectionString))
                    {
                        try
                        {
                            conn.Open();
                            string query = @"UPDATE public.""User"" SET ""UserEmail"" = @UserEmail WHERE ""UserID"" = @UserID";
                            using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                            {
                                cmd.Parameters.AddWithValue("@UserEmail", newEmail);
                                cmd.Parameters.AddWithValue("@UserID", userId);

                                int rowsAffected = cmd.ExecuteNonQuery();
                                if (rowsAffected > 0)
                                {
                                    MessageBox.Show("Email berhasil diubah.");
                                    loggedInUser.userEmail = newEmail;
                                    tbEmail.Text = loggedInUser.userEmail;
                                }
                                else
                                {
                                    MessageBox.Show("Gagal mengubah Email.");
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

        private void tbPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                DialogResult dialogResult = MessageBox.Show("Password telah diubah. Apakah Anda setuju untuk mengubah Password?", "Ubah Password", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    string newPass = tbPassword.Text;
                    int userId = loggedInUser.userID;
                    using (NpgsqlConnection conn = new NpgsqlConnection(dbConfig.ConnectionString))
                    {
                        try
                        {
                            conn.Open();
                            // Ganti dengan nama kolom yang sesuai jika berbeda
                            string query = @"UPDATE public.""User"" SET ""UserPass"" = @UserPass WHERE ""UserID"" = @UserID";
                            using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                            {
                                cmd.Parameters.AddWithValue("@UserPass", newPass);
                                cmd.Parameters.AddWithValue("@UserID", userId);

                                int rowsAffected = cmd.ExecuteNonQuery();
                                if (rowsAffected > 0)
                                {
                                    MessageBox.Show("Password berhasil diubah.");
                                    loggedInUser.userPass = newPass;
                                    tbPassword.Text = loggedInUser.userPass;
                                }
                                else
                                {
                                    MessageBox.Show("Gagal mengubah Password.");
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

        private void tbAlamat_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                DialogResult dialogResult = MessageBox.Show("Alamat telah diubah. Apakah Anda setuju untuk mengubah Username?", "Ubah Alamat", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    string newAddress = tbAlamat.Text;
                    int userId = loggedInUser.userID;
                    int idAlamat = Transaction.GetIdKotaList(tbAlamat.Text.Trim());

                    if (idAlamat == -1)
                    {
                        MessageBox.Show("Kota asal atau tujuan tidak valid. Harap periksa kembali.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    using (NpgsqlConnection conn = new NpgsqlConnection(dbConfig.ConnectionString))
                    {
                        try
                        {
                            conn.Open();
                            string query = @"UPDATE public.""User"" SET ""UserAddress"" = @UserAddress WHERE ""UserID"" = @UserID";
                            using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                            {
                                cmd.Parameters.AddWithValue("@UserAddress", newAddress);
                                cmd.Parameters.AddWithValue("@UserID", userId);

                                int rowsAffected = cmd.ExecuteNonQuery();
                                if (rowsAffected > 0)
                                {
                                    MessageBox.Show("Alamat berhasil diubah.");
                                    loggedInUser.userAddress = newAddress;
                                    tbAlamat.Text = loggedInUser.userAddress;
                                }
                                else
                                {
                                    MessageBox.Show("Gagal mengubah Alamat.");
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
            produkSellerForm produkSeller = new produkSellerForm(loggedInUser);
            produkSeller.Show();
        }

        private void btPenawaran_Click(object sender, EventArgs e)
        {
            this.Hide();
            penawaranBuyerForm penawaranBuyer = new penawaranBuyerForm(loggedInUser);
            penawaranBuyer.Show();
        }

        private void btPesanan_Click(object sender, EventArgs e)
        {
            this.Hide();
            pesananBuyerForm pesananBuyerForm = new pesananBuyerForm(loggedInUser);
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

        private void btnProfillogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to log out?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Hide();

                signinForm signinForm = new signinForm();
                signinForm.ShowDialog();
            }
        }
    }
}
