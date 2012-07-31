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
    public partial class frmPatientInfo : Form
    {
        public frmPatientInfo()
        {
            InitializeComponent();
        }
        private bool IsValidData()
        {
            return Validator.IsPresent(sSNMaskedTextBox) &&
                Validator.IsPresent(lastNameTextBox) &&
                Validator.IsPresent(firstNameTextBox) &&
                Validator.IsPresent(middleNameTextBox) &&
                Validator.IsPresent(birthDateDateTimePicker) &&
                Validator.IsPresent(patientIDTextBox) &&
                Validator.IsPresent(genderComboBox);
        }
        private void patientBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.patientBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.capstone_Project_FinalDataSet);

        }
        private void frmPatientInfo_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'capstone_Project_FinalDataSet.Patient' table. You can move, or remove it, as needed.
            //this.patientTableAdapter.Fill(this.capstone_Project_FinalDataSet.Patient);

        }
        private void btnNew_Click(object sender, EventArgs e)
        {
            this.patientBindingSource.AddNew();
            sSNMaskedTextBox.ReadOnly = false;
            lastNameTextBox.ReadOnly = false;
            firstNameTextBox.ReadOnly = false;
            middleNameTextBox.ReadOnly = false;
            birthDateDateTimePicker.Enabled = true;
            patientIDTextBox.ReadOnly = false;
            genderComboBox.Enabled = true;

            btnNew.Enabled = false;
            sSNMaskedTextBox.Focus();
            btnSave.Enabled = true;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (IsValidData())
                {
                    this.Validate();
                    this.patientBindingSource.EndEdit();
                    this.tableAdapterManager.UpdateAll(this.capstone_Project_FinalDataSet);

                    sSNMaskedTextBox.Clear();
                    lastNameTextBox.Clear();
                    firstNameTextBox.Clear();
                    middleNameTextBox.Clear();
                    patientIDTextBox.Clear();
                    genderComboBox.SelectedIndex = -1;


                    btnNew.Enabled = true;
                    sSNMaskedTextBox.Focus();
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
                this.patientTableAdapter.SearchByLastName(this.capstone_Project_FinalDataSet.Patient, tsTxtSSN.Text);

                sSNMaskedTextBox.ReadOnly = true;
                lastNameTextBox.ReadOnly = true;
                firstNameTextBox.ReadOnly = true;
                middleNameTextBox.ReadOnly = true;
                birthDateDateTimePicker.Enabled = false;
                patientIDTextBox.ReadOnly = true;
                genderComboBox.Enabled = false;

                patientIDTextBox1.Clear();

                btnSave.Enabled = true;
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
