using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;
using PRG282_Milestone2.PresentationLayer;
using PRG282_Milestone2.BusinessLogicLayer;
using PRG282_Milestone2.DataLayer;

namespace PRG282_Milestone2.DataLayer
{
  
  internal class FileHandler
    {
        public FileHandler()
        {
        }

        private string users = $"{AppContext.BaseDirectory}Users.txt";

        public List<string> getUsers()
        {
            FileStream Stream = new FileStream(users, FileMode.OpenOrCreate);
            List<string> usernames = new List<string>();
            try
            {
                string text;
                using (StreamReader reader = new StreamReader(Stream, Encoding.UTF8))
                {
                    while ((text = reader.ReadLine()) != null)
                    {
                        usernames.Add(text);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return usernames;
        }

        public void addUser(List<string> newUser)
        {
            File.WriteAllLines(users, newUser);
        }
    }
}