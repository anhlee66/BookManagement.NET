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
using BookManagement.Views.CustomControl;
using System.Web;
using BookManagement.Views.ViewDialog;

namespace BookManagement.Views
{
    public partial class AdminStorage : Form
    {
        const string Root = "C:\\Users\\anh79\\source\\repos\\BookManagement\\BookManagement\\";
        private Shadow shadow;
        const int SUCCESS_CODE = 1;
        const int FAILURE_CODE = 0;
        const int ADD_MODE = 1;
        const int EDIT_MODE = 0;
        public AdminStorage()
        {
            InitializeComponent();
            shadow = new Shadow(this);
        }
        #region Form load handler
        private void AdminStorage_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            this.Dock = DockStyle.Fill;
            authorFilter_Load();
            genreFilter_Load();
            itemBook_Load();
            filter_Reset();
            statictis_Load();
            SelectedChanged += state_Button;
        }
        private void state_Button(object sender, EventArgs e)
        {
            // MessageBox.Show("changed");
            if (itemSelected != -1)
            {
                btnEdit.Enabled = true;
            }
            else
            {
                btnEdit.Enabled = false;
            }
        }
        private void statictis_Load()
        {
            int[] data = BookController.GetStatictisBook(author, genre);
            txtNumberBook.Text = data[0].ToString();
            txtQuantity.Text = data[1].ToString();

        }

        private void itemBook_Load()
        {
            books = BookController.getAllBook();

            flowListBook.VerticalScroll.Visible = true;
            flowListBook.WrapContents = false;
            flowListBook.AutoScroll = true;
            flowListBook.Controls.Clear();
            //MessageBox.Show(books.Count.ToString());
            for (int i = 0; i < books.Count; i++)
            {
                BookItemControl book = new BookItemControl(this);
                string thumbnail  = Root + books[i].thumbnail;
                //MessageBox.Show(thumbnail);
                book.Id = books[i].bookId;
                book.Title = books[i].name;
                book.AuthorId = BookController.getAuthorId(book.Id);
                book.Author = BookController.getAuthorName(book.Id);
                book.GenreId = books[i].genre;
                book.Price = BookController.getBookPrice(book.Id).ToString() + "đ";
                book.Quantity = books[i].quantity.ToString();
                book.AutoSize = true;
                book.Thumbnail = new Bitmap(Image.FromFile(thumbnail));
                book.Width = flowListBook.Width - 20;

                book.Click += book_OpenDetail;

                flowListBook.Controls.Add(book);
            }
        }

        public void authorFilter_Load()
        {
            DataTable dt = AuthorController.getAuthorToCombobox();

            if ((dt.Rows.Count > 0))
            {
                cbAuthorFilter.DataSource = dt;
                cbAuthorFilter.DisplayMember = "Name";
                cbAuthorFilter.ValueMember = "AuthorId";
                cbAuthorFilter.SelectedIndex = -1;
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
                cbGenreFilter.SelectedIndex = -1;
            }
        }



        #endregion

        #region Command handler

        internal void GetMessage(int code, int mode)
        {
            string message = string.Empty;
            if(mode == ADD_MODE)
            {
                message += "Add book";
            }
            else
            {
                message += "Edit book";
            }
            if (code == SUCCESS_CODE)
            {
                MessageBox.Show(message + " successfully",message, MessageBoxButtons.OK,MessageBoxIcon.Information);
                itemBook_Load();
            }
            else
            {
                MessageBox.Show(message + " Faild.",message, MessageBoxButtons.AbortRetryIgnore,
                    MessageBoxIcon.Warning);
            }
        }
        public void getItemSelected(int id)
        {
            this.itemSelected = id;
        }

        private void clearItemSelected()
        {
            itemSelected = -1;
            foreach (Control c in flowListBook.Controls)
            {
                (c as BookItemControl).BackColor = Color.White;
            }
        }


