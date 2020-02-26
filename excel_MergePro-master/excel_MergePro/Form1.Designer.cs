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
            this.SuspendLayout();
            // 
            // txb_OpenFIle1
            // 
            this.txb_OpenFIle1.Location = new System.Drawing.Point(12, 90);
            this.txb_OpenFIle1.Name = "txb_OpenFIle1";
            this.txb_OpenFIle1.Size = new System.Drawing.Size(596, 20);
            this.txb_OpenFIle1.TabIndex = 0;
            // 
            // txb_OpenFIle2
            // 
            this.txb_OpenFIle2.Location = new System.Drawing.Point(814, 91);
            this.txb_OpenFIle2.Name = "txb_OpenFIle2";
            this.txb_OpenFIle2.Size = new System.Drawing.Size(596, 20);
            this.txb_OpenFIle2.TabIndex = 1;
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.Location = new System.Drawing.Point(614, 88);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(194, 23);
            this.btnOpenFile.TabIndex = 2;
            this.btnOpenFile.Text = "파일열기";
            this.btnOpenFile.UseVisualStyleBackColor = true;
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFileClick);
            // 
            // btnMergeFile
            // 
            this.btnMergeFile.Location = new System.Drawing.Point(614, 136);
            this.btnMergeFile.Name = "btnMergeFile";
            this.btnMergeFile.Size = new System.Drawing.Size(194, 23);
            this.btnMergeFile.TabIndex = 4;
            this.btnMergeFile.Text = "파일 병합";
            this.btnMergeFile.UseVisualStyleBackColor = true;
            this.btnMergeFile.Click += new System.EventHandler(this.btnMergeFile_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1422, 787);
            this.Controls.Add(this.btnMergeFile);
            this.Controls.Add(this.btnOpenFile);
            this.Controls.Add(this.txb_OpenFIle2);
            this.Controls.Add(this.txb_OpenFIle1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txb_OpenFIle1;
        private System.Windows.Forms.TextBox txb_OpenFIle2;
        private System.Windows.Forms.Button btnOpenFile;
        private System.Windows.Forms.Button btnMergeFile;
    }
}

