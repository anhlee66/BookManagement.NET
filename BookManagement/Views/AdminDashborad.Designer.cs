using System.Windows.Forms;

namespace BookManagement.Views
{
    partial class AdminDashborad
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
            cbSort = new ComboBox();
            panel3 = new Panel();
            label2 = new Label();
            pbThumbnail = new PictureBox();
            panel2 = new Panel();
            splitContainer1 = new SplitContainer();
            panel1 = new Panel();
            headerLabel7 = new ReaLTaiizor.Controls.HeaderLabel();
            pictureBox5 = new PictureBox();
            headerLabel6 = new ReaLTaiizor.Controls.HeaderLabel();
            headerLabel5 = new ReaLTaiizor.Controls.HeaderLabel();
            headerLabel4 = new ReaLTaiizor.Controls.HeaderLabel();
            headerLabel3 = new ReaLTaiizor.Controls.HeaderLabel();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            headerLabel2 = new ReaLTaiizor.Controls.HeaderLabel();
            pictureBox1 = new PictureBox();
            headerLabel1 = new ReaLTaiizor.Controls.HeaderLabel();
            bigLabel1 = new ReaLTaiizor.Controls.BigLabel();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbThumbnail).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // cbSort
            // 
            int currentYear = GetCurrentYear(); // Lấy năm hiện tại
            int currentMonth = GetCurrentMonth(); // Lấy tháng hiện tại
            int currentQuarter = GetCurrentQuarter(); // Lấy quý hiện tại
            int currentWeek = GetCurrentWeek(); // Lấy tuần hiện tại
            cbSort.DropDownStyle = ComboBoxStyle.DropDownList;
            cbSort.FormattingEnabled = true;
            cbSort.Location = new Point(35, 10);
            cbSort.Margin = new Padding(4);
            cbSort.Name = "cbSort";
            cbSort.Size = new Size(197, 40);
            cbSort.TabIndex = 0;
            cbSort.SelectedIndexChanged += cbSort_SelectedIndexChanged;
            cbSort.Items.Add("Year " + currentYear);
            cbSort.Items.Add("Month " + currentYear + " - " + currentMonth);
            cbSort.Items.Add("Quarter " + currentYear + " - " + currentQuarter);
            cbSort.Items.Add("Week " + currentYear + " - " + currentWeek);
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Right;
            panel3.Controls.Add(label2);
            panel3.Controls.Add(pbThumbnail);
            panel3.Location = new Point(715, 3);
            panel3.Margin = new Padding(4);
            panel3.Name = "panel3";
            panel3.Size = new Size(242, 65);
            panel3.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(64, 6);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(105, 32);
            label2.TabIndex = 1;
            label2.Text = "Anh Lee";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pbThumbnail
            // 
            pbThumbnail.Image = Properties.Resources.user__Custom_;
            pbThumbnail.Location = new Point(4, 8);
            pbThumbnail.Margin = new Padding(4);
            pbThumbnail.Name = "pbThumbnail";
            pbThumbnail.Size = new Size(53, 53);
            pbThumbnail.SizeMode = PictureBoxSizeMode.StretchImage;
            pbThumbnail.TabIndex = 0;
            pbThumbnail.TabStop = false;
            pbThumbnail.Click += pbThumbnail_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(splitContainer1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(4);
            panel2.Name = "panel2";
            panel2.Size = new Size(961, 535);
            panel2.TabIndex = 2;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Margin = new Padding(4);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.BackColor = Color.Silver;
            splitContainer1.Panel1.Controls.Add(panel1);
            splitContainer1.Panel1.Controls.Add(panel3);
            splitContainer1.Panel1.Paint += splitContainer1_Panel1_Paint;
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.BackColor = Color.Gainsboro;
            splitContainer1.Panel2.Controls.Add(headerLabel7);
            splitContainer1.Panel2.Controls.Add(pictureBox5);
            splitContainer1.Panel2.Controls.Add(headerLabel6);
            splitContainer1.Panel2.Controls.Add(headerLabel5);
            splitContainer1.Panel2.Controls.Add(headerLabel4);
            splitContainer1.Panel2.Controls.Add(headerLabel3);
            splitContainer1.Panel2.Controls.Add(pictureBox4);
            splitContainer1.Panel2.Controls.Add(pictureBox3);
            splitContainer1.Panel2.Controls.Add(pictureBox2);
            splitContainer1.Panel2.Controls.Add(headerLabel2);
            splitContainer1.Panel2.Controls.Add(pictureBox1);
            splitContainer1.Panel2.Controls.Add(headerLabel1);
            splitContainer1.Panel2.Controls.Add(bigLabel1);
            splitContainer1.Panel2.Paint += splitContainer1_Panel2_Paint;
            splitContainer1.Size = new Size(961, 535);
            splitContainer1.SplitterDistance = 65;
            splitContainer1.SplitterWidth = 5;
            splitContainer1.TabIndex = 0;
            splitContainer1.SplitterMoved += splitContainer1_SplitterMoved;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Left;
            panel1.Controls.Add(cbSort);
            panel1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel1.Location = new Point(14, 4);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(290, 60);
            panel1.TabIndex = 5;
            panel1.Paint += panel1_Paint;
            // 
            // headerLabel7
            // 
            headerLabel7.AutoSize = true;
            headerLabel7.BackColor = Color.Transparent;
            headerLabel7.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold);
            headerLabel7.ForeColor = Color.FromArgb(80, 80, 80);
            headerLabel7.Location = new Point(746, 319);
            headerLabel7.Name = "headerLabel7";
            headerLabel7.Size = new Size(96, 26);
            headerLabel7.TabIndex = 13;
            headerLabel7.Text = "Ai Đây?";
            headerLabel7.Click += headerLabel7_Click;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.user__Custom_;
            pictureBox5.Location = new Point(849, 229);
            pictureBox5.Margin = new Padding(4);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(53, 53);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 12;
            pictureBox5.TabStop = false;
            // 
            // headerLabel6
            // 
            headerLabel6.AutoSize = true;
            headerLabel6.BackColor = Color.Transparent;
            headerLabel6.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold);
            headerLabel6.ForeColor = Color.FromArgb(80, 80, 80);
            headerLabel6.Location = new Point(613, 256);
            headerLabel6.Name = "headerLabel6";
            headerLabel6.Size = new Size(229, 26);
            headerLabel6.TabIndex = 11;
            headerLabel6.Text = "Nhân Viên Sáng Giá";
            // 
            // headerLabel5
            // 
            headerLabel5.AutoSize = true;
            headerLabel5.BackColor = Color.Transparent;
            headerLabel5.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold);
            headerLabel5.ForeColor = Color.FromArgb(80, 80, 80);
            headerLabel5.Location = new Point(17, 386);
            headerLabel5.Name = "headerLabel5";
            headerLabel5.Size = new Size(71, 26);
            headerLabel5.TabIndex = 10;
            headerLabel5.Text = "Top 3";
            headerLabel5.Click += headerLabel5_Click;
            // 
            // headerLabel4
            // 
            headerLabel4.AutoSize = true;
            headerLabel4.BackColor = Color.Transparent;
            headerLabel4.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold);
            headerLabel4.ForeColor = Color.FromArgb(80, 80, 80);
            headerLabel4.Location = new Point(17, 270);
            headerLabel4.Name = "headerLabel4";
            headerLabel4.Size = new Size(71, 26);
            headerLabel4.TabIndex = 9;
            headerLabel4.Text = "Top 2";
            // 
            // headerLabel3
            // 
            headerLabel3.AutoSize = true;
            headerLabel3.BackColor = Color.Transparent;
            headerLabel3.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold);
            headerLabel3.ForeColor = Color.FromArgb(80, 80, 80);
            headerLabel3.Location = new Point(17, 155);
            headerLabel3.Name = "headerLabel3";
            headerLabel3.Size = new Size(71, 26);
            headerLabel3.TabIndex = 8;
            headerLabel3.Text = "Top 1";
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.top1;
            pictureBox4.Location = new Point(66, 89);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(51, 49);
            pictureBox4.TabIndex = 7;
            pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.top3;
            pictureBox3.Location = new Point(66, 319);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(51, 49);
            pictureBox3.TabIndex = 6;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.top2;
            pictureBox2.Location = new Point(66, 204);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(53, 48);
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // headerLabel2
            // 
            headerLabel2.AutoSize = true;
            headerLabel2.BackColor = Color.Transparent;
            headerLabel2.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold);
            headerLabel2.ForeColor = Color.FromArgb(80, 80, 80);
            headerLabel2.Location = new Point(25, 50);
            headerLabel2.Name = "headerLabel2";
            headerLabel2.Size = new Size(141, 26);
            headerLabel2.TabIndex = 4;
            headerLabel2.Text = "Best Sellers";
            headerLabel2.Click += headerLabel2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.coins;
            pictureBox1.Location = new Point(851, 24);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(51, 52);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // headerLabel1
            // 
            headerLabel1.AutoSize = true;
            headerLabel1.BackColor = Color.Transparent;
            headerLabel1.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold);
            headerLabel1.ForeColor = Color.FromArgb(80, 80, 80);
            headerLabel1.Location = new Point(659, 50);
            headerLabel1.Name = "headerLabel1";
            headerLabel1.Size = new Size(186, 26);
            headerLabel1.TabIndex = 2;
            headerLabel1.Text = "Tổng Doanh Thu";
            headerLabel1.Click += headerLabel1_Click;
            // 
            // bigLabel1
            // 
            bigLabel1.AutoSize = true;
            bigLabel1.BackColor = Color.Transparent;
            bigLabel1.Font = new Font("Segoe UI", 25F);
            bigLabel1.ForeColor = Color.FromArgb(80, 80, 80);
            bigLabel1.Location = new Point(613, 88);
            bigLabel1.Name = "bigLabel1";
            bigLabel1.Size = new Size(326, 67);
            bigLabel1.TabIndex = 1;
            bigLabel1.Text = "00000000000";
            bigLabel1.Click += bigLabel1_Click;
            // 
            // AdminDashborad
            // 
            AutoScaleDimensions = new SizeF(144F, 144F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(961, 535);
            ControlBox = false;
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "AdminDashborad";
            Text = "AdminDashborad";
            WindowState = FormWindowState.Maximized;
            Load += dashboard_Load;
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbThumbnail).EndInit();
            panel2.ResumeLayout(false);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ComboBox cbSort;
        private Panel panel2;
        private Panel panel3;
        private PictureBox pbThumbnail;
        private Label label2;
        private SplitContainer splitContainer1;
        private Panel panel1;
        private ReaLTaiizor.Controls.BigLabel bigLabel1;
        private ReaLTaiizor.Controls.HeaderLabel headerLabel1;
        private PictureBox pictureBox1;
        private ReaLTaiizor.Controls.HeaderLabel headerLabel2;
        private ReaLTaiizor.Controls.HeaderLabel headerLabel5;
        private ReaLTaiizor.Controls.HeaderLabel headerLabel4;
        private ReaLTaiizor.Controls.HeaderLabel headerLabel3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private ReaLTaiizor.Controls.HeaderLabel headerLabel6;
        private PictureBox pictureBox5;
        private ReaLTaiizor.Controls.HeaderLabel headerLabel7;
    }
}