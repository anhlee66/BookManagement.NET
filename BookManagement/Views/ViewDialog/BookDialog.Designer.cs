namespace BookManagement.Views.ViewDialog
{
    partial class BookDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookDialog));
            groupBox1 = new GroupBox();
            button1 = new Button();
            ptbThumbnail = new PictureBox();
            btnSave = new Button();
            title = new Label();
            btnClear = new Button();
            btnCancel = new Button();
            groupBox3 = new GroupBox();
            txtQuantity = new NumericUpDown();
            numImport = new NumericUpDown();
            label6 = new Label();
            label7 = new Label();
            numPrice = new NumericUpDown();
            txtPrice = new Label();
            label5 = new Label();
            cbBookState = new ComboBox();
            groupBox2 = new GroupBox();
            cbPublisher = new ComboBox();
            cbAuthor = new ComboBox();
            cbGenre = new ComboBox();
            txtName = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label4 = new Label();
            label1 = new Label();
            iconClose = new PictureBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ptbThumbnail).BeginInit();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtQuantity).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numImport).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numPrice).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconClose).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(ptbThumbnail);
            groupBox1.Controls.Add(btnSave);
            groupBox1.Controls.Add(title);
            groupBox1.Controls.Add(btnClear);
            groupBox1.Controls.Add(btnCancel);
            groupBox1.Controls.Add(groupBox3);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Font = new Font("Segoe UI", 12F);
            groupBox1.Location = new Point(19, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.RightToLeft = RightToLeft.No;
            groupBox1.Size = new Size(681, 788);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Image = Properties.Resources.refesh__Custom_;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(451, 603);
            button1.Name = "button1";
            button1.Size = new Size(199, 40);
            button1.TabIndex = 24;
            button1.Text = "Load thumbnail";
            button1.UseVisualStyleBackColor = false;
            button1.Click += ptbThumbnail_Click;
            // 
            // ptbThumbnail
            // 
            ptbThumbnail.Image = (Image)resources.GetObject("ptbThumbnail.Image");
            ptbThumbnail.Location = new Point(451, 376);
            ptbThumbnail.Name = "ptbThumbnail";
            ptbThumbnail.Size = new Size(199, 267);
            ptbThumbnail.SizeMode = PictureBoxSizeMode.StretchImage;
            ptbThumbnail.TabIndex = 2;
            ptbThumbnail.TabStop = false;
            ptbThumbnail.Click += ptbThumbnail_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.SteelBlue;
            btnSave.Font = new Font("Segoe UI", 12F);
            btnSave.Location = new Point(120, 705);
            btnSave.Name = "btnSave";
            btnSave.RightToLeft = RightToLeft.No;
            btnSave.Size = new Size(110, 41);
            btnSave.TabIndex = 23;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // title
            // 
            title.AutoSize = true;
            title.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            title.Location = new Point(267, 30);
            title.Name = "title";
            title.Size = new Size(147, 38);
            title.TabIndex = 22;
            title.Text = "Add Book";
            // 
            // btnClear
            // 
            btnClear.BackColor = SystemColors.AppWorkspace;
            btnClear.Font = new Font("Segoe UI", 12F);
            btnClear.Location = new Point(287, 705);
            btnClear.Name = "btnClear";
            btnClear.RightToLeft = RightToLeft.No;
            btnClear.Size = new Size(110, 41);
            btnClear.TabIndex = 17;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnCancel
            // 
            btnCancel.Font = new Font("Segoe UI", 12F);
            btnCancel.Location = new Point(451, 705);
            btnCancel.Name = "btnCancel";
            btnCancel.RightToLeft = RightToLeft.No;
            btnCancel.Size = new Size(110, 41);
            btnCancel.TabIndex = 21;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(txtQuantity);
            groupBox3.Controls.Add(numImport);
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(numPrice);
            groupBox3.Controls.Add(txtPrice);
            groupBox3.Controls.Add(label5);
            groupBox3.Controls.Add(cbBookState);
            groupBox3.Font = new Font("Segoe UI", 12F);
            groupBox3.Location = new Point(28, 358);
            groupBox3.Name = "groupBox3";
            groupBox3.RightToLeft = RightToLeft.No;
            groupBox3.Size = new Size(408, 285);
            groupBox3.TabIndex = 15;
            groupBox3.TabStop = false;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(180, 28);
            txtQuantity.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(197, 34);
            txtQuantity.TabIndex = 27;
            txtQuantity.ValueChanged += txtQuantity_ValueChanged;
            // 
            // numImport
            // 
            numImport.Location = new Point(180, 95);
            numImport.Maximum = new decimal(new int[] { 500000, 0, 0, 0 });
            numImport.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numImport.Name = "numImport";
            numImport.Size = new Size(197, 34);
            numImport.TabIndex = 25;
            numImport.Value = new decimal(new int[] { 1000, 0, 0, 0 });
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(32, 97);
            label6.Name = "label6";
            label6.RightToLeft = RightToLeft.No;
            label6.Size = new Size(124, 28);
            label6.TabIndex = 22;
            label6.Text = "Import price:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F);
            label7.Location = new Point(32, 30);
            label7.Name = "label7";
            label7.RightToLeft = RightToLeft.No;
            label7.Size = new Size(92, 28);
            label7.TabIndex = 23;
            label7.Text = "Quantity:";
            // 
            // numPrice
            // 
            numPrice.Location = new Point(180, 157);
            numPrice.Maximum = new decimal(new int[] { 500000, 0, 0, 0 });
            numPrice.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numPrice.Name = "numPrice";
            numPrice.Size = new Size(197, 34);
            numPrice.TabIndex = 21;
            numPrice.Value = new decimal(new int[] { 1000, 0, 0, 0 });
            // 
            // txtPrice
            // 
            txtPrice.AutoSize = true;
            txtPrice.Font = new Font("Segoe UI", 12F);
            txtPrice.Location = new Point(32, 157);
            txtPrice.Name = "txtPrice";
            txtPrice.RightToLeft = RightToLeft.No;
            txtPrice.Size = new Size(123, 28);
            txtPrice.TabIndex = 8;
            txtPrice.Text = "Selling price:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(32, 227);
            label5.Name = "label5";
            label5.RightToLeft = RightToLeft.No;
            label5.Size = new Size(108, 28);
            label5.TabIndex = 19;
            label5.Text = "Book state:";
            // 
            // cbBookState
            // 
            cbBookState.DropDownStyle = ComboBoxStyle.DropDownList;
            cbBookState.Font = new Font("Segoe UI", 12F);
            cbBookState.FormattingEnabled = true;
            cbBookState.Items.AddRange(new object[] { "In stock", "Out of stock", "Upcoming" });
            cbBookState.Location = new Point(180, 227);
            cbBookState.Name = "cbBookState";
            cbBookState.RightToLeft = RightToLeft.No;
            cbBookState.Size = new Size(197, 36);
            cbBookState.TabIndex = 20;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(cbPublisher);
            groupBox2.Controls.Add(cbAuthor);
            groupBox2.Controls.Add(cbGenre);
            groupBox2.Controls.Add(txtName);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label1);
            groupBox2.Font = new Font("Segoe UI", 12F);
            groupBox2.Location = new Point(28, 86);
            groupBox2.Name = "groupBox2";
            groupBox2.RightToLeft = RightToLeft.No;
            groupBox2.Size = new Size(622, 255);
            groupBox2.TabIndex = 14;
            groupBox2.TabStop = false;
            // 
            // cbPublisher
            // 
            cbPublisher.DropDownStyle = ComboBoxStyle.DropDownList;
            cbPublisher.FormattingEnabled = true;
            cbPublisher.Location = new Point(178, 196);
            cbPublisher.Name = "cbPublisher";
            cbPublisher.Size = new Size(396, 36);
            cbPublisher.TabIndex = 22;
            // 
            // cbAuthor
            // 
            cbAuthor.DropDownStyle = ComboBoxStyle.DropDownList;
            cbAuthor.FormattingEnabled = true;
            cbAuthor.Location = new Point(178, 141);
            cbAuthor.Name = "cbAuthor";
            cbAuthor.Size = new Size(396, 36);
            cbAuthor.TabIndex = 21;
            // 
            // cbGenre
            // 
            cbGenre.DropDownStyle = ComboBoxStyle.DropDownList;
            cbGenre.FormattingEnabled = true;
            cbGenre.Location = new Point(178, 86);
            cbGenre.Name = "cbGenre";
            cbGenre.Size = new Size(396, 36);
            cbGenre.TabIndex = 20;
            // 
            // txtName
            // 
            txtName.Location = new Point(178, 33);
            txtName.Name = "txtName";
            txtName.Size = new Size(396, 34);
            txtName.TabIndex = 19;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(24, 88);
            label3.Name = "label3";
            label3.RightToLeft = RightToLeft.No;
            label3.Size = new Size(118, 28);
            label3.TabIndex = 17;
            label3.Text = "Book Genre:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(30, 142);
            label2.Name = "label2";
            label2.RightToLeft = RightToLeft.No;
            label2.Size = new Size(85, 28);
            label2.TabIndex = 16;
            label2.Text = "Authors:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(28, 198);
            label4.Name = "label4";
            label4.RightToLeft = RightToLeft.No;
            label4.Size = new Size(96, 28);
            label4.TabIndex = 18;
            label4.Text = "Publisher:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(28, 33);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.No;
            label1.Size = new Size(114, 28);
            label1.TabIndex = 10;
            label1.Text = "Book name:";
            // 
            // iconClose
            // 
            iconClose.Image = Properties.Resources.close__Custom_;
            iconClose.Location = new Point(682, 12);
            iconClose.Name = "iconClose";
            iconClose.Size = new Size(25, 25);
            iconClose.SizeMode = PictureBoxSizeMode.AutoSize;
            iconClose.TabIndex = 24;
            iconClose.TabStop = false;
            iconClose.Click += iconClose_Click;
            // 
            // BookDialog
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(731, 812);
            Controls.Add(iconClose);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "BookDialog";
            StartPosition = FormStartPosition.CenterParent;
            Text = "BookDialog";
            FormClosed += BookDialog_FormClosed;
            Load += BookDialog_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ptbThumbnail).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)txtQuantity).EndInit();
            ((System.ComponentModel.ISupportInitialize)numImport).EndInit();
            ((System.ComponentModel.ISupportInitialize)numPrice).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconClose).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnSave;
        private Label title;
        private Button btnClear;
        private Button btnCancel;
        private ComboBox cbBookState;
        private Label label5;
        private GroupBox groupBox3;
        private Label txtPrice;
        private GroupBox groupBox2;
        private Label label3;
        private Label label2;
        private Label label4;
        private Label label1;
        private ComboBox cbPublisher;
        private ComboBox cbAuthor;
        private ComboBox cbGenre;
        private TextBox txtName;
        private PictureBox ptbThumbnail;
        private PictureBox iconClose;
        private NumericUpDown numPrice;
        private NumericUpDown numImport;
        private Label label6;
        private Label label7;
        private Button button1;
        private NumericUpDown txtQuantity;
    }
}