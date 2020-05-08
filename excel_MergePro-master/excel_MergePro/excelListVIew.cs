using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace excel_MergePro
{
    public partial class excelListView : UserControl
    {
        public DataTable ExcelListDT = new DataTable();
        public string excelFileName = "";

        public excelListView()
        {
            InitializeComponent();
        }



        public void excelGridViewDraw()
        {

        }

        private void excelListView_Load(object sender, EventArgs e)
        {
            dgvExcelList.DataSource = ExcelListDT;
            lblExFileName.Text = excelFileName;
        }
    }
}
