namespace excel_MergePro
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txb_OpenFIle1 = new System.Windows.Forms.TextBox();
            this.txb_OpenFIle2 = new System.Windows.Forms.TextBox();
            this.btnOpenFile = new System.Windows.Forms.Button();
            this.btnMergeFile = new System.Windows.Forms.Button();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.clbAddFileList = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // txb_OpenFIle1
            // 
            this.txb_OpenFIle1.BackColor = System.Drawing.Color.White;
            this.txb_OpenFIle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_OpenFIle1.ForeColor = System.Drawing.Color.Silver;
            this.txb_OpenFIle1.Location = new System.Drawing.Point(12, 12);
            this.txb_OpenFIle1.Name = "txb_OpenFIle1";
            this.txb_OpenFIle1.Size = new System.Drawing.Size(596, 22);
            this.txb_OpenFIle1.TabIndex = 0;
            this.txb_OpenFIle1.Text = "클릭 하시오";
            this.txb_OpenFIle1.TextChanged += new System.EventHandler(this.txb_OpenFIle1_TextChanged);
            // 
            // txb_OpenFIle2
            // 
            this.txb_OpenFIle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_OpenFIle2.ForeColor = System.Drawing.Color.Silver;
            this.txb_OpenFIle2.Location = new System.Drawing.Point(12, 69);
            this.txb_OpenFIle2.Name = "txb_OpenFIle2";
            this.txb_OpenFIle2.Size = new System.Drawing.Size(596, 22);
            this.txb_OpenFIle2.TabIndex = 1;
            this.txb_OpenFIle2.Text = "클릭 하시오";
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.Location = new System.Drawing.Point(614, 12);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(194, 29);
            this.btnOpenFile.TabIndex = 2;
            this.btnOpenFile.Text = "파일열기";
            this.btnOpenFile.UseVisualStyleBackColor = true;
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFileClick);
            // 
            // btnMergeFile
            // 
            this.btnMergeFile.Location = new System.Drawing.Point(614, 62);
            this.btnMergeFile.Name = "btnMergeFile";
            this.btnMergeFile.Size = new System.Drawing.Size(194, 29);
            this.btnMergeFile.TabIndex = 4;
            this.btnMergeFile.Text = "파일 병합";
            this.btnMergeFile.UseVisualStyleBackColor = true;
            this.btnMergeFile.Click += new System.EventHandler(this.btnMergeFile_Click);
            // 
            // pnlMain
            // 
            this.pnlMain.Location = new System.Drawing.Point(12, 117);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1400, 720);
            this.pnlMain.TabIndex = 5;
            // 
            // clbAddFileList
            // 
            this.clbAddFileList.ColumnWidth = 200;
            this.clbAddFileList.FormattingEnabled = true;
            this.clbAddFileList.Location = new System.Drawing.Point(814, 12);
            this.clbAddFileList.MultiColumn = true;
            this.clbAddFileList.Name = "clbAddFileList";
            this.clbAddFileList.Size = new System.Drawing.Size(600, 79);
            this.clbAddFileList.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1422, 850);
            this.Controls.Add(this.clbAddFileList);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.btnMergeFile);
            this.Controls.Add(this.btnOpenFile);
            this.Controls.Add(this.txb_OpenFIle2);
            this.Controls.Add(this.txb_OpenFIle1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txb_OpenFIle1;
        private System.Windows.Forms.TextBox txb_OpenFIle2;
        private System.Windows.Forms.Button btnOpenFile;
        private System.Windows.Forms.Button btnMergeFile;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.CheckedListBox clbAddFileList;
    }
}

