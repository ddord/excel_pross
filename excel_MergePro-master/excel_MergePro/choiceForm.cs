using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace excel_MergePro
{
    public partial class choiceForm : Form
    {
        public choiceForm()
        {
            InitializeComponent();
        }

        public string[] receiveFile = new string[2];
        private Microsoft.Office.Interop.Excel.Application excelApp = null;


        private void choiceForm_Load(object sender, EventArgs e)
        {
            listChoice choiceList = new listChoice();
            choiceList.Visible = true;
            excelApp = new Microsoft.Office.Interop.Excel.Application();
            choiceList.excelMerge1 = excelApp.Workbooks.Open(receiveFile[0], null, true);
            choiceList.excelMerge2 = excelApp.Workbooks.Open(receiveFile[1], null, true);
            this.pnlMain.Controls.Add(choiceList);
            choiceList.Dock = System.Windows.Forms.DockStyle.Fill;
            //test code
            
        }

    }
}
