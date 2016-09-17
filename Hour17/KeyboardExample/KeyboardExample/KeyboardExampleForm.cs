using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KeyboardExample
{
    public partial class KeyboardExampleForm : Form
    {
        public KeyboardExampleForm()
        {
            InitializeComponent();
        }

        private void txtInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (e.KeyChar == 'k' || e.KeyChar == 'K') e.Handled = true;


            //if (Convert.ToInt16(e.KeyChar.ToString()) == 1 ||
            //    Convert.ToInt16(e.KeyChar.ToString()) == 2 ||
            //    Convert.ToInt16(e.KeyChar.ToString()) == 3 ||
            //    Convert.ToInt16(e.KeyChar.ToString()) == 4 ||
            //    Convert.ToInt16(e.KeyChar.ToString()) == 5 ||
            //    Convert.ToInt16(e.KeyChar.ToString()) == 6 ||
            //    Convert.ToInt16(e.KeyChar.ToString()) == 7 ||
            //    Convert.ToInt16(e.KeyChar.ToString()) == 8 ||
            //    Convert.ToInt16(e.KeyChar.ToString()) == 9 ||
            //    Convert.ToInt16(e.KeyChar.ToString()) == 0)
            //{ e.Handled = false; }
            //else e.Handled = true;


            try
            {
                Convert.ToInt16(e.KeyChar.ToString());
                e.Handled = false;
            }
            catch
            {
                e.Handled = true;
            }

            if (e.KeyChar == '.')
            {
                if (1 == 1)  //TODO if (period key has not yet been pressed (convert to string and search for period))
                {
                    e.Handled = false;
                }
                else e.Handled = true;
            }

            if (e.KeyChar == '\b') e.Handled = false;
        }
    }
}
