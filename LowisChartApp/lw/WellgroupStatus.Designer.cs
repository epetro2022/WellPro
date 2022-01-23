namespace LowisChartApp.lw
{
    partial class WellgroupStatus
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
            DevExpress.DataAccess.Sql.StoredProcQuery storedProcQuery1 = new DevExpress.DataAccess.Sql.StoredProcQuery();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter1 = new DevExpress.DataAccess.Sql.QueryParameter();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WellgroupStatus));
            this.prosedur_getdataBeamWellGroupConfigurationTableAdapter2 = new LowisChartApp.lw2DataSet7TableAdapters.prosedur_getdataBeamWellGroupConfigurationTableAdapter();
            this.lw2DataSet7 = new LowisChartApp.lw2DataSet7();
            this.prosedur_getdataBeamWellGroupConfigurationTableAdapter1 = new LowisChartApp.lw2DataSet6TableAdapters.prosedur_getdataBeamWellGroupConfigurationTableAdapter();
            this.prosedurgetdataBeamWellGroupConfigurationBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.lw2DataSet6 = new LowisChartApp.lw2DataSet6();
            this.prosedur_getdataBeamWellGroupConfigurationTableAdapter = new LowisChartApp.lw2DataSet2TableAdapters.prosedur_getdataBeamWellGroupConfigurationTableAdapter();
            this.lw2DataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.prosedurgetdataGroupDescreteConfigBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lw2DataSet1 = new LowisChartApp.lw2DataSet1();
            this.lw2DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.prosedurgetdataBeamWellGroupConfigurationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lw2DataSet2 = new LowisChartApp.lw2DataSet2();
            this.prosedurgetdataBeamWellGroupConfigurationBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
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
            this.prosedurgetdataWellGroupStatusBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.prosedurgetdatabeamWellGroupStatusBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.prosedur_getdataGroupDescreteConfigTableAdapter = new LowisChartApp.lw2DataSet1TableAdapters.prosedur_getdataGroupDescreteConfigTableAdapter();
            this.gvLowis = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colWellNameLWNAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRTUAddress = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colScanTime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLastGoodScanDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colScanDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAlarmMessage = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLastGoodScan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHighestPriorityAlarmAgeinDays = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWellStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTodayRunTimehrs = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHOAState = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStartsToday = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLastRunTimehrs = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalStarts = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAvgAmps = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAverageVolts = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPumpIntakePressure = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVibration = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMotorTemperature = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOperatingFrequency = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWellComment = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRTUType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOutofServiceDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLastGoodTestDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLastGoodTestOil = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLastGoodTestWater = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLastGoodTestTotalGas = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOutofServiceCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLastGoodWaterCut = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLastGoodTotalFluid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLastFluidDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLastFluidLevelFromSurface = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLastFluidAbovePump = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLastFluidGasFreeLiquid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLastFluidCasingPressure = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCommPort = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAlarmDelay = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colECStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gdLowis = new DevExpress.XtraGrid.GridControl();
            this.prosedurgetdataESPWellgroupStatusBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lw2DataSet13 = new LowisChartApp.lw2DataSet13();
            this.prosedurgetdataWellGroupStatusBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lw2DataSet8 = new LowisChartApp.lw2DataSet8();
            this.panel2 = new System.Windows.Forms.Panel();
            this.prosedur_getdataWellGroupStatusTableAdapter = new LowisChartApp.lw2DataSet8TableAdapters.prosedur_getdataWellGroupStatusTableAdapter();
            this.prosedurgetdataWellGroupStatusBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.prosedur_getdataESPWellgroupStatusTableAdapter = new LowisChartApp.lw2DataSet13TableAdapters.prosedur_getdataESPWellgroupStatusTableAdapter();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.lw2DataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prosedurgetdataBeamWellGroupConfigurationBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lw2DataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lw2DataSetBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prosedurgetdataGroupDescreteConfigBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lw2DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lw2DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prosedurgetdataBeamWellGroupConfigurationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lw2DataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prosedurgetdataBeamWellGroupConfigurationBindingSource2)).BeginInit();
            this.panel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.prosedurgetdataWellGroupStatusBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prosedurgetdatabeamWellGroupStatusBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvLowis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdLowis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prosedurgetdataESPWellgroupStatusBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lw2DataSet13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prosedurgetdataWellGroupStatusBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lw2DataSet8)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.prosedurgetdataWellGroupStatusBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // prosedur_getdataBeamWellGroupConfigurationTableAdapter2
            // 
            this.prosedur_getdataBeamWellGroupConfigurationTableAdapter2.ClearBeforeFill = true;
            // 
            // lw2DataSet7
            // 
            this.lw2DataSet7.DataSetName = "lw2DataSet7";
            this.lw2DataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // prosedur_getdataBeamWellGroupConfigurationTableAdapter1
            // 
            this.prosedur_getdataBeamWellGroupConfigurationTableAdapter1.ClearBeforeFill = true;
            // 
            // prosedurgetdataBeamWellGroupConfigurationBindingSource1
            // 
            this.prosedurgetdataBeamWellGroupConfigurationBindingSource1.DataMember = "prosedur_getdataBeamWellGroupConfiguration";
            this.prosedurgetdataBeamWellGroupConfigurationBindingSource1.DataSource = this.lw2DataSet6;
            // 
            // lw2DataSet6
            // 
            this.lw2DataSet6.DataSetName = "lw2DataSet6";
            this.lw2DataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // prosedur_getdataBeamWellGroupConfigurationTableAdapter
            // 
            this.prosedur_getdataBeamWellGroupConfigurationTableAdapter.ClearBeforeFill = true;
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
            // prosedurgetdataBeamWellGroupConfigurationBindingSource
            // 
            this.prosedurgetdataBeamWellGroupConfigurationBindingSource.DataMember = "prosedur_getdataBeamWellGroupConfiguration";
            this.prosedurgetdataBeamWellGroupConfigurationBindingSource.DataSource = this.lw2DataSet2;
            // 
            // lw2DataSet2
            // 
            this.lw2DataSet2.DataSetName = "lw2DataSet2";
            this.lw2DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // prosedurgetdataBeamWellGroupConfigurationBindingSource2
            // 
            this.prosedurgetdataBeamWellGroupConfigurationBindingSource2.DataMember = "prosedur_getdataBeamWellGroupConfiguration";
            this.prosedurgetdataBeamWellGroupConfigurationBindingSource2.DataSource = this.lw2DataSet7;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.toolStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1412, 32);
            this.panel1.TabIndex = 14;
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
            this.btnAcknowladge,
            this.toolStripButton1,
            this.btnHelp});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStrip1.Size = new System.Drawing.Size(1412, 25);
            this.toolStrip1.TabIndex = 2;
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
            // prosedurgetdataWellGroupStatusBindingSource1
            // 
            this.prosedurgetdataWellGroupStatusBindingSource1.DataMember = "prosedur_getdataWellGroupStatus";
            // 
            // prosedurgetdatabeamWellGroupStatusBindingSource
            // 
            this.prosedurgetdatabeamWellGroupStatusBindingSource.DataMember = "prosedur_getdatabeamWellGroupStatus";
            // 
            // prosedur_getdataGroupDescreteConfigTableAdapter
            // 
            this.prosedur_getdataGroupDescreteConfigTableAdapter.ClearBeforeFill = true;
            // 
            // gvLowis
            // 
            this.gvLowis.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colWellNameLWNAME,
            this.colRTUAddress,
            this.colScanTime,
            this.colLastGoodScanDate,
            this.colScanDate,
            this.colAlarmMessage,
            this.colLastGoodScan,
            this.colHighestPriorityAlarmAgeinDays,
            this.colWellStatus,
            this.colTodayRunTimehrs,
            this.gridColumn1,
            this.colHOAState,
            this.colStartsToday,
            this.colLastRunTimehrs,
            this.colTotalStarts,
            this.colAvgAmps,
            this.colAverageVolts,
            this.colPumpIntakePressure,
            this.colVibration,
            this.colMotorTemperature,
            this.colOperatingFrequency,
            this.colWellComment,
            this.colRTUType,
            this.colOutofServiceDate,
            this.colLastGoodTestDate,
            this.colLastGoodTestOil,
            this.colLastGoodTestWater,
            this.colLastGoodTestTotalGas,
            this.colOutofServiceCode,
            this.colLastGoodWaterCut,
            this.colLastGoodTotalFluid,
            this.colLastFluidDate,
            this.colLastFluidLevelFromSurface,
            this.colLastFluidAbovePump,
            this.colLastFluidGasFreeLiquid,
            this.colLastFluidCasingPressure,
            this.colCommPort,
            this.colAlarmDelay,
            this.colECStatus});
            this.gvLowis.GridControl = this.gdLowis;
            this.gvLowis.Name = "gvLowis";
            this.gvLowis.OptionsBehavior.Editable = false;
            this.gvLowis.OptionsView.ColumnAutoWidth = false;
            // 
            // colWellNameLWNAME
            // 
            this.colWellNameLWNAME.FieldName = "WellNameLWNAME";
            this.colWellNameLWNAME.Name = "colWellNameLWNAME";
            this.colWellNameLWNAME.Visible = true;
            this.colWellNameLWNAME.VisibleIndex = 0;
            // 
            // colRTUAddress
            // 
            this.colRTUAddress.FieldName = "RTUAddress";
            this.colRTUAddress.Name = "colRTUAddress";
            this.colRTUAddress.Visible = true;
            this.colRTUAddress.VisibleIndex = 1;
            // 
            // colScanTime
            // 
            this.colScanTime.FieldName = "ScanTime";
            this.colScanTime.Name = "colScanTime";
            this.colScanTime.Visible = true;
            this.colScanTime.VisibleIndex = 2;
            // 
            // colLastGoodScanDate
            // 
            this.colLastGoodScanDate.FieldName = "LastGoodScanDate";
            this.colLastGoodScanDate.Name = "colLastGoodScanDate";
            this.colLastGoodScanDate.Visible = true;
            this.colLastGoodScanDate.VisibleIndex = 3;
            // 
            // colScanDate
            // 
            this.colScanDate.FieldName = "ScanDate";
            this.colScanDate.Name = "colScanDate";
            this.colScanDate.Visible = true;
            this.colScanDate.VisibleIndex = 4;
            // 
            // colAlarmMessage
            // 
            this.colAlarmMessage.FieldName = "AlarmMessage";
            this.colAlarmMessage.Name = "colAlarmMessage";
            this.colAlarmMessage.Visible = true;
            this.colAlarmMessage.VisibleIndex = 5;
            // 
            // colLastGoodScan
            // 
            this.colLastGoodScan.FieldName = "LastGoodScan";
            this.colLastGoodScan.Name = "colLastGoodScan";
            this.colLastGoodScan.Visible = true;
            this.colLastGoodScan.VisibleIndex = 6;
            // 
            // colHighestPriorityAlarmAgeinDays
            // 
            this.colHighestPriorityAlarmAgeinDays.FieldName = "HighestPriorityAlarmAgeinDays";
            this.colHighestPriorityAlarmAgeinDays.Name = "colHighestPriorityAlarmAgeinDays";
            this.colHighestPriorityAlarmAgeinDays.Visible = true;
            this.colHighestPriorityAlarmAgeinDays.VisibleIndex = 7;
            // 
            // colWellStatus
            // 
            this.colWellStatus.FieldName = "WellStatus";
            this.colWellStatus.Name = "colWellStatus";
            this.colWellStatus.Visible = true;
            this.colWellStatus.VisibleIndex = 8;
            // 
            // colTodayRunTimehrs
            // 
            this.colTodayRunTimehrs.FieldName = "TodayRunTimehrs";
            this.colTodayRunTimehrs.Name = "colTodayRunTimehrs";
            this.colTodayRunTimehrs.Visible = true;
            this.colTodayRunTimehrs.VisibleIndex = 9;
            // 
            // gridColumn1
            // 
            this.gridColumn1.FieldName = "YesterdayRunTime (hrs)";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 10;
            // 
            // colHOAState
            // 
            this.colHOAState.FieldName = "HOAState";
            this.colHOAState.Name = "colHOAState";
            this.colHOAState.Visible = true;
            this.colHOAState.VisibleIndex = 11;
            // 
            // colStartsToday
            // 
            this.colStartsToday.FieldName = "StartsToday";
            this.colStartsToday.Name = "colStartsToday";
            this.colStartsToday.Visible = true;
            this.colStartsToday.VisibleIndex = 12;
            // 
            // colLastRunTimehrs
            // 
            this.colLastRunTimehrs.FieldName = "LastRunTimehrs";
            this.colLastRunTimehrs.Name = "colLastRunTimehrs";
            this.colLastRunTimehrs.Visible = true;
            this.colLastRunTimehrs.VisibleIndex = 13;
            // 
            // colTotalStarts
            // 
            this.colTotalStarts.FieldName = "TotalStarts";
            this.colTotalStarts.Name = "colTotalStarts";
            this.colTotalStarts.Visible = true;
            this.colTotalStarts.VisibleIndex = 14;
            // 
            // colAvgAmps
            // 
            this.colAvgAmps.FieldName = "AvgAmps";
            this.colAvgAmps.Name = "colAvgAmps";
            this.colAvgAmps.Visible = true;
            this.colAvgAmps.VisibleIndex = 15;
            // 
            // colAverageVolts
            // 
            this.colAverageVolts.FieldName = "AverageVolts";
            this.colAverageVolts.Name = "colAverageVolts";
            this.colAverageVolts.Visible = true;
            this.colAverageVolts.VisibleIndex = 16;
            // 
            // colPumpIntakePressure
            // 
            this.colPumpIntakePressure.FieldName = "PumpIntakePressure";
            this.colPumpIntakePressure.Name = "colPumpIntakePressure";
            this.colPumpIntakePressure.Visible = true;
            this.colPumpIntakePressure.VisibleIndex = 17;
            // 
            // colVibration
            // 
            this.colVibration.FieldName = "Vibration";
            this.colVibration.Name = "colVibration";
            this.colVibration.Visible = true;
            this.colVibration.VisibleIndex = 18;
            // 
            // colMotorTemperature
            // 
            this.colMotorTemperature.FieldName = "MotorTemperature";
            this.colMotorTemperature.Name = "colMotorTemperature";
            this.colMotorTemperature.Visible = true;
            this.colMotorTemperature.VisibleIndex = 19;
            // 
            // colOperatingFrequency
            // 
            this.colOperatingFrequency.FieldName = "OperatingFrequency";
            this.colOperatingFrequency.Name = "colOperatingFrequency";
            this.colOperatingFrequency.Visible = true;
            this.colOperatingFrequency.VisibleIndex = 20;
            // 
            // colWellComment
            // 
            this.colWellComment.FieldName = "WellComment";
            this.colWellComment.Name = "colWellComment";
            this.colWellComment.Visible = true;
            this.colWellComment.VisibleIndex = 21;
            // 
            // colRTUType
            // 
            this.colRTUType.FieldName = "RTUType";
            this.colRTUType.Name = "colRTUType";
            this.colRTUType.Visible = true;
            this.colRTUType.VisibleIndex = 22;
            // 
            // colOutofServiceDate
            // 
            this.colOutofServiceDate.FieldName = "OutofServiceDate";
            this.colOutofServiceDate.Name = "colOutofServiceDate";
            this.colOutofServiceDate.Visible = true;
            this.colOutofServiceDate.VisibleIndex = 23;
            // 
            // colLastGoodTestDate
            // 
            this.colLastGoodTestDate.FieldName = "LastGoodTestDate";
            this.colLastGoodTestDate.Name = "colLastGoodTestDate";
            this.colLastGoodTestDate.Visible = true;
            this.colLastGoodTestDate.VisibleIndex = 24;
            // 
            // colLastGoodTestOil
            // 
            this.colLastGoodTestOil.FieldName = "LastGoodTestOil";
            this.colLastGoodTestOil.Name = "colLastGoodTestOil";
            this.colLastGoodTestOil.Visible = true;
            this.colLastGoodTestOil.VisibleIndex = 25;
            // 
            // colLastGoodTestWater
            // 
            this.colLastGoodTestWater.FieldName = "LastGoodTestWater";
            this.colLastGoodTestWater.Name = "colLastGoodTestWater";
            this.colLastGoodTestWater.Visible = true;
            this.colLastGoodTestWater.VisibleIndex = 26;
            // 
            // colLastGoodTestTotalGas
            // 
            this.colLastGoodTestTotalGas.FieldName = "LastGoodTestTotalGas";
            this.colLastGoodTestTotalGas.Name = "colLastGoodTestTotalGas";
            this.colLastGoodTestTotalGas.Visible = true;
            this.colLastGoodTestTotalGas.VisibleIndex = 27;
            // 
            // colOutofServiceCode
            // 
            this.colOutofServiceCode.FieldName = "OutofServiceCode";
            this.colOutofServiceCode.Name = "colOutofServiceCode";
            this.colOutofServiceCode.Visible = true;
            this.colOutofServiceCode.VisibleIndex = 28;
            // 
            // colLastGoodWaterCut
            // 
            this.colLastGoodWaterCut.FieldName = "LastGoodWaterCut";
            this.colLastGoodWaterCut.Name = "colLastGoodWaterCut";
            this.colLastGoodWaterCut.Visible = true;
            this.colLastGoodWaterCut.VisibleIndex = 29;
            // 
            // colLastGoodTotalFluid
            // 
            this.colLastGoodTotalFluid.FieldName = "LastGoodTotalFluid";
            this.colLastGoodTotalFluid.Name = "colLastGoodTotalFluid";
            this.colLastGoodTotalFluid.Visible = true;
            this.colLastGoodTotalFluid.VisibleIndex = 30;
            // 
            // colLastFluidDate
            // 
            this.colLastFluidDate.FieldName = "LastFluidDate";
            this.colLastFluidDate.Name = "colLastFluidDate";
            this.colLastFluidDate.Visible = true;
            this.colLastFluidDate.VisibleIndex = 31;
            // 
            // colLastFluidLevelFromSurface
            // 
            this.colLastFluidLevelFromSurface.FieldName = "LastFluidLevelFromSurface";
            this.colLastFluidLevelFromSurface.Name = "colLastFluidLevelFromSurface";
            this.colLastFluidLevelFromSurface.Visible = true;
            this.colLastFluidLevelFromSurface.VisibleIndex = 32;
            // 
            // colLastFluidAbovePump
            // 
            this.colLastFluidAbovePump.FieldName = "LastFluidAbovePump";
            this.colLastFluidAbovePump.Name = "colLastFluidAbovePump";
            this.colLastFluidAbovePump.Visible = true;
            this.colLastFluidAbovePump.VisibleIndex = 33;
            // 
            // colLastFluidGasFreeLiquid
            // 
            this.colLastFluidGasFreeLiquid.FieldName = "LastFluidGasFreeLiquid";
            this.colLastFluidGasFreeLiquid.Name = "colLastFluidGasFreeLiquid";
            this.colLastFluidGasFreeLiquid.Visible = true;
            this.colLastFluidGasFreeLiquid.VisibleIndex = 34;
            // 
            // colLastFluidCasingPressure
            // 
            this.colLastFluidCasingPressure.FieldName = "LastFluidCasingPressure";
            this.colLastFluidCasingPressure.Name = "colLastFluidCasingPressure";
            this.colLastFluidCasingPressure.Visible = true;
            this.colLastFluidCasingPressure.VisibleIndex = 35;
            // 
            // colCommPort
            // 
            this.colCommPort.FieldName = "CommPort";
            this.colCommPort.Name = "colCommPort";
            this.colCommPort.Visible = true;
            this.colCommPort.VisibleIndex = 36;
            // 
            // colAlarmDelay
            // 
            this.colAlarmDelay.FieldName = "AlarmDelay";
            this.colAlarmDelay.Name = "colAlarmDelay";
            this.colAlarmDelay.Visible = true;
            this.colAlarmDelay.VisibleIndex = 37;
            // 
            // colECStatus
            // 
            this.colECStatus.FieldName = "ECStatus";
            this.colECStatus.Name = "colECStatus";
            this.colECStatus.Visible = true;
            this.colECStatus.VisibleIndex = 38;
            // 
            // gdLowis
            // 
            this.gdLowis.DataSource = this.prosedurgetdataESPWellgroupStatusBindingSource;
            this.gdLowis.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gdLowis.Location = new System.Drawing.Point(0, 0);
            this.gdLowis.MainView = this.gvLowis;
            this.gdLowis.Name = "gdLowis";
            this.gdLowis.Size = new System.Drawing.Size(1412, 515);
            this.gdLowis.TabIndex = 0;
            this.gdLowis.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvLowis});
            this.gdLowis.Click += new System.EventHandler(this.gdLowis_Click);
            this.gdLowis.MouseUp += new System.Windows.Forms.MouseEventHandler(this.gdLowis_MouseUp);
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
            // prosedurgetdataWellGroupStatusBindingSource
            // 
            this.prosedurgetdataWellGroupStatusBindingSource.DataMember = "prosedur_getdataWellGroupStatus";
            this.prosedurgetdataWellGroupStatusBindingSource.DataSource = this.lw2DataSet8;
            // 
            // lw2DataSet8
            // 
            this.lw2DataSet8.DataSetName = "lw2DataSet8";
            this.lw2DataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.gdLowis);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1412, 515);
            this.panel2.TabIndex = 15;
            // 
            // prosedur_getdataWellGroupStatusTableAdapter
            // 
            this.prosedur_getdataWellGroupStatusTableAdapter.ClearBeforeFill = true;
            // 
            // prosedurgetdataWellGroupStatusBindingSource2
            // 
            this.prosedurgetdataWellGroupStatusBindingSource2.DataMember = "prosedur_getdataWellGroupStatus";
            this.prosedurgetdataWellGroupStatusBindingSource2.DataSource = this.lw2DataSet8;
            // 
            // prosedur_getdataESPWellgroupStatusTableAdapter
            // 
            this.prosedur_getdataESPWellgroupStatusTableAdapter.ClearBeforeFill = true;
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "Clear Alarm";
            // 
            // WellgroupStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "WellgroupStatus";
            this.Size = new System.Drawing.Size(1412, 515);
            this.Load += new System.EventHandler(this.WellgroupStatus_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lw2DataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prosedurgetdataBeamWellGroupConfigurationBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lw2DataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lw2DataSetBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prosedurgetdataGroupDescreteConfigBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lw2DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lw2DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prosedurgetdataBeamWellGroupConfigurationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lw2DataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prosedurgetdataBeamWellGroupConfigurationBindingSource2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.prosedurgetdataWellGroupStatusBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prosedurgetdatabeamWellGroupStatusBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvLowis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdLowis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prosedurgetdataESPWellgroupStatusBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lw2DataSet13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prosedurgetdataWellGroupStatusBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lw2DataSet8)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.prosedurgetdataWellGroupStatusBindingSource2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private lw2DataSet7TableAdapters.prosedur_getdataBeamWellGroupConfigurationTableAdapter prosedur_getdataBeamWellGroupConfigurationTableAdapter2;
        private lw2DataSet7 lw2DataSet7;
        private lw2DataSet6TableAdapters.prosedur_getdataBeamWellGroupConfigurationTableAdapter prosedur_getdataBeamWellGroupConfigurationTableAdapter1;
        private System.Windows.Forms.BindingSource prosedurgetdataBeamWellGroupConfigurationBindingSource1;
        private lw2DataSet6 lw2DataSet6;
        private lw2DataSet2TableAdapters.prosedur_getdataBeamWellGroupConfigurationTableAdapter prosedur_getdataBeamWellGroupConfigurationTableAdapter;
        private System.Windows.Forms.BindingSource lw2DataSetBindingSource1;
        private System.Windows.Forms.BindingSource prosedurgetdataGroupDescreteConfigBindingSource;
        private lw2DataSet1 lw2DataSet1;
        private System.Windows.Forms.BindingSource lw2DataSetBindingSource;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
        private System.Windows.Forms.BindingSource prosedurgetdataBeamWellGroupConfigurationBindingSource;
        private lw2DataSet2 lw2DataSet2;
        private System.Windows.Forms.BindingSource prosedurgetdataBeamWellGroupConfigurationBindingSource2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.BindingSource prosedurgetdataWellGroupStatusBindingSource1;
        private System.Windows.Forms.BindingSource prosedurgetdatabeamWellGroupStatusBindingSource;
        private lw2DataSet1TableAdapters.prosedur_getdataGroupDescreteConfigTableAdapter prosedur_getdataGroupDescreteConfigTableAdapter;
        private DevExpress.XtraGrid.Views.Grid.GridView gvLowis;
        private DevExpress.XtraGrid.GridControl gdLowis;
        private System.Windows.Forms.BindingSource prosedurgetdataWellGroupStatusBindingSource;
        private lw2DataSet8 lw2DataSet8;
        private System.Windows.Forms.Panel panel2;
        private lw2DataSet8TableAdapters.prosedur_getdataWellGroupStatusTableAdapter prosedur_getdataWellGroupStatusTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colWellNameLWNAME;
        private DevExpress.XtraGrid.Columns.GridColumn colRTUAddress;
        private DevExpress.XtraGrid.Columns.GridColumn colScanTime;
        private DevExpress.XtraGrid.Columns.GridColumn colLastGoodScanDate;
        private DevExpress.XtraGrid.Columns.GridColumn colScanDate;
        private DevExpress.XtraGrid.Columns.GridColumn colAlarmMessage;
        private DevExpress.XtraGrid.Columns.GridColumn colLastGoodScan;
        private DevExpress.XtraGrid.Columns.GridColumn colHighestPriorityAlarmAgeinDays;
        private DevExpress.XtraGrid.Columns.GridColumn colWellStatus;
        private DevExpress.XtraGrid.Columns.GridColumn colTodayRunTimehrs;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn colHOAState;
        private DevExpress.XtraGrid.Columns.GridColumn colStartsToday;
        private DevExpress.XtraGrid.Columns.GridColumn colLastRunTimehrs;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalStarts;
        private DevExpress.XtraGrid.Columns.GridColumn colAvgAmps;
        private DevExpress.XtraGrid.Columns.GridColumn colAverageVolts;
        private DevExpress.XtraGrid.Columns.GridColumn colPumpIntakePressure;
        private DevExpress.XtraGrid.Columns.GridColumn colVibration;
        private DevExpress.XtraGrid.Columns.GridColumn colMotorTemperature;
        private DevExpress.XtraGrid.Columns.GridColumn colOperatingFrequency;
        private DevExpress.XtraGrid.Columns.GridColumn colWellComment;
        private DevExpress.XtraGrid.Columns.GridColumn colRTUType;
        private DevExpress.XtraGrid.Columns.GridColumn colOutofServiceDate;
        private DevExpress.XtraGrid.Columns.GridColumn colLastGoodTestDate;
        private DevExpress.XtraGrid.Columns.GridColumn colLastGoodTestOil;
        private DevExpress.XtraGrid.Columns.GridColumn colLastGoodTestWater;
        private DevExpress.XtraGrid.Columns.GridColumn colLastGoodTestTotalGas;
        private DevExpress.XtraGrid.Columns.GridColumn colOutofServiceCode;
        private DevExpress.XtraGrid.Columns.GridColumn colLastGoodWaterCut;
        private DevExpress.XtraGrid.Columns.GridColumn colLastGoodTotalFluid;
        private DevExpress.XtraGrid.Columns.GridColumn colLastFluidDate;
        private DevExpress.XtraGrid.Columns.GridColumn colLastFluidLevelFromSurface;
        private DevExpress.XtraGrid.Columns.GridColumn colLastFluidAbovePump;
        private DevExpress.XtraGrid.Columns.GridColumn colLastFluidGasFreeLiquid;
        private DevExpress.XtraGrid.Columns.GridColumn colLastFluidCasingPressure;
        private DevExpress.XtraGrid.Columns.GridColumn colCommPort;
        private DevExpress.XtraGrid.Columns.GridColumn colAlarmDelay;
        private DevExpress.XtraGrid.Columns.GridColumn colECStatus;
        private System.Windows.Forms.BindingSource prosedurgetdataESPWellgroupStatusBindingSource;
        private lw2DataSet13 lw2DataSet13;
        private System.Windows.Forms.BindingSource prosedurgetdataWellGroupStatusBindingSource2;
        private lw2DataSet13TableAdapters.prosedur_getdataESPWellgroupStatusTableAdapter prosedur_getdataESPWellgroupStatusTableAdapter;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton Start;
        private System.Windows.Forms.ToolStripButton BtnStop;
        private System.Windows.Forms.ToolStripButton btnFilter;
        private System.Windows.Forms.ToolStripButton btnScan;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnPOC;
        private System.Windows.Forms.ToolStripButton btnContinous;
        private System.Windows.Forms.ToolStripButton btnHelp;
        private System.Windows.Forms.ToolStripButton btnRefresh;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripTextBox btnSearch;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton btnChart;
        private System.Windows.Forms.ToolStripButton btnAcknowladge;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
    }
}
