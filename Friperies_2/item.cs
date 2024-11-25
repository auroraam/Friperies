using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Friperies_2
{
    public class Item : User
    {
        private int _itemID;
        private string _itemCategory;
        private int _itemPrice;
        private int _ownerItem;

        public Item(int userID, int itemID, string itemCategory, int itemPrice)
            : base()
        {
            _itemID = itemID;
            _itemCategory = itemCategory;
            _itemPrice = itemPrice;
            _ownerItem = userID;
        }
         public new int userID
        {
            get { return base.userID; }
        }

        // Properties
        public int ItemID
        {
            get { return _itemID; }
            set { _itemID = value; }
        }

        public string ItemCategory
        {
            get { return _itemCategory; }
            set { _itemCategory = value; }
        }

        public int ItemPrice
        {
            get { return _itemPrice; }
            set { _itemPrice = value; }
        }

        public int OwnerItem
        {
            get { return _ownerItem; }
            set { _ownerItem = value; }
        }

        public override void delete(int itemid)
        {
            string query = @"DELETE FROM public.""Item"" WHERE ""ItemID"" = @itemID";

            var parameters = new Dictionary<string, object>
            {
                { "@itemID", itemid },
            };

            if (dbConfig.ExecuteDelete(query, parameters, "Produk berhasil dihapus!", "Produk gagal dihapus atau tidak ditemukan."))
            {
                Console.WriteLine($"Item with ID {itemid} deleted.");
            }
        }
    }
}
