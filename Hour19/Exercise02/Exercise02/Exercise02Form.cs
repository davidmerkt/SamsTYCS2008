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

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            string strExtention = txtFileExtention.Text;

            if (strExtention == "")
                strExtention = "*";

            ofdFilterExtention.Title = "Select a File";
            ofdFilterExtention.Filter = (strExtention + " files|*." + strExtention);
            ofdFilterExtention.FilterIndex = 1;

            if (ofdFilterExtention.ShowDialog() == DialogResult.Cancel)
            txtFileExtention.Text = "";
        }
    }
}
