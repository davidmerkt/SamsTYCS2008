using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CollectionsExample
{
    public partial class CollectionsExampleForm : Form
    {
        public CollectionsExampleForm()
        {
            InitializeComponent();
        }

        private void btnShowNames_Click(object sender, EventArgs e)
        {
            for (int intIndex = 0; intIndex < this.Controls.Count; intIndex++)
            {
                MessageBox.Show("Control #" + intIndex.ToString() + " has the name " + this.Controls[intIndex].Name);
            }
        }
    }
}
