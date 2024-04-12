using BookManagement.Views.ViewDialog;
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
    public partial class AdminEmployee : Form
    {
        public AdminEmployee()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            EmployeeDialog employee = new EmployeeDialog();

            employee.StartPosition = FormStartPosition.CenterParent;
            employee.ShowDialog();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void AdminEmployee_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }
    }
}
