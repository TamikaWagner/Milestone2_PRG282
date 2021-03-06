using PRG282_Milestone2.BusinessLogicLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;


namespace PRG282_Milestone2.DataLayer
{
    class DataHandler
    {
        public string conn = "Data source=.;Initial Catalog=StudentInfo;Integrated security=True";

        public SqlConnection connectdb()
        {
            //need to add dbd
            SqlConnection connection = new SqlConnection(conn);
            return connection;
        }

        public DataHandler() { }

        public List<Students> GetStudents()
        {
            List<Students> AllClients = new List<Students>();
            SqlConnection connect = new SqlConnection(conn);
            if (connect.State != ConnectionState.Open)
            {
                connect.Open();
                string Q = "Select * from StudentDetails";

                SqlCommand Command = new SqlCommand(Q, connect);
                using (var reader = Command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        AllClients.Add(new Students(int.Parse(reader[0].ToString()), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString(), int.Parse(reader[6].ToString())));
                    }
                }
            }
            connect.Close();
            return AllClients;
        }

        public string RegisterStudent(int SNumber, string SName, string Gender, string DOB, string Phone, string SAddress, int MCode)
        {
            SqlConnection connect = new SqlConnection(conn);
            connect.Open();
            string Query = $"Insert Into StudentDetails(Student_Number, Student_Name, Gender, Date_Of_Birth, Phone , Student_Address, Module_Codes) Values('{SNumber}', '{SName}', '{Gender}', '{DOB}', '{Phone}', '{SAddress}', '{MCode}')";
            if (SNumber > 0 && SName != "" && Gender != "" && DOB != "" && Phone != "" && SAddress != "" && MCode > 0)
            {
                SqlCommand Command = new SqlCommand(Query, connect);
                int Changes = Command.ExecuteNonQuery();
                if (Changes > 0)
                {
                    return "New Student was added.";
                }
                else
                {
                    return "Insertion Failed.";
                }
            }
            else
            {
                connect.Close();
                return "Please enter all the required data.";
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

            string Query = "Select * From ModuleDetails";
            SqlCommand cmd = new SqlCommand(Query, connection);
            SqlDataReader Reader = cmd.ExecuteReader();

            if (Reader.HasRows)
            {
                while (Reader.Read())
                {
                    modules.Add(new Module(int.Parse(Reader[0].ToString()), Reader[1].ToString(), Reader[2].ToString(), Reader[3].ToString()));
                }
            }
            connection.Close();
            return modules;
        }

        public string UpdateModules(int MCode, string MName, string MDescription, string Link)
        {
            SqlConnection connect = new SqlConnection(conn);
            connect.Open();
            string Query = $"Update ModuleDetails set Module_Codes= '" + MCode + "', Module_Name = '" + MName + "', Module_Description = '" + MDescription + "', Module_Link = '" + Link + "' Where Module_Codes = '" + MCode + "'";

            if (MCode > 0)
            {
                if (MName != "" && MDescription != "" && Link != "")
                {
                    SqlCommand Command = new SqlCommand(Query, connect);
                    int Row = Command.ExecuteNonQuery();
                    if (Row > 0)
                    {
                        return "Module with code " + MCode + " was updated.";
                    }
                    else
                    {
                        return "Module with number " + MCode + " failed to be updated.";
                    }
                }
                else
                {
                    return "Please enter data to be updated.";
                }
            }
            else
            {
                return "Please enter the Module code.";
            }
        }

        public string AddModules(int MCode, string MName, string MDescription, string Link)
        {
            SqlConnection connect = new SqlConnection(conn);
            connect.Open();
            string Query = $"Insert Into ModuleDetails(Module_Codes, Module_Name, Module_Description, Module_Link) Values('{MCode}', '{MName}', '{MDescription}', '{Link}')";
            SqlCommand Command = new SqlCommand(Query, connect);
            int RowsChanges = Command.ExecuteNonQuery();
            if (MCode > 0 && MName != "" && MDescription != "" && Link != "")
            {
                if (RowsChanges > 0)
                {
                    return "New Module " + MName + " was added.";
                }
                else
                {
                    return "Inserting " + MName + " failed.";
                }
            }
            else
            {
                connect.Close();
                return "Please enter all the required data.";
            }
        }


        public string DeleteModules(int MCode)
        {
            SqlConnection connect = new SqlConnection(conn);
            connect.Open();
            string Query = "Delete from ModuleDetails Where Module_Codes = '" + MCode + "'";
            SqlCommand Command = new SqlCommand(Query, connect);
            int Rows = Command.ExecuteNonQuery();

            if (MCode >= 0)
            {
                if (Rows >= 0)
                {
                    connect.Close();
                    return "Deleted details of module with the code: " + MCode + "'.";
                }
                else
                {
                    connect.Close();
                    return "This Module does not exits.";
                }
            }
            else
            {
                connect.Close();
                return "Please enter a Module code.";
            }
        }

        public List<Module> SearchModules(int MCode)
        {
            List<Module> FoundList = new List<Module>();
            SqlConnection connect = new SqlConnection(conn);
            if (connect.State != ConnectionState.Open)
            {
                connect.Open();
                string Query = "Select * from ModuleDetails Where Module_Codes= '" + MCode + "'";
                SqlCommand Command = new SqlCommand(Query, connect);
                using (var Reader = Command.ExecuteReader())
                {
                    while (Reader.Read())
                    {
                        FoundList.Add(new Module(int.Parse(Reader[0].ToString()), Reader[1].ToString(), Reader[2].ToString(), Reader[3].ToString()));
                    }
                }
            }
            connect.Close();
            return FoundList;
        }


        public string DeleteStudent(int StudentNumber)
        {
            SqlConnection connect = new SqlConnection(conn);
            connect.Open();
            string Query = "Delete from StudentDetails Where Student_Number = '" + StudentNumber + "'";

            if (StudentNumber > 0)
            {
                SqlCommand Command = new SqlCommand(Query, connect);
                int Rows = Command.ExecuteNonQuery();
                if (Rows >= 0)
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
                string Query = "Select * from StudentDetails Where Student_Number = '" + StudentID + "'";
                SqlCommand Command = new SqlCommand(Query, connect);
                using (var reader = Command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Found.Add(new Students(int.Parse(reader[0].ToString()), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString(), int.Parse(reader[6].ToString())));
                    }
                }
            }
            connect.Close();
            return Found;
        }

