using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Lists
{
    public partial class ListsForm : Form
    {
        public ListsForm()
        {
            InitializeComponent();
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            lstPinkFloydAlbums.Items.Add("The Division Bell");
        }

        private void btnRemoveItem_Click(object sender, EventArgs e)
        {
            lstPinkFloydAlbums.Items.Remove("The Division Bell");
        }

        private void btnClearList_Click(object sender, EventArgs e)
        {
            lstPinkFloydAlbums.Items.Clear();
        }

        private void btnShowItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You selected " + lstPinkFloydAlbums.SelectedItem + " which has an index of " + lstPinkFloydAlbums.SelectedIndex);
        }
    }
}
