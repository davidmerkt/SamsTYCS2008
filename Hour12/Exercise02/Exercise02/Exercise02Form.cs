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
        public Exercise02Form()
        {
            InitializeComponent();
        }

        private void btnFindBirthDay_Click(object sender, EventArgs e)
        {
            string Birthday = txtBirthdateEntry.Text;

            DateTime BirthdayP = Convert.ToDateTime(Birthday);

            MessageBox.Show("The day of birth is: " + BirthdayP.DayOfWeek);
        }

        private void txtBirthdateEntry_Click(object sender, EventArgs e)
        {
            txtBirthdateEntry.Text = "";
        }
    }
}
