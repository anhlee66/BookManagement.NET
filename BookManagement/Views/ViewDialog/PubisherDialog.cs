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

namespace BookManagement.Views.ViewDialog
{
    public partial class PubisherDialog : Form
    {
        const int SUCCESS_CODE = 1;
        const int FAILURE_CODE = 0;
        const int ADD_MODE = 1;
        const int EDIT_MODE = 0;

        private AdminCategory category;
        private int id;
        private int mode;
        public PubisherDialog(AdminCategory category)
        {
            this.category = category;
            InitializeComponent();
        }

        internal void setMode(int mode)
        {
            this.mode = mode;
            if (mode == ADD_MODE)
            {
                title.Text = "Add new publisher";
                btnSave.Text = "New";
            }
            else
            {
                title.Text = "Edit publisher";
                btnSave.Text = "Save";
            }
        }

        internal void setData(Publisher publisher)
        {
            this.id = publisher.publisherId;
            txtPublisher.Text = publisher.name;
            txtContact.Text = publisher.contact;
            txtDescription.Text = publisher.description;
        }

        private void iconClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDescription.Text = String.Empty;
            txtPublisher.Text = String.Empty;
            txtContact.Text = String.Empty;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string name = txtPublisher.Text.Trim();
            string contact = txtContact.Text.Trim();
            string description = txtDescription.Text.Trim();

            if (name == "" || contact == "" || description == "")
            {
                MessageBox.Show("Needed values are empty.");
                txtPublisher.Focus();
                return;
            }
            Publisher publisher = new Publisher(id,name,contact,description);
            category.GetMessage(SUCCESS_CODE,publisher,mode);
            this.Close();
        }
    }
}
