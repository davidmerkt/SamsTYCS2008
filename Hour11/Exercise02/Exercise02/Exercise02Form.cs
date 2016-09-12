using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Exercise02
{
    public partial class Exercise02Form : Form
    {
        public Exercise02Form()
        {
            InitializeComponent();
        }

        private void btnExercise_Click(object sender, EventArgs e)
        {
            string[] strGameArray = new string[2];
            strGameArray[0] = "Battlefield 2";
            strGameArray[1] = "The Orange Box";
        }
    }
}
