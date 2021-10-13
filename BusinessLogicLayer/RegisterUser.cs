using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PRG282_Milestone2.PresentationLayer;
using PRG282_Milestone2.BusinessLogicLayer;
using PRG282_Milestone2.DataLayer;
using System.IO;
using System.Data;
using System.Data.SqlClient;

namespace PRG282_Milestone2.BusinessLogicLayer
{
    internal class RegisterUser
    {
        private User user = new User();

        public string addUser(string username, string password)
        {
            user.Username = username;
            user.Password = password;

            string newuser = $"{user.Username}, {user.Password}";

            return newuser;
        }

    }
}