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

        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (ofdFileToBackup.ShowDialog() == DialogResult.OK)
            {
                txtFilePath.Text = ofdFileToBackup.FileName;
            }
        }

        private void btnBackup_Click(object sender, EventArgs e)
        {
            if (!System.IO.File.Exists(txtFilePath.Text))
            {
                MessageBox.Show("The file to be backed up \ndoes not exist!");
                return;
            }

            if (!System.IO.File.Exists(txtFilePath.Text + ".bak"))
            {
                System.IO.File.Copy(txtFilePath.Text, txtFilePath.Text + ".bak");
            }

            MessageBox.Show("The file was successfully backed up");
        }
    }
}
