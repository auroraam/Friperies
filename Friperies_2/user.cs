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

        public User()
        {
            _userID = userID;
            _userEmail = userEmail;
            _userPass = userPass;
            _userName = userName;
        }

        public int userID
        {
            get {return _userID;}
            set { _userID = value;}
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
    }
}
