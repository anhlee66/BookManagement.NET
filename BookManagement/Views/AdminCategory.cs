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
        private Shadow shadow;
        public AdminCategory()
        {
            InitializeComponent();
        }

        private void AdminCategory_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            genreTab_Load();
            authorTab_Load();
            publisherTab_Load();
            shadow = new Shadow(this);
            GenreChanged += button_GenreChanged;
            AuthorChanged += button_AuthorChanged;
            PublisherChanged += button_PublisherChanged;


        }

        private void AdminCategory_PublisherChanged(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #region common handler

        internal void GetMessage(int code, Object obj, int mode)
        {
            if (code == FAILURE_CODE) return;

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
            else if (obj is Author)
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
            else
            {
                Publisher publisher = (Publisher)obj;
                switch (mode)
                {
                    case EDIT_MODE:
                        if (PublisherController.UpdatePublisher(publisher))
                        {
                            this.publisherTab_Load();
                            // MessageBox.Show("Need to refresh");
                        }
                        else
                        {
                            Debug.Print("Update error");
                        }
                        break;
                    default:
                        if (PublisherController.InsertPublisher(publisher))
                        {
                            this.publisherTab_Load();
                        }
                        else
                        {
                            Debug.Print("Insert error");
                        }
                        break;
                }
            }


            return;
        }


        #endregion


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

            dtPublisher = PublisherController.getAllPublisherDataTable();
            if (dtPublisher.Rows.Count > 0)
            {
                dgvPublisher.DataSource = dtPublisher;

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

        private void button_GenreChanged(object sender, EventArgs e)
        {
            if (bookGenreSelected == null)
            {
                btnEditGenre.Enabled = false;
                btnDeleteGenre.Enabled = false;
            }
            else
            {
                btnEditGenre.Enabled = true;
                btnDeleteGenre.Enabled = true;
            }
        }
        private void btnEditGenre_Click(object sender, EventArgs e)
        {
            if (isSelectedItem(bookGenreSelected))
            {
                BookGenreDialog gender = new BookGenreDialog(this);
                shadow.Show();
                gender.setShadow(shadow);
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
            if (isSelectedItem(bookGenreSelected) )
            {
                if(MessageDelete())
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
            }
            else Message.EmptySelection();

        }
        private void btnNewGenre_Click(object sender, EventArgs e)
        {
            BookGenreDialog gender = new BookGenreDialog(this);
            shadow.Show();
            gender.setShadow(shadow);
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
            //MessageBox.Show(authorSelected.authorId.ToString());
        }

        public void button_AuthorChanged(Object sender, EventArgs e)
        {
            if(authorSelected == null)
            {
                btnDeleteAuthor.Enabled = false;
                btnEditAuthor.Enabled = false;
            }
            else
            {
                btnDeleteAuthor.Enabled = true;
                btnEditAuthor.Enabled = true;
            }
        }
        private void btnEditAuthor_Click(object sender, EventArgs e)
        {
            if (isSelectedItem(authorSelected))
            {
                AuthorDialog author = new AuthorDialog(this);
                shadow.Show();
                author.setShadow(shadow);
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
            shadow.Show();
            author.setShadow(shadow);
            author.setMode(ADD_MODE);
            author.getData(new Author());
            author.ShowDialog();

        }
        private void btnDeleteAuthor_Click(object sender, EventArgs e)
        {
            if (isSelectedItem(authorSelected) && MessageDelete())
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
            else
            {
                Message.EmptySelection();
            }
        }
        #endregion




        #region publisher handler
        private void dgvPublisher_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (isRangeOut(index, dtPublisher.Rows.Count)) return;
            publisherSelected = new Publisher(dtPublisher.Rows[index]);
            //MessageBox.Show(publisherSelected.publisherId.ToString());
        }

        public void button_PublisherChanged(Object sender, EventArgs e)
        {
            if ((publisherSelected == null))
            {
                btnDeletePublisher.Enabled = false;
                btnEditPuslisher.Enabled = false;
            }
            else
            {
                btnDeletePublisher.Enabled = true;
                btnEditPuslisher.Enabled = true;
            }
            
        }
        private void btnEditPuslisher_Click(object sender, EventArgs e)
        {
            if (isSelectedItem(publisherSelected))
            {
                PubisherDialog publisher = new PubisherDialog(this);
                shadow.Show();
                publisher.setShadow(shadow);
                publisher.setMode(EDIT_MODE);
                publisher.setData(publisherSelected);
                publisher.ShowDialog();

            }
            else
            {
                Message.EmptySelection();
            }
        }

        private void btnNewPublisher_Click(object sender, EventArgs e)
        {

            PubisherDialog publisher = new PubisherDialog(this);
            shadow.Show();
            publisher.setShadow(shadow);
            publisher.setMode(ADD_MODE);
            publisher.setData(new Publisher());
            publisher.ShowDialog();


        }

        private void btnDeletePublisher_Click(object sender, EventArgs e)
        {
            if (isSelectedItem(publisherSelected) && MessageDelete())
            {
                if (!PublisherController.isPublisherEmpty(publisherSelected.publisherId))
                {
                    Message.DeleteError("Cannot execute this action because this list not empty", "Delete Error");

                }
                else if (PublisherController.DeletePublisher(publisherSelected.publisherId))
                {
                    MessageBox.Show("Deleted a item", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.publisherTab_Load();
                }
                else
                {
                    MessageBox.Show("Deleted Error");
                }
            }
            else
            {
                Message.EmptySelection();
            }
        }
        #endregion


        private void AdminCategory_FormClosed(object sender, FormClosedEventArgs e)
        {
            shadow.Hide();
        }

        public bool MessageDelete()
        {
            string msg = "Do you want to delete this item?";
            string title = "Delete item";
            DialogResult result = MessageBox.Show(msg, title,MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                return true;
            }
            return false;
        }

        private void dgvGenre_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Click");
        }

       
    }
}
