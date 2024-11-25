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
                    string query = @"UPDATE public.""User"" SET ""UserName"" = @UserName WHERE ""UserID"" = @UserID";
                    var parameters = new Dictionary<string, object>
                    {
                        { "@UserName", tbUsername.Text },
                        { "@UserID", loggedInUser.userID }
                    };

                    if (dbConfig.ExecuteNonQuery(query, parameters, "Username berhasil diubah.", "Gagal mengubah Username."))
                    {
                        loggedInUser.userPass = tbUsername.Text;
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
                    string query = @"UPDATE public.""User"" SET ""UserEmail"" = @UserEmail WHERE ""UserID"" = @UserID";
                    var parameters = new Dictionary<string, object>
                    {
                        { "@UserEmail", tbEmail.Text },
                        { "@UserID", loggedInUser.userID }
                    };

                    if (dbConfig.ExecuteNonQuery(query, parameters, "Email berhasil diubah.", "Gagal mengubah Email."))
                    {
                        loggedInUser.userEmail = tbEmail.Text;
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
                    string query = @"UPDATE public.""User"" SET ""UserPass"" = @UserPass WHERE ""UserID"" = @UserID";
                    var parameters = new Dictionary<string, object>
                    {
                        { "@UserPass", tbPassword.Text },
                        { "@UserID", loggedInUser.userID }
                    };

                    if (dbConfig.ExecuteNonQuery(query, parameters, "Password berhasil diubah.", "Gagal mengubah Password."))
                    {
                        loggedInUser.userPass = tbPassword.Text;
                    }
                }
            }

        }

        private void tbAlamat_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                DialogResult dialogResult = MessageBox.Show("Alamat telah diubah. Apakah Anda setuju untuk mengubah Alamat?", "Ubah Alamat", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    int idAlamat = Transaction.GetIdKotaList(tbAlamat.Text.Trim());
                    if (idAlamat == -1)
                    {
                        MessageBox.Show("Kota asal atau tujuan tidak valid. Harap periksa kembali.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    string query = @"UPDATE public.""User"" SET ""UserAddress"" = @UserAddress WHERE ""UserID"" = @UserID";
                    var parameters = new Dictionary<string, object>
                    {
                        { "@UserAddress", tbAlamat.Text },
                        { "@UserID", loggedInUser.userID }
                    };

                    if (dbConfig.ExecuteNonQuery(query, parameters, "Alamat berhasil diubah.", "Gagal mengubah Alamat."))
                    {
                        loggedInUser.userAddress = tbAlamat.Text;
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
