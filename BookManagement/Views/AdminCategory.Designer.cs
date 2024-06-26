﻿using BookManagement.Models;
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
        /// </summary>button
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminCategory));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            label1 = new Label();
            tabCategory = new TabControl();
            tabGenre = new TabPage();
            panel2 = new Panel();
            panel3 = new Panel();
            panel1 = new Panel();
            btnDeleteGenre = new Button();
            btnEditGenre = new Button();
            btnNewGenre = new Button();
            dgvGenre = new DataGridView();
            genreName = new DataGridViewTextBoxColumn();
            genreDescription = new DataGridViewTextBoxColumn();
            tabAuthor = new TabPage();
            panel6 = new Panel();
            panel4 = new Panel();
            panel5 = new Panel();
            btnDeleteAuthor = new Button();
            btnEditAuthor = new Button();
            btnNewAuthor = new Button();
            dgvAuthor = new DataGridView();
            authorName = new DataGridViewTextBoxColumn();
            authorContact = new DataGridViewTextBoxColumn();
            authorDescription = new DataGridViewTextBoxColumn();
            tabPuslisher = new TabPage();
            panel11 = new Panel();
            dgvPublisher = new DataGridView();
            publisherName = new DataGridViewTextBoxColumn();
            publisherContact = new DataGridViewTextBoxColumn();
            publisherDescription = new DataGridViewTextBoxColumn();
            panel9 = new Panel();
            panel8 = new Panel();
            panel7 = new Panel();
            btnDeletePublisher = new Button();
            btnEditPuslisher = new Button();
            btnNewPublisher = new Button();
            button8 = new Button();
            button9 = new Button();
            tabCategory.SuspendLayout();
            tabGenre.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvGenre).BeginInit();
            tabAuthor.SuspendLayout();
            panel6.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAuthor).BeginInit();
            tabPuslisher.SuspendLayout();
            panel11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPublisher).BeginInit();
            panel9.SuspendLayout();
            panel8.SuspendLayout();
            panel7.SuspendLayout();
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
            tabCategory.Appearance = TabAppearance.FlatButtons;
            tabCategory.Controls.Add(tabGenre);
            tabCategory.Controls.Add(tabAuthor);
            tabCategory.Controls.Add(tabPuslisher);
            tabCategory.Dock = DockStyle.Fill;
            tabCategory.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tabCategory.Location = new Point(0, 0);
            tabCategory.Margin = new Padding(0);
            tabCategory.Multiline = true;
            tabCategory.Name = "tabCategory";
            tabCategory.SelectedIndex = 0;
            tabCategory.Size = new Size(850, 451);
            tabCategory.TabIndex = 2;
            // 
            // tabGenre
            // 
            tabGenre.Controls.Add(panel2);
            tabGenre.Font = new Font("Segoe UI", 12F);
            tabGenre.Location = new Point(4, 40);
            tabGenre.Name = "tabGenre";
            tabGenre.Padding = new Padding(3);
            tabGenre.Size = new Size(842, 407);
            tabGenre.TabIndex = 0;
            tabGenre.Text = "Genre";
            tabGenre.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.AutoSize = true;
            panel2.BackColor = Color.LightGray;
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(dgvGenre);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(836, 401);
            panel2.TabIndex = 2;
            // 
            // panel3
            // 
            panel3.Controls.Add(panel1);
            panel3.Controls.Add(btnNewGenre);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(836, 62);
            panel3.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel1.Controls.Add(btnDeleteGenre);
            panel1.Controls.Add(btnEditGenre);
            panel1.Location = new Point(497, 10);
            panel1.Name = "panel1";
            panel1.Size = new Size(334, 45);
            panel1.TabIndex = 6;
            // 
            // btnDeleteGenre
            // 
            btnDeleteGenre.BackColor = Color.Salmon;
            btnDeleteGenre.Enabled = false;
            btnDeleteGenre.FlatAppearance.BorderSize = 0;
            btnDeleteGenre.FlatStyle = FlatStyle.Flat;
            btnDeleteGenre.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDeleteGenre.ForeColor = SystemColors.ButtonFace;
            btnDeleteGenre.Image = (Image)resources.GetObject("btnDeleteGenre.Image");
            btnDeleteGenre.ImageAlign = ContentAlignment.MiddleLeft;
            btnDeleteGenre.Location = new Point(184, 4);
            btnDeleteGenre.Margin = new Padding(4);
            btnDeleteGenre.Name = "btnDeleteGenre";
            btnDeleteGenre.Size = new Size(146, 37);
            btnDeleteGenre.TabIndex = 5;
            btnDeleteGenre.Text = "Delete";
            btnDeleteGenre.UseVisualStyleBackColor = false;
            btnDeleteGenre.Click += btnDeleteGenre_Click;
            // 
            // btnEditGenre
            // 
            btnEditGenre.BackColor = Color.SteelBlue;
            btnEditGenre.Enabled = false;
            btnEditGenre.FlatAppearance.BorderSize = 0;
            btnEditGenre.FlatStyle = FlatStyle.Flat;
            btnEditGenre.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            btnEditGenre.ForeColor = SystemColors.ButtonFace;
            btnEditGenre.Image = (Image)resources.GetObject("btnEditGenre.Image");
            btnEditGenre.ImageAlign = ContentAlignment.MiddleLeft;
            btnEditGenre.Location = new Point(4, 4);
            btnEditGenre.Margin = new Padding(4);
            btnEditGenre.Name = "btnEditGenre";
            btnEditGenre.Size = new Size(146, 37);
            btnEditGenre.TabIndex = 4;
            btnEditGenre.Text = "Edit";
            btnEditGenre.UseVisualStyleBackColor = false;
            btnEditGenre.Click += btnEditGenre_Click;
            // 
            // btnNewGenre
            // 
            btnNewGenre.BackColor = Color.SteelBlue;
            btnNewGenre.FlatAppearance.BorderSize = 0;
            btnNewGenre.FlatStyle = FlatStyle.Flat;
            btnNewGenre.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            btnNewGenre.ForeColor = SystemColors.ButtonFace;
            btnNewGenre.Image = (Image)resources.GetObject("btnNewGenre.Image");
            btnNewGenre.ImageAlign = ContentAlignment.MiddleLeft;
            btnNewGenre.Location = new Point(6, 14);
            btnNewGenre.Margin = new Padding(4);
            btnNewGenre.Name = "btnNewGenre";
            btnNewGenre.Size = new Size(146, 37);
            btnNewGenre.TabIndex = 3;
            btnNewGenre.Text = "New";
            btnNewGenre.UseVisualStyleBackColor = false;
            btnNewGenre.Click += btnNewGenre_Click;
            // 
            // dgvGenre
            // 
            dgvGenre.AllowUserToAddRows = false;
            dgvGenre.AllowUserToDeleteRows = false;
            dgvGenre.AllowUserToResizeColumns = false;
            dgvGenre.AllowUserToResizeRows = false;
            dgvGenre.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvGenre.BackgroundColor = Color.LightGray;
            dgvGenre.BorderStyle = BorderStyle.None;
            dgvGenre.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.SteelBlue;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.InactiveBorder;
            dataGridViewCellStyle1.SelectionBackColor = Color.SteelBlue;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvGenre.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvGenre.ColumnHeadersHeight = 40;
            dgvGenre.Columns.AddRange(new DataGridViewColumn[] { genreName, genreDescription });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.Silver;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.ButtonShadow;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvGenre.DefaultCellStyle = dataGridViewCellStyle2;
            dgvGenre.EnableHeadersVisualStyles = false;
            dgvGenre.Location = new Point(5, 68);
            dgvGenre.MultiSelect = false;
            dgvGenre.Name = "dgvGenre";
            dgvGenre.ReadOnly = true;
            dgvGenre.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.LightGray;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 12F);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvGenre.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvGenre.RowHeadersVisible = false;
            dgvGenre.RowHeadersWidth = 51;
            dgvGenre.RowTemplate.Height = 35;
            dgvGenre.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvGenre.Size = new Size(826, 318);
            dgvGenre.TabIndex = 1;
            dgvGenre.CellClick += dgvGenre_CellClick;
            dgvGenre.Click += dgvGenre_Click;
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
            // tabAuthor
            // 
            tabAuthor.BackColor = Color.LightGray;
            tabAuthor.Controls.Add(panel6);
            tabAuthor.Font = new Font("Segoe UI", 12F);
            tabAuthor.Location = new Point(4, 40);
            tabAuthor.Name = "tabAuthor";
            tabAuthor.Padding = new Padding(3);
            tabAuthor.Size = new Size(842, 407);
            tabAuthor.TabIndex = 1;
            tabAuthor.Text = "Author";
            // 
            // panel6
            // 
            panel6.Controls.Add(panel4);
            panel6.Controls.Add(dgvAuthor);
            panel6.Dock = DockStyle.Fill;
            panel6.Location = new Point(3, 3);
            panel6.Name = "panel6";
            panel6.Size = new Size(836, 401);
            panel6.TabIndex = 4;
            // 
            // panel4
            // 
            panel4.BackColor = Color.LightGray;
            panel4.Controls.Add(panel5);
            panel4.Controls.Add(btnNewAuthor);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(836, 62);
            panel4.TabIndex = 3;
            // 
            // panel5
            // 
            panel5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel5.Controls.Add(btnDeleteAuthor);
            panel5.Controls.Add(btnEditAuthor);
            panel5.Location = new Point(497, 10);
            panel5.Name = "panel5";
            panel5.Size = new Size(334, 45);
            panel5.TabIndex = 7;
            // 
            // btnDeleteAuthor
            // 
            btnDeleteAuthor.BackColor = Color.Salmon;
            btnDeleteAuthor.Enabled = false;
            btnDeleteAuthor.FlatAppearance.BorderSize = 0;
            btnDeleteAuthor.FlatStyle = FlatStyle.Flat;
            btnDeleteAuthor.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDeleteAuthor.ForeColor = SystemColors.ButtonFace;
            btnDeleteAuthor.Image = (Image)resources.GetObject("btnDeleteAuthor.Image");
            btnDeleteAuthor.ImageAlign = ContentAlignment.MiddleLeft;
            btnDeleteAuthor.Location = new Point(184, 4);
            btnDeleteAuthor.Margin = new Padding(4);
            btnDeleteAuthor.Name = "btnDeleteAuthor";
            btnDeleteAuthor.Size = new Size(146, 37);
            btnDeleteAuthor.TabIndex = 5;
            btnDeleteAuthor.Text = "Delete";
            btnDeleteAuthor.UseVisualStyleBackColor = false;
            btnDeleteAuthor.Click += btnDeleteAuthor_Click;
            // 
            // btnEditAuthor
            // 
            btnEditAuthor.BackColor = Color.SteelBlue;
            btnEditAuthor.Enabled = false;
            btnEditAuthor.FlatAppearance.BorderSize = 0;
            btnEditAuthor.FlatStyle = FlatStyle.Flat;
            btnEditAuthor.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            btnEditAuthor.ForeColor = SystemColors.ButtonFace;
            btnEditAuthor.Image = (Image)resources.GetObject("btnEditAuthor.Image");
            btnEditAuthor.ImageAlign = ContentAlignment.MiddleLeft;
            btnEditAuthor.Location = new Point(4, 4);
            btnEditAuthor.Margin = new Padding(4);
            btnEditAuthor.Name = "btnEditAuthor";
            btnEditAuthor.Size = new Size(146, 37);
            btnEditAuthor.TabIndex = 4;
            btnEditAuthor.Text = "Edit";
            btnEditAuthor.UseVisualStyleBackColor = false;
            btnEditAuthor.Click += btnEditAuthor_Click;
            // 
            // btnNewAuthor
            // 
            btnNewAuthor.BackColor = Color.SteelBlue;
            btnNewAuthor.FlatAppearance.BorderSize = 0;
            btnNewAuthor.FlatStyle = FlatStyle.Flat;
            btnNewAuthor.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            btnNewAuthor.ForeColor = SystemColors.ButtonFace;
            btnNewAuthor.Image = (Image)resources.GetObject("btnNewAuthor.Image");
            btnNewAuthor.ImageAlign = ContentAlignment.MiddleLeft;
            btnNewAuthor.Location = new Point(6, 14);
            btnNewAuthor.Margin = new Padding(4);
            btnNewAuthor.Name = "btnNewAuthor";
            btnNewAuthor.Size = new Size(146, 37);
            btnNewAuthor.TabIndex = 4;
            btnNewAuthor.Text = "New";
            btnNewAuthor.UseVisualStyleBackColor = false;
            btnNewAuthor.Click += btnNewAuthor_Click;
            // 
            // dgvAuthor
            // 
            dgvAuthor.AllowUserToAddRows = false;
            dgvAuthor.AllowUserToDeleteRows = false;
            dgvAuthor.AllowUserToResizeColumns = false;
            dgvAuthor.AllowUserToResizeRows = false;
            dgvAuthor.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvAuthor.BackgroundColor = Color.LightGray;
            dgvAuthor.BorderStyle = BorderStyle.None;
            dgvAuthor.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.SteelBlue;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = SystemColors.InactiveBorder;
            dataGridViewCellStyle4.SelectionBackColor = Color.SteelBlue;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvAuthor.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvAuthor.ColumnHeadersHeight = 40;
            dgvAuthor.Columns.AddRange(new DataGridViewColumn[] { authorName, authorContact, authorDescription });
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.Silver;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.ButtonShadow;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            dgvAuthor.DefaultCellStyle = dataGridViewCellStyle5;
            dgvAuthor.EnableHeadersVisualStyles = false;
            dgvAuthor.Location = new Point(5, 68);
            dgvAuthor.MultiSelect = false;
            dgvAuthor.Name = "dgvAuthor";
            dgvAuthor.ReadOnly = true;
            dgvAuthor.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.LightGray;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 12F);
            dataGridViewCellStyle6.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dgvAuthor.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dgvAuthor.RowHeadersVisible = false;
            dgvAuthor.RowHeadersWidth = 51;
            dgvAuthor.RowTemplate.Height = 35;
            dgvAuthor.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAuthor.Size = new Size(826, 318);
            dgvAuthor.TabIndex = 2;
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
            // tabPuslisher
            // 
            tabPuslisher.BackColor = Color.LightGray;
            tabPuslisher.Controls.Add(panel11);
            tabPuslisher.Controls.Add(panel9);
            tabPuslisher.Font = new Font("Segoe UI", 12F);
            tabPuslisher.Location = new Point(4, 40);
            tabPuslisher.Name = "tabPuslisher";
            tabPuslisher.Padding = new Padding(3);
            tabPuslisher.Size = new Size(842, 407);
            tabPuslisher.TabIndex = 2;
            tabPuslisher.Text = "Publisher";
            // 
            // panel11
            // 
            panel11.Controls.Add(dgvPublisher);
            panel11.Dock = DockStyle.Fill;
            panel11.Location = new Point(3, 65);
            panel11.Name = "panel11";
            panel11.Size = new Size(836, 339);
            panel11.TabIndex = 4;
            // 
            // dgvPublisher
            // 
            dgvPublisher.AllowUserToAddRows = false;
            dgvPublisher.AllowUserToDeleteRows = false;
            dgvPublisher.AllowUserToResizeColumns = false;
            dgvPublisher.AllowUserToResizeRows = false;
            dgvPublisher.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvPublisher.BackgroundColor = Color.LightGray;
            dgvPublisher.BorderStyle = BorderStyle.None;
            dgvPublisher.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = Color.SteelBlue;
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle7.ForeColor = SystemColors.InactiveBorder;
            dataGridViewCellStyle7.SelectionBackColor = Color.SteelBlue;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            dgvPublisher.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dgvPublisher.ColumnHeadersHeight = 40;
            dgvPublisher.Columns.AddRange(new DataGridViewColumn[] { publisherName, publisherContact, publisherDescription });
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = Color.Silver;
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle8.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = SystemColors.ButtonShadow;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.False;
            dgvPublisher.DefaultCellStyle = dataGridViewCellStyle8;
            dgvPublisher.EnableHeadersVisualStyles = false;
            dgvPublisher.Location = new Point(5, 10);
            dgvPublisher.Margin = new Padding(0);
            dgvPublisher.MultiSelect = false;
            dgvPublisher.Name = "dgvPublisher";
            dgvPublisher.ReadOnly = true;
            dgvPublisher.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = Color.LightGray;
            dataGridViewCellStyle9.Font = new Font("Segoe UI", 12F);
            dataGridViewCellStyle9.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.True;
            dgvPublisher.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            dgvPublisher.RowHeadersVisible = false;
            dgvPublisher.RowHeadersWidth = 51;
            dgvPublisher.RowTemplate.Height = 35;
            dgvPublisher.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPublisher.Size = new Size(826, 318);
            dgvPublisher.TabIndex = 2;
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
            panel9.Controls.Add(panel8);
            panel9.Dock = DockStyle.Top;
            panel9.Location = new Point(3, 3);
            panel9.Name = "panel9";
            panel9.Size = new Size(836, 62);
            panel9.TabIndex = 3;
            // 
            // panel8
            // 
            panel8.BackColor = Color.LightGray;
            panel8.Controls.Add(panel7);
            panel8.Controls.Add(btnNewPublisher);
            panel8.Dock = DockStyle.Top;
            panel8.Location = new Point(0, 0);
            panel8.Margin = new Padding(0);
            panel8.Name = "panel8";
            panel8.Size = new Size(836, 62);
            panel8.TabIndex = 3;
            // 
            // panel7
            // 
            panel7.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel7.Controls.Add(btnDeletePublisher);
            panel7.Controls.Add(btnEditPuslisher);
            panel7.Location = new Point(497, 10);
            panel7.Name = "panel7";
            panel7.Size = new Size(334, 45);
            panel7.TabIndex = 8;
            // 
            // btnDeletePublisher
            // 
            btnDeletePublisher.BackColor = Color.Salmon;
            btnDeletePublisher.Enabled = false;
            btnDeletePublisher.FlatAppearance.BorderSize = 0;
            btnDeletePublisher.FlatStyle = FlatStyle.Flat;
            btnDeletePublisher.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDeletePublisher.ForeColor = SystemColors.ButtonFace;
            btnDeletePublisher.Image = (Image)resources.GetObject("btnDeletePublisher.Image");
            btnDeletePublisher.ImageAlign = ContentAlignment.MiddleLeft;
            btnDeletePublisher.Location = new Point(184, 4);
            btnDeletePublisher.Margin = new Padding(4);
            btnDeletePublisher.Name = "btnDeletePublisher";
            btnDeletePublisher.Size = new Size(146, 37);
            btnDeletePublisher.TabIndex = 5;
            btnDeletePublisher.Text = "Delete";
            btnDeletePublisher.UseVisualStyleBackColor = false;
            btnDeletePublisher.Click += btnDeletePublisher_Click;
            // 
            // btnEditPuslisher
            // 
            btnEditPuslisher.BackColor = Color.SteelBlue;
            btnEditPuslisher.Enabled = false;
            btnEditPuslisher.FlatAppearance.BorderSize = 0;
            btnEditPuslisher.FlatStyle = FlatStyle.Flat;
            btnEditPuslisher.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            btnEditPuslisher.ForeColor = SystemColors.ButtonFace;
            btnEditPuslisher.Image = (Image)resources.GetObject("btnEditPuslisher.Image");
            btnEditPuslisher.ImageAlign = ContentAlignment.MiddleLeft;
            btnEditPuslisher.Location = new Point(4, 4);
            btnEditPuslisher.Margin = new Padding(4);
            btnEditPuslisher.Name = "btnEditPuslisher";
            btnEditPuslisher.Size = new Size(146, 37);
            btnEditPuslisher.TabIndex = 4;
            btnEditPuslisher.Text = "Edit";
            btnEditPuslisher.UseVisualStyleBackColor = false;
            btnEditPuslisher.Click += btnEditPuslisher_Click;
            // 
            // btnNewPublisher
            // 
            btnNewPublisher.BackColor = Color.SteelBlue;
            btnNewPublisher.FlatAppearance.BorderSize = 0;
            btnNewPublisher.FlatStyle = FlatStyle.Flat;
            btnNewPublisher.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            btnNewPublisher.ForeColor = SystemColors.ButtonFace;
            btnNewPublisher.Image = (Image)resources.GetObject("btnNewPublisher.Image");
            btnNewPublisher.ImageAlign = ContentAlignment.MiddleLeft;
            btnNewPublisher.Location = new Point(6, 14);
            btnNewPublisher.Margin = new Padding(4);
            btnNewPublisher.Name = "btnNewPublisher";
            btnNewPublisher.Size = new Size(146, 37);
            btnNewPublisher.TabIndex = 3;
            btnNewPublisher.Text = "New";
            btnNewPublisher.UseVisualStyleBackColor = false;
            btnNewPublisher.Click += btnNewPublisher_Click;
            // 
            // button8
            // 
            button8.Location = new Point(0, 0);
            button8.Name = "button8";
            button8.Size = new Size(75, 23);
            button8.TabIndex = 0;
            // 
            // button9
            // 
            button9.BackColor = Color.SteelBlue;
            button9.FlatAppearance.BorderSize = 0;
            button9.FlatStyle = FlatStyle.Flat;
            button9.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            button9.ForeColor = SystemColors.ButtonFace;
            button9.Image = (Image)resources.GetObject("button9.Image");
            button9.ImageAlign = ContentAlignment.MiddleLeft;
            button9.Location = new Point(4, 4);
            button9.Margin = new Padding(4);
            button9.Name = "button9";
            button9.Size = new Size(146, 37);
            button9.TabIndex = 4;
            button9.Text = "Edit";
            button9.UseVisualStyleBackColor = false;
            // 
            // AdminCategory
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(850, 451);
            Controls.Add(tabCategory);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AdminCategory";
            Text = "AdminCategory";
            FormClosed += AdminCategory_FormClosed;
            Load += AdminCategory_Load;
            tabCategory.ResumeLayout(false);
            tabGenre.ResumeLayout(false);
            tabGenre.PerformLayout();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvGenre).EndInit();
            tabAuthor.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvAuthor).EndInit();
            tabPuslisher.ResumeLayout(false);
            panel11.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvPublisher).EndInit();
            panel9.ResumeLayout(false);
            panel8.ResumeLayout(false);
            panel7.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TabControl tabCategory;
        private TabPage tabGenre;
        private TabPage tabAuthor;
        private Panel panel2;
        private DataGridView dgvGenre;
        private Panel panel3;
        private DataTable dtGenre;
       
        private DataTable dtAuthor;
        private DataTable dtPublisher;
        private Button btnNewGenre;
        private DataGridViewTextBoxColumn genreName;
        private DataGridViewTextBoxColumn genreDescription;
        private Panel panel1;
        private Button btnDeleteGenre;
        private Button btnEditGenre;
        private TabPage tabPuslisher;
        private Panel panel9;
        private Panel panel6;
        private DataGridView dgvAuthor;
        private Panel panel11;
        private DataGridView dgvPublisher;
        private Panel panel8;
        private Button button8;
        private Button button9;
        private Button btnNewPublisher;
        private DataGridViewTextBoxColumn authorName;
        private DataGridViewTextBoxColumn authorContact;
        private DataGridViewTextBoxColumn authorDescription;
        private Panel panel4;
        private Panel panel5;
        private Button btnDeleteAuthor;
        private Button btnEditAuthor;
        private Button btnNewAuthor;
        private Panel panel7;
        private Button btnDeletePublisher;
        private Button btnEditPuslisher;
        private BookGenre _genre;
        private Author _author;
        private Publisher _publisher;
        public event EventHandler GenreChanged;   
        public event EventHandler AuthorChanged;
        public event EventHandler PublisherChanged;
        private BookGenre bookGenreSelected
        {
            get { return _genre; }
            set
            {
                _genre = value;
                OnGenreChanged();
            }
        }
        private Author authorSelected
        {
            get { return _author; }
            set
            {
                _author = value;
                OnAuthorChanged();
            }
        }

        private Publisher publisherSelected
        {
            get { return _publisher; }
            set
            {
                _publisher = value;
                OnPublisherChanged();
            }
        }
        protected virtual void OnGenreChanged()
        {
            GenreChanged?.Invoke(this, EventArgs.Empty);
        }
        protected virtual void OnAuthorChanged()
        {
            AuthorChanged?.Invoke(this, EventArgs.Empty);
        }
        protected virtual void OnPublisherChanged()
        {
            PublisherChanged?.Invoke(this, EventArgs.Empty);
        }
        
        private Button button1;
        private DataGridViewTextBoxColumn publisherName;
        private DataGridViewTextBoxColumn publisherContact;
        private DataGridViewTextBoxColumn publisherDescription;
    }
}