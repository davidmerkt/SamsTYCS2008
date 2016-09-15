using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassProgrammingExample
{
    public partial class ClassExampleForm : Form
    {
        public ClassExampleForm()
        {
            InitializeComponent();
        }

        private void btnCreateObject_Click(object sender, EventArgs e)
        {
            clsMyClass objMyObject = new clsMyClass();
            MessageBox.Show(objMyObject.AddTwoNumbers(1, 2).ToString());
        }

        private void btnExercise01_Click(object sender, EventArgs e)
        {
            clsMyClass Exercise01 = new clsMyClass();
            MessageBox.Show(Exercise01.DropsInABucket.ToString());
        }

        private void btnExercise02_Click(object sender, EventArgs e)
        {
            clsMyClass object1;
            clsMyClass object2;

            object1 = new clsMyClass();
            object2 = object1;
            object1.Height = 15;
            MessageBox.Show(object2.Height.ToString(), "The height is…");
        }
    }
}
