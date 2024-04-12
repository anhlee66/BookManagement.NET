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
            panel3 = new Panel();
            cbPublisherFilter = new ComboBox();
            cbAuthorFilter = new ComboBox();
            label8 = new Label();
            cbGenreFilter = new ComboBox();
            panel4 = new Panel();
            btnSearch = new Button();
            textBox5 = new TextBox();
            panel1 = new Panel();
            flowListBook = new FlowLayoutPanel();
            bookItemControl1 = new CustomControl.BookItemControl();
            panel2 = new Panel();
            bookControl1 = new CustomControl.BookControl();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel1.SuspendLayout();
            flowListBook.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Right;
            panel3.Controls.Add(cbPublisherFilter);
            panel3.Controls.Add(cbAuthorFilter);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(cbGenreFilter);
            panel3.Location = new Point(903, 62);
            panel3.Name = "panel3";
            panel3.Size = new Size(531, 41);
            panel3.TabIndex = 5;
            // 
            // cbPublisherFilter
            // 
            cbPublisherFilter.FormattingEnabled = true;
            cbPublisherFilter.Location = new Point(371, 6);
            cbPublisherFilter.Name = "cbPublisherFilter";
            cbPublisherFilter.Size = new Size(151, 28);
            cbPublisherFilter.TabIndex = 6;
            cbPublisherFilter.Text = "-- filter publiser --";
            // 
            // cbAuthorFilter
            // 
            cbAuthorFilter.FormattingEnabled = true;
            cbAuthorFilter.Location = new Point(200, 6);
            cbAuthorFilter.Name = "cbAuthorFilter";
            cbAuthorFilter.Size = new Size(151, 28);
            cbAuthorFilter.TabIndex = 5;
            cbAuthorFilter.Text = "-- filter author --";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(4, 6);
            label8.Name = "label8";
            label8.Size = new Size(0, 28);
            label8.TabIndex = 4;
            // 
            // cbGenreFilter
            // 
            cbGenreFilter.FormattingEnabled = true;
            cbGenreFilter.Location = new Point(26, 6);
            cbGenreFilter.Name = "cbGenreFilter";
            cbGenreFilter.Size = new Size(151, 28);
            cbGenreFilter.TabIndex = 3;
            cbGenreFilter.Text = "-- filter genre --";
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Right;
            panel4.Controls.Add(btnSearch);
            panel4.Controls.Add(textBox5);
            panel4.Location = new Point(903, 14);
            panel4.Name = "panel4";
            panel4.Size = new Size(531, 47);
            panel4.TabIndex = 6;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = SystemColors.ButtonShadow;
            btnSearch.Image = Properties.Resources.search25x25;
            btnSearch.ImageAlign = ContentAlignment.MiddleLeft;
            btnSearch.Location = new Point(393, 3);
            btnSearch.Margin = new Padding(4);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(129, 41);
            btnSearch.TabIndex = 3;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            // 
            // textBox5
            // 
            textBox5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox5.Location = new Point(22, 9);
            textBox5.Margin = new Padding(4);
            textBox5.Name = "textBox5";
            textBox5.PlaceholderText = "Search ?";
            textBox5.Size = new Size(363, 34);
            textBox5.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1446, 106);
            panel1.TabIndex = 2;
            // 
            // flowListBook
            // 
            flowListBook.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            flowListBook.Controls.Add(bookItemControl1);
            flowListBook.Location = new Point(608, 106);
            flowListBook.Name = "flowListBook";
            flowListBook.Size = new Size(838, 689);
            flowListBook.TabIndex = 4;
            // 
            // bookItemControl1
            // 
            bookItemControl1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            bookItemControl1.AutoSize = true;
            bookItemControl1.BackColor = Color.FromArgb(224, 224, 224);
            bookItemControl1.BorderStyle = BorderStyle.Fixed3D;
            bookItemControl1.Location = new Point(3, 3);
            bookItemControl1.Name = "bookItemControl1";
            bookItemControl1.Size = new Size(684, 154);
            bookItemControl1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(bookControl1);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 106);
            panel2.Name = "panel2";
            panel2.Size = new Size(602, 718);
            panel2.TabIndex = 5;
            // 
            // bookControl1
            // 
            bookControl1.AutoSize = true;
            bookControl1.BackColor = Color.FromArgb(224, 224, 224);
            bookControl1.Location = new Point(3, 6);
            bookControl1.Name = "bookControl1";
            bookControl1.Size = new Size(593, 506);
            bookControl1.TabIndex = 4;
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
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel1.ResumeLayout(false);
            flowListBook.ResumeLayout(false);
            flowListBook.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private ComboBox cbAuthor;
        private Panel panel3;
        private ComboBox cbPublisherFilter;
        private ComboBox cbAuthorFilter;
        private Label label8;
        private ComboBox cbGenreFilter;
        private Panel panel4;
        private Button btnSearch;
        private TextBox textBox5;
        private Panel panel1;
        private FlowLayoutPanel flowListBook;
        private Panel panel2;
        private CustomControl.BookControl bookControl1;
        private CustomControl.BookItemControl bookItemControl1;
    }
}