using PRG282_Milestone2.DataLayer;

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