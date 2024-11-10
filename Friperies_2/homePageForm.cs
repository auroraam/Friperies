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
    public partial class homePageForm : Form
    {
        public homePageForm()
        {
            InitializeComponent();
        }

        private void btnUnggahProduk_Click(object sender, EventArgs e)
        {
            this.Hide();
            unggahProdukForm unggahProdukForm = new unggahProdukForm();
            unggahProdukForm.Show();
        }

        private void btnLihatProduk_Click(object sender, EventArgs e)
        {
            this.Hide();
            lihatProdukForm lihatProdukForm = new lihatProdukForm();
            lihatProdukForm.Show();
        }

        private void btnProfil_Click(object sender, EventArgs e)
        {
            this.Hide();
            profilForm profilForm = new profilForm();
            profilForm.Show();
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
