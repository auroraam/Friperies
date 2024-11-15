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

        private const string apiKey = "c31a7ac4eaed9d6d966f5af4cf2aa4b9";
        private const string baseUrl = "https://api.rajaongkir.com/starter/";

        public List<string> GetKotaList()
        {
            List<string> returnList = new List<string>(;)
            var client = new RestClient($"{baseUrl}city");
            var request = new RestRequest(Method.GET);
            request.AddHeader("key", apiKey);

            IRestResponse response = client.Execute(request);

            var deserializer = new JsonDeserializer();
            var jsonResponse = deserializer.Deserializer<Dictionary<string, object>>(response);

            if (jsonResponse.ContainsKey("rajaongkir"))
            {
                var rajaOngkirData = jsonResponse["rajaongkir"] as Dictionary<string, object>;
                if (rajaOngkirData != null && rajaOngkirData.ContainsKey("results"))
                {
                    var cityListArray = rajaOngkirData["results"] as List<object>;
                    foreach (var city in cityListArray)
                    {
                        var cityData = city as Dictionary<string, object>;
                        if (cityData != null && cityData.ContainsKey("city_name"))
                        {
                            returnList.Add(cityData["city_name"].ToString());
                        }
                    }
                }
            }

            return returnList;
        }

        public static int GetIdKotaList(string kota)
        {
            int idKota = -1;
            var client = new RestClient($"{baseUrl}city");
            var request = new RestRequest(Method.GET);
            request.AddHeader("key", apiKey);

            IRestResponse response = client.Execute(request);
            var deserializer = new JsonDeserializer();
            var jsonResponse = deserializer.Deserialize<Dictionary<string, object>>(response);

            if (jsonResponse.ContainsKey("rajaongkir"))
            {
                var rajaOngkirData = jsonResponse["rajaongkir"] as Dictionary<string, object>;
                if (rajaOngkirData != null && rajaOngkirData.ContainsKey("results"))
                {
                    var cityListArray = rajaOngkirData["results"] as List<object>;
                    foreach (var city in cityListArray)
                    {
                        var cityData = city as Dictionary<string, object>;
                        if (cityData != null && cityData.ContainsKey("city_name") && cityData.ContainsKey("city_id"))
                        {
                            if (cityData["city_name"].ToString().Equals(kota, StringComparison.OrdinalIgnoreCase))
                            {
                                idKota = int.Parse(cityData["city_id"].ToString());
                                break;
                            }
                        }
                    }
                }
            }

            return idKota;
        }

        public static List<string> GetLayananList(int idAsal, int idTujuan, int berat, string kurir)
        {
            List<string> returnList = new List<string>();
            var client = new RestClient($"{baseUrl}cost");
            var request = new RestRequest(Method.POST);
            request.AddHeader("content-type", "application/x-www-form-urlencoded");
            request.AddHeader("key", apiKey);

            request.AddParameter("application/x-www-form-urlencoded",
                $"origin={idAsal}&destination={idTujuan}&weight={berat}&courier={kurir}",
                ParameterType.RequestBody);

            IRestResponse response = client.Execute(request);
            var deserializer = new JsonDeserializer();
            var jsonResponse = deserializer.Deserialize<Dictionary<string, object>>(response);

            if (jsonResponse.ContainsKey("rajaongkir"))
            {
                var rajaOngkirData = jsonResponse["rajaongkir"] as Dictionary<string, object>;
                if (rajaOngkirData != null && rajaOngkirData.ContainsKey("results"))
                {
                    var resultsArray = rajaOngkirData["results"] as List<object>;
                    var courierInfo = resultsArray[0] as Dictionary<string, object>;
                    if (courierInfo != null && courierInfo.ContainsKey("costs"))
                    {
                        var servicesArray = courierInfo["costs"] as List<object>;
                        foreach (var service in servicesArray)
                        {
                            var serviceData = service as Dictionary<string, object>;
                            if (serviceData != null)
                            {
                                string layanan = $"{courierInfo["name"]} - {serviceData["service"]}";

                                var detail = serviceData["cost"] as List<object>;
                                if (detail.Count > 0)
                                {
                                    var infoService = detail[0] as Dictionary<string, object>;
                                    layanan += $" - Rp {infoService["value"]} - {infoService["etd"]} Hari";
                                }

                                returnList.Add(layanan);
                            }
                        }
                    }
                }
            }

            return returnList;
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
