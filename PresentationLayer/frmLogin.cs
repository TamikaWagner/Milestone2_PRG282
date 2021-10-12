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
using System.Threading;
using PRG282_Milestone2.PresentationLayer;
using PRG282_Milestone2.BusinessLogicLayer;
using PRG282_Milestone2.DataLayer;

namespace PRG282_Milestone2.PresentationLayer
{
    public partial class frmLogin : Form
    {
        FileHandler db = new FileHandler();
        clear clearbox = new clear();
        CheckLogin loginc = new CheckLogin();
        List<string> usersInSystem = new List<string>();

        public frmLogin()
        {
            InitializeComponent();
      
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            this.ActiveControl = txtusername;
        }

      


        

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            loginc.checkLogin(txtusername.Text, txtpassword.Text , usersInSystem);
        }

        private void brnRegister_Click(object sender, EventArgs e)
        {
             this.Hide();
            frmRegisterStudent registration = new frmRegisterStudent();
            registration.ShowDialog();
        }
    }
}
/*
 * FileHandler db = new FileHandler();
        ComponentController cc = new ComponentController();
        CheckLogin cl = new CheckLogin();
        List<string> usersInSystem = new List<string>();

        public frmLogin()
        {
            InitializeComponent();
        }

        private void linkRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Register registerForm = new Register();
            registerForm.Show();
            Hide();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            cl.checkLogin(txtusernameBoxLogin.Text, txtpasswordBoxLogin.Text, usersInSystem);
            
        }

        private void btnClearLogin_Click(object sender, EventArgs e)
        {
            cc.clearFieldsLogIn(txtusernameBoxLogin,txtpasswordBoxLogin); 
        }


        public void loginSuccessful()
        {
            //frmMain main = new frmMain(txtusernameBoxLogin.Text);
            frmNavigation navigation = new frmNavigation(txtusernameBoxLogin.Text);
            cc.clearFieldsLogIn(txtusernameBoxLogin,txtpasswordBoxLogin);
            navigation.Show();
            Hide();
        }


        private void frmLogin_Load(object sender, EventArgs e)
        {
            cl.loginSuccess += loginSuccessful;
            usersInSystem = db.getUsers();
        }
    }
}
*/