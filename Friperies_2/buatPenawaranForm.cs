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
    public partial class buatPenawaranForm : Form
    {
        public User loggedInUser;
        public int ItemID;
        public string itemName;
        public string itemPrice;
        public buatPenawaranForm(int id, string name, string price, User user)
        {
            InitializeComponent();
            conn = new NpgsqlConnection(connstring);
            ItemID = id;
            tbOffernamaitem.Text = itemName = name;
            tbHargaawal.Text = itemPrice = price;
            loggedInUser = user;
        }

        private NpgsqlConnection conn;
        string connstring = dbConfig.ConnectionString;
        private NpgsqlCommand cmd;
        private string sql;
        //private int itemID;

        private void OpenConnection()
        {
            if (conn.State == System.Data.ConnectionState.Closed)
                conn.Open();
        }

        private void btnPenawaranbatal_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Apakah Anda yakin akan membatalkan penawaran?", "Konfirmasi Pembatalan", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Hide();
                lihatProdukForm lihatProdukForm = new lihatProdukForm(loggedInUser);
                lihatProdukForm.Show();
            }
        }

        private void btnBuatpenawaran_Click(object sender, EventArgs e)
        {
            try
            {
                int offerPrice = int.Parse(tbOfferprice.Text);
                string offerStatus = "Pending" ;

                string sql = @"INSERT INTO public.""Offer"" (""ItemOffered"",""OwnerOffer"", ""OfferPrice"", ""OfferStatus"") VALUES (@itemID, @ownerOffer, @offerPrice, @offerStatus)";
                var parameters = new Dictionary<string, object>
                {
                    { "@itemID", ItemID },
                    { "@ownerOffer", loggedInUser.userID },
                    { "@offerPrice", offerPrice },
                    { "@offerStatus", offerStatus }
                };
                if (dbConfig.ExecuteNonQuery(sql, parameters, "Penawaran berhasil dibuat.", "Gagal membuat penawaran."))
                {
                    this.Hide();
                    penawaranBuyerForm penawaranBuyerForm = new penawaranBuyerForm(loggedInUser);
                    penawaranBuyerForm.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Terjadi Kesalahan: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
            lihatProdukForm lihatProdukForm = new lihatProdukForm(loggedInUser);
            lihatProdukForm.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }
    }
}
