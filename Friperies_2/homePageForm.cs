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
        public User loggedInUser;
        public homePageForm(User user)
        {
            InitializeComponent();
            loggedInUser = user;
        }

        private void btnUnggahProduk_Click(object sender, EventArgs e)
        {
            this.Hide();
            unggahProdukForm unggahProdukForm = new unggahProdukForm(loggedInUser);
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
            profilForm profilForm = new profilForm(loggedInUser);
            profilForm.Show(); 
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
