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
        }

        private void btnMoveLeft_Click(object sender, EventArgs e)
        {
            this.Left -= 2;
        }

        private void btnMoveRight_Click(object sender, EventArgs e)
        {
            this.Left += 2;
        }
    }
}
