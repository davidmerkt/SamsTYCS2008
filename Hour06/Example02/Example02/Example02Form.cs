using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

        private void Example02Form_Load(object sender, EventArgs e)
        {
            Child2Form objChild = new Child2Form();
            objChild.MdiParent = this;
            objChild.Show();
        }
    }
}
