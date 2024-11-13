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
    public partial class penawaranBuyerForm : Form
    {
        public User loggedInUser;
        public penawaranBuyerForm()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            homePageForm homePageForm = new homePageForm(loggedInUser);
            homePageForm.Show();
        }

        private void btCheckOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            buatPesananForm buatPesananForm = new buatPesananForm();
            buatPesananForm.Show();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            profilForm profilForm = new profilForm(loggedInUser);
            profilForm.Show();
        }
    }
}
