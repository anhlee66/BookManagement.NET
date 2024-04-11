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
            groupBox1 = new GroupBox();
            button1 = new Button();
            button3 = new Button();
            comboBox3 = new ComboBox();
            label5 = new Label();
            button2 = new Button();
            groupBox3 = new GroupBox();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            label6 = new Label();
            label7 = new Label();
            groupBox2 = new GroupBox();
            label3 = new Label();
            label2 = new Label();
            label4 = new Label();
            comboBox2 = new ComboBox();
            comboBox1 = new ComboBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            bookname = new DataGridViewTextBoxColumn();
            bookgenre = new DataGridViewTextBoxColumn();
            quantity = new DataGridViewTextBoxColumn();
            price = new DataGridViewTextBoxColumn();
            groupBox1.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(comboBox3);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(groupBox3);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Dock = DockStyle.Left;
            groupBox1.Font = new Font("Segoe UI", 12F);
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.RightToLeft = RightToLeft.No;
            groupBox1.Size = new Size(593, 728);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F);
            button1.Location = new Point(238, 640);
            button1.Name = "button1";
            button1.RightToLeft = RightToLeft.No;
            button1.Size = new Size(110, 42);
            button1.TabIndex = 17;
            button1.Text = "Update";
            button1.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 12F);
            button3.Location = new Point(377, 640);
            button3.Name = "button3";
            button3.RightToLeft = RightToLeft.No;
            button3.Size = new Size(110, 42);
            button3.TabIndex = 21;
            button3.Text = "Help";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // comboBox3
            // 
            comboBox3.Font = new Font("Segoe UI", 12F);
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(202, 531);
            comboBox3.Name = "comboBox3";
            comboBox3.RightToLeft = RightToLeft.No;
            comboBox3.Size = new Size(346, 36);
            comboBox3.TabIndex = 20;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(58, 534);
            label5.Name = "label5";
            label5.RightToLeft = RightToLeft.No;
            label5.Size = new Size(104, 28);
            label5.TabIndex = 19;
            label5.Text = "Book state";
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 12F);
            button2.Location = new Point(101, 640);
            button2.Name = "button2";
            button2.RightToLeft = RightToLeft.No;
            button2.Size = new Size(110, 42);
            button2.TabIndex = 18;
            button2.Text = "Add";
            button2.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(textBox4);
            groupBox3.Controls.Add(textBox3);
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(label7);
            groupBox3.Font = new Font("Segoe UI", 12F);
            groupBox3.Location = new Point(23, 311);
            groupBox3.Name = "groupBox3";
            groupBox3.RightToLeft = RightToLeft.No;
            groupBox3.Size = new Size(543, 159);
            groupBox3.TabIndex = 15;
            groupBox3.TabStop = false;
            groupBox3.Text = "Price";
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Segoe UI", 12F);
            textBox4.Location = new Point(179, 93);
            textBox4.Name = "textBox4";
            textBox4.RightToLeft = RightToLeft.No;
            textBox4.Size = new Size(346, 34);
            textBox4.TabIndex = 10;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI", 12F);
            textBox3.Location = new Point(179, 42);
            textBox3.Name = "textBox3";
            textBox3.RightToLeft = RightToLeft.No;
            textBox3.Size = new Size(346, 34);
            textBox3.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(28, 49);
            label6.Name = "label6";
            label6.RightToLeft = RightToLeft.No;
            label6.Size = new Size(120, 28);
            label6.TabIndex = 7;
            label6.Text = "Import price";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F);
            label7.Location = new Point(28, 96);
            label7.Name = "label7";
            label7.RightToLeft = RightToLeft.No;
            label7.Size = new Size(54, 28);
            label7.TabIndex = 8;
            label7.Text = "Price";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(comboBox2);
            groupBox2.Controls.Add(comboBox1);
            groupBox2.Controls.Add(textBox2);
            groupBox2.Controls.Add(textBox1);
            groupBox2.Controls.Add(label1);
            groupBox2.Font = new Font("Segoe UI", 12F);
            groupBox2.Location = new Point(23, 50);
            groupBox2.Name = "groupBox2";
            groupBox2.RightToLeft = RightToLeft.No;
            groupBox2.Size = new Size(543, 255);
            groupBox2.TabIndex = 14;
            groupBox2.TabStop = false;
            groupBox2.Text = "Information";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(24, 88);
            label3.Name = "label3";
            label3.RightToLeft = RightToLeft.No;
            label3.Size = new Size(114, 28);
            label3.TabIndex = 17;
            label3.Text = "Book Genre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(30, 142);
            label2.Name = "label2";
            label2.RightToLeft = RightToLeft.No;
            label2.Size = new Size(81, 28);
            label2.TabIndex = 16;
            label2.Text = "Authors";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(28, 198);
            label4.Name = "label4";
            label4.RightToLeft = RightToLeft.No;
            label4.Size = new Size(81, 28);
            label4.TabIndex = 18;
            label4.Text = "Publiser";
            // 
            // comboBox2
            // 
            comboBox2.Font = new Font("Segoe UI", 12F);
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(179, 198);
            comboBox2.Name = "comboBox2";
            comboBox2.RightToLeft = RightToLeft.No;
            comboBox2.Size = new Size(346, 36);
            comboBox2.TabIndex = 17;
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Segoe UI", 12F);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(179, 142);
            comboBox1.Name = "comboBox1";
            comboBox1.RightToLeft = RightToLeft.No;
            comboBox1.Size = new Size(346, 36);
            comboBox1.TabIndex = 15;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 12F);
            textBox2.Location = new Point(179, 81);
            textBox2.Name = "textBox2";
            textBox2.RightToLeft = RightToLeft.No;
            textBox2.Size = new Size(346, 34);
            textBox2.TabIndex = 13;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 12F);
            textBox1.Location = new Point(179, 31);
            textBox1.Name = "textBox1";
            textBox1.RightToLeft = RightToLeft.No;
            textBox1.Size = new Size(346, 34);
            textBox1.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(28, 33);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.No;
            label1.Size = new Size(110, 28);
            label1.TabIndex = 10;
            label1.Text = "Book name";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { bookname, bookgenre, quantity, price });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(593, 0);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridView1.Size = new Size(388, 728);
            dataGridView1.TabIndex = 1;
            // 
            // bookname
            // 
            bookname.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            bookname.HeaderText = "Book name";
            bookname.MinimumWidth = 6;
            bookname.Name = "bookname";
            bookname.ReadOnly = true;
            // 
            // bookgenre
            // 
            bookgenre.HeaderText = "Book genre";
            bookgenre.MinimumWidth = 6;
            bookgenre.Name = "bookgenre";
            bookgenre.ReadOnly = true;
            bookgenre.Width = 125;
            // 
            // quantity
            // 
            quantity.HeaderText = "Quantity";
            quantity.MinimumWidth = 6;
            quantity.Name = "quantity";
            quantity.ReadOnly = true;
            quantity.Width = 125;
            // 
            // price
            // 
            price.HeaderText = "Price";
            price.MinimumWidth = 6;
            price.Name = "price";
            price.ReadOnly = true;
            price.Width = 125;
            // 
            // AdminStorage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(981, 728);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AdminStorage";
            Text = "AdminStorage";
            Load += AdminStorage_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private ComboBox comboBox1;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label1;
        private Label label7;
        private Label label6;
        private GroupBox groupBox3;
        private TextBox textBox4;
        private TextBox textBox3;
        private Label label3;
        private Label label2;
        private Label label4;
        private ComboBox comboBox2;
        private ComboBox comboBox3;
        private Label label5;
        private Button button2;
        private Button button1;
        private Button button3;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn bookname;
        private DataGridViewTextBoxColumn bookgenre;
        private DataGridViewTextBoxColumn quantity;
        private DataGridViewTextBoxColumn price;
    }
}