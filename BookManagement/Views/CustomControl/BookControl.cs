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

namespace BookManagement.Views.CustomControl
{
    public partial class BookControl : UserControl
    {
        public BookControl()
        {
            InitializeComponent();
        }

        #region
        //private Book _book;
        private string _title;
        private string _genre;
        private string _author;
        private string _quantity;
        private string _import;
        private string _publisher;
        private string _summary;

        /*public Book BookSource
        {
            get
            {
                return _book;
            }
            set
            {
                _book = value;
            }
        }*/
        [Category("Custom Props")]
        public string Title
        {
            get
            {
                return _title;
            }
            set
            {
                _title = value;
                txtBookTitleDetail.Text = value;
            }
        }
        [Category("Custom Props")]
        public string Genre
        {
            get
            {
                return _genre;
            }
            set
            {
                _genre = value;
                txtBookGenreDetail.Text = value;
            }
        }

        [Category("Custom Props")]
        public string Author
        {
            get
            {
                return _genre;
            }
            set
            {
                _genre = value;
            }
        }
        [Category("Custom Props")]
        public string Quantity
        {
            get
            {
                return _quantity;
            }
            set
            {
                _quantity = value;
                txtQuantityDetail.Text = value;
            }
        }
        [Category("Custom Props")]
        public string Import
        {
            get
            {
                return _import;

            }
            set
            {
                _import = value;
                txtPriceDetail.Text = value;
            }

        }
        [Category("Custom Props")]
        public string Publisher
        {
            get
            {
                return _publisher;
            }
            set
            {
                _publisher = value;
                txtPublisherDetail.Text = value;
            }
        }

        [Category("Custom Props")]
        public string Summary
        {
            get
            {
                return _summary;
            }
            set
            {
                _summary = value;
                txtSummaryDetail.Text = value;
            }
        }
        #endregion

    }
}
