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
using PRG282_Milestone2.PresentationLayer;
using PRG282_Milestone2.BusinessLogicLayer;
using PRG282_Milestone2.DataLayer;

namespace PRG282_Milestone2.PresentationLayer
{
    public partial class frmMenu : Form
    {
        List<Students> StudentDetails = new List<Students>();
        BindingSource source = new BindingSource();
        DataHandler Handler = new DataHandler();

        public frmMenu()
        {
            InitializeComponent();
            DataHandler Handler = new DataHandler();
            StudentDetails = Handler.GetStudents();
            dgvStudents.DataSource = source;
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            txtSearch.Visible = false;
            btnUp.Enabled = false;
            btnRegister.Enabled = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            lblSearch.Visible = true;
            btnSearch.Visible = true;
            txtSearch.Visible = true;
        }

        private void lblUp_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text.Length > 0)
            {
                btnDel.Visible = true;
                lblDel.Visible = true;
            }
            else
            {
                MessageBox.Show("Please enter a ID number.");
            }
        }

        private void dgvStudents_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            frmMenu M = new frmMenu();
            M.Hide();
            frmRegisterStudent R = new frmRegisterStudent();
            R.Show();
        }

        private void lblUp_Click_1(object sender, EventArgs e)
        {

        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            pnlStudents.Visible = true;
            try
            {
                source.DataSource = StudentDetails;
                txtSearch.Visible = true;
                btnDel.Visible = true;
                lblSearch.Visible = true;
                lblDel.Visible = true;
                btnSearch.Visible = true;
                source.DataSource = StudentDetails;
            }
            catch (Exception)
            {
                MessageBox.Show("Something went wrong trying to retrieve Student information.");
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            try
            {
                int StudentID = int.Parse(txtSearch.Text);
                Handler.DeleteStudent(StudentID);
                MessageBox.Show(Handler.DeleteStudent(StudentID));
            }
            catch (Exception)
            {
                MessageBox.Show("Failed to delete Student.");
            }
        }

        private void btnSearch_Click_1(object sender, EventArgs e)
        {
            try
            {
                int IDSearch = int.Parse(txtSearch.Text);
                source.DataSource = null;
                source.DataSource = Handler.SearchStudent(IDSearch);
            }
            catch (Exception)
            {
                MessageBox.Show("Something went wrong trying to search for Student information.");
            }
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAdd_Up_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmRegisterStudent register = new frmRegisterStudent();
            register.Show();
        }

        private void dgvStudents_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
             if (e.RowIndex >= 0)
                {
                    DataGridViewRow Rows = this.dgvStudents.Rows[e.RowIndex];
                    txtSearch.Text = Rows.Cells["Studentnumber"].Value.ToString();
                }
        }

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

        private void btnMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmNavigation navi = new frmNavigation();
            navi.Show();
        }
    }
}
