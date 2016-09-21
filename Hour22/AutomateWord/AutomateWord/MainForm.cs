using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;

namespace AutomateWord
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnAutomateWord_Click(object sender, EventArgs e)
        {
            Word.Application objWord = new Word.Application();
            objWord.Visible = true;

            Word.Document objDoc;
            object objMissing = System.Reflection.Missing.Value;

            objDoc = objWord.Documents.Add(ref objMissing, ref objMissing, ref objMissing, ref objMissing);

            objWord.Selection.TypeText("This is text from a C# application.");

            objWord = null;
        }
    }
}
