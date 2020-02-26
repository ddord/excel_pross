using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using Excel = Microsoft.Office.Interop.Excel;
using ClosedXML;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Spreadsheet;

namespace excel_MergePro
{
    public partial class Form1 : Form
    {
        private int countFile = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnOpenFileClick(object sender, EventArgs args)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Excel File(*.xlsx)|*.xlsx|Text File(*.txt)|*.txt|CSV File(*.csv)|*.csv";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                countFile += 1;

                Button btnClickObject = new Button();
                btnClickObject = sender as Button;

                switch (countFile)
                {
                    case 1:
                        txb_OpenFIle1.Text = openFileDialog.FileName;
                        break;
                    case 2:
                        txb_OpenFIle2.Text = openFileDialog.FileName;
                        countFile = 0;
                        break;
                }
            }

        }

        private void btnMergeFile_Click(object sender, EventArgs e)
        {
            //choiceForm choiceform = new choiceForm();
            Excel.Application excelApp = new Microsoft.Office.Interop.Excel.Application();
            //choiceform.receiveFile[0] = txb_OpenFIle1.Text;
            //choiceform.receiveFile[1] = txb_OpenFIle2.Text;
            //choiceform.ShowDialog();
            Excel.Workbook excelMerge1 = null;
            Excel.Workbook excelMerge2 = null;

            //excelMerge1 = excelApp.Workbooks.Open(txb_OpenFIle1.Text, null, true);
            //excelMerge2 = excelApp.Workbooks.Open(txb_OpenFIle2.Text, null, true);

            Excel.Worksheet excelSheet = null;

            

            
            DataTable dt1 = new DataTable();
            dt1 = ReadAsDataTable(txb_OpenFIle1.Text);


            DataTable dt2 = new DataTable();
            dt2 = ReadAsDataTable(txb_OpenFIle2.Text);

            DataTable dtResult = dt1.Clone();


            var dt2Columns = dt2.Columns.OfType<DataColumn>().Select(dc => new DataColumn(dc.ColumnName, dc.DataType, dc.Expression, dc.ColumnMapping));


            var dt2FinalColumns = from dc in dt2Columns.AsEnumerable()
                                  where !dtResult.Columns.Contains(dc.ColumnName)
                                  select dc;

            dtResult.Columns.AddRange(dt2FinalColumns.ToArray());

            var result = from t1 in dt1.AsEnumerable()
                         join t2 in dt2.AsEnumerable() on t1.Field<string>("ID") equals t2.Field<string>("ID")
                         select t1.ItemArray.Concat(t2.ItemArray.Where(r2 => t1.ItemArray.Contains(r2) == false)).ToArray();

                         //select t1.ItemArray.Concat((subRight == null) ? (dt2.NewRow().ItemArray) : subRight.ItemArray).ToArray();
                         /*
                         select dtResult.LoadDataRow(new object[]
                         {
                             subRight.Field<string>("ID"),
                             subRight.Field<string>("관리번호"),
                             subRight.Field<string>("일련번호"),
                             subRight.Field<string>("성명"),
                             subRight.Field<string>("시도명"),
                             subRight.Field<string>("시군구명"),
                             subRight.Field<string>("법정읍면동명"),
                             subRight.Field<string>("지번본번(번지)"),
                             subRight.Field<string>("비번부번(호)"),
                             subRight.Field<string>("대표여부"),
                         }, false);
                         */

            foreach (object[] values in result)
                dtResult.Rows.Add(values);

            ClosedXML.Excel.XLWorkbook wbook = new ClosedXML.Excel.XLWorkbook();
            wbook.Worksheets.Add(dtResult, "tab1");
            
            wbook.SaveAs("D:\\03_dor_works\\LocalApp\\001\\test_data\\test11.xlsx");


        }

        public static DataTable ReadAsDataTable(string fileName)
        {
            DataTable dataTable = new DataTable();
            using (SpreadsheetDocument spreadSheetDocument = SpreadsheetDocument.Open(fileName, false))
            {
                WorkbookPart workbookPart = spreadSheetDocument.WorkbookPart;
                IEnumerable<Sheet> sheets = spreadSheetDocument.WorkbookPart.Workbook.GetFirstChild<Sheets>().Elements<Sheet>();
                string relationshipId = sheets.First().Id.Value;
                WorksheetPart worksheetPart = (WorksheetPart)spreadSheetDocument.WorkbookPart.GetPartById(relationshipId);
                Worksheet workSheet = worksheetPart.Worksheet;
                SheetData sheetData = workSheet.GetFirstChild<SheetData>();
                IEnumerable<Row> rows = sheetData.Descendants<Row>();

                foreach (Cell cell in rows.ElementAt(0))
                {
                    dataTable.Columns.Add(GetCellValue(spreadSheetDocument, cell));
                }

                foreach (Row row in rows)
                {
                    DataRow dataRow = dataTable.NewRow();
                    for (int i = 0; i < row.Descendants<Cell>().Count(); i++)
                    {
                        dataRow[i] = GetCellValue(spreadSheetDocument, row.Descendants<Cell>().ElementAt(i));
                    }

                    dataTable.Rows.Add(dataRow);
                }

            }
            dataTable.Rows.RemoveAt(0);

            return dataTable;
        }

        private static string GetCellValue(SpreadsheetDocument document, Cell cell)
        {
            SharedStringTablePart stringTablePart = document.WorkbookPart.SharedStringTablePart;
            string value = cell.CellValue.InnerXml;

            if (cell.DataType != null && cell.DataType.Value == CellValues.SharedString)
            {
                return stringTablePart.SharedStringTable.ChildElements[Int32.Parse(value)].InnerText;
            }
            else
            {
                return value;
            }
        }
    }
}
