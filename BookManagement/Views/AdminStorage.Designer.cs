using BookManagement.Models;

namespace BookManagement.Views
{
    partial class AdminStorage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminStorage));
            btnClear = new Button();
            panel1 = new Panel();
            btnClearSelected = new Button();
            btnEdit = new Button();
            btnNew = new Button();
            panel6 = new Panel();
            label2 = new Label();
            cbGenreFilter = new ComboBox();
            panel5 = new Panel();
            label3 = new Label();
            cbAuthorFilter = new ComboBox();
            flowListBook = new FlowLayoutPanel();
            panel2 = new Panel();
            panelBookDetail = new Panel();
            bookControl1 = new CustomControl.BookControl();
            panel3 = new Panel();
            txtAmountSold = new Label();
            txtQuantity = new Label();
            txtNumberBook = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            panel1.SuspendLayout();
            panel6.SuspendLayout();
            panel5.SuspendLayout();
            panel2.SuspendLayout();
            panelBookDetail.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // btnClear
            // 
            btnClear.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClear.BackColor = SystemColors.Control;
            btnClear.Image = (Image)resources.GetObject("btnClear.Image");
            btnClear.Location = new Point(1383, 21);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(51, 36);
            btnClear.TabIndex = 7;
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gainsboro;
            panel1.Controls.Add(btnClearSelected);
            panel1.Controls.Add(btnEdit);
            panel1.Controls.Add(btnNew);
            panel1.Controls.Add(btnClear);
            panel1.Controls.Add(panel6);
            panel1.Controls.Add(panel5);
            panel1.Dock = DockStyle.Top;
            panel1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1446, 76);
            panel1.TabIndex = 2;
            // 
            // btnClearSelected
            // 
            btnClearSelected.BackColor = Color.SlateGray;
            btnClearSelected.ImageAlign = ContentAlignment.MiddleLeft;
            btnClearSelected.Location = new Point(354, 17);
            btnClearSelected.Name = "btnClearSelected";
            btnClearSelected.Size = new Size(125, 44);
            btnClearSelected.TabIndex = 17;
            btnClearSelected.Text = "Clear";
            btnClearSelected.UseVisualStyleBackColor = false;
            btnClearSelected.Click += btnClearSelected_Click;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.SteelBlue;
            btnEdit.Enabled = false;
            btnEdit.Image = (Image)resources.GetObject("btnEdit.Image");
            btnEdit.ImageAlign = ContentAlignment.MiddleLeft;
            btnEdit.Location = new Point(189, 17);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(125, 44);
            btnEdit.TabIndex = 16;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnNew
            // 
            btnNew.BackColor = Color.LimeGreen;
            btnNew.Image = (Image)resources.GetObject("btnNew.Image");
            btnNew.ImageAlign = ContentAlignment.MiddleLeft;
            btnNew.Location = new Point(27, 16);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(125, 44);
            btnNew.TabIndex = 15;
            btnNew.Text = "New";
            btnNew.UseVisualStyleBackColor = false;
            btnNew.Click += btnNew_Click;
            // 
            // panel6
            // 
            panel6.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel6.AutoSize = true;
            panel6.Controls.Add(label2);
            panel6.Controls.Add(cbGenreFilter);
            panel6.Location = new Point(684, 16);
            panel6.Name = "panel6";
            panel6.Size = new Size(338, 44);
            panel6.TabIndex = 13;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 7);
            label2.Name = "label2";
            label2.Size = new Size(68, 28);
            label2.TabIndex = 4;
            label2.Text = "Genre:";
            // 
            // cbGenreFilter
            // 
            cbGenreFilter.BackColor = SystemColors.InactiveCaption;
            cbGenreFilter.FormattingEnabled = true;
            cbGenreFilter.ImeMode = ImeMode.NoControl;
            cbGenreFilter.Location = new Point(87, 3);
            cbGenreFilter.Name = "cbGenreFilter";
            cbGenreFilter.Size = new Size(248, 36);
            cbGenreFilter.TabIndex = 3;
            cbGenreFilter.Text = "     -- filter genre --   ";
            cbGenreFilter.SelectedIndexChanged += filter_SelectedChanged;
            // 
            // panel5
            // 
            panel5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel5.Controls.Add(label3);
            panel5.Controls.Add(cbAuthorFilter);
            panel5.Location = new Point(1038, 17);
            panel5.Name = "panel5";
            panel5.Size = new Size(325, 43);
            panel5.TabIndex = 12;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 7);
            label3.Name = "label3";
            label3.Size = new Size(77, 28);
            label3.TabIndex = 6;
            label3.Text = "Author:";
            // 
            // cbAuthorFilter
            // 
            cbAuthorFilter.BackColor = SystemColors.InactiveCaption;
            cbAuthorFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            cbAuthorFilter.FormattingEnabled = true;
            cbAuthorFilter.Location = new Point(86, 3);
            cbAuthorFilter.Name = "cbAuthorFilter";
            cbAuthorFilter.Size = new Size(230, 36);
            cbAuthorFilter.TabIndex = 5;
            cbAuthorFilter.SelectedIndexChanged += filter_SelectedChanged;
            // 
            // flowListBook
            // 
            flowListBook.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            flowListBook.AutoScroll = true;
            flowListBook.BackColor = Color.WhiteSmoke;
            flowListBook.FlowDirection = FlowDirection.TopDown;
            flowListBook.Location = new Point(608, 76);
            flowListBook.Name = "flowListBook";
            flowListBook.Size = new Size(838, 748);
            flowListBook.TabIndex = 4;
            flowListBook.TabStop = true;
            flowListBook.WrapContents = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.WhiteSmoke;
            panel2.Controls.Add(panelBookDetail);
            panel2.Controls.Add(panel3);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 76);
            panel2.Name = "panel2";
            panel2.Size = new Size(602, 748);
            panel2.TabIndex = 5;
            // 
            // panelBookDetail
            // 
            panelBookDetail.AutoSize = true;
            panelBookDetail.Controls.Add(bookControl1);
            panelBookDetail.Dock = DockStyle.Bottom;
            panelBookDetail.Location = new Point(0, 345);
            panelBookDetail.Name = "panelBookDetail";
            panelBookDetail.Size = new Size(602, 403);
            panelBookDetail.TabIndex = 6;
            // 
            // bookControl1
            // 
            bookControl1.Author = null;
            bookControl1.BackColor = Color.FromArgb(224, 224, 224);
            bookControl1.Genre = null;
            bookControl1.Import = null;
            bookControl1.Location = new Point(12, 13);
            bookControl1.Name = "bookControl1";
            bookControl1.Publisher = null;
            bookControl1.Quantity = null;
            bookControl1.Size = new Size(568, 387);
            bookControl1.Summary = null;
            bookControl1.TabIndex = 0;
            bookControl1.Title = null;
            // 
            // panel3
            // 
            panel3.BackColor = Color.LightSkyBlue;
            panel3.Controls.Add(txtAmountSold);
            panel3.Controls.Add(txtQuantity);
            panel3.Controls.Add(txtNumberBook);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label4);
            panel3.Dock = DockStyle.Top;
            panel3.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(602, 201);
            panel3.TabIndex = 5;
            // 
            // txtAmountSold
            // 
            txtAmountSold.AutoSize = true;
            txtAmountSold.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            txtAmountSold.ForeColor = Color.Transparent;
            txtAmountSold.Location = new Point(262, 130);
            txtAmountSold.Name = "txtAmountSold";
            txtAmountSold.Size = new Size(27, 31);
            txtAmountSold.TabIndex = 5;
            txtAmountSold.Text = "8";
            // 
            // txtQuantity
            // 
            txtQuantity.AutoSize = true;
            txtQuantity.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            txtQuantity.ForeColor = Color.Transparent;
            txtQuantity.Location = new Point(262, 84);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(40, 31);
            txtQuantity.TabIndex = 4;
            txtQuantity.Text = "44";
            // 
            // txtNumberBook
            // 
            txtNumberBook.AutoSize = true;
            txtNumberBook.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            txtNumberBook.ForeColor = Color.Transparent;
            txtNumberBook.Location = new Point(262, 35);
            txtNumberBook.Name = "txtNumberBook";
            txtNumberBook.Size = new Size(27, 31);
            txtNumberBook.TabIndex = 3;
            txtNumberBook.Text = "6";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            label6.Location = new Point(38, 130);
            label6.Name = "label6";
            label6.Size = new Size(159, 31);
            label6.TabIndex = 2;
            label6.Text = "Amount sold:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            label5.Location = new Point(38, 84);
            label5.Name = "label5";
            label5.Size = new Size(114, 31);
            label5.TabIndex = 1;
            label5.Text = "Quantity:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            label4.Location = new Point(38, 35);
            label4.Name = "label4";
            label4.Size = new Size(208, 31);
            label4.TabIndex = 0;
            label4.Text = "Number of books:";
            // 
            // AdminStorage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(1446, 824);
            Controls.Add(panel2);
            Controls.Add(flowListBook);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AdminStorage";
            Text = "AdminStorage";
            Load += AdminStorage_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panelBookDetail.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private ComboBox cbAuthor;
        private Panel panel1;
        private FlowLayoutPanel flowListBook;
        private Panel panel2;
        private CustomControl.BookItemControl bookItemControl1;
        private Button btnClear;
        private Panel panel6;
        private Label label2;
        private ComboBox cbGenreFilter;
        private Panel panel5;
        private Label label3;
        private ComboBox cbAuthorFilter;
        private Panel panel3;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label txtAmountSold;
        private Label txtQuantity;
        private Label txtNumberBook;
        private Panel panelBookDetail;
        public event EventHandler SelectedChanged;
        private int _id;
        private int itemSelected
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
                OnSelectedChanged();

            }
        }
        protected virtual void OnSelectedChanged()
        {
            SelectedChanged?.Invoke(this, EventArgs.Empty);

        }
        private CustomControl.BookControl bookControl1;
        List<Book> books;
        private int author = -1;
        private int genre = -1;
        private Button btnNew;
        private Button btnEdit;
        private Button btnClearSelected;
    }
}