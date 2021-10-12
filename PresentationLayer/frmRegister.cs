using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PRG282_Milestone2.PresentationLayer;
using PRG282_Milestone2.BusinessLogicLayer;
using PRG282_Milestone2.DataLayer;

namespace PRG282_Milestone2.PresentationLayer
{
    public partial class frmRegister : Form
    {
        DataHandler Handler = new DataHandler();
        public frmRegister()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            int SNumber = int.Parse(txtSNumber.Text);
            string SName = txtSName.Text;
            string Gender = "";
            int DOB = int.Parse(dtpDOB.Text);
            int Phone = int.Parse(txtPhone.Text);
            string SAddress = txtAddress.Text;
            string MCodes = txtCodes.Text;

            if (rbF.Checked == true)
            {
                Gender = "Female";
            }
            else if (rbM.Checked == true)
            {
                Gender = "Male";
            }
            else
            {
                Gender = "Other";
            }

            try
            {
                if (Handler.RegisterStudent(SNumber, SName, Gender, DOB, Phone, SAddress, MCodes) == "Registration was successful.")
                {
                    frmRegister R = new frmRegister();
                    R.Hide();
                    frmMenu M = new frmMenu();
                    M.Show();
                    MessageBox.Show(Handler.RegisterStudent(SNumber, SName, Gender, DOB, Phone, SAddress, MCodes));
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Somthing went wrong trying to register Student.");
            }
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            int SNumber = int.Parse(txtSNumber.Text);
            string SName = txtSName.Text;
            string Gender = "";
            int DOB = int.Parse(dtpDOB.Text);
            int Phone = int.Parse(txtPhone.Text);
            string SAddress = txtAddress.Text;
            string MCodes = txtCodes.Text;

            if (rbF.Checked == true)
            {
                Gender = "Female";
            }
            else if(rbM.Checked == true)
            {
                Gender = "Male";
            }
            else
            {
                Gender = "Other";
            }

            try
            {
                if (Handler.UpdateStudent(SNumber, SName, Gender, DOB, Phone, SAddress, MCodes) == "Student with number " + SNumber + " was updated.")
                {
                    frmRegister R = new frmRegister();
                    R.Hide();
                    frmMenu M = new frmMenu();
                    M.Show();
                    MessageBox.Show(Handler.RegisterStudent(SNumber, SName, Gender, DOB, Phone, SAddress, MCodes));
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Somthing went wrong trying to register Student.");
            }
        }

        private void frmRegister_Load(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
