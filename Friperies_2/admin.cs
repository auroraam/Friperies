using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Friperies_2
{
    internal class admin
    {
        private int _adminID;
        private string _adminName;
        private string _adminEmail;
        private string _adminPass;

        public int AdminID
        {
            get {return _adminID;}
        }
        public string AdminName 
        {
            get {return _adminName;}
            set {_adminName = value;}
        }
        public string AdminEmail 
        {
            get {return _adminEmail;}
            set {_adminEmail = value;}
        }
        public string AdminPass 
        {
            get {return _adminPass;}
            set {_adminPass = value;}
        }

        // Method for admin sign in
        public void AdminSignIn(string adminPass, string adminName)
        {
            if (_adminPass == adminPass && _adminName == adminName)
                Console.WriteLine($"Succesfully Signed in.");
            else
                Console.WriteLine("Sign in failed.");
        }

        // Method for admin change pass

        //Method for edit user

        //Method for edit item

        //Method for edit offer

        //Method for edit transaction

    }

}
