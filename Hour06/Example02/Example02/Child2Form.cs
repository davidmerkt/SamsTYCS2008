using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Example02
{
    public partial class Child2Form : Form
    {
        public Child2Form()
        {
            InitializeComponent();
        }

        private void btnShowChild1_Click(object sender, EventArgs e)
        {
            Child1Form objChild = new Child1Form();
            objChild.MdiParent = this.MdiParent;
            objChild.Show();
        }
    }
}
