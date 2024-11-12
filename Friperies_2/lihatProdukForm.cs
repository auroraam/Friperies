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
        public lihatProdukForm()
        {
            InitializeComponent();
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
            homePageForm homePageForm = new homePageForm();
            homePageForm.Show();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            homePageForm homePageForm = new homePageForm();
            homePageForm.Show();
        }
    }
}
