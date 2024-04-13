using BookManagement.Models;
using BookManagement.Views;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookManagement.Views.ViewDialog
{
    public partial class BookGenreDialog : Form
    {
        const int SUCCESS_CODE = 1;
        const int FAILURE_CODE = 0;
        const int ADD_MODE = 1;
        const int EDIT_MODE = 0;
        private int mode;
        private int id;
        private AdminCategory category;

        
        public BookGenreDialog(AdminCategory category)
        {
            this.category = category;
            InitializeComponent();
        }
        internal void setMode(int mode)
        {
            this.mode = mode;
            if(mode == ADD_MODE)
            {
                title.Text = "Add new genre";
                btnSave.Text = "New";
            }
            else
            {
                title.Text = "Edit genre book";
                btnSave.Text = "Save";
            }
        }
        internal void setData(BookGenre genre)
        {
            txtGenreName.Text = genre.name;
            this.id = Convert.ToInt32(genre.genreId.ToString());
            txtGenreDescription.Text = genre.description;

        }
        public void NotifyIdChangeVaulue()
        {

        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string name = txtGenreName.Text.Trim();
                string description = txtGenreDescription.Text.Trim();

                if (name == "" || description == "")
                {
                    MessageBox.Show("Needed values are empty.");
                    txtGenreName.Focus();
                    return;
                }

                BookGenre genre = new BookGenre(id, name, description);
                category.GetMessage(SUCCESS_CODE, genre,mode);
                this.Close();


            }
            catch (Exception ex)
            {
                Debug.Print(ex.Message);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            foreach(Control control in this.Controls)
            {
                if(control is TextBox)
                {
                    control.Text = "";
                }
            }
        }
    }
}
