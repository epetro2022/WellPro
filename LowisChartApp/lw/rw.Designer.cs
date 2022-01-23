namespace LowisChartApp.lw
{
    partial class rw
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

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnWrite = new System.Windows.Forms.Button();
            this.btnRead = new System.Windows.Forms.Button();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.btnConnect = new System.Windows.Forms.Button();
            this.txtWriteVal = new System.Windows.Forms.TextBox();
            this.txtReadVal = new System.Windows.Forms.TextBox();
            this.txtItem = new System.Windows.Forms.TextBox();
            this.txtServer = new System.Windows.Forms.TextBox();
            this.txtServerName = new System.Windows.Forms.TextBox();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.dataOPC = new System.Windows.Forms.DataGridView();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtRate = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnMonitoringOff = new System.Windows.Forms.Button();
            this.btnMonitoringOn = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button6 = new System.Windows.Forms.Button();
            this.GroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataOPC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnWrite
            // 
            this.btnWrite.Location = new System.Drawing.Point(146, 314);
            this.btnWrite.Name = "btnWrite";
            this.btnWrite.Size = new System.Drawing.Size(111, 35);
            this.btnWrite.TabIndex = 23;
            this.btnWrite.Text = "Write";
            this.btnWrite.UseVisualStyleBackColor = true;
            this.btnWrite.Click += new System.EventHandler(this.btnWrite_Click);
            // 
            // btnRead
            // 
            this.btnRead.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnRead.Location = new System.Drawing.Point(33, 260);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(111, 35);
            this.btnRead.TabIndex = 21;
            this.btnRead.Text = "Read";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // btnAddItem
            // 
            this.btnAddItem.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAddItem.Location = new System.Drawing.Point(33, 198);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(224, 35);
            this.btnAddItem.TabIndex = 20;
            this.btnAddItem.Text = "Set Item";
            this.btnAddItem.UseVisualStyleBackColor = true;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnDisconnect.Enabled = false;
            this.btnDisconnect.Location = new System.Drawing.Point(144, 113);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(111, 35);
            this.btnDisconnect.TabIndex = 18;
            this.btnDisconnect.Text = "Disconnect";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // btnConnect
            // 
            this.btnConnect.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnConnect.Location = new System.Drawing.Point(33, 113);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(111, 35);
            this.btnConnect.TabIndex = 17;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // txtWriteVal
            // 
            this.txtWriteVal.Location = new System.Drawing.Point(33, 314);
            this.txtWriteVal.Name = "txtWriteVal";
            this.txtWriteVal.Size = new System.Drawing.Size(96, 21);
            this.txtWriteVal.TabIndex = 22;
            // 
            // txtReadVal
            // 
            this.txtReadVal.Location = new System.Drawing.Point(164, 263);
            this.txtReadVal.Name = "txtReadVal";
            this.txtReadVal.Size = new System.Drawing.Size(96, 21);
            this.txtReadVal.TabIndex = 24;
            // 
            // txtItem
            // 
            this.txtItem.Location = new System.Drawing.Point(101, 172);
            this.txtItem.Name = "txtItem";
            this.txtItem.Size = new System.Drawing.Size(432, 21);
            this.txtItem.TabIndex = 19;
            this.txtItem.Text = "2P38A.LastPumpOnCardData";
            // 
            // txtServer
            // 
            this.txtServer.Location = new System.Drawing.Point(99, 16);
            this.txtServer.Name = "txtServer";
            this.txtServer.Size = new System.Drawing.Size(156, 21);
            this.txtServer.TabIndex = 25;
            this.txtServer.Text = "127.0.0.1";
            // 
            // txtServerName
            // 
            this.txtServerName.Location = new System.Drawing.Point(99, 64);
            this.txtServerName.Name = "txtServerName";
            this.txtServerName.Size = new System.Drawing.Size(156, 21);
            this.txtServerName.TabIndex = 11;
            this.txtServerName.Text = "asi.OPC";
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Location = new System.Drawing.Point(30, 337);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(70, 13);
            this.Label5.TabIndex = 12;
            this.Label5.Text = "(Write value)";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(30, 175);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(53, 13);
            this.Label3.TabIndex = 13;
            this.Label3.Text = "OPC Item";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(158, 285);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(69, 13);
            this.Label4.TabIndex = 10;
            this.Label4.Text = "(Read value)";
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Location = new System.Drawing.Point(96, 87);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(101, 13);
            this.Label6.TabIndex = 15;
            this.Label6.Text = "(OPC Server Name)";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(96, 39);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(133, 13);
            this.Label2.TabIndex = 16;
            this.Label2.Text = "(Host name or IP address)";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(30, 19);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(63, 13);
            this.Label1.TabIndex = 14;
            this.Label1.Text = "OPC Server";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(8, 353);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 26;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // GroupBox2
            // 
            this.GroupBox2.Controls.Add(this.dataOPC);
            this.GroupBox2.Controls.Add(this.txtRate);
            this.GroupBox2.Controls.Add(this.label7);
            this.GroupBox2.Controls.Add(this.label8);
            this.GroupBox2.Controls.Add(this.button2);
            this.GroupBox2.Controls.Add(this.button3);
            this.GroupBox2.Controls.Add(this.btnMonitoringOff);
            this.GroupBox2.Controls.Add(this.btnMonitoringOn);
            this.GroupBox2.Location = new System.Drawing.Point(609, 19);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new System.Drawing.Size(744, 602);
            this.GroupBox2.TabIndex = 27;
            this.GroupBox2.TabStop = false;
            // 
            // dataOPC
            // 
            this.dataOPC.BackgroundColor = System.Drawing.Color.Beige;
            this.dataOPC.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 8.25F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataOPC.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataOPC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataOPC.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column3,
            this.ColumnItem,
            this.Column1,
            this.ColumnValue,
            this.Column2});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Tahoma", 8.25F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataOPC.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataOPC.Enabled = false;
            this.dataOPC.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataOPC.Location = new System.Drawing.Point(19, 38);
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
            this.dataOPC.Size = new System.Drawing.Size(706, 434);
            this.dataOPC.TabIndex = 9;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "No.";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 30;
            // 
            // ColumnItem
            // 
            this.ColumnItem.HeaderText = "Description";
            this.ColumnItem.Name = "ColumnItem";
            this.ColumnItem.ReadOnly = true;
            this.ColumnItem.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ColumnItem.Width = 470;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Address";
            this.Column1.Name = "Column1";
            this.Column1.Width = 50;
            // 
            // ColumnValue
            // 
            this.ColumnValue.HeaderText = "Host";
            this.ColumnValue.Name = "ColumnValue";
            this.ColumnValue.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ColumnValue.Width = 50;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "RTU";
            this.Column2.Name = "Column2";
            this.Column2.Width = 50;
            // 
            // txtRate
            // 
            this.txtRate.Location = new System.Drawing.Point(186, 524);
            this.txtRate.Name = "txtRate";
            this.txtRate.Size = new System.Drawing.Size(68, 21);
            this.txtRate.TabIndex = 8;
            this.txtRate.Text = "1000";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(73, 527);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Monitoring Rate (ms):";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Monitoring Items:";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Control;
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(186, 478);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(161, 29);
            this.button2.TabIndex = 4;
            this.button2.Text = "Write";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.Control;
            this.button3.Enabled = false;
            this.button3.Location = new System.Drawing.Point(19, 478);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(161, 29);
            this.button3.TabIndex = 4;
            this.button3.Text = "Read";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnMonitoringOff
            // 
            this.btnMonitoringOff.BackColor = System.Drawing.SystemColors.Control;
            this.btnMonitoringOff.Enabled = false;
            this.btnMonitoringOff.Location = new System.Drawing.Point(186, 556);
            this.btnMonitoringOff.Name = "btnMonitoringOff";
            this.btnMonitoringOff.Size = new System.Drawing.Size(161, 29);
            this.btnMonitoringOff.TabIndex = 4;
            this.btnMonitoringOff.Text = "Monitoring OFF";
            this.btnMonitoringOff.UseVisualStyleBackColor = false;
            // 
            // btnMonitoringOn
            // 
            this.btnMonitoringOn.BackColor = System.Drawing.SystemColors.Control;
            this.btnMonitoringOn.Enabled = false;
            this.btnMonitoringOn.Location = new System.Drawing.Point(19, 556);
            this.btnMonitoringOn.Name = "btnMonitoringOn";
            this.btnMonitoringOn.Size = new System.Drawing.Size(161, 29);
            this.btnMonitoringOn.TabIndex = 4;
            this.btnMonitoringOn.Text = "Monitoring ON";
            this.btnMonitoringOn.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(20, 382);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 28;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(144, 368);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 29;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(20, 454);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(564, 217);
            this.dataGridView1.TabIndex = 30;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(25, 424);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 31;
            this.button6.Text = "button6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // rw
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button6);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.GroupBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnWrite);
            this.Controls.Add(this.btnRead);
            this.Controls.Add(this.btnAddItem);
            this.Controls.Add(this.btnDisconnect);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.txtWriteVal);
            this.Controls.Add(this.txtReadVal);
            this.Controls.Add(this.txtItem);
            this.Controls.Add(this.txtServer);
            this.Controls.Add(this.txtServerName);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.Label6);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Name = "rw";
            this.Size = new System.Drawing.Size(1412, 671);
            this.GroupBox2.ResumeLayout(false);
            this.GroupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataOPC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void DataOPC_CellBeginEdit(object sender, System.Windows.Forms.DataGridViewCellCancelEventArgs e)
        {
            throw new System.NotImplementedException();
        }

        internal System.Windows.Forms.Button btnWrite;
        internal System.Windows.Forms.Button btnRead;
        internal System.Windows.Forms.Button btnAddItem;
        internal System.Windows.Forms.Button btnDisconnect;
        internal System.Windows.Forms.Button btnConnect;
        internal System.Windows.Forms.TextBox txtWriteVal;
        internal System.Windows.Forms.TextBox txtReadVal;
        internal System.Windows.Forms.TextBox txtItem;
        internal System.Windows.Forms.TextBox txtServer;
        internal System.Windows.Forms.TextBox txtServerName;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Button button1;
        internal System.Windows.Forms.GroupBox GroupBox2;
        internal System.Windows.Forms.DataGridView dataOPC;
        internal System.Windows.Forms.TextBox txtRate;
        internal System.Windows.Forms.Label label7;
        internal System.Windows.Forms.Label label8;
        internal System.Windows.Forms.Button button2;
        internal System.Windows.Forms.Button button3;
        internal System.Windows.Forms.Button btnMonitoringOff;
        internal System.Windows.Forms.Button btnMonitoringOn;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button6;
    }
}