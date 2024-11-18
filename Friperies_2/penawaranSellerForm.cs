using Microsoft.VisualBasic.ApplicationServices;
using Npgsql;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Friperies_2
{
    public partial class penawaranSellerForm : Form
    {
        public User loggedInUser;
        public int ItemID;
        private NpgsqlConnection conn;
        string connstring = dbConfig.ConnectionString;
        public DataTable dt;
        public static NpgsqlCommand cmd;
        private string sql = null;
        private DataGridViewRow row;
        public penawaranSellerForm(User user, int id)
        {
            InitializeComponent();
            conn = new NpgsqlConnection(connstring);
            loggedInUser = user;
            ItemID = id;
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
            try
            {
                OpenConnection();
                string sql = @"SELECT * FROM public.""Offer"" WHERE ""ItemOffered"" = @itemOffered";
                using (NpgsqlCommand cmd = new NpgsqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@itemOffered", ItemID); 

                    // Eksekusi command dengan adapter
                    NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    // Tampilkan data di DataGridView
                    dataGridView1.DataSource = dt;
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

        private void btnOffertolak_Click(object sender, EventArgs e)
        {
            UpdateOfferStatus("Rejected");
        }

        private void UpdateOfferStatus(string status)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int offerId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["OfferID"].Value);
                try
                {
                    OpenConnection();
                    sql = @"UPDATE public.""Offer"" SET ""OfferStatus"" = @offerstatus WHERE ""OfferID"" = @offerid";
                    cmd = new NpgsqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@offerstatus", status);
                    cmd.Parameters.AddWithValue("@offerid", offerId);
                    cmd.ExecuteNonQuery();
                    // Refresh DataGridView setelah update
                    LoadOffer();
                    MessageBox.Show($"Penawaran telah di {status.ToLower()}.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Failed!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally { conn.Close(); }
            }
            else
            {
                MessageBox.Show("Pilih penawaran untuk di perbarui.");
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            produkSellerForm produkSellerForm = new produkSellerForm(loggedInUser);
            produkSellerForm.Show();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            homePageForm homePageForm = new homePageForm(loggedInUser);
            homePageForm.Show();
        }

        private void btnOfferterima_Click_1(object sender, EventArgs e)
        {
            UpdateOfferStatus("Accepted");
        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnOfferload_Click_1(object sender, EventArgs e)
        {
            LoadOffer();
        }

        protected (string itemname, int itemprice) GetNamaProduk(int iditem)
        {
            string itemname = null;
            int itemprice = 0;
            try
            {
                OpenConnection();
                sql = @"select ""ItemName"", ""ItemPrice"" from public.""Item"" WHERE ""ItemID"" = @itemid";
                using (NpgsqlCommand cmd = new NpgsqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@itemid", iditem);
                    using (NpgsqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            itemname = reader.GetString(reader.GetOrdinal("ItemName"));
                            itemprice = reader.GetInt32(reader.GetOrdinal("ItemPrice"));
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
            return (itemname, itemprice);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var (itemName, itemPrice) = GetNamaProduk(ItemID);
                row = dataGridView1.Rows[e.RowIndex];
                tbOffernamaitem.Text = itemName;
                tbOfferhargaitem.Text = itemPrice.ToString();
                tbHargaPenawaran.Text = row.Cells["OfferPrice"].Value.ToString();
            }
            else
            {
                MessageBox.Show("Pilih data produk.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
