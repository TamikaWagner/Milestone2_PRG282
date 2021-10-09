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

namespace PRG282_Milestone2.PresentationLayer
{
    public partial class frmMenu : Form
    {
        SqlConnection connect;
        List<Students> StudentDetails = new List<Students>();
        BindingSource source = new BindingSource();
        public frmMenu()
        {
            InitializeComponent();
            DataHandler Handler = new DataHandler();
            dgvStudents.DataSource = source;
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            btnUp.Visible = false;
            txtSearch.Visible = false;
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
                btnUp.Visible = true;
                lblUp.Visible = true;
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

        }
    }
}
