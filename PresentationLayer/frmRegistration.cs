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
    public partial class frmRegistration : Form
    {
        SqlCommand cmd;
        SqlConnection cn;
        SqlDataReader dr;
        public frmRegistration()
        {
            InitializeComponent();
        }

        private void Regestration_Load(object sender, EventArgs e)
        {/*
             cn = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = :\Users\franc\OneDrive - belgiumcampus.ac.za\study\2nd Year\PRG\PRG 282\assignment\Project\Project_1_PRG\Project_1_PRG\Login.mdf; Integrated Security = True");
             cn.Open();
            */
            this.ActiveControl = txtusername;
        }


        private void BtnRegister_Click_1(object sender, EventArgs e)
        {
            if (txtconfirmpassword.Text != string.Empty || txtpassword.Text != string.Empty || txtusername.Text != string.Empty)
            {
                if (txtpassword.Text == txtconfirmpassword.Text)
                {
                    cmd = new SqlCommand("select * from LoginTable where username='" + txtusername.Text + "'", cn);
                    var dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        dr.Close();
                        MessageBox.Show("Username Already exist please try another ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        dr.Close();
                        cmd = new SqlCommand("insert into LoginTable values(@username,@password)", cn);
                        cmd.Parameters.AddWithValue("username", txtusername.Text);
                        cmd.Parameters.AddWithValue("password", txtpassword.Text);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Your Account is created . Please login now.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Please enter both password same ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please enter value in all field.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLoginredirect_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            frmLogin login = new frmLogin();
            login.ShowDialog();
        }

        private void frmRegistration_Load(object sender, EventArgs e)
        {

        }
    }

}
