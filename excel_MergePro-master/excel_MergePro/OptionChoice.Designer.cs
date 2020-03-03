namespace excel_MergePro
{
    partial class OptionChoice
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
            this.pnlOptionMain = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // pnlOptionMain
            // 
            this.pnlOptionMain.Location = new System.Drawing.Point(13, 13);
            this.pnlOptionMain.Name = "pnlOptionMain";
            this.pnlOptionMain.Size = new System.Drawing.Size(669, 415);
            this.pnlOptionMain.TabIndex = 0;
            // 
            // OptionChoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(694, 440);
            this.Controls.Add(this.pnlOptionMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "OptionChoice";
            this.Text = "OptionChoice";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlOptionMain;
    }
}