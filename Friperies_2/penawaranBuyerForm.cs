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
    public partial class penawaranBuyerForm : Form
    {
        public User loggedInUser;
        public penawaranBuyerForm(User user)
        {
            InitializeComponent();
            this.loggedInUser = user;
        }

        private void btLoad_Click(object sender, EventArgs e)
        {
            try
            {
                using (var conn = new NpgsqlConnection("Host=localhost;Port=5432;Username=postgres;Password=;Database=friperiesfix"))
                {
                    conn.Open();
                    var query = @"
                        SELECT 
                            Offer.OfferID, 
                            Item.ItemName, 
                            Offer.OfferPrice, 
                            Offer.OfferStatus 
                        FROM 
                            Offer 
                        INNER JOIN 
                            Item 
                        ON 
                            Offer.ItemOffered = Item.ItemID 
                        WHERE 
                            Offer.OwnerOffer = @buyerID";
                    var cmd = new NpgsqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("buyerID", loggedInUser.userID);

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
                MessageBox.Show($"Error saat memuat penawaran: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvPenawaran_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                int rowIndex = e.RowIndex;
                tbIdPenawaran.Text = dgvPenawaran.Rows[rowIndex].Cells["OfferID"].Value.ToString();
                tbNamaProduk.Text = dgvPenawaran.Rows[rowIndex].Cells["ItemName"].Value.ToString();
                tbHarga.Text = dgvPenawaran.Rows[rowIndex].Cells["OfferPrice"].Value.ToString();
                tbStatus.Text = dgvPenawaran.Rows[rowIndex].Cells["OfferStatus"].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saat memilih penawaran: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbIdPenawaran.Text))
            {
                MessageBox.Show("Pilih penawaran yang ingin dihapus.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (var conn = new NpgsqlConnection("Host=localhost;Port=5432;Username=postgres;Password=;Database=friperiesfix"))
                {
                    conn.Open();

                    var query = "DELETE FROM Offer WHERE OfferID = @offerID";

                    var cmd = new NpgsqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("offerID", int.Parse(tbIdPenawaran.Text));

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Penawaran berhasil dihapus!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btLoad_Click(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("Penawaran gagal dihapus atau tidak ditemukan.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saat menghapus penawaran: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void btCheckOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            buatPesananForm buatPesananForm = new buatPesananForm();
            buatPesananForm.Show();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            profilForm profilForm = new profilForm(loggedInUser);
            profilForm.Show();
        }
    }
}
