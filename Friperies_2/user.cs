using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Friperies_2
{
    internal class User
    {
        private int _userID;
        private string _userName;
        private string _userEmail;
        private string _userPass; 
        private string _userAddress;

        public User(int userID, string userName, string userEmail, string userPass, string userAddress)
        {
            _userID = userID;
            _userEmail = userEmail;
            _userPass = userPass;
            _userName = userName;
            _userAddress = userAddress;
        }

        public int userID
        {
            get {return _userID;}
        } 
        public string userName 
        {
            get {return _userName;}
            set {_userName = value;}
        }
        public string userEmail 
        {
            get {return _userEmail;}
            set {_userEmail = value;}
        }
        public string userPass 
        {
            get {return _userPass;}
            set {_userPass = value;}
        }
        public string userAddress 
        {
            get {return _userAddress;}
            set {_userAddress = value;}
        }

        public void UserSignIn()
        {
            // Dummy data
            if (username == "Ara" && password == "test")
            {
                _userID = 1;
                _username = username;
                _email = "ara@email.com";
                _phoneNumber = "081423943";
                _name = "Ara";
                return true;
            }
            else if (username == "Rora" && password == "coba")
            {
                _userID = 2;
                _username = username;
                _email = "rora@email.com";
                _phoneNumber = "0812489102";
                _name = "Rora";
                return true;
            }
            else
            {
                return false;
            }
        }

        public static void UserSignUp(string userName, string userEmail, string userPass, string userAddress, List<User> users)
        {
            // Check if email already exists
            if (users.Any(u => u._userEmail == userEmail))
            {
                Console.WriteLine("Sign up failed. Email is already in use.");
                return;
            }

            // Create a new user
            int newUserID = users.Count + 1; // Simplified way to generate userID
            User newUser = new User(newUserID, userName, userEmail, userPass, userAddress);
            users.Add(newUser);
            Console.WriteLine($"Sign up successful! Welcome, {userName}.");
        }

        public void UserUpdate (int userID, string userName, string userEmail, string userAddress)
        {
            _userID = userID;
            _userName = userName;
            _userEmail = userEmail;
            _userAddress = userAddress;
            Console.WriteLine($"User {userID} updated successfully.");
        }

        public void UserChangePass(int userID, string oldPass, string newPass)
        {
            if (_userID == userID && _userPass == oldPass)
            {
                _userPass = newPass;
                Console.WriteLine("Password updated successfully.");
            }
            else
            {
                Console.WriteLine("Password update failed. Incorrect old password.");
            }
        }

        public void UserDelete(int userID)
        {
            _userID = 0;
            _userEmail = null;
            _userPass = null;
            _userName = null;
            _userAddress = null;
            Console.WriteLine(userName + " Deleted.");
        }
    }
}
