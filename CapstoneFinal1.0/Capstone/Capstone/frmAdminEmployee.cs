using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Capstone
{
    public partial class frmAdminEmployee : Form
    {
        public frmAdminEmployee()
        {
            InitializeComponent();
        }

        private void employeesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.employeesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.capstone_Project_FinalDataSet);

        }

        private void frmAdmin_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'capstone_Project_FinalDataSet.Employees' table. You can move, or remove it, as needed.
            this.employeesTableAdapter.Fill(this.capstone_Project_FinalDataSet.Employees);

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form welcomeForm = new frmWelcome();
            welcomeForm.Owner = this;
            welcomeForm.Show();
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
