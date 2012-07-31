using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Capstone
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        private bool IsValidData()
        {
            return Validator.IsPresent(txtUsername) &&
                Validator.IsPresent(txtPassword);
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (IsValidData())
            {
                string username = Convert.ToString(txtUsername.Text);
                string password = Convert.ToString(txtPassword.Text);
                try
                {
                    this.employeesTableAdapter.GetPassword(capstone_Project_FinalDataSet.Employees, username);
                    if (txtUsername.Text == usernameTextBox.Text)
                    {
                        if (password == passwordTextBox.Text)
                        {
                            Form welcomeForm = new frmWelcome();
                            welcomeForm.Owner = this;
                            welcomeForm.Show();
                            this.Hide();
                            
                        }
                        else
                        {
                            MessageBox.Show("This username or password does not exist or is incorrect", "Invalid Login");
                            txtPassword.Clear();
                            txtPassword.Focus();
                            passwordTextBox.Clear();
                            usernameTextBox.Clear();
                        }
                    }
                    else
                    {
                        MessageBox.Show( "This username or password does not exist or is incorrect", "Invalid Login");
                        txtUsername.Clear();
                        txtPassword.Clear();
                        txtUsername.Focus();

                        passwordTextBox.Clear();
                        usernameTextBox.Clear();
                    }
                }
                catch (System.Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show(ex.Message);
                }
            }
        }
        private void frmLogin_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'capstone_Project_FinalDataSet.Employees' table. You can move, or remove it, as needed.
            //this.employeesTableAdapter.Fill(this.capstone_Project_FinalDataSet.Employees);
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
