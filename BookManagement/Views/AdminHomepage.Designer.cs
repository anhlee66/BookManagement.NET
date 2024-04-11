namespace BookManagement.Views
{
    partial class AdminHomepage
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
            sidebar = new FlowLayoutPanel();
            panel7 = new Panel();
            sbDashboard = new Button();
            panel3 = new Panel();
            sbOrders = new Button();
            panel5 = new Panel();
            sbStorage = new Button();
            panel4 = new Panel();
            btnCategory = new Button();
            panel6 = new Panel();
            sbSetting = new Button();
            panel2 = new Panel();
            button1 = new Button();
            btnLogout = new Button();
            sbEmployee = new Button();
            panel1 = new Panel();
            button3 = new Button();
            sidebar.SuspendLayout();
            panel7.SuspendLayout();
            panel3.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel6.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // sidebar
            // 
            sidebar.BackColor = Color.SteelBlue;
            sidebar.Controls.Add(panel7);
            sidebar.Controls.Add(panel3);
            sidebar.Controls.Add(panel5);
            sidebar.Controls.Add(panel4);
            sidebar.Controls.Add(panel6);
            sidebar.Controls.Add(panel2);
            sidebar.Controls.Add(panel1);
            sidebar.Dock = DockStyle.Left;
            sidebar.Location = new Point(0, 0);
            sidebar.Name = "sidebar";
            sidebar.Size = new Size(284, 753);
            sidebar.TabIndex = 1;
            // 
            // panel7
            // 
            panel7.BackColor = Color.SteelBlue;
            panel7.Controls.Add(sbDashboard);
            panel7.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            panel7.ForeColor = SystemColors.ActiveCaptionText;
            panel7.Location = new Point(0, 0);
            panel7.Margin = new Padding(0);
            panel7.Name = "panel7";
            panel7.Size = new Size(284, 87);
            panel7.TabIndex = 6;
            // 
            // sbDashboard
            // 
            sbDashboard.FlatAppearance.BorderSize = 0;
            sbDashboard.FlatStyle = FlatStyle.Flat;
            sbDashboard.ForeColor = SystemColors.ActiveCaptionText;
            sbDashboard.Image = Properties.Resources.dashboard__Custom_;
            sbDashboard.ImageAlign = ContentAlignment.MiddleLeft;
            sbDashboard.Location = new Point(0, 15);
            sbDashboard.Margin = new Padding(3, 10, 3, 3);
            sbDashboard.Name = "sbDashboard";
            sbDashboard.Size = new Size(287, 69);
            sbDashboard.TabIndex = 2;
            sbDashboard.Text = "             Dashboard";
            sbDashboard.TextAlign = ContentAlignment.MiddleLeft;
            sbDashboard.UseVisualStyleBackColor = true;
            sbDashboard.Click += sbDashboard_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.SteelBlue;
            panel3.Controls.Add(sbOrders);
            panel3.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            panel3.ForeColor = SystemColors.ActiveCaptionText;
            panel3.Location = new Point(0, 87);
            panel3.Margin = new Padding(0);
            panel3.Name = "panel3";
            panel3.Padding = new Padding(0, 30, 0, 0);
            panel3.Size = new Size(284, 77);
            panel3.TabIndex = 4;
            // 
            // sbOrders
            // 
            sbOrders.FlatAppearance.BorderSize = 0;
            sbOrders.FlatStyle = FlatStyle.Flat;
            sbOrders.ForeColor = SystemColors.ActiveCaptionText;
            sbOrders.Image = Properties.Resources.checkout__Custom_;
            sbOrders.ImageAlign = ContentAlignment.MiddleLeft;
            sbOrders.Location = new Point(3, 3);
            sbOrders.Name = "sbOrders";
            sbOrders.Size = new Size(281, 77);
            sbOrders.TabIndex = 2;
            sbOrders.Text = "             Orders";
            sbOrders.TextAlign = ContentAlignment.MiddleLeft;
            sbOrders.UseVisualStyleBackColor = true;
            sbOrders.Click += sbOrders_Click;
            // 
            // panel5
            // 
            panel5.BackColor = Color.SteelBlue;
            panel5.Controls.Add(sbStorage);
            panel5.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            panel5.ForeColor = SystemColors.ActiveCaptionText;
            panel5.Location = new Point(0, 164);
            panel5.Margin = new Padding(0);
            panel5.Name = "panel5";
            panel5.Size = new Size(287, 77);
            panel5.TabIndex = 4;
            // 
            // sbStorage
            // 
            sbStorage.FlatAppearance.BorderSize = 0;
            sbStorage.FlatStyle = FlatStyle.Flat;
            sbStorage.ForeColor = SystemColors.ActiveCaptionText;
            sbStorage.Image = Properties.Resources.hosting__Custom_;
            sbStorage.ImageAlign = ContentAlignment.MiddleLeft;
            sbStorage.Location = new Point(3, 3);
            sbStorage.Name = "sbStorage";
            sbStorage.Size = new Size(281, 85);
            sbStorage.TabIndex = 2;
            sbStorage.Text = "             Storage";
            sbStorage.TextAlign = ContentAlignment.MiddleLeft;
            sbStorage.UseVisualStyleBackColor = true;
            sbStorage.Click += sbStorage_Click;
            // 
            // panel4
            // 
            panel4.BackColor = Color.SteelBlue;
            panel4.Controls.Add(btnCategory);
            panel4.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            panel4.ForeColor = SystemColors.ActiveCaptionText;
            panel4.Location = new Point(0, 241);
            panel4.Margin = new Padding(0);
            panel4.Name = "panel4";
            panel4.Size = new Size(287, 77);
            panel4.TabIndex = 4;
            // 
            // btnCategory
            // 
            btnCategory.FlatAppearance.BorderSize = 0;
            btnCategory.FlatStyle = FlatStyle.Flat;
            btnCategory.ForeColor = SystemColors.ActiveCaptionText;
            btnCategory.Image = Properties.Resources.menu__Custom_1;
            btnCategory.ImageAlign = ContentAlignment.MiddleLeft;
            btnCategory.Location = new Point(3, 3);
            btnCategory.Name = "btnCategory";
            btnCategory.Size = new Size(281, 71);
            btnCategory.TabIndex = 2;
            btnCategory.Text = "             Categories";
            btnCategory.TextAlign = ContentAlignment.MiddleLeft;
            btnCategory.UseVisualStyleBackColor = true;
            btnCategory.Click += button3_Click;
            // 
            // panel6
            // 
            panel6.BackColor = Color.SteelBlue;
            panel6.Controls.Add(sbEmployee);
            panel6.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            panel6.ForeColor = SystemColors.ActiveCaptionText;
            panel6.Location = new Point(0, 318);
            panel6.Margin = new Padding(0);
            panel6.Name = "panel6";
            panel6.Size = new Size(287, 77);
            panel6.TabIndex = 5;
            // 
            // sbSetting
            // 
            sbSetting.FlatAppearance.BorderSize = 0;
            sbSetting.FlatStyle = FlatStyle.Flat;
            sbSetting.ForeColor = SystemColors.ActiveCaptionText;
            sbSetting.Image = Properties.Resources.settings__Custom___1_;
            sbSetting.ImageAlign = ContentAlignment.MiddleLeft;
            sbSetting.Location = new Point(0, 0);
            sbSetting.Name = "sbSetting";
            sbSetting.Size = new Size(278, 71);
            sbSetting.TabIndex = 2;
            sbSetting.Text = "             Setting";
            sbSetting.TextAlign = ContentAlignment.MiddleLeft;
            sbSetting.UseVisualStyleBackColor = true;
            sbSetting.Click += sbSetting_Click;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Bottom;
            panel2.BackColor = Color.SteelBlue;
            panel2.Controls.Add(btnLogout);
            panel2.Controls.Add(sbSetting);
            panel2.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            panel2.ForeColor = SystemColors.ActiveCaptionText;
            panel2.Location = new Point(0, 395);
            panel2.Margin = new Padding(0);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(0, 30, 0, 0);
            panel2.Size = new Size(284, 77);
            panel2.TabIndex = 3;
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Image = Properties.Resources.logout__Custom_;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(3, 0);
            button1.Name = "button1";
            button1.Size = new Size(278, 71);
            button1.TabIndex = 3;
            button1.Text = "             Log out";
            button1.TextAlign = ContentAlignment.MiddleLeft;
            button1.UseVisualStyleBackColor = true;
            // 
            // btnLogout
            // 
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.ForeColor = SystemColors.ActiveCaptionText;
            btnLogout.Image = Properties.Resources.logout__Custom_;
            btnLogout.ImageAlign = ContentAlignment.MiddleLeft;
            btnLogout.Location = new Point(3, -673);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(284, 71);
            btnLogout.TabIndex = 2;
            btnLogout.Text = "              Log out";
            btnLogout.TextAlign = ContentAlignment.MiddleLeft;
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += button6_Click;
            // 
            // sbEmployee
            // 
            sbEmployee.FlatAppearance.BorderSize = 0;
            sbEmployee.FlatStyle = FlatStyle.Flat;
            sbEmployee.ForeColor = SystemColors.ActiveCaptionText;
            sbEmployee.Image = Properties.Resources.team__Custom_;
            sbEmployee.ImageAlign = ContentAlignment.MiddleLeft;
            sbEmployee.Location = new Point(0, 3);
            sbEmployee.Name = "sbEmployee";
            sbEmployee.Size = new Size(281, 71);
            sbEmployee.TabIndex = 3;
            sbEmployee.Text = "             Employee";
            sbEmployee.TextAlign = ContentAlignment.MiddleLeft;
            sbEmployee.UseVisualStyleBackColor = true;
            sbEmployee.Click += sbEmployee_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Bottom;
            panel1.BackColor = Color.SteelBlue;
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button1);
            panel1.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            panel1.ForeColor = SystemColors.ActiveCaptionText;
            panel1.Location = new Point(0, 472);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(0, 30, 0, 0);
            panel1.Size = new Size(284, 77);
            panel1.TabIndex = 4;
            // 
            // button3
            // 
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.ForeColor = SystemColors.ActiveCaptionText;
            button3.Image = Properties.Resources.logout__Custom_;
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(3, -673);
            button3.Name = "button3";
            button3.Size = new Size(284, 71);
            button3.TabIndex = 2;
            button3.Text = "              Log out";
            button3.TextAlign = ContentAlignment.MiddleLeft;
            button3.UseVisualStyleBackColor = true;
            // 
            // AdminHomepage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(1262, 753);
            Controls.Add(sidebar);
            IsMdiContainer = true;
            Name = "AdminHomepage";
            Text = "AdminHomepage";
            WindowState = FormWindowState.Maximized;
            Load += sbDashboard_Click;
            sidebar.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private FlowLayoutPanel sidebar;
        private Button sbDashboard;
        private Panel panel2;
        private Panel panel3;
        private Button sbOrders;
        private Panel panel4;
        private Button btnCategory;
        private Panel panel5;
        private Button sbStorage;
        private Panel panel6;
        private Button sbSetting;
        private Panel panel7;
        private Button btnLogout;
        private Button button1;
        private Button sbEmployee;
        private Panel panel1;
        private Button button3;
    }
}