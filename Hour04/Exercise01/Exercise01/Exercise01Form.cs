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

        private void Exercise01Form_Load(object sender, EventArgs e)
        {
            this.BackColor = System.Drawing.Color.Blue;
            lblDescriptiveText.ForeColor = System.Drawing.Color.White;
        }
    }
}
