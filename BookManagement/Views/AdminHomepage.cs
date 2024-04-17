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
    public partial class AdminHomepage : Form
    {

        LoginForm login;
        AdminCategory category;
        AdminDashborad dashborad;
        AdminOrders orders;
        AdminSetting setting;
        AdminStorage storage;
        AdminEmployee employee;
        private int id;
        public AdminHomepage(LoginForm login)
        {
            InitializeComponent();
            this.login = login;
        }
        internal void setUser(int id)
        {
            this.id = id;
        }

        #region Form load
        private void home_Load(object sender, EventArgs e)
        {
            userLogin_Load();
        }

        private void userLogin_Load()
        {
            Employee employee = EmployeeController.GetEmployee(id);
            txtUser.Text = employee.name;
        }
        #endregion

        #region sibar closed
        private void dashboard_Closed(object sender, FormClosedEventArgs e)
        {
            dashborad = null;
        }
        private void category_Closed(object sender, FormClosedEventArgs e)
        {
            category = null;
        }
        private void storage_Closed(object sender, FormClosedEventArgs e)
        {
            storage = null;
        }
        private void order_Closed(Object sender, FormClosedEventArgs e)
        {
            orders = null;
        }
        private void setting_Closed(object sender, FormClosedEventArgs e)
        {
            setting = null;
        }
        private void Employee_FormClosed(object sender, FormClosedEventArgs e)
        {
            employee = null;
        }
        #endregion

        #region sibar click
        private void sbDashboard_Click(object sender, EventArgs e)
        {
            if (dashborad == null)
            {
                dashborad = new AdminDashborad();
                dashborad.FormClosed += dashboard_Closed;
                dashborad.MdiParent = this;
                dashborad.Dock = DockStyle.Fill;

                dashborad.Show();
            }
            else
            {
                dashborad.Activate();
            }
        }

        private void sbOrders_Click(object sender, EventArgs e)
        {
            if (orders == null)
            {
                orders = new AdminOrders();
                orders.FormClosed += order_Closed;
                orders.MdiParent = this;
                orders.Dock = DockStyle.Fill;
                orders.Show();
            }
            else
            {
                orders.Activate();
            }

        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (category == null)
            {
                category = new AdminCategory();
                category.FormClosed += category_Closed;
                category.MdiParent = this;
                category.Dock = DockStyle.Fill;
                category.Show();
            }
            else
            {
                category.Activate();
            }
        }
        private void sbStorage_Click(object sender, EventArgs e)
        {
            if (storage == null)
            {
                storage = new AdminStorage();
                storage.FormClosed += storage_Closed;
                storage.MdiParent = this;
                storage.Dock = DockStyle.Fill;
                storage.Show();
            }
            else
            {
                storage.Activate();
            }
        }
        private void sbSetting_Click(object sender, EventArgs e)
        {
            if (setting == null)
            {
                setting = new AdminSetting();
                setting.FormClosed += setting_Closed;
                setting.MdiParent = this;
                setting.Dock = DockStyle.Fill;
                setting.Show();
            }
            else
            {
                setting.Activate();
            }
        }
        private void button6_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Close();

        }
        private void sbEmployee_Click(object sender, EventArgs e)
        {
            if (employee == null)
            {
                employee = new AdminEmployee();
                employee.MdiParent = this;
                employee.FormClosed += Employee_FormClosed;
                employee.Dock = DockStyle.Fill;
                employee.Show();
            }
            else
            {
                employee.Activate();
            }
        }
        #endregion


        private void btnSearch_Click(object sender, EventArgs e)
        {
            enter_Seacrch();

        }


        public void enter_Seacrch()
        {
            Form activate = this.ActiveMdiChild;
            Form form = new Form();
            string keyword = txtSearch.Text.Trim();
            switch (activate)
            {
                case AdminStorage storage: storage.searchRecord(keyword); break;
                case AdminCategory category: category.searchRecord(keyword); break;

            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            enter_Seacrch();
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            enter_Seacrch();
        }


        private void AdminHomepage_FormClosed(object sender, FormClosedEventArgs e)
        {
            login.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
