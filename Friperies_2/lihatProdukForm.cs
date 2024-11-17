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
    public partial class lihatProdukForm : Form
    {
        public User loggedInUser;
        private NpgsqlConnection conn;
        private string connString = "Host=localhost;Port=5432;Username=postgres;Password=feather0325;Database=friperiesfix";
        private DataGridViewRow row;
        public lihatProdukForm(User user)
        {
            InitializeComponent();
            loggedInUser = user;
            conn = new NpgsqlConnection(connString);
            LoadProduk();
        }

        private void LoadProduk()
        {
            try
            {
                conn.Open();
                string sql = @"select * from public.""Item""";
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

        private void btnBuatPenawaran_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int itemID = int.Parse(dataGridView1.SelectedRows[0].Cells["ItemID"].Value.ToString());
                this.Hide();
                buatPenawaranForm buatPenawaranForm = new buatPenawaranForm(itemID, loggedInUser);
                buatPenawaranForm.Show();
            }
            else
            {
                MessageBox.Show("Silahkan pilih produk terlebih dahulu.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnBack_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            homePageForm homePageForm = new homePageForm(loggedInUser);
            homePageForm.Show();
        }

        private void btnMuatproduk_Click_1(object sender, EventArgs e)
        {
            LoadProduk();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            homePageForm homePageForm = new homePageForm(loggedInUser);
            homePageForm.Show();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                row = dataGridView1.Rows[e.RowIndex];
                tbNamaitem.Text = row.Cells["ItemName"].Value.ToString();
                tbKtgitem.Text = row.Cells["ItemCategory"].Value.ToString();
                tbHargaitem.Text = row.Cells["ItemPrice"].Value.ToString();

                if (row.Cells["ItemImage"].Value != DBNull.Value)
                {
                    byte[] imageData = (byte[])row.Cells["ItemImage"].Value;
                    using (var ms = new MemoryStream(imageData))
                    {
                        pbUnggahitem.Image = Image.FromStream(ms);
                    }
                }
                else
                {
                    pbUnggahitem.Image = null; // Jika data foto kosong
                }
            }
        }
    }
}
