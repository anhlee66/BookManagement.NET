﻿using System;
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
    public partial class AdminSetting : Form
    {
        public AdminSetting()
        {
            InitializeComponent();
        }

        private void AdminSetting_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;

        }
    }
}
