namespace excel_MergePro
{
    partial class JoinOptionChoice
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
            this.cbSelectTable = new System.Windows.Forms.ComboBox();
            this.lblStandard = new System.Windows.Forms.Label();
            this.clbJoinFile2 = new System.Windows.Forms.CheckedListBox();
            this.clbJoinFile1 = new System.Windows.Forms.CheckedListBox();
            this.lblTableKey1 = new System.Windows.Forms.Label();
            this.lblTableKey2 = new System.Windows.Forms.Label();
            this.btnJoinTable = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbSelectTable
            // 
            this.cbSelectTable.FormattingEnabled = true;
            this.cbSelectTable.Location = new System.Drawing.Point(153, 17);
            this.cbSelectTable.Name = "cbSelectTable";
            this.cbSelectTable.Size = new System.Drawing.Size(133, 21);
            this.cbSelectTable.TabIndex = 0;
            // 
            // lblStandard
            // 
            this.lblStandard.AutoSize = true;
            this.lblStandard.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStandard.ForeColor = System.Drawing.Color.White;
            this.lblStandard.Location = new System.Drawing.Point(68, 19);
            this.lblStandard.Name = "lblStandard";
            this.lblStandard.Size = new System.Drawing.Size(76, 16);
            this.lblStandard.TabIndex = 1;
            this.lblStandard.Text = "기준 테이블 -";
            // 
            // clbJoinFile2
            // 
            this.clbJoinFile2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clbJoinFile2.FormattingEnabled = true;
            this.clbJoinFile2.Location = new System.Drawing.Point(209, 81);
            this.clbJoinFile2.Name = "clbJoinFile2";
            this.clbJoinFile2.Size = new System.Drawing.Size(190, 191);
            this.clbJoinFile2.TabIndex = 4;
            // 
            // clbJoinFile1
            // 
            this.clbJoinFile1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clbJoinFile1.FormattingEnabled = true;
            this.clbJoinFile1.Location = new System.Drawing.Point(3, 81);
            this.clbJoinFile1.Name = "clbJoinFile1";
            this.clbJoinFile1.Size = new System.Drawing.Size(190, 191);
            this.clbJoinFile1.TabIndex = 3;
            // 
            // lblTableKey1
            // 
            this.lblTableKey1.AutoSize = true;
            this.lblTableKey1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTableKey1.ForeColor = System.Drawing.Color.White;
            this.lblTableKey1.Location = new System.Drawing.Point(3, 62);
            this.lblTableKey1.Name = "lblTableKey1";
            this.lblTableKey1.Size = new System.Drawing.Size(127, 16);
            this.lblTableKey1.TabIndex = 5;
            this.lblTableKey1.Text = "병합 테이블1 키값 선택";
            // 
            // lblTableKey2
            // 
            this.lblTableKey2.AutoSize = true;
            this.lblTableKey2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTableKey2.ForeColor = System.Drawing.Color.White;
            this.lblTableKey2.Location = new System.Drawing.Point(210, 62);
            this.lblTableKey2.Name = "lblTableKey2";
            this.lblTableKey2.Size = new System.Drawing.Size(127, 16);
            this.lblTableKey2.TabIndex = 6;
            this.lblTableKey2.Text = "병합 테이블2 키값 선택";
            // 
            // btnJoinTable
            // 
            this.btnJoinTable.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnJoinTable.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnJoinTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJoinTable.Location = new System.Drawing.Point(3, 278);
            this.btnJoinTable.Name = "btnJoinTable";
            this.btnJoinTable.Size = new System.Drawing.Size(396, 42);
            this.btnJoinTable.TabIndex = 7;
            this.btnJoinTable.Text = "병합";
            this.btnJoinTable.UseVisualStyleBackColor = false;
            // 
            // JoinOptionChoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.btnJoinTable);
            this.Controls.Add(this.lblTableKey2);
            this.Controls.Add(this.lblTableKey1);
            this.Controls.Add(this.clbJoinFile2);
            this.Controls.Add(this.clbJoinFile1);
            this.Controls.Add(this.lblStandard);
            this.Controls.Add(this.cbSelectTable);
            this.Name = "JoinOptionChoice";
            this.Size = new System.Drawing.Size(402, 325);
            this.Load += new System.EventHandler(this.JoinOptionChoice_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbSelectTable;
        private System.Windows.Forms.Label lblStandard;
        private System.Windows.Forms.CheckedListBox clbJoinFile2;
        private System.Windows.Forms.CheckedListBox clbJoinFile1;
        private System.Windows.Forms.Label lblTableKey1;
        private System.Windows.Forms.Label lblTableKey2;
        private System.Windows.Forms.Button btnJoinTable;
    }
}
