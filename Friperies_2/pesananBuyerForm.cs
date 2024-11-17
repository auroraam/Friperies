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
    
    public partial class pesananBuyerForm : Form
    {
        public User loggedInUser;
        public pesananBuyerForm(User user)
        {
            InitializeComponent();
            loggedInUser = user;
        }

        private void btLoad_Click(object sender, EventArgs e)
        {
            try
            {
               using (var conn = new NpgsqlConnection("Host=localhost;Port=5432;Username=postgres;Password=feather0325;Database=friperiesfix"))
                {
                    conn.Open();
                    string query = @"
                        SELECT 
                            Transaction.TransactionID, 
                            Item.ItemName, 
                            Transaction.TransactionDate, 
                            Transaction.TransactionStatus 
                        FROM 
                            Transaction 
                        INNER JOIN 
                            Item 
                        ON 
                            Transaction.ItemSold = Item.ItemID 
                        WHERE 
                            Transaction.BuyerID = @buyerID";

                    var cmd = new NpgsqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("buyerID", loggedInUser.userID);

                    using (var reader = cmd.ExecuteReader())
                    {
                        var dt = new DataTable();
                        dt.Load(reader);
                        dgvPesanan.DataSource = dt;
                    }
                } 
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading orders: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvPesanan_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                int rowIndex = e.RowIndex;
                tbIdPesanan.Text = dgvPesanan.Rows[rowIndex].Cells["TransactionID"].Value.ToString();
                tbNamaProduk.Text = dgvPesanan.Rows[rowIndex].Cells["ItemName"].Value.ToString();
                tbTanggal.Text = dgvPesanan.Rows[rowIndex].Cells["TransactionDate"].Value.ToString();
                tbStatus.Text = dgvPesanan.Rows[rowIndex].Cells["TransactionStatus"].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error displaying order details: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbIdPesanan.Text))
            {
                MessageBox.Show("Pilih pesanan yang ingin ditandai selesai.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (var conn = new NpgsqlConnection("Host=localhost;Port=5432;Username=postgres;Password=feather0325;Database=friperiesfix"))
                {
                    conn.Open();
                    string query = "UPDATE Transaction SET TransactionStatus = 'Completed' WHERE TransactionID = @transactionID";
                    var cmd = new NpgsqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("transactionID", int.Parse(tbIdPesanan.Text));

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Pesanan berhasil ditandai selesai!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btLoad_Click(sender, e); 
                    }
                    else
                    {
                        MessageBox.Show("Gagal memperbarui status pesanan.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating order status: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            homePageForm homePageForm = new homePageForm(loggedInUser);
            homePageForm.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            profilForm profilForm = new profilForm(loggedInUser);
            profilForm.Show();
        }
    }
}
