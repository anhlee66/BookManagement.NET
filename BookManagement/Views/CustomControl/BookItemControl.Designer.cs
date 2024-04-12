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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookItemControl));
            pictureBox1 = new PictureBox();
            groupBox1 = new GroupBox();
            txtItemPrice = new Label();
            label4 = new Label();
            label3 = new Label();
            txtItemAuthor = new Label();
            txtItemTitle = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(13, 15);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(102, 132);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtItemPrice);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtItemAuthor);
            groupBox1.Controls.Add(txtItemTitle);
            groupBox1.Location = new Point(144, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(533, 137);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            // 
            // txtItemPrice
            // 
            txtItemPrice.AutoSize = true;
            txtItemPrice.Font = new Font("Segoe UI", 12F);
            txtItemPrice.Location = new Point(356, 106);
            txtItemPrice.Name = "txtItemPrice";
            txtItemPrice.Size = new Size(99, 28);
            txtItemPrice.TabIndex = 4;
            txtItemPrice.Text = "100.000 d";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(268, 106);
            label4.Name = "label4";
            label4.Size = new Size(58, 28);
            label4.TabIndex = 3;
            label4.Text = "Price:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(12, 106);
            label3.Name = "label3";
            label3.Size = new Size(85, 28);
            label3.TabIndex = 2;
            label3.Text = "Authors:";
            // 
            // txtItemAuthor
            // 
            txtItemAuthor.AutoSize = true;
            txtItemAuthor.Font = new Font("Segoe UI", 12F);
            txtItemAuthor.Location = new Point(103, 106);
            txtItemAuthor.Name = "txtItemAuthor";
            txtItemAuthor.Size = new Size(133, 28);
            txtItemAuthor.TabIndex = 1;
            txtItemAuthor.Text = "Dale Carnegie";
            // 
            // txtItemTitle
            // 
            txtItemTitle.AutoSize = true;
            txtItemTitle.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtItemTitle.Location = new Point(6, 12);
            txtItemTitle.MaximumSize = new Size(450, 0);
            txtItemTitle.Name = "txtItemTitle";
            txtItemTitle.Size = new Size(79, 31);
            txtItemTitle.TabIndex = 0;
            txtItemTitle.Text = "label1";
            // 
            // BookItemControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.FromArgb(224, 224, 224);
            BorderStyle = BorderStyle.Fixed3D;
            Controls.Add(groupBox1);
            Controls.Add(pictureBox1);
            Name = "BookItemControl";
            Size = new Size(680, 154);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private GroupBox groupBox1;
        private Label txtItemPrice;
        private Label label4;
        private Label label3;
        private Label txtItemAuthor;
        private Label txtItemTitle;
    }
}
