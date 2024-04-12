namespace BookManagement.Views.CustomControl
{
    partial class BookControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookControl));
            pictureBox1 = new PictureBox();
            txtSummaryDetail = new Label();
            groupBox1 = new GroupBox();
            txtPublisherDetail = new Label();
            txtPriceDetail = new Label();
            txtQuantityDetail = new Label();
            txtAuthorDetail = new Label();
            txtBookGenreDetail = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            txtBookTitleDetail = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(17, 20);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(197, 285);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // txtSummaryDetail
            // 
            txtSummaryDetail.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtSummaryDetail.BorderStyle = BorderStyle.FixedSingle;
            txtSummaryDetail.Location = new Point(17, 343);
            txtSummaryDetail.Name = "txtSummaryDetail";
            txtSummaryDetail.Size = new Size(552, 132);
            txtSummaryDetail.TabIndex = 8;
            txtSummaryDetail.Text = "Day la summary";
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            groupBox1.Controls.Add(txtPublisherDetail);
            groupBox1.Controls.Add(txtPriceDetail);
            groupBox1.Controls.Add(txtQuantityDetail);
            groupBox1.Controls.Add(txtAuthorDetail);
            groupBox1.Controls.Add(txtBookGenreDetail);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtBookTitleDetail);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(220, 20);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(360, 307);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // txtPublisherDetail
            // 
            txtPublisherDetail.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtPublisherDetail.AutoSize = true;
            txtPublisherDetail.Font = new Font("Segoe UI", 12F);
            txtPublisherDetail.Location = new Point(124, 266);
            txtPublisherDetail.MaximumSize = new Size(250, 0);
            txtPublisherDetail.Name = "txtPublisherDetail";
            txtPublisherDetail.Size = new Size(115, 28);
            txtPublisherDetail.TabIndex = 24;
            txtPublisherDetail.Text = "NSB Ha Noi";
            // 
            // txtPriceDetail
            // 
            txtPriceDetail.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtPriceDetail.AutoSize = true;
            txtPriceDetail.Font = new Font("Segoe UI", 12F);
            txtPriceDetail.Location = new Point(124, 217);
            txtPriceDetail.MaximumSize = new Size(250, 0);
            txtPriceDetail.Name = "txtPriceDetail";
            txtPriceDetail.Size = new Size(99, 28);
            txtPriceDetail.TabIndex = 23;
            txtPriceDetail.Text = "100.000 d";
            // 
            // txtQuantityDetail
            // 
            txtQuantityDetail.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtQuantityDetail.AutoSize = true;
            txtQuantityDetail.Font = new Font("Segoe UI", 12F);
            txtQuantityDetail.Location = new Point(124, 169);
            txtQuantityDetail.MaximumSize = new Size(250, 0);
            txtQuantityDetail.Name = "txtQuantityDetail";
            txtQuantityDetail.Size = new Size(34, 28);
            txtQuantityDetail.TabIndex = 22;
            txtQuantityDetail.Text = "10";
            // 
            // txtAuthorDetail
            // 
            txtAuthorDetail.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtAuthorDetail.AutoSize = true;
            txtAuthorDetail.Font = new Font("Segoe UI", 12F);
            txtAuthorDetail.Location = new Point(124, 117);
            txtAuthorDetail.MaximumSize = new Size(250, 0);
            txtAuthorDetail.Name = "txtAuthorDetail";
            txtAuthorDetail.Size = new Size(133, 28);
            txtAuthorDetail.TabIndex = 21;
            txtAuthorDetail.Text = "Dale Carnegie";
            // 
            // txtBookGenreDetail
            // 
            txtBookGenreDetail.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtBookGenreDetail.AutoSize = true;
            txtBookGenreDetail.Font = new Font("Segoe UI", 12F);
            txtBookGenreDetail.Location = new Point(124, 64);
            txtBookGenreDetail.MaximumSize = new Size(250, 0);
            txtBookGenreDetail.Name = "txtBookGenreDetail";
            txtBookGenreDetail.Size = new Size(123, 28);
            txtBookGenreDetail.TabIndex = 20;
            txtBookGenreDetail.Text = "genres name";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label6.Location = new Point(12, 266);
            label6.Name = "label6";
            label6.Size = new Size(106, 28);
            label6.TabIndex = 19;
            label6.Text = "Publisher:";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label5.Location = new Point(8, 117);
            label5.Name = "label5";
            label5.Size = new Size(92, 28);
            label5.TabIndex = 18;
            label5.Text = "Authors:";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label4.Location = new Point(8, 217);
            label4.Name = "label4";
            label4.Size = new Size(64, 28);
            label4.TabIndex = 17;
            label4.Text = "Price:";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.Location = new Point(8, 169);
            label3.Name = "label3";
            label3.Size = new Size(100, 28);
            label3.TabIndex = 16;
            label3.Text = "Quantity:";
            // 
            // txtBookTitleDetail
            // 
            txtBookTitleDetail.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtBookTitleDetail.AutoSize = true;
            txtBookTitleDetail.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtBookTitleDetail.Location = new Point(8, -10);
            txtBookTitleDetail.MaximumSize = new Size(400, 0);
            txtBookTitleDetail.Name = "txtBookTitleDetail";
            txtBookTitleDetail.Size = new Size(345, 62);
            txtBookTitleDetail.TabIndex = 15;
            txtBookTitleDetail.Text = "How to Win Friends & Influence People";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.Location = new Point(8, 64);
            label1.Name = "label1";
            label1.Size = new Size(82, 28);
            label1.TabIndex = 14;
            label1.Text = "Genres:";
            // 
            // BookControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            Controls.Add(groupBox1);
            Controls.Add(txtSummaryDetail);
            Controls.Add(pictureBox1);
            Name = "BookControl";
            Size = new Size(593, 506);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Label txtSummaryDetail;
        private GroupBox groupBox1;
        private Label txtPublisherDetail;
        private Label txtPriceDetail;
        private Label txtQuantityDetail;
        private Label txtAuthorDetail;
        private Label txtBookGenreDetail;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label txtBookTitleDetail;
        private Label label1;
    }
}
