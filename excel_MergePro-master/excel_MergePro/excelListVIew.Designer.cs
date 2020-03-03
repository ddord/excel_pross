namespace excel_MergePro
{
    partial class excelListView
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvExcelList = new System.Windows.Forms.DataGridView();
            this.lblExFileName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExcelList)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvExcelList
            // 
            this.dgvExcelList.AllowUserToAddRows = false;
            this.dgvExcelList.AllowUserToDeleteRows = false;
            this.dgvExcelList.AllowUserToOrderColumns = true;
            this.dgvExcelList.BackgroundColor = System.Drawing.Color.White;
            this.dgvExcelList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvExcelList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvExcelList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvExcelList.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvExcelList.EnableHeadersVisualStyles = false;
            this.dgvExcelList.GridColor = System.Drawing.Color.LightGray;
            this.dgvExcelList.Location = new System.Drawing.Point(0, 47);
            this.dgvExcelList.Name = "dgvExcelList";
            this.dgvExcelList.ReadOnly = true;
            this.dgvExcelList.RowHeadersVisible = false;
            this.dgvExcelList.Size = new System.Drawing.Size(350, 300);
            this.dgvExcelList.TabIndex = 0;
            // 
            // lblExFileName
            // 
            this.lblExFileName.AutoSize = true;
            this.lblExFileName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExFileName.Location = new System.Drawing.Point(0, 0);
            this.lblExFileName.Name = "lblExFileName";
            this.lblExFileName.Size = new System.Drawing.Size(51, 20);
            this.lblExFileName.TabIndex = 1;
            this.lblExFileName.Text = "label1";
            // 
            // excelListView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.lblExFileName);
            this.Controls.Add(this.dgvExcelList);
            this.Name = "excelListView";
            this.Size = new System.Drawing.Size(350, 350);
            this.Load += new System.EventHandler(this.excelListView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvExcelList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvExcelList;
        private System.Windows.Forms.Label lblExFileName;
    }
}
