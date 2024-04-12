using BookManagement.Controller;
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

        private void dgvGenre_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (isRangeOut(index, dgvGenre.Rows.Count)) return;
            DataGridViewRow dr = dgvGenre.Rows[index];
            id = Convert.ToInt32(dr.Cells["BookGenreId"].Value);
            txtGenreName.Text = dr.Cells["genreName"].Value.ToString();
            txtGenreDescription.Text = dr.Cells["genreDescription"].Value.ToString();

        }

        private void dgvAuthor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (isRangeOut(index, dgvAuthor.Rows.Count)) return;
            DataGridViewRow dr = dgvAuthor.Rows[index];
            txtAuthorName.Text = dr.Cells["authorName"].Value.ToString();
            txtAuthorDescription.Text = dr.Cells["authorDescription"].Value.ToString();
            txtAuthorContact.Text = dr.Cells["authorContact"].Value.ToString();
        }

        private void dgvPublisher_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (isRangeOut(index, dgvPublisher.Rows.Count)) return;

            DataGridViewRow dr = dgvPublisher.Rows[index];
            txtPublisherName.Text = dr.Cells["publisherName"].Value.ToString();
            txtPublisherDescription.Text = dr.Cells["publisherDescription"].Value.ToString();
            txtPublisherContact.Text = dr.Cells["publisherContact"].Value.ToString();
            txtPublisherAddress.Text = dr.Cells["publisherAddress"].Value.ToString();
        }

        public bool isRangeOut(int index, int size)
        {
            if (index < 0 || index >= size) return true;
            return false;
        }

        private void btnNewGenre_Click(object sender, EventArgs e)
        {
            

        }

        private void btnUpdateGenre_Click(object sender, EventArgs e)
        {
            if (id != -1)
            {
                BookGenreDialog genre = new BookGenreDialog();
                genre.getData(id, txtGenreName.Text, txtGenreDescription.Text);
                //genre.Parent = this;
                genre.ShowDialog();
            }
        }
    }
}
