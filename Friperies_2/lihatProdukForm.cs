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

        private void btnPenawaran_Click(object sender, EventArgs e)
        {
            this.Hide();
            buatPenawaranForm buatPenawaranForm = new buatPenawaranForm();
            buatPenawaranForm.Show();
        }
    }
}
