using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PRG282_Milestone2.BusinessLogicLayer;

using PRG282_Milestone2.PresentationLayer;
using PRG282_Milestone2.DataLayer;

namespace PRG282_Milestone2.DataLayer
{
    internal class User
    {
        private string _username;
        private string _password;

        public User()
        {
        }

        public User(string username, string password)
        {
            Username = username;
            Password = password;
        }

        public string Username { get => _username; set => _username = value; }
        public string Password { get => _password; set => _password = value; }
    }
}
