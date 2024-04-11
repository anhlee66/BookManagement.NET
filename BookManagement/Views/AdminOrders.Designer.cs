namespace BookManagement.Views
{
    partial class AdminOrders
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
            panel1 = new Panel();
            label3 = new Label();
            button1 = new Button();
            groupBox1 = new GroupBox();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            comboBox1 = new ComboBox();
            label1 = new Label();
            panel2 = new Panel();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label3);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(groupBox1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(411, 542);
            panel1.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(32, 382);
            label3.Name = "label3";
            label3.Size = new Size(105, 20);
            label3.TabIndex = 5;
            label3.Text = "Total: 10.000 d";
            // 
            // button1
            // 
            button1.Location = new Point(150, 428);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 4;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Location = new Point(32, 183);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(328, 176);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.add__Custom_;
            pictureBox1.InitialImage = Properties.Resources.add__Custom_;
            pictureBox1.Location = new Point(291, 14);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(31, 31);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 95);
            label2.Name = "label2";
            label2.Size = new Size(154, 20);
            label2.TabIndex = 2;
            label2.Text = "Customer information";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(32, 118);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(328, 28);
            comboBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(103, 20);
            label1.Name = "label1";
            label1.Size = new Size(180, 38);
            label1.TabIndex = 0;
            label1.Text = "Create order";
            // 
            // panel2
            // 
            panel2.Location = new Point(437, 20);
            panel2.Name = "panel2";
            panel2.Size = new Size(452, 510);
            panel2.TabIndex = 1;
            // 
            // AdminOrders
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(901, 542);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AdminOrders";
            Text = "AdminOrders";
            Load += AdminOrders_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private GroupBox groupBox1;
        private PictureBox pictureBox1;
        private Label label2;
        private ComboBox comboBox1;
        private Label label1;
        private Label label3;
        private Button button1;
        private Panel panel2;
    }
}