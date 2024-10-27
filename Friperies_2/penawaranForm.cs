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
    public partial class penawaranForm : Form
    {
        public penawaranForm()
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
                dvgData.DataSource = null;
                sql = "SELECT * FROM Offers";
                cmd = new NpgsqlCommand(sql, conn);
                dt = new DataTable();
                NpgsqlDataReader rd = cmd.ExecuteReader();
                dt.Load(rd);
                dvgData.DataSource = dt;

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Fail!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvOffers_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvOffers.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvOffers.SelectedRows[0];
                tbOffernamaitem.Text = row.Cells["ItemName"].Value.ToString();
                tbHargaitem.Text = row.Cells["OfferPrice"].Value.ToString();
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
