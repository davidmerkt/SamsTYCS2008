using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using Word = Microsoft.Office.Interop.Word;

namespace Exercise
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnAutomate_Click(object sender, EventArgs e)
        {
            object objMissing = System.Reflection.Missing.Value;

            Excel.Application objExcel = new Excel.Application();
            objExcel.Visible = true;

            Excel.Workbook objBook = objExcel.Workbooks.Add(System.Reflection.Missing.Value);
            Excel.Worksheet objSheet = (Excel.Worksheet)objBook.Worksheets.get_Item(1);

            Excel.Range objRange;

            objRange = objSheet.get_Range("A1", objMissing);
            objRange.Value2 = 75;

            objRange = objSheet.get_Range("B1", objMissing);
            objRange.Value2 = 125;

            objRange = objSheet.get_Range("C1", objMissing);
            objRange.Value2 = 255;

            objRange = objSheet.get_Range("D1", objMissing);
            objRange.Value2 = 295;

            objRange = objSheet.get_Range("E1", objMissing);
            objRange.set_Value(objMissing, "=SUM(RC[-4]:RC[-1])");

            string ExcelValue = objRange.Value2.ToString();

            objRange = objSheet.get_Range("A1", "E1");
            objRange.Font.Bold = true;

            //objBook.SaveAs(objMissing, Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookDefault, objMissing, objMissing,
            //false, false, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlNoChange,
            //objMissing, objMissing, objMissing, objMissing, objMissing);

            objBook.Save();

            Word.Application objWord = new Word.Application();
            objWord.Visible = true;

            Word.Document objDoc = objWord.Documents.Add(ref objMissing, ref objMissing, ref objMissing, ref objMissing);

            objWord.Selection.TypeText(ExcelValue);

            objExcel = null;
            objWord = null;
        }
    }
}
