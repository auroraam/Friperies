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

        private void profilForm_Load_1(object sender, EventArgs e)
        {
            if (loggedInUser != null)
            {
                tbIdUser.Text = loggedInUser.userID.ToString();
                tbUsername.Text = loggedInUser.userName;
                tbEmail.Text = loggedInUser.userEmail;
                tbPassword.Text = loggedInUser.userPass;
                tbAlamat.Text = loggedInUser.userAddress;

                List<Item> items = new List<Item>();
                items = Item.GetUserItem(loggedInUser.userID);

                foreach (Item item in items)
                {
                    gbProduk.Text += "n/-" + ($"{item.ItemCategory} - Rp{item.ItemPrice} - Likes: {item.LikesCounter}");
                }
            }
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
    }
}
