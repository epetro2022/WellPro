namespace LowisChartApp.lw
{
    partial class BeamWellCurrentStatus
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BeamWellCurrentStatus));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.lblpoc = new System.Windows.Forms.Label();
            this.lblMotorStatus = new System.Windows.Forms.Label();
            this.btn_clear_Alarm = new System.Windows.Forms.Button();
            this.lblPOC_Mode = new System.Windows.Forms.Label();
            this.ss = new System.Windows.Forms.Label();
            this.dataOPC = new System.Windows.Forms.DataGridView();
            this.ColumnItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alias = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coladdress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colrtu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colfunction = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_scan = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.lblWellName = new System.Windows.Forms.Label();
            this.label45 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.splashScreenManager1 = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::LowisChartApp.lw.WaitForm1), true, true, typeof(System.Windows.Forms.UserControl));
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataOPC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Appearance.BackColor = System.Drawing.Color.White;
            this.xtraTabControl1.Appearance.Options.UseBackColor = true;
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl1.Location = new System.Drawing.Point(0, 0);
            this.xtraTabControl1.LookAndFeel.SkinMaskColor = System.Drawing.Color.White;
            this.xtraTabControl1.LookAndFeel.SkinMaskColor2 = System.Drawing.Color.White;
            this.xtraTabControl1.LookAndFeel.UseDefaultLookAndFeel = false;
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(1418, 843);
            this.xtraTabControl1.TabIndex = 1;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage2});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Appearance.PageClient.BackColor = System.Drawing.Color.White;
            this.xtraTabPage1.Appearance.PageClient.Options.UseBackColor = true;
            this.xtraTabPage1.Controls.Add(this.lblpoc);
            this.xtraTabPage1.Controls.Add(this.lblMotorStatus);
            this.xtraTabPage1.Controls.Add(this.btn_clear_Alarm);
            this.xtraTabPage1.Controls.Add(this.lblPOC_Mode);
            this.xtraTabPage1.Controls.Add(this.ss);
            this.xtraTabPage1.Controls.Add(this.dataOPC);
            this.xtraTabPage1.Controls.Add(this.btn_scan);
            this.xtraTabPage1.Controls.Add(this.btnStop);
            this.xtraTabPage1.Controls.Add(this.btnStart);
            this.xtraTabPage1.Controls.Add(this.lblWellName);
            this.xtraTabPage1.Controls.Add(this.label45);
            this.xtraTabPage1.Controls.Add(this.pictureBox1);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(1416, 818);
            this.xtraTabPage1.Text = "Well Current Status";
            this.xtraTabPage1.Paint += new System.Windows.Forms.PaintEventHandler(this.xtraTabPage1_Paint);
            // 
            // lblpoc
            // 
            this.lblpoc.AutoSize = true;
            this.lblpoc.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpoc.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblpoc.Location = new System.Drawing.Point(156, 134);
            this.lblpoc.Name = "lblpoc";
            this.lblpoc.Size = new System.Drawing.Size(0, 14);
            this.lblpoc.TabIndex = 397;
            // 
            // lblMotorStatus
            // 
            this.lblMotorStatus.AutoSize = true;
            this.lblMotorStatus.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMotorStatus.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblMotorStatus.Location = new System.Drawing.Point(156, 118);
            this.lblMotorStatus.Name = "lblMotorStatus";
            this.lblMotorStatus.Size = new System.Drawing.Size(0, 14);
            this.lblMotorStatus.TabIndex = 396;
            // 
            // btn_clear_Alarm
            // 
            this.btn_clear_Alarm.ForeColor = System.Drawing.Color.Black;
            this.btn_clear_Alarm.Image = ((System.Drawing.Image)(resources.GetObject("btn_clear_Alarm.Image")));
            this.btn_clear_Alarm.Location = new System.Drawing.Point(209, 30);
            this.btn_clear_Alarm.Name = "btn_clear_Alarm";
            this.btn_clear_Alarm.Size = new System.Drawing.Size(44, 48);
            this.btn_clear_Alarm.TabIndex = 395;
            this.btn_clear_Alarm.UseVisualStyleBackColor = true;
            this.btn_clear_Alarm.Click += new System.EventHandler(this.btn_clear_Alarm_Click);
            // 
            // lblPOC_Mode
            // 
            this.lblPOC_Mode.AutoSize = true;
            this.lblPOC_Mode.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPOC_Mode.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblPOC_Mode.Location = new System.Drawing.Point(50, 134);
            this.lblPOC_Mode.Name = "lblPOC_Mode";
            this.lblPOC_Mode.Size = new System.Drawing.Size(100, 14);
            this.lblPOC_Mode.TabIndex = 394;
            this.lblPOC_Mode.Text = "POC Mode     :";
            // 
            // ss
            // 
            this.ss.AutoSize = true;
            this.ss.BackColor = System.Drawing.Color.Transparent;
            this.ss.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ss.ForeColor = System.Drawing.SystemColors.Highlight;
            this.ss.Location = new System.Drawing.Point(50, 118);
            this.ss.Name = "ss";
            this.ss.Size = new System.Drawing.Size(100, 14);
            this.ss.TabIndex = 393;
            this.ss.Text = "Motor Status :";
            // 
            // dataOPC
            // 
            this.dataOPC.BackgroundColor = System.Drawing.Color.White;
            this.dataOPC.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 8.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataOPC.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataOPC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataOPC.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnItem,
            this.alias,
            this.coladdress,
            this.colrtu,
            this.colfunction});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Ivory;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Tahoma", 8.25F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataOPC.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataOPC.Enabled = false;
            this.dataOPC.GridColor = System.Drawing.Color.Black;
            this.dataOPC.Location = new System.Drawing.Point(856, 30);
            this.dataOPC.Name = "dataOPC";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Tahoma", 8.25F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataOPC.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataOPC.RowHeadersWidth = 30;
            this.dataOPC.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataOPC.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataOPC.Size = new System.Drawing.Size(557, 775);
            this.dataOPC.TabIndex = 392;
            // 
            // ColumnItem
            // 
            this.ColumnItem.HeaderText = "Description";
            this.ColumnItem.Name = "ColumnItem";
            this.ColumnItem.ReadOnly = true;
            this.ColumnItem.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ColumnItem.Visible = false;
            this.ColumnItem.Width = 390;
            // 
            // alias
            // 
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Coral;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            this.alias.DefaultCellStyle = dataGridViewCellStyle2;
            this.alias.HeaderText = "Description";
            this.alias.Name = "alias";
            this.alias.ReadOnly = true;
            this.alias.Width = 250;
            // 
            // coladdress
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.coladdress.DefaultCellStyle = dataGridViewCellStyle3;
            this.coladdress.HeaderText = "Address";
            this.coladdress.Name = "coladdress";
            this.coladdress.ReadOnly = true;
            this.coladdress.Visible = false;
            this.coladdress.Width = 80;
            // 
            // colrtu
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.colrtu.DefaultCellStyle = dataGridViewCellStyle4;
            this.colrtu.HeaderText = "Value";
            this.colrtu.Name = "colrtu";
            this.colrtu.ReadOnly = true;
            this.colrtu.Width = 250;
            // 
            // colfunction
            // 
            this.colfunction.HeaderText = "function";
            this.colfunction.Name = "colfunction";
            this.colfunction.Visible = false;
            this.colfunction.Width = 200;
            // 
            // btn_scan
            // 
            this.btn_scan.ForeColor = System.Drawing.Color.Black;
            this.btn_scan.Image = ((System.Drawing.Image)(resources.GetObject("btn_scan.Image")));
            this.btn_scan.Location = new System.Drawing.Point(153, 30);
            this.btn_scan.Name = "btn_scan";
            this.btn_scan.Size = new System.Drawing.Size(44, 48);
            this.btn_scan.TabIndex = 391;
            this.btn_scan.UseVisualStyleBackColor = true;
            this.btn_scan.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnStop
            // 
            this.btnStop.Image = ((System.Drawing.Image)(resources.GetObject("btnStop.Image")));
            this.btnStop.Location = new System.Drawing.Point(96, 30);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(44, 48);
            this.btnStop.TabIndex = 390;
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnStart
            // 
            this.btnStart.Image = ((System.Drawing.Image)(resources.GetObject("btnStart.Image")));
            this.btnStart.Location = new System.Drawing.Point(53, 30);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(44, 48);
            this.btnStart.TabIndex = 389;
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lblWellName
            // 
            this.lblWellName.AutoSize = true;
            this.lblWellName.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWellName.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblWellName.Location = new System.Drawing.Point(137, 4);
            this.lblWellName.Name = "lblWellName";
            this.lblWellName.Size = new System.Drawing.Size(32, 14);
            this.lblWellName.TabIndex = 387;
            this.lblWellName.Text = "well";
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label45.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label45.Location = new System.Drawing.Point(50, 4);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(92, 14);
            this.label45.TabIndex = 386;
            this.label45.Text = "Well Name  :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(53, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(804, 628);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 279;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Appearance.PageClient.BackColor = System.Drawing.Color.Black;
            this.xtraTabPage2.Appearance.PageClient.Options.UseBackColor = true;
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(1416, 818);
            this.xtraTabPage2.Text = "Well Current Status Detail";
            // 
            // splashScreenManager1
            // 
            this.splashScreenManager1.ClosingDelay = 500;
            // 
            // BeamWellCurrentStatus
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.xtraTabControl1);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "BeamWellCurrentStatus";
            this.Size = new System.Drawing.Size(1418, 843);
            this.Load += new System.EventHandler(this.BeamWellCurrentStatus_Load);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            this.xtraTabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataOPC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        public System.Windows.Forms.Label lblWellName;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btn_scan;
        internal System.Windows.Forms.DataGridView dataOPC;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn alias;
        private System.Windows.Forms.DataGridViewTextBoxColumn coladdress;
        private System.Windows.Forms.DataGridViewTextBoxColumn colrtu;
        private System.Windows.Forms.DataGridViewTextBoxColumn colfunction;
        private System.Windows.Forms.Label lblPOC_Mode;
        private System.Windows.Forms.Label ss;
        private System.Windows.Forms.Button btn_clear_Alarm;
        private System.Windows.Forms.Label lblpoc;
        private System.Windows.Forms.Label lblMotorStatus;
    }
}
