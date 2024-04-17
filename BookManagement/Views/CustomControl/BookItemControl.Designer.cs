namespace BookManagement.Views.CustomControl
{
    partial class BookItemControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ptbThumbnail = new PictureBox();
            panel1 = new Panel();
            itemInfoArea = new Panel();
            panel6 = new Panel();
            labQuantity = new Label();
            txtQuantity = new Label();
            panel5 = new Panel();
            label1 = new Label();
            txtItemAuthor = new Label();
            panel4 = new Panel();
            txtItemPrice = new Label();
            label4 = new Label();
            panel3 = new Panel();
            label3 = new Label();
            txtItemTitle = new Label();
            ((System.ComponentModel.ISupportInitialize)ptbThumbnail).BeginInit();
            panel1.SuspendLayout();
            itemInfoArea.SuspendLayout();
            panel6.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // ptbThumbnail
            // 
            ptbThumbnail.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ptbThumbnail.Image = Properties.Resources.defaultThumbnail;
            ptbThumbnail.Location = new Point(20, 17);
            ptbThumbnail.Name = "ptbThumbnail";
            ptbThumbnail.Size = new Size(104, 132);
            ptbThumbnail.SizeMode = PictureBoxSizeMode.StretchImage;
            ptbThumbnail.TabIndex = 0;
            ptbThumbnail.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightGray;
            panel1.Controls.Add(ptbThumbnail);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(142, 166);
            panel1.TabIndex = 2;
            // 
            // itemInfoArea
            // 
            itemInfoArea.AutoSize = true;
            itemInfoArea.BackColor = Color.Transparent;
            itemInfoArea.Controls.Add(panel6);
            itemInfoArea.Controls.Add(panel5);
            itemInfoArea.Controls.Add(panel4);
            itemInfoArea.Controls.Add(panel3);
            itemInfoArea.Controls.Add(label3);
            itemInfoArea.Controls.Add(txtItemTitle);
            itemInfoArea.Dock = DockStyle.Fill;
            itemInfoArea.Location = new Point(142, 0);
            itemInfoArea.Name = "itemInfoArea";
            itemInfoArea.Size = new Size(899, 166);
            itemInfoArea.TabIndex = 3;
            itemInfoArea.Paint += itemInfoArea_Paint;
            // 
            // panel6
            // 
            panel6.Anchor = AnchorStyles.None;
            panel6.Controls.Add(labQuantity);
            panel6.Controls.Add(txtQuantity);
            panel6.Location = new Point(479, 71);
            panel6.Name = "panel6";
            panel6.Size = new Size(169, 47);
            panel6.TabIndex = 15;
            // 
            // labQuantity
            // 
            labQuantity.AutoSize = true;
            labQuantity.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labQuantity.Location = new Point(9, 9);
            labQuantity.Name = "labQuantity";
            labQuantity.Size = new Size(100, 28);
            labQuantity.TabIndex = 12;
            labQuantity.Text = "Quantity:";
            // 
            // txtQuantity
            // 
            txtQuantity.AutoSize = true;
            txtQuantity.Font = new Font("Segoe UI", 12F);
            txtQuantity.Location = new Point(109, 9);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(34, 28);
            txtQuantity.TabIndex = 11;
            txtQuantity.Text = "20";
            // 
            // panel5
            // 
            panel5.Anchor = AnchorStyles.Left;
            panel5.Controls.Add(label1);
            panel5.Controls.Add(txtItemAuthor);
            panel5.Location = new Point(32, 71);
            panel5.Name = "panel5";
            panel5.Size = new Size(419, 47);
            panel5.TabIndex = 14;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(9, 9);
            label1.Name = "label1";
            label1.Size = new Size(92, 28);
            label1.TabIndex = 12;
            label1.Text = "Authors:";
            // 
            // txtItemAuthor
            // 
            txtItemAuthor.AutoSize = true;
            txtItemAuthor.Font = new Font("Segoe UI", 12F);
            txtItemAuthor.Location = new Point(109, 9);
            txtItemAuthor.Name = "txtItemAuthor";
            txtItemAuthor.Size = new Size(133, 28);
            txtItemAuthor.TabIndex = 11;
            txtItemAuthor.Text = "Dale Carnegie";
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Right;
            panel4.Controls.Add(txtItemPrice);
            panel4.Controls.Add(label4);
            panel4.Location = new Point(673, 71);
            panel4.Name = "panel4";
            panel4.Size = new Size(188, 47);
            panel4.TabIndex = 13;
            // 
            // txtItemPrice
            // 
            txtItemPrice.AutoSize = true;
            txtItemPrice.Font = new Font("Segoe UI", 12F);
            txtItemPrice.Location = new Point(82, 10);
            txtItemPrice.Name = "txtItemPrice";
            txtItemPrice.Size = new Size(99, 28);
            txtItemPrice.TabIndex = 11;
            txtItemPrice.Text = "100.000 d";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(3, 10);
            label4.Name = "label4";
            label4.Size = new Size(64, 28);
            label4.TabIndex = 10;
            label4.Text = "Price:";
            // 
            // panel3
            // 
            panel3.BackColor = Color.LightGray;
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 161);
            panel3.Name = "panel3";
            panel3.Size = new Size(899, 5);
            panel3.TabIndex = 12;
            // 
            // label3
            // 
            label3.Location = new Point(0, 0);
            label3.Name = "label3";
            label3.Size = new Size(100, 23);
            label3.TabIndex = 11;
            // 
            // txtItemTitle
            // 
            txtItemTitle.AutoSize = true;
            txtItemTitle.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtItemTitle.Location = new Point(32, 23);
            txtItemTitle.MaximumSize = new Size(450, 0);
            txtItemTitle.Name = "txtItemTitle";
            txtItemTitle.Size = new Size(319, 31);
            txtItemTitle.TabIndex = 5;
            txtItemTitle.Text = "Dac nhan tam tinh nhu nuoc";
            // 
            // BookItemControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.White;
            Controls.Add(itemInfoArea);
            Controls.Add(panel1);
            MinimumSize = new Size(737, 154);
            Name = "BookItemControl";
            Size = new Size(1041, 166);
            Click += BookItemControl_Click;
            ((System.ComponentModel.ISupportInitialize)ptbThumbnail).EndInit();
            panel1.ResumeLayout(false);
            itemInfoArea.ResumeLayout(false);
            itemInfoArea.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox ptbThumbnail;
        private Panel panel1;
        private Panel itemInfoArea;
        private Label label3;
        private Label txtItemTitle;
        private Panel panel3;
        private Panel panel4;
        private Label txtItemPrice;
        private Label label4;
        private Panel panel6;
        private Label labQuantity;
        private Label txtQuantity;
        private Panel panel5;
        private Label label1;
        private Label txtItemAuthor;
    }
}
