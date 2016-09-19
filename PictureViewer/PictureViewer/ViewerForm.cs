using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PictureViewer
{
    public partial class ViewerForm : Form
    {
        const bool c_defPromptOnExit = false;
        string m_strUserName = "";
        bool m_blnPromptOnExit = c_defPromptOnExit;
        Color m_objPictureBackColor;

        public ViewerForm()
        {
            InitializeComponent();
        }

        private void ViewerForm_Load(object sender, EventArgs e)
        {
            lblX.Text = "";
            lblY.Text = "";
            m_blnPromptOnExit = c_defPromptOnExit;
            m_objPictureBackColor = System.Drawing.SystemColors.Control;
            picShowPicture.BackColor = m_objPictureBackColor;
            mnuConfirmOnExit.Checked = m_blnPromptOnExit;
        }

        private void btnEnlarge_Click(object sender, EventArgs e)
        {
            this.Width += 20;
            this.Height += 20;
        }

        private void btnShrink_Click(object sender, EventArgs e)
        {
            this.Width -= 20;
            this.Height -= 20;
        }

        private void picShowPicture_MouseMove(object sender, MouseEventArgs e)
        {
            lblX.Text = "X: " + e.X.ToString();
            lblY.Text = "Y: " + e.Y.ToString();
        }

        private void picShowPicture_MouseLeave(object sender, EventArgs e)
        {
            lblX.Text = "";
            lblY.Text = "";
        }

        private void mnuOpenPicture_Click(object sender, EventArgs e)
        {
            OpenPicture();
        }

        private void mnuConfirmOnExit_Click(object sender, EventArgs e)
        {
            mnuConfirmOnExit.Checked = !(mnuConfirmOnExit.Checked);
            m_blnPromptOnExit = mnuConfirmOnExit.Checked;
        }

        private void mnuQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mnuDrawBorder_Click(object sender, EventArgs e)
        {
            DrawBorder(picShowPicture);
        }

        private void mnuOptions_Click(object sender, EventArgs e)
        {
            Options();
        }

        private void tbbOpenPicture_Click(object sender, EventArgs e)
        {
            OpenPicture();
        }

        private void tbbDrawBorder_Click(object sender, EventArgs e)
        {
            DrawBorder(picShowPicture);
        }

        private void tbbOptions_Click(object sender, EventArgs e)
        {
            Options();
        }

        private void tbbEnlarge_Click(object sender, EventArgs e)
        {

        }

        private void tbbShrink_Click(object sender, EventArgs e)
        {

        }

        private void OpenPicture()
        {
            try
            {
                if (ofdSelectPicture.ShowDialog() == DialogResult.OK)
                {
                    picShowPicture.Image = Image.FromFile(ofdSelectPicture.FileName);
                    this.Text = string.Concat("Picture Viewer (" + ofdSelectPicture.FileName + ")");
                    sbrMyStatusStrip.Items[0].Text = ofdSelectPicture.FileName; 
                }
            }
            catch (System.OutOfMemoryException)
            {
                MessageBox.Show("The file you have chosen is not an image file.", "Invalid File", MessageBoxButtons.OK);
            }

            //ofdSelectPicture.FileName = ""; 
        }

        private void DrawBorder(PictureBox objPicturebox)
        {
            Graphics objGraphics = this.CreateGraphics();
            objGraphics.Clear(SystemColors.Control);
            objGraphics.DrawRectangle(Pens.Blue,
                objPicturebox.Left - 1, objPicturebox.Top - 1,
                objPicturebox.Width + 1, objPicturebox.Height + 1);
            objGraphics.Dispose();
        }

        private void Options()
        {
            OptionsForm frmOptionsDialog = new OptionsForm();
            frmOptionsDialog.ShowDialog();
        }

        private void ViewerForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (m_blnPromptOnExit)
            {
                if(MessageBox.Show("Close the Picture Viewer program?", "Confirm Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }

        private void ViewerForm_Resize(object sender, EventArgs e)
        {
            this.Refresh();
        }

        private void tbbGetFileAttributes_Click(object sender, EventArgs e)
        {
            if ((ofdSelectPicture.FileName) == "") 
            { 
                MessageBox.Show("There is no file open");
                return;
            }

            System.Text.StringBuilder stbProperties = new System.Text.StringBuilder("");
            System.IO.FileAttributes fileAttributes;

            stbProperties.Append("Created: ");
            stbProperties.Append(System.IO.File.GetCreationTime(ofdSelectPicture.FileName));
            stbProperties.Append("\r\n");

            stbProperties.Append("Accessed: ");
            stbProperties.Append(System.IO.File.GetLastAccessTime(ofdSelectPicture.FileName));
            stbProperties.Append("\r\n");

            stbProperties.Append("Modified: ");
            stbProperties.Append(System.IO.File.GetLastWriteTime(ofdSelectPicture.FileName));
            stbProperties.Append("\r\n");

            fileAttributes = System.IO.File.GetAttributes(ofdSelectPicture.FileName);
            stbProperties.Append("\r\n");

            stbProperties.Append("Normal: ");
            stbProperties.Append(Convert.ToBoolean((fileAttributes & System.IO.FileAttributes.Normal) == System.IO.FileAttributes.Normal));
            stbProperties.Append("\r\n");

            stbProperties.Append("Hidden: ");
            stbProperties.Append(Convert.ToBoolean((fileAttributes & System.IO.FileAttributes.Hidden) == System.IO.FileAttributes.Hidden));
            stbProperties.Append("\r\n");

            stbProperties.Append("Read-Only: ");
            stbProperties.Append(Convert.ToBoolean((fileAttributes & System.IO.FileAttributes.ReadOnly) == System.IO.FileAttributes.ReadOnly));
            stbProperties.Append("\r\n");

            stbProperties.Append("System: ");
            stbProperties.Append(Convert.ToBoolean((fileAttributes & System.IO.FileAttributes.System) == System.IO.FileAttributes.System));
            stbProperties.Append("\r\n");

            stbProperties.Append("Temp File: ");
            stbProperties.Append(Convert.ToBoolean((fileAttributes & System.IO.FileAttributes.Temporary) == System.IO.FileAttributes.Temporary));
            stbProperties.Append("\r\n");

            stbProperties.Append("Archive: ");
            stbProperties.Append(Convert.ToBoolean((fileAttributes & System.IO.FileAttributes.Archive) == System.IO.FileAttributes.Archive));

            MessageBox.Show(stbProperties.ToString());
        }
    }
}
