namespace excel_MergePro
{
    partial class listChoice
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
            this.clbMergeFile1 = new System.Windows.Forms.CheckedListBox();
            this.lblmergFile1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.clbMergeFile2 = new System.Windows.Forms.CheckedListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // clbMergeFile1
            // 
            this.clbMergeFile1.FormattingEnabled = true;
            this.clbMergeFile1.Location = new System.Drawing.Point(15, 39);
            this.clbMergeFile1.Name = "clbMergeFile1";
            this.clbMergeFile1.Size = new System.Drawing.Size(190, 199);
            this.clbMergeFile1.TabIndex = 0;
            // 
            // lblmergFile1
            // 
            this.lblmergFile1.BackColor = System.Drawing.Color.Azure;
            this.lblmergFile1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblmergFile1.Font = new System.Drawing.Font("Microsoft Yi Baiti", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmergFile1.Location = new System.Drawing.Point(15, 13);
            this.lblmergFile1.Name = "lblmergFile1";
            this.lblmergFile1.Size = new System.Drawing.Size(190, 23);
            this.lblmergFile1.TabIndex = 1;
            this.lblmergFile1.Text = "병합 파일1";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Azure;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Yi Baiti", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(240, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "병합 파일2";
            // 
            // clbMergeFile2
            // 
            this.clbMergeFile2.FormattingEnabled = true;
            this.clbMergeFile2.Location = new System.Drawing.Point(240, 39);
            this.clbMergeFile2.Name = "clbMergeFile2";
            this.clbMergeFile2.Size = new System.Drawing.Size(190, 199);
            this.clbMergeFile2.TabIndex = 2;
            this.clbMergeFile2.SelectedIndexChanged += new System.EventHandler(this.MergFilesCheckList_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Azure;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(15, 244);
            this.button1.Name = "button1";
            this.button1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.button1.Size = new System.Drawing.Size(415, 39);
            this.button1.TabIndex = 4;
            this.button1.Text = "확    인";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // listChoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.clbMergeFile2);
            this.Controls.Add(this.lblmergFile1);
            this.Controls.Add(this.clbMergeFile1);
            this.Name = "listChoice";
            this.Size = new System.Drawing.Size(446, 300);
            this.Load += new System.EventHandler(this.listChoice_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox clbMergeFile1;
        private System.Windows.Forms.Label lblmergFile1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox clbMergeFile2;
        private System.Windows.Forms.Button button1;
    }
}
