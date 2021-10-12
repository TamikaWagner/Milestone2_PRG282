using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRG282_Milestone2.PresentationLayer
{
    public partial class frmNavigation : Form
    {
        public frmNavigation()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmSearchStudents search = new frmSearchStudents();

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmRegisterStudent register = new frmRegisterStudent();
        }

        private void btnModules_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void frmNavigation_Load(object sender, EventArgs e)
        {

        }
    }
}
