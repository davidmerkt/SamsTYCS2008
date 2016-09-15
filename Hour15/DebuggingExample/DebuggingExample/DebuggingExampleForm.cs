using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DebuggingExample
{
    public partial class DebuggingExampleForm : Form
    {
        public DebuggingExampleForm()
        {
            InitializeComponent();
        }

        private void btnPerformDivision_Click(object sender, EventArgs e)
        {
            long lngAnswer;
            System.Diagnostics.Debug.WriteLine("Textbox value: " + txtInput.Text);
            if (txtInput.Text.Length == 0) return;
            lngAnswer = 100 / Convert.ToInt64(txtInput.Text);
            MessageBox.Show("100 / " + txtInput.Text + " is " + lngAnswer);
        }
    }
}
