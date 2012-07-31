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
    public partial class frmAdminPatient : Form
    {
        public frmAdminPatient()
        {
            InitializeComponent();
        }

        private void patientBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.patientBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.capstone_Project_FinalDataSet);

        }

        private void frmAdminPatient_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'capstone_Project_FinalDataSet.Patient' table. You can move, or remove it, as needed.
            this.patientTableAdapter.Fill(this.capstone_Project_FinalDataSet.Patient);

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form welcomeForm = new frmWelcome();
            welcomeForm.Owner = this;
            welcomeForm.Show();
            this.Hide();
        }
    }
}
