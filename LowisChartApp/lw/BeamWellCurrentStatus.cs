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
using LowisChartApp.model;
using OPCAutomation;

namespace LowisChartApp.lw
{
    
    public partial class BeamWellCurrentStatus : DevExpress.XtraEditors.XtraUserControl
    {
        DB dbCon;
        int flag=0;

        public OPCServer MyOPCServer = new OPCServer();
        public OPCGroup My_OPCGroup = null;
        public OPCGroup My_OPCGroupw = null;
        OPCItem MyOPCItem;
        OPCItem MyOPCItemw;
        int[] MyServerHandles = new int[200];
        int[] MyServerHandlesw = new int[200];
        object[] MyValues = new object[200];
        object[] MyValuesw = new object[200];
        public Array MyErrors;


        public BeamWellCurrentStatus()
        {
            InitializeComponent();
            dbCon = new DB(Globals.getstringco());
        }

        private DataTable loaddata()
        {
            Dictionary<string, object> paras = new Dictionary<string, object>();
           // paras.Add("@param", Globals.ForeignKey);
            paras.Add("@param", Globals.ForeignKey);
            DataSet ds = dbCon.execprosedure("dbo.[prosedur_getdatabeamWellGroupStatus]", paras);
            return ds.Tables[0];
        }
        void fillwcs()
        {
            dbCon.clearCache();
            Dictionary<string, object> paras = new Dictionary<string, object>();
            paras.Add("@param", lblWellName.Text);
            DataSet ds = dbCon.execprosedure("dbo.[spgetlastcurrentstatus]", paras);

            dataOPC.Rows.Clear();
            dataOPC.Enabled = true;
            int i = 0;
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                foreach (DataColumn dc in ds.Tables[0].Columns)
                {
                    var field1 = dr[dc].ToString();
                    string namakol = dc.ColumnName;
                    dataOPC.Rows.Add();

                    dataOPC.Rows[i].Cells["colrtu"].Value = field1;
                    dataOPC.Rows[i].Cells["alias"].Value = namakol;
                    if(namakol=="POCMODE")
                    {
                        //if(field1=="0")
                        //{
                            lblpoc.Text = field1;
                        //}
                    }

                    if (namakol == "MOTORSTAT")
                    {
                        lblMotorStatus.Text = field1;
                        if (field1 == "Stop")
                        {
                            lblMotorStatus.BackColor = Color.Red;
                            lblMotorStatus.ForeColor = Color.White;
                        }
                        else
                        {
                            lblMotorStatus.BackColor = Color.Blue;
                            lblMotorStatus.ForeColor = Color.White;
                        }
                    }


                    i += 1;
                }


                //string itemName = dr["description"].ToString();
                //string functionname = dr["colfunction"].ToString();
                //string hostdb = dr["host_value"].ToString();
                //string desc = dr["desc2"].ToString();
                //dataOPC.Rows.Add();

                //dataOPC.Rows[i].Cells["ColumnItem"].Value = itemName;
                //dataOPC.Rows[i].Cells["alias"].Value = desc;
                //dataOPC.Rows[i].Cells["coladdress"].Value = dr["param"].ToString();
                //dataOPC.Rows[i].Cells["colfunction"].Value = dr["colfunction"].ToString();

            }

        }
        private void BeamWellCurrentStatus_Load(object sender, EventArgs e)
        {
            lblWellName.Text = Globals.ForeignKey;
            //DataTable dt=  this.loaddata();
            //lblLastScanTime.Text = dt.Rows[0]["SCANDATE"].ToString();


            fillwcs();



            //lblController.Text = "";
            //lblControllerSubType.Text = dt.Rows[0][21].ToString();
            //lblHostMode.Text = dt.Rows[0][7].ToString();
            //lblRPCMode.Text = "";
            //lblRunTimeToday.Text = "";
            //lblRunTimeYesterday.Text = "";
            //lblMotorSlip.Text = dt.Rows[0][9].ToString();

            //lblCrank.Text = "";
            //lblCBT.Text = "";
            //lblStatus.Text = "";

            //lblCardTime.Text = "";
            //lblAlarm.Text = dt.Rows[0][4].ToString();
            //lblOil.Text = dt.Rows[0][11].ToString();
            //lblWater.Text = dt.Rows[0][12].ToString();
            //lblGas.Text = dt.Rows[0][13].ToString();
            //lblTotalFluid.Text = "";
            //lblTestDate.Text = "";

            //lblHighLoad.Text = "Alarm";
            //lblLoadCell.Text = "Normal";
            //lblLowAvgLoad.Text = "Normal";
            //lblLowLoad.Text = "Normal";
            //lblLowLoadSpan.Text = "Normal";
            //lblManualSD.Text = "Normal";
            //lblPOC.Text = "Normal";
            //lblPosSwitch.Text = "Normal";
            //lblPosition.Text = "Normal";
            //lblPumpOff.Text = "Normal";
            //lblWellOpetation.Text = "Normal";

            //lblCardAreaLastStrCurrent.Text = "";
            //lblCasingPressCurrent.Text = "";
            //lblCasingTempCurrent.Text = "";
            //lblElapsedTimeCurrent.Text = "";
            //lblLastAveragedSPMCurrent.Text = "";
            //lblLastCyleRTCurrent.Text = "";
            //lblLastStrokeSPMCurrent.Text = "";
            //lblSurfacPFCurrent.Text = "";
            //lblTubingPressCurrent.Text = "";
            //lblTubingTempCurrent.Text = "";

            //lblCardAreaLastStrAverageToday.Text = "";
            //lblCasingPressAverageToday.Text = "";
            //lblCasingTempAverageToday.Text = "";
            //lblElapsedTimeAverageToday.Text = "";
            //lblLastAveragedSPMAverageToday.Text = "";
            //lblLastCyleRTAverageToday.Text = "";
            //lblLastStrokeSPMAverageToday.Text = "";
            //lblSurfacPFAverageToday.Text = "";
            //lblTubingPressAverageToday.Text = "";
            //lblTubingTempAverageToday.Text = "";

            //label62.Text = "";
            //lblCasingPressUnit.Text = "";
            //lblCasingTempUnits.Text = "";
            //lblElapsedTimeUnits.Text = "";
            //lblLastAveragedSPMUnits.Text = "";
            //lblLastCyleRTUnits.Text = "";
            //lblLastStrokeSPMUnits.Text = "";
            //lblSurfacPFUnits.Text = "";
            //lblTubingPressUnits.Text = "";
            //lblTubingTempUnits.Text = "";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void lblTubingTempCurrent_Click(object sender, EventArgs e)
        {

        }

        private void lblTubingPressCurrent_Click(object sender, EventArgs e)
        {

        }

        private void lblSurfacPFCurrent_Click(object sender, EventArgs e)
        {

        }

        private void lblLastStrokeSPMCurrent_Click(object sender, EventArgs e)
        {

        }

        private void lblLastCyleRTCurrent_Click(object sender, EventArgs e)
        {

        }

        private void lblLastAveragedSPMCurrent_Click(object sender, EventArgs e)
        {

        }

        private void lblElapsedTimeCurrent_Click(object sender, EventArgs e)
        {

        }

        private void lblCasingTempCurrent_Click(object sender, EventArgs e)
        {

        }

        private void lblCasingPressCurrent_Click(object sender, EventArgs e)
        {

        }

        private void lblCardAreaLastStrCurrent_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void lblCardAreaLastStrUnit_Click(object sender, EventArgs e)
        {

        }

        private void lblCardAreaLastStrAverageToday_Click(object sender, EventArgs e)
        {

        }

        private void lblCasingPressAverageToday_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void lblTubingPressUnits_Click(object sender, EventArgs e)
        {

        }

        private void lblSurfacPFUnits_Click(object sender, EventArgs e)
        {

        }

        private void lblLastStrokeSPMUnits_Click(object sender, EventArgs e)
        {

        }

        private void lblLastCyleRTUnits_Click(object sender, EventArgs e)
        {

        }

        private void lblLastAveragedSPMUnits_Click(object sender, EventArgs e)
        {

        }

        private void lblElapsedTimeUnits_Click(object sender, EventArgs e)
        {

        }

        private void lblCasingTempUnits_Click(object sender, EventArgs e)
        {

        }

        private void lblCasingPressUnit_Click(object sender, EventArgs e)
        {

        }

        private void label62_Click(object sender, EventArgs e)
        {

        }

        private void lblTubingTempAverageToday_Click(object sender, EventArgs e)
        {

        }

        private void lblTubingPressAverageToday_Click(object sender, EventArgs e)
        {

        }

        private void lblSurfacPFAverageToday_Click(object sender, EventArgs e)
        {

        }

        private void lblLastStrokeSPMAverageToday_Click(object sender, EventArgs e)
        {

        }

        private void lblLastCyleRTAverageToday_Click(object sender, EventArgs e)
        {

        }

        private void lblLastAveragedSPMAverageToday_Click(object sender, EventArgs e)
        {

        }

        private void lblElapsedTimeAverageToday_Click(object sender, EventArgs e)
        {

        }

        private void lblCasingTempAverageToday_Click(object sender, EventArgs e)
        {

        }

        private void lblCasingPressAverageToday_Click_1(object sender, EventArgs e)
        {

        }

        private void lblCardAreaLastStrAverageToday_Click_1(object sender, EventArgs e)
        {

        }

        private void lblTubingTempCurrent_Click_1(object sender, EventArgs e)
        {

        }

        private void lblTubingPressCurrent_Click_1(object sender, EventArgs e)
        {

        }

        private void lblSurfacPFCurrent_Click_1(object sender, EventArgs e)
        {

        }

        private void lblLastStrokeSPMCurrent_Click_1(object sender, EventArgs e)
        {

        }

        private void lblLastCyleRTCurrent_Click_1(object sender, EventArgs e)
        {

        }

        private void lblLastAveragedSPMCurrent_Click_1(object sender, EventArgs e)
        {

        }

        private void lblElapsedTimeCurrent_Click_1(object sender, EventArgs e)
        {

        }

        private void lblCasingTempCurrent_Click_1(object sender, EventArgs e)
        {

        }

        private void lblCasingPressCurrent_Click_1(object sender, EventArgs e)
        {

        }

        private void lblCardAreaLastStrCurrent_Click_1(object sender, EventArgs e)
        {

        }

        private void label20_Click_1(object sender, EventArgs e)
        {

        }

        private void label24_Click_1(object sender, EventArgs e)
        {

        }

        private void label16_Click_1(object sender, EventArgs e)
        {

        }

        private void label17_Click_1(object sender, EventArgs e)
        {

        }

        private void label18_Click_1(object sender, EventArgs e)
        {

        }

        private void label19_Click_1(object sender, EventArgs e)
        {

        }

        private void label14_Click_1(object sender, EventArgs e)
        {

        }

        private void label15_Click_1(object sender, EventArgs e)
        {

        }

        private void label9_Click_1(object sender, EventArgs e)
        {

        }

        private void label8_Click_1(object sender, EventArgs e)
        {

        }

        private void lblCardAreaLastStrUnit_Click_1(object sender, EventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void lblTubingTempUnits_Click(object sender, EventArgs e)
        {

        }

        private void xtraTabPage1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        void tulisopc(string nilai,string colfunction)
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
                //btnConnect.Enabled = false;
                //btnDisconnect.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Connect! \r\n" + ex.Message);
            }

            MyOPCItem = My_OPCGroup.OPCItems.AddItem(colfunction, 1);
            MyServerHandles[1] = MyOPCItem.ServerHandle;



            MyValues[1] = nilai;
            int transID;
            My_OPCGroup.AsyncWrite(1, MyServerHandles, MyValues, out MyErrors, DateTime.Now.Second, out transID);
            My_OPCGroup.IsActive = false;
        }
        private void btnStart_Click(object sender, EventArgs e)
        {
            flag = 1;
            try
            {
                tulisopc("524",lblWellName.Text.Trim() + ".ExecuteParameter");
                MessageBox.Show("Start successfully");
            }
            catch(Exception cpt)
            {
                MessageBox.Show("Error: "+cpt.Message);
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            flag = 2;
            try
            {
                tulisopc("525", lblWellName.Text.Trim()+ ".ExecuteParameter");
                MessageBox.Show("Stop successfully");
            }
            catch (Exception cpt)
            {
                MessageBox.Show("Error: "+ cpt.Message);
            }
        }
         
        void fillgrid(string parame, int mulai, int akhir, string fungsi)
        {
             
            try
            {
                dbCon.clearCache();
                Dictionary<string, object> paras = new Dictionary<string, object>();
                paras.Add("@param", parame);
                paras.Add("@mulai", mulai);
                paras.Add("@akhir", akhir);
                paras.Add("@sin", fungsi);
                paras.Add("@wellname", lblWellName.Text);
                DataSet ds = dbCon.execprosedure("dbo.[spgetparamcon]", paras);

                dataOPC.Rows.Clear();
                dataOPC.Enabled = true;
                int i = 0, indeks = 1;
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    string itemName = dr["description"].ToString();
                    string functionname = dr["colfunction"].ToString();
                    string hostdb = dr["host_value"].ToString();
                    string desc = dr["desc2"].ToString();
                    dataOPC.Rows.Add();

                    dataOPC.Rows[i].Cells["ColumnItem"].Value = itemName;
                    dataOPC.Rows[i].Cells["alias"].Value = desc;
                    dataOPC.Rows[i].Cells["coladdress"].Value = dr["param"].ToString();
                   dataOPC.Rows[i].Cells["colfunction"].Value = dr["colfunction"].ToString();
                   // dataOPC.Rows[i].Cells["colhost"].Value = hostdb;



                    i += 1;
                    indeks += 1;
                }

            }
            catch (Exception ex)
            {

            }
            //if (current != lblCurrent.Text)
            //{
            
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
                //btnConnect.Enabled = false;
                //btnDisconnect.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Connect! \r\n" + ex.Message);
            }
            //}

