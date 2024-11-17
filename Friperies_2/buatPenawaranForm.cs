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
        public buatPenawaranForm(User user)
        {
            InitializeComponent();
            conn = new NpgsqlConnection(connstring);
            //belum bener
            //tbOffernamaitem.Text = itemName;
            //tbHargaawal.Text = itemPrice.ToString();
            int itemPrice;
            currentOffer = new Offer(loggedInUser.userID, loggedInUser.userName, loggedInUser.userEmail, loggedInUser.userPass, loggedInUser.userAddress, 0, itemID, itemPrice);
            
        }

        private Offer currentOffer;

        private NpgsqlConnection conn;
        string connstring = "Host = localhost; Port = 5432; Username = postgres; Password = ; Database = Friperies";
        private NpgsqlCommand cmd;
        private string sql;
        private int itemID;

        private void OpenConnection()
        {
            if (conn.State == System.Data.ConnectionState.Closed)
                conn.Open();
        }

        private void CloseConnection()
        {
            if (conn.State == System.Data.ConnectionState.Open)
                conn.Close();
        }

        private void btnPenawaranbatal_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Apakah Anda yakin akan mebatalkan penawaran?", "Konfirmasi Pembatalan", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnBuatpenawaran_Click(object sender, EventArgs e)
        {
            try
            {
                OpenConnection();
                int offerPrice = int.Parse(tbOfferprice.Text);
                currentOffer.OfferPrice = offerPrice;

                currentOffer.NewOffer(0, currentOffer.ItemID, offerPrice, currentOffer.OwnerOffer);

                string sql = "INSERT INTO Offer (ItemOffered, OwnerOffer, OfferPrice, OfferStatus) VALUES (@itemID, @ownerOffer, @itemPrice, @offerStatus)";
                using (var cmd = new NpgsqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("itemID", currentOffer.ItemID);
                    cmd.Parameters.AddWithValue("ownerOffer", currentOffer.OwnerOffer);
                    cmd.Parameters.AddWithValue("offerPrice", currentOffer.OfferPrice);
                    cmd.Parameters.AddWithValue("offerStatus", currentOffer.OfferStatus);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    MessageBox.Show($"{rowsAffected} penawaran berhasil ditambahkan.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            lihatProdukForm lihatProdukForm = new lihatProdukForm();
            lihatProdukForm.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }
    }
}
