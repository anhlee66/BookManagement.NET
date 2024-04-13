namespace BookManagement.Views.ViewDialog
{
    partial class AuthorDialog
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
            pictureBox1 = new PictureBox();
            groupBox1 = new GroupBox();
            groupBox4 = new GroupBox();
            txtDescription = new TextBox();
            label4 = new Label();
            groupBox3 = new GroupBox();
            txtContact = new TextBox();
            label3 = new Label();
            groupBox2 = new GroupBox();
            txtAuthor = new TextBox();
            label2 = new Label();
            btnSave = new Button();
            btnClear = new Button();
            btnCancel = new Button();
            title = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.close__Custom_;
            pictureBox1.Location = new Point(653, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(25, 25);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 35;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(groupBox4);
            groupBox1.Controls.Add(groupBox3);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Controls.Add(btnSave);
            groupBox1.Controls.Add(btnClear);
            groupBox1.Controls.Add(btnCancel);
            groupBox1.Controls.Add(title);
            groupBox1.Location = new Point(22, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(634, 466);
            groupBox1.TabIndex = 36;
            groupBox1.TabStop = false;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(txtDescription);
            groupBox4.Controls.Add(label4);
            groupBox4.Location = new Point(55, 251);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(525, 127);
            groupBox4.TabIndex = 50;
            groupBox4.TabStop = false;
            // 
            // txtDescription
            // 
            txtDescription.Font = new Font("Segoe UI", 12F);
            txtDescription.Location = new Point(167, 20);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(338, 101);
            txtDescription.TabIndex = 44;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(21, 23);
            label4.Name = "label4";
            label4.Size = new Size(116, 28);
            label4.TabIndex = 43;
            label4.Text = "Description:";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(txtContact);
            groupBox3.Controls.Add(label3);
            groupBox3.Location = new Point(55, 166);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(525, 67);
            groupBox3.TabIndex = 49;
            groupBox3.TabStop = false;
            // 
            // txtContact
            // 
            txtContact.Font = new Font("Segoe UI", 12F);
            txtContact.Location = new Point(167, 20);
            txtContact.Name = "txtContact";
            txtContact.Size = new Size(338, 34);
            txtContact.TabIndex = 44;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(21, 23);
            label3.Name = "label3";
            label3.Size = new Size(84, 28);
            label3.TabIndex = 43;
            label3.Text = "Contact:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtAuthor);
            groupBox2.Controls.Add(label2);
            groupBox2.Location = new Point(55, 84);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(525, 67);
            groupBox2.TabIndex = 48;
            groupBox2.TabStop = false;
            // 
            // txtAuthor
            // 
            txtAuthor.Font = new Font("Segoe UI", 12F);
            txtAuthor.Location = new Point(167, 20);
            txtAuthor.Name = "txtAuthor";
            txtAuthor.Size = new Size(338, 34);
            txtAuthor.TabIndex = 44;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(21, 23);
            label2.Name = "label2";
            label2.Size = new Size(134, 28);
            label2.TabIndex = 43;
            label2.Text = "Author Name:";
            // 
            // btnSave
            // 
            btnSave.BackColor = SystemColors.ActiveCaption;
            btnSave.Font = new Font("Segoe UI", 12F);
            btnSave.Location = new Point(108, 413);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(108, 37);
            btnSave.TabIndex = 45;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Segoe UI", 12F);
            btnClear.Location = new Point(263, 413);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(108, 37);
            btnClear.TabIndex = 43;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = SystemColors.ButtonShadow;
            btnCancel.Font = new Font("Segoe UI", 12F);
            btnCancel.Location = new Point(419, 413);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(108, 37);
            btnCancel.TabIndex = 41;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += button2_Click;
            // 
            // title
            // 
            title.AutoSize = true;
            title.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            title.Location = new Point(231, 23);
            title.Name = "title";
            title.Size = new Size(172, 38);
            title.TabIndex = 38;
            title.Text = "Add Author";
            // 
            // AuthorDialog
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(680, 490);
            Controls.Add(groupBox1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AuthorDialog";
            StartPosition = FormStartPosition.CenterParent;
            Text = "AuthorDialog";
            TransparencyKey = Color.Gray;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox1;
        private GroupBox groupBox1;
        private GroupBox groupBox4;
        private TextBox txtDescription;
        private Label label4;
        private GroupBox groupBox3;
        private TextBox txtContact;
        private Label label3;
        private GroupBox groupBox2;
        private TextBox txtAuthor;
        private Label label2;
        private Button btnSave;
        private Button btnClear;
        private Button btnCancel;
        private Label title;
    }
}