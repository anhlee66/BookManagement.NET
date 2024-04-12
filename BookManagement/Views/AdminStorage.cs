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
using BookManagement.Controller;
using System.Diagnostics;

namespace BookManagement.Views
{
    public partial class AdminStorage : Form
    {
        public AdminStorage()
        {
            InitializeComponent();
        }

        private void AdminStorage_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            authorFilter_Load();
            genreFilter_Load();
            publisherFilter_Load();

        }

        public void authorFilter_Load()
        {
            DataTable dt = AuthorController.getAuthorToCombobox();
            if ((dt.Rows.Count > 0))
            {
                cbAuthorFilter.DataSource = dt;
                cbAuthorFilter.DisplayMember = "Name";
                cbAuthorFilter.ValueMember = "AuthorId";
            }
        }
        public void genreFilter_Load()
        {
            DataTable dt = BookGenreController.getBookGenreToFilter();
            if (dt.Rows.Count > 0)
            {
                cbGenreFilter.DataSource = dt;
                cbGenreFilter.DisplayMember = "Name";
                cbGenreFilter.ValueMember = "BookGenreId";
            }
        }
        public void publisherFilter_Load()
        {

            DataTable dt = PublisherController.getPublisherToFilter();
            if (dt.Rows.Count > 0)
            {
                cbPublisherFilter.DataSource = dt;
                cbPublisherFilter.DisplayMember = "Name";
                cbPublisherFilter.ValueMember = "PublisherId";
            }
        }


        private void button3_Click(object sender, EventArgs e)
        {

            DataTable dt = BookGenreController.getBookGenreToFilter();
            if (dt.Rows.Count > 0)
            {
                cbGenreFilter.DataSource = dt;
                cbGenreFilter.DisplayMember = "Name";
                cbGenreFilter.ValueMember = "BookGenreId";
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bookControl1_Load(object sender, EventArgs e)
        {

        }

        private void bookItemControl1_Load(object sender, EventArgs e)
        {

        }
    }
}