        // show book information detail
        private void book_OpenDetail(object sender, EventArgs e)
        {
            clearItemSelected();
            panelBookDetail.Controls.Clear();
            BookItemControl item = (BookItemControl)sender;
            itemSelected = item.Id;
            item.BackColor = Color.LightGray;

            BookControl bookDetail = new BookControl();
            Book book = BookController.getBookById(itemSelected);

            if (book != null)
            {
                bookDetail.Title = book.name;
                bookDetail.Genre = BookGenreController.getBookGenreName(book.genre);
                bookDetail.Author = BookController.getAuthorName(itemSelected);
                bookDetail.Quantity = book.quantity.ToString();
                bookDetail.Import = BookController.getBookPrice(itemSelected).ToString();
                bookDetail.Publisher = PublisherController.GetPublisherName(itemSelected);
                bookDetail.Summary = book.summary.ToString();
                bookDetail.Thumbnail = new Bitmap(Image.FromFile(Root + book.thumbnail));
            }
            //MessageBox.Show(bookDetail.Author);
            panelBookDetail.Controls.Add(bookDetail);

            // MessageBox.Show(bookDetail.Title);
        }

        internal void searchRecord(string keyword)
        {
            string[] builder = keyword.Split(" ");
            foreach (Control c in flowListBook.Controls)
            {
                BookItemControl book = (BookItemControl)c;

                if (!book.Visible) continue;
                else
                {
                    string info = book.Title + " " + book.Author;
                    if (findWord(builder, info))
                    {
                        book.Visible = true;
                    }
                    else
                    {
                        book.Visible = false;
                    }
                }

            }
            if (keyword == string.Empty)
            {
                filter_BookReference(this.author, this.genre);
            }
        }


        private void statictis_Book(int author, int genre)
        {

        }

        public bool check_AuthorId(List<int> authors, int author)
        {
            if (author == -1) return true;
            foreach (int i in authors)
            {
                if (i == author) return true;
            }
            return false;
        }
        private bool findWord(string[] str, string filter)
        {
            filter = filter.ToLower();
            foreach (string s in str)
            {
                if (filter.IndexOf(s.ToLower()) != -1) return true;
            }
            return false;
        }

        public void filter_BookReference(int author, int genre)
        {
            //MessageBox.Show(author.ToString() + genre.ToString());
            foreach (Control c in flowListBook.Controls)
            {
                BookItemControl bookmark = (BookItemControl)c;
                if (check_AuthorId(bookmark.AuthorId, author)
                    && (genre == -1 || bookmark.GenreId == genre))
                {
                    bookmark.Visible = true;


                }
                else bookmark.Visible = false;
            }
            statictis_Load();
        }

        // filter by combobox
        private void filter_SelectedChanged(object sender, EventArgs e)
        {
            int author = -1, genre = -1;
            try
            {
                if (cbAuthorFilter.SelectedIndex != -1)
                    author = Convert.ToInt32(cbAuthorFilter.SelectedValue);
            }
            catch
            {
                author = -1;
            }
            try
            {
                if (cbGenreFilter.SelectedIndex != -1)
                {

                    genre = Convert.ToInt32(cbGenreFilter.SelectedValue);
                    //MessageBox.Show(genre.ToString());
                }
            }
            catch
            {
                genre = -1;
            }
            this.author = author;
            this.genre = genre;
            filter_BookReference(author, genre);

        }

        #endregion


        #region click handle

        private void btnClear_Click(object sender, EventArgs e)
        {

            filter_Reset();
        }

        public void filter_Reset()
        {
            cbGenreFilter.SelectedIndex = -1;
            cbAuthorFilter.SelectedIndex = -1;
            cbGenreFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            cbGenreFilter.Text = "--genre filter--";
            cbAuthorFilter.Text = "--author filter--";

        }



        private void btnNew_Click(object sender, EventArgs e)
        {
            BookDialog bookDialog = new BookDialog(this);
            shadow.Show();
            bookDialog.setShadow(shadow);
           // bookDialog.setData(new Book());
            bookDialog.setMode(ADD_MODE);
            bookDialog.ShowDialog();
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            BookDialog bookDialog = new BookDialog(this);
            Book book = BookController.getBookById(itemSelected);
            shadow.Show();
            bookDialog.setShadow(shadow);
            bookDialog.setMode(EDIT_MODE);
            bookDialog.setData(book);
            bookDialog.ShowDialog();
        }

        #endregion


        private void btnClearSelected_Click(object sender, EventArgs e)
        {
            clearItemSelected();
        }
    }
}