        public string UpdateStudent(int SNumber, string SName, string Gender, string DOB, string Phone, string SAddress, int MCode)
        {
            SqlConnection connect = new SqlConnection(conn);
            connect.Open();
            string Query = $"Update StudentDetails set Student_Number = '" + SNumber + "', Student_Name = '" + SName + "', Gender = '" + Gender + "', Date_Of_Birth = '" + DOB + "', Phone = '" + Phone + "', Student_Address = '" + SAddress + "', Module_Codes = '" + MCode + "' Where Student_Number = '" + SNumber + "'";

            if (SNumber > 0)
            {
                if (SName != "" && Gender != "" && DOB != "" && Phone != "" && SAddress != "" && MCode > 0)
                {
                    SqlCommand Command = new SqlCommand(Query, connect);
                    int Row = Command.ExecuteNonQuery();
                    if (Row > 0)
                    {
                        return "Student with number " + SNumber + " was updated.";
                    }
                    else
                    {
                        return "Student with number " + SNumber + " Does not exist.";
                    }
                }
                else
                {
                    return "Please enter data to be updated.";
                }
            }
            else
            {
                return "Please enter the Student number.";
            }
        }

        public byte[] newImage()
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog()
            {
                Filter = "images|*.jpg; *.png",
                ValidateNames = true,
                Multiselect = false
            })
            {
                byte[] bytes = null;
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string imageFileName = openFileDialog.FileName;
                    bytes = File.ReadAllBytes(imageFileName);
                    return bytes;
                }
                return bytes;
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
