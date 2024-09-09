using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Friperies_2
{
    internal class Transaction
    {
        private int _transactionID;
        private int _itemID;
        private int _sellerID;
        private int _buyerID;
        private DateTime _transactionDate;
        private string _transactionStatus;

        public Transaction(int transactionID, Item item, int userID)
        {
            _transactionID = transactionID;
            _itemID = item.ItemID;  // Mengambil itemID dari item terkait
            _sellerID = item.OwnerItem;  // Mengambil sellerID dari ownerItem di kelas Item
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

        public void NewTransaction(int transactionID, Item item, int userID)
        {
            _transactionID = transactionID;
            _itemID = item.ItemID;  // Mengambil itemID dari item terkait
            _sellerID = item.OwnerItem;  // Mengambil sellerID dari ownerItem di kelas Item
            _buyerID = userID;
            _transactionDate = DateTime.Now;
            _transactionStatus = "Pembayaran";
        }

        public void TransactionUpdate(int transactionID, string transactionStatus)
        {
            _transactionStatus = transactionStatus;
        }

        public void TransactionDelete(int transactionID) 
        {
            //removing from database
            return;
        }
    }
}
