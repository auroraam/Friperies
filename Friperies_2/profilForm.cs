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
    public partial class profilForm : Form
    {
        private User loggedInUser;
        public profilForm()
        {
            InitializeComponent();
            //currentUser = loggedInUser;
        }

        private void tbUsername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                MessageBox.Show("Ubah Username", "Username telah diubah. Apakah Anda setuju untuk mengubah Username?", MessageBoxButtons.YesNo);
                if (DialogResult == DialogResult.Yes)
                {
                    //ubah username di db
                }
            }
        }

        private void tbEmail_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                MessageBox.Show("Ubah Email", "Email telah diubah. Apakah Anda setuju untuk mengubah Email?", MessageBoxButtons.YesNo);
                if (DialogResult == DialogResult.Yes)
                {
                    //ubah email di db
                }
            }
        }

        private void tbPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                MessageBox.Show("Ubah Password", "Password telah diubah. Apakah Anda setuju untuk mengubah Username?", MessageBoxButtons.YesNo);
                if (DialogResult == DialogResult.Yes)
                {
                    //ubah password di db
                }
            }
        }

        private void tbAlamat_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                MessageBox.Show("Ubah Alamat", "Alamat telah diubah. Apakah Anda setuju untuk mengubah Username?", MessageBoxButtons.YesNo);
                if (DialogResult == DialogResult.Yes)
                {
                    //ubah alamat di db
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            homePageForm homePageForm = new homePageForm();
            homePageForm.Show();
        }

        private void btProduk_Click(object sender, EventArgs e)
        {
            this.Hide();
            produkSellerForm produkSeller = new produkSellerForm();
            produkSeller.Show();
        }

        private void btPenawaran_Click(object sender, EventArgs e)
        {
            this.Hide();
            penawaranBuyerForm penawaranBuyer = new penawaranBuyerForm();
            penawaranBuyer.Show();
        }

        private void btPesanan_Click(object sender, EventArgs e)
        {

        }

        private void tbAlamat_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
