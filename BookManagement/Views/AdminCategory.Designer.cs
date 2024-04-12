using System.Data;

namespace BookManagement.Views
{
    partial class AdminCategory
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
            label1 = new Label();
            tabCategory = new TabControl();
            tabGenre = new TabPage();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            btnSearch = new Button();
            textBox1 = new TextBox();
            dgvGenre = new DataGridView();
            genreName = new DataGridViewTextBoxColumn();
            genreDescription = new DataGridViewTextBoxColumn();
            panel1 = new Panel();
            groupBox1 = new GroupBox();
            btnDeleteGenre = new Button();
            btnUpdateGenre = new Button();
            btnNewGenre = new Button();
            label8 = new Label();
            txtGenreDescription = new Label();
            txtGenreName = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            tabAuthor = new TabPage();
            panel11 = new Panel();
            dgvAuthor = new DataGridView();
            authorName = new DataGridViewTextBoxColumn();
            authorContact = new DataGridViewTextBoxColumn();
            authorDescription = new DataGridViewTextBoxColumn();
            panel6 = new Panel();
            panel7 = new Panel();
            button7 = new Button();
            textBox2 = new TextBox();
            panel5 = new Panel();
            groupBox2 = new GroupBox();
            btnDeleteAuthor = new Button();
            btnUpdateAuthor = new Button();
            btnNewAuthor = new Button();
            txtAuthorContact = new Label();
            txtAuthorDescription = new Label();
            txtAuthorName = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            tabPuslisher = new TabPage();
            dgvPublisher = new DataGridView();
            publisherName = new DataGridViewTextBoxColumn();
            publisherContact = new DataGridViewTextBoxColumn();
            publisherAddress = new DataGridViewTextBoxColumn();
            publisherDescription = new DataGridViewTextBoxColumn();
            panel9 = new Panel();
            panel10 = new Panel();
            button11 = new Button();
            textBox3 = new TextBox();
            panel8 = new Panel();
            groupBox3 = new GroupBox();
            txtPublisherAddress = new Label();
            label24 = new Label();
            btnDeletePublisher = new Button();
            btnUpdatePublisher = new Button();
            btnNewPublisher = new Button();
            txtPublisherContact = new Label();
            txtPublisherDescription = new Label();
            txtPublisherName = new Label();
            label19 = new Label();
            label20 = new Label();
            label21 = new Label();
            label22 = new Label();
            tabCategory.SuspendLayout();
            tabGenre.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvGenre).BeginInit();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            tabAuthor.SuspendLayout();
            panel11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAuthor).BeginInit();
            panel6.SuspendLayout();
            panel7.SuspendLayout();
            panel5.SuspendLayout();
            groupBox2.SuspendLayout();
            tabPuslisher.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPublisher).BeginInit();
            panel9.SuspendLayout();
            panel10.SuspendLayout();
            panel8.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(349, 215);
            label1.Name = "label1";
            label1.Size = new Size(168, 28);
            label1.TabIndex = 1;
            label1.Text = "Welcom Category";
            // 
            // tabCategory
            // 
            tabCategory.Controls.Add(tabGenre);
            tabCategory.Controls.Add(tabAuthor);
            tabCategory.Controls.Add(tabPuslisher);
            tabCategory.Dock = DockStyle.Fill;
            tabCategory.Font = new Font("Segoe UI", 12F);
            tabCategory.Location = new Point(0, 0);
            tabCategory.Multiline = true;
            tabCategory.Name = "tabCategory";
            tabCategory.SelectedIndex = 0;
            tabCategory.Size = new Size(1062, 602);
            tabCategory.TabIndex = 2;
            // 
            // tabGenre
            // 
            tabGenre.Controls.Add(panel2);
            tabGenre.Controls.Add(panel1);
            tabGenre.Font = new Font("Segoe UI", 12F);
            tabGenre.Location = new Point(4, 37);
            tabGenre.Name = "tabGenre";
            tabGenre.Padding = new Padding(3);
            tabGenre.Size = new Size(1054, 561);
            tabGenre.TabIndex = 0;
            tabGenre.Text = "Genre";
            tabGenre.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.AutoSize = true;
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(dgvGenre);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(457, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(594, 555);
            panel2.TabIndex = 2;
            // 
            // panel3
            // 
            panel3.Controls.Add(panel4);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(594, 62);
            panel3.TabIndex = 2;
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Right;
            panel4.Controls.Add(btnSearch);
            panel4.Controls.Add(textBox1);
            panel4.Location = new Point(26, 12);
            panel4.Name = "panel4";
            panel4.Size = new Size(531, 47);
            panel4.TabIndex = 1;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.LightBlue;
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
            // textBox1
            // 
            textBox1.Location = new Point(22, 6);
            textBox1.Margin = new Padding(4);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Search ?";
            textBox1.Size = new Size(363, 34);
            textBox1.TabIndex = 2;
            // 
            // dgvGenre
            // 
            dgvGenre.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvGenre.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGenre.Columns.AddRange(new DataGridViewColumn[] { genreName, genreDescription });
            dgvGenre.Location = new Point(26, 83);
            dgvGenre.MultiSelect = false;
            dgvGenre.Name = "dgvGenre";
            dgvGenre.ReadOnly = true;
            dgvGenre.RowHeadersWidth = 51;
            dgvGenre.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvGenre.Size = new Size(563, 457);
            dgvGenre.TabIndex = 1;
            dgvGenre.CellClick += dgvGenre_CellContentClick;
            // 
            // genreName
            // 
            genreName.DataPropertyName = "Name";
            genreName.HeaderText = "Genre name";
            genreName.MinimumWidth = 6;
            genreName.Name = "genreName";
            genreName.ReadOnly = true;
            genreName.Width = 300;
            // 
            // genreDescription
            // 
            genreDescription.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            genreDescription.DataPropertyName = "Description";
            genreDescription.HeaderText = "Description";
            genreDescription.MinimumWidth = 6;
            genreDescription.Name = "genreDescription";
            genreDescription.ReadOnly = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(groupBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(454, 555);
            panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.AutoSize = true;
            groupBox1.Controls.Add(btnDeleteGenre);
            groupBox1.Controls.Add(btnUpdateGenre);
            groupBox1.Controls.Add(btnNewGenre);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(txtGenreDescription);
            groupBox1.Controls.Add(txtGenreName);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(12, 83);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(436, 444);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            // 
            // btnDeleteGenre
            // 
            btnDeleteGenre.Location = new Point(300, 372);
            btnDeleteGenre.Name = "btnDeleteGenre";
            btnDeleteGenre.Size = new Size(102, 39);
            btnDeleteGenre.TabIndex = 13;
            btnDeleteGenre.Text = "Delete";
            btnDeleteGenre.UseVisualStyleBackColor = true;
            // 
            // btnUpdateGenre
            // 
            btnUpdateGenre.Location = new Point(171, 372);
            btnUpdateGenre.Name = "btnUpdateGenre";
            btnUpdateGenre.Size = new Size(102, 39);
            btnUpdateGenre.TabIndex = 12;
            btnUpdateGenre.Text = "Update";
            btnUpdateGenre.UseVisualStyleBackColor = true;
            btnUpdateGenre.Click += btnUpdateGenre_Click;
            // 
            // btnNewGenre
            // 
            btnNewGenre.Location = new Point(35, 372);
            btnNewGenre.Name = "btnNewGenre";
            btnNewGenre.Size = new Size(102, 39);
            btnNewGenre.TabIndex = 11;
            btnNewGenre.Text = "New";
            btnNewGenre.UseVisualStyleBackColor = true;
            btnNewGenre.Click += btnNewGenre_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(178, 167);
            label8.Name = "label8";
            label8.Size = new Size(65, 28);
            label8.TabIndex = 10;
            label8.Text = "label8";
            // 
            // txtGenreDescription
            // 
            txtGenreDescription.AutoSize = true;
            txtGenreDescription.Location = new Point(178, 217);
            txtGenreDescription.Name = "txtGenreDescription";
            txtGenreDescription.Size = new Size(65, 28);
            txtGenreDescription.TabIndex = 9;
            txtGenreDescription.Text = "label7";
            // 
            // txtGenreName
            // 
            txtGenreName.AutoSize = true;
            txtGenreName.Location = new Point(178, 120);
            txtGenreName.Name = "txtGenreName";
            txtGenreName.Size = new Size(120, 28);
            txtGenreName.TabIndex = 8;
            txtGenreName.Text = "Truyen tranh";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label5.Location = new Point(21, 167);
            label5.Name = "label5";
            label5.Size = new Size(133, 28);
            label5.TabIndex = 7;
            label5.Text = "Books in list:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label4.Location = new Point(21, 217);
            label4.Name = "label4";
            label4.Size = new Size(126, 28);
            label4.TabIndex = 6;
            label4.Text = "Description:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.Location = new Point(21, 120);
            label3.Name = "label3";
            label3.Size = new Size(135, 28);
            label3.TabIndex = 5;
            label3.Text = "Genre Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(133, 53);
            label2.Name = "label2";
            label2.Size = new Size(171, 38);
            label2.TabIndex = 4;
            label2.Text = "Book Genre";
            // 
            // tabAuthor
            // 
            tabAuthor.Controls.Add(panel11);
            tabAuthor.Controls.Add(panel6);
            tabAuthor.Controls.Add(panel5);
            tabAuthor.Font = new Font("Segoe UI", 12F);
            tabAuthor.Location = new Point(4, 37);
            tabAuthor.Name = "tabAuthor";
            tabAuthor.Padding = new Padding(3);
            tabAuthor.Size = new Size(1054, 561);
            tabAuthor.TabIndex = 1;
            tabAuthor.Text = "Author";
            tabAuthor.UseVisualStyleBackColor = true;
            // 
            // panel11
            // 
            panel11.Controls.Add(dgvAuthor);
            panel11.Dock = DockStyle.Fill;
            panel11.Location = new Point(457, 65);
            panel11.Name = "panel11";
            panel11.Size = new Size(594, 493);
            panel11.TabIndex = 5;
            // 
            // dgvAuthor
            // 
            dgvAuthor.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvAuthor.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAuthor.Columns.AddRange(new DataGridViewColumn[] { authorName, authorContact, authorDescription });
            dgvAuthor.Location = new Point(27, 38);
            dgvAuthor.MultiSelect = false;
            dgvAuthor.Name = "dgvAuthor";
            dgvAuthor.ReadOnly = true;
            dgvAuthor.RowHeadersWidth = 51;
            dgvAuthor.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAuthor.Size = new Size(553, 427);
            dgvAuthor.TabIndex = 4;
            dgvAuthor.CellClick += dgvAuthor_CellClick;
            // 
            // authorName
            // 
            authorName.DataPropertyName = "Name";
            authorName.HeaderText = "Author name";
            authorName.MinimumWidth = 6;
            authorName.Name = "authorName";
            authorName.ReadOnly = true;
            authorName.Width = 300;
            // 
            // authorContact
            // 
            authorContact.DataPropertyName = "Contact";
            authorContact.HeaderText = "Contact";
            authorContact.MinimumWidth = 6;
            authorContact.Name = "authorContact";
            authorContact.ReadOnly = true;
            authorContact.Width = 300;
            // 
            // authorDescription
            // 
            authorDescription.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            authorDescription.DataPropertyName = "Description";
            authorDescription.HeaderText = "Description";
            authorDescription.MinimumWidth = 6;
            authorDescription.Name = "authorDescription";
            authorDescription.ReadOnly = true;
            // 
            // panel6
            // 
            panel6.Controls.Add(panel7);
            panel6.Dock = DockStyle.Top;
            panel6.Location = new Point(457, 3);
            panel6.Name = "panel6";
            panel6.Size = new Size(594, 62);
            panel6.TabIndex = 3;
            // 
            // panel7
            // 
            panel7.Anchor = AnchorStyles.Right;
            panel7.Controls.Add(button7);
            panel7.Controls.Add(textBox2);
            panel7.Location = new Point(58, 3);
            panel7.Name = "panel7";
            panel7.Size = new Size(531, 47);
            panel7.TabIndex = 1;
            // 
            // button7
            // 
            button7.BackColor = Color.LightBlue;
            button7.Image = Properties.Resources.search25x25;
            button7.ImageAlign = ContentAlignment.MiddleLeft;
            button7.Location = new Point(393, 3);
            button7.Margin = new Padding(4);
            button7.Name = "button7";
            button7.Size = new Size(129, 41);
            button7.TabIndex = 3;
            button7.Text = "Search";
            button7.UseVisualStyleBackColor = false;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(22, 6);
            textBox2.Margin = new Padding(4);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Search ?";
            textBox2.Size = new Size(363, 34);
            textBox2.TabIndex = 2;
            // 
            // panel5
            // 
            panel5.Controls.Add(groupBox2);
            panel5.Dock = DockStyle.Left;
            panel5.Location = new Point(3, 3);
            panel5.Name = "panel5";
            panel5.Size = new Size(454, 555);
            panel5.TabIndex = 1;
            // 
            // groupBox2
            // 
            groupBox2.AutoSize = true;
            groupBox2.Controls.Add(btnDeleteAuthor);
            groupBox2.Controls.Add(btnUpdateAuthor);
            groupBox2.Controls.Add(btnNewAuthor);
            groupBox2.Controls.Add(txtAuthorContact);
            groupBox2.Controls.Add(txtAuthorDescription);
            groupBox2.Controls.Add(txtAuthorName);
            groupBox2.Controls.Add(label12);
            groupBox2.Controls.Add(label13);
            groupBox2.Controls.Add(label14);
            groupBox2.Controls.Add(label15);
            groupBox2.Location = new Point(12, 83);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(446, 444);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            // 
            // btnDeleteAuthor
            // 
            btnDeleteAuthor.Location = new Point(300, 372);
            btnDeleteAuthor.Name = "btnDeleteAuthor";
            btnDeleteAuthor.Size = new Size(102, 39);
            btnDeleteAuthor.TabIndex = 13;
            btnDeleteAuthor.Text = "Delete";
            btnDeleteAuthor.UseVisualStyleBackColor = true;
            // 
            // btnUpdateAuthor
            // 
            btnUpdateAuthor.Location = new Point(171, 372);
            btnUpdateAuthor.Name = "btnUpdateAuthor";
            btnUpdateAuthor.Size = new Size(102, 39);
            btnUpdateAuthor.TabIndex = 12;
            btnUpdateAuthor.Text = "Update";
            btnUpdateAuthor.UseVisualStyleBackColor = true;
            // 
            // btnNewAuthor
            // 
            btnNewAuthor.Location = new Point(35, 372);
            btnNewAuthor.Name = "btnNewAuthor";
            btnNewAuthor.Size = new Size(102, 39);
            btnNewAuthor.TabIndex = 11;
            btnNewAuthor.Text = "New";
            btnNewAuthor.UseVisualStyleBackColor = true;
            // 
            // txtAuthorContact
            // 
            txtAuthorContact.AutoSize = true;
            txtAuthorContact.Location = new Point(178, 167);
            txtAuthorContact.Name = "txtAuthorContact";
            txtAuthorContact.Size = new Size(159, 28);
            txtAuthorContact.TabIndex = 10;
            txtAuthorContact.Text = "(+84)765109055";
            // 
            // txtAuthorDescription
            // 
            txtAuthorDescription.AutoSize = true;
            txtAuthorDescription.Location = new Point(178, 217);
            txtAuthorDescription.Name = "txtAuthorDescription";
            txtAuthorDescription.Size = new Size(88, 28);
            txtAuthorDescription.TabIndex = 9;
            txtAuthorDescription.Text = "Dep chai";
            // 
            // txtAuthorName
            // 
            txtAuthorName.AutoSize = true;
            txtAuthorName.Location = new Point(178, 120);
            txtAuthorName.Name = "txtAuthorName";
            txtAuthorName.Size = new Size(118, 28);
            txtAuthorName.TabIndex = 8;
            txtAuthorName.Text = "Le Tuan Anh";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label12.Location = new Point(21, 167);
            label12.Name = "label12";
            label12.Size = new Size(90, 28);
            label12.TabIndex = 7;
            label12.Text = "Contact:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label13.Location = new Point(21, 217);
            label13.Name = "label13";
            label13.Size = new Size(126, 28);
            label13.TabIndex = 6;
            label13.Text = "Description:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label14.Location = new Point(21, 120);
            label14.Name = "label14";
            label14.Size = new Size(141, 28);
            label14.TabIndex = 5;
            label14.Text = "Author name:";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label15.Location = new Point(80, 54);
            label15.Name = "label15";
            label15.Size = new Size(277, 38);
            label15.TabIndex = 4;
            label15.Text = "Author Information";
            // 
            // tabPuslisher
            // 
            tabPuslisher.Controls.Add(dgvPublisher);
            tabPuslisher.Controls.Add(panel9);
            tabPuslisher.Controls.Add(panel8);
            tabPuslisher.Font = new Font("Segoe UI", 12F);
            tabPuslisher.Location = new Point(4, 37);
            tabPuslisher.Name = "tabPuslisher";
            tabPuslisher.Padding = new Padding(3);
            tabPuslisher.Size = new Size(1054, 561);
            tabPuslisher.TabIndex = 2;
            tabPuslisher.Text = "Publisher";
            tabPuslisher.UseVisualStyleBackColor = true;
            // 
            // dgvPublisher
            // 
            dgvPublisher.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvPublisher.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPublisher.Columns.AddRange(new DataGridViewColumn[] { publisherName, publisherContact, publisherAddress, publisherDescription });
            dgvPublisher.Location = new Point(487, 98);
            dgvPublisher.MultiSelect = false;
            dgvPublisher.Name = "dgvPublisher";
            dgvPublisher.ReadOnly = true;
            dgvPublisher.RowHeadersWidth = 51;
            dgvPublisher.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPublisher.Size = new Size(550, 457);
            dgvPublisher.TabIndex = 5;
            dgvPublisher.CellClick += dgvPublisher_CellClick;
            // 
            // publisherName
            // 
            publisherName.DataPropertyName = "Name";
            publisherName.HeaderText = "Publisher name";
            publisherName.MinimumWidth = 6;
            publisherName.Name = "publisherName";
            publisherName.ReadOnly = true;
            publisherName.Width = 300;
            // 
            // publisherContact
            // 
            publisherContact.DataPropertyName = "Contact";
            publisherContact.HeaderText = "Contact";
            publisherContact.MinimumWidth = 6;
            publisherContact.Name = "publisherContact";
            publisherContact.ReadOnly = true;
            publisherContact.Width = 300;
            // 
            // publisherAddress
            // 
            publisherAddress.DataPropertyName = "Address";
            publisherAddress.HeaderText = "Address";
            publisherAddress.MinimumWidth = 6;
            publisherAddress.Name = "publisherAddress";
            publisherAddress.ReadOnly = true;
            publisherAddress.Width = 125;
            // 
            // publisherDescription
            // 
            publisherDescription.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            publisherDescription.DataPropertyName = "Description";
            publisherDescription.HeaderText = "Description";
            publisherDescription.MinimumWidth = 6;
            publisherDescription.Name = "publisherDescription";
            publisherDescription.ReadOnly = true;
            // 
            // panel9
            // 
            panel9.Controls.Add(panel10);
            panel9.Dock = DockStyle.Top;
            panel9.Location = new Point(457, 3);
            panel9.Name = "panel9";
            panel9.Size = new Size(594, 62);
            panel9.TabIndex = 3;
            // 
            // panel10
            // 
            panel10.Anchor = AnchorStyles.Right;
            panel10.Controls.Add(button11);
            panel10.Controls.Add(textBox3);
            panel10.Location = new Point(58, 3);
            panel10.Name = "panel10";
            panel10.Size = new Size(531, 47);
            panel10.TabIndex = 1;
            // 
            // button11
            // 
            button11.BackColor = Color.LightBlue;
            button11.Image = Properties.Resources.search25x25;
            button11.ImageAlign = ContentAlignment.MiddleLeft;
            button11.Location = new Point(393, 3);
            button11.Margin = new Padding(4);
            button11.Name = "button11";
            button11.Size = new Size(129, 41);
            button11.TabIndex = 3;
            button11.Text = "Search";
            button11.UseVisualStyleBackColor = false;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(22, 6);
            textBox3.Margin = new Padding(4);
            textBox3.Name = "textBox3";
            textBox3.PlaceholderText = "Search ?";
            textBox3.Size = new Size(363, 34);
            textBox3.TabIndex = 2;
            // 
            // panel8
            // 
            panel8.Controls.Add(groupBox3);
            panel8.Dock = DockStyle.Left;
            panel8.Location = new Point(3, 3);
            panel8.Name = "panel8";
            panel8.Size = new Size(454, 555);
            panel8.TabIndex = 1;
            // 
            // groupBox3
            // 
            groupBox3.AutoSize = true;
            groupBox3.Controls.Add(txtPublisherAddress);
            groupBox3.Controls.Add(label24);
            groupBox3.Controls.Add(btnDeletePublisher);
            groupBox3.Controls.Add(btnUpdatePublisher);
            groupBox3.Controls.Add(btnNewPublisher);
            groupBox3.Controls.Add(txtPublisherContact);
            groupBox3.Controls.Add(txtPublisherDescription);
            groupBox3.Controls.Add(txtPublisherName);
            groupBox3.Controls.Add(label19);
            groupBox3.Controls.Add(label20);
            groupBox3.Controls.Add(label21);
            groupBox3.Controls.Add(label22);
            groupBox3.Location = new Point(12, 83);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(436, 444);
            groupBox3.TabIndex = 4;
            groupBox3.TabStop = false;
            // 
            // txtPublisherAddress
            // 
            txtPublisherAddress.AutoSize = true;
            txtPublisherAddress.Location = new Point(178, 219);
            txtPublisherAddress.Name = "txtPublisherAddress";
            txtPublisherAddress.Size = new Size(177, 28);
            txtPublisherAddress.TabIndex = 15;
            txtPublisherAddress.Text = "Ninh Kieu, Can Tho";
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label24.Location = new Point(21, 219);
            label24.Name = "label24";
            label24.Size = new Size(92, 28);
            label24.TabIndex = 14;
            label24.Text = "Address:";
            // 
            // btnDeletePublisher
            // 
            btnDeletePublisher.Location = new Point(300, 372);
            btnDeletePublisher.Name = "btnDeletePublisher";
            btnDeletePublisher.Size = new Size(102, 39);
            btnDeletePublisher.TabIndex = 13;
            btnDeletePublisher.Text = "Delete";
            btnDeletePublisher.UseVisualStyleBackColor = true;
            // 
            // btnUpdatePublisher
            // 
            btnUpdatePublisher.Location = new Point(171, 372);
            btnUpdatePublisher.Name = "btnUpdatePublisher";
            btnUpdatePublisher.Size = new Size(102, 39);
            btnUpdatePublisher.TabIndex = 12;
            btnUpdatePublisher.Text = "Update";
            btnUpdatePublisher.UseVisualStyleBackColor = true;
            // 
            // btnNewPublisher
            // 
            btnNewPublisher.Location = new Point(35, 372);
            btnNewPublisher.Name = "btnNewPublisher";
            btnNewPublisher.Size = new Size(102, 39);
            btnNewPublisher.TabIndex = 11;
            btnNewPublisher.Text = "New";
            btnNewPublisher.UseVisualStyleBackColor = true;
            // 
            // txtPublisherContact
            // 
            txtPublisherContact.AutoSize = true;
            txtPublisherContact.Location = new Point(178, 167);
            txtPublisherContact.Name = "txtPublisherContact";
            txtPublisherContact.Size = new Size(76, 28);
            txtPublisherContact.TabIndex = 10;
            txtPublisherContact.Text = "label16";
            // 
            // txtPublisherDescription
            // 
            txtPublisherDescription.AutoSize = true;
            txtPublisherDescription.Location = new Point(178, 263);
            txtPublisherDescription.Name = "txtPublisherDescription";
            txtPublisherDescription.Size = new Size(76, 28);
            txtPublisherDescription.TabIndex = 9;
            txtPublisherDescription.Text = "label17";
            // 
            // txtPublisherName
            // 
            txtPublisherName.AutoSize = true;
            txtPublisherName.Location = new Point(178, 120);
            txtPublisherName.Name = "txtPublisherName";
            txtPublisherName.Size = new Size(120, 28);
            txtPublisherName.TabIndex = 8;
            txtPublisherName.Text = "Truyen tranh";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label19.Location = new Point(21, 167);
            label19.Name = "label19";
            label19.Size = new Size(90, 28);
            label19.TabIndex = 7;
            label19.Text = "Contact:";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label20.Location = new Point(21, 263);
            label20.Name = "label20";
            label20.Size = new Size(126, 28);
            label20.TabIndex = 6;
            label20.Text = "Description:";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label21.Location = new Point(21, 120);
            label21.Name = "label21";
            label21.Size = new Size(151, 28);
            label21.TabIndex = 5;
            label21.Text = "Publiser name:";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label22.Location = new Point(74, 40);
            label22.Name = "label22";
            label22.Size = new Size(289, 38);
            label22.TabIndex = 4;
            label22.Text = "Publiser Information";
            // 
            // AdminCategory
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1062, 602);
            Controls.Add(tabCategory);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AdminCategory";
            Text = "AdminCategory";
            Load += AdminCategory_Load;
            tabCategory.ResumeLayout(false);
            tabGenre.ResumeLayout(false);
            tabGenre.PerformLayout();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvGenre).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            tabAuthor.ResumeLayout(false);
            panel11.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvAuthor).EndInit();
            panel6.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            tabPuslisher.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvPublisher).EndInit();
            panel9.ResumeLayout(false);
            panel10.ResumeLayout(false);
            panel10.PerformLayout();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TabControl tabCategory;
        private TabPage tabGenre;
        private TabPage tabAuthor;
        private TabPage tabPuslisher;
        private Panel panel1;
        private GroupBox groupBox1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button btnDeleteGenre;
        private Button btnUpdateGenre;
        private Button btnNewGenre;
        private Label label8;
        private Label txtGenreDescription;
        private Label txtGenreName;
        private Panel panel2;
        private DataGridView dgvGenre;
        private Panel panel3;
        private Panel panel4;
        private Button btnSearch;
        private TextBox textBox1;
        private DataGridView dgvAuthor;
        private Panel panel6;
        private Panel panel7;
        private Button button7;
        private TextBox textBox2;
        private Panel panel5;
        private GroupBox groupBox2;
        private Button btnDeleteAuthor;
        private Button btnUpdateAuthor;
        private Button btnNewAuthor;
        private Label txtAuthorContact;
        private Label txtAuthorDescription;
        private Label txtAuthorName;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label15;
        private Panel panel9;
        private Panel panel10;
        private Button button11;
        private TextBox textBox3;
        private Panel panel8;
        private GroupBox groupBox3;
        private Button btnDeletePublisher;
        private Button btnUpdatePublisher;
        private Button btnNewPublisher;
        private Label txtPublisherContact;
        private Label txtPublisherDescription;
        private Label txtPublisherName;
        private Label label19;
        private Label label20;
        private Label label21;
        private Label label22;
        private Panel panel11;
        private DataGridView dgvPublisher;
        private Label txtPublisherAddress;
        private Label label24;
        private DataGridViewTextBoxColumn authorName;
        private DataGridViewTextBoxColumn authorContact;
        private DataGridViewTextBoxColumn authorDescription;
        private DataGridViewTextBoxColumn publisherName;
        private DataGridViewTextBoxColumn publisherContact;
        private DataGridViewTextBoxColumn publisherAddress;
        private DataGridViewTextBoxColumn publisherDescription;
        private DataGridViewTextBoxColumn genreName;
        private DataGridViewTextBoxColumn genreDescription;
        private DataTable dtGenre;
        private DataTable dtAuthor;
        private DataTable dtPublisher;
    }
}