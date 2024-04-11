using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookManagement.Views
{
    public partial class AdminOrders : Form
    {
        public AdminOrders()
        {
            InitializeComponent();
        }

        private void AdminOrders_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }
    }
}
