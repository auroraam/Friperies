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

namespace Friperies_2
{
    public partial class unggahProdukForm : Form
    {
        public User loggedInUser;
        public unggahProdukForm(User user)
        {
            InitializeComponent();
            loggedInUser = user;
        }

        private NpgsqlConnection conn;
        string connstring = dbConfig.ConnectionString;
        public DataTable dt;
        public static NpgsqlCommand cmd;
        private string sql = null;
        private string imageLocation = "";

        private void unggahProdukForm_Load(object sender, EventArgs e)
        {
            conn = new NpgsqlConnection(connstring);
        }

        private void btnUnggahfotoitem_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "JPG files (*.jpg)|*.jpg|PNG files (*.png)|*.png|All files (*.*)|*.*";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    imageLocation = openFileDialog.FileName; // Simpan lokasi gambar
                    pbUnggahitem.Image = new Bitmap(imageLocation); // Tampilkan di PictureBox
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Fail!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUnggahitem_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(imageLocation))
                {
                    MessageBox.Show("Silakan unggah gambar terlebih dahulu.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Membaca file gambar menjadi byte array
                byte[] imageBytes = File.ReadAllBytes(imageLocation);
                string itemCategory = cbKategori.Text;

                conn.Open();
                sql = @"INSERT INTO public.""Item"" (""ItemName"", ""ItemPrice"", ""OwnerItem"", ""ItemImage"", ""ItemCategory"") 
                VALUES (@1, @2, @3, @4, @5) RETURNING ""ItemID""";
                using (NpgsqlCommand cmd = new NpgsqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@1", tbNamaitem.Text);
                    cmd.Parameters.AddWithValue("@2", Convert.ToInt32(tbHargaitem.Text));
                    cmd.Parameters.AddWithValue("@3", loggedInUser.userID);
                    cmd.Parameters.AddWithValue("@4", imageBytes); // Tambahkan byte array gambar
                    cmd.Parameters.AddWithValue("@5", itemCategory);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show($"Data Produk Berhasil", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        tbNamaitem.Text = rtbDesitem.Text = tbHargaitem.Text = "";
                        pbUnggahitem.Image = null; // Reset PictureBox
                        imageLocation = "";
                    }
                    else
                    {
                        MessageBox.Show("Gagal mengunggah", "Upload Failed!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Upload Failed!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }

        private void btnExit_Click_1(object sender, EventArgs e)
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
            homePageForm homePageForm = new homePageForm(loggedInUser);
            homePageForm.Show();
        }
    }
}
