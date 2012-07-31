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
    public partial class frmWelcome : Form
    {
        public frmWelcome()
        {
            InitializeComponent();
        }

        private void toolPtNew_Click(object sender, EventArgs e)
        {
            Form PatientForm = new frmPatientInfo();
            PatientForm.Owner = this;
            PatientForm.Show();
            this.Hide();
        }
        private void toolNewEmp_Click(object sender, EventArgs e)
        {
            Form EmployeeForm = new frmEmployeeInfo();
            EmployeeForm.Owner = this;
            EmployeeForm.Show();
            this.Hide();
        }
        private void toolAssessment_Click(object sender, EventArgs e)
        {
            Form assessmentForm = new frmAssessment();
            assessmentForm.Owner = this;
            assessmentForm.Show();
            this.Hide();
        }
        private void toolPtInformation_Click(object sender, EventArgs e)
        {
            Form newPatientForm = new frmPatientInfo();
            newPatientForm.Owner = this;
            newPatientForm.Show();
            this.Hide();
        }
        private void tsExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void tsAdminPatient_Click(object sender, EventArgs e)
        {
            Form newPatientAdminForm = new frmAdminPatient();
            newPatientAdminForm.Owner = this;
            newPatientAdminForm.Show();
            this.Hide();
        }
        private void tsAdminEmployee_Click(object sender, EventArgs e)
        {
            Form newEmployeeAdminForm = new frmAdminEmployee();
            newEmployeeAdminForm.Owner = this;
            newEmployeeAdminForm.Show();
            this.Hide();
        }
    }
}
