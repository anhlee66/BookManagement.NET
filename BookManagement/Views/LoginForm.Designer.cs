namespace BookManagement.Views
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            panel1 = new Panel();
            panel2 = new Panel();
            txtUser = new TextBox();
            labuser = new Label();
            txtCancel = new Label();
            btnLogin = new Button();
            cbPassword = new CheckBox();
            txtPassword = new TextBox();
            label3 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(txtCancel);
            panel1.Controls.Add(btnLogin);
            panel1.Controls.Add(cbPassword);
            panel1.Controls.Add(txtPassword);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label1);
            panel1.Font = new Font("Segoe UI", 12F);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(399, 435);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.Controls.Add(txtUser);
            panel2.Controls.Add(labuser);
            panel2.Location = new Point(25, 63);
            panel2.Name = "panel2";
            panel2.Size = new Size(349, 101);
            panel2.TabIndex = 8;
            // 
            // txtUser
            // 
            txtUser.Font = new Font("Segoe UI", 12F);
            txtUser.Location = new Point(15, 50);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(318, 34);
            txtUser.TabIndex = 6;
            // 
            // labuser
            // 
            labuser.AutoSize = true;
            labuser.Font = new Font("Segoe UI", 12F);
            labuser.Location = new Point(15, 10);
            labuser.Name = "labuser";
            labuser.Size = new Size(104, 28);
            labuser.TabIndex = 5;
            labuser.Text = "User name";
            // 
            // txtCancel
            // 
            txtCancel.AutoSize = true;
            txtCancel.Location = new Point(165, 393);
            txtCancel.Name = "txtCancel";
            txtCancel.Size = new Size(69, 28);
            txtCancel.TabIndex = 7;
            txtCancel.Text = "Cancel";
            txtCancel.Click += txtCancel_Click;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.SteelBlue;
            btnLogin.Location = new Point(40, 335);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(318, 46);
            btnLogin.TabIndex = 6;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // cbPassword
            // 
            cbPassword.AutoSize = true;
            cbPassword.Location = new Point(38, 271);
            cbPassword.Name = "cbPassword";
            cbPassword.Size = new Size(170, 32);
            cbPassword.TabIndex = 5;
            cbPassword.Text = "Show password";
            cbPassword.UseVisualStyleBackColor = true;
            cbPassword.CheckedChanged += cbPassword_CheckedChanged;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 12F);
            txtPassword.Location = new Point(40, 218);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(318, 34);
            txtPassword.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(38, 177);
            label3.Name = "label3";
            label3.Size = new Size(93, 28);
            label3.TabIndex = 2;
            label3.Text = "Password";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(59, 9);
            label1.Name = "label1";
            label1.Size = new Size(281, 38);
            label1.TabIndex = 0;
            label1.Text = "Login To Book Store";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(417, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(277, 457);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(706, 472);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoginForm";
            Load += LoginForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label txtCancel;
        private Button btnLogin;
        private CheckBox cbPassword;
        private TextBox txtPassword;
        private TextBox txtName;
        private Label label3;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
        private Panel panel2;
        private TextBox txtUser;
        private Label labuser;
    }
}