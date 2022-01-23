namespace LowisChartApp.lw
{
    partial class BeamWellCurrentStatusMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BeamWellCurrentStatusMain));
            DevExpress.DataAccess.Sql.StoredProcQuery storedProcQuery1 = new DevExpress.DataAccess.Sql.StoredProcQuery();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter1 = new DevExpress.DataAccess.Sql.QueryParameter();
            this.prosedur_getdataESPWellgroupStatusTableAdapter = new LowisChartApp.lw2DataSet13TableAdapters.prosedur_getdataESPWellgroupStatusTableAdapter();
            this.prosedur_getdataWellGroupStatusTableAdapter = new LowisChartApp.lw2DataSet8TableAdapters.prosedur_getdataWellGroupStatusTableAdapter();
            this.panel2 = new System.Windows.Forms.Panel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnRefresh = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.btnSearch = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.btnFilter = new System.Windows.Forms.ToolStripButton();
            this.btnChart = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnScan = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnPOC = new System.Windows.Forms.ToolStripButton();
            this.btnContinous = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.Start = new System.Windows.Forms.ToolStripButton();
            this.BtnStop = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.btnHelp = new System.Windows.Forms.ToolStripButton();
            this.btnAcknowladge = new System.Windows.Forms.ToolStripButton();
            this.gdLowis = new DevExpress.XtraGrid.GridControl();
            this.gvLowis = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colWellName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colArea = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colScanTime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colScanDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAlarmMessage = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLastGoodScanTime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLastGoodScanDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHostMode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPOCMode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMotorStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colComment = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLastGoodTestOil = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLastGoodTestWater = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLastGoodTestTotalGas = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPOCardDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTodayRun = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colYestRun = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsetpointpos = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsetpointload = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colYestCycles = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSPM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTypeofSub_Controller = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOutofService = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCommToday = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCommYest = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCommPort = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPumpSLip = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPumpFill = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTodayInferredProd = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colYestInferredProd = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTubingPress = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCasingPress = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTubingtemp = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCasingtemp = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHeaderPress = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLastCurrentCardCollection = new DevExpress.XtraGrid.Columns.GridColumn();
            this.prosedurgetdataESPWellgroupStatusBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lw2DataSet13 = new LowisChartApp.lw2DataSet13();
            this.lw2DataSet8 = new LowisChartApp.lw2DataSet8();
            this.prosedurgetdataWellGroupStatusBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.prosedurgetdataBeamWellGroupConfigurationBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.lw2DataSet7 = new LowisChartApp.lw2DataSet7();
            this.lw2DataSet2 = new LowisChartApp.lw2DataSet2();
            this.prosedurgetdataBeamWellGroupConfigurationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.lw2DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.prosedurgetdataGroupDescreteConfigBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lw2DataSet1 = new LowisChartApp.lw2DataSet1();
            this.lw2DataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.prosedur_getdataBeamWellGroupConfigurationTableAdapter = new LowisChartApp.lw2DataSet2TableAdapters.prosedur_getdataBeamWellGroupConfigurationTableAdapter();
            this.lw2DataSet6 = new LowisChartApp.lw2DataSet6();
            this.prosedurgetdataBeamWellGroupConfigurationBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.prosedur_getdataBeamWellGroupConfigurationTableAdapter1 = new LowisChartApp.lw2DataSet6TableAdapters.prosedur_getdataBeamWellGroupConfigurationTableAdapter();
            this.prosedur_getdataBeamWellGroupConfigurationTableAdapter2 = new LowisChartApp.lw2DataSet7TableAdapters.prosedur_getdataBeamWellGroupConfigurationTableAdapter();
            this.prosedur_getdataGroupDescreteConfigTableAdapter = new LowisChartApp.lw2DataSet1TableAdapters.prosedur_getdataGroupDescreteConfigTableAdapter();
            this.prosedurgetdatabeamWellGroupStatusBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.prosedurgetdataWellGroupStatusBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.prosedurgetdataWellGroupStatusBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.lw2DataSet15 = new LowisChartApp.lw2DataSet15();
            this.lw2DataSet15BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.prosedurgetdatabeamWellGroupStatusBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.prosedur_getdatabeamWellGroupStatusTableAdapter = new LowisChartApp.lw2DataSet15TableAdapters.prosedur_getdatabeamWellGroupStatusTableAdapter();
            this.lw2DataSet16 = new LowisChartApp.lw2DataSet16();
            this.prosedurgetdatabeamWellGroupStatusBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.prosedur_getdatabeamWellGroupStatusTableAdapter1 = new LowisChartApp.lw2DataSet16TableAdapters.prosedur_getdatabeamWellGroupStatusTableAdapter();
            this.prosedurgetdatabeamWellGroupStatusBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.panel2.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdLowis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvLowis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prosedurgetdataESPWellgroupStatusBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lw2DataSet13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lw2DataSet8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prosedurgetdataWellGroupStatusBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prosedurgetdataBeamWellGroupConfigurationBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lw2DataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lw2DataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prosedurgetdataBeamWellGroupConfigurationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lw2DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prosedurgetdataGroupDescreteConfigBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lw2DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lw2DataSetBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lw2DataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prosedurgetdataBeamWellGroupConfigurationBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prosedurgetdatabeamWellGroupStatusBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prosedurgetdataWellGroupStatusBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prosedurgetdataWellGroupStatusBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lw2DataSet15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lw2DataSet15BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prosedurgetdatabeamWellGroupStatusBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lw2DataSet16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prosedurgetdatabeamWellGroupStatusBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prosedurgetdatabeamWellGroupStatusBindingSource3)).BeginInit();
            this.SuspendLayout();
            // 
            // prosedur_getdataESPWellgroupStatusTableAdapter
            // 
            this.prosedur_getdataESPWellgroupStatusTableAdapter.ClearBeforeFill = true;
            // 
            // prosedur_getdataWellGroupStatusTableAdapter
            // 
            this.prosedur_getdataWellGroupStatusTableAdapter.ClearBeforeFill = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.toolStrip1);
            this.panel2.Controls.Add(this.gdLowis);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 32);
            this.panel2.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1235, 446);
            this.panel2.TabIndex = 17;
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnRefresh,
            this.toolStripSeparator6,
            this.btnSearch,
            this.toolStripSeparator5,
            this.btnFilter,
            this.btnChart,
            this.toolStripSeparator2,
            this.btnScan,
            this.toolStripSeparator1,
            this.btnPOC,
            this.btnContinous,
            this.toolStripSeparator3,
            this.Start,
            this.BtnStop,
            this.toolStripSeparator4,
            this.btnHelp,
            this.btnAcknowladge});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStrip1.Size = new System.Drawing.Size(1235, 25);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnRefresh
            // 
            this.btnRefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Image")));
            this.btnRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(23, 22);
            this.btnRefresh.Text = "toolStripButton1";
            this.btnRefresh.ToolTipText = "Refresh";
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 25);
            // 
            // btnSearch
            // 
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(100, 25);
            this.btnSearch.Text = "Search";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // btnFilter
            // 
            this.btnFilter.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnFilter.Image = ((System.Drawing.Image)(resources.GetObject("btnFilter.Image")));
            this.btnFilter.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(23, 22);
            this.btnFilter.Text = "Filter";
            // 
            // btnChart
            // 
            this.btnChart.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnChart.Image = ((System.Drawing.Image)(resources.GetObject("btnChart.Image")));
            this.btnChart.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnChart.Name = "btnChart";
            this.btnChart.Size = new System.Drawing.Size(23, 22);
            this.btnChart.Text = "Chart";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // btnScan
            // 
            this.btnScan.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnScan.Image = ((System.Drawing.Image)(resources.GetObject("btnScan.Image")));
            this.btnScan.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnScan.Name = "btnScan";
            this.btnScan.Size = new System.Drawing.Size(23, 22);
            this.btnScan.Text = "Scan";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // btnPOC
            // 
            this.btnPOC.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnPOC.Image = ((System.Drawing.Image)(resources.GetObject("btnPOC.Image")));
            this.btnPOC.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPOC.Name = "btnPOC";
            this.btnPOC.Size = new System.Drawing.Size(23, 22);
            this.btnPOC.Text = "POC";
            // 
            // btnContinous
            // 
            this.btnContinous.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnContinous.Image = ((System.Drawing.Image)(resources.GetObject("btnContinous.Image")));
            this.btnContinous.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnContinous.Name = "btnContinous";
            this.btnContinous.Size = new System.Drawing.Size(23, 22);
            this.btnContinous.Text = "Continuous";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // Start
            // 
            this.Start.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Start.Image = global::LowisChartApp.Properties.Resources.Go;
            this.Start.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(23, 22);
            this.Start.Text = "Start";
            // 
            // BtnStop
            // 
            this.BtnStop.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnStop.Image = global::LowisChartApp.Properties.Resources.Stop_sign;
            this.BtnStop.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnStop.Name = "BtnStop";
            this.BtnStop.Size = new System.Drawing.Size(23, 22);
            this.BtnStop.Text = "Stop";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // btnHelp
            // 
            this.btnHelp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnHelp.Image = ((System.Drawing.Image)(resources.GetObject("btnHelp.Image")));
            this.btnHelp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(23, 22);
            this.btnHelp.Text = "Help";
            // 
            // btnAcknowladge
            // 
            this.btnAcknowladge.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAcknowladge.Image = ((System.Drawing.Image)(resources.GetObject("btnAcknowladge.Image")));
            this.btnAcknowladge.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAcknowladge.Name = "btnAcknowladge";
            this.btnAcknowladge.Size = new System.Drawing.Size(23, 22);
            this.btnAcknowladge.Text = "Acknowladge Alarms";
            // 
            // gdLowis
            // 
            this.gdLowis.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gdLowis.Location = new System.Drawing.Point(0, 0);
            this.gdLowis.MainView = this.gvLowis;
            this.gdLowis.Name = "gdLowis";
            this.gdLowis.Size = new System.Drawing.Size(1235, 446);
            this.gdLowis.TabIndex = 0;
            this.gdLowis.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvLowis});
            this.gdLowis.DoubleClick += new System.EventHandler(this.gdLowis_DoubleClick);
            // 
            // gvLowis
            // 
            this.gvLowis.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colWellName,
            this.colArea,
            this.colScanTime,
            this.colScanDate,
            this.colAlarmMessage,
            this.colLastGoodScanTime,
            this.colLastGoodScanDate,
            this.colHostMode,
            this.colPOCMode,
            this.colMotorStatus,
            this.colComment,
            this.colLastGoodTestOil,
            this.colLastGoodTestWater,
            this.colLastGoodTestTotalGas,
            this.colPOCardDate,
            this.colTodayRun,
            this.colYestRun,
            this.colsetpointpos,
            this.colsetpointload,
            this.colYestCycles,
            this.colSPM,
            this.colTypeofSub_Controller,
            this.colOutofService,
            this.colCommToday,
            this.colCommYest,
            this.colCommPort,
            this.colPumpSLip,
            this.colPumpFill,
            this.colTodayInferredProd,
            this.colYestInferredProd,
            this.colTubingPress,
            this.colCasingPress,
            this.colTubingtemp,
            this.colCasingtemp,
            this.colHeaderPress,
            this.colLastCurrentCardCollection});
            this.gvLowis.GridControl = this.gdLowis;
            this.gvLowis.Name = "gvLowis";
            this.gvLowis.OptionsBehavior.Editable = false;
            this.gvLowis.OptionsView.ColumnAutoWidth = false;
            // 
            // colWellName
            // 
            this.colWellName.FieldName = "WellName";
            this.colWellName.Name = "colWellName";
            this.colWellName.Visible = true;
            this.colWellName.VisibleIndex = 0;
            // 
            // colArea
            // 
            this.colArea.FieldName = "Area";
            this.colArea.Name = "colArea";
            this.colArea.Visible = true;
            this.colArea.VisibleIndex = 1;
            // 
            // colScanTime
            // 
            this.colScanTime.FieldName = "ScanTime";
            this.colScanTime.Name = "colScanTime";
            this.colScanTime.Visible = true;
            this.colScanTime.VisibleIndex = 2;
            // 
            // colScanDate
            // 
            this.colScanDate.FieldName = "ScanDate";
            this.colScanDate.Name = "colScanDate";
            this.colScanDate.Visible = true;
            this.colScanDate.VisibleIndex = 3;
            // 
            // colAlarmMessage
            // 
            this.colAlarmMessage.FieldName = "AlarmMessage";
            this.colAlarmMessage.Name = "colAlarmMessage";
            this.colAlarmMessage.Visible = true;
            this.colAlarmMessage.VisibleIndex = 4;
            // 
            // colLastGoodScanTime
            // 
            this.colLastGoodScanTime.FieldName = "LastGoodScanTime";
            this.colLastGoodScanTime.Name = "colLastGoodScanTime";
            this.colLastGoodScanTime.Visible = true;
            this.colLastGoodScanTime.VisibleIndex = 5;
            // 
            // colLastGoodScanDate
            // 
            this.colLastGoodScanDate.FieldName = "LastGoodScanDate";
            this.colLastGoodScanDate.Name = "colLastGoodScanDate";
            this.colLastGoodScanDate.Visible = true;
            this.colLastGoodScanDate.VisibleIndex = 6;
            // 
            // colHostMode
            // 
            this.colHostMode.FieldName = "HostMode";
            this.colHostMode.Name = "colHostMode";
            this.colHostMode.Visible = true;
            this.colHostMode.VisibleIndex = 7;
            // 
            // colPOCMode
            // 
            this.colPOCMode.FieldName = "POCMode";
            this.colPOCMode.Name = "colPOCMode";
            this.colPOCMode.Visible = true;
            this.colPOCMode.VisibleIndex = 8;
            // 
            // colMotorStatus
            // 
            this.colMotorStatus.FieldName = "MotorStatus";
            this.colMotorStatus.Name = "colMotorStatus";
            this.colMotorStatus.Visible = true;
            this.colMotorStatus.VisibleIndex = 9;
            // 
            // colComment
            // 
            this.colComment.FieldName = "Comment";
            this.colComment.Name = "colComment";
            this.colComment.Visible = true;
            this.colComment.VisibleIndex = 10;
            // 
            // colLastGoodTestOil
            // 
            this.colLastGoodTestOil.FieldName = "LastGoodTestOil";
            this.colLastGoodTestOil.Name = "colLastGoodTestOil";
            this.colLastGoodTestOil.Visible = true;
            this.colLastGoodTestOil.VisibleIndex = 11;
            // 
            // colLastGoodTestWater
            // 
            this.colLastGoodTestWater.FieldName = "LastGoodTestWater";
            this.colLastGoodTestWater.Name = "colLastGoodTestWater";
            this.colLastGoodTestWater.Visible = true;
            this.colLastGoodTestWater.VisibleIndex = 12;
            // 
            // colLastGoodTestTotalGas
            // 
            this.colLastGoodTestTotalGas.FieldName = "LastGoodTestTotalGas";
            this.colLastGoodTestTotalGas.Name = "colLastGoodTestTotalGas";
            this.colLastGoodTestTotalGas.Visible = true;
            this.colLastGoodTestTotalGas.VisibleIndex = 13;
            // 
            // colPOCardDate
            // 
            this.colPOCardDate.FieldName = "POCardDate";
            this.colPOCardDate.Name = "colPOCardDate";
            this.colPOCardDate.Visible = true;
            this.colPOCardDate.VisibleIndex = 14;
            // 
            // colTodayRun
            // 
            this.colTodayRun.FieldName = "TodayRun";
            this.colTodayRun.Name = "colTodayRun";
            this.colTodayRun.Visible = true;
            this.colTodayRun.VisibleIndex = 15;
            // 
            // colYestRun
            // 
            this.colYestRun.FieldName = "YestRun";
            this.colYestRun.Name = "colYestRun";
            this.colYestRun.Visible = true;
            this.colYestRun.VisibleIndex = 16;
            // 
            // colsetpointpos
            // 
            this.colsetpointpos.FieldName = "setpointpos";
            this.colsetpointpos.Name = "colsetpointpos";
            this.colsetpointpos.Visible = true;
            this.colsetpointpos.VisibleIndex = 17;
            // 
            // colsetpointload
            // 
            this.colsetpointload.FieldName = "setpointload";
            this.colsetpointload.Name = "colsetpointload";
            this.colsetpointload.Visible = true;
            this.colsetpointload.VisibleIndex = 18;
            // 
            // colYestCycles
            // 
            this.colYestCycles.FieldName = "YestCycles";
            this.colYestCycles.Name = "colYestCycles";
            this.colYestCycles.Visible = true;
            this.colYestCycles.VisibleIndex = 19;
            // 
            // colSPM
            // 
            this.colSPM.FieldName = "SPM";
            this.colSPM.Name = "colSPM";
            this.colSPM.Visible = true;
            this.colSPM.VisibleIndex = 20;
            // 
            // colTypeofSub_Controller
            // 
            this.colTypeofSub_Controller.FieldName = "TypeofSub_Controller";
            this.colTypeofSub_Controller.Name = "colTypeofSub_Controller";
            this.colTypeofSub_Controller.Visible = true;
            this.colTypeofSub_Controller.VisibleIndex = 21;
            // 
            // colOutofService
            // 
            this.colOutofService.FieldName = "OutofService";
            this.colOutofService.Name = "colOutofService";
            this.colOutofService.Visible = true;
            this.colOutofService.VisibleIndex = 22;
            // 
            // colCommToday
            // 
            this.colCommToday.FieldName = "CommToday";
            this.colCommToday.Name = "colCommToday";
            this.colCommToday.Visible = true;
            this.colCommToday.VisibleIndex = 23;
            // 
            // colCommYest
            // 
            this.colCommYest.FieldName = "CommYest";
            this.colCommYest.Name = "colCommYest";
            this.colCommYest.Visible = true;
            this.colCommYest.VisibleIndex = 24;
            // 
            // colCommPort
            // 
            this.colCommPort.FieldName = "CommPort";
            this.colCommPort.Name = "colCommPort";
            this.colCommPort.Visible = true;
            this.colCommPort.VisibleIndex = 25;
            // 
            // colPumpSLip
            // 
            this.colPumpSLip.FieldName = "PumpSLip";
            this.colPumpSLip.Name = "colPumpSLip";
            this.colPumpSLip.Visible = true;
            this.colPumpSLip.VisibleIndex = 26;
            // 
            // colPumpFill
            // 
            this.colPumpFill.FieldName = "PumpFill";
            this.colPumpFill.Name = "colPumpFill";
            this.colPumpFill.Visible = true;
            this.colPumpFill.VisibleIndex = 27;
            // 
            // colTodayInferredProd
            // 
            this.colTodayInferredProd.FieldName = "TodayInferredProd";
            this.colTodayInferredProd.Name = "colTodayInferredProd";
            this.colTodayInferredProd.Visible = true;
            this.colTodayInferredProd.VisibleIndex = 28;
            // 
            // colYestInferredProd
            // 
            this.colYestInferredProd.FieldName = "YestInferredProd";
            this.colYestInferredProd.Name = "colYestInferredProd";
            this.colYestInferredProd.Visible = true;
            this.colYestInferredProd.VisibleIndex = 29;
            // 
            // colTubingPress
            // 
            this.colTubingPress.FieldName = "TubingPress";
            this.colTubingPress.Name = "colTubingPress";
            this.colTubingPress.Visible = true;
            this.colTubingPress.VisibleIndex = 30;
            // 
            // colCasingPress
            // 
            this.colCasingPress.FieldName = "CasingPress";
            this.colCasingPress.Name = "colCasingPress";
            this.colCasingPress.Visible = true;
            this.colCasingPress.VisibleIndex = 31;
            // 
            // colTubingtemp
            // 
            this.colTubingtemp.FieldName = "Tubingtemp";
            this.colTubingtemp.Name = "colTubingtemp";
            this.colTubingtemp.Visible = true;
            this.colTubingtemp.VisibleIndex = 32;
            // 
            // colCasingtemp
            // 
            this.colCasingtemp.FieldName = "Casingtemp";
            this.colCasingtemp.Name = "colCasingtemp";
            this.colCasingtemp.Visible = true;
            this.colCasingtemp.VisibleIndex = 33;
            // 
            // colHeaderPress
            // 
            this.colHeaderPress.FieldName = "HeaderPress";
            this.colHeaderPress.Name = "colHeaderPress";
            this.colHeaderPress.Visible = true;
            this.colHeaderPress.VisibleIndex = 34;
            // 
            // colLastCurrentCardCollection
            // 
            this.colLastCurrentCardCollection.FieldName = "LastCurrentCardCollection";
            this.colLastCurrentCardCollection.Name = "colLastCurrentCardCollection";
            this.colLastCurrentCardCollection.Visible = true;
            this.colLastCurrentCardCollection.VisibleIndex = 35;
            // 
            // prosedurgetdataESPWellgroupStatusBindingSource
            // 
            this.prosedurgetdataESPWellgroupStatusBindingSource.DataMember = "prosedur_getdataESPWellgroupStatus";
            this.prosedurgetdataESPWellgroupStatusBindingSource.DataSource = this.lw2DataSet13;
            // 
            // lw2DataSet13
            // 
            this.lw2DataSet13.DataSetName = "lw2DataSet13";
            this.lw2DataSet13.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lw2DataSet8
            // 
            this.lw2DataSet8.DataSetName = "lw2DataSet8";
            this.lw2DataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // prosedurgetdataWellGroupStatusBindingSource
            // 
            this.prosedurgetdataWellGroupStatusBindingSource.DataMember = "prosedur_getdataWellGroupStatus";
            this.prosedurgetdataWellGroupStatusBindingSource.DataSource = this.lw2DataSet8;
            // 
            // prosedurgetdataBeamWellGroupConfigurationBindingSource2
            // 
            this.prosedurgetdataBeamWellGroupConfigurationBindingSource2.DataMember = "prosedur_getdataBeamWellGroupConfiguration";
            this.prosedurgetdataBeamWellGroupConfigurationBindingSource2.DataSource = this.lw2DataSet7;
            // 
            // lw2DataSet7
            // 
            this.lw2DataSet7.DataSetName = "lw2DataSet7";
            this.lw2DataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lw2DataSet2
            // 
            this.lw2DataSet2.DataSetName = "lw2DataSet2";
            this.lw2DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // prosedurgetdataBeamWellGroupConfigurationBindingSource
            // 
            this.prosedurgetdataBeamWellGroupConfigurationBindingSource.DataMember = "prosedur_getdataBeamWellGroupConfiguration";
            this.prosedurgetdataBeamWellGroupConfigurationBindingSource.DataSource = this.lw2DataSet2;
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.ConnectionName = "LowisChartApp.Properties.Settings.db_chartConnectionString";
            this.sqlDataSource1.Name = "sqlDataSource1";
            storedProcQuery1.Name = "prosedur_getdataWellGroupStatus";
            queryParameter1.Name = "@param";
            queryParameter1.Type = typeof(string);
            storedProcQuery1.Parameters.AddRange(new DevExpress.DataAccess.Sql.QueryParameter[] {
            queryParameter1});
            storedProcQuery1.StoredProcName = "prosedur_getdataWellGroupStatus";
            this.sqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            storedProcQuery1});
            this.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable");
            // 
            // prosedurgetdataGroupDescreteConfigBindingSource
            // 
            this.prosedurgetdataGroupDescreteConfigBindingSource.DataMember = "prosedur_getdataGroupDescreteConfig";
            this.prosedurgetdataGroupDescreteConfigBindingSource.DataSource = this.lw2DataSet1;
            // 
            // lw2DataSet1
            // 
            this.lw2DataSet1.DataSetName = "lw2DataSet1";
            this.lw2DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // prosedur_getdataBeamWellGroupConfigurationTableAdapter
            // 
            this.prosedur_getdataBeamWellGroupConfigurationTableAdapter.ClearBeforeFill = true;
            // 
            // lw2DataSet6
            // 
            this.lw2DataSet6.DataSetName = "lw2DataSet6";
            this.lw2DataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // prosedurgetdataBeamWellGroupConfigurationBindingSource1
            // 
            this.prosedurgetdataBeamWellGroupConfigurationBindingSource1.DataMember = "prosedur_getdataBeamWellGroupConfiguration";
            this.prosedurgetdataBeamWellGroupConfigurationBindingSource1.DataSource = this.lw2DataSet6;
            // 
            // prosedur_getdataBeamWellGroupConfigurationTableAdapter1
            // 
            this.prosedur_getdataBeamWellGroupConfigurationTableAdapter1.ClearBeforeFill = true;
            // 
            // prosedur_getdataBeamWellGroupConfigurationTableAdapter2
            // 
            this.prosedur_getdataBeamWellGroupConfigurationTableAdapter2.ClearBeforeFill = true;
            // 
            // prosedur_getdataGroupDescreteConfigTableAdapter
            // 
            this.prosedur_getdataGroupDescreteConfigTableAdapter.ClearBeforeFill = true;
            // 
            // prosedurgetdatabeamWellGroupStatusBindingSource
            // 
            this.prosedurgetdatabeamWellGroupStatusBindingSource.DataMember = "prosedur_getdatabeamWellGroupStatus";
            // 
            // prosedurgetdataWellGroupStatusBindingSource1
            // 
            this.prosedurgetdataWellGroupStatusBindingSource1.DataMember = "prosedur_getdataWellGroupStatus";
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1235, 32);
            this.panel1.TabIndex = 16;
            // 
            // prosedurgetdataWellGroupStatusBindingSource2
            // 
            this.prosedurgetdataWellGroupStatusBindingSource2.DataMember = "prosedur_getdataWellGroupStatus";
            this.prosedurgetdataWellGroupStatusBindingSource2.DataSource = this.lw2DataSet8;
            // 
            // lw2DataSet15
            // 
            this.lw2DataSet15.DataSetName = "lw2DataSet15";
            this.lw2DataSet15.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lw2DataSet15BindingSource
            // 
            this.lw2DataSet15BindingSource.DataSource = this.lw2DataSet15;
            this.lw2DataSet15BindingSource.Position = 0;
            // 
            // prosedurgetdatabeamWellGroupStatusBindingSource1
            // 
            this.prosedurgetdatabeamWellGroupStatusBindingSource1.DataMember = "prosedur_getdatabeamWellGroupStatus";
            this.prosedurgetdatabeamWellGroupStatusBindingSource1.DataSource = this.lw2DataSet15;
            // 
            // prosedur_getdatabeamWellGroupStatusTableAdapter
            // 
            this.prosedur_getdatabeamWellGroupStatusTableAdapter.ClearBeforeFill = true;
            // 
            // lw2DataSet16
            // 
            this.lw2DataSet16.DataSetName = "lw2DataSet16";
            this.lw2DataSet16.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // prosedurgetdatabeamWellGroupStatusBindingSource2
            // 
            this.prosedurgetdatabeamWellGroupStatusBindingSource2.DataMember = "prosedur_getdatabeamWellGroupStatus";
            this.prosedurgetdatabeamWellGroupStatusBindingSource2.DataSource = this.lw2DataSet16;
            // 
            // prosedur_getdatabeamWellGroupStatusTableAdapter1
            // 
            this.prosedur_getdatabeamWellGroupStatusTableAdapter1.ClearBeforeFill = true;
            // 
            // prosedurgetdatabeamWellGroupStatusBindingSource3
            // 
            this.prosedurgetdatabeamWellGroupStatusBindingSource3.DataMember = "prosedur_getdatabeamWellGroupStatus";
            this.prosedurgetdatabeamWellGroupStatusBindingSource3.DataSource = this.lw2DataSet16;
            // 
            // BeamWellCurrentStatusMain
            // 
            this.Appearance.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "BeamWellCurrentStatusMain";
            this.Size = new System.Drawing.Size(1235, 478);
            this.Load += new System.EventHandler(this.BeamWellCurrentStatusMain_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdLowis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvLowis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prosedurgetdataESPWellgroupStatusBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lw2DataSet13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lw2DataSet8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prosedurgetdataWellGroupStatusBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prosedurgetdataBeamWellGroupConfigurationBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lw2DataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lw2DataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prosedurgetdataBeamWellGroupConfigurationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lw2DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prosedurgetdataGroupDescreteConfigBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lw2DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lw2DataSetBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lw2DataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prosedurgetdataBeamWellGroupConfigurationBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prosedurgetdatabeamWellGroupStatusBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prosedurgetdataWellGroupStatusBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prosedurgetdataWellGroupStatusBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lw2DataSet15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lw2DataSet15BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prosedurgetdatabeamWellGroupStatusBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lw2DataSet16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prosedurgetdatabeamWellGroupStatusBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prosedurgetdatabeamWellGroupStatusBindingSource3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private lw2DataSet13TableAdapters.prosedur_getdataESPWellgroupStatusTableAdapter prosedur_getdataESPWellgroupStatusTableAdapter;
        private lw2DataSet8TableAdapters.prosedur_getdataWellGroupStatusTableAdapter prosedur_getdataWellGroupStatusTableAdapter;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraGrid.GridControl gdLowis;
        private System.Windows.Forms.BindingSource prosedurgetdataESPWellgroupStatusBindingSource;
        private lw2DataSet13 lw2DataSet13;
        private DevExpress.XtraGrid.Views.Grid.GridView gvLowis;
        private lw2DataSet8 lw2DataSet8;
        private System.Windows.Forms.BindingSource prosedurgetdataWellGroupStatusBindingSource;
        private System.Windows.Forms.BindingSource prosedurgetdataBeamWellGroupConfigurationBindingSource2;
        private lw2DataSet7 lw2DataSet7;
        private lw2DataSet2 lw2DataSet2;
        private System.Windows.Forms.BindingSource prosedurgetdataBeamWellGroupConfigurationBindingSource;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
        private System.Windows.Forms.BindingSource lw2DataSetBindingSource;
        private System.Windows.Forms.BindingSource prosedurgetdataGroupDescreteConfigBindingSource;
        private lw2DataSet1 lw2DataSet1;
        private System.Windows.Forms.BindingSource lw2DataSetBindingSource1;
        private lw2DataSet2TableAdapters.prosedur_getdataBeamWellGroupConfigurationTableAdapter prosedur_getdataBeamWellGroupConfigurationTableAdapter;
        private lw2DataSet6 lw2DataSet6;
        private System.Windows.Forms.BindingSource prosedurgetdataBeamWellGroupConfigurationBindingSource1;
        private lw2DataSet6TableAdapters.prosedur_getdataBeamWellGroupConfigurationTableAdapter prosedur_getdataBeamWellGroupConfigurationTableAdapter1;
        private lw2DataSet7TableAdapters.prosedur_getdataBeamWellGroupConfigurationTableAdapter prosedur_getdataBeamWellGroupConfigurationTableAdapter2;
        private lw2DataSet1TableAdapters.prosedur_getdataGroupDescreteConfigTableAdapter prosedur_getdataGroupDescreteConfigTableAdapter;
        private System.Windows.Forms.BindingSource prosedurgetdatabeamWellGroupStatusBindingSource;
        private System.Windows.Forms.BindingSource prosedurgetdataWellGroupStatusBindingSource1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.BindingSource prosedurgetdataWellGroupStatusBindingSource2;
        private System.Windows.Forms.BindingSource prosedurgetdatabeamWellGroupStatusBindingSource1;
        private lw2DataSet15 lw2DataSet15;
        private System.Windows.Forms.BindingSource lw2DataSet15BindingSource;
        private lw2DataSet15TableAdapters.prosedur_getdatabeamWellGroupStatusTableAdapter prosedur_getdatabeamWellGroupStatusTableAdapter;
        private System.Windows.Forms.BindingSource prosedurgetdatabeamWellGroupStatusBindingSource2;
        private lw2DataSet16 lw2DataSet16;
        private lw2DataSet16TableAdapters.prosedur_getdatabeamWellGroupStatusTableAdapter prosedur_getdatabeamWellGroupStatusTableAdapter1;
        private System.Windows.Forms.BindingSource prosedurgetdatabeamWellGroupStatusBindingSource3;
        private DevExpress.XtraGrid.Columns.GridColumn colWellName;
        private DevExpress.XtraGrid.Columns.GridColumn colArea;
        private DevExpress.XtraGrid.Columns.GridColumn colScanTime;
        private DevExpress.XtraGrid.Columns.GridColumn colScanDate;
        private DevExpress.XtraGrid.Columns.GridColumn colAlarmMessage;
        private DevExpress.XtraGrid.Columns.GridColumn colLastGoodScanTime;
        private DevExpress.XtraGrid.Columns.GridColumn colLastGoodScanDate;
        private DevExpress.XtraGrid.Columns.GridColumn colHostMode;
        private DevExpress.XtraGrid.Columns.GridColumn colPOCMode;
        private DevExpress.XtraGrid.Columns.GridColumn colMotorStatus;
        private DevExpress.XtraGrid.Columns.GridColumn colComment;
        private DevExpress.XtraGrid.Columns.GridColumn colLastGoodTestOil;
        private DevExpress.XtraGrid.Columns.GridColumn colLastGoodTestWater;
        private DevExpress.XtraGrid.Columns.GridColumn colLastGoodTestTotalGas;
        private DevExpress.XtraGrid.Columns.GridColumn colPOCardDate;
        private DevExpress.XtraGrid.Columns.GridColumn colTodayRun;
        private DevExpress.XtraGrid.Columns.GridColumn colYestRun;
        private DevExpress.XtraGrid.Columns.GridColumn colsetpointpos;
        private DevExpress.XtraGrid.Columns.GridColumn colsetpointload;
        private DevExpress.XtraGrid.Columns.GridColumn colYestCycles;
        private DevExpress.XtraGrid.Columns.GridColumn colSPM;
        private DevExpress.XtraGrid.Columns.GridColumn colTypeofSub_Controller;
        private DevExpress.XtraGrid.Columns.GridColumn colOutofService;
        private DevExpress.XtraGrid.Columns.GridColumn colCommToday;
        private DevExpress.XtraGrid.Columns.GridColumn colCommYest;
        private DevExpress.XtraGrid.Columns.GridColumn colCommPort;
        private DevExpress.XtraGrid.Columns.GridColumn colPumpSLip;
        private DevExpress.XtraGrid.Columns.GridColumn colPumpFill;
        private DevExpress.XtraGrid.Columns.GridColumn colTodayInferredProd;
        private DevExpress.XtraGrid.Columns.GridColumn colYestInferredProd;
        private DevExpress.XtraGrid.Columns.GridColumn colTubingPress;
        private DevExpress.XtraGrid.Columns.GridColumn colCasingPress;
        private DevExpress.XtraGrid.Columns.GridColumn colTubingtemp;
        private DevExpress.XtraGrid.Columns.GridColumn colCasingtemp;
        private DevExpress.XtraGrid.Columns.GridColumn colHeaderPress;
        private DevExpress.XtraGrid.Columns.GridColumn colLastCurrentCardCollection;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnRefresh;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripTextBox btnSearch;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton btnFilter;
        private System.Windows.Forms.ToolStripButton btnChart;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnScan;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnPOC;
        private System.Windows.Forms.ToolStripButton btnContinous;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton Start;
        private System.Windows.Forms.ToolStripButton BtnStop;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton btnHelp;
        private System.Windows.Forms.ToolStripButton btnAcknowladge;
    }
}
