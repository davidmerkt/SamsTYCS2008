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

        private void btnBreakStuff_Click(object sender, EventArgs e)
        {
            breakStuff();
        }

        private static void breakStuff()
        {
            breakStuff();
        }
    }
}
