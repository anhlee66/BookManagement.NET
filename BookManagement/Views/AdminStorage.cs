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

namespace BookManagement.Views
{
    public partial class AdminStorage : Form
    {
        
        public AdminStorage()
        {
            InitializeComponent();
        }
        #region Form load handler
        private void AdminStorage_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            authorFilter_Load();
            genreFilter_Load();
            publisherFilter_Load();
            itemBook_Load();
            filter_Reset();
        }

        

        private void itemBook_Load()
        {
            books= BookController.getAllBook();

            flowListBook.VerticalScroll.Visible = true;
            flowListBook.WrapContents = false;
            flowListBook.AutoScroll = true;
            
            //MessageBox.Show(books.Count.ToString());
            for (int i = 0; i < books.Count; i++)
            {
                BookItemControl book = new BookItemControl(this);
                book.Id = books[i].bookId;
                book.Title = books[i].name;
                book.Price = BookController.getBookPrice(3).ToString() + "đ";
                book.Quantity = books[i].quantity.ToString();
                book.AutoSize = true;
                book.Thumbnail = new Bitmap(Image.FromFile("C:\\Users\\anh79\\source\\repos\\BookManagement\\BookManagement\\Resource\\Image\\book.png"));
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


        #endregion

        #region Command handler
        public void getItemSelected(int id)
        {
            this.itemSelected = id;
            txtItemSelected.Text = id.ToString();
        }
        
        private void clearItemSelected()
        {
            itemSelected  = -1;
            foreach(Control c in flowListBook.Controls)
            {
                (c as BookItemControl).BackColor = Color.White;
            }
        }
        private void book_OpenDetail(object sender, EventArgs e)
        {
            clearItemSelected();
            panelBookDetail.Controls.Clear();
            BookItemControl  item  = (BookItemControl)sender;
            itemSelected = item.Id;
            item.BackColor = Color.LightGray;

            BookControl bookDetail = new BookControl();
            Book book = BookController.getBookById(itemSelected);

            if (book != null)
            {
                bookDetail.Title = book.name;
                bookDetail.Genre = "ANHLE";
                bookDetail.Author = "AUTHOR";
                bookDetail.Quantity = book.quantity.ToString();
                bookDetail.Import = BookController.getBookPrice(itemSelected).ToString();
                bookDetail.Publisher = "publisher";
                bookDetail.Summary = book.summary.ToString();
            }

            panelBookDetail.Controls.Add(bookDetail);

           // MessageBox.Show(bookDetail.Title);
        }

        internal void searchRecord(string keyword)
        {
            String[] builder = keyword.Trim().Split(" ");
            MessageBox.Show(builder[0]);
        }

        #endregion

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

        private void btnClear_Click(object sender, EventArgs e)
        {

            filter_Reset();
        }

        public void filter_Reset()
        {
            cbGenreFilter.SelectedIndex = -1;
            cbAuthorFilter.SelectedIndex = -1;
            cbPublisherFilter.SelectedIndex = -1;
            cbGenreFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            cbGenreFilter.Text = "--genre filter--";
            cbAuthorFilter.Text = "--author filter--";
            cbPublisherFilter.Text = "--publisher filter--";

        }

        private void flowListBook_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
