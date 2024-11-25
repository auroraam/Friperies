using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Friperies_2
{
    internal class Offer : User
    {
        protected int _offerID;
        protected int _itemID;
        protected int _ownerOffer;
        protected int _offerPrice;
        protected string _offerStatus;

        public Offer()
            : base()
        {
            _offerID = offerID;
            _itemID = itemID;
            _offerPrice = offerPrice;
            _ownerOffer = userID;
            _offerStatus = "Pending";
        }

        public int offerID
        {
            get { return _offerID; }
        } 

        public int itemID
        {
            get { return _itemID;}
            set { _offerID = value; }
        }

        public int OwnerOffer
        {
            get { return _ownerOffer;}
        }

        public int offerPrice
        {
            get { return _offerPrice; }
            set { _offerPrice = value; }
        }
        
        public string OfferStatus
        {
            get { return _offerStatus; }
            set { _offerStatus = value; }
        }

        public void NewOffer(int offerID, int itemID, int offerPrice, int userID)
        {
            _offerID = offerID;
            _itemID = itemID;
            _offerPrice = offerPrice;
            _ownerOffer = userID;
            _offerStatus = "Pending";
            Console.WriteLine($"Offer {offerID} created.");
        }

        public void OfferUpdate(int offerID, int offerPrice)
        {
            _offerPrice = offerPrice;
            Console.WriteLine($"Offer price updated to {offerPrice}.");
        }

        public override void delete(int offerID)
        {
            string query = @"DELETE FROM public.""Offer"" WHERE ""OfferID"" = @offerID";

            var parameters = new Dictionary<string, object>
            {
                { "@offerID", offerID }
            };

            if (dbConfig.ExecuteDelete(query, parameters, "Penawaran berhasil dihapus!", "Penawaran gagal dihapus atau tidak ditemukan."))
            {
                Console.WriteLine($"Offer with ID {offerID} deleted.");
            }
        }

        public void AcceptOffer(int offerID, int itemID)
        {
            if(_offerStatus == "Pending")
            {
                OfferStatus = "Accepted";
            }
            else
            {
                Console.WriteLine($"Offer {offerID} for item {itemID} is already accepted.");
            }
        }
    }
}
