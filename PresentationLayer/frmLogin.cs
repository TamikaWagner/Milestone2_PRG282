using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;


namespace PRG282_Milestone2.PresentationLayer
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            /*cn = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = :\Users\franc\OneDrive - belgiumcampus.ac.za\study\2nd Year\PRG\PRG 282\assignment\Project\Project_1_PRG\Project_1_PRG\Login.mdf; Integrated Security = True");

             cn.Open();*/
            this.ActiveControl = txtusername;
        }



        private void BtnLogin_Click_1(object sender, EventArgs e)
        {
            GetLogin();
        }

        public void GetLogin()
        {
            if (txtpassword.Text != "A".ToLower() || txtusername.Text != "1")
            {
                this.Hide();
                frmMenu home = new frmMenu();
                home.ShowDialog();
            }
            /*else if (txtpassword.Text != string.Empty || txtusername.Text != string.Empty)
            {

                cmd = new SqlCommand("select * from LoginTable where username='" + txtusername.Text + "' and password='" + txtpassword.Text + "'", cn);
                var dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    dr.Close();
                    this.Hide();
                    frmMenu home = new frmMenu();
                    home.ShowDialog();
                }
                else
                {
                    dr.Close();
                    MessageBox.Show("No Account avilable with this username and password ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please enter value in all field.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }*/
        }

        private void brnRegister_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            frmRegistration registration = new frmRegistration();
            registration.ShowDialog();
        }

        private void txtusername_TextChanged(object sender, EventArgs e)
        {

        }
    }
}