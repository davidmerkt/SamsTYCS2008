using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Exercise01
{
    public partial class Exercise01Form : Form
    {
        public Exercise01Form()
        {
            InitializeComponent();
        }

        private void btnFindNumbers_Click(object sender, EventArgs e)
        {
            int intSeek = 1;
            int intFound = 0;

            do
            {
                if ((intSeek % int.Parse(txtInput.Text)) == 0)
                {
                    lstResults.Items.Add(intSeek.ToString());
                    intFound++;
                } 
                intSeek++;
            } while (intFound < 10);
        }
    }
}
