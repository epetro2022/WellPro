using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using LowisChartApp.model;
using DevExpress.XtraCharts;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using OPCAutomation;
using System.Collections;

namespace LowisChartApp.lw
{
    public partial class detailLW : DevExpress.XtraEditors.XtraUserControl
    {
        private CheckBox[] cb;
        bool[] unboundColumnValues;
        DataTable someDT = new DataTable();
        DB dbCon;
        GridColumn col;
        RepositoryItemCheckEdit ritem;
        private MyCache _Cache = new MyCache("description");
        GridColumn _UnboundCheckCol;
        RepositoryItemCheckEdit _RepositoryItemCheckEdit;
        Dictionary<int, object> _UnboundCheckValues;

        public OPCServer MyOPCServer = new OPCServer();
        public OPCGroup My_OPCGroup = null;
        OPCItem MyOPCItem;
        int[] MyServerHandles = new int[2];
        object[] MyValues = new object[2];
        public Array MyErrors;
        object objk;


        public detailLW()
        {
            InitializeComponent();
            dbCon = new DB(Globals.getstringco());
        }
        private void CheckedChanged(object sender, System.EventArgs e)
        {
            int tmo = _UnboundCheckValues.Count();
        }
        public void setgrid()
        {
            _RepositoryItemCheckEdit = new RepositoryItemCheckEdit();
            
            _UnboundCheckCol = new GridColumn();
           
            _UnboundCheckCol.ColumnEdit = _RepositoryItemCheckEdit;

           // _RepositoryItemCheckEdit.EditValueChanging += _RepositoryItemCheckEdit_EditValueChanging;
          
            //_RepositoryItemCheckEdit.AllowGrayed = false;
            //_RepositoryItemCheckEdit.AllowFocused = true;
            //_UnboundCheckCol.FieldName = "Select";
            //_UnboundCheckCol.UnboundType = DevExpress.Data.UnboundColumnType.Boolean;
            //_UnboundCheckCol.VisibleIndex = 0;

            //gvDynoCards.Columns.Add(_UnboundCheckCol);
            _UnboundCheckValues = new Dictionary<int, object>();
            gvDynoCards.CustomUnboundColumnData += gvDynoCards_CustomUnboundColumnData;
            //gvDynoCards.Columns["Select"].VisibleIndex = 0;
            //gvDynoCards.Columns["Select"].Width = 80;
            gvDynoCards.Columns["description"].Caption = "Description";
            gvDynoCards.Columns["description"].VisibleIndex = 1;
            _RepositoryItemCheckEdit.CheckedChanged += new EventHandler(CheckedChanged);

        }

        private void setdatatable()
        {
            //someDT.Columns.Add("select", typeof(int));
            someDT.Columns.Add("description", typeof(string));

        }

        private void dynocardsgrid()
        {
            dbCon.clearCache();
            Dictionary<string, object> paras = new Dictionary<string, object>();
            paras.Add("@param", Globals.ForeignKey);
            DataSet ds = dbCon.execprosedure("dbo.[prosedur_getdataDynoCards]", paras);
            gdDynoCards.DataSource = ds.Tables[0];
            CreateUnboundColumn();
            gvDynoCards.SetRowCellValue(0, "Select", true);
            this.gdDynoCards.Refresh();
        }

        private DataTable CreateChartData(int rowCount)
        {
            // Create an empty table.
            DataTable table = new DataTable("Table1");

            // Add two columns to the table.
            table.Columns.Add("Argument", typeof(Int32));
            table.Columns.Add("Value", typeof(Int32));

            // Add data rows to the table.
            Random rnd = new Random();
            DataRow row = null;
            for (int i = 0; i < rowCount; i++)
            {
                row = table.NewRow();
                row["Argument"] = i;
                row["Value"] = rnd.Next(100);
                table.Rows.Add(row);
            }

            return table;
        }

        public void chartDynoload(List<string> filename)
        {
            dbCon.clearCache();
            //chartdynocard.DataSource();
            Dictionary<string, object> paras = null;
            DataSet ds=null;
            DataTable dtAll = new DataTable();

            for (var i = 0; i < filename.Count; i++)
            {
                paras=new Dictionary<string, object>();
                paras.Add("@Param1", 3);
                paras.Add("@Param2", Globals.ForeignKey);
                paras.Add("@Param3", filename[i]);
                ds = dbCon.execprosedure("dbo.[spGetDataWithParamB]", paras);
                dtAll.Merge(ds.Tables[0]);
            }
            
            chartDyno.Series.Clear();
            //chartDyno.ClearCache();        

            Series series = new Series("", ViewType.ScatterLine);
            //series.

            chartDyno.Series.Add(series);
            chartDyno.DataSource = dtAll;

            foreach (DataRow row in dtAll.Rows)
            {
              series.Points.Add(new SeriesPoint(row["datar"], row["tinggi"]));
            }
        }

        public void blanktext()
        {
            gdDynoCards.DataSource = someDT;
            gdDynoCards.ForceInitialize();

            lblPickupDate.Text = "";
            lblTime.Text = "";
            lblWellGridName.Text = "";
            lblWellDrillNumber.Text = "";
            lblArea.Text = "";
            lblAreaSection.Text = "";
            lblFieldName.Text = "";

            lblWellStatus.Text = "";
            lblAlarms.Text = "";
            lblRunTime.Text = "";
            lblComment.Text = "";

            lblSPM.Text = "";
            lblStrokeLengthIn.Text = "";
            lblMotorSize.Text = "";
            lblPUType.Text = "";
            lblRotation.Text = "";

            lblTubingPress.Text = "";
            lblCasingPress.Text = "";
            lblTubingTemp.Text = "";
            lblCasingTemp.Text = "";
            lblChokePress.Text = "";
            lblPPRL.Text = "";
            lblMPRL.Text = "";
            lblTVLoad.Text = "";
            lblSVLoadMBS.Text = "";

            lblGearBoxLoadActual.Text = "";
            lblGearBoxLoadBalances.Text = "";
            lblPeakTorqueActual.Text = "";
            lblPeakTorqueBalance.Text = "";
            lblCBEBalance.Text = "";
            lblRodStressLoading.Text = "";
            lblUnitStructural.Text = "";
            lblPowerConsumption.Text = "";

            //lblPumpDept.Text = "";
            //lblPumpSize.Text = "";
            //lblTubingSize.Text = "";
            //lblRodGrade1.Text = "";

            lblPumpFillage.Text = "";
            lblPumpSlippage.Text = "";
            lblPumpSlippageRate.Text = "";
            lblNetDisplacement.Text = "";
            lblGrossDisplacement.Text = "";
            lblPumpEff.Text = "";

            lblCardArea.Text = "";
            lblFluidLevelFAP.Text = "";
            lblFluidLevelFromSurface.Text = "";
            lblPRHP.Text = "";
            lblTubingSretch.Text = "";

            //lblPumpDeptft.Text = "";
            //lblPumpSizein.Text = "";
            //lblTubingSizein.Text = "";
            //lblRodGrade1.Text = "";

            lblPumpDeptft2.Text = "";
            lblPumpSizein2.Text = "";
            lblTubingSizein2.Text = "";
            lblRodGrade2.Text = "";
        }

