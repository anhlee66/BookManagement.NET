namespace BookManagement.Views
{
    partial class AdminEmployee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminEmployee));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            panel1 = new Panel();
            groupBox1 = new GroupBox();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            button4 = new Button();
            label6 = new Label();
            label3 = new Label();
            button1 = new Button();
            label5 = new Label();
            label4 = new Label();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            employeename = new DataGridViewTextBoxColumn();
            yearofbirth = new DataGridViewTextBoxColumn();
            gener = new DataGridViewTextBoxColumn();
            position = new DataGridViewTextBoxColumn();
            state = new DataGridViewTextBoxColumn();
            panel2 = new Panel();
            panel3 = new Panel();
            label7 = new Label();
            comboBox4 = new ComboBox();
            label8 = new Label();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackgroundImageLayout = ImageLayout.None;
            panel1.Controls.Add(groupBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Font = new Font("Segoe UI", 12F);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(500, 665);
            panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Controls.Add(button4);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(32, 71);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(444, 535);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(225, 377);
            label12.Name = "label12";
            label12.Size = new Size(59, 28);
            label12.TabIndex = 38;
            label12.Text = "Work";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(225, 328);
            label11.Name = "label11";
            label11.Size = new Size(70, 28);
            label11.TabIndex = 37;
            label11.Text = "Admin";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(225, 281);
            label10.Name = "label10";
            label10.Size = new Size(177, 28);
            label10.TabIndex = 36;
            label10.Text = "Ninh Kieu, Can Tho";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(225, 231);
            label9.Name = "label9";
            label9.Size = new Size(56, 28);
            label9.TabIndex = 35;
            label9.Text = "2002";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(225, 184);
            label1.Name = "label1";
            label1.Size = new Size(118, 28);
            label1.TabIndex = 34;
            label1.Text = "Le Tuan Anh";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(146, 43);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(152, 114);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 33;
            pictureBox1.TabStop = false;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 12F);
            button4.Location = new Point(77, 451);
            button4.Name = "button4";
            button4.Size = new Size(108, 37);
            button4.TabIndex = 32;
            button4.Text = "New";
            button4.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label6.ForeColor = SystemColors.ActiveCaptionText;
            label6.Location = new Point(38, 377);
            label6.Name = "label6";
            label6.Size = new Size(66, 28);
            label6.TabIndex = 31;
            label6.Text = "State:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.FlatStyle = FlatStyle.Popup;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(38, 231);
            label3.Name = "label3";
            label3.Size = new Size(136, 28);
            label3.TabIndex = 30;
            label3.Text = "Year of birth:";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F);
            button1.Location = new Point(222, 451);
            button1.Name = "button1";
            button1.Size = new Size(108, 37);
            button1.TabIndex = 29;
            button1.Text = "Update";
            button1.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label5.ForeColor = SystemColors.ActiveCaptionText;
            label5.Location = new Point(38, 328);
            label5.Name = "label5";
            label5.Size = new Size(93, 28);
            label5.TabIndex = 28;
            label5.Text = "Position:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(38, 281);
            label4.Name = "label4";
            label4.Size = new Size(92, 28);
            label4.TabIndex = 27;
            label4.Text = "Address:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(38, 184);
            label2.Name = "label2";
            label2.Size = new Size(167, 28);
            label2.TabIndex = 26;
            label2.Text = "Employee name:";
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.Gray;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(0, 192, 192);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { employeename, yearofbirth, gener, position, state });
            dataGridView1.Location = new Point(500, 83);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(664, 582);
            dataGridView1.TabIndex = 1;
            // 
            // employeename
            // 
            employeename.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            employeename.HeaderText = "Employee name";
            employeename.MinimumWidth = 6;
            employeename.Name = "employeename";
            // 
            // yearofbirth
            // 
            yearofbirth.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            yearofbirth.HeaderText = "Year of birth";
            yearofbirth.MinimumWidth = 6;
            yearofbirth.Name = "yearofbirth";
            yearofbirth.Width = 119;
            // 
            // gener
            // 
            gener.HeaderText = "Gender";
            gener.MinimumWidth = 6;
            gener.Name = "gener";
            gener.Width = 86;
            // 
            // position
            // 
            position.HeaderText = "position";
            position.MinimumWidth = 6;
            position.Name = "position";
            position.Width = 92;
            // 
            // state
            // 
            state.HeaderText = "State";
            state.MinimumWidth = 6;
            state.Name = "state";
            state.Width = 72;
            // 
            // panel2
            // 
            panel2.Controls.Add(panel3);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(500, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(676, 77);
            panel2.TabIndex = 2;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Right;
            panel3.Controls.Add(label7);
            panel3.Controls.Add(comboBox4);
            panel3.Location = new Point(389, 18);
            panel3.Name = "panel3";
            panel3.Size = new Size(275, 41);
            panel3.TabIndex = 4;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(4, 6);
            label7.Name = "label7";
            label7.Size = new Size(86, 28);
            label7.TabIndex = 4;
            label7.Text = "Position:";
            // 
            // comboBox4
            // 
            comboBox4.FormattingEnabled = true;
            comboBox4.Location = new Point(109, 6);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(151, 28);
            comboBox4.TabIndex = 3;
            comboBox4.Text = "-- filter position --";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(3, 5);
            label8.Name = "label8";
            label8.Size = new Size(60, 28);
            label8.TabIndex = 5;
            label8.Text = "State:";
            // 
            // AdminEmployee
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            AutoSize = true;
            ClientSize = new Size(1176, 665);
            ControlBox = false;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AdminEmployee";
            Text = "AdminEmployee";
            TopMost = true;
            Load += AdminEmployee_Load;
            panel1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DataGridView dataGridView1;
        private Panel panel2;
        private Label label8;
        private Panel panel3;
        private Label label7;
        private ComboBox comboBox4;
        private DataGridViewTextBoxColumn employeename;
        private DataGridViewTextBoxColumn yearofbirth;
        private DataGridViewTextBoxColumn gener;
        private DataGridViewTextBoxColumn position;
        private DataGridViewTextBoxColumn state;
        private GroupBox groupBox1;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label1;
        private PictureBox pictureBox1;
        private Button button4;
        private Label label6;
        private Label label3;
        private Button button1;
        private Label label5;
        private Label label4;
        private Label label2;
    }
}