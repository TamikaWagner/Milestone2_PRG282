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
    private string gender;
    private string dob;
    private string phone;
    private string address;
    private int mcode;

    public Students(int studentnumber, string fullname, string gender, string dob, string phone, string address, int mcode)
    {
        this.studentnumber = studentnumber;
        this.fullname = fullname;
        this.gender = gender;
        this.dob = dob;
        this.phone = phone;
        this.address = address;
        this.mcode = mcode;
    }

    public int Studentnumber { get => studentnumber; set => studentnumber = value; }
    public string Fullname { get => fullname; set => fullname = value; }
    public string Gender { get => gender; set => gender = value; }
    public string Dob { get => dob; set => dob = value; }
    public string Phone { get => phone; set => phone = value; }
    public string Address { get => address; set => address = value; }
    public int Mcode { get => mcode; set => mcode = value; }
}
}
