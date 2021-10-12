﻿using System;
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
                MessageBox.Show("Somthing went wrong trying to retrieve Student information.");
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
                MessageBox.Show("Somthing went wrong trying to search for Student information.");
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
    }
}
