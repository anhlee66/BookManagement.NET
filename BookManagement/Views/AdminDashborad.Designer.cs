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
            panel4 = new Panel();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbThumbnail).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // cbSort
            // 
            cbSort.DropDownStyle = ComboBoxStyle.DropDownList;
            cbSort.FormattingEnabled = true;
            cbSort.Location = new Point(29, 8);
            cbSort.Name = "cbSort";
            cbSort.Size = new Size(165, 36);
            cbSort.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Right;
            panel3.Controls.Add(label2);
            panel3.Controls.Add(pbThumbnail);
            panel3.Location = new Point(596, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(202, 54);
            panel3.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(53, 5);
            label2.Name = "label2";
            label2.Size = new Size(88, 28);
            label2.TabIndex = 1;
            label2.Text = "Anh Lee";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pbThumbnail
            // 
            pbThumbnail.Image = Properties.Resources.user__Custom_;
            pbThumbnail.Location = new Point(3, 7);
            pbThumbnail.Name = "pbThumbnail";
            pbThumbnail.Size = new Size(44, 44);
            pbThumbnail.SizeMode = PictureBoxSizeMode.StretchImage;
            pbThumbnail.TabIndex = 0;
            pbThumbnail.TabStop = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(splitContainer1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(801, 446);
            panel2.TabIndex = 2;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
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
            splitContainer1.Panel2.Controls.Add(panel4);
            splitContainer1.Panel2.Paint += splitContainer1_Panel2_Paint;
            splitContainer1.Size = new Size(801, 446);
            splitContainer1.SplitterDistance = 55;
            splitContainer1.TabIndex = 0;
            splitContainer1.SplitterMoved += splitContainer1_SplitterMoved;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Left;
            panel1.Controls.Add(cbSort);
            panel1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel1.Location = new Point(12, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(242, 50);
            panel1.TabIndex = 5;
            // 
            // panel4
            // 
            panel4.Location = new Point(12, 17);
            panel4.Name = "panel4";
            panel4.Size = new Size(777, 171);
            panel4.TabIndex = 0;
            // 
            // AdminDashborad
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(801, 446);
            ControlBox = false;
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
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
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            panel1.ResumeLayout(false);
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
        private Panel panel4;
    }
}