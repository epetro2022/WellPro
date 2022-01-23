namespace LowisChartApp.lw
{
    partial class TmpTest
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
            this.pgbUpdateMarks = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // pgbUpdateMarks
            // 
            this.pgbUpdateMarks.Location = new System.Drawing.Point(106, 90);
            this.pgbUpdateMarks.Name = "pgbUpdateMarks";
            this.pgbUpdateMarks.Size = new System.Drawing.Size(100, 23);
            this.pgbUpdateMarks.TabIndex = 0;
            // 
            // TmpTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pgbUpdateMarks);
            this.Name = "TmpTest";
            this.Size = new System.Drawing.Size(531, 298);
            this.Load += new System.EventHandler(this.TmpTest_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ProgressBar pgbUpdateMarks;
    }
}
