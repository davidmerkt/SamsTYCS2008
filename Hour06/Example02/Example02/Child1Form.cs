using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Example02
{
    public partial class Child1Form : Form
    {
        public Child1Form()
        {
            InitializeComponent();
        }

        private void btnShowChild2_Click(object sender, EventArgs e)
        {
            Child2Form objChild = new Child2Form();
            objChild.MdiParent = this.MdiParent;
            objChild.Show();
        }
    }
}
