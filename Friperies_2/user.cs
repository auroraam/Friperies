using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace Friperies_2
{
    public class User
    {
        protected int _userID;
        protected string _userName;
        protected string _userEmail;
        protected string _userPass; 
        protected string _userAddress;

        public User()
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

        public bool SignIn(string username, string password)
        {
            string connectionString = "Host = localhost; Port = 5432; Username = ...; Password = ...; Database = ...";

            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                string query = "SELECT * FROM Users WHERE userName = @username AND userPass = @password";
                NpgsqlCommand command = new NpgsqlCommand(query, connection);
                command.Parameters.AddWithValue("username", username);
                command.Parameters.AddWithValue("password", password);

                connection.Open();
                using (NpgsqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        _userID = reader.GetInt32(reader.GetOrdinal("userID"));
                        _userName = reader.GetString(reader.GetOrdinal("userName"));
                        _userEmail = reader.GetString(reader.GetOrdinal("userEmail"));
                        _userPass = reader.GetString(reader.GetOrdinal("userPass"));
                        _userAddress = reader.GetString(reader.GetOrdinal("userAddress"));

                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
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
            User newUser = new User();
            newUserID = newUser.userID;
            string newusername = newUser.userName;
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
