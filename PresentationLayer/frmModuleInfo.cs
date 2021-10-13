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
            dgvModules.DataSource = Source;
            ModuleDetails = Handler.GetModules(Handler.connectdb());
        }

        private void frmSearchStudents_Load(object sender, EventArgs e)
        {
            //this.ActiveControl = txt_SStudentID;
        }

        private void btn_SReg_Click(object sender, EventArgs e)
        {
            //try
            //{
                int MNumber = int.Parse(txtMNumber.Text);
                string MName = txtMName.Text;
                string MDesc = txtMDesc.Text;
                string MLink = txtMLink.Text;
                Handler.AddModules(MNumber, MName, MDesc, MLink);
                MessageBox.Show(Handler.AddModules(MNumber, MName, MDesc, MLink));
            //}
            //catch (Exception)
            //{
                //string MName = txtMName.Text;
                //MessageBox.Show($"Smoething went wrong trying to add {MName} as a new Module.");
            //}
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
                Source.DataSource = null;
                Source.DataSource = ModuleDetails;
                lblDel.Visible = true;
                lblSearch.Visible = true;
                btnDel.Visible = true;
                txtSearch.Visible = true;
                pnlModuleD.Visible = true;
                btnSearch.Visible = true;
            }
            catch (Exception)
            {
                MessageBox.Show("Something went wrong getting the data.");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            try
            {
                int MNumber = int.Parse(txtSearch.Text);
                Handler.DeleteModules(MNumber);
                MessageBox.Show(Handler.DeleteModules(MNumber));
            }
            catch (Exception)
            {
                MessageBox.Show("Something went wrong trying to delete the data.");
            }
        }

        private void dgvModules_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow Rows = this.dgvModules.Rows[e.RowIndex];
                txtSearch.Text = Rows.Cells["Module_ID"].Value.ToString();
                txtMNumber.Text = Rows.Cells["Module_ID"].Value.ToString();
                txtMName.Text = Rows.Cells["Module_Name"].Value.ToString();
                txtMDesc.Text = Rows.Cells["Module_Description"].Value.ToString();
                txtMLink.Text = Rows.Cells["Module_Link"].Value.ToString();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                int SModule = int.Parse(txtSearch.Text);
                Source.DataSource = null;
                Source.DataSource = Handler.SearchModules(SModule);
                
            }
            catch (Exception)
            {
                int SModule = int.Parse(txtSearch.Text);
                MessageBox.Show("Something went wrong trying to search for Module number: " + SModule);
            }
        }

        private void brnReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmNavigation FN = new frmNavigation();
            FN.Show();
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            int MNumber = int.Parse(txtMNumber.Text);
            string MName = txtMName.Text;
            string MDesc = txtMDesc.Text;
            string MLink = txtMLink.Text;
            Handler.UpdateModules(MNumber, MName, MDesc, MLink);
            MessageBox.Show(Handler.UpdateModules(MNumber, MName, MDesc, MLink));
        }
    }
}
