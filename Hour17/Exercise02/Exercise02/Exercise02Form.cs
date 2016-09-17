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
        private Graphics m_objGraphics;

        public Exercise02Form()
        {
            InitializeComponent();
        }

        private void Exercise02Form_Load(object sender, EventArgs e)
        {
            m_objGraphics = this.CreateGraphics();
        }

        private void Exercise02Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            m_objGraphics.Dispose();
        }

        private void Exercise02Form_MouseMove(object sender, MouseEventArgs e)
        {
            Rectangle rectEllipse = new Rectangle();

            if (e.Button != MouseButtons.Left) return;

            rectEllipse.X = e.X - 1;
            rectEllipse.Y = e.Y - 1;
            rectEllipse.Width = 2;
            rectEllipse.Height = 2;

            m_objGraphics.DrawEllipse(System.Drawing.Pens.Blue, rectEllipse);
        }

        private void Exercise02Form_MouseDown(object sender, MouseEventArgs e)
        {
            m_objGraphics.Clear(this.BackColor);
        }
    }
}
