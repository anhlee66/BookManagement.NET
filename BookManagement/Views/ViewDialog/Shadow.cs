using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookManagement.Views.ViewDialog
{
    public partial class Shadow : Form
    {
        private Form parentForm;
        public Shadow(Form form)
        {
            this.parentForm = form;
            InitializeComponent();
        }

        private void Shadow_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void Shadow_FormClosed(object sender, FormClosedEventArgs e)
        {
            parentForm.Activate();
        }
    }
}
