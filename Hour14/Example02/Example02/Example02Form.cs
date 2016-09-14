using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Example02
{
    public partial class Example02Form : Form
    {
        public Example02Form()
        {
            InitializeComponent();
        }

        private void btnResize_Click(object sender, EventArgs e)
        {
            for (int i = 1; i <= 100; i++)
            {
                lblLabelToResize.Width = i;
                lblLabelToResize.Refresh();

                for (int j = 1; j <= 100; j++)
                {
                    lblLabelToResize.Height = j;
                    lblLabelToResize.Refresh();
                }
            }
        }
    }
}
