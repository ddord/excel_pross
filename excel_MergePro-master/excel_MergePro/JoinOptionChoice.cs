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
    }
}
