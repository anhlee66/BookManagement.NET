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
    public partial class AuthorDialog : Form
    {
       
        const int SUCCESS_CODE = 1;
        const int FAILURE_CODE = 0;
        const int ADD_MODE = 1;
        const int EDIT_MODE = 0;

        private AdminCategory category;
        private int id;
        private int mode;
        public AuthorDialog()
        {
            InitializeComponent();
        }
        public AuthorDialog(AdminCategory category)
        {
            this.category = category;
            InitializeComponent();
        }

        internal void setMode(int mode)
        {
            this.mode = mode;
            if (mode == ADD_MODE)
            {
                title.Text = "Add new author";
                btnSave.Text = "New";
            }
            else
            {
                title.Text = "Edit author";
                btnSave.Text = "Save";
            }
        }
        internal void getData(Author author)
        {
            this.id = author.authorId;
            txtAuthor.Text = author.name;
            txtContact.Text = author.contact;
            txtDescription.Text = author.description;
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            foreach (Control control in this.Controls)
            {
                if (control is TextBox)
                {
                    control.Text = "";
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Save");

            string name = txtAuthor.Text.Trim();
            string contact = txtContact.Text.Trim();
            string description = txtDescription.Text.Trim();
            if (name == null || contact == null || description == null) {
                MessageBox.Show("Needed values are empty.");
                txtAuthor.Focus();
                return;
            }
            Author author = new Author(id, name, contact, description);
            category.GetMessage(SUCCESS_CODE,author,mode);

            this.Close();
        }
    }
}
