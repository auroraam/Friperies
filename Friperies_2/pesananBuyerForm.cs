using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
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
        public int ItemID;
        private NpgsqlConnection conn;
        string connstring = dbConfig.ConnectionString;
        public DataTable dt;
        public static NpgsqlCommand cmd;
        private string sql = null;
        private DataGridViewRow row;
        public pesananBuyerForm(User user)
        {
            InitializeComponent();
            conn = new NpgsqlConnection(connstring);
            loggedInUser = user;
            LoadOrders();
        }

        private void OpenConnection()
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
        }

        public void LoadOrders()
        {
            try
            {
                OpenConnection();
                string sql = @"SELECT * FROM public.""Transaction"" WHERE ""BuyerID"" = @userID";
                using (NpgsqlCommand cmd = new NpgsqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@userID", loggedInUser.userID);
                    NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dgvPesanan.DataSource = dt;
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

        private void btLoad_Click(object sender, EventArgs e)
        {
            LoadOrders();
        }

        private string GetNamaProduk(int itemsold)
        {
            string namaProduk = null;
            try
            {
                OpenConnection();
                string sql = @"SELECT ""ItemName"" FROM public.""Item"" WHERE ""ItemID"" = @itemsold";
                using (NpgsqlCommand cmd = new NpgsqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@itemsold", itemsold);
                    using (NpgsqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            namaProduk = reader.GetString(reader.GetOrdinal("ItemName"));
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }

            return namaProduk;
        }


        private void dgvPesanan_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                row = dgvPesanan.Rows[e.RowIndex];
                int ItemSold = int.Parse(row.Cells["ItemSold"].Value.ToString());
                var itemName = GetNamaProduk(ItemSold);
                tbNamaProduk.Text = itemName;
                tbIdPesanan.Text = row.Cells["TransactionID"].Value.ToString();
                tbTanggal.Text = row.Cells["TransactionDate"].Value.ToString();
                tbStatus.Text = row.Cells["TransactionStatus"].Value.ToString();
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
                using (var conn = new NpgsqlConnection(connstring))
                {
                    conn.Open();
                    string query = @"UPDATE public.""Transaction"" SET ""TransactionStatus"" = 'Completed' WHERE ""TransactionID"" = @transactionID";
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
