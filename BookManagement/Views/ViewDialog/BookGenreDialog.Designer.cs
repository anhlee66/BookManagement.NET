namespace BookManagement.Views.ViewDialog
{
    partial class BookGenreDialog
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
            groupBox2 = new GroupBox();
            groupBox4 = new GroupBox();
            txtGenreId = new TextBox();
            label4 = new Label();
            groupBox3 = new GroupBox();
            txtGenreDescription = new TextBox();
            label1 = new Label();
            groupBox1 = new GroupBox();
            txtGenreName = new TextBox();
            label3 = new Label();
            btnCancel = new Button();
            btnSave = new Button();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            groupBox2.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.AutoSize = true;
            groupBox2.Controls.Add(groupBox4);
            groupBox2.Controls.Add(groupBox3);
            groupBox2.Controls.Add(groupBox1);
            groupBox2.Controls.Add(btnCancel);
            groupBox2.Controls.Add(btnSave);
            groupBox2.Controls.Add(label2);
            groupBox2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(23, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(520, 433);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(txtGenreId);
            groupBox4.Controls.Add(label4);
            groupBox4.Location = new Point(21, 73);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(479, 73);
            groupBox4.TabIndex = 16;
            groupBox4.TabStop = false;
            // 
            // txtGenreId
            // 
            txtGenreId.Location = new Point(147, 27);
            txtGenreId.Name = "txtGenreId";
            txtGenreId.ReadOnly = true;
            txtGenreId.Size = new Size(326, 34);
            txtGenreId.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label4.Location = new Point(6, 23);
            label4.Name = "label4";
            label4.Size = new Size(38, 28);
            label4.TabIndex = 5;
            label4.Text = "ID:";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(txtGenreDescription);
            groupBox3.Controls.Add(label1);
            groupBox3.Location = new Point(21, 240);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(479, 73);
            groupBox3.TabIndex = 15;
            groupBox3.TabStop = false;
            // 
            // txtGenreDescription
            // 
            txtGenreDescription.Location = new Point(147, 27);
            txtGenreDescription.Name = "txtGenreDescription";
            txtGenreDescription.Size = new Size(326, 34);
            txtGenreDescription.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.Location = new Point(6, 23);
            label1.Name = "label1";
            label1.Size = new Size(126, 28);
            label1.TabIndex = 5;
            label1.Text = "Description:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtGenreName);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(21, 152);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(479, 73);
            groupBox1.TabIndex = 14;
            groupBox1.TabStop = false;
            // 
            // txtGenreName
            // 
            txtGenreName.Location = new Point(147, 27);
            txtGenreName.Name = "txtGenreName";
            txtGenreName.Size = new Size(326, 34);
            txtGenreName.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.Location = new Point(6, 23);
            label3.Name = "label3";
            label3.Size = new Size(135, 28);
            label3.TabIndex = 5;
            label3.Text = "Genre Name:";
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.LightGray;
            btnCancel.Location = new Point(287, 361);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(102, 39);
            btnCancel.TabIndex = 13;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = SystemColors.ActiveCaption;
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.Location = new Point(131, 361);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(102, 39);
            btnSave.TabIndex = 11;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(175, 23);
            label2.Name = "label2";
            label2.Size = new Size(171, 38);
            label2.TabIndex = 4;
            label2.Text = "Book Genre";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.close__Custom_;
            pictureBox1.Location = new Point(530, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(25, 25);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 16;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // BookGenreDialog
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(567, 449);
            Controls.Add(pictureBox1);
            Controls.Add(groupBox2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "BookGenreDialog";
            StartPosition = FormStartPosition.CenterParent;
            Text = "BookGenreDialog";
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox2;
        private Button btnCancel;
        private Button btnSave;
        private Label label3;
        private Label label2;
        private GroupBox groupBox3;
        private TextBox txtGenreDescription;
        private Label label1;
        private GroupBox groupBox1;
        private TextBox txtGenreName;
        private PictureBox pictureBox1;
        private GroupBox groupBox4;
        private TextBox txtGenreId;
        private Label label4;
    }
}