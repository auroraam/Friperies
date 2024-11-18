﻿using System;
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
                OpenConnection();
                int offerPrice = int.Parse(tbOfferprice.Text);
                string OfferStatus = "Pending" ;

                string sql = @"INSERT INTO public.""Offer"" (""ItemOffered"",""OwnerOffer"", ""OfferPrice"", ""OfferStatus"") VALUES (@itemID, @ownerOffer, @offerPrice, @offerStatus)";
                using (var cmd = new NpgsqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@itemID", ItemID);
                    cmd.Parameters.AddWithValue("@ownerOffer", loggedInUser.userID);
                    cmd.Parameters.AddWithValue("@offerPrice", offerPrice);
                    cmd.Parameters.AddWithValue("@offerStatus", OfferStatus);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Penawaran berhasil dibuat.", "Offer Succeed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide();
                        homePageForm homePageForm = new homePageForm(loggedInUser);
                        homePageForm.Show();
                    }
                    else
                    {
                        MessageBox.Show("Gagal membuat penawaran.", "Offer Failed!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
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
