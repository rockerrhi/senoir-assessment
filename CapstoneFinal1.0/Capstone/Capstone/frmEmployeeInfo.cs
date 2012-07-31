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
    public partial class frmEmployeeInfo : Form
    {
        public frmEmployeeInfo()
        {
            InitializeComponent();
        }
        private bool IsValidData()
        {
            return Validator.IsPresent(lastNameTextBox) &&
                Validator.IsPresent(firstNameTextBox) &&
                Validator.IsPresent(dateofBirthTextBox) &&
                Validator.IsPresent(employeeIDTextBox1) &&
                Validator.IsPresent(usernameTextBox) &&
                Validator.IsPresent(passwordTextBox);
        }
        private void frmEmployeeInfo_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'capstone_Project_FinalDataSet.Employees' table. You can move, or remove it, as needed.
            //this.employeesTableAdapter.Fill(this.capstone_Project_FinalDataSet.Employees);
        }
        private void employeesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.employeesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.capstone_Project_FinalDataSet);

        }
        private void btnNew_Click(object sender, EventArgs e)
        {
            this.employeesBindingSource.AddNew();
            lastNameTextBox.ReadOnly = false;
            firstNameTextBox.ReadOnly = false;
            dateofBirthTextBox.ReadOnly = false;
            employeeIDTextBox1.ReadOnly = false;
            passwordTextBox.ReadOnly = false;
            usernameTextBox.ReadOnly = false;

            btnNew.Enabled = false;
            btnSave.Enabled = true;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (IsValidData())
                {
                    this.Validate();
                    this.employeesBindingSource.EndEdit();
                    this.tableAdapterManager.UpdateAll(this.capstone_Project_FinalDataSet);

                    lastNameTextBox.Clear();
                    firstNameTextBox.Clear();
                    dateofBirthTextBox.Clear();
                    employeeIDTextBox1.Clear();
                    passwordTextBox.Clear();
                    usernameTextBox.Clear();

                    lastNameTextBox.ReadOnly = true;
                    firstNameTextBox.ReadOnly = true;
                    dateofBirthTextBox.ReadOnly = true;
                    employeeIDTextBox1.ReadOnly = true;
                    passwordTextBox.ReadOnly = true;
                    usernameTextBox.ReadOnly = true;
                    btnNew.Enabled = true;
                }
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }
        private void tsBtnBack_Click(object sender, EventArgs e)
        {
            Form welcomeForm = new frmWelcome();
            welcomeForm.Owner = this;
            welcomeForm.Show();
            this.Hide();
        }
        private void tsBtnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                this.employeesTableAdapter.SearchByLastName(capstone_Project_FinalDataSet.Employees, tsTxtLastName.Text);
                lastNameTextBox.ReadOnly = true;
                firstNameTextBox.ReadOnly = true;
                dateofBirthTextBox.ReadOnly = true;
                employeeIDTextBox1.ReadOnly = true;
                passwordTextBox.ReadOnly = true;
                usernameTextBox.ReadOnly = true;

                btnNew.Enabled = true;
                btnSave.Enabled = false;
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
