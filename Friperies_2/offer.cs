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
        protected bool _offerStatus;

        public Offer()
            : base()
        {
            _offerID = offerID;
            _itemID = itemID;
            _offerPrice = offerPrice;
            _ownerOffer = userID;
            _offerStatus = false;
        }

        public int offerID
        {
            get { return _offerID; }
        } 

        public int itemID
        {
            get { return _itemID;}
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
        
        public bool OfferStatus
        {
            get { return _offerStatus; }
            private set { _offerStatus = value; }
        }

        public void NewOffer(int offerID, int itemID, int offerPrice, int userID)
        {
            _offerID = offerID;
            _itemID = itemID;
            _offerPrice = offerPrice;
            _ownerOffer = userID;
            _offerStatus = false;
            Console.WriteLine($"Offer {offerID} created.");
        }

        public void OfferUpdate(int offerID, int offerPrice)
        {
            _offerPrice = offerPrice;
            Console.WriteLine($"Offer price updated to {offerPrice}.");
        }

        public void OfferDelete(int offerID)
        {
            _offerID = 0;
            _itemID = 0;
            _offerPrice = 0;
            _ownerOffer = 0;
            _offerStatus = false;
            Console.WriteLine($"Offer {offerID} deleted.");
        }

        public void AcceptOffer(int offerID, int itemID)
        {
            if(!_offerStatus)
            {
                OfferStatus = true;
            }
            else
            {
                Console.WriteLine($"Offer {offerID} for item {itemID} is already accepted.");
            }
        }
    }
}
