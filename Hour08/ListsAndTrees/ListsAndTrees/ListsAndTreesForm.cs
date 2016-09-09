using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ListsAndTrees
{
    public partial class ListsAndTreesForm : Form
    {
        public ListsAndTreesForm()
        {
            InitializeComponent();
        }

        private void btnAddToList_Click(object sender, EventArgs e)
        {
            //lstMyListView.Items.Add("Mike Cook", 0);

            ListViewItem objListItem;
            objListItem = lstMyListView.Items.Add("Mike Saklar", 0);
            objListItem.SubItems.Add("Nebraska");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tvwLanguages.Nodes.Add("James");
            tvwLanguages.Nodes.Add("Visual C#");
        }

        private void btnCreateChild_Click(object sender, EventArgs e)
        {
            TreeNode objNode = tvwLanguages.Nodes.Add("Matt Perry");
            objNode.Nodes.Add("Visual C#");
        }

        private void btnDave_Click(object sender, EventArgs e)
        {
            TreeNode objNode = tvwLanguages.Nodes.Add("Dave");
            TreeNode languageNode = objNode.Nodes.Add("C#");
            languageNode.Nodes.Add("Learning…");
        }
    }
}
