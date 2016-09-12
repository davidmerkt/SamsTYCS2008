using System;
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
            lblStringToLabel.Text = "";
        }

        private void btnClickMe_Click(object sender, EventArgs e)
        {
            string TextToString = txtTextToString.Text;
            lblStringToLabel.Text = TextToString;
        }
    }
}
