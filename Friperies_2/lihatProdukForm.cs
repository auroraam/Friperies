using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Friperies_2
{
    public partial class lihatProdukForm : Form
    {
        public User loggedInUser;
        public lihatProdukForm()

        private NpgsqlConnection conn;
        private string connString = "Host=localhost;Port=5432;Username=postgres;Password=;Database=Friperies";
        {
            InitializeComponent();
            conn = new NpgsqlConnection(connString);
            LoadProduk();
        }

        private void LoadProduk()
        {
            try
            {
                conn.Open();
                string sql = "select * from Item";
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
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

        private void rbKtg1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbKtg3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            homePageForm homePageForm = new homePageForm(loggedInUser);
            homePageForm.Show();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            homePageForm homePageForm = new homePageForm(loggedInUser);
            homePageForm.Show();
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEvenetArgs e)
        {
            int rowIndex >= e.RowIndex;

            if (rowIndex >= 0)
            {
                DataGridView row = dataGridView1.Rows[rowIndex];
                tbNamaitem.Text = row.Cells["ItemName"].Value.ToString();
                tbKtgitem.Text = row.Cells["ItemCategory"].Value.ToString();
                tbHargaitem.Text = row.Cells["ItemPrice"].Value.ToString();
            }
        }

        private void btnBuatPenawaran_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbNamaitem.Text) && !string.IsNullOrEmpty(tbHargaitem.Text))
            {
                string namaItem = tbNamaitem.Text;
                string kategori = tbKtgitem.Text;
                int hargaAwal = int.Parse(tbHargaitem.Text);
                int itemID = int.Parse(dataGridView1.SelectedRows[0].Cells["ItemID"].Value.ToString());

                int userID = loggedInUser.userID;
                string userName = loggedInUser.userName;
                string userEmail = loggedInUser.userEmail;
                string userPass = loggedInUser.userPass;
                string userAddress = loggedInUser.userAddress;

                buatPenawaranForm buatPenawaranForm = new buatPenawaranForm();
                buatPenawaranForm.ShowDialaog();
            }
            else
            {
                MessageBox.Show("Silahkan pilih produk terlebih dahulu.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnMuatproduk_Click(object sender, EventArgs e)
        {
            LoadProduk();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
