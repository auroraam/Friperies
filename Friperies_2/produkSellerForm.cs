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
        private string connString = dbConfig.ConnectionString;
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
            string sql = @"SELECT * FROM public.""Item"" WHERE ""OwnerItem"" = @ownerItem";
            var parameters = new Dictionary<string, object>
            {
                { "@ownerItem", loggedInUser.userID }
            };

            DataTable dt = dbConfig.LoadData(sql, parameters);
            if (dt != null)
            {
                dgvPenawaran.DataSource = dt;
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

            int itemID = int.Parse(tbIdProduk.Text);
            Item item = new Item(loggedInUser.userID, itemID, null, 0); // Buat instance Item dengan ID
            item.delete(itemID); // Panggil metode delete
            LoadProduk(); // Refresh data produk
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
