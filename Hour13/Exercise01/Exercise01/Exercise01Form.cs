using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise01
{
    public partial class Exercise01Form : Form
    {
        public Exercise01Form()
        {
            InitializeComponent();
        }

        private void btnShowMessagebox_Click(object sender, EventArgs e)
        {
            //if (txtShape.Text == "circle")
            //    MessageBox.Show("There are no sides\nto the shape…");
            //else if (txtShape.Text == "triangle")
            //    MessageBox.Show("There are three sides\nto the shape…");
            //else if (txtShape.Text == "square")
            //    MessageBox.Show("There are four sides\nto the shape…");
            //else if (txtShape.Text == "rectangle")
            //    MessageBox.Show("There are four sides\nto the shape…");
            //else if (txtShape.Text == "pentagon")
            //    MessageBox.Show("There are five sides\nto the shape…");
            //else
            //    MessageBox.Show("No valid shape was entered");

            switch (txtShape.Text)
            {
                case "circle":
                    MessageBox.Show("There are no sides\nto the shape…");
                    break;
                case "triangle":
                    MessageBox.Show("There are three sides\nto the shape…");
                    break;
                case "square":
                case "rectangle":
                    MessageBox.Show("There are four sides\nto the shape…");
                    break;
                case "pentagon":
                    MessageBox.Show("There are five sides\nto the shape…");
                    break;
                default:
                    MessageBox.Show("No valid shape was entered");
                    break;
            }
        }
    }
}
