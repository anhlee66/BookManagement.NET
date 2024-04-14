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
            txtItemSelected = new Label();
            panel6 = new Panel();
            label2 = new Label();
            cbGenreFilter = new ComboBox();
            panel5 = new Panel();
            label3 = new Label();
            cbAuthorFilter = new ComboBox();
            panel4 = new Panel();
            label1 = new Label();
            cbPublisherFilter = new ComboBox();
            flowListBook = new FlowLayoutPanel();
            panel2 = new Panel();
            panelBookDetail = new Panel();
            bookControl1 = new CustomControl.BookControl();
            panel3 = new Panel();
            txtBestSeller = new Label();
            label7 = new Label();
            txtAmountSold = new Label();
            txtQuantity = new Label();
            txtNumberBook = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            panel1.SuspendLayout();
            panel6.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
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
            panel1.Controls.Add(txtItemSelected);
            panel1.Controls.Add(btnClear);
            panel1.Controls.Add(panel6);
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(panel4);
            panel1.Dock = DockStyle.Top;
            panel1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1446, 76);
            panel1.TabIndex = 2;
            // 
            // txtItemSelected
            // 
            txtItemSelected.AutoSize = true;
            txtItemSelected.Location = new Point(44, 24);
            txtItemSelected.Name = "txtItemSelected";
            txtItemSelected.Size = new Size(65, 28);
            txtItemSelected.TabIndex = 14;
            txtItemSelected.Text = "label8";
            txtItemSelected.Visible = false;
            // 
            // panel6
            // 
            panel6.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel6.AutoSize = true;
            panel6.Controls.Add(label2);
            panel6.Controls.Add(cbGenreFilter);
            panel6.Location = new Point(293, 18);
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
            cbGenreFilter.FormattingEnabled = true;
            cbGenreFilter.ImeMode = ImeMode.NoControl;
            cbGenreFilter.Location = new Point(87, 3);
            cbGenreFilter.Name = "cbGenreFilter";
            cbGenreFilter.Size = new Size(248, 36);
            cbGenreFilter.TabIndex = 3;
            cbGenreFilter.Text = "     -- filter genre --   ";
            // 
            // panel5
            // 
            panel5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel5.Controls.Add(label3);
            panel5.Controls.Add(cbAuthorFilter);
            panel5.Location = new Point(659, 18);
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
            cbAuthorFilter.FormattingEnabled = true;
            cbAuthorFilter.Location = new Point(86, 3);
            cbAuthorFilter.Name = "cbAuthorFilter";
            cbAuthorFilter.Size = new Size(230, 36);
            cbAuthorFilter.TabIndex = 5;
            cbAuthorFilter.Text = "     -- filter author --";
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel4.Controls.Add(label1);
            panel4.Controls.Add(cbPublisherFilter);
            panel4.Location = new Point(1008, 18);
            panel4.Name = "panel4";
            panel4.Size = new Size(369, 44);
            panel4.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 11);
            label1.Name = "label1";
            label1.Size = new Size(96, 28);
            label1.TabIndex = 8;
            label1.Text = "Publisher:";
            // 
            // cbPublisherFilter
            // 
            cbPublisherFilter.FormattingEnabled = true;
            cbPublisherFilter.Location = new Point(105, 3);
            cbPublisherFilter.Name = "cbPublisherFilter";
            cbPublisherFilter.Size = new Size(245, 36);
            cbPublisherFilter.TabIndex = 7;
            cbPublisherFilter.Text = "       -- filter publiser --";
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
            flowListBook.Paint += flowListBook_Paint;
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
            bookControl1.Location = new Point(12, -26);
            bookControl1.Name = "bookControl1";
            bookControl1.Publisher = null;
            bookControl1.Quantity = null;
            bookControl1.Size = new Size(568, 426);
            bookControl1.Summary = null;
            bookControl1.TabIndex = 0;
            bookControl1.Title = null;
            // 
            // panel3
            // 
            panel3.Controls.Add(txtBestSeller);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(txtAmountSold);
            panel3.Controls.Add(txtQuantity);
            panel3.Controls.Add(txtNumberBook);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label4);
            panel3.Dock = DockStyle.Top;
            panel3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(602, 260);
            panel3.TabIndex = 5;
            // 
            // txtBestSeller
            // 
            txtBestSeller.AutoSize = true;
            txtBestSeller.Location = new Point(229, 181);
            txtBestSeller.Name = "txtBestSeller";
            txtBestSeller.Size = new Size(65, 28);
            txtBestSeller.TabIndex = 7;
            txtBestSeller.Text = "label8";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(38, 181);
            label7.Name = "label7";
            label7.Size = new Size(105, 28);
            label7.TabIndex = 6;
            label7.Text = "Best Seller:";
            // 
            // txtAmountSold
            // 
            txtAmountSold.AutoSize = true;
            txtAmountSold.Location = new Point(229, 130);
            txtAmountSold.Name = "txtAmountSold";
            txtAmountSold.Size = new Size(65, 28);
            txtAmountSold.TabIndex = 5;
            txtAmountSold.Text = "label9";
            // 
            // txtQuantity
            // 
            txtQuantity.AutoSize = true;
            txtQuantity.Location = new Point(229, 84);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(65, 28);
            txtQuantity.TabIndex = 4;
            txtQuantity.Text = "label8";
            // 
            // txtNumberBook
            // 
            txtNumberBook.AutoSize = true;
            txtNumberBook.Location = new Point(229, 35);
            txtNumberBook.Name = "txtNumberBook";
            txtNumberBook.Size = new Size(65, 28);
            txtNumberBook.TabIndex = 3;
            txtNumberBook.Text = "label7";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(38, 130);
            label6.Name = "label6";
            label6.Size = new Size(129, 28);
            label6.TabIndex = 2;
            label6.Text = "Amount sold:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(38, 84);
            label5.Name = "label5";
            label5.Size = new Size(92, 28);
            label5.TabIndex = 1;
            label5.Text = "Quantity:";
            label5.Click += label5_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(38, 35);
            label4.Name = "label4";
            label4.Size = new Size(162, 28);
            label4.TabIndex = 0;
            label4.Text = "Number of book:";
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
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
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
        private Panel panel4;
        private Label label1;
        private ComboBox cbPublisherFilter;
        private Panel panel3;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label txtAmountSold;
        private Label txtQuantity;
        private Label txtNumberBook;
        private Label txtBestSeller;
        private Label label7;
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

        private Label txtItemSelected;
        private CustomControl.BookControl bookControl1;
        List<Book> books;
    }
}