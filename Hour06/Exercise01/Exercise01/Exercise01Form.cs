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
            this.btnAnchorExample.Location = new System.Drawing.Point(((this.Width / 2) - (btnAnchorExample.Width / 2)), ((this.Height / 2) - (btnAnchorExample.Height / 2)));
        }
    }
}
