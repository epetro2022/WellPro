namespace LowisChartApp.lw
{
    partial class LowisForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LowisForm));
            DevExpress.DataAccess.Sql.StoredProcQuery storedProcQuery1 = new DevExpress.DataAccess.Sql.StoredProcQuery();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter1 = new DevExpress.DataAccess.Sql.QueryParameter();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pgbar = new System.Windows.Forms.ProgressBar();
            this.gdLowis = new DevExpress.XtraGrid.GridControl();
            this.gvLowis = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWELLNAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colARSE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSCANTIME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSCANDATE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colALARM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLASTGOOD_SCANTIME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLASTGOOD_SCANDATE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHOSTMODE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPOCMODE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMOTORSTAT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCOMMENTS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEC_WELL_STATUS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRTU_WELL_STATUS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRTUTYPE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSERVICESTAT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCOMMTODAYPRCT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCOMMYESTPRCT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCOMMPORT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colYESTRUN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colYESTCYCLES = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colYEST_INFERRED = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colYEST_PUMP_FILL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCC_FILLAGE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAVG_FILLAGE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPUMP_FILL_DEV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFOP_STAT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTEST_DATE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBOPD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBWPD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBFPD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLAST_INFERRED24H_DATE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLAST_INFERRED24H = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colINFERRED_ACCURACY_WT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPUMP_SIZE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPUMP_SPEED = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPUMP_STROKE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGROSS_DISPLACEMENT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTODAY_INFERRED = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPUMP_DEPTH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPUMP_OFF_BEFORE_IDLE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIDLE_TIME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPEAK_POLISH_ROD_LOAD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMIN_POLISH_ROD_LOAD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTUBING_PRESS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCASING_PRESS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTUBING_TEMP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCASING_TEMP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHEADER_PRESS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUPDATE_TIME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colREMARKS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVM_TEST_DATE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVM_BFPD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVM_BOPD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVM_KFACTOR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPO_CARD_DATE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPO_FILLAGE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFULL_CARD_DATE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFC_FILLAGE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCC_CARD_DATE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.prosedurgetdataWellGroupStatusBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.prosedurgetdatabeamWellGroupStatusBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            this.lw2DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lw2DataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdLowis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvLowis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prosedurgetdataWellGroupStatusBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prosedurgetdatabeamWellGroupStatusBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lw2DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lw2DataSetBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pgbar);
            this.panel2.Controls.Add(this.gdLowis);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 32);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1059, 446);
            this.panel2.TabIndex = 7;
            // 
            // pgbar
            // 
            this.pgbar.Location = new System.Drawing.Point(294, 118);
            this.pgbar.Name = "pgbar";
            this.pgbar.Size = new System.Drawing.Size(246, 18);
            this.pgbar.TabIndex = 1;
            this.pgbar.Visible = false;
            // 
            // gdLowis
            // 
            this.gdLowis.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gdLowis.Location = new System.Drawing.Point(0, 0);
            this.gdLowis.MainView = this.gvLowis;
            this.gdLowis.Name = "gdLowis";
            this.gdLowis.Size = new System.Drawing.Size(1059, 446);
            this.gdLowis.TabIndex = 0;
            this.gdLowis.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvLowis});
            this.gdLowis.Click += new System.EventHandler(this.gdLowis_Click_1);
            this.gdLowis.DoubleClick += new System.EventHandler(this.gdLowis_DoubleClick);
            this.gdLowis.MouseClick += new System.Windows.Forms.MouseEventHandler(this.gdLowis_MouseClick);
            this.gdLowis.MouseDown += new System.Windows.Forms.MouseEventHandler(this.gdLowis_MouseDown);
            // 
            // gvLowis
            // 
            this.gvLowis.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colWELLNAME,
            this.colARSE,
            this.colSCANTIME,
            this.colSCANDATE,
            this.colALARM,
            this.colLASTGOOD_SCANTIME,
            this.colLASTGOOD_SCANDATE,
            this.colHOSTMODE,
            this.colPOCMODE,
            this.colMOTORSTAT,
            this.colCOMMENTS,
            this.colEC_WELL_STATUS,
            this.colRTU_WELL_STATUS,
            this.colRTUTYPE,
            this.colSERVICESTAT,
            this.colCOMMTODAYPRCT,
            this.colCOMMYESTPRCT,
            this.colCOMMPORT,
            this.colYESTRUN,
            this.colYESTCYCLES,
            this.colYEST_INFERRED,
            this.colYEST_PUMP_FILL,
            this.colCC_FILLAGE,
            this.colAVG_FILLAGE,
            this.colPUMP_FILL_DEV,
            this.colFOP_STAT,
            this.colTEST_DATE,
            this.colBOPD,
            this.colBWPD,
            this.colBFPD,
            this.colLAST_INFERRED24H_DATE,
            this.colLAST_INFERRED24H,
            this.colINFERRED_ACCURACY_WT,
            this.colPUMP_SIZE,
            this.colPUMP_SPEED,
            this.colPUMP_STROKE,
            this.colGROSS_DISPLACEMENT,
            this.colTODAY_INFERRED,
            this.colPUMP_DEPTH,
            this.colPUMP_OFF_BEFORE_IDLE,
            this.colIDLE_TIME,
            this.colPEAK_POLISH_ROD_LOAD,
            this.colMIN_POLISH_ROD_LOAD,
            this.colTUBING_PRESS,
            this.colCASING_PRESS,
            this.colTUBING_TEMP,
            this.colCASING_TEMP,
            this.colHEADER_PRESS,
            this.colUPDATE_TIME,
            this.colREMARKS,
            this.colVM_TEST_DATE,
            this.colVM_BFPD,
            this.colVM_BOPD,
            this.colVM_KFACTOR,
            this.colPO_CARD_DATE,
            this.colPO_FILLAGE,
            this.colFULL_CARD_DATE,
            this.colFC_FILLAGE,
            this.colCC_CARD_DATE});
            this.gvLowis.GridControl = this.gdLowis;
            this.gvLowis.Name = "gvLowis";
            this.gvLowis.OptionsBehavior.AutoSelectAllInEditor = false;
            this.gvLowis.OptionsBehavior.Editable = false;
            this.gvLowis.OptionsView.ColumnAutoWidth = false;
            this.gvLowis.OptionsView.ShowGroupPanel = false;
            this.gvLowis.RowStyle += new DevExpress.XtraGrid.Views.Grid.RowStyleEventHandler(this.gvLowis_RowStyle);
            // 
            // colID
            // 
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            // 
            // colWELLNAME
            // 
            this.colWELLNAME.FieldName = "WELLNAME";
            this.colWELLNAME.Name = "colWELLNAME";
            this.colWELLNAME.Visible = true;
            this.colWELLNAME.VisibleIndex = 0;
            // 
            // colARSE
            // 
            this.colARSE.FieldName = "ARSE";
            this.colARSE.Name = "colARSE";
            this.colARSE.Visible = true;
            this.colARSE.VisibleIndex = 1;
            // 
            // colSCANTIME
            // 
            this.colSCANTIME.FieldName = "SCANTIME";
            this.colSCANTIME.Name = "colSCANTIME";
            this.colSCANTIME.Visible = true;
            this.colSCANTIME.VisibleIndex = 2;
            // 
            // colSCANDATE
            // 
            this.colSCANDATE.FieldName = "SCANDATE";
            this.colSCANDATE.Name = "colSCANDATE";
            this.colSCANDATE.Visible = true;
            this.colSCANDATE.VisibleIndex = 3;
            // 
            // colALARM
            // 
            this.colALARM.FieldName = "ALARM";
            this.colALARM.Name = "colALARM";
            this.colALARM.Visible = true;
            this.colALARM.VisibleIndex = 4;
            // 
            // colLASTGOOD_SCANTIME
            // 
            this.colLASTGOOD_SCANTIME.FieldName = "LASTGOOD_SCANTIME";
            this.colLASTGOOD_SCANTIME.Name = "colLASTGOOD_SCANTIME";
            this.colLASTGOOD_SCANTIME.Visible = true;
            this.colLASTGOOD_SCANTIME.VisibleIndex = 5;
            // 
            // colLASTGOOD_SCANDATE
            // 
            this.colLASTGOOD_SCANDATE.FieldName = "LASTGOOD_SCANDATE";
            this.colLASTGOOD_SCANDATE.Name = "colLASTGOOD_SCANDATE";
            this.colLASTGOOD_SCANDATE.Visible = true;
            this.colLASTGOOD_SCANDATE.VisibleIndex = 6;
            // 
            // colHOSTMODE
            // 
            this.colHOSTMODE.FieldName = "HOSTMODE";
            this.colHOSTMODE.Name = "colHOSTMODE";
            this.colHOSTMODE.Visible = true;
            this.colHOSTMODE.VisibleIndex = 7;
            // 
            // colPOCMODE
            // 
            this.colPOCMODE.FieldName = "POCMODE";
            this.colPOCMODE.Name = "colPOCMODE";
            this.colPOCMODE.Visible = true;
            this.colPOCMODE.VisibleIndex = 8;
            // 
            // colMOTORSTAT
            // 
            this.colMOTORSTAT.FieldName = "MOTORSTAT";
            this.colMOTORSTAT.Name = "colMOTORSTAT";
            this.colMOTORSTAT.Visible = true;
            this.colMOTORSTAT.VisibleIndex = 9;
            // 
            // colCOMMENTS
            // 
            this.colCOMMENTS.FieldName = "COMMENTS";
            this.colCOMMENTS.Name = "colCOMMENTS";
            this.colCOMMENTS.Visible = true;
            this.colCOMMENTS.VisibleIndex = 10;
            // 
            // colEC_WELL_STATUS
            // 
            this.colEC_WELL_STATUS.FieldName = "EC_WELL_STATUS";
            this.colEC_WELL_STATUS.Name = "colEC_WELL_STATUS";
            this.colEC_WELL_STATUS.Visible = true;
            this.colEC_WELL_STATUS.VisibleIndex = 11;
            // 
            // colRTU_WELL_STATUS
            // 
            this.colRTU_WELL_STATUS.FieldName = "RTU_WELL_STATUS";
            this.colRTU_WELL_STATUS.Name = "colRTU_WELL_STATUS";
            this.colRTU_WELL_STATUS.Visible = true;
            this.colRTU_WELL_STATUS.VisibleIndex = 12;
            // 
            // colRTUTYPE
            // 
            this.colRTUTYPE.FieldName = "RTUTYPE";
            this.colRTUTYPE.Name = "colRTUTYPE";
            this.colRTUTYPE.Visible = true;
            this.colRTUTYPE.VisibleIndex = 13;
            // 
            // colSERVICESTAT
            // 
            this.colSERVICESTAT.FieldName = "SERVICESTAT";
            this.colSERVICESTAT.Name = "colSERVICESTAT";
            this.colSERVICESTAT.Visible = true;
            this.colSERVICESTAT.VisibleIndex = 14;
            // 
            // colCOMMTODAYPRCT
            // 
            this.colCOMMTODAYPRCT.FieldName = "COMMTODAYPRCT";
            this.colCOMMTODAYPRCT.Name = "colCOMMTODAYPRCT";
            this.colCOMMTODAYPRCT.Visible = true;
            this.colCOMMTODAYPRCT.VisibleIndex = 15;
            // 
            // colCOMMYESTPRCT
            // 
            this.colCOMMYESTPRCT.FieldName = "COMMYESTPRCT";
            this.colCOMMYESTPRCT.Name = "colCOMMYESTPRCT";
            this.colCOMMYESTPRCT.Visible = true;
            this.colCOMMYESTPRCT.VisibleIndex = 16;
            // 
            // colCOMMPORT
            // 
            this.colCOMMPORT.FieldName = "COMMPORT";
            this.colCOMMPORT.Name = "colCOMMPORT";
            this.colCOMMPORT.Visible = true;
            this.colCOMMPORT.VisibleIndex = 17;
            // 
            // colYESTRUN
            // 
            this.colYESTRUN.FieldName = "YESTRUN";
            this.colYESTRUN.Name = "colYESTRUN";
            this.colYESTRUN.Visible = true;
            this.colYESTRUN.VisibleIndex = 18;
            // 
            // colYESTCYCLES
            // 
            this.colYESTCYCLES.FieldName = "YESTCYCLES";
            this.colYESTCYCLES.Name = "colYESTCYCLES";
            this.colYESTCYCLES.Visible = true;
            this.colYESTCYCLES.VisibleIndex = 19;
            // 
            // colYEST_INFERRED
            // 
            this.colYEST_INFERRED.FieldName = "YEST_INFERRED";
            this.colYEST_INFERRED.Name = "colYEST_INFERRED";
            this.colYEST_INFERRED.Visible = true;
            this.colYEST_INFERRED.VisibleIndex = 20;
            // 
            // colYEST_PUMP_FILL
            // 
            this.colYEST_PUMP_FILL.FieldName = "YEST_PUMP_FILL";
            this.colYEST_PUMP_FILL.Name = "colYEST_PUMP_FILL";
            this.colYEST_PUMP_FILL.Visible = true;
            this.colYEST_PUMP_FILL.VisibleIndex = 21;
            // 
            // colCC_FILLAGE
            // 
            this.colCC_FILLAGE.FieldName = "CC_FILLAGE";
            this.colCC_FILLAGE.Name = "colCC_FILLAGE";
            this.colCC_FILLAGE.Visible = true;
            this.colCC_FILLAGE.VisibleIndex = 22;
            // 
            // colAVG_FILLAGE
            // 
            this.colAVG_FILLAGE.FieldName = "AVG_FILLAGE";
            this.colAVG_FILLAGE.Name = "colAVG_FILLAGE";
            this.colAVG_FILLAGE.Visible = true;
            this.colAVG_FILLAGE.VisibleIndex = 23;
            // 
            // colPUMP_FILL_DEV
            // 
            this.colPUMP_FILL_DEV.FieldName = "PUMP_FILL_DEV";
            this.colPUMP_FILL_DEV.Name = "colPUMP_FILL_DEV";
            this.colPUMP_FILL_DEV.Visible = true;
            this.colPUMP_FILL_DEV.VisibleIndex = 24;
            // 
            // colFOP_STAT
            // 
            this.colFOP_STAT.FieldName = "FOP_STAT";
            this.colFOP_STAT.Name = "colFOP_STAT";
            this.colFOP_STAT.Visible = true;
            this.colFOP_STAT.VisibleIndex = 25;
            // 
            // colTEST_DATE
            // 
            this.colTEST_DATE.FieldName = "TEST_DATE";
            this.colTEST_DATE.Name = "colTEST_DATE";
            this.colTEST_DATE.Visible = true;
            this.colTEST_DATE.VisibleIndex = 26;
            // 
            // colBOPD
            // 
            this.colBOPD.FieldName = "BOPD";
            this.colBOPD.Name = "colBOPD";
            this.colBOPD.Visible = true;
            this.colBOPD.VisibleIndex = 27;
            // 
            // colBWPD
            // 
            this.colBWPD.FieldName = "BWPD";
            this.colBWPD.Name = "colBWPD";
            this.colBWPD.Visible = true;
            this.colBWPD.VisibleIndex = 28;
            // 
            // colBFPD
            // 
            this.colBFPD.FieldName = "BFPD";
            this.colBFPD.Name = "colBFPD";
            this.colBFPD.Visible = true;
            this.colBFPD.VisibleIndex = 29;
            // 
            // colLAST_INFERRED24H_DATE
            // 
            this.colLAST_INFERRED24H_DATE.FieldName = "LAST_INFERRED24H_DATE";
            this.colLAST_INFERRED24H_DATE.Name = "colLAST_INFERRED24H_DATE";
            this.colLAST_INFERRED24H_DATE.Visible = true;
            this.colLAST_INFERRED24H_DATE.VisibleIndex = 30;
            // 
            // colLAST_INFERRED24H
            // 
            this.colLAST_INFERRED24H.FieldName = "LAST_INFERRED24H";
            this.colLAST_INFERRED24H.Name = "colLAST_INFERRED24H";
            this.colLAST_INFERRED24H.Visible = true;
            this.colLAST_INFERRED24H.VisibleIndex = 31;
            // 
            // colINFERRED_ACCURACY_WT
            // 
            this.colINFERRED_ACCURACY_WT.FieldName = "INFERRED_ACCURACY_WT";
            this.colINFERRED_ACCURACY_WT.Name = "colINFERRED_ACCURACY_WT";
            this.colINFERRED_ACCURACY_WT.Visible = true;
            this.colINFERRED_ACCURACY_WT.VisibleIndex = 32;
            // 
            // colPUMP_SIZE
            // 
            this.colPUMP_SIZE.FieldName = "PUMP_SIZE";
            this.colPUMP_SIZE.Name = "colPUMP_SIZE";
            this.colPUMP_SIZE.Visible = true;
            this.colPUMP_SIZE.VisibleIndex = 33;
            // 
            // colPUMP_SPEED
            // 
            this.colPUMP_SPEED.FieldName = "PUMP_SPEED";
            this.colPUMP_SPEED.Name = "colPUMP_SPEED";
            this.colPUMP_SPEED.Visible = true;
            this.colPUMP_SPEED.VisibleIndex = 34;
            // 
            // colPUMP_STROKE
            // 
            this.colPUMP_STROKE.FieldName = "PUMP_STROKE";
            this.colPUMP_STROKE.Name = "colPUMP_STROKE";
            this.colPUMP_STROKE.Visible = true;
            this.colPUMP_STROKE.VisibleIndex = 35;
            // 
            // colGROSS_DISPLACEMENT
            // 
            this.colGROSS_DISPLACEMENT.FieldName = "GROSS_DISPLACEMENT";
            this.colGROSS_DISPLACEMENT.Name = "colGROSS_DISPLACEMENT";
            this.colGROSS_DISPLACEMENT.Visible = true;
            this.colGROSS_DISPLACEMENT.VisibleIndex = 36;
            // 
            // colTODAY_INFERRED
            // 
            this.colTODAY_INFERRED.FieldName = "TODAY_INFERRED";
            this.colTODAY_INFERRED.Name = "colTODAY_INFERRED";
            this.colTODAY_INFERRED.Visible = true;
            this.colTODAY_INFERRED.VisibleIndex = 37;
            // 
            // colPUMP_DEPTH
            // 
            this.colPUMP_DEPTH.FieldName = "PUMP_DEPTH";
            this.colPUMP_DEPTH.Name = "colPUMP_DEPTH";
            this.colPUMP_DEPTH.Visible = true;
            this.colPUMP_DEPTH.VisibleIndex = 38;
            // 
            // colPUMP_OFF_BEFORE_IDLE
            // 
            this.colPUMP_OFF_BEFORE_IDLE.FieldName = "PUMP_OFF_BEFORE_IDLE";
            this.colPUMP_OFF_BEFORE_IDLE.Name = "colPUMP_OFF_BEFORE_IDLE";
            this.colPUMP_OFF_BEFORE_IDLE.Visible = true;
            this.colPUMP_OFF_BEFORE_IDLE.VisibleIndex = 39;
            // 
            // colIDLE_TIME
            // 
            this.colIDLE_TIME.FieldName = "IDLE_TIME";
            this.colIDLE_TIME.Name = "colIDLE_TIME";
            this.colIDLE_TIME.Visible = true;
            this.colIDLE_TIME.VisibleIndex = 40;
            // 
            // colPEAK_POLISH_ROD_LOAD
            // 
            this.colPEAK_POLISH_ROD_LOAD.FieldName = "PEAK_POLISH_ROD_LOAD";
            this.colPEAK_POLISH_ROD_LOAD.Name = "colPEAK_POLISH_ROD_LOAD";
            this.colPEAK_POLISH_ROD_LOAD.Visible = true;
            this.colPEAK_POLISH_ROD_LOAD.VisibleIndex = 41;
            // 
            // colMIN_POLISH_ROD_LOAD
            // 
            this.colMIN_POLISH_ROD_LOAD.FieldName = "MIN_POLISH_ROD_LOAD";
            this.colMIN_POLISH_ROD_LOAD.Name = "colMIN_POLISH_ROD_LOAD";
            this.colMIN_POLISH_ROD_LOAD.Visible = true;
            this.colMIN_POLISH_ROD_LOAD.VisibleIndex = 42;
            // 
            // colTUBING_PRESS
            // 
            this.colTUBING_PRESS.FieldName = "TUBING_PRESS";
            this.colTUBING_PRESS.Name = "colTUBING_PRESS";
            this.colTUBING_PRESS.Visible = true;
            this.colTUBING_PRESS.VisibleIndex = 43;
            // 
            // colCASING_PRESS
            // 
            this.colCASING_PRESS.FieldName = "CASING_PRESS";
            this.colCASING_PRESS.Name = "colCASING_PRESS";
            this.colCASING_PRESS.Visible = true;
            this.colCASING_PRESS.VisibleIndex = 44;
            // 
            // colTUBING_TEMP
            // 
            this.colTUBING_TEMP.FieldName = "TUBING_TEMP";
            this.colTUBING_TEMP.Name = "colTUBING_TEMP";
            this.colTUBING_TEMP.Visible = true;
            this.colTUBING_TEMP.VisibleIndex = 45;
            // 
            // colCASING_TEMP
            // 
            this.colCASING_TEMP.FieldName = "CASING_TEMP";
            this.colCASING_TEMP.Name = "colCASING_TEMP";
            this.colCASING_TEMP.Visible = true;
            this.colCASING_TEMP.VisibleIndex = 46;
            // 
            // colHEADER_PRESS
            // 
            this.colHEADER_PRESS.FieldName = "HEADER_PRESS";
            this.colHEADER_PRESS.Name = "colHEADER_PRESS";
            this.colHEADER_PRESS.Visible = true;
            this.colHEADER_PRESS.VisibleIndex = 47;
            // 
            // colUPDATE_TIME
            // 
            this.colUPDATE_TIME.FieldName = "UPDATE_TIME";
            this.colUPDATE_TIME.Name = "colUPDATE_TIME";
            this.colUPDATE_TIME.Visible = true;
            this.colUPDATE_TIME.VisibleIndex = 48;
            // 
            // colREMARKS
            // 
            this.colREMARKS.FieldName = "REMARKS";
            this.colREMARKS.Name = "colREMARKS";
            this.colREMARKS.Visible = true;
            this.colREMARKS.VisibleIndex = 49;
            // 
            // colVM_TEST_DATE
            // 
            this.colVM_TEST_DATE.FieldName = "VM_TEST_DATE";
            this.colVM_TEST_DATE.Name = "colVM_TEST_DATE";
            this.colVM_TEST_DATE.Visible = true;
            this.colVM_TEST_DATE.VisibleIndex = 50;
            // 
            // colVM_BFPD
            // 
            this.colVM_BFPD.FieldName = "VM_BFPD";
            this.colVM_BFPD.Name = "colVM_BFPD";
            this.colVM_BFPD.Visible = true;
            this.colVM_BFPD.VisibleIndex = 51;
            // 
            // colVM_BOPD
            // 
            this.colVM_BOPD.FieldName = "VM_BOPD";
            this.colVM_BOPD.Name = "colVM_BOPD";
            this.colVM_BOPD.Visible = true;
            this.colVM_BOPD.VisibleIndex = 52;
            // 
            // colVM_KFACTOR
            // 
            this.colVM_KFACTOR.FieldName = "VM_KFACTOR";
            this.colVM_KFACTOR.Name = "colVM_KFACTOR";
            this.colVM_KFACTOR.Visible = true;
            this.colVM_KFACTOR.VisibleIndex = 53;
            // 
            // colPO_CARD_DATE
            // 
            this.colPO_CARD_DATE.FieldName = "PO_CARD_DATE";
            this.colPO_CARD_DATE.Name = "colPO_CARD_DATE";
            this.colPO_CARD_DATE.Visible = true;
            this.colPO_CARD_DATE.VisibleIndex = 54;
            // 
            // colPO_FILLAGE
            // 
            this.colPO_FILLAGE.FieldName = "PO_FILLAGE";
            this.colPO_FILLAGE.Name = "colPO_FILLAGE";
            this.colPO_FILLAGE.Visible = true;
            this.colPO_FILLAGE.VisibleIndex = 55;
            // 
            // colFULL_CARD_DATE
            // 
            this.colFULL_CARD_DATE.FieldName = "FULL_CARD_DATE";
            this.colFULL_CARD_DATE.Name = "colFULL_CARD_DATE";
            this.colFULL_CARD_DATE.Visible = true;
            this.colFULL_CARD_DATE.VisibleIndex = 56;
            // 
            // colFC_FILLAGE
            // 
            this.colFC_FILLAGE.FieldName = "FC_FILLAGE";
            this.colFC_FILLAGE.Name = "colFC_FILLAGE";
            this.colFC_FILLAGE.Visible = true;
            this.colFC_FILLAGE.VisibleIndex = 57;
            // 
            // colCC_CARD_DATE
            // 
            this.colCC_CARD_DATE.FieldName = "CC_CARD_DATE";
            this.colCC_CARD_DATE.Name = "colCC_CARD_DATE";
            this.colCC_CARD_DATE.Visible = true;
            this.colCC_CARD_DATE.VisibleIndex = 58;
            // 
            // prosedurgetdataWellGroupStatusBindingSource1
            // 
            this.prosedurgetdataWellGroupStatusBindingSource1.DataMember = "prosedur_getdataWellGroupStatus";
            // 
            // prosedurgetdatabeamWellGroupStatusBindingSource
            // 
            this.prosedurgetdatabeamWellGroupStatusBindingSource.DataMember = "prosedur_getdatabeamWellGroupStatus";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.toolStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1059, 32);
            this.panel1.TabIndex = 6;
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
            this.toolStrip1.Size = new System.Drawing.Size(1059, 25);
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
            this.btnScan.Click += new System.EventHandler(this.btnScan_Click);
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
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // LowisForm
            // 
            this.Appearance.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "LowisForm";
            this.Size = new System.Drawing.Size(1059, 478);
            this.Load += new System.EventHandler(this.LowisForm_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gdLowis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvLowis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prosedurgetdataWellGroupStatusBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prosedurgetdatabeamWellGroupStatusBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lw2DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lw2DataSetBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        //private lw2DataSet lw2DataSet;
        //private lw2DataSetTableAdapters.prosedur_getdatabeamWellGroupStatusTableAdapter prosedur_getdatabeamWellGroupStatusTableAdapter;
        private System.Windows.Forms.BindingSource prosedurgetdatabeamWellGroupStatusBindingSource;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.BindingSource prosedurgetdataWellGroupStatusBindingSource1;
        private System.Windows.Forms.BindingSource lw2DataSetBindingSource1;
        private System.Windows.Forms.BindingSource lw2DataSetBindingSource;
        private DevExpress.XtraGrid.GridControl gdLowis;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
        private DevExpress.XtraGrid.Views.Grid.GridView gvLowis;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colWELLNAME;
        private DevExpress.XtraGrid.Columns.GridColumn colARSE;
        private DevExpress.XtraGrid.Columns.GridColumn colSCANTIME;
        private DevExpress.XtraGrid.Columns.GridColumn colSCANDATE;
        private DevExpress.XtraGrid.Columns.GridColumn colALARM;
        private DevExpress.XtraGrid.Columns.GridColumn colLASTGOOD_SCANTIME;
        private DevExpress.XtraGrid.Columns.GridColumn colLASTGOOD_SCANDATE;
        private DevExpress.XtraGrid.Columns.GridColumn colHOSTMODE;
        private DevExpress.XtraGrid.Columns.GridColumn colPOCMODE;
        private DevExpress.XtraGrid.Columns.GridColumn colMOTORSTAT;
        private DevExpress.XtraGrid.Columns.GridColumn colCOMMENTS;
        private DevExpress.XtraGrid.Columns.GridColumn colEC_WELL_STATUS;
        private DevExpress.XtraGrid.Columns.GridColumn colRTU_WELL_STATUS;
        private DevExpress.XtraGrid.Columns.GridColumn colRTUTYPE;
        private DevExpress.XtraGrid.Columns.GridColumn colSERVICESTAT;
        private DevExpress.XtraGrid.Columns.GridColumn colCOMMTODAYPRCT;
        private DevExpress.XtraGrid.Columns.GridColumn colCOMMYESTPRCT;
        private DevExpress.XtraGrid.Columns.GridColumn colCOMMPORT;
        private DevExpress.XtraGrid.Columns.GridColumn colYESTRUN;
        private DevExpress.XtraGrid.Columns.GridColumn colYESTCYCLES;
        private DevExpress.XtraGrid.Columns.GridColumn colYEST_INFERRED;
        private DevExpress.XtraGrid.Columns.GridColumn colYEST_PUMP_FILL;
        private DevExpress.XtraGrid.Columns.GridColumn colCC_FILLAGE;
        private DevExpress.XtraGrid.Columns.GridColumn colAVG_FILLAGE;
        private DevExpress.XtraGrid.Columns.GridColumn colPUMP_FILL_DEV;
        private DevExpress.XtraGrid.Columns.GridColumn colFOP_STAT;
        private DevExpress.XtraGrid.Columns.GridColumn colTEST_DATE;
        private DevExpress.XtraGrid.Columns.GridColumn colBOPD;
        private DevExpress.XtraGrid.Columns.GridColumn colBWPD;
        private DevExpress.XtraGrid.Columns.GridColumn colBFPD;
        private DevExpress.XtraGrid.Columns.GridColumn colLAST_INFERRED24H_DATE;
        private DevExpress.XtraGrid.Columns.GridColumn colLAST_INFERRED24H;
        private DevExpress.XtraGrid.Columns.GridColumn colINFERRED_ACCURACY_WT;
        private DevExpress.XtraGrid.Columns.GridColumn colPUMP_SIZE;
        private DevExpress.XtraGrid.Columns.GridColumn colPUMP_SPEED;
        private DevExpress.XtraGrid.Columns.GridColumn colPUMP_STROKE;
        private DevExpress.XtraGrid.Columns.GridColumn colGROSS_DISPLACEMENT;
        private DevExpress.XtraGrid.Columns.GridColumn colTODAY_INFERRED;
        private DevExpress.XtraGrid.Columns.GridColumn colPUMP_DEPTH;
        private DevExpress.XtraGrid.Columns.GridColumn colPUMP_OFF_BEFORE_IDLE;
        private DevExpress.XtraGrid.Columns.GridColumn colIDLE_TIME;
        private DevExpress.XtraGrid.Columns.GridColumn colPEAK_POLISH_ROD_LOAD;
        private DevExpress.XtraGrid.Columns.GridColumn colMIN_POLISH_ROD_LOAD;
        private DevExpress.XtraGrid.Columns.GridColumn colTUBING_PRESS;
        private DevExpress.XtraGrid.Columns.GridColumn colCASING_PRESS;
        private DevExpress.XtraGrid.Columns.GridColumn colTUBING_TEMP;
        private DevExpress.XtraGrid.Columns.GridColumn colCASING_TEMP;
        private DevExpress.XtraGrid.Columns.GridColumn colHEADER_PRESS;
        private DevExpress.XtraGrid.Columns.GridColumn colUPDATE_TIME;
        private DevExpress.XtraGrid.Columns.GridColumn colREMARKS;
        private DevExpress.XtraGrid.Columns.GridColumn colVM_TEST_DATE;
        private DevExpress.XtraGrid.Columns.GridColumn colVM_BFPD;
        private DevExpress.XtraGrid.Columns.GridColumn colVM_BOPD;
        private DevExpress.XtraGrid.Columns.GridColumn colVM_KFACTOR;
        private DevExpress.XtraGrid.Columns.GridColumn colPO_CARD_DATE;
        private DevExpress.XtraGrid.Columns.GridColumn colPO_FILLAGE;
        private DevExpress.XtraGrid.Columns.GridColumn colFULL_CARD_DATE;
        private DevExpress.XtraGrid.Columns.GridColumn colFC_FILLAGE;
        private DevExpress.XtraGrid.Columns.GridColumn colCC_CARD_DATE;
        private System.Windows.Forms.ProgressBar pgbar;
        private System.Windows.Forms.Timer timer1;
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
