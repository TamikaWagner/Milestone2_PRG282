using PRG282_Milestone2.DataLayer;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
namespace PRG282_Milestone2.PresentationLayer
{
    public partial class frmRegisterStudent : Form
    {
        DataHandler Handler = new DataHandler();
        public frmRegisterStudent()
        {
            InitializeComponent();
        }

        private byte[] bytes;

        private void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                int SNumber = int.Parse(txtSNumber.Text);
                string SName = txtSName.Text;
                string Gender = "";
                string DOB = dtpDOB.Text;
                string Phone = txtPhone.Text;
                string SAddress = txtAddress.Text;
                int MCodes = int.Parse(txtCodes.Text);

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

                MessageBox.Show(Handler.RegisterStudent(SNumber, SName, Gender, DOB, Phone, SAddress, MCodes));

                if (Handler.RegisterStudent(SNumber, SName, Gender, DOB, Phone, SAddress, MCodes) == "New Student was added.")
                {
                    Handler.RegisterStudent(SNumber, SName, Gender, DOB, Phone, SAddress, MCodes);
                    this.Hide();
                    frmMenu M = new frmMenu();
                    M.Show();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Something went wrong trying to register Student.");
            }
        }

        private void btnUp_Click(object sender, EventArgs e)
        {

            try
            {
                int SNumber = int.Parse(txtSNumber.Text);
                string SName = txtSName.Text;
                string Gender = "";
                string DOB = dtpDOB.Text.ToString();
                string Phone = txtPhone.Text;
                string SAddress = txtAddress.Text;
                int MCodes = int.Parse(txtCodes.Text);

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

                MessageBox.Show(Handler.UpdateStudent(SNumber, SName, Gender, DOB, Phone, SAddress, MCodes));

                if (Handler.UpdateStudent(SNumber, SName, Gender, DOB, Phone, SAddress, MCodes) == "Student with number " + SNumber + " was updated.")
                {
                    frmRegisterStudent R = new frmRegisterStudent();
                    R.Hide();
                    frmMenu M = new frmMenu();
                    M.Show();
                    MessageBox.Show(Handler.RegisterStudent(SNumber, SName, Gender, DOB, Phone, SAddress, MCodes));
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Something went wrong trying to register Student.");
            }
        }

        private void frmRegister_Load(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmNavigation navi = new frmNavigation();
            navi.Show();
        }

        private void pb1_Click(object sender, EventArgs e)
        {
            try
            {
                DataHandler operations = new DataHandler();
                bytes = operations.newImage();
                MemoryStream memoryStream = new MemoryStream(bytes);
                Image image = Image.FromStream(memoryStream);
                pb1.Image = image;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please upload a photo", ex.Message);
            }
        }
    }
}
