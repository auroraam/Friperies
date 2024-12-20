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
using RestSharp;
using Newtonsoft;
using System.Transactions;

namespace Friperies_2
{
    public partial class buatPesananForm : Form
    {
        public User loggedInUser;
        public int offerid;
        private int itemID;
        private string itemname;
        private int itemPrice;
        private int offereditem;
        private string selectedService;
        List<string> listKota = new List<string>();
        private void buatPesananForm_Load(object sender, EventArgs e)
        {

        }
        public buatPesananForm(User user, int id, string name, int price, int offeritem)
        {
            InitializeComponent();
            loggedInUser = user;
            tbTujuan.Text = GetAlamatBuyer(loggedInUser.userID);
            offerid = id;
            tbBuatpesananitem.Text = itemname = name;
            itemPrice = price;
            offereditem = offeritem;
            tbAsal.Text = GetAlamatSeller(offeritem);
            tbBuatpesananharga.Text = itemPrice.ToString();
            tbBuatpesanantgl.Text = DateTime.Now.ToString("yyyy-MM-dd");
            listKota = Transaction.GetKotaList();
            foreach (string kota in listKota)
            {
                tbTujuan.AutoCompleteCustomSource.Add(kota);
                tbTujuan.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                tbTujuan.AutoCompleteSource = AutoCompleteSource.CustomSource;
            }
        }

        private NpgsqlConnection conn;
        string connstring = dbConfig.ConnectionString;
        public DataTable dt;
        public static NpgsqlCommand cmd;
        private string sql = null;

        private int GetIdKota(string kota)
        {
            int idKota = -1;
            idKota = Transaction.GetIdKotaList(kota);
            return idKota;
        }

        private void TampilkanDaftar(List<string> daftarLayanan)
        {
            gbCekHargaOngkir.Text = "Detail Ongkir";
            foreach (string layanan in daftarLayanan)
            {
                gbCekHargaOngkir.Text += "\n-" + layanan;
            }
        }

        private void UpdateSelectedService()
        {
            if (rbJNE.Checked) selectedService = "jne";
            if (rbTIKI.Checked) selectedService = "tiki";
            if (rbPOS.Checked) selectedService = "pos";
        }

        private void OpenConnection()
        {
            if (conn == null)
            {
                conn = new NpgsqlConnection(dbConfig.ConnectionString); // Inisialisasi jika null
            }

            if (conn.State == ConnectionState.Closed)
            {
                conn.Open(); // Buka koneksi hanya jika statusnya tertutup
            }
        }

        protected string GetAlamatBuyer(int iduser)
        {
            string alamat = null;
            try
            {
                OpenConnection();
                sql = @"select ""UserAddress"" from public.""User"" WHERE ""UserID"" = @UserID";
                using (NpgsqlCommand cmd = new NpgsqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@UserID", iduser);
                    using (NpgsqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            alamat = reader.GetString(reader.GetOrdinal("UserAddress"));
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Fail!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return alamat;
        }

        protected string GetAlamatSeller(int iduser)
        {
            string alamat = null;
            try
            {
                OpenConnection();
                sql = @"select ""UserAddress"" from public.""User"" WHERE ""UserID"" = @UserID";
                using (NpgsqlCommand cmd = new NpgsqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@UserID", iduser);
                    using (NpgsqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            alamat = reader.GetString(reader.GetOrdinal("UserAddress"));
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Fail!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return alamat;
        }

        protected (int itemid, int sellerid) GetVarItem(int offeritemid)
        {
            int itemid = 0;
            int sellerid = 0;
            try
            {
                OpenConnection();
                sql = @"select ""ItemID"", ""OwnerItem"" from public.""Item"" WHERE ""ItemID"" = @offeritemid";
                using (NpgsqlCommand cmd = new NpgsqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@offeritemid", offeritemid);
                    using (NpgsqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            itemid = reader.GetInt32(reader.GetOrdinal("ItemID"));
                            sellerid = reader.GetInt32(reader.GetOrdinal("OwnerItem"));
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Fail!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return (itemid, sellerid);
        }

        private void btnBuatpesanan_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(selectedService))
            {
                MessageBox.Show("Harap pilih layanan pengiriman.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                OpenConnection();
                var (itemID, SellerID) = GetVarItem(offereditem);
                string sql = @"INSERT INTO public.""Transaction""(""ItemSold"", ""SellerID"", ""BuyerID"", ""TransactionDate"", ""TransactionStatus"", ""TransactionService"") VALUES(@itemSold, @sellerID, @buyerID, @transactionDate, @transactionStatus, @service)";
                using (var cmd = new NpgsqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@itemSold", itemID);
                    cmd.Parameters.AddWithValue("@sellerID", SellerID);
                    cmd.Parameters.AddWithValue("@buyerID", loggedInUser.userID);
                    cmd.Parameters.AddWithValue("@transactionDate", DateTime.Now);
                    cmd.Parameters.AddWithValue("@transactionStatus", "Pembayaran");
                    cmd.Parameters.AddWithValue("@service", selectedService);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Pesanan berhasil dibuat.", "Transaction Succeed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide();
                        pesananBuyerForm pesananBuyerForm = new pesananBuyerForm(loggedInUser);
                        pesananBuyerForm.Show();
                    }
                    else
                    {
                        MessageBox.Show("Gagal membuat pesanan.", "Transaction Failed!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Terjadi kesalahan: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
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
            lihatProdukForm lihatProdukForm = new lihatProdukForm(loggedInUser);
            lihatProdukForm.Show();
        }

        private void btnCekOngkir_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbAsal.Text) || string.IsNullOrWhiteSpace(tbTujuan.Text) || string.IsNullOrWhiteSpace(tbBerat.Text))
            {
                MessageBox.Show("Harap isi asal kota, kota tujuan, dan berat barang.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int idAsal = Transaction.GetIdKotaList(tbAsal.Text.Trim());
            int idTujuan = Transaction.GetIdKotaList(tbTujuan.Text.Trim());
            UpdateSelectedService();

            if (idAsal == -1 || idTujuan == -1)
            {
                MessageBox.Show("Kota asal atau tujuan tidak valid. Harap periksa kembali.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(tbBerat.Text, out int berat))
            {
                MessageBox.Show("Berat barang harus berupa angka.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            List<string> daftarLayanan = Transaction.GetLayananList
                (GetIdKota(tbAsal.Text), GetIdKota(tbTujuan.Text), int.Parse(tbBerat.Text), selectedService);
            TampilkanDaftar(daftarLayanan);
        }

        private void tbAsal_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
