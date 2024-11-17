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
        private NpgsqlConnection conn;
        private string connString = "Host=localhost;Port=5432;Username=postgres;Password=feather0325;Database=friperiesfix";
        private DataGridViewRow row;
        public produkSellerForm(User user)
        {
            InitializeComponent();
            this.loggedInUser = user;
            conn = new NpgsqlConnection(connString);
            LoadProduk();
        }
        private void LoadProduk()
        {
            try
            {
                conn.Open();
                string sql = @"SELECT * FROM public.""Item"" WHERE ""OwnerItem"" = @ownerItem";
                using (NpgsqlCommand cmd = new NpgsqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@ownerItem", loggedInUser.userID); // loggedInUser adalah pengguna saat ini

                    // Eksekusi command dengan adapter
                    NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    // Tampilkan data di DataGridView
                    dgvPenawaran.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Terjadi kesalahan saat memuat data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            finally
            {
                conn.Close();
            }
        }

        private void dgvPenawaran_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                row = dgvPenawaran.Rows[e.RowIndex];
                tbIdProduk.Text = row.Cells["ItemID"].Value.ToString();
                tbNamaProduk.Text = row.Cells["ItemName"].Value.ToString();
                tbKategori.Text = row.Cells["ItemCategory"].Value.ToString();
                tbHarga.Text = row.Cells["ItemPrice"].Value.ToString();
            }
            else
            {
                MessageBox.Show("Pilih data produk.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btLoad_Click(object sender, EventArgs e)
        {
             LoadProduk();
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
                using (var conn = new NpgsqlConnection("Host=localhost;Port=5432;Username=postgres;Password=feather0325;Database=friperiesfix"))
                {
                    conn.Open();
                    var query = @"DELETE FROM public.""Item"" WHERE ""ItemID"" = @itemID AND ""OwnerItem"" = @ownerItem";
                    var cmd = new NpgsqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@itemID", int.Parse(tbIdProduk.Text));
                    cmd.Parameters.AddWithValue("@ownerItem", loggedInUser.userID);

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
                this.Hide();
                int ItemID = int.Parse(tbIdProduk.Text);
                var penawaranSellerForm = new penawaranSellerForm(loggedInUser, ItemID);
                penawaranSellerForm.Show();
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