        private void filltexxt()
        {
            dbCon.clearCache();
            Dictionary<string, object> paras = new Dictionary<string, object>();
            paras.Add("@param", Globals.ForeignKey);
            DataSet ds = dbCon.execprosedure("dbo.[prosedur_getdataDetailWell]", paras);

            if (ds.Tables[0].Rows.Count < 1)
                return;


            lblPickupDate.Text = ds.Tables[0].Rows[0]["SCANDATE"].ToString();
            //lblTime.Text = ds.Tables[0].Rows[0]["SCANTIME"].ToString();
            lblWellGridName.Text = ds.Tables[0].Rows[0][0].ToString();
            lblWellDrillNumber.Text = ds.Tables[0].Rows[0][0].ToString();
            lblArea.Text = ds.Tables[0].Rows[0][3].ToString();
            lblAreaSection.Text = ds.Tables[0].Rows[0][4].ToString();
            lblFieldName.Text = ds.Tables[0].Rows[0][5].ToString();

            lblAlarms.Text = ds.Tables[0].Rows[0][2].ToString();
            lblWellStatus.Text = ds.Tables[0].Rows[0][7].ToString();
            lblRunTime.Text = ds.Tables[0].Rows[0][8].ToString();
            lblComment.Text = ds.Tables[0].Rows[0][6].ToString();

            lblSPM.Text = ds.Tables[0].Rows[0][9].ToString();
            lblStrokeLengthIn.Text = ds.Tables[0].Rows[0][10].ToString();
            lblMotorSize.Text = ds.Tables[0].Rows[0][11].ToString();
            lblPUType.Text = ds.Tables[0].Rows[0][12].ToString();
            lblRotation.Text = ds.Tables[0].Rows[0][13].ToString();

            lblTubingPress.Text = ds.Tables[0].Rows[0][14].ToString();
            lblCasingPress.Text = ds.Tables[0].Rows[0][15].ToString();
            lblTubingTemp.Text = ds.Tables[0].Rows[0][16].ToString();
            lblCasingTemp.Text = ds.Tables[0].Rows[0][17].ToString();
            lblChokePress.Text = ds.Tables[0].Rows[0][18].ToString();
            lblPPRL.Text = ds.Tables[0].Rows[0][19].ToString();
            lblMPRL.Text = ds.Tables[0].Rows[0][20].ToString();
            lblTVLoad.Text = ds.Tables[0].Rows[0][21].ToString();
            lblSVLoadMBS.Text = ds.Tables[0].Rows[0][22].ToString();

            lblGearBoxLoadActual.Text = ds.Tables[0].Rows[0][23].ToString();
            lblGearBoxLoadBalances.Text = ds.Tables[0].Rows[0][24].ToString();
            lblPeakTorqueActual.Text = ds.Tables[0].Rows[0][25].ToString();
            lblPeakTorqueBalance.Text = ds.Tables[0].Rows[0][26].ToString();
            lblCBEBalance.Text = ds.Tables[0].Rows[0][27].ToString();
            lblRodStressLoading.Text = ds.Tables[0].Rows[0][28].ToString();
            lblUnitStructural.Text = ds.Tables[0].Rows[0][29].ToString();
            lblPowerConsumption.Text = ds.Tables[0].Rows[0][30].ToString();

            lblPumpDeptft2.Text = ds.Tables[0].Rows[0][31].ToString();
            lblPumpSizein2.Text = ds.Tables[0].Rows[0][32].ToString();
            lblTubingSizein2.Text = ds.Tables[0].Rows[0][33].ToString();
            lblRodGrade2.Text = ds.Tables[0].Rows[0][34].ToString();

            lblPumpFillage.Text = ds.Tables[0].Rows[0][35].ToString();
            lblPumpSlippage.Text = ds.Tables[0].Rows[0][36].ToString();
            lblPumpSlippageRate.Text = ds.Tables[0].Rows[0][37].ToString();
            lblNetDisplacement.Text = ds.Tables[0].Rows[0][38].ToString();
            lblGrossDisplacement.Text = ds.Tables[0].Rows[0][39].ToString();
            lblPumpEff.Text = ds.Tables[0].Rows[0][40].ToString();

            lblCardArea.Text = ds.Tables[0].Rows[0][41].ToString();
            lblFluidLevelFromSurface.Text = ds.Tables[0].Rows[0][42].ToString();
            lblFluidLevelFAP.Text = ds.Tables[0].Rows[0][43].ToString();
            lblPRHP.Text = ds.Tables[0].Rows[0][44].ToString();
            lblTubingSretch.Text = ds.Tables[0].Rows[0][45].ToString();

            //gddynocard.DataSource = ds.Tables[0];
            //this.gddynocard.Refresh();
        }

        private void fillgdWellWorkHistory()
        {
            dbCon.clearCache();
            Dictionary<string, object> paras = new Dictionary<string, object>();
            paras.Add("@param", Globals.ForeignKey);
            DataSet ds = dbCon.execprosedure("dbo.[prosedur_getdataDetailWellWorkHistory]", paras);

            gdWellWorkHistory.DataSource = ds.Tables[0];
            this.gdWellWorkHistory.Refresh();
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void xtraTabPage2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void xtraTabPage4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gdwwHistory2_Click(object sender, EventArgs e)
        {

        }

        private void xtraTabPage1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void detailLW_Load(object sender, EventArgs e)
        {
            setdatatable();
            blanktext();
            

            dynocardsgrid();
            setgrid();

            chartPresureandTemperatureload();
            chartWellWorkload();
            chartProductionTrendingload();
            chartPerformanceLoad();

            filltexxt();
            fillgdWellWorkHistory();

            List<string> list = new List<string>();
            list.Add(gvDynoCards.GetRowCellValue(0, gvDynoCards.Columns[0]).ToString());
            chartDynoload(list);
        }

        public void chartPerformanceLoad()
        {
            //chartdynocard.DataSource();
            dbCon.clearCache();
            Dictionary<string, object> paras = new Dictionary<string, object>();
            //paras.Add("@Param1", 2);
            paras.Add("@Param", Globals.ForeignKey);
            //paras.Add("@Param3", "");
            DataSet ds = dbCon.execprosedure("dbo.[prosedur_chartPerformanceLoad]", paras);

            Series series = new Series("YESTRUN", ViewType.StackedLine);
            chartSystemPeformpance.Series.Add(series);
            series.DataSource = ds.Tables[0];
            // Specify data members to bind the series.
            series.ArgumentScaleType = ScaleType.DateTime;
            series.ArgumentDataMember = "SCANDATE";
            series.ValueScaleType = ScaleType.Numerical;
            series.ValueDataMembers.AddRange(new string[] { "YESTRUN" });

            Series series2 = new Series("YESTCYCLES", ViewType.StackedLine);
            chartSystemPeformpance.Series.Add(series2);
            series2.DataSource = ds.Tables[0];
            // Specify data members to bind the series.
            series2.ArgumentScaleType = ScaleType.DateTime;
            series2.ArgumentDataMember = "SCANDATE";
            series2.ValueScaleType = ScaleType.Numerical;
            series2.ValueDataMembers.AddRange(new string[] { "YESTCYCLES" });

            Series series3 = new Series("PUMP_SPEED", ViewType.StackedLine);
            chartSystemPeformpance.Series.Add(series3);
            series3.DataSource = ds.Tables[0];
            // Specify data members to bind the series.
            series3.ArgumentScaleType = ScaleType.DateTime;
            series3.ArgumentDataMember = "SCANDATE";
            series3.ValueScaleType = ScaleType.Numerical;
            series3.ValueDataMembers.AddRange(new string[] { "PUMP_SPEED" });

        }

        public void chartProductionTrendingload()
        {
            dbCon.clearCache();
            Dictionary<string, object> paras = new Dictionary<string, object>();
            //paras.Add("@Param1", 2);
            paras.Add("@Param", Globals.ForeignKey);
            //paras.Add("@Param3", "");
            DataSet ds = dbCon.execprosedure("dbo.[prosedur_chartProductTrending]", paras);

            Series series = new Series("YES INFERRED", ViewType.StackedLine);
            chartProductTrending.Series.Add(series);
            series.DataSource = ds.Tables[0];
            // Specify data members to bind the series.
            series.ArgumentScaleType = ScaleType.DateTime;
            series.ArgumentDataMember = "SCANDATE";
            series.ValueScaleType = ScaleType.Numerical;
            series.ValueDataMembers.AddRange(new string[] { "YEST_INFERRED" });

            Series series2 = new Series("BOPD", ViewType.StackedLine);
            chartProductTrending.Series.Add(series2);
            series2.DataSource = ds.Tables[0];
            // Specify data members to bind the series.
            series2.ArgumentScaleType = ScaleType.DateTime;
            series2.ArgumentDataMember = "SCANDATE";
            series2.ValueScaleType = ScaleType.Numerical;
            series2.ValueDataMembers.AddRange(new string[] { "BOPD" });

            Series series3 = new Series("BWPD", ViewType.StackedLine);
            chartProductTrending.Series.Add(series3);
            series3.DataSource = ds.Tables[0];
            // Specify data members to bind the series.
            series3.ArgumentScaleType = ScaleType.DateTime;
            series3.ArgumentDataMember = "SCANDATE";
            series3.ValueScaleType = ScaleType.Numerical;
            series3.ValueDataMembers.AddRange(new string[] { "BWPD" });

            Series series4 = new Series("BFPD", ViewType.StackedLine);
            chartProductTrending.Series.Add(series4);
            series4.DataSource = ds.Tables[0];
            // Specify data members to bind the series.
            series4.ArgumentScaleType = ScaleType.DateTime;
            series4.ArgumentDataMember = "SCANDATE";
            series4.ValueScaleType = ScaleType.Numerical;
            series4.ValueDataMembers.AddRange(new string[] { "BFPD" });
        }

        public void chartWellWorkload()
        {
            //chartdynocard.DataSource();
            dbCon.clearCache();
            Series series = new Series("Well Works", ViewType.CandleStick);
            chartWellWork.Series.Add(series);


            Dictionary<string, object> paras = new Dictionary<string, object>();
            //paras.Add("@Param1", 2);
            paras.Add("@Param", Globals.ForeignKey);
            //paras.Add("@Param3", "");
            DataSet ds = dbCon.execprosedure("dbo.[prosedur_chartWellWork]", paras);

            series.DataSource = ds.Tables[0];
            // Specify data members to bind the series.
            series.ArgumentScaleType = ScaleType.DateTime;
            series.ArgumentDataMember = "SCANDATE";
            series.ValueScaleType = ScaleType.Numerical;
            series.ValueDataMembers.AddRange(new string[] { "YEST_INFERRED", "BOPD", "BWPD", "BFPD" });

        }

        public void chartPresureandTemperatureload()
        {
            //chartdynocard.DataSource();

            Series series = new Series("Tubing Press", ViewType.StackedLine);
            chartTemperaturePresure.Series.Add(series);
            dbCon.clearCache();
            Dictionary<string, object> paras = new Dictionary<string, object>();
            //paras.Add("@Param1", 2);
            paras.Add("@param", Globals.ForeignKey);
            //paras.Add("@Param3", "");
            DataSet ds = dbCon.execprosedure("dbo.[prosedur_chartPresureandTemperatureload]", paras);

            series.DataSource = ds.Tables[0];
            series.ArgumentScaleType = ScaleType.DateTime;
            series.ArgumentDataMember = "SCANDATE";
            series.ValueScaleType = ScaleType.Numerical;
            series.ValueDataMembers.AddRange(new string[] { "TUBING_PRESS" });

            Series series2 = new Series("Casing Press", ViewType.StackedLine);
            chartTemperaturePresure.Series.Add(series2);
            //paras = new Dictionary<string, object>();
            //paras.Add("@param", Globals.ForeignKey);
            //ds = dbCon.execprosedure("[prosedur_getdataChartPressureandTemperatureCasingPress]", paras);

            series2.DataSource = ds.Tables[0];
            series2.ArgumentScaleType = ScaleType.DateTime;
            series2.ArgumentDataMember = "SCANDATE";
            series2.ValueScaleType = ScaleType.Numerical;
            series2.ValueDataMembers.AddRange(new string[] { "CASING_PRESS" });

            Series series3 = new Series("Tubing Temp", ViewType.StackedLine);
            chartTemperaturePresure.Series.Add(series3);
            //paras = new Dictionary<string, object>();
            //paras.Add("@param", Globals.ForeignKey);
            //ds = dbCon.execprosedure("[prosedur_getdataChartPressureandTemperatureTubingTemp]", paras);

            series3.DataSource = ds.Tables[0];
            series3.ArgumentScaleType = ScaleType.DateTime;
            series3.ArgumentDataMember = "SCANDATE";
            series3.ValueScaleType = ScaleType.Numerical;
            series3.ValueDataMembers.AddRange(new string[] { "TUBING_TEMP" });

            Series series4 = new Series("Casing Temp", ViewType.StackedLine);
            chartTemperaturePresure.Series.Add(series4);
            //paras = new Dictionary<string, object>();
            //paras.Add("@param", Globals.ForeignKey);
            //ds = dbCon.execprosedure("[prosedur_getdataChartPressureandTemperatureCasingTemp]", paras);

            series4.DataSource = ds.Tables[0];
            series4.ArgumentScaleType = ScaleType.DateTime;
            series4.ArgumentDataMember = "SCANDATE";
            series4.ValueScaleType = ScaleType.Numerical;
            series4.ValueDataMembers.AddRange(new string[] { "CASING_TEMP" });
        }

        private void gvDynoCards_CustomUnboundColumnData(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs e)
        {
            if (e.Column.FieldName == "Select")
            {
                if (e.IsGetData)
                {
                    string tmp = _RepositoryItemCheckEdit.ValueChecked.ToString();
                    if (_UnboundCheckValues.ContainsKey(e.ListSourceRowIndex))
                    {
                        e.Value = _UnboundCheckValues[e.ListSourceRowIndex];
                        
                    }
                }
                if (e.IsSetData)
                {
                    if (_UnboundCheckValues.ContainsKey(e.ListSourceRowIndex))
                    {
                        _UnboundCheckValues[e.ListSourceRowIndex] = e.Value;
                    }
                    else
                    {
                        _UnboundCheckValues.Add(e.ListSourceRowIndex, e.Value);
                    }
                    //Console.WriteLine("CustomUnboundColumnData Set");
                }
            }

        }

        private void gvDynoCards_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {


        }

        private void gvDynoCards_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            //StringBuilder sb = new StringBuilder();
            //List<string> listdata = new List<string>();
            ////for (int i = 0; i < gvDynoCards.RowCount; i++)
            //for (int i = 0; i < 2; i++)
            //{
            //    sb.Append(string.Format("\tRowHandle: {0}, Value: {1}{2}", i, gvDynoCards.GetRowCellValue(i, col), Environment.NewLine));
            //    //MessageBox.Show(gvDynoCards.GetRowCellValue(i, "Check").ToString());
            //    //string tmp1 = gvDynoCards.GetRowCellValue(i, "Check").ToString();
            //    string tmp = (gvDynoCards.GetRowCellValue(i, "Check") != null) ? gvDynoCards.GetRowCellValue(i, "Check").ToString() : "";
            //    //MessageBox.Show(gvDynoCards.GetRowCellValue(i, col).ToString());
            //    //if (tmp == "True")
            //    //{
            //    //    listdata.Add(gvDynoCards.GetRowCellValue(i, gvDynoCards.Columns[0]).ToString());

            //    //}
                
            //        listdata.Add(gvDynoCards.GetRowCellValue(i, gvDynoCards.Columns[0]).ToString());


                 
            //}
            // chartDynoload(listdata);

        }

        private void gvDynoCards_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {

        }

        private void CreateUnboundColumn()
        {
       
        }

        void _RepositoryItemCheckEdit_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            //Text = count++.ToString();
            List<string> listdata = new List<string>();
            //sb.Append("Unbound column values:" + Environment.NewLine);
            for (int i = 0; i < _UnboundCheckValues.Count; i++)
            {
                //listdata.Add(_UnboundCheckValues[i]);
                if (_UnboundCheckValues.ContainsKey(i))
                {
                    listdata.Add(gvDynoCards.GetRowCellValue(i, gvDynoCards.Columns[0]).ToString());
                }
            }
            chartDynoload(listdata);
        }
        void Bacaopc(string strfunction)
        {
            try
            {
                MyOPCServer.Connect("asi.OPC", "127.0.0.1");
                My_OPCGroup = MyOPCServer.OPCGroups.Add("MyOPCGroup");
                My_OPCGroup.IsActive = true;
                My_OPCGroup.IsSubscribed = true;
                My_OPCGroup.UpdateRate = 1000;    //1 second
                My_OPCGroup.DataChange += new DIOPCGroupEvent_DataChangeEventHandler(My_OPCGroup_DataChange);
                My_OPCGroup.AsyncWriteComplete += new DIOPCGroupEvent_AsyncWriteCompleteEventHandler(My_OPCGroup_AsyncWriteComplete);
                My_OPCGroup.AsyncReadComplete += new DIOPCGroupEvent_AsyncReadCompleteEventHandler(My_OPCGroup_AsyncReadComplete);
               
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Connect! \r\n" + ex.Message);
            }

            MyOPCItem = My_OPCGroup.OPCItems.AddItem(strfunction, 1);
            MyServerHandles[1] = MyOPCItem.ServerHandle;
            int transID;
            My_OPCGroup.AsyncRead(1, MyServerHandles, out MyErrors, DateTime.Now.Second, out transID);
        }

        private void My_OPCGroup_DataChange(int TransactionID, int NumItems, ref Array ClientHandles, ref Array ItemValues, ref Array Qualities, ref Array TimeStamps)
        {
           // txtReadVal.Text = ItemValues.GetValue(1).ToString();
        }

        private void My_OPCGroup_AsyncReadComplete(int TransactionID, int NumItems, ref Array ClientHandles, ref Array ItemValues, ref Array Qualities, ref Array TimeStamps, ref Array Errors)
        {
           // txtReadVal.Text = ItemValues.GetValue(1).ToString();
            objk = ItemValues.GetValue(1);
            My_OPCGroup.IsActive = false;
            populatedyno(lblmfunction.Text);
            
        }

        private void My_OPCGroup_AsyncWriteComplete(int TransactionID, int NumItems, ref System.Array ClientHandles, ref System.Array Errors)
        {
        }
        private void button1_Click(object sender, EventArgs e)
        {
            
            splashScreenManager1.ShowWaitForm();
            //...
            splashScreenManager1.SetWaitFormDescription("Dyno Cards Data Loading...");
            Int32[] selectedRowHandles = gvDynoCards.GetSelectedRows();
            List<string> listdata = new List<string>();
            for (int i = 0; i < selectedRowHandles.Length; i++)
            {
                listdata.Add(gvDynoCards.GetRowCellValue(i, gvDynoCards.Columns[0]).ToString());
            }
            chartDynoload(listdata);
            splashScreenManager1.CloseWaitForm();
        }
        public string kiri( string input, int count)
        {
            return input.Substring(0, Math.Min(input.Length, count));
        }
        void populatedyno(string modulfunction)
        {
            dbCon.clearCache();
            splashScreenManager1.ShowWaitForm();
            //...
            splashScreenManager1.SetWaitFormDescription("Dyno Cards Data Loading...");

            chartDyno.Series.Clear();
            //chartDyno.ClearCache();        

            Series series = new Series("", ViewType.ScatterLine);
            //series.


            DataTable dtAll = new DataTable();
            dtAll.Clear();
            dtAll.Columns.Add("datar");
            dtAll.Columns.Add("tinggi");
            int counter = 0;
            int counter2 = 6;
            IList myList = (IList)objk;
            //ArrayList myList = objk as ArrayList;
            if (myList.Count > 10)
            {
                //List<string> listdata = new List<string>();

                //string arrgabungan = String.Join(",", myList);

                // Guid g =  Guid.NewGuid();
                // string reff1 = g.ToString();
                // g = Guid.NewGuid();
                // string reff2 = g.ToString();
                string cd = myList[0].ToString();
                string ct = myList[1].ToString();
                double totalpoint =double.Parse( myList[2].ToString());
                string totstroke = myList[3].ToString();
                string reasoncode = myList[4].ToString();
                int isdh = int.Parse(myList[5].ToString());

                // string tahun = cd.Substring(0, 2);
                // string bulan = cd.Substring(2, 2);
                // string tanggal = cd.Substring(4, 2);
                // DateTime waktuskrg = DateTime.Now;
                // string jam = waktuskrg.Hour < 10 ? "0" + waktuskrg.Hour.ToString() : waktuskrg.Hour.ToString();// ct.Substring(0, 2);
                // string menit = waktuskrg.Minute < 10 ? "0" + waktuskrg.Minute.ToString() : waktuskrg.Minute.ToString();//ct.Substring(2, 2);
                // string detik = waktuskrg.Second < 10 ? "0" + waktuskrg.Second.ToString() : waktuskrg.Second.ToString();//ct.Substring(4, 2);
                // string scdt = bulan + "/" + tanggal + "/" + tahun + " " + jam + ":" + menit + ":" + detik;

                //string cardtype = "CC";
                double pembagi = totalpoint / 2;
                pembagi = pembagi + 3;
                //int pembagi = pembagi - 1;
                int cek = 0;
                double datax = 0;
                double datay = 0;
                string pertamasurfacex="0",pertamasurfacey = "0", pertamadhx = "0", pertamadhy = "0";

                //Dictionary<string, object> paras = new Dictionary<string, object>(); 
                //paras.Add("@wellname", Globals.ForeignKey);
                //paras.Add("@reffid", reff1);
                //paras.Add("@sd", cd);
                //paras.Add("@st", ct);
                //paras.Add("@scandatetime", scdt);
                //paras.Add("@totalpoint", totalpoint.ToString());
                //paras.Add("@numberofstroke", totstroke);
                //paras.Add("@reasoncode", reasoncode);
                //paras.Add("@isdownhole", isdh.ToString());
                //paras.Add("@typecard", "CC");
                //paras.Add("@by", "admin");
                //paras.Add("@modulfunction", modulfunction);
                //dbCon.execprosedureinup("spadddynomaster", paras);

                //listdata.Add(reff1);
                //if (isdh==1)
                //{

                //    paras = new Dictionary<string, object>();
                //    paras.Add("@wellname", Globals.ForeignKey);
                //    paras.Add("@reffid", reff2);
                //    paras.Add("@sd", cd);
                //    paras.Add("@st", ct);
                //    paras.Add("@scandatetime", scdt);
                //    paras.Add("@totalpoint", totalpoint.ToString());
                //    paras.Add("@numberofstroke", totstroke);
                //    paras.Add("@reasoncode", reasoncode);
                //    paras.Add("@isdownhole", isdh.ToString());
                //    paras.Add("@typecard", "DH");
                //    paras.Add("@by", "admin");
                //    paras.Add("@modulfunction", modulfunction);
                //    dbCon.execprosedureinup("spadddynomaster", paras);
                //}
                 
                foreach (var val in myList)
                {
                    if (counter > 5 && counter % 2 == 0)
                    {
                        DataRow dr = dtAll.NewRow();
                        datax = double.Parse(val.ToString()); // 10;
                        datay = double.Parse(myList[counter + 1].ToString());
                        dr["datar"] = datax.ToString();
                        dr["tinggi"] = myList[counter + 1].ToString();
                        //if(counter==6)
                        //{
                        //       pertamasurfacex = datax.ToString();
                        //        pertamasurfacey = myList[counter + 1].ToString();
                        //}



                        if (counter >= pembagi && isdh == 1)
                        {
                            //listdata.Add(reff2);
                            //reff1 = reff2;
                            //cardtype = "DH";
                            datay = double.Parse(myList[counter + 1].ToString()) - 40000; // 10;
                            dr["tinggi"] = datay.ToString();
                            if (counter >= pembagi && cek == 0)
                            {


                                //DataRow dr2 = dtAll.NewRow();
                                //dr2["datar"] = pertamasurfacex;
                                //dr2["tinggi"] = pertamasurfacey;
                                //dtAll.Rows.Add(dr2);

                                pertamadhx = datax.ToString();
                                pertamadhy = datay.ToString();
                                cek += 1;
                            }

                            // dtAll.Rows.Add(dr);
                        }
                        //paras = new Dictionary<string, object>();
                        //paras.Add("@wellname", Globals.ForeignKey);
                        //paras.Add("@cardtype", cardtype);
                        //paras.Add("@scandate", scdt);
                        //paras.Add("@scanchar", cd+" "+ct);
                        //paras.Add("@datax", datax.ToString());
                        //paras.Add("@datay", datay.ToString());
                        //paras.Add("@reffid", reff1);
                        //paras.Add("@by","Admin");
                        //paras.Add("@pengurang", "40000");

                        //dbCon.execprosedureinup("spadddetaildynocard", paras);
                        dtAll.Rows.Add(dr);

                    }
                    if (counter > 5)
                    {
                        counter2 += 1;
                    }
                    counter += 1;
                }

                if(datax.ToString() != pertamadhx)
                {
                    DataRow dr2 = dtAll.NewRow();
                    dr2["datar"] = pertamadhx;
                    dr2["tinggi"] = pertamadhy;
                    dtAll.Rows.Add(dr2);


                    //paras = new Dictionary<string, object>();
                    //paras.Add("@wellname", Globals.ForeignKey);
                    //paras.Add("@cardtype", "DH");
                    //paras.Add("@scandate", scdt);
                    //paras.Add("@scanchar", cd + " " + ct);
                    //paras.Add("@datax", pertamadhx);
                    //paras.Add("@datay", pertamadhy);
                    //paras.Add("@reffid", reff1);
                    //paras.Add("@by", "Admin");
                    //paras.Add("@pengurang", "40000");

                    //dbCon.execprosedureinup("spadddetaildynocard", paras);
                }





                //chartDynoload(listdata);

                chartDyno.Series.Clear();

                chartDyno.Series.Add(series);
                chartDyno.DataSource = dtAll;

                foreach (DataRow row in dtAll.Rows)
                {
                    series.Points.Add(new SeriesPoint(row["datar"], row["tinggi"]));
                }

            }
            splashScreenManager1.CloseWaitForm();
        }
        private void cboCollectCard_Click(object sender, EventArgs e)
        {
           string pilih = cboCollectCard.SelectedText;

            if(pilih == "Current Card")
            {
                Bacaopc(Globals.ForeignKey+ ".LastPresentCardData");
            }
            else if (pilih == "Full Card")
            {
                Bacaopc(Globals.ForeignKey + ".LastPumpOnCardData");
            }
            else if (pilih == "Pump Off Card")
            {
                Bacaopc(Globals.ForeignKey + ".LastPumpOffCardData");
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            lblmfunction.Text = "1";
            Bacaopc(Globals.ForeignKey + ".LastPresentCardData");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            char[] arr = {'G', 'e', 'e', 'k',
        's', 'F', 'o', 'r', 'G', 'e',
        'e', 'k', 's'};
            IList myList = (IList)arr;
            string s = string.Join("", myList);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            lblmfunction.Text = "2";
            Bacaopc(Globals.ForeignKey + ".LastPumpOnCardData");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            lblmfunction.Text = "3";
            Bacaopc(Globals.ForeignKey + ".LastPumpOffCardData");
        }
    }
}
