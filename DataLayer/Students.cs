using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRG282_Milestone2.DataLayer
{
    class Students
    {
    
    private int studentnumber;
    private string fullname;
    private int dob;
    private string gender;
    private int phone;
    private string address;
    private string mcode;

    public Students(int studentnumber, string fullname, int dob, string gender, int phone, string address, string mcode)
    {
        this.studentnumber = studentnumber;
        this.fullname = fullname;
        this.dob = dob;
        this.gender = gender;
        this.phone = phone;
        this.address = address;
        this.mcode = mcode;
    }

    public int Studentnumber { get => studentnumber; set => studentnumber = value; }
    public string Fullname { get => fullname; set => fullname = value; }
    public int Dob { get => dob; set => dob = value; }
    public string Gender { get => gender; set => gender = value; }
    public int Phone { get => phone; set => phone = value; }
    public string Address { get => address; set => address = value; }
    public string Mcode { get => mcode; set => mcode = value; }
}
}
