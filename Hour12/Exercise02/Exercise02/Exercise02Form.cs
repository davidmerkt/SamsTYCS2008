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

            int FirstSpaceLocation = Birthday.IndexOf("/", 0);
            int SecondSpaceLocation = Birthday.IndexOf("/", FirstSpaceLocation + 1);

            string Month = Birthday.Substring(0, FirstSpaceLocation);
            string Day = Birthday.Substring(FirstSpaceLocation + 1, SecondSpaceLocation - FirstSpaceLocation - 1);
            string Year = Birthday.Substring(SecondSpaceLocation + 1, Birthday.Length - SecondSpaceLocation - 1);
            

            DateTime BirthdayP = new DateTime( int.Parse(Year), int.Parse(Month), int.Parse(Day));

            MessageBox.Show("The day of birth is: " + BirthdayP.DayOfWeek);
        }

        private void txtBirthdateEntry_Click(object sender, EventArgs e)
        {
            txtBirthdateEntry.Text = "";
        }
    }
}
