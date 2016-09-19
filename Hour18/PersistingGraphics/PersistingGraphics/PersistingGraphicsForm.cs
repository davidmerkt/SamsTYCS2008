using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersistingGraphics
{
    public partial class PersistingGraphicsForm : Form
    {
        private Bitmap m_objDrawingSurface;

        public PersistingGraphicsForm()
        {
            InitializeComponent();
        }

        private void PersistingGraphicsForm_Load(object sender, EventArgs e)
        {
            m_objDrawingSurface = new Bitmap(this.ClientRectangle.Width, this.ClientRectangle.Height, System.Drawing.Imaging.PixelFormat.Format24bppRgb);
            InitializeSurface();
        }

        private void PersistingGraphicsForm_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(m_objDrawingSurface, 0, 0, m_objDrawingSurface.Width, m_objDrawingSurface.Height);
            e.Graphics.Dispose();
        }

        private void PersistingGraphicsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            m_objDrawingSurface.Dispose();
        }

        private void btnDrawText_Click(object sender, EventArgs e)
        {
            Graphics objGraphics;
            Font objFont;
            int intFontSize, intTextX, intTextY;

            Random randomGenerator = new Random();

            if (txtInput.Text == "") return;

            objGraphics = Graphics.FromImage(m_objDrawingSurface);
            intFontSize = randomGenerator.Next(8, 48);
            intTextX = randomGenerator.Next(0, this.ClientRectangle.Width);
            intTextY = randomGenerator.Next(0, this.ClientRectangle.Height);

            objFont = new System.Drawing.Font("Courier New", intFontSize, FontStyle.Bold);
            objGraphics.DrawString(txtInput.Text, objFont, System.Drawing.Brushes.Red, intTextX, intTextY);

            objGraphics.Dispose();
            this.Invalidate();
        }

        private void InitializeSurface()
        {
            Graphics objGraphics;
            Rectangle rectBounds;

            objGraphics = Graphics.FromImage(m_objDrawingSurface);

            objGraphics.Clear(SystemColors.Control);

            rectBounds = new Rectangle(0, 0, m_objDrawingSurface.Width, m_objDrawingSurface.Height);
            rectBounds.Inflate(-1, -1);

            objGraphics.DrawEllipse(Pens.Orange, rectBounds);

            objGraphics.Dispose();
        }
    }
}
