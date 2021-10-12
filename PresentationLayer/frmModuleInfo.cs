using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PRG282_Milestone2.PresentationLayer;
using PRG282_Milestone2.BusinessLogicLayer;
using PRG282_Milestone2.DataLayer;

namespace PRG282_Milestone2.PresentationLayer
{
    public partial class frmModuleInfo : Form
    {
        DataHandler Handler = new DataHandler();
        BindingSource Source = new BindingSource();
        List<Module> ModuleDetails = new List<Module>();
        public frmModuleInfo()
        {
            InitializeComponent();
        }

        private void frmSearchStudents_Load(object sender, EventArgs e)
        {
            //this.ActiveControl = txt_SStudentID;
        }

        private void btn_SReg_Click(object sender, EventArgs e)
        {

        }

        private void btn_SReturn_Click(object sender, EventArgs e)
        {
            this.Hide(); ;
            frmNavigation navi = new frmNavigation();
        }

        private void pnlStudentDetails_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
