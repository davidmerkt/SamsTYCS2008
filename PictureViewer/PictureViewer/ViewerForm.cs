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
            if (ofdSelectPicture.ShowDialog() == DialogResult.OK)
            {
                picShowPicture.Image = Image.FromFile(ofdSelectPicture.FileName);
                this.Text = string.Concat("Picture Viewer (" + ofdSelectPicture.FileName + ")");
                sbrMyStatusStrip.Items[0].Text = ofdSelectPicture.FileName;
                ofdSelectPicture.FileName = "";
            }
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
    }
}
