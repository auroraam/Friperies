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
        public int itemID;
        public buatPenawaranForm(int id)
        {
            InitializeComponent();
            conn = new NpgsqlConnection(connstring);
            //belum bener
            //tbOffernamaitem.Text = itemName;
            //tbHargaawal.Text = itemPrice.ToString();
            itemID = id;
            int itemPrice;
            currentOffer = new Offer();
        }

        private Offer currentOffer;

        private NpgsqlConnection conn;
        string connstring = "Host = localhost; Port = 5432; Username = postgres; Password = feather0325; Database = Friperies";
        private NpgsqlCommand cmd;
        private string sql;
        //private int itemID;

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
                currentOffer.offerPrice = offerPrice;

                currentOffer.NewOffer(0, currentOffer.itemID, offerPrice, currentOffer.OwnerOffer);

                string sql = "INSERT INTO Offer (ItemOffered, OwnerOffer, OfferPrice, OfferStatus) VALUES (@itemID, @ownerOffer, @itemPrice, @offerStatus)";
                using (var cmd = new NpgsqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("itemID", currentOffer.itemID);
                    cmd.Parameters.AddWithValue("ownerOffer", currentOffer.OwnerOffer);
                    cmd.Parameters.AddWithValue("offerPrice", currentOffer.offerPrice);
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
            lihatProdukForm lihatProdukForm = new lihatProdukForm(loggedInUser);
            lihatProdukForm.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }
    }
}
