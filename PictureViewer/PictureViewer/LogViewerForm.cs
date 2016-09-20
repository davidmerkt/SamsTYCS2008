using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PictureViewer
{
    public partial class LogViewerForm : Form
    {
        public LogViewerForm()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LogViewerForm_Load(object sender, EventArgs e)
        {
            try
            {
                System.IO.StreamReader objFile = new System.IO.StreamReader(System.AppDomain.CurrentDomain.BaseDirectory + @"\PictureLog.txt");
                txtLog.Text = objFile.ReadToEnd();
                objFile.Close();
                objFile.Dispose();
            }
            catch
            {
                txtLog.Text = "The log file could not be found.";
            }
        }

        private void btnClearLog_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you really want to clear the log?", "Clear Log", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    System.IO.File.Delete(System.AppDomain.CurrentDomain.BaseDirectory + @"\PictureLog.txt");
                    MessageBox.Show("Log Cleared", "Log Cleared");
                    txtLog.Text = "The log file was cleared…";
                }
                catch
                {
                    MessageBox.Show("The log file was not found", "File not found");
                }
            }

        }
    }
}
