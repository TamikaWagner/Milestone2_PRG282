using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System.IO;
using PRG282_Milestone2.PresentationLayer;
using PRG282_Milestone2.BusinessLogicLayer;
using PRG282_Milestone2.DataLayer;

namespace PRG282_Milestone2.DataLayer
{
    class DataHandler
    {

        public SqlConnection connectdb()
        {
            //need to add dbd
            SqlConnection connection = new SqlConnection(@"Server=(local); Initial Catalog=/StudentInfo; Integrated Security=true");


            return connection;
        }

        string conn = "Server =.; Initial Catalog = Student; Integrated Security = SSPI";
        
        public DataHandler() { }

        public List<Students> GetStudents()
        {
            List<Students> AllClients = new List<Students>();
            SqlConnection connect = new SqlConnection(conn);
            if (connect.State != ConnectionState.Open)
            {
                connect.Open();
                string Q = "Select * from DetailsStudent";

                SqlCommand Command = new SqlCommand(Q, connect);
                using (var reader = Command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        AllClients.Add(new Students(int.Parse(reader[0].ToString()), reader[1].ToString(), int.Parse(reader[2].ToString()), reader[3].ToString(), int.Parse(reader[4].ToString()), reader[5].ToString(), reader[6].ToString()));
                    }
                }
            }
            connect.Close();
            return AllClients;
        }

        public string RegisterStudent(int SNumber, string SName, string Gender, int DOB, int Phone, string SAddress, string MCode)
        {
            try
            {
                SqlConnection connection = new SqlConnection(conn);
                connection.Open();
                string Query = $"INSERT INTO DetailsStudent(Student_Number, Student_Name, Gender, Date_Of_Birth, Phone, Student_Address, Module_Codes) VALUES({SNumber}, '{SName}', '{Gender}', '{DOB}', '{Phone}', '{SAddress}', '{MCode}')";
                SqlCommand cmd = new SqlCommand(Query, connection);
                cmd.ExecuteNonQuery();
                connection.Close();
                return "Registration was successful.";
            }
            catch (Exception)
            {
                return "Registration failed.";
            }
        }
        public List<Module> GetModules(SqlConnection connection)
        {
            List<Module> modules = new List<Module>();
            try
            {
                connection.Open();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return modules;

            }


            SqlCommand cmd = new SqlCommand(@"SELECT * FROM tblModules", connection);

            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    modules.Add(new Module(reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3)));
                }
            }
            connection.Close();
            return modules;
        }


        public string DeleteStudent(int StudentNumber)
        {
            SqlConnection connect = new SqlConnection(conn);
            connect.Open();
            string Query = "Delete from DetailsStudent Where Student_Number = '" + StudentNumber + "'";
            SqlCommand Command = new SqlCommand(Query, connect);
            int Rows = Command.ExecuteNonQuery();

            if (StudentNumber >= 0)
            {
                if (Rows > 0)
                {
                    connect.Close();
                    return "Deleted details of Student with the number: " + StudentNumber + ".";
                }
                else
                {
                    connect.Close();
                    return "This Student does not exits.";
                }
            }
            else
            {
                connect.Close();
                return "Please enter a Student number.";
            }
        }

        public List<Students> SearchStudent(int StudentID)
        {
            SqlConnection connect = new SqlConnection(conn);
            List<Students> Found = new List<Students>();
            if (connect.State != ConnectionState.Open)
            {
                connect.Open();
                string Query = "Select * from DeltailsStudent Where Student_Number = '" + StudentID + "'";
                SqlCommand Command = new SqlCommand(Query, connect);
                using (var reader = Command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Found.Add(new Students(int.Parse(reader[0].ToString()), reader[1].ToString(), int.Parse(reader[2].ToString()), reader[3].ToString(), int.Parse(reader[4].ToString()), reader[5].ToString(), reader[6].ToString()));
                    }
                }
            }
            connect.Close();
            return Found;
        }

        public string UpdateStudent(int SNumber, string SName, string Gender, int DOB, int Phone, string SAddress, string MCode)
        {
            SqlConnection connect = new SqlConnection(conn);
            connect.Open();
            string Query = $"Update DetailsStudent set Student_Number = '" + SNumber + "', Student_Name = '" + SName + "', Gender = '" + Gender + "', Date_Of_Birth = '" + DOB + "', Phone = '" + Phone + "', Student_Address = '" + SAddress + "', Module_Code = '" + MCode + "' Where Student_Number = '" + SNumber + "'";

            if (SNumber < 0 && SName != "" && Gender != "" && DOB >= 0 && Phone < 0 && SAddress != "" && MCode != "")
            {
                SqlCommand Command = new SqlCommand(Query, connect);
                int Row = Command.ExecuteNonQuery();
                if (Row > 0)
                {
                    return "Student with number " + SNumber + " was updated.";
                }
                else
                {
                    return "Student with number " + SNumber + " failed to be updated.";
                }
            }
            else
            {
                return "Please enter the required data.";
            }
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
