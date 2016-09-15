using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise02
{
    public partial class Exercise02Form : Form
    {
        public Exercise02Form()
        {
            InitializeComponent();
        }

        private void btnPerformDivision_Click(object sender, EventArgs e)
        {
            long lngAnswer;

            if (txtInput.Text.Length == 0) 
                return;

            try
            {
                lngAnswer = 100 / Convert.ToInt64(txtInput.Text);
                MessageBox.Show("100 / " + txtInput.Text + " is " + lngAnswer);
            }
            catch
            {
                MessageBox.Show("Entry in textbox must be a number");
            }
        }
    }
}
