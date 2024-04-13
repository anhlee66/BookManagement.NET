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
        const int SUCCESS_CODE = 1;
        const int FAILURE_CODE = 0;
        const int ADD_MODE = 1;
        const int EDIT_MODE = 0;
        public AdminCategory()
        {
            InitializeComponent();
        }
        internal void GetMessage(int code, Object obj, int mode)
        {
            if (code == SUCCESS_CODE)
            {
                if (obj is BookGenre)
                {
                    BookGenre genre = (BookGenre)obj;
                    switch (mode)
                    {
                        case ADD_MODE:
                            if (BookGenreController.UpdateBookGenre(genre))
                            {
                                this.genreTab_Load();
                                // MessageBox.Show("Need to refresh");
                            }
                            break;
                        default:
                            if (BookGenreController.InsertBookGenre(genre))
                            {
                                this.genreTab_Load();
                            }
                            break;
                    }


                }
                if (obj is Author)
                {
                    Author author = (Author)obj;
                    switch (mode)
                    {
                        case EDIT_MODE:
                            if (AuthorController.updateAuthor(author))
                            {
                                this.authorTab_Load();
                                // MessageBox.Show("Need to refresh");
                            }
                            else
                            {
                                Debug.Print("Update error");
                            }
                            break;
                        default:
                            if (AuthorController.InsertAuthor(author))
                            {
                                this.authorTab_Load();
                            }
                            else
                            {
                                Debug.Print("Insert error");
                            }
                            break;
                    }

                }

            }
            return;
        }

        private void AdminCategory_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            genreTab_Load();
            authorTab_Load();
            publisherTab_Load();

        }

        #region Load datagridview 
        public void genreTab_Load()
        {
            dtGenre = null;
            dtGenre = BookGenreController.getAllBookGenre();
            if (dtGenre.Rows.Count > 0)
            {
                dgvGenre.DataSource = dtGenre;

            }
            dgvGenre.Columns["BookGenreId"].Visible = false;
            //MessageBox.Show("genre reload");
        }
        public void authorTab_Load()
        {
            dtAuthor = null;
            dtAuthor = AuthorController.getAllAuthorDatatable();
            if (dtAuthor.Rows.Count > 0)
            {
                dgvAuthor.DataSource = dtAuthor;

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
        #endregion

        #region check constrain
        public bool isRangeOut(int index, int size)
        {
            if (index < 0 || index >= size) return true;
            return false;
        }

        internal bool isSelectedItem(Object obj)
        {
            if (obj == null) return false;
            return true;
        }

        #endregion

        #region genre handler
        private void btnEditGenre_Click(object sender, EventArgs e)
        {
            if (isSelectedItem(bookGenreSelected))
            {
                BookGenreDialog gender = new BookGenreDialog(this);
                gender.setMode(EDIT_MODE);
                gender.setData(bookGenreSelected);
                gender.ShowDialog();
            }
            else
            {
                Message.EmptySelection();
            }
        }


        //genre cell click
        private void dgvGenre_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (isRangeOut(index, dtGenre.Rows.Count)) return;
            bookGenreSelected = new BookGenre(dtGenre.Rows[index]);
        }

        // delete click
        private void btnDeleteGenre_Click(object sender, EventArgs e)
        {
            if (isSelectedItem(bookGenreSelected))
            {
                if (!BookGenreController.isGenreEmpty(bookGenreSelected.genreId))
                {
                    Message.DeleteError("Cannot execute this action because this list not empty", "Delete Error");
                }
                else if (BookGenreController.DeleteBookGenre(bookGenreSelected.genreId))
                {
                    MessageBox.Show("Deleted a item", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.genreTab_Load();
                }
                else
                {
                    MessageBox.Show("Deleted Error");
                }
            }
            else Message.EmptySelection();

        }
        private void btnNewGenre_Click(object sender, EventArgs e)
        {
            BookGenreDialog gender = new BookGenreDialog(this);
            gender.setMode(EDIT_MODE);
            gender.setData(new BookGenre());
            gender.ShowDialog();
        }
        #endregion



        #region author handler

        private void dgvAuthor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (isRangeOut(index, dtAuthor.Rows.Count)) return;
            authorSelected = new Author(dtAuthor.Rows[index]);
            MessageBox.Show(authorSelected.authorId.ToString());
        }

        private void btnEditAuthor_Click(object sender, EventArgs e)
        {
            if (isSelectedItem(authorSelected))
            {
                AuthorDialog author = new AuthorDialog(this);
                author.setMode(EDIT_MODE);
                author.getData(authorSelected);
                author.ShowDialog();
            }
            else
            {
                Message.EmptySelection();
            }
        }
        private void btnNewAuthor_Click(object sender, EventArgs e)
        {

            AuthorDialog author = new AuthorDialog(this);
            author.setMode(ADD_MODE);
            author.getData(new Author());
            author.ShowDialog();

        }
        private void btnDeleteAuthor_Click(object sender, EventArgs e)
        {
            if (isSelectedItem(authorSelected))
            {
                if (!AuthorController.isAuthorEmpty(authorSelected.authorId))
                {
                    Message.DeleteError("Cannot execute this action because this list not empty", "Delete Error");

                }
                else if (AuthorController.DeleteAuthor(authorSelected.authorId))
                {
                    MessageBox.Show("Deleted a item", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.authorTab_Load();
                }
                else
                {
                    MessageBox.Show("Deleted Error");
                }
            }
        }
        #endregion




    }
}
