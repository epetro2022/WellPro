namespace LowisChartApp.lw
{
    partial class GroupAnalogStatus
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GroupAnalogStatus));
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
            this.newToolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.openToolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.saveToolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.printToolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.cutToolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.copyToolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.pasteToolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.helpToolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.newToolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.openToolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.saveToolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.printToolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.cutToolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.copyToolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.pasteToolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.helpToolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.prosedurgetdataWellGroupStatusBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.prosedurgetdatabeamWellGroupStatusBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.prosedur_getdataGroupDescreteConfigTableAdapter = new LowisChartApp.lw2DataSet1TableAdapters.prosedur_getdataGroupDescreteConfigTableAdapter();
            this.gdLowis = new DevExpress.XtraGrid.GridControl();
            this.gvLowis = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colFacilityWellName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAnalogPointDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCurrentValue = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTodayMaxValue = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTodayMinValue = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTodayAvgValue = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMonthlyAvgValue = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLastMonthAvgValue = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHiHiAlarm = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHiAlarm = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLoAlarm = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLoLoAlarm = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colClamp = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSensorFail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPointType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEngUnits = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOnTrend = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gridSplitContainer1 = new DevExpress.XtraGrid.GridSplitContainer();
            this.lw2DataSet10 = new LowisChartApp.lw2DataSet10();
            this.prosedurgetdataGroupanalogstatusBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.prosedur_getdataGroupanalogstatusTableAdapter = new LowisChartApp.lw2DataSet10TableAdapters.prosedur_getdataGroupanalogstatusTableAdapter();
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
            ((System.ComponentModel.ISupportInitialize)(this.gdLowis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvLowis)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridSplitContainer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSplitContainer1.Panel1)).BeginInit();
            this.gridSplitContainer1.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridSplitContainer1.Panel2)).BeginInit();
            this.gridSplitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lw2DataSet10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prosedurgetdataGroupanalogstatusBindingSource)).BeginInit();
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
            this.newToolStripButton1,
            this.openToolStripButton1,
            this.saveToolStripButton1,
            this.printToolStripButton1,
            this.toolStripSeparator2,
            this.cutToolStripButton1,
            this.copyToolStripButton1,
            this.pasteToolStripButton1,
            this.toolStripSeparator3,
            this.helpToolStripButton1,
            this.newToolStripButton2,
            this.openToolStripButton2,
            this.saveToolStripButton2,
            this.printToolStripButton2,
            this.toolStripSeparator4,
            this.cutToolStripButton2,
            this.copyToolStripButton2,
            this.pasteToolStripButton2,
            this.toolStripSeparator5,
            this.helpToolStripButton2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStrip1.Size = new System.Drawing.Size(1412, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // newToolStripButton1
            // 
            this.newToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.newToolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripButton1.Image")));
            this.newToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newToolStripButton1.Name = "newToolStripButton1";
            this.newToolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.newToolStripButton1.Text = "&New";
            // 
            // openToolStripButton1
            // 
            this.openToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.openToolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripButton1.Image")));
            this.openToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openToolStripButton1.Name = "openToolStripButton1";
            this.openToolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.openToolStripButton1.Text = "&Open";
            // 
            // saveToolStripButton1
            // 
            this.saveToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveToolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripButton1.Image")));
            this.saveToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripButton1.Name = "saveToolStripButton1";
            this.saveToolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.saveToolStripButton1.Text = "&Save";
            // 
            // printToolStripButton1
            // 
            this.printToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.printToolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("printToolStripButton1.Image")));
            this.printToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.printToolStripButton1.Name = "printToolStripButton1";
            this.printToolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.printToolStripButton1.Text = "&Print";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // cutToolStripButton1
            // 
            this.cutToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cutToolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("cutToolStripButton1.Image")));
            this.cutToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cutToolStripButton1.Name = "cutToolStripButton1";
            this.cutToolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.cutToolStripButton1.Text = "C&ut";
            // 
            // copyToolStripButton1
            // 
            this.copyToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.copyToolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("copyToolStripButton1.Image")));
            this.copyToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.copyToolStripButton1.Name = "copyToolStripButton1";
            this.copyToolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.copyToolStripButton1.Text = "&Copy";
            // 
            // pasteToolStripButton1
            // 
            this.pasteToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pasteToolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("pasteToolStripButton1.Image")));
            this.pasteToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pasteToolStripButton1.Name = "pasteToolStripButton1";
            this.pasteToolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.pasteToolStripButton1.Text = "&Paste";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // helpToolStripButton1
            // 
            this.helpToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.helpToolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("helpToolStripButton1.Image")));
            this.helpToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.helpToolStripButton1.Name = "helpToolStripButton1";
            this.helpToolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.helpToolStripButton1.Text = "He&lp";
            // 
            // newToolStripButton2
            // 
            this.newToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.newToolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripButton2.Image")));
            this.newToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newToolStripButton2.Name = "newToolStripButton2";
            this.newToolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.newToolStripButton2.Text = "&New";
            // 
            // openToolStripButton2
            // 
            this.openToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.openToolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripButton2.Image")));
            this.openToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openToolStripButton2.Name = "openToolStripButton2";
            this.openToolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.openToolStripButton2.Text = "&Open";
            // 
            // saveToolStripButton2
            // 
            this.saveToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveToolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripButton2.Image")));
            this.saveToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripButton2.Name = "saveToolStripButton2";
            this.saveToolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.saveToolStripButton2.Text = "&Save";
            // 
            // printToolStripButton2
            // 
            this.printToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.printToolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("printToolStripButton2.Image")));
            this.printToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.printToolStripButton2.Name = "printToolStripButton2";
            this.printToolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.printToolStripButton2.Text = "&Print";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // cutToolStripButton2
            // 
            this.cutToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cutToolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("cutToolStripButton2.Image")));
            this.cutToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cutToolStripButton2.Name = "cutToolStripButton2";
            this.cutToolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.cutToolStripButton2.Text = "C&ut";
            // 
            // copyToolStripButton2
            // 
            this.copyToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.copyToolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("copyToolStripButton2.Image")));
            this.copyToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.copyToolStripButton2.Name = "copyToolStripButton2";
            this.copyToolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.copyToolStripButton2.Text = "&Copy";
            // 
            // pasteToolStripButton2
            // 
            this.pasteToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pasteToolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("pasteToolStripButton2.Image")));
            this.pasteToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pasteToolStripButton2.Name = "pasteToolStripButton2";
            this.pasteToolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.pasteToolStripButton2.Text = "&Paste";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // helpToolStripButton2
            // 
            this.helpToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.helpToolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("helpToolStripButton2.Image")));
            this.helpToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.helpToolStripButton2.Name = "helpToolStripButton2";
            this.helpToolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.helpToolStripButton2.Text = "He&lp";
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
            // gdLowis
            // 
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
            // gvLowis
            // 
            this.gvLowis.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colFacilityWellName,
            this.colAnalogPointDescription,
            this.colCurrentValue,
            this.colTodayMaxValue,
            this.colTodayMinValue,
            this.colTodayAvgValue,
            this.colMonthlyAvgValue,
            this.colLastMonthAvgValue,
            this.colHiHiAlarm,
            this.colHiAlarm,
            this.colLoAlarm,
            this.colLoLoAlarm,
            this.colClamp,
            this.colSensorFail,
            this.colDate,
            this.colTime,
            this.colPointType,
            this.colEngUnits,
            this.colOnTrend});
            this.gvLowis.GridControl = this.gdLowis;
            this.gvLowis.Name = "gvLowis";
            this.gvLowis.OptionsBehavior.Editable = false;
            this.gvLowis.OptionsView.ColumnAutoWidth = false;
            // 
            // colFacilityWellName
            // 
            this.colFacilityWellName.FieldName = "FacilityWellName";
            this.colFacilityWellName.Name = "colFacilityWellName";
            this.colFacilityWellName.Visible = true;
            this.colFacilityWellName.VisibleIndex = 0;
            // 
            // colAnalogPointDescription
            // 
            this.colAnalogPointDescription.FieldName = "AnalogPointDescription";
            this.colAnalogPointDescription.Name = "colAnalogPointDescription";
            this.colAnalogPointDescription.Visible = true;
            this.colAnalogPointDescription.VisibleIndex = 1;
            // 
            // colCurrentValue
            // 
            this.colCurrentValue.FieldName = "CurrentValue";
            this.colCurrentValue.Name = "colCurrentValue";
            this.colCurrentValue.Visible = true;
            this.colCurrentValue.VisibleIndex = 2;
            // 
            // colTodayMaxValue
            // 
            this.colTodayMaxValue.FieldName = "TodayMaxValue";
            this.colTodayMaxValue.Name = "colTodayMaxValue";
            this.colTodayMaxValue.Visible = true;
            this.colTodayMaxValue.VisibleIndex = 3;
            // 
            // colTodayMinValue
            // 
            this.colTodayMinValue.FieldName = "TodayMinValue";
            this.colTodayMinValue.Name = "colTodayMinValue";
            this.colTodayMinValue.Visible = true;
            this.colTodayMinValue.VisibleIndex = 4;
            // 
            // colTodayAvgValue
            // 
            this.colTodayAvgValue.FieldName = "TodayAvgValue";
            this.colTodayAvgValue.Name = "colTodayAvgValue";
            this.colTodayAvgValue.Visible = true;
            this.colTodayAvgValue.VisibleIndex = 5;
            // 
            // colMonthlyAvgValue
            // 
            this.colMonthlyAvgValue.FieldName = "MonthlyAvgValue";
            this.colMonthlyAvgValue.Name = "colMonthlyAvgValue";
            this.colMonthlyAvgValue.Visible = true;
            this.colMonthlyAvgValue.VisibleIndex = 6;
            // 
            // colLastMonthAvgValue
            // 
            this.colLastMonthAvgValue.FieldName = "LastMonthAvgValue";
            this.colLastMonthAvgValue.Name = "colLastMonthAvgValue";
            this.colLastMonthAvgValue.Visible = true;
            this.colLastMonthAvgValue.VisibleIndex = 7;
            // 
            // colHiHiAlarm
            // 
            this.colHiHiAlarm.FieldName = "HiHiAlarm";
            this.colHiHiAlarm.Name = "colHiHiAlarm";
            this.colHiHiAlarm.Visible = true;
            this.colHiHiAlarm.VisibleIndex = 8;
            // 
            // colHiAlarm
            // 
            this.colHiAlarm.FieldName = "HiAlarm";
            this.colHiAlarm.Name = "colHiAlarm";
            this.colHiAlarm.Visible = true;
            this.colHiAlarm.VisibleIndex = 9;
            // 
            // colLoAlarm
            // 
            this.colLoAlarm.FieldName = "LoAlarm";
            this.colLoAlarm.Name = "colLoAlarm";
            this.colLoAlarm.Visible = true;
            this.colLoAlarm.VisibleIndex = 10;
            // 
            // colLoLoAlarm
            // 
            this.colLoLoAlarm.FieldName = "LoLoAlarm";
            this.colLoLoAlarm.Name = "colLoLoAlarm";
            this.colLoLoAlarm.Visible = true;
            this.colLoLoAlarm.VisibleIndex = 11;
            // 
            // colClamp
            // 
            this.colClamp.FieldName = "Clamp";
            this.colClamp.Name = "colClamp";
            this.colClamp.Visible = true;
            this.colClamp.VisibleIndex = 12;
            // 
            // colSensorFail
            // 
            this.colSensorFail.FieldName = "SensorFail";
            this.colSensorFail.Name = "colSensorFail";
            this.colSensorFail.Visible = true;
            this.colSensorFail.VisibleIndex = 13;
            // 
            // colDate
            // 
            this.colDate.FieldName = "Date";
            this.colDate.Name = "colDate";
            this.colDate.Visible = true;
            this.colDate.VisibleIndex = 14;
            // 
            // colTime
            // 
            this.colTime.FieldName = "Time";
            this.colTime.Name = "colTime";
            this.colTime.Visible = true;
            this.colTime.VisibleIndex = 15;
            // 
            // colPointType
            // 
            this.colPointType.FieldName = "PointType";
            this.colPointType.Name = "colPointType";
            this.colPointType.Visible = true;
            this.colPointType.VisibleIndex = 16;
            // 
            // colEngUnits
            // 
            this.colEngUnits.FieldName = "EngUnits";
            this.colEngUnits.Name = "colEngUnits";
            this.colEngUnits.Visible = true;
            this.colEngUnits.VisibleIndex = 17;
            // 
            // colOnTrend
            // 
            this.colOnTrend.FieldName = "OnTrend";
            this.colOnTrend.Name = "colOnTrend";
            this.colOnTrend.Visible = true;
            this.colOnTrend.VisibleIndex = 18;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.gridSplitContainer1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1412, 515);
            this.panel2.TabIndex = 15;
            // 
            // gridSplitContainer1
            // 
            this.gridSplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridSplitContainer1.Grid = this.gdLowis;
            this.gridSplitContainer1.Location = new System.Drawing.Point(0, 0);
            this.gridSplitContainer1.Name = "gridSplitContainer1";
            // 
            // gridSplitContainer1.Panel1
            // 
            this.gridSplitContainer1.Panel1.Controls.Add(this.gdLowis);
            this.gridSplitContainer1.Size = new System.Drawing.Size(1412, 515);
            this.gridSplitContainer1.TabIndex = 0;
            // 
            // lw2DataSet10
            // 
            this.lw2DataSet10.DataSetName = "lw2DataSet10";
            this.lw2DataSet10.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // prosedurgetdataGroupanalogstatusBindingSource
            // 
            this.prosedurgetdataGroupanalogstatusBindingSource.DataMember = "prosedur_getdataGroupanalogstatus";
            this.prosedurgetdataGroupanalogstatusBindingSource.DataSource = this.lw2DataSet10;
            // 
            // prosedur_getdataGroupanalogstatusTableAdapter
            // 
            this.prosedur_getdataGroupanalogstatusTableAdapter.ClearBeforeFill = true;
            // 
            // GroupAnalogStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "GroupAnalogStatus";
            this.Size = new System.Drawing.Size(1412, 515);
            this.Load += new System.EventHandler(this.GroupAnalogStatus_Load);
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
            ((System.ComponentModel.ISupportInitialize)(this.gdLowis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvLowis)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridSplitContainer1.Panel1)).EndInit();
            this.gridSplitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridSplitContainer1.Panel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSplitContainer1)).EndInit();
            this.gridSplitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lw2DataSet10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prosedurgetdataGroupanalogstatusBindingSource)).EndInit();
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
        private DevExpress.XtraGrid.GridControl gdLowis;
        private DevExpress.XtraGrid.Views.Grid.GridView gvLowis;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraGrid.Columns.GridColumn colFacilityWellName;
        private DevExpress.XtraGrid.Columns.GridColumn colAnalogPointDescription;
        private DevExpress.XtraGrid.Columns.GridColumn colCurrentValue;
        private DevExpress.XtraGrid.Columns.GridColumn colTodayMaxValue;
        private DevExpress.XtraGrid.Columns.GridColumn colTodayMinValue;
        private DevExpress.XtraGrid.Columns.GridColumn colTodayAvgValue;
        private DevExpress.XtraGrid.Columns.GridColumn colMonthlyAvgValue;
        private DevExpress.XtraGrid.Columns.GridColumn colLastMonthAvgValue;
        private DevExpress.XtraGrid.Columns.GridColumn colHiHiAlarm;
        private DevExpress.XtraGrid.Columns.GridColumn colHiAlarm;
        private DevExpress.XtraGrid.Columns.GridColumn colLoAlarm;
        private DevExpress.XtraGrid.Columns.GridColumn colLoLoAlarm;
        private DevExpress.XtraGrid.Columns.GridColumn colClamp;
        private DevExpress.XtraGrid.Columns.GridColumn colSensorFail;
        private DevExpress.XtraGrid.Columns.GridColumn colDate;
        private DevExpress.XtraGrid.Columns.GridColumn colTime;
        private DevExpress.XtraGrid.Columns.GridColumn colPointType;
        private DevExpress.XtraGrid.Columns.GridColumn colEngUnits;
        private DevExpress.XtraGrid.Columns.GridColumn colOnTrend;
        private DevExpress.XtraGrid.GridSplitContainer gridSplitContainer1;
        private lw2DataSet10 lw2DataSet10;
        private System.Windows.Forms.BindingSource prosedurgetdataGroupanalogstatusBindingSource;
        private lw2DataSet10TableAdapters.prosedur_getdataGroupanalogstatusTableAdapter prosedur_getdataGroupanalogstatusTableAdapter;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton newToolStripButton1;
        private System.Windows.Forms.ToolStripButton openToolStripButton1;
        private System.Windows.Forms.ToolStripButton saveToolStripButton1;
        private System.Windows.Forms.ToolStripButton printToolStripButton1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton cutToolStripButton1;
        private System.Windows.Forms.ToolStripButton copyToolStripButton1;
        private System.Windows.Forms.ToolStripButton pasteToolStripButton1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton helpToolStripButton1;
        private System.Windows.Forms.ToolStripButton newToolStripButton2;
        private System.Windows.Forms.ToolStripButton openToolStripButton2;
        private System.Windows.Forms.ToolStripButton saveToolStripButton2;
        private System.Windows.Forms.ToolStripButton printToolStripButton2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton cutToolStripButton2;
        private System.Windows.Forms.ToolStripButton copyToolStripButton2;
        private System.Windows.Forms.ToolStripButton pasteToolStripButton2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton helpToolStripButton2;
    }
}
