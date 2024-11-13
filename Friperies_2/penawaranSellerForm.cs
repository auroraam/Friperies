using Npgsql;
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
    public partial class penawaranSellerForm : Form
    {
        public User loggedInUser;
        public penawaranSellerForm()
        {
            InitializeComponent();
        }

        private NpgsqlConnection conn;
        string connstring = "Host = localhost; Port = 5432; Username = postgres; Password = Fhpduadua22; Database = Friperies";
        public DataTable dt;
        public static NpgsqlCommand cmd;
        private string sql = null;
        private DataGridViewRow r;

        private void penawaranForm_Load(object sender, EventArgs e)
        {
            conn = new NpgsqlConnection(connstring);
        }

        private void btnOfferload_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                dataGridView1.DataSource = null;
                sql = "SELECT * FROM Offer";
                cmd = new NpgsqlCommand(sql, conn);
                dt = new DataTable();
                NpgsqlDataReader rd = cmd.ExecuteReader();
                dt.Load(rd);
                dataGridView1.DataSource = dt;

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Fail!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dataGridView1.SelectedRows[0];
                tbOffernamaitem.Text = row.Cells["ItemName"].Value.ToString();
                tbOfferhargaitem.Text = row.Cells["OfferPrice"].Value.ToString();
            }
        }

        private void btnOfferterima_Click(object sender, EventArgs e)
        {
            UpdateOfferStatus("Accepted");
        }

        private void btnOffertolak_Click(object sender, EventArgs e)
        {
            UpdateOfferStatus("Rejected");
        }

        private void UpdateOfferStatus(string status)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int offerId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["OfferId"].Value);

                try
                {
                    conn.Open();
                    sql = "UPDATE Offer SET OfferStatus = $1 WHERE OfferId = $2";
                    cmd = new NpgsqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("$1", status);
                    cmd.Parameters.AddWithValue("$2", offerId);
                    cmd.ExecuteNonQuery();
                    // Refresh DataGridView setelah update
                    btnOfferload_Click(null, null);
                    MessageBox.Show($"Penawaran {offerId} telah di {status.ToLower()}.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Fail!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Pilih penawaran untuk di perbarui.");
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

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            produkSellerForm produkSellerForm = new produkSellerForm();
            produkSellerForm.Show();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            homePageForm homePageForm = new homePageForm(loggedInUser);
            homePageForm.Show();
        }
    }
}
