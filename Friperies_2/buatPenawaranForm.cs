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
    public partial class buatPenawaranForm : Form
    {
        public buatPenawaranForm()
        {
            InitializeComponent();
        }

        private void buatPenawaranForm_Load(object sender, EventArgs e)
        {

        }

        private void lblUnggahdesitem_Click(object sender, EventArgs e)
        {

        }

        private void lblBuatpenawaranitem_Click(object sender, EventArgs e)
        {

        }

        private void tbKtgitem_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            homePageForm homePageForm = new homePageForm();
            homePageForm.Show();
        }

        private void btnExit2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnBuatpenawaran_Click(object sender, EventArgs e)
        {
            //save offer ke db, terus back to lihat produk
        }

        private void btnBuatpenawaranbatal_Click(object sender, EventArgs e)
        {
            this.Hide();
            lihatProdukForm lihatProdukForm = new lihatProdukForm();
            lihatProdukForm.Show();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide(); 
            previousForm.Show(); 
        }
    }
}
