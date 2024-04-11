namespace BookManagement.Views
{
    partial class StatisticControl
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
            panel1 = new Panel();
            scTitle = new Label();
            scValue = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.CornflowerBlue;
            panel1.Controls.Add(scTitle);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(227, 67);
            panel1.TabIndex = 0;
            // 
            // scTitle
            // 
            scTitle.AutoSize = true;
            scTitle.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            scTitle.ForeColor = Color.White;
            scTitle.Location = new Point(61, 19);
            scTitle.Name = "scTitle";
            scTitle.Size = new Size(107, 38);
            scTitle.TabIndex = 0;
            scTitle.Text = "Revene";
            // 
            // scValue
            // 
            scValue.AutoSize = true;
            scValue.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            scValue.Location = new Point(74, 101);
            scValue.Name = "scValue";
            scValue.Size = new Size(76, 31);
            scValue.TabIndex = 1;
            scValue.Text = "label2";
            // 
            // StatisticControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(scValue);
            Controls.Add(panel1);
            Name = "StatisticControl";
            Size = new Size(227, 164);
            Load += StatisticControl_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label scTitle;
        private Label scValue;
    }
}
