using BookManagement.Controller;
using BookManagement.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookManagement.Views
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void txtCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (cbPassword.Checked)
            {
                cbPassword.Text = "Hide password.";
                txtPassword.PasswordChar = '\0';
            }
            else
            {
                cbPassword.Text = "Show password.";
                txtPassword.PasswordChar = '*';
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (validation())
            {
                string password = txtPassword.Text;
                string user = txtUser.Text;
                AccountComputer account = AccountController.GetAccount(user);
                if(account == null || password != account.password)
                {
                    MessageBox.Show("User name or password is incorrect.", "Login faild");
                }
                else
                {
                    AdminHomepage home = new AdminHomepage(this);
                    home.setUser(account.EmployeeId);
                    home.Show();
                    this.Hide();
                }
            }
        }
        private bool validation()
        {
            if (txtUser.Text.Trim() == string.Empty || txtPassword.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please type all information", "Missing information");
                return false;
            }
            return true;
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            txtUser.Select();
        }
    }
}
