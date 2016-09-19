using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManipulatingFiles
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = @"C:\";
            openFileDialog1.Title = "Select a File";
            openFileDialog1.FileName = "";
            openFileDialog1.Filter = "Text Files (*.txt)|*.txt";
            openFileDialog1.FilterIndex = 1;

            if (openFileDialog1.ShowDialog() != DialogResult.Cancel)
                txtSource.Text = openFileDialog1.FileName;
            else
                txtSource.Text = "";
        }

        private void btnSaveFile_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Title = "Specify Destination File Name";
            saveFileDialog1.Filter = "Text Files (*.txt)|*.txt";
            saveFileDialog1.FilterIndex = 1;
            saveFileDialog1.OverwritePrompt = true;

            if (saveFileDialog1.ShowDialog() != DialogResult.Cancel)
                txtDestination.Text = saveFileDialog1.FileName;
        }

        bool SourceFileExists()
        {
            if (!System.IO.File.Exists(txtSource.Text))
            {
                MessageBox.Show("The source file does not exist!");
                return false;
            }
            else return true;
        }

        private void btnCopyFile_Click(object sender, EventArgs e)
        {
            if (!SourceFileExists()) return;
            System.IO.File.Copy(txtSource.Text, txtDestination.Text);
            MessageBox.Show("The file has been successfully copied.");
        }

        private void btnMove_Click(object sender, EventArgs e)
        {
            if (!SourceFileExists()) return;
            System.IO.File.Move(txtSource.Text, txtDestination.Text);
            MessageBox.Show("The file has been successfully moved.");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (!SourceFileExists()) return;

            if (MessageBox.Show("Are you sure you want to delete the source file?", 
                "Delete Verification", MessageBoxButtons.YesNo, 
                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                System.IO.File.Delete(txtSource.Text);
                MessageBox.Show("The file has been successfully deleted.");
            }
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            if (!SourceFileExists()) return;

            if (MessageBox.Show("Are you sure you want to encrypt the source file?",
                "Encrypt Verification", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                System.IO.File.Encrypt(txtSource.Text);
                MessageBox.Show("The file has been encrypted.");
            }
        }
    }
}
