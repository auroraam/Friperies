using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Friperies_2
{
    internal class Item
    {
        private int _itemID;
        private string _itemCategory;
        private int _itemPrice;
        private int _ownerItem;
        private bool _itemLikes;
        private int _likesCounter;

        public Item(int itemID, string itemCategory, int itemPrice, int userID)
        {
            _itemID = itemID;
            _itemCategory = itemCategory;
            _itemPrice = itemPrice;
            _itemLikes = false;
            _likesCounter = 0;
            _ownerItem = userID;
        }

        // Properties
        public int ItemID
        {
            get { return _itemID; }
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
        }
        public bool ItemLikes
        {
            get { return _itemLikes; }
            private set { _itemLikes = value; }
        }

        public int LikesCounter
        {
            get { return _likesCounter; }
            private set { _likesCounter = value; }
        }

        public void NewItem(int  itemID, string itemCategory, int itemPrice, int userID)
        {
            _itemID = itemID;
            _itemCategory = itemCategory;
            _itemPrice = itemPrice;
            _ownerItem = userID;
        }

        public void ItemUpdate(int itemID, string itemCategory, int itemPrice)
        {
            _itemID = itemID;
            _itemCategory = itemCategory;
            _itemPrice = itemPrice;
            Console.WriteLine($"Item {_itemID} updated successfully.");
        }

        public void ItemDelete(int itemID)
        {
            //removing data from database
            return;
        }

        // Method to add a like to the item
        public void LikeItem(string itemID)
        {
            if (!_itemLikes)
            {
                _itemLikes = true;
                _likesCounter++;
                Console.WriteLine($"Item {itemID} liked! Total likes: {_likesCounter}");
            }
            else
            {
                Console.WriteLine($"Item {itemID} is already liked.");
            }
        }
        
        public static void ShowCategory(List<Item> items, string itemCategory)
        {
            Console.WriteLine($"Items for category: {itemCategory}");
            foreach (var item in items)
            {
                if (item._itemCategory == itemCategory)
                {
                    //displaying item info
                    return;
                }
            }
        }
    }
}
