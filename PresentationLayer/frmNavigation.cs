using System;
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
            frmMenu search = new frmMenu();
            search.Show();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMenu f = new frmMenu();
            f.Show();
        }

        private void btnModules_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmModuleInfo MI = new frmModuleInfo();
            MI.Show();
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
