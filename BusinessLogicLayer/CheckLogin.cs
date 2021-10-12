using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Threading;
using PRG282_Milestone2.PresentationLayer;
using PRG282_Milestone2.BusinessLogicLayer;
using PRG282_Milestone2.DataLayer;

namespace PRG282_Milestone2.BusinessLogicLayer
{
  
    
    public delegate void loginDelegate();

    internal class CheckLogin
    {
        public event loginDelegate loginSuccess;

        public void checkLogin(string username, string password, List<string> usernames)
        {
            try
            {
                List<User> users = new List<User>();

                foreach (var name in usernames)
                {
                    string[] entries = name.Split(',');
                    users.Add(new User(entries[0], entries[1].Trim()));
                }
                if (username == "")
                {
                    System.Windows.Forms.MessageBox.Show("Please enter username", "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                    return;

                }
                if (password == "")
                {
                    System.Windows.Forms.MessageBox.Show("Please enter password", "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                    return;
                }

                var user = users.Where(x => x.Username == username && x.Password == password).FirstOrDefault();

                if (user == null)
                {
                    throw new Exception("Login failed!");
                }
                else
                {
                    if (loginSuccess != null)
                    {
                        loginSuccess.Invoke();
                    }
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message, "Error!", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
        }
    }
}