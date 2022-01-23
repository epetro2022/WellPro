namespace LowisChartApp.lw
{
    partial class BeamWellGroupConfiguration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BeamWellGroupConfiguration));
            DevExpress.DataAccess.Sql.StoredProcQuery storedProcQuery1 = new DevExpress.DataAccess.Sql.StoredProcQuery();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter1 = new DevExpress.DataAccess.Sql.QueryParameter();
            this.lw2DataSet1 = new LowisChartApp.lw2DataSet1();
            this.prosedur_getdataGroupDescreteConfigTableAdapter = new LowisChartApp.lw2DataSet1TableAdapters.prosedur_getdataGroupDescreteConfigTableAdapter();
            this.prosedurgetdatabeamWellGroupStatusBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.prosedurgetdataWellGroupStatusBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.newToolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.EditToolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.DeleteToolStripButton1 = new System.Windows.Forms.ToolStripButton();
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.gdLowis = new DevExpress.XtraGrid.GridControl();
            this.gvLowis = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colWellNameLWNAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWellNameNAVNAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUniqueWellboreIDAPI10 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUniqueWellboreHoleIDAPI12 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUniqueIntervalIDAPI14 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGroup1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGroup2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGroup3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGroup4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGeographicalXCoord = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGeographicalYCoord = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colControllerName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colControllerSubType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProtocol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCommPort = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRTUAddress = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAlternateIPOPCAddress = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCommunicationRetries = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKeyOnDelay = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKeyOffDelay = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAlarmDelay = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colClearDelay = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCasingOD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCasingWeight = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTubingOD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTubingGrade = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTubingType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPlugBackTD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTubingRoughness = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTubingLength = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTopPerforation = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBottomPerforation = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colInstallDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPumpIntake = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMotorHz = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLastChgDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDiluentInjectiondepth = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTubingDischargePressure = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSurfCasingPres = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTubingDischargeTemperature = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGOR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWaterCut = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalLiquidProd = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colInjDilutionWater = new DevExpress.XtraGrid.Columns.GridColumn();
            this.prosedurgetdataBeamWellGroupConfigurationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lw2DataSet2 = new LowisChartApp.lw2DataSet2();
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.lw2DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.prosedurgetdataGroupDescreteConfigBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lw2DataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.prosedur_getdataBeamWellGroupConfigurationTableAdapter = new LowisChartApp.lw2DataSet2TableAdapters.prosedur_getdataBeamWellGroupConfigurationTableAdapter();
            this.lw2DataSet6 = new LowisChartApp.lw2DataSet6();
            this.prosedurgetdataBeamWellGroupConfigurationBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.prosedur_getdataBeamWellGroupConfigurationTableAdapter1 = new LowisChartApp.lw2DataSet6TableAdapters.prosedur_getdataBeamWellGroupConfigurationTableAdapter();
            this.lw2DataSet7 = new LowisChartApp.lw2DataSet7();
            this.prosedurgetdataBeamWellGroupConfigurationBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.prosedur_getdataBeamWellGroupConfigurationTableAdapter2 = new LowisChartApp.lw2DataSet7TableAdapters.prosedur_getdataBeamWellGroupConfigurationTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.lw2DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prosedurgetdatabeamWellGroupStatusBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prosedurgetdataWellGroupStatusBindingSource1)).BeginInit();
            this.panel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdLowis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvLowis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prosedurgetdataBeamWellGroupConfigurationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lw2DataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lw2DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prosedurgetdataGroupDescreteConfigBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lw2DataSetBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lw2DataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prosedurgetdataBeamWellGroupConfigurationBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lw2DataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prosedurgetdataBeamWellGroupConfigurationBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // lw2DataSet1
            // 
            this.lw2DataSet1.DataSetName = "lw2DataSet1";
            this.lw2DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.panel1.Controls.Add(this.toolStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1412, 32);
            this.panel1.TabIndex = 12;
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripButton1,
            this.EditToolStripButton1,
            this.DeleteToolStripButton1,
            this.toolStripSeparator2,
            this.printToolStripButton1,
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
            this.newToolStripButton1.Text = "&Add_New_Well";
            // 
            // EditToolStripButton1
            // 
            this.EditToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.EditToolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("EditToolStripButton1.Image")));
            this.EditToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.EditToolStripButton1.Name = "EditToolStripButton1";
            this.EditToolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.EditToolStripButton1.Text = "&Edit Well";
            // 
            // DeleteToolStripButton1
            // 
            this.DeleteToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.DeleteToolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("DeleteToolStripButton1.Image")));
            this.DeleteToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DeleteToolStripButton1.Name = "DeleteToolStripButton1";
            this.DeleteToolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.DeleteToolStripButton1.Text = "&Delete Well";
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
            // panel2
            // 
            this.panel2.Controls.Add(this.gdLowis);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1412, 515);
            this.panel2.TabIndex = 13;
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
            this.gdLowis.MouseDown += new System.Windows.Forms.MouseEventHandler(this.gdLowis_MouseDown);
            this.gdLowis.MouseUp += new System.Windows.Forms.MouseEventHandler(this.gdLowis_MouseUp);
            // 
            // gvLowis
            // 
            this.gvLowis.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colWellNameLWNAME,
            this.colWellNameNAVNAME,
            this.colUniqueWellboreIDAPI10,
            this.colUniqueWellboreHoleIDAPI12,
            this.colUniqueIntervalIDAPI14,
            this.colGroup1,
            this.colGroup2,
            this.colGroup3,
            this.colGroup4,
            this.colGeographicalXCoord,
            this.colGeographicalYCoord,
            this.colControllerName,
            this.colControllerSubType,
            this.colProtocol,
            this.colCommPort,
            this.colRTUAddress,
            this.colAlternateIPOPCAddress,
            this.colCommunicationRetries,
            this.colKeyOnDelay,
            this.colKeyOffDelay,
            this.colAlarmDelay,
            this.colClearDelay,
            this.colCasingOD,
            this.colCasingWeight,
            this.colTubingOD,
            this.colTubingGrade,
            this.colTubingType,
            this.colPlugBackTD,
            this.colTubingRoughness,
            this.colTubingLength,
            this.colTopPerforation,
            this.colBottomPerforation,
            this.colInstallDate,
            this.colPumpIntake,
            this.colMotorHz,
            this.colLastChgDate,
            this.colDiluentInjectiondepth,
            this.colTubingDischargePressure,
            this.colSurfCasingPres,
            this.colTubingDischargeTemperature,
            this.colGOR,
            this.colWaterCut,
            this.colTotalLiquidProd,
            this.colInjDilutionWater});
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
            // colWellNameNAVNAME
            // 
            this.colWellNameNAVNAME.FieldName = "WellNameNAVNAME";
            this.colWellNameNAVNAME.Name = "colWellNameNAVNAME";
            this.colWellNameNAVNAME.Visible = true;
            this.colWellNameNAVNAME.VisibleIndex = 1;
            this.colWellNameNAVNAME.Width = 78;
            // 
            // colUniqueWellboreIDAPI10
            // 
            this.colUniqueWellboreIDAPI10.FieldName = "UniqueWellboreIDAPI10";
            this.colUniqueWellboreIDAPI10.Name = "colUniqueWellboreIDAPI10";
            this.colUniqueWellboreIDAPI10.Visible = true;
            this.colUniqueWellboreIDAPI10.VisibleIndex = 2;
            // 
            // colUniqueWellboreHoleIDAPI12
            // 
            this.colUniqueWellboreHoleIDAPI12.FieldName = "UniqueWellboreHoleIDAPI12";
            this.colUniqueWellboreHoleIDAPI12.Name = "colUniqueWellboreHoleIDAPI12";
            this.colUniqueWellboreHoleIDAPI12.Visible = true;
            this.colUniqueWellboreHoleIDAPI12.VisibleIndex = 3;
            // 
            // colUniqueIntervalIDAPI14
            // 
            this.colUniqueIntervalIDAPI14.FieldName = "UniqueIntervalIDAPI14";
            this.colUniqueIntervalIDAPI14.Name = "colUniqueIntervalIDAPI14";
            this.colUniqueIntervalIDAPI14.Visible = true;
            this.colUniqueIntervalIDAPI14.VisibleIndex = 4;
            // 
            // colGroup1
            // 
            this.colGroup1.FieldName = "Group1";
            this.colGroup1.Name = "colGroup1";
            this.colGroup1.Visible = true;
            this.colGroup1.VisibleIndex = 5;
            // 
            // colGroup2
            // 
            this.colGroup2.FieldName = "Group2";
            this.colGroup2.Name = "colGroup2";
            this.colGroup2.Visible = true;
            this.colGroup2.VisibleIndex = 6;
            // 
            // colGroup3
            // 
            this.colGroup3.FieldName = "Group3";
            this.colGroup3.Name = "colGroup3";
            this.colGroup3.Visible = true;
            this.colGroup3.VisibleIndex = 7;
            // 
            // colGroup4
            // 
            this.colGroup4.FieldName = "Group4";
            this.colGroup4.Name = "colGroup4";
            this.colGroup4.Visible = true;
            this.colGroup4.VisibleIndex = 8;
            // 
            // colGeographicalXCoord
            // 
            this.colGeographicalXCoord.FieldName = "GeographicalXCoord";
            this.colGeographicalXCoord.Name = "colGeographicalXCoord";
            this.colGeographicalXCoord.Visible = true;
            this.colGeographicalXCoord.VisibleIndex = 9;
            // 
            // colGeographicalYCoord
            // 
            this.colGeographicalYCoord.FieldName = "GeographicalYCoord";
            this.colGeographicalYCoord.Name = "colGeographicalYCoord";
            this.colGeographicalYCoord.Visible = true;
            this.colGeographicalYCoord.VisibleIndex = 10;
            // 
            // colControllerName
            // 
            this.colControllerName.FieldName = "ControllerName";
            this.colControllerName.Name = "colControllerName";
            this.colControllerName.Visible = true;
            this.colControllerName.VisibleIndex = 11;
            // 
            // colControllerSubType
            // 
            this.colControllerSubType.FieldName = "ControllerSubType";
            this.colControllerSubType.Name = "colControllerSubType";
            this.colControllerSubType.Visible = true;
            this.colControllerSubType.VisibleIndex = 12;
            // 
            // colProtocol
            // 
            this.colProtocol.FieldName = "Protocol";
            this.colProtocol.Name = "colProtocol";
            this.colProtocol.Visible = true;
            this.colProtocol.VisibleIndex = 13;
            // 
            // colCommPort
            // 
            this.colCommPort.FieldName = "CommPort";
            this.colCommPort.Name = "colCommPort";
            this.colCommPort.Visible = true;
            this.colCommPort.VisibleIndex = 14;
            // 
            // colRTUAddress
            // 
            this.colRTUAddress.FieldName = "RTUAddress";
            this.colRTUAddress.Name = "colRTUAddress";
            this.colRTUAddress.Visible = true;
            this.colRTUAddress.VisibleIndex = 15;
            // 
            // colAlternateIPOPCAddress
            // 
            this.colAlternateIPOPCAddress.FieldName = "AlternateIPOPCAddress";
            this.colAlternateIPOPCAddress.Name = "colAlternateIPOPCAddress";
            this.colAlternateIPOPCAddress.Visible = true;
            this.colAlternateIPOPCAddress.VisibleIndex = 16;
            // 
            // colCommunicationRetries
            // 
            this.colCommunicationRetries.FieldName = "CommunicationRetries";
            this.colCommunicationRetries.Name = "colCommunicationRetries";
            this.colCommunicationRetries.Visible = true;
            this.colCommunicationRetries.VisibleIndex = 17;
            // 
            // colKeyOnDelay
            // 
            this.colKeyOnDelay.FieldName = "KeyOnDelay";
            this.colKeyOnDelay.Name = "colKeyOnDelay";
            this.colKeyOnDelay.Visible = true;
            this.colKeyOnDelay.VisibleIndex = 18;
            // 
            // colKeyOffDelay
            // 
            this.colKeyOffDelay.FieldName = "KeyOffDelay";
            this.colKeyOffDelay.Name = "colKeyOffDelay";
            this.colKeyOffDelay.Visible = true;
            this.colKeyOffDelay.VisibleIndex = 19;
            // 
            // colAlarmDelay
            // 
            this.colAlarmDelay.FieldName = "AlarmDelay";
            this.colAlarmDelay.Name = "colAlarmDelay";
            this.colAlarmDelay.Visible = true;
            this.colAlarmDelay.VisibleIndex = 20;
            // 
            // colClearDelay
            // 
            this.colClearDelay.FieldName = "ClearDelay";
            this.colClearDelay.Name = "colClearDelay";
            this.colClearDelay.Visible = true;
            this.colClearDelay.VisibleIndex = 21;
            // 
            // colCasingOD
            // 
            this.colCasingOD.FieldName = "CasingOD";
            this.colCasingOD.Name = "colCasingOD";
            this.colCasingOD.Visible = true;
            this.colCasingOD.VisibleIndex = 22;
            // 
            // colCasingWeight
            // 
            this.colCasingWeight.FieldName = "CasingWeight";
            this.colCasingWeight.Name = "colCasingWeight";
            this.colCasingWeight.Visible = true;
            this.colCasingWeight.VisibleIndex = 23;
            // 
            // colTubingOD
            // 
            this.colTubingOD.FieldName = "TubingOD";
            this.colTubingOD.Name = "colTubingOD";
            this.colTubingOD.Visible = true;
            this.colTubingOD.VisibleIndex = 24;
            // 
            // colTubingGrade
            // 
            this.colTubingGrade.FieldName = "TubingGrade";
            this.colTubingGrade.Name = "colTubingGrade";
            this.colTubingGrade.Visible = true;
            this.colTubingGrade.VisibleIndex = 25;
            // 
            // colTubingType
            // 
            this.colTubingType.FieldName = "TubingType";
            this.colTubingType.Name = "colTubingType";
            this.colTubingType.Visible = true;
            this.colTubingType.VisibleIndex = 26;
            // 
            // colPlugBackTD
            // 
            this.colPlugBackTD.FieldName = "PlugBackTD";
            this.colPlugBackTD.Name = "colPlugBackTD";
            this.colPlugBackTD.Visible = true;
            this.colPlugBackTD.VisibleIndex = 27;
            // 
            // colTubingRoughness
            // 
            this.colTubingRoughness.FieldName = "TubingRoughness";
            this.colTubingRoughness.Name = "colTubingRoughness";
            this.colTubingRoughness.Visible = true;
            this.colTubingRoughness.VisibleIndex = 28;
            // 
            // colTubingLength
            // 
            this.colTubingLength.FieldName = "TubingLength";
            this.colTubingLength.Name = "colTubingLength";
            this.colTubingLength.Visible = true;
            this.colTubingLength.VisibleIndex = 29;
            // 
            // colTopPerforation
            // 
            this.colTopPerforation.FieldName = "TopPerforation";
            this.colTopPerforation.Name = "colTopPerforation";
            this.colTopPerforation.Visible = true;
            this.colTopPerforation.VisibleIndex = 30;
            // 
            // colBottomPerforation
            // 
            this.colBottomPerforation.FieldName = "BottomPerforation";
            this.colBottomPerforation.Name = "colBottomPerforation";
            this.colBottomPerforation.Visible = true;
            this.colBottomPerforation.VisibleIndex = 31;
            // 
            // colInstallDate
            // 
            this.colInstallDate.FieldName = "InstallDate";
            this.colInstallDate.Name = "colInstallDate";
            this.colInstallDate.Visible = true;
            this.colInstallDate.VisibleIndex = 32;
            // 
            // colPumpIntake
            // 
            this.colPumpIntake.FieldName = "PumpIntake";
            this.colPumpIntake.Name = "colPumpIntake";
            this.colPumpIntake.Visible = true;
            this.colPumpIntake.VisibleIndex = 33;
            // 
            // colMotorHz
            // 
            this.colMotorHz.FieldName = "MotorHz";
            this.colMotorHz.Name = "colMotorHz";
            this.colMotorHz.Visible = true;
            this.colMotorHz.VisibleIndex = 34;
            // 
            // colLastChgDate
            // 
            this.colLastChgDate.FieldName = "LastChgDate";
            this.colLastChgDate.Name = "colLastChgDate";
            this.colLastChgDate.Visible = true;
            this.colLastChgDate.VisibleIndex = 35;
            // 
            // colDiluentInjectiondepth
            // 
            this.colDiluentInjectiondepth.FieldName = "DiluentInjectiondepth";
            this.colDiluentInjectiondepth.Name = "colDiluentInjectiondepth";
            this.colDiluentInjectiondepth.Visible = true;
            this.colDiluentInjectiondepth.VisibleIndex = 36;
            // 
            // colTubingDischargePressure
            // 
            this.colTubingDischargePressure.FieldName = "TubingDischargePressure";
            this.colTubingDischargePressure.Name = "colTubingDischargePressure";
            this.colTubingDischargePressure.Visible = true;
            this.colTubingDischargePressure.VisibleIndex = 37;
            // 
            // colSurfCasingPres
            // 
            this.colSurfCasingPres.FieldName = "SurfCasingPres";
            this.colSurfCasingPres.Name = "colSurfCasingPres";
            this.colSurfCasingPres.Visible = true;
            this.colSurfCasingPres.VisibleIndex = 38;
            // 
            // colTubingDischargeTemperature
            // 
            this.colTubingDischargeTemperature.FieldName = "TubingDischargeTemperature";
            this.colTubingDischargeTemperature.Name = "colTubingDischargeTemperature";
            this.colTubingDischargeTemperature.Visible = true;
            this.colTubingDischargeTemperature.VisibleIndex = 39;
            // 
            // colGOR
            // 
            this.colGOR.FieldName = "GOR";
            this.colGOR.Name = "colGOR";
            this.colGOR.Visible = true;
            this.colGOR.VisibleIndex = 40;
            // 
            // colWaterCut
            // 
            this.colWaterCut.FieldName = "WaterCut";
            this.colWaterCut.Name = "colWaterCut";
            this.colWaterCut.Visible = true;
            this.colWaterCut.VisibleIndex = 41;
            // 
            // colTotalLiquidProd
            // 
            this.colTotalLiquidProd.FieldName = "TotalLiquidProd";
            this.colTotalLiquidProd.Name = "colTotalLiquidProd";
            this.colTotalLiquidProd.Visible = true;
            this.colTotalLiquidProd.VisibleIndex = 42;
            // 
            // colInjDilutionWater
            // 
            this.colInjDilutionWater.FieldName = "InjDilutionWater";
            this.colInjDilutionWater.Name = "colInjDilutionWater";
            this.colInjDilutionWater.Visible = true;
            this.colInjDilutionWater.VisibleIndex = 43;
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
            // lw2DataSet7
            // 
            this.lw2DataSet7.DataSetName = "lw2DataSet7";
            this.lw2DataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // prosedurgetdataBeamWellGroupConfigurationBindingSource2
            // 
            this.prosedurgetdataBeamWellGroupConfigurationBindingSource2.DataMember = "prosedur_getdataBeamWellGroupConfiguration";
            this.prosedurgetdataBeamWellGroupConfigurationBindingSource2.DataSource = this.lw2DataSet7;
            // 
            // prosedur_getdataBeamWellGroupConfigurationTableAdapter2
            // 
            this.prosedur_getdataBeamWellGroupConfigurationTableAdapter2.ClearBeforeFill = true;
            // 
            // BeamWellGroupConfiguration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "BeamWellGroupConfiguration";
            this.Size = new System.Drawing.Size(1412, 515);
            this.Load += new System.EventHandler(this.BeamWellGroupConfiguration_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lw2DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prosedurgetdatabeamWellGroupStatusBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prosedurgetdataWellGroupStatusBindingSource1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gdLowis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvLowis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prosedurgetdataBeamWellGroupConfigurationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lw2DataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lw2DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prosedurgetdataGroupDescreteConfigBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lw2DataSetBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lw2DataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prosedurgetdataBeamWellGroupConfigurationBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lw2DataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prosedurgetdataBeamWellGroupConfigurationBindingSource2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private lw2DataSet1 lw2DataSet1;
        private lw2DataSet1TableAdapters.prosedur_getdataGroupDescreteConfigTableAdapter prosedur_getdataGroupDescreteConfigTableAdapter;
        private System.Windows.Forms.BindingSource prosedurgetdatabeamWellGroupStatusBindingSource;
        private System.Windows.Forms.BindingSource prosedurgetdataWellGroupStatusBindingSource1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraGrid.GridControl gdLowis;
        private DevExpress.XtraGrid.Views.Grid.GridView gvLowis;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
        private System.Windows.Forms.BindingSource lw2DataSetBindingSource;
        private System.Windows.Forms.BindingSource prosedurgetdataGroupDescreteConfigBindingSource;
        private System.Windows.Forms.BindingSource lw2DataSetBindingSource1;
        private System.Windows.Forms.BindingSource prosedurgetdataBeamWellGroupConfigurationBindingSource;
        private lw2DataSet2 lw2DataSet2;
        private lw2DataSet2TableAdapters.prosedur_getdataBeamWellGroupConfigurationTableAdapter prosedur_getdataBeamWellGroupConfigurationTableAdapter;
        private System.Windows.Forms.BindingSource prosedurgetdataBeamWellGroupConfigurationBindingSource1;
        private lw2DataSet6 lw2DataSet6;
        private lw2DataSet6TableAdapters.prosedur_getdataBeamWellGroupConfigurationTableAdapter prosedur_getdataBeamWellGroupConfigurationTableAdapter1;
        private System.Windows.Forms.BindingSource prosedurgetdataBeamWellGroupConfigurationBindingSource2;
        private lw2DataSet7 lw2DataSet7;
        private DevExpress.XtraGrid.Columns.GridColumn colWellNameLWNAME;
        private DevExpress.XtraGrid.Columns.GridColumn colWellNameNAVNAME;
        private DevExpress.XtraGrid.Columns.GridColumn colUniqueWellboreIDAPI10;
        private DevExpress.XtraGrid.Columns.GridColumn colUniqueWellboreHoleIDAPI12;
        private DevExpress.XtraGrid.Columns.GridColumn colUniqueIntervalIDAPI14;
        private DevExpress.XtraGrid.Columns.GridColumn colGroup1;
        private DevExpress.XtraGrid.Columns.GridColumn colGroup2;
        private DevExpress.XtraGrid.Columns.GridColumn colGroup3;
        private DevExpress.XtraGrid.Columns.GridColumn colGroup4;
        private DevExpress.XtraGrid.Columns.GridColumn colGeographicalXCoord;
        private DevExpress.XtraGrid.Columns.GridColumn colGeographicalYCoord;
        private DevExpress.XtraGrid.Columns.GridColumn colControllerName;
        private DevExpress.XtraGrid.Columns.GridColumn colControllerSubType;
        private DevExpress.XtraGrid.Columns.GridColumn colProtocol;
        private DevExpress.XtraGrid.Columns.GridColumn colCommPort;
        private DevExpress.XtraGrid.Columns.GridColumn colRTUAddress;
        private DevExpress.XtraGrid.Columns.GridColumn colAlternateIPOPCAddress;
        private DevExpress.XtraGrid.Columns.GridColumn colCommunicationRetries;
        private DevExpress.XtraGrid.Columns.GridColumn colKeyOnDelay;
        private DevExpress.XtraGrid.Columns.GridColumn colKeyOffDelay;
        private DevExpress.XtraGrid.Columns.GridColumn colAlarmDelay;
        private DevExpress.XtraGrid.Columns.GridColumn colClearDelay;
        private DevExpress.XtraGrid.Columns.GridColumn colCasingOD;
        private DevExpress.XtraGrid.Columns.GridColumn colCasingWeight;
        private DevExpress.XtraGrid.Columns.GridColumn colTubingOD;
        private DevExpress.XtraGrid.Columns.GridColumn colTubingGrade;
        private DevExpress.XtraGrid.Columns.GridColumn colTubingType;
        private DevExpress.XtraGrid.Columns.GridColumn colPlugBackTD;
        private DevExpress.XtraGrid.Columns.GridColumn colTubingRoughness;
        private DevExpress.XtraGrid.Columns.GridColumn colTubingLength;
        private DevExpress.XtraGrid.Columns.GridColumn colTopPerforation;
        private DevExpress.XtraGrid.Columns.GridColumn colBottomPerforation;
        private DevExpress.XtraGrid.Columns.GridColumn colInstallDate;
        private DevExpress.XtraGrid.Columns.GridColumn colPumpIntake;
        private DevExpress.XtraGrid.Columns.GridColumn colMotorHz;
        private DevExpress.XtraGrid.Columns.GridColumn colLastChgDate;
        private DevExpress.XtraGrid.Columns.GridColumn colDiluentInjectiondepth;
        private DevExpress.XtraGrid.Columns.GridColumn colTubingDischargePressure;
        private DevExpress.XtraGrid.Columns.GridColumn colSurfCasingPres;
        private DevExpress.XtraGrid.Columns.GridColumn colTubingDischargeTemperature;
        private DevExpress.XtraGrid.Columns.GridColumn colGOR;
        private DevExpress.XtraGrid.Columns.GridColumn colWaterCut;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalLiquidProd;
        private DevExpress.XtraGrid.Columns.GridColumn colInjDilutionWater;
        private lw2DataSet7TableAdapters.prosedur_getdataBeamWellGroupConfigurationTableAdapter prosedur_getdataBeamWellGroupConfigurationTableAdapter2;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton newToolStripButton1;
        private System.Windows.Forms.ToolStripButton EditToolStripButton1;
        private System.Windows.Forms.ToolStripButton DeleteToolStripButton1;
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
