using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomDialogExample
{
    public partial class CustomDialogExampleForm : Form
    {
        public CustomDialogExampleForm()
        {
            InitializeComponent();
        }

        private void btnShowCustomDialogBox_Click(object sender, EventArgs e)
        {
            CustomDialogBoxForm frmCustomDialogBox = new CustomDialogBoxForm();

            if (frmCustomDialogBox.ShowDialog() == DialogResult.OK)
                MessageBox.Show("You clicked OK.");
            else
                MessageBox.Show("You clicked Cancel.");

            frmCustomDialogBox = null;
        }
    }
}
