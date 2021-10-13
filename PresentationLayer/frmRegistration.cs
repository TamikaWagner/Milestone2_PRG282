using PRG282_Milestone2.BusinessLogicLayer;
using PRG282_Milestone2.DataLayer;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PRG282_Milestone2.PresentationLayer
{
    public partial class frmRegistration : Form
    {
        private FileHandler db = new FileHandler();
        private RegisterUser ru = new RegisterUser();
        private List<string> exsistingUsers = new List<string>();

        public frmRegistration()
        {
            InitializeComponent();
            exsistingUsers = db.getUsers();
        }

        private void Regestration_Load(object sender, EventArgs e)
        {
        }

        private void btnLoginredirect_Click(object sender, EventArgs e)
        {
            showLogin();
        }

        public void showLogin()
        {

            Hide();
            frmLogin login = new frmLogin();
            login.ShowDialog();
        }

        private void frmRegistration_Load(object sender, EventArgs e)
        {

        }

        private void BtnRegister_Click(object sender, EventArgs e)
        {

            string newUser = ru.addUser(txtusername.Text, txtpassword.Text);
            exsistingUsers.Add(newUser);
            db.addUser(exsistingUsers);
            clearFields();
            showLogin();


        }


        public void clearFields()
        {
            txtusername.Clear();
            txtpassword.Clear();

        }

        private void frmRegistration_Load_1(object sender, EventArgs e)
        {
            this.ActiveControl = txtusername;
        }
    }

}
