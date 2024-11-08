using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Friperies_2
{
    internal class Transaction : User
    {
        private int _transactionID;
        private int _itemID;
        private int _sellerID;
        private int _buyerID;
        private DateTime _transactionDate;
        private string _transactionStatus;

        public Transaction(int userID, string userName, string userEmail, string userPass, string userAddress, int transactionID, int itemID)
            : base ()
        {
            _transactionID = transactionID;
            _itemID = itemID;  // Mengambil itemID dari item terkait
            //_sellerID = Item.OwnerItem;  // Mengambil sellerID dari ownerItem di kelas Item
            _buyerID = userID;
            _transactionDate = DateTime.Now;
            _transactionStatus = "Pembayaran";
        }

        public int TransactionID
        {
            get {return _transactionID;}
        }

        public int ItemID
        {
            get {return _itemID;}
        }

        public int SellerID
        {
            get {return _sellerID;}
        }

        public int BuyerID
        {
            get {return _buyerID;}
        }

        public DateTime TransactionDate 
        {
            get {return _transactionDate;}
        }

        public string TransactionStatus
        {
            get {return _transactionStatus;}
            set {_transactionStatus = value;}
        }

        public void NewTransaction(int transactionID, int itemID, int userID)
        {
            Item item = Item.items.Find(i => i.ItemID == itemID);
            _transactionID = transactionID;
            _itemID = itemID;  // Mengambil itemID dari item terkait
            _sellerID = item.OwnerItem;  // Mengambil sellerID dari ownerItem di kelas Item
            _buyerID = userID;
            _transactionDate = DateTime.Now;
            _transactionStatus = "Pembayaran";
            Console.WriteLine($"Transaction {transactionID} created.");
        }

        public void TransactionUpdate(int transactionID, string transactionStatus)
        {
            _transactionStatus = transactionStatus;
            Console.WriteLine($"Transaction status updated to {transactionStatus}.");
        }

        public void TransactionDelete(int transactionID) 
        {
            _transactionID = 0;
            _itemID = 0;
            _sellerID = 0; 
            _buyerID = 0;
            _transactionStatus = null;
            Console.WriteLine($"Transaction {transactionID} deleted.");
        }
    }
}
