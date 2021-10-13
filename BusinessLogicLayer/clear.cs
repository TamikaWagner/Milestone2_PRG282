using PRG282_Milestone2.DataLayer;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PRG282_Milestone2.BusinessLogicLayer
{
    internal class clear
    {
        DataHandler datah = new DataHandler();

        public void clearFieldsLogIn(TextBox txtName, TextBox txtPass)

        {
            txtName.Clear();
            txtPass.Clear();
        }
        public void fillCBXModule(ComboBox cbx)
        {
            List<Module> lmod = new List<Module>();
            lmod = datah.GetModules(datah.connectdb());
            foreach (Module module in lmod)
            {
                cbx.Items.Add(module.Module_ID);
            }
        }

        public void fillUpdateCBX(ComboBox cbx, ListBox lbx, List<Module> lmod)
        {
            foreach (Module mod in lmod)
            {
                if (!lbx.Items.Contains(mod.Module_ID))
                {
                    cbx.Items.Add(mod.Module_ID);
                }
            }
        }

        public void AddModuleLBX(ListBox lbxModules, ComboBox cbxModule)
        {
            if (cbxModule.Text == "")
            {
                MessageBox.Show("Please select a module to add");
            }
            else
            {
                lbxModules.Items.Add(cbxModule.SelectedItem);
                cbxModule.Items.Remove(cbxModule.SelectedItem);
                cbxModule.Text = "";
            }
        }

        public void RemoveModuleLBX(ListBox lbxModules, ComboBox cbxModule)
        {
            if (lbxModules.SelectedIndex == -1)
            {
                MessageBox.Show("Select Item to remove");
            }
            else
            {
                cbxModule.Items.Add(lbxModules.SelectedItem);
                lbxModules.Items.Remove(lbxModules.SelectedItem);
            }
        }
    }
}