using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

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
    }
}
