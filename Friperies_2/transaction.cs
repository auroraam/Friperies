using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
using Newtonsoft.Json;

namespace Friperies_2
{
    public class Transaction : User
    {
        private int _transactionID;
        private int _itemID;
        private int _sellerID;
        private int _buyerID;
        private DateTime _transactionDate;
        private string _transactionStatus;
        private string _transactionService;

        public Transaction(int userID, int transactionID, int itemID)
            : base ()
        {
            _transactionID = transactionID;
            _itemID = itemID;
            _buyerID = userID;
            _transactionDate = DateTime.Now;
            _transactionStatus = "Pembayaran";
            _transactionService = null;
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

        public string TransactionService
        {
            get { return _transactionService;}
            set { _transactionService = value;}
        }

        protected const string apiKey = "c31a7ac4eaed9d6d966f5af4cf2aa4b9";
        protected const string baseUrl = "https://api.rajaongkir.com/starter/";

        public static List<string> GetKotaList()
        {
            List<string> returnList = new List<string>();
            var client = new RestClient($"{baseUrl}city");
            var request = new RestRequest(Method.GET);
            request.AddHeader("key", apiKey);
            IRestResponse response = client.Execute(request);
            JsonObject obj = (JsonObject)SimpleJson.DeserializeObject(response.Content);
            JsonObject rajaObj = (JsonObject)obj["rajaongkir"];
            JsonArray cityListArray = (JsonArray)rajaObj["results"];
            foreach (JsonObject city in cityListArray)
            {
                returnList.Add((string)city["city_name"]);
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
            JsonObject obj = (JsonObject)SimpleJson.DeserializeObject(response.Content);
            JsonObject rajaObj = (JsonObject)obj["rajaongkir"];
            JsonArray cityListArray = (JsonArray)rajaObj["results"];
            foreach (JsonObject city in cityListArray)
            {
                if (((string) city["city_name"]) == kota)
                {
                    idKota = int.Parse((string)city["city_id"]);
                    break;
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
            Console.WriteLine("Response Content: " + response.Content);

            if (!response.IsSuccessful)
            {
                throw new Exception($"API call failed: {response.StatusCode} - {response.Content}");
            }

            JsonObject obj = (JsonObject)SimpleJson.DeserializeObject(response.Content);
            if (!obj.ContainsKey("rajaongkir"))
            {
                throw new Exception("Unexpected response structure: 'rajaongkir' key not found.");
            }

            JsonObject rajaObj = (JsonObject)obj["rajaongkir"];
            if (!rajaObj.ContainsKey("results"))
            {
                throw new Exception("Unexpected response structure: 'results' key not found.");
            }
            JsonArray resultsArray = (JsonArray)rajaObj["results"];
            JsonObject courierInfo = (JsonObject)resultsArray[0];
            JsonArray servicesArray = (JsonArray)courierInfo["costs"];
            foreach (JsonObject service in servicesArray)
            {
                string layanan = (string)courierInfo["name"];
                layanan += "-" + (string)service["service"];
                JsonArray detail = (JsonArray)service["cost"];
                JsonObject infoService = (JsonObject)detail[0];
                layanan += " Rp" + (infoService["value"]).ToString();
                layanan += " " + (string)infoService["etd"] + "Hari";
                returnList.Add(layanan);
            }
            return returnList;
        }
    }
}
