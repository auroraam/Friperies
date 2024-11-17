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
    public partial class buatPesananForm : Form
    {
        public User loggedInUser;
        private int itemID;
        private string itemName;
        private int itemPrice;
        private string selectedService;
        private void buatPesananForm_Load(object sender, EventArgs e)
        {

        }
        public buatPesananForm(User user)
        {
            InitializeComponent();
            this.loggedInUser = user;
            this.itemID = itemID;
            this.itemName = itemName;
            this.itemPrice = itemPrice;

            tbBuatpesananitem.Text = itemName;
            tbBuatpesananharga.Text = itemPrice.ToString();
            // tbBuatpesananitem.ReadOnly = true;
            // tbBuatpenananharga.ReadOnly = true;

            tbBuatpesanantgl.Text = DateTime.Now.ToString("yyyy-MM-dd");
        }

        private void UpdateSelectedService()
        {
            if (rbJNE.Checked) selectedService = "jne";
            if (rbTIKI.Checked) selectedService = "tiki";
            if (rbPOS.Checked) selectedService = "pos";
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
                using (var conn = new NpgsqlConnection("Host=localhost;Port=5432;Username=postgres;Password=feather0325;Database=friperiesfix"))
                {
                    conn.Open();

                    var cmd = new NpgsqlCommand("INSERT INTO Transaction (ItemSold, SellerID, BuyerID, TransactionDate, TransactionStatus, Service) VALUES (@itemSold, @sellerID, @buyerID, @transactionDate, @transactionStatus, @service)", conn);
                    cmd.Parameters.AddWithValue("itemSold", itemID);
                    cmd.Parameters.AddWithValue("sellerID", GetSellerID());
                    cmd.Parameters.AddWithValue("buyerID", loggedInUser.userID);
                    cmd.Parameters.AddWithValue("transactionDate", DateTime.Now);
                    cmd.Parameters.AddWithValue("transactionStatus", "Menunggu Pembayaran");
                    cmd.Parameters.AddWithValue("service", selectedService);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Pesanan berhasil dibuat!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Terjadi kesalahan: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private int GetSellerID()
        {
            int sellerID = -1;

            try
            {
                using (var conn = new NpgsqlConnection("Host=localhost;Port=5432;Username=postgres;Password=feather0325;Database=friperiesfix"))
                {
                    conn.Open();

                    var cmd = new NpgsqlCommand("SELECT OwnerItem FROM Item WHERE ItemID = @itemID", conn);
                    cmd.Parameters.AddWithValue("itemID", itemID);

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            sellerID = reader.GetInt32(reader.GetOrdinal("OwnerItem"));
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saat mengambil SellerID: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return sellerID;
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

            var layananList = Transaction.GetLayananList(idAsal, idTujuan, berat, selectedService);
            //gbCekhargaongkir.Items.Clear();
            foreach (var layanan in layananList)
            {
                //gbCekhargaongkir.Items.Add(layanan);
            }
        }


    }
}
