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

namespace BookManagement.Views.CustomControl
{
    public partial class BookItemControl : UserControl
    {
        private AdminStorage storage;
        public BookItemControl(AdminStorage storage)
        {
            InitializeComponent();
            setEventToChild(this);
            this.storage = storage;
        }
        public BookItemControl()
        {
            InitializeComponent();
            setEventToChild(this);
        }

        #region Properties
        public event EventHandler SelectedChanaged;
        private int id;
        private string _title;
        private string _author;
        private string _price;
        private string _quantity;
        private Image _thumbnail;
        private List<int> authorId;
        private int genreId;
        private bool _isSelected;
        private bool isSelected
        {
            get
            {
                return _isSelected;
            }
            set
            {
                value = _isSelected;
            }
        }
        // 
        private void setEventToChild(Control parent)
        {
            foreach (Control c in parent.Controls)
            {
                c.Click += child_Click;
                setEventToChild((Control)c);
            }

        }
        private void child_Click(Object sender, EventArgs e)
        {
            this.OnClick(new EventArgs());
        }


        // parent click
        private void BookItemControl_Click(object sender, EventArgs e)
        {


        }

        private void itemInfoArea_Paint(object sender, PaintEventArgs e)
        {

        }

        [Category("Custome Props")]
        public string Title
        {
            get { return _title; }
            set
            {
                _title = value;
                txtItemTitle.Text = value;

            }

        }

        [Category("Custome Props")]
        public string Author
        {
            get { return _author; }
            set
            {
                _author = value;
                txtItemAuthor.Text = value;
            }
        }

        [Category("Custome Props")]
        public string Price
        {
            get => _price;
            set
            {
                _price = value;
                txtItemPrice.Text = value;
            }
        }
        [Category("Custome Props")]
        public Image Thumbnail
        {
            get
            {
                return _thumbnail;
            }
            set
            {
                _thumbnail = value;
                ptbThumbnail.Image = _thumbnail;
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
                txtQuantity.Text = value;
            }
        }
        [Category("Custome Props")]
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        [Category("Custome Props")]
        public List<int> AuthorId
        {
            get
            {
                return authorId;
            }
            set
            {
                authorId = value;
            }
        }

        [Category("Custome Props")]
        public int GenreId
        {
            get { return genreId; }
            set { 
                genreId = value;
            }
        }
        #endregion
    }
}
