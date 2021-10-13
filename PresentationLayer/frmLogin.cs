using PRG282_Milestone2.BusinessLogicLayer;
using PRG282_Milestone2.DataLayer;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PRG282_Milestone2.PresentationLayer
{
    public partial class frmLogin : Form
    {
        FileHandler db = new FileHandler();
        clear clearbox = new clear();
        CheckLogin cl = new CheckLogin();
        List<string> usersInSystem = new List<string>();

        public frmLogin()
        {
            InitializeComponent();


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
            cl.checkLogin(txtusername.Text, txtpassword.Text, usersInSystem);

        }

        private void brnRegister_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmRegistration registration = new frmRegistration();
            registration.ShowDialog();
        }
        public void loginSuccessful()
        {
            frmNavigation navi = new frmNavigation();
            clearbox.clearFieldsLogIn(txtusername, txtpassword);
            navi.Show();
            Hide();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            cl.loginSuccess += loginSuccessful;
            usersInSystem = db.getUsers();
            this.ActiveControl = txtusername;

        }

        private void image1ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}