using BookManagement.Controller;
using BookManagement.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookManagement.Views.ViewDialog
{
    public partial class BookDialog : Form
    {
        const string Root = "C:\\Users\\anh79\\source\\repos\\BookManagement\\BookManagement\\";

        const int SUCCESS_CODE = 1;
        const int FAILURE_CODE = 0;
        const int ADD_MODE = 1;
        const int EDIT_MODE = 0;
        private int mode;
        private int id;
        private string summary = string.Empty;

        private AdminStorage storage;
        private Shadow shadow;
        public BookDialog()
        {
            InitializeComponent();
        }
        public BookDialog(AdminStorage storage)
        {
            InitializeComponent();
            this.storage = storage;
        }
        internal void setShadow(Shadow shadow)
        {
            this.shadow = shadow;
        }
        internal void setMode(int mode)
        {
            this.mode = mode;
            if (mode == ADD_MODE)
            {
                title.Text = "Add book";
                btnSave.Text = "New";
                txtPrice.Text = "Import price:";
                txtQuantity.ReadOnly = false;
                numImport.ReadOnly = false;
            }
            else
            {
                txtQuantity.ReadOnly = true;
                numImport.ReadOnly = true;
                title.Text = "Edit book";
                btnSave.Text = "Save";
                txtPrice.Text = "Selling price:";
            }
        }
        internal void setData(Book book)
        {
            field_Reset();
            if (book == null) return;
           
            this.id = book.bookId;
            txtName.Text = book.name;
            txtQuantity.Value = book.quantity;
            numImport.Value = book.importPrice;
            numPrice.Value = BookController.getBookPrice(id);
            cbAuthor.SelectedValue = BookController.getAuthorId(id);
            cbGenre.SelectedValue = book.genre;
            cbPublisher.SelectedValue = book.publisher;
            cbBookState.SelectedItem = BookController.GetStateById(id);
            ptbThumbnail.Image = new Bitmap(Image.FromFile(Root + book.thumbnail));
            this.summary = book.summary;
            //cbAuthor.SelectedIndex = cbAuthor.ValueMember.IndexOf()
        }

        #region
        private void BookDialog_Load(object sender, EventArgs e)
        {
            author_Load();
            genre_Load();
            publisher_Load();
            cbBookState.SelectedIndex = 2;
            cbBookState.Enabled = false;

        }

        public void author_Load()
        {
            DataTable dt = AuthorController.getAuthorToCombobox();
            if (dt.Rows.Count > 0)
            {
                cbAuthor.DataSource = dt;
                cbAuthor.DisplayMember = "Name";
                cbAuthor.ValueMember = "AuthorId";
            }
        }
        public void genre_Load()
        {
            DataTable dt = BookGenreController.getBookGenreToFilter();
            if (dt.Rows.Count > 0)
            {
                cbGenre.DataSource = dt;
                cbGenre.DisplayMember = "Name";
                cbGenre.ValueMember = "BookGenreId";
            }
        }
        public void publisher_Load()
        {
            DataTable dt = PublisherController.getPublisherToCombobox();
            if (dt.Rows.Count > 0)
            {
                cbPublisher.DataSource = dt;
                cbPublisher.DisplayMember = "Name";
                cbPublisher.ValueMember = "PublisherId";
            }
        }
        #endregion


        #region click handler
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
            field_Reset();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (validationInput())
            {
                string name = txtName.Text;
                int quantity = Convert.ToInt32(txtQuantity.Value);
                decimal import = numImport.Value;
                decimal price = numPrice.Value;
                int author = Convert.ToInt32(cbAuthor.SelectedValue);
                int publisher = Convert.ToInt32(cbPublisher.SelectedValue);
                int genre = Convert.ToInt32(cbGenre.SelectedValue);
                string thumbnail = string.Format("\\Database\\Images\\thumbnail_{0}_{1}.png", name, DateTimeOffset.Now.ToUnixTimeSeconds(), Root);
                Bitmap bitmap = new Bitmap(ptbThumbnail.Image);
               // MessageBox.Show(thumbnail);
                string state = cbBookState.Text;
                switch (mode)
                {
                    case ADD_MODE:
                        if (BookController.InsertBook(genre, author, publisher, quantity, import, price, name, this.summary, state, thumbnail))
                        {
                            bitmap.Save(Root+thumbnail, ImageFormat.Png);
                            bitmap.Dispose();
                          
                            this.Hide();
                            storage.GetMessage(SUCCESS_CODE, ADD_MODE);
                            this.Close();
                        }
                        else
                        {

                            storage.GetMessage(FAILURE_CODE, ADD_MODE);
                        }
                        break;
                    default:
                        if (BookController.EditBook(this.id, genre, author, publisher, quantity, import, price, name, this.summary, state, thumbnail))
                        {
                            bitmap.Save(Root + thumbnail, ImageFormat.Png);
                            bitmap.Dispose();
                          //  this.Hide();
                            storage.GetMessage(SUCCESS_CODE, EDIT_MODE);
                            this.Close();
                            //MessageBox.Show("OKd");
                        }
                        else
                        {
                            //MessageBox.Show("!OKd");
                            storage.GetMessage(FAILURE_CODE, EDIT_MODE);
                        }
                        break;
                }

            }
            else
            {
                Message.InputFaild();
            }
        }

        #endregion

        #region command handle
        private void BookDialog_FormClosed(object sender, FormClosedEventArgs e)
        {
            shadow.Hide();
        }
        private void field_Reset()
        {
            txtName.Text = string.Empty;
            numPrice.Text = string.Empty;
            cbAuthor.SelectedIndex = -1;
            cbBookState.SelectedIndex = -1;
            cbGenre.SelectedIndex = -1;
            cbPublisher.SelectedIndex = -1;
        }

        private bool validationInput()
        {
            if (cbPublisher.SelectedIndex == -1) return false;
            if (cbGenre.SelectedIndex == -1) return false;
            if (cbBookState.SelectedIndex == -1) return false;
            if (cbPublisher.SelectedIndex == -1) return false;
            if (txtName.Text.Trim() == "" || numPrice.Value == 0) return false;
            if (txtQuantity.Value == 0)
            {
                cbBookState.SelectedIndex = 2;
            }
            return true;

        }
        #endregion


        private void ptbThumbnail_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Title = "Open Image";
                dlg.Filter = "png file (*.png)|*.png | jpg file (*.jpg)|*.jpg";
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    Bitmap bitmap = new Bitmap(dlg.FileName);
                    ptbThumbnail.Image = bitmap;
                }
            }
        }

        private void txtQuantity_ValueChanged(object sender, EventArgs e)
        {
            if(txtQuantity.Value == 0)
            {
                cbBookState.SelectedIndex = 2;
                cbBookState.Enabled = false;
            }
            else
            {
                cbBookState.Enabled = true;
                //cbBookState.SelectedIndex = -1;
            }
        }
    }
}
