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
    public partial class unggahProdukForm : Form
    {
        public unggahProdukForm()
        {
            InitializeComponent();
        }

        private void btnUnggahfotoitem_Click(object sender, EventArgs e)
        {
            string imageLocation = "";
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "JPG files (*.jpg)|*.jpg|PNG files (*.png)|*.png|All files (*.*)|*.*";
                
                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    imageLocation = dialog.FileName;
                    image1.ImageLocation = imageLocation; // Memperbarui lokasi gambar untuk PictureBox
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Fail!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private btnUnggahitem_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                sql = @"INSERT INTO Item (ItemName, ItemCategory, ItemPrice, OwnerItem, LikesCounter) 
                        VALUES ($1, $2, $3, $4, 0) RETURNING ItemID";
                cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("$1", tbNamaitem.Text);
                cmd.Parameters.AddWithValue("$2", tbKtgitem.Text);
                cmd.Parameters.AddWithValue("$3", Convert.ToInt32(tbHargaitem.Text)); 
                cmd.Parameters.AddWithValue("$4", 101); 

                int newItemID = (int)cmd.ExecuteScalar();

                MessageBox.Show($"Data Produk Berhasil diunggah dengan ID: {newItemID}", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                tbNamaitem.Text = rtbDesitem.Text = tbKtgitem.Text = tbHargaitem.Text = "";
                image1.Image = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Upload Failed!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to log out?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Hide(); 
                
                signinForm signinForm = new signinForm();
                signinForm.ShowDialog(); 
            }
        }

        private void btnExit_Click (object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
