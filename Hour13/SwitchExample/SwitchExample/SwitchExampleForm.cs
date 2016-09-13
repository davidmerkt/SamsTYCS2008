using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SwitchExample
{
    public partial class SwitchExampleForm : Form
    {
        public SwitchExampleForm()
        {
            InitializeComponent();
        }

        private void btnShowLegs_Click(object sender, EventArgs e)
        {
            switch (cboAnimals.Text)
            {
                case "Bird":
                    MessageBox.Show("The animal has 2 legs.");
                    break;
                case "Dog":
                case "Horse":
                case "Cat":
                    MessageBox.Show("The animal has 4 legs.");
                    break;
                case "Snake":
                    MessageBox.Show("The animal has no legs.");
                    break;
                case "Centipede":
                    MessageBox.Show("The animal has 100 legs.");
                    break;
                default:
                    MessageBox.Show("You did not selecte from the list!");
                    break;
            }
        }
    }
}
