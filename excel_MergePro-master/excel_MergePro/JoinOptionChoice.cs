using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace excel_MergePro
{
    public partial class JoinOptionChoice : UserControl
    {
        public JoinOptionChoice()
        {
            InitializeComponent();
        }

        public Excel.Workbook excelMerge1 = null;
        public Excel.Workbook excelMerge2 = null;
        private Excel.Worksheet Worksheet = null;
        public List<string> cbList = new List<string>();

        private void JoinOptionChoice_Load(object sender, EventArgs e)
        {
            foreach (string TableName in cbList)
                cbSelectTable.Items.Add(System.IO.Path.GetFileName(TableName));

            excelList_load(excelMerge1, clbJoinFile1);
            excelList_load(excelMerge2, clbJoinFile2);
        }

        private void excelList_load (Excel.Workbook workbook, CheckedListBox ckListBox)
        {
            Worksheet = workbook.Sheets[1];

            int headerRow = Worksheet.UsedRange.Columns.ListHeaderRows;
            int columnsCount = Worksheet.UsedRange.Columns.Count;
            for (int i = 1; i <= columnsCount; i++)
            {
                ckListBox.Items.Add(Worksheet.Cells[headerRow, i].Value.ToString());
            }
        }
    }
}
