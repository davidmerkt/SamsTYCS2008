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
        public ViewerForm()
        {
            InitializeComponent();
        }

        private void btnSelectPicture_Click(object sender, EventArgs e)
        {
            if (ofdSelectPicture.ShowDialog() == DialogResult.OK)
            {
                picShowPicture.Image = Image.FromFile(ofdSelectPicture.FileName);
                this.Text = String.Concat("Picture Viewer (" + ofdSelectPicture.FileName + ")");
                ofdSelectPicture.FileName = "";
            }
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
