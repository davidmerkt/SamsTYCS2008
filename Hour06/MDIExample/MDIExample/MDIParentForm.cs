using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MDIExample
{
    public partial class MDIParentForm : Form
    {
        public MDIParentForm()
        {
            InitializeComponent();
        }

        private void MDIParentForm_Load(object sender, EventArgs e)
        {
            Child1Form objChild = new Child1Form();
            objChild.MdiParent = this;
            objChild.Show();
        }
    }
}
