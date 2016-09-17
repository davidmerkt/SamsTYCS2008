using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MousePaint
{
    public partial class MousePaintForm : Form
    {
        private Graphics m_objGraphics;

        public MousePaintForm()
        {
            InitializeComponent();
        }

        private void MousePaintForm_Load(object sender, EventArgs e)
        {
            m_objGraphics = this.CreateGraphics();
        }

        private void MousePaintForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            m_objGraphics.Dispose();
        }

        private void MousePaintForm_MouseMove(object sender, MouseEventArgs e)
        {
            Rectangle rectEllipse = new Rectangle();

            if (e.Button != MouseButtons.Left) return;

            rectEllipse.X = e.X - 1;
            rectEllipse.Y = e.Y - 1;
            rectEllipse.Width = 2;
            rectEllipse.Height = 2;

            m_objGraphics.DrawEllipse(System.Drawing.Pens.Blue, rectEllipse);
        }
    }
}
