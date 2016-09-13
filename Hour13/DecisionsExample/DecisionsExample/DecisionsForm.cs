using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DecisionsExample
{
    public partial class DecisionsForm : Form
    {
        public DecisionsForm()
        {
            InitializeComponent();
        }

        private void btnIsLessThanHundred_Click(object sender, EventArgs e)
        {
            if (int.Parse(txtInput.Text) < 100)
                MessageBox.Show("The text entered is less than 100.");
            else
                MessageBox.Show("The text entered is greater than or equal to 100.");
        }
    }
}
