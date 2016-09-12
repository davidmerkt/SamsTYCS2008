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

        private void btnParse_Click(object sender, EventArgs e)
        {
            string FullName = txtFullName.Text;
            
            const int FirstStartingLocation = 0;
            int MiddleStartingLocation = FullName.IndexOf(" ", FirstStartingLocation) + 1;
            int LastStartingLocation = FullName.IndexOf(" ", MiddleStartingLocation) + 1;

            int FirstLength = MiddleStartingLocation - 1;
            int MiddleLength = LastStartingLocation - MiddleStartingLocation - 1;
            int LastLength = FullName.Length - LastStartingLocation;

            string FirstName = FullName.Substring(FirstStartingLocation, FirstLength);
            string MiddleName = FullName.Substring(MiddleStartingLocation, MiddleLength);
            string LastName = FullName.Substring(LastStartingLocation, LastLength);
            
            lblFirstName.Text = "First Name: " + FirstName;
            lblMiddleName.Text = "Middle Name: " + MiddleName;
            lblLastName.Text = "Last Name: " + LastName;
        }
    }
}
