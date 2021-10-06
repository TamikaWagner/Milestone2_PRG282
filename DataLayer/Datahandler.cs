using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System.IO;
namespace PRG282_Milestone2.DataLayer
{
    class DataHandler
    {
        public void GetStudents()
        {
            List<Students> StudentDetails = new List<Students>();
            SqlConnection connect = new SqlConnection("Server=HentaiLord69; Database= Student; Integrated Security= SSPI");
            connect.Open();
            SqlCommand Job = new SqlCommand("Select * From DetailStudents", connect);

            SqlDataReader Reader = Job.ExecuteReader();

            Console.WriteLine("test");
        }



        class DH_ReadLogin
        {
            public List<string> ReadLogin()
            {
                try
                {
                    List<string> users = new List<string>();
                    string path = @"C:\Users\franc\Downloads\PRG 282 Project\Milestone2_PRG282\DataLayer\UserLogin.txt";
                    FileStream fstream = new FileStream(path, FileMode.Open, FileAccess.Read);
                    using (StreamReader sReader = new StreamReader(fstream))
                    {
                        string line;
                        while ((line = sReader.ReadLine()) != null)
                        {
                            users.Add(line);
                        }
                        return users;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                    return null;
                }
            }
        }







    }
}
