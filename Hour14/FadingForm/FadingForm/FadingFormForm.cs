using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FadingForm
{
    public partial class FadingFormForm : Form
    {
        public FadingFormForm()
        {
            InitializeComponent();
        }

        private void btnFadeForm_Click(object sender, EventArgs e)
        {
            for (double dblOpacity = 1; dblOpacity > 0; dblOpacity += -.05)
            {
                this.Opacity = dblOpacity;
                //this.Refresh();
                System.Threading.Thread.Sleep(200);
            }
            this.Opacity = 1;
        }
    }
}
