using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Supabase;
using System.Net.Http;
using Npgsql;

namespace Friperies_2
{
    public partial class penawaranBuyerForm : Form
    {
        public User loggedInUser;
        private NpgsqlConnection conn;
        string connstring = dbConfig.ConnectionString;
        public DataTable dt;
        public static NpgsqlCommand cmd;
        private string sql = null;
        private DataGridViewRow row;
        public penawaranBuyerForm(User user)
        {
            InitializeComponent();
            loggedInUser = user;
            conn = new NpgsqlConnection(connstring);
            LoadOffer();
        }

        private void OpenConnection()
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
        }

        private void LoadOffer()
        {
            string sql = @"SELECT * FROM public.""Offer"" WHERE ""OwnerOffer"" = @owneroffer";
            var parameters = new Dictionary<string, object>
            {
                { "@owneroffer", loggedInUser.userID }
            };

            DataTable dt = dbConfig.LoadData(sql, parameters);
            if (dt != null)
            {
                dgvPenawaran.DataSource = dt;
            }
        }

        private void btLoad_Click(object sender, EventArgs e)
        {
            LoadOffer();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbIdPenawaran.Text))
            {
                MessageBox.Show("Pilih penawaran yang ingin dihapus.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int offerID = int.Parse(tbIdPenawaran.Text);
            Offer offer = new Offer(); // Buat instance Offer
            offer.delete(offerID); // Panggil metode delete
            LoadOffer(); // Refresh data penawaran
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
            if(dgvPenawaran.SelectedRows.Count > 0)
            {
                int offereditem = Convert.ToInt32(row.Cells["ItemOffered"].Value);
                int ItemID = offereditem;
                string itemname = GetNamaProduk(ItemID);
                int itemprice = Convert.ToInt32(row.Cells["OfferPrice"].Value);
                string status = row.Cells["OfferStatus"].Value.ToString();
                int offerid = Convert.ToInt32(row.Cells["OfferID"].Value);
                if (status == "Accepted")
                {
                    this.Hide();
                    buatPesananForm buatPesananForm = new buatPesananForm(loggedInUser, offerid, itemname, itemprice, offereditem);
                    buatPesananForm.Show();
                }
                else
                {
                    MessageBox.Show("Tidak dapat membuat pesanan karena penawaran belum diterima.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            profilForm profilForm = new profilForm(loggedInUser);
            profilForm.Show();
        }

        protected string GetNamaProduk(int iditem)
        {
            string itemname = null;
            try
            {
                OpenConnection();
                sql = @"select ""ItemName"" from public.""Item"" WHERE ""ItemID"" = @itemid";
                using (NpgsqlCommand cmd = new NpgsqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@itemid", iditem);
                    using (NpgsqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            itemname = reader.GetString(reader.GetOrdinal("ItemName"));
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Fail!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
            return itemname;
        }

        private void dgvPenawaran_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                row = dgvPenawaran.Rows[e.RowIndex];
                int offereditem = Convert.ToInt32(row.Cells["ItemOffered"].Value);
                int ItemID = offereditem;
                string itemname = GetNamaProduk(ItemID);
                tbIdPenawaran.Text = row.Cells["OfferID"].Value.ToString();
                tbNamaProduk.Text = itemname;
                tbHarga.Text = row.Cells["OfferPrice"].Value.ToString();
                tbStatus.Text = row.Cells["OfferStatus"].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saat memilih penawaran: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
