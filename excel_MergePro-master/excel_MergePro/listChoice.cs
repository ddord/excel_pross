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
    public partial class listChoice : UserControl
    {
        public listChoice()
        {
            InitializeComponent();
        }
        
        private int choiceCount = 0;
        public Excel.Workbook excelMerge1 = null;
        public Excel.Workbook excelMerge2 = null;
        private Excel.Worksheet excelSheet = null;

        private void listChoice_Load(object sender, EventArgs e)
        {
            int countExcel = 1;
            excelSheet = excelMerge1.Sheets[1];
            listFill(excelSheet, 0, countExcel);
            countExcel += 1;
            excelSheet = excelMerge2.Sheets[1];
            listFill(excelSheet, 0, countExcel);
            choiceCount += 1;
        }

        private void MergFilesCheckList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listFill(Excel.Worksheet excelWs, int caseNum, int excelcount)
        {
            /*
            int columnCount = excelWs.UsedRange.Columns.Count;
            List<string> columnNames = new List<string>();
            clbMergeFile1.Items.Clear();
            clbMergeFile2.Items.Clear();

            for (int i = 1; i < columnCount; i++)
            {
                if (excelWs.Cells[1, i].value != null)
                { 
                    if (excelcount == 1)
                        //clbMergeFile1.Items.Add(excelWs.Cells.Value(match.Groups[2].ToString() + "1"));
                    else
                        //clbMergeFile2.Items.Add(match.Groups[2].Value);                   
                }
            }  
            */
        }
    }
}
