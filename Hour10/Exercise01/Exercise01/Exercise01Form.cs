﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Exercise01
{
    public partial class Exercise01Form : Form
    {
        public Exercise01Form()
        {
            InitializeComponent();
            lblUppercase.Text = "";
        }

        private void txtTextBox_TextChanged(object sender, EventArgs e)
        {
            lblUppercase.Text = txtTextBox.Text.ToUpper();
        }
    }
}
