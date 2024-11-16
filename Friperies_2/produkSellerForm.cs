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
    public partial class produkSellerForm : Form
    {
        public User loggedInUser;
        public produkSellerForm(User user)
        {
            InitializeComponent();
            this.loggedInUser = user;
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            try
            {
                using (var conn = new NpgsqlConnection("Host=localhost;Port=5432;Username=postgres;Password=;Database=friperiesfix"))
                {
                    conn.Open();
                    var query = "SELECT ItemID, ItemName, Category, Price FROM Item WHERE OwnerItem = @ownerItem";
                    var cmd = new NpgsqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("ownerItem", loggedInUser.userID);

                    using (var reader = cmd.ExecuteReader())
                    {
                        var dt = new DataTable();
                        dt.Load(reader);
                        dgvPenawaran.DataSource = dt; 
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saat memuat produk: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvPenawaran_RowHeaderMouseClick(object sender, DataGridViewCellMouseEvenetArgs e)
        {
           try
            {
                int rowIndex = e.RowIndex;
                tbIdProduk.Text = dgvPenawaran.Rows[rowIndex].Cells["ItemID"].Value.ToString();
                tbNamaProduk.Text = dgvPenawaran.Rows[rowIndex].Cells["ItemName"].Value.ToString();
                tbKategori.Text = dgvPenawaran.Rows[rowIndex].Cells["ItemCategory"].Value.ToString();
                tbHarga.Text = dgvPenawaran.Rows[rowIndex].Cells["ItemPrice"].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saat memilih produk: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } 
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbIdProduk.Text))
            {
                MessageBox.Show("Pilih produk yang ingin dihapus.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (var conn = new NpgsqlConnection("Host=localhost;Port=5432;Username=postgres;Password=;Database=friperiesfix"))
                {
                    conn.Open();
                    var query = "DELETE FROM Item WHERE ItemID = @itemID AND OwnerItem = @ownerItem";
                    var cmd = new NpgsqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("itemID", int.Parse(tbIdProduk.Text));
                    cmd.Parameters.AddWithValue("ownerItem", loggedInUser.userID);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Produk berhasil dihapus!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btLoad_Click(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("Produk gagal dihapus atau tidak ditemukan.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saat menghapus produk: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btPenawaran_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbIdProduk.Text))
            {
                MessageBox.Show("Pilih produk untuk melihat penawaran.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                int ItemID = int.Parse(tbIdProduk.Text);
                var penawaranSellerForm = new penawaranSellerForm(ItemID, loggedInUser);
                penawaranSellerForm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saat membuka form penawaran: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            profilForm profilForm = new profilForm(loggedInUser);
            profilForm.Show();
        }
    }
}
