using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise01
{
    public partial class Exercise01Form : Form
    {
        public Exercise01Form()
        {
            InitializeComponent();
        }

        private void btnPerformDivision_Click(object sender, EventArgs e)
        {
            Single lngAnswer;
            //if (txtInput.Text.Length == 0) return;
            lngAnswer = 100 / Convert.ToInt64(txtInput.Text);
            MessageBox.Show("100 / " + txtInput.Text + " is " + lngAnswer);
        }
    }
}
