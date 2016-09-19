using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise2
{
    public partial class Exercise02Form : Form
    {
        //Create a project that draws an ellipse that fills the form, 
        //    much like the one you created in this hour. However, draw 
        //    the ellipse directly to the form in the Paint event. Make 
        //    sure that the ellipse is redrawn when the form is sized. 
        //    (Hint: Invalidate the form in the form’s Resize() event.)

        Graphics objGraphics;

        public Exercise02Form()
        {
            InitializeComponent();
            drawEllipse();
            this.Invalidate();
        }

        private void drawEllipse()
        {
            objGraphics = this.CreateGraphics();
            objGraphics.Clear(SystemColors.Control);

            objGraphics.DrawEllipse(System.Drawing.Pens.Blue, 0, 0, this.ClientRectangle.Width - 1, this.ClientRectangle.Height - 1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            drawEllipse();
        }

        private void Exercise02Form_Load(object sender, EventArgs e)
        {
            drawEllipse();
            this.Invalidate();
        }

        private void Exercise02Form_Resize(object sender, EventArgs e)
        {
            drawEllipse();
            this.Invalidate();
        }
    }
}