            // My_OPCGroup.IsActive = true;
            int rowg = 1;
            foreach (DataGridViewRow row in dataOPC.Rows)
            {
                if (row.Cells["colfunction"].Value != null)
                {
                    string str1 = row.Cells["colfunction"].Value.ToString();
                    string str2 = rowg.ToString();// row.Cells["coladdress"].Value.ToString();

                    MyOPCItem = My_OPCGroup.OPCItems.AddItem(str1, int.Parse(str2));
                    MyServerHandles[int.Parse(str2)] = MyOPCItem.ServerHandle;

                    rowg += 1;
                }
            }

           // My_OPCGroup.IsActive = false;

        }

        private void My_OPCGroup_DataChange(int TransactionID, int NumItems, ref Array ClientHandles, ref Array ItemValues, ref Array Qualities, ref Array TimeStamps)
        {

            for (int i = 1; i <= NumItems; i++)
            {
                int iHandles = int.Parse(ClientHandles.GetValue(i).ToString());
                dataOPC.Rows[iHandles - 1].Cells["colrtu"].Value = ItemValues.GetValue(i).ToString();
            }

            My_OPCGroup.IsActive = false;


//         ,@IDLE_TIME float
//, @POCMODE nvarchar(100)
//,@MIN_POLISH_ROD_LOAD float
//, @PEAK_POLISH_ROD_LOAD float
// , @PUMP_SPEED float
//  , @TODAYCYCLES float
//   , @YESTCYCLES float
//    , @MOTORSTAT float
//     , @PUMP_STROKE float
//      , @YEST_PUMP_FILL float
//       , @AVG_FILLAGE float
//        , @TODAYRUN float
//         , @YESTRUN float
//          , @CURRENT_INFERRED float
//           , @TODAY_INFERRED float
//            , @YEST_INFERRED float
//             , @ALARM nvarchar(100)
//,@POWER_CONSUME float
//, @POWER_CONSUME_YEST float
// , @PRHP float 
            string IDLE_TIME=string.Empty, POCMODE = string.Empty, MIN_POLISH_ROD_LOAD = string.Empty, PEAK_POLISH_ROD_LOAD = string.Empty, PUMP_SPEED = string.Empty, TODAYCYCLES = string.Empty, YESTCYCLES = string.Empty, MOTORSTAT = string.Empty, PUMP_STROKE = string.Empty, YEST_PUMP_FILL = string.Empty, AVG_FILLAGE = string.Empty, TODAYRUN = string.Empty, YESTRUN = string.Empty, CURRENT_INFERRED = string.Empty, TODAY_INFERRED = string.Empty, YEST_INFERRED = string.Empty, ALARM = string.Empty, POWER_CONSUME = string.Empty, POWER_CONSUME_YEST = string.Empty, PRHP = string.Empty;
            foreach (DataGridViewRow row in dataOPC.Rows)
            {
                if (row.Cells["alias"].Value != null)
                {
                    if (row.Cells["alias"].Value.ToString() == "IDLE_TIME" && row.Cells["colrtu"].Value != null)
                    {
                        IDLE_TIME = row.Cells["colrtu"].Value.ToString();
                    }
                    else if (row.Cells["alias"].Value.ToString() == "POCMODE" && row.Cells["colrtu"].Value != null)
                    {
                        POCMODE = row.Cells["colrtu"].Value.ToString();
                    }
                    else if (row.Cells["alias"].Value.ToString() == "MIN_POLISH_ROD_LOAD" && row.Cells["colrtu"].Value != null)
                    {
                        MIN_POLISH_ROD_LOAD = row.Cells["colrtu"].Value.ToString();
                    }
                    else if (row.Cells["alias"].Value.ToString() == "PUMP_SPEED" && row.Cells["colrtu"].Value != null)
                    {
                        PUMP_SPEED = row.Cells["colrtu"].Value.ToString();
                    }
                    else if (row.Cells["alias"].Value.ToString() == "PEAK_POLISH_ROD_LOAD" && row.Cells["colrtu"].Value != null)
                    {
                        PEAK_POLISH_ROD_LOAD = row.Cells["colrtu"].Value.ToString();
                    }
                    else if (row.Cells["alias"].Value.ToString() == "TODAYCYCLES" && row.Cells["colrtu"].Value != null)
                    {
                        TODAYCYCLES = row.Cells["colrtu"].Value.ToString();
                    }
                    else if (row.Cells["alias"].Value.ToString() == "YESTCYCLES" && row.Cells["colrtu"].Value != null)
                    {
                        YESTCYCLES = row.Cells["colrtu"].Value.ToString();
                    }
                    else if (row.Cells["alias"].Value.ToString() == "MOTORSTAT" && row.Cells["colrtu"].Value != null)
                    {
                        MOTORSTAT = row.Cells["colrtu"].Value.ToString();
                    }
                    else if (row.Cells["alias"].Value.ToString() == "PUMP_STROKE" && row.Cells["colrtu"].Value != null)
                    {
                        PUMP_STROKE = row.Cells["colrtu"].Value.ToString();
                    }
                    else if (row.Cells["alias"].Value.ToString() == "YEST_PUMP_FILL" && row.Cells["colrtu"].Value != null)
                    {
                        YEST_PUMP_FILL = row.Cells["colrtu"].Value.ToString();
                    }
                    else if (row.Cells["alias"].Value.ToString() == "AVG_FILLAGE" && row.Cells["colrtu"].Value != null)
                    {
                        AVG_FILLAGE = row.Cells["colrtu"].Value.ToString();
                    }
                    else if (row.Cells["alias"].Value.ToString() == "TODAYRUN" && row.Cells["colrtu"].Value != null)
                    {
                        TODAYRUN = row.Cells["colrtu"].Value.ToString();
                    }
                    else if (row.Cells["alias"].Value.ToString() == "YESTRUN" && row.Cells["colrtu"].Value != null)
                    {
                        YESTRUN = row.Cells["colrtu"].Value.ToString();
                    }
                    else if (row.Cells["alias"].Value.ToString() == "CURRENT_INFERRED" && row.Cells["colrtu"].Value != null)
                    {
                        CURRENT_INFERRED = row.Cells["colrtu"].Value.ToString();
                    }
                    else if (row.Cells["alias"].Value.ToString() == "TODAY_INFERRED" && row.Cells["colrtu"].Value != null)
                    {
                        TODAY_INFERRED = row.Cells["colrtu"].Value.ToString();
                    }
                    else if (row.Cells["alias"].Value.ToString() == "YEST_INFERRED" && row.Cells["colrtu"].Value != null)
                    {
                        YEST_INFERRED = row.Cells["colrtu"].Value.ToString();
                    }
                    else if (row.Cells["alias"].Value.ToString() == "ALARM" && row.Cells["colrtu"].Value != null)
                    {
                        ALARM = row.Cells["colrtu"].Value.ToString();
                    }
                    else if (row.Cells["alias"].Value.ToString() == "POWER_CONSUME" && row.Cells["colrtu"].Value != null)
                    {
                        POWER_CONSUME = row.Cells["colrtu"].Value.ToString();
                    }
                    else if (row.Cells["alias"].Value.ToString() == "POWER_CONSUME_YEST" && row.Cells["colrtu"].Value != null)
                    {
                        POWER_CONSUME_YEST = row.Cells["colrtu"].Value.ToString();
                    }
                    else if (row.Cells["alias"].Value.ToString() == "PRHP" && row.Cells["colrtu"].Value != null)
                    {
                        PRHP = row.Cells["colrtu"].Value.ToString();
                    }
                }

                 
            }
            dbCon.clearCache();
            Dictionary<string, object> paras = new Dictionary<string, object>();
    
            paras.Add("@wellname", lblWellName.Text);
            paras.Add("@IDLE_TIME", IDLE_TIME);
            if (POCMODE == "0")
            {
                POCMODE = "POC";
            }
            else if (POCMODE == "1")
            {
                POCMODE = "%Timer";
            }
            else if (POCMODE == "2")
            {
                POCMODE = "XFER";
            }
            paras.Add("@POCMODE", POCMODE);
            paras.Add("@MIN_POLISH_ROD_LOAD", MIN_POLISH_ROD_LOAD);
            paras.Add("@PEAK_POLISH_ROD_LOAD", PEAK_POLISH_ROD_LOAD);
            paras.Add("@PUMP_SPEED", PUMP_SPEED);
            paras.Add("@TODAYCYCLES", TODAYCYCLES);
            paras.Add("@YESTCYCLES", YESTCYCLES);
            if(MOTORSTAT =="0")
            {
                MOTORSTAT = "Stop";
            }
            else
            {
                MOTORSTAT = "Running";
            }
            paras.Add("@MOTORSTAT", MOTORSTAT);
            paras.Add("@PUMP_STROKE", PUMP_STROKE);
            paras.Add("@YEST_PUMP_FILL", YEST_PUMP_FILL);
            paras.Add("@AVG_FILLAGE", AVG_FILLAGE);
            paras.Add("@TODAYRUN", TODAYRUN); 
            paras.Add("@YESTRUN", YESTRUN);
            paras.Add("@CURRENT_INFERRED", CURRENT_INFERRED);
            paras.Add("@TODAY_INFERRED", TODAY_INFERRED);
            paras.Add("@YEST_INFERRED", YEST_INFERRED);
            paras.Add("@ALARM", ALARM);
            paras.Add("@POWER_CONSUME", POWER_CONSUME);
            paras.Add("@POWER_CONSUME_YEST", POWER_CONSUME_YEST);
            paras.Add("@PRHP", PRHP); 
            paras.Add("@by", Globals.userlogin);
            dbCon.execprosedureinup("spaddnupdatewcs", paras);


            fillwcs();
             MessageBox.Show("Scanning successfully");
        }

        private void My_OPCGroup_AsyncReadComplete(int TransactionID, int NumItems, ref Array ClientHandles, ref Array ItemValues, ref Array Qualities, ref Array TimeStamps, ref Array Errors)
        {
           
            // txtReadVal.Text = ItemValues.GetValue(1).ToString();
            //dataOPC.Rows[rowgrid].Cells[2].Value = ItemValues.Length.ToString();// ItemValues.GetValue(1).ToString();
        }

        private void My_OPCGroup_AsyncWriteComplete(int TransactionID, int NumItems, ref System.Array ClientHandles, ref System.Array Errors)
        {
        }

        public void button1_Click(object sender, EventArgs e)
        {
            flag = 3;
            splashScreenManager1.ShowWaitForm();
            //...
            //splashScreenManager1.SetWaitFormDescription("Dyno Cards Data Loading...");
            try
            {
                fillgrid("6", 1,1, "");
              //  System.Threading.Thread.Sleep(2000);
                
            }
            catch (Exception exc)
            {
                MessageBox.Show("start and end address must be integer");
            }
        
            splashScreenManager1.CloseWaitForm();

        }

        private void btn_clear_Alarm_Click(object sender, EventArgs e)
        {
            flag = 4;
            try
            {
                tulisopc("523", lblWellName.Text.Trim()+ ".ExecuteParameter");
                MessageBox.Show("Clear Alarm successfully");
            }
            catch (Exception cpt)
            {
                MessageBox.Show("Error: " + cpt.Message);
            }
        }
    }
}
