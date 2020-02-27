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
using System.Reflection;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;

namespace excel_MergePro
{
    public partial class Form1 : Form
    {
        private int countFile = 0;
        private Object oDocument;
        private Excel.Application excelApp = new Excel.Application();
        private Excel.Workbook exlWbMerge1 = null;
        private Excel.Workbook exlWb = null;
        private Excel.Worksheet exlSheet = null;
        private string s_filename = "";


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
                        s_filename = openFileDialog.FileName;
                        break;
                    case 2:
                        txb_OpenFIle2.Text = openFileDialog.FileName;

                        countFile = 0;
                        break;
                }
            }

            /*
            object missing = System.Reflection.Missing.Value;
            excelApp.Visible = false;

            exlWbMerge1 = (Excel.Workbook)(excelApp.Workbooks.Open(txb_OpenFIle1.Text, 0, false, 5, missing, missing, true, Excel.XlPlatform.xlWindows, "\t", true, false, 0, missing, missing, missing));

            exlSheet = (Excel.Worksheet)exlWbMerge1.ActiveSheet;
            
            if (countFile == 1)
            {
                Object refmissing = System.Reflection.Missing.Value;
                oDocument = null;
                webFile1.Navigate(exlWbMerge1.FullName, null, null, null);
            }
            else
            {

            }
            */

        }

        private void btnMergeFile_Click(object sender, EventArgs e)
        {
            //simpleMergeExcel();
            //choiceForm choiceform = new choiceForm();
            //Excel.Application excelApp = new Excel.Application();
            //choiceform.receiveFile[0] = txb_OpenFIle1.Text;
            //choiceform.receiveFile[1] = txb_OpenFIle2.Text;
            //choiceform.ShowDialog();
            //Excel.Workbook excelMerge1 = null;
            //Excel.Workbook excelMerge2 = null;

            //excelMerge1 = excelApp.Workbooks.Open(txb_OpenFIle1.Text, null, true);
            //excelMerge2 = excelApp.Workbooks.Open(txb_OpenFIle2.Text, null, true);

            //Excel.Worksheet excelSheet = null;
        }

        private void txb_OpenFIle1_TextChanged(object sender, EventArgs e)
        {

        }
        /*
public void simpleMergeExcel()
{

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

private void webFile1_Navigated(object sender, WebBrowserNavigatedEventArgs e)
{
   // Creation of the workbook object
   exlWb = RetrieveWorkbook(s_filename);
   if (exlWb == null) return;
   // Create the Excel.Application
   excelApp = (Excel.Application)exlWb.Application;
}

[DllImport("ole32.dll")]
static extern int GetRunningObjectTable
(uint reserved, out IRunningObjectTable pprot);
[DllImport("ole32.dll")] static extern int CreateBindCtx(uint reserved, out IBindCtx pctx);

public Excel.Workbook RetrieveWorkbook(string xlfile)
{
   IRunningObjectTable prot = null;
   IEnumMoniker pmonkenum = null;
   try
   {
       IntPtr pfetched = IntPtr.Zero;
       // Query the running object table (ROT)
       if (GetRunningObjectTable(0, out prot) != 0 || prot == null) return null;
       prot.EnumRunning(out pmonkenum); pmonkenum.Reset();
       IMoniker[] monikers = new IMoniker[1];
       while (pmonkenum.Next(1, monikers, pfetched) == 0)
       {
           IBindCtx pctx; string filepathname;
           CreateBindCtx(0, out pctx);
           // Get the name of the file
           monikers[0].GetDisplayName(pctx, null, out filepathname);
           // Clean up
           Marshal.ReleaseComObject(pctx);
           // Search for the workbook
           if (filepathname.IndexOf(xlfile) != -1)
           {
               object roval;
               // Get a handle on the workbook
               prot.GetObject(monikers[0], out roval);
               return roval as Excel.Workbook;
           }
       }
   }
   catch
   {
       return null;
   }
   finally
   {
       // Clean up
       if (prot != null) Marshal.ReleaseComObject(prot);
       if (pmonkenum != null) Marshal.ReleaseComObject(pmonkenum);
   }
   return null;
}
*/
    }
}
