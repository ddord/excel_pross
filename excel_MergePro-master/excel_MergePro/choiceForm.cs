using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CommonCode;

namespace excel_MergePro
{
    public partial class choiceForm : Form, IMyInterface
    {
        private IMyInterface frm = null;
        public List<string> receiveFile = new List<string>();
        private Microsoft.Office.Interop.Excel.Application excelApp = null;
        //public string choiceForm_pnlValue { get; set; }

        public choiceForm()
        {
            InitializeComponent();
            //this.frm = frm;
        }
        
        public string choicechoiceForm_pnlValue { get; set; }

        string IMyInterface.choiceForm_pnlValue
        {
            get { return this.choicechoiceForm_pnlValue; }
            set { this.choicechoiceForm_pnlValue = value; }
        }
        
        private void choiceForm_Load(object sender, EventArgs e)
        {
            
            switch (choicechoiceForm_pnlValue)
            {
                case "table_two":
                    JoinOptionChoice joinOptionChoice = new JoinOptionChoice();
                    joinOptionChoice.Visible = true;
                    excelApp = new Microsoft.Office.Interop.Excel.Application();
                    joinOptionChoice.excelMerge1 = excelApp.Workbooks.Open(receiveFile[0], null, true);
                    joinOptionChoice.excelMerge2 = excelApp.Workbooks.Open(receiveFile[1], null, true);
                    joinOptionChoice.cbList = receiveFile;
                    joinOptionChoice.Dock = System.Windows.Forms.DockStyle.Fill;
                    this.pnlMain.Controls.Add(joinOptionChoice);
                    
                    break;
                case "table_mul":

                    break;                    
            }
            
            
            /*
            listChoice choiceList = new listChoice();
            choiceList.Visible = true;
            excelApp = new Microsoft.Office.Interop.Excel.Application();
            choiceList.excelMerge1 = excelApp.Workbooks.Open(receiveFile[0], null, true);
            choiceList.excelMerge2 = excelApp.Workbooks.Open(receiveFile[1], null, true);
            this.pnlMain.Controls.Add(choiceList);
            choiceList.Dock = System.Windows.Forms.DockStyle.Fill;
            */

            

        }

        

    }
}
