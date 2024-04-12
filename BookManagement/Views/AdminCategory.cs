using BookManagement.Controller;
using BookManagement.Models;
using BookManagement.Views.ViewDialog;
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

namespace BookManagement.Views
{
    public partial class AdminCategory : Form
    {
        public int id { get; set; } = -1;
        public AdminCategory()
        {
            InitializeComponent();
        }

        private void AdminCategory_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            gengerTab_Load();
            authorTab_Load();
            publisherTab_Load();

        }
        public void gengerTab_Load()
        {
            dtGenre = BookGenreController.getAllBookGenre();
            if (dtGenre.Rows.Count > 0)
            {
                dgvGenre.DataSource = dtGenre;

            }
            dgvGenre.Columns["BookGenreId"].Visible = false;
        }
        public void authorTab_Load()
        {
            DataTable dt = new DataTable();
            dt = AuthorController.getAllAuthorDatatable();
            if (dt.Rows.Count > 0)
            {
                dgvAuthor.DataSource = dt;

            }
            dgvAuthor.Columns["AuthorId"].Visible = false;

        }
        public void publisherTab_Load()
        {
            DataTable dt = new DataTable();
            dt = PublisherController.getAllPublisherDataTable();
            if (dt.Rows.Count > 0)
            {
                dgvPublisher.DataSource = dt;

            }
            dgvPublisher.Columns["PublisherId"].Visible = false;

        }







        public bool isRangeOut(int index, int size)
        {
            if (index < 0 || index >= size) return true;
            return false;
        }


        private void btnEditGenre_Click(object sender, EventArgs e)
        {
            if (bookGenreSelected != null)
            {
                BookGenreDialog gender = new BookGenreDialog();
                gender.getData(bookGenreSelected);
                gender.ShowDialog();
            }
            else
            {
                MessageBox.Show("Not has ob");
            }
        }

        private void dgvGenre_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (isRangeOut(index, dtGenre.Rows.Count)) return;
            bookGenreSelected = new BookGenre(dtGenre.Rows[index]); 
        }
    }
}
