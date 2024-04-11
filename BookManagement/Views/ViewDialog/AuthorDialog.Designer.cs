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
            button4 = new Button();
            textBox2 = new TextBox();
            button3 = new Button();
            textBox1 = new TextBox();
            button2 = new Button();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 12F);
            button4.Location = new Point(134, 276);
            button4.Name = "button4";
            button4.Size = new Size(108, 37);
            button4.TabIndex = 34;
            button4.Text = "New";
            button4.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(254, 169);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(339, 27);
            textBox2.TabIndex = 30;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 12F);
            button3.Location = new Point(289, 276);
            button3.Name = "button3";
            button3.Size = new Size(108, 37);
            button3.TabIndex = 27;
            button3.Text = "Clear";
            button3.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 12F);
            textBox1.Location = new Point(254, 106);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(338, 34);
            textBox1.TabIndex = 25;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 12F);
            button2.Location = new Point(445, 276);
            button2.Name = "button2";
            button2.Size = new Size(108, 37);
            button2.TabIndex = 24;
            button2.Text = "Cancel";
            button2.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(87, 165);
            label4.Name = "label4";
            label4.Size = new Size(84, 28);
            label4.TabIndex = 22;
            label4.Text = "Contact:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(87, 106);
            label2.Name = "label2";
            label2.Size = new Size(130, 28);
            label2.TabIndex = 21;
            label2.Text = "Author Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(239, 25);
            label1.Name = "label1";
            label1.Size = new Size(172, 38);
            label1.TabIndex = 20;
            label1.Text = "Add Author";
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
            // 
            // AuthorDialog
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(680, 358);
            Controls.Add(pictureBox1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AuthorDialog";
            StartPosition = FormStartPosition.CenterParent;
            Text = "AuthorDialog";
            TransparencyKey = Color.Gray;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button4;
        private TextBox textBox2;
        private Button button3;
        private TextBox textBox1;
        private Button button2;
        private Label label4;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
    }
}