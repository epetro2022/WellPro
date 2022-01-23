using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using LowisChartApp.BeamWellConditions;
using LowisChartApp.lw;
using LowisChartApp.model;
using System.Threading;
using LowisChartApp.utility;

namespace LowisChartApp
{
    public partial class frmMain : DevExpress.XtraEditors.XtraForm
    {
        private TreeNode m_OldSelectNode;
        DB dbCon;
        public event EventHandler ButtonFirstFormClicked;
        BackgroundWorker m_oWorker;
        LowisForm modulePEDashboard;
        BeamWellCurrentStatus moduleBeamWellCurrentStatus;
        DiscreteStatus moduleDiscreteStatus;
        ESPWellCurrentStatus moduleESPWellCurrentStatus;
        BeamWellCurrentStatusMain moduleBeamWellCurrentStatusMain;
        ESPWellCurrentStatusMain moduleESPWellCurrentStatusMain;
        Mostrecenttest moduleMostrecenttest;
        Groupdescretestatus moduleGroupDiscreteStatus;
        GroupAnalogStatus moduleGroupAnalogStatus;
        AlarmClassConfig moduleAlarmClassConfiguration;
        WellgroupStatus moduleWellgroupStatus;
        AlarmHistory moduleAlarmHistory;
        BeamWellGroupConfiguration moduleBeamWellGroupConfiguration;
        GroupDescreteConfig moduleGroupDescreteConfig;
        GroupAnalogConfig moduleGroupAnalogConfig;
        rw modulerw;
        rw2 modulerw2;
        LowisForm moduleWellGroupStatus;
        LowisForm moduleWellAnalysis;
        LowisForm moduleConfiguration;
        LowisForm moduleWelltest;
        LowisForm moduleWellFailure;
        LowisForm moduleOutofSpecHighPeak;
        LowisForm moduleParameterMismatch;
        LowisForm moduleUnconfiguredAlarms;
        LowisForm moduleUnconfiguredCranks;
        LowisForm moduleInvalidPumpEffSPM;
        LowisForm moduleOldCards;
        LowisForm moduleConfigured;
        LowisForm module24HRFOP;
        LowisForm moduleHighCycles150;
        LowisForm moduleGearboxOverLoad110;
        LowisForm moduleLowRuntime;
        LowisForm moduleUnderDisplaced;
        LowisForm moduleOptimized;
        LowisForm moduleOverloadedRods;
        LowisForm moduleLowPumpEfficiency;
        LowisForm moduleMoreFluidAvailable;
        LowisForm moduleProductionDecreasing;
        LowisForm moduleQuestionablePOC;
        LowisForm moduleMiscalibrationofData;
        LowisForm moduleUnitsUnderUtilized;
        LowisForm moduleCandidatesforUnitUpsize;
        LowisForm moduleSavingsFromBalancing;
        detailLW moduleDetailLW;
        WellCurrentStatus moduleWellCurrentStatus;
        EspGroup moduleEspGroupAllEspWell;
        EspGroup moduleEspGroupAlarms;
        EspGroup moduleEspGroupAlarmsatGO;
        EspGroup moduleEspGroupRunning;
        EspGroup moduleEspGroupInServiceWellType;
        EspGroup moduleEspGroupOutofService;
        EspGroup moduleEspGroupDown;
        EspGroup moduleEspGroupCommFail;
        EspGroup moduleEspGroupCommOk;
        frmFav favDialog;
        public frmMain()
        {
            InitializeComponent();
            dbCon = new DB(Globals.getstringco());
            m_oWorker = new BackgroundWorker();
            m_oWorker.DoWork += new DoWorkEventHandler(m_oWorker_DoWork);
            m_oWorker.ProgressChanged += new ProgressChangedEventHandler(m_oWorker_ProgressChanged);
            m_oWorker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(m_oWorker_RunWorkerCompleted);
            m_oWorker.WorkerReportsProgress = true;
            m_oWorker.WorkerSupportsCancellation = true;
        }
        void m_oWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
        }

        void m_oWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            //Here you play with the main UI thread
            progressBar1.Value = e.ProgressPercentage;
            //lblStatus.Text = "Processing......" + progressBar1.Value.ToString() + "%";
        }

        void m_oWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            //NOTE : Never play with the UI thread here...

            //time consuming operation
            for (int i = 0; i < 100; i++)
            {
                Thread.Sleep(100);
                m_oWorker.ReportProgress(i);

                //If cancel button was pressed while the execution is in progress
                //Change the state from cancellation ---> cancel'ed
                if (m_oWorker.CancellationPending)
                {
                    e.Cancel = true;
                    m_oWorker.ReportProgress(0);
                    return;
                }

            }

            //Report 100% completion on operation completed
            m_oWorker.ReportProgress(100);
        }
        public void ShowModule(string namakelas)
        {
            switch (namakelas)
            {
                case "Test Temp":
                    //MessageBox.Show("All");
                    TmpTest moduleTmpTest = new TmpTest();
                    moduleTmpTest.Dock = DockStyle.Fill;
                    if (splitContainer1.Panel2.Controls.Count > 0)
                    {
                        splitContainer1.Panel2.Controls.RemoveAt(0);
                    }
                    this.splitContainer1.Panel2.Controls.Clear();
                    moduleTmpTest.Bounds = splitContainer1.Panel2.DisplayRectangle;
                    this.splitContainer1.Panel2.Controls.Add(moduleTmpTest);
                    this.splitContainer1.Panel2.Update();
                    moduleTmpTest.Show();
                    if (Globals.treePilih != "Discrete")
                    {
                        lvWellCol("Discrete");
                        loaddatalv("Discrete");
                        Globals.treePilih = "Discrete";
                    }
                    break;

                case "Beam Well Current Status Detail":
                    //MessageBox.Show("All");
                    moduleBeamWellCurrentStatus = new BeamWellCurrentStatus();
                    moduleBeamWellCurrentStatus.Dock = DockStyle.Fill;
                    if (splitContainer1.Panel2.Controls.Count > 0)
                    {
                        splitContainer1.Panel2.Controls.RemoveAt(0);
                    }
                    this.splitContainer1.Panel2.Controls.Clear();
                    moduleBeamWellCurrentStatus.Bounds = splitContainer1.Panel2.DisplayRectangle;
                    this.splitContainer1.Panel2.Controls.Add(moduleBeamWellCurrentStatus);
                    this.splitContainer1.Panel2.Update();
                    moduleBeamWellCurrentStatus.Show();
                    if (Globals.treePilih != "Beam")
                    {
                        lvWellCol("Beam");
                        loaddatalv("Beam");
                        Globals.treePilih = "Beam";
                        ttJenis.Text = "Beam Well";
                    }
                    break;

                case "Discrete Status":
                    moduleDiscreteStatus = new DiscreteStatus();
                    moduleDiscreteStatus.Dock = DockStyle.Fill;
                    if (splitContainer1.Panel2.Controls.Count > 0)
                    {
                        splitContainer1.Panel2.Controls.RemoveAt(0);
                    }
                    this.splitContainer1.Panel2.Controls.Clear();
                    moduleDiscreteStatus.Bounds = splitContainer1.Panel2.DisplayRectangle;
                    this.splitContainer1.Panel2.Controls.Add(moduleDiscreteStatus);
                    this.splitContainer1.Panel2.Update();
                    moduleDiscreteStatus.Show();
                    if (Globals.treePilih != "Discrete")
                    {
                        lvWellCol("Discrete");
                        loaddatalv("Discrete");
                        Globals.treePilih = "Discrete";
                    }
                    break;

                case "ESP Well Current Status Detail":
                    moduleESPWellCurrentStatus = new ESPWellCurrentStatus();
                    moduleESPWellCurrentStatus.Dock = DockStyle.Fill;
                    if (splitContainer1.Panel2.Controls.Count > 0)
                    {
                        splitContainer1.Panel2.Controls.RemoveAt(0);
                    }
                    this.splitContainer1.Panel2.Controls.Clear();
                    moduleESPWellCurrentStatus.Bounds = splitContainer1.Panel2.DisplayRectangle;
                    this.splitContainer1.Panel2.Controls.Add(moduleESPWellCurrentStatus);
                    this.splitContainer1.Panel2.Update();
                    moduleESPWellCurrentStatus.Show();
                    if (Globals.treePilih != "Beam")
                    {
                        lvWellCol("Beam");
                        loaddatalv("Beam");
                        Globals.treePilih = "Beam";
                        ttJenis.Text = "Beam Well";
                    }
                    break;

                case "Beam Well Current Status":
                    //MessageBox.Show("All");
                    moduleBeamWellCurrentStatusMain = new BeamWellCurrentStatusMain();
                    moduleBeamWellCurrentStatusMain.Dock = DockStyle.Fill;
                    if (splitContainer1.Panel2.Controls.Count > 0)
                    {
                        splitContainer1.Panel2.Controls.RemoveAt(0);
                    }
                    this.splitContainer1.Panel2.Controls.Clear();
                    moduleBeamWellCurrentStatusMain.Bounds = splitContainer1.Panel2.DisplayRectangle;
                    this.splitContainer1.Panel2.Controls.Add(moduleBeamWellCurrentStatusMain);
                    this.splitContainer1.Panel2.Update();
                    moduleBeamWellCurrentStatusMain.Show();
                    if (Globals.treePilih != "Beam")
                    {
                        lvWellCol("Beam");
                        loaddatalv("Beam");
                        Globals.treePilih = "Beam";
                        ttJenis.Text = "Beam Well";
                    }
                    break;

                case "ESP Well Current Status":
                    //MessageBox.Show("All");
                    moduleESPWellCurrentStatusMain = new ESPWellCurrentStatusMain();
                    moduleESPWellCurrentStatusMain.Dock = DockStyle.Fill;
                    if (splitContainer1.Panel2.Controls.Count > 0)
                    {
                        splitContainer1.Panel2.Controls.RemoveAt(0);
                    }
                    this.splitContainer1.Panel2.Controls.Clear();
                    moduleESPWellCurrentStatusMain.Bounds = splitContainer1.Panel2.DisplayRectangle;
                    this.splitContainer1.Panel2.Controls.Add(moduleESPWellCurrentStatusMain);
                    this.splitContainer1.Panel2.Update();
                    moduleESPWellCurrentStatusMain.Show();
                    if (Globals.treePilih != "Beam")
                    {
                        lvWellCol("Beam");
                        loaddatalv("Beam");
                        Globals.treePilih = "Beam";
                        ttJenis.Text = "Beam Well";
                    }
                    break;

                case "Most Recent Test":
                    //MessageBox.Show("All");
                    moduleMostrecenttest = new Mostrecenttest();
                    moduleMostrecenttest.Dock = DockStyle.Fill;
                    if (splitContainer1.Panel2.Controls.Count > 0)
                    {
                        splitContainer1.Panel2.Controls.RemoveAt(0);
                    }
                    this.splitContainer1.Panel2.Controls.Clear();
                    moduleMostrecenttest.Bounds = splitContainer1.Panel2.DisplayRectangle;
                    this.splitContainer1.Panel2.Controls.Add(moduleMostrecenttest);
                    this.splitContainer1.Panel2.Update();
                    moduleMostrecenttest.Show();
                    if (Globals.treePilih != "Beam")
                    {
                        lvWellCol("Beam");
                        loaddatalv("Beam");
                        Globals.treePilih = "Beam";
                        ttJenis.Text = "Beam Well";
                    }
                    break;

                case "Group Discrete Status":
                    //MessageBox.Show("All");
                    moduleGroupDiscreteStatus = new Groupdescretestatus();
                    moduleGroupDiscreteStatus.Dock = DockStyle.Fill;
                    if (splitContainer1.Panel2.Controls.Count > 0)
                    {
                        splitContainer1.Panel2.Controls.RemoveAt(0);
                    }
                    this.splitContainer1.Panel2.Controls.Clear();
                    moduleGroupDiscreteStatus.Bounds = splitContainer1.Panel2.DisplayRectangle;
                    this.splitContainer1.Panel2.Controls.Add(moduleGroupDiscreteStatus);
                    this.splitContainer1.Panel2.Update();
                    moduleGroupDiscreteStatus.Show();
                    if (Globals.treePilih != "Beam")
                    {
                        lvWellCol("Beam");
                        loaddatalv("Beam");
                        Globals.treePilih = "Beam";
                        ttJenis.Text = "Beam Well";
                    }
                    break;

                case "Group Analog Status":
                    //MessageBox.Show("All");
                    moduleGroupAnalogStatus = new GroupAnalogStatus();
                    moduleGroupAnalogStatus.Dock = DockStyle.Fill;
                    if (splitContainer1.Panel2.Controls.Count > 0)
                    {
                        splitContainer1.Panel2.Controls.RemoveAt(0);
                    }
                    this.splitContainer1.Panel2.Controls.Clear();
                    moduleGroupAnalogStatus.Bounds = splitContainer1.Panel2.DisplayRectangle;
                    this.splitContainer1.Panel2.Controls.Add(moduleGroupAnalogStatus);
                    this.splitContainer1.Panel2.Update();
                    moduleGroupAnalogStatus.Show();
                    if (Globals.treePilih != "Beam")
                    {
                        lvWellCol("Beam");
                        loaddatalv("Beam");
                        Globals.treePilih = "Beam";
                        ttJenis.Text = "Beam Well";
                    }
                    break;

                case "Alarm Class Configuration":
                    //MessageBox.Show("All");
                    moduleAlarmClassConfiguration = new AlarmClassConfig();
                    moduleAlarmClassConfiguration.Dock = DockStyle.Fill;
                    if (splitContainer1.Panel2.Controls.Count > 0)
                    {
                        splitContainer1.Panel2.Controls.RemoveAt(0);
                    }
                    this.splitContainer1.Panel2.Controls.Clear();
                    moduleAlarmClassConfiguration.Bounds = splitContainer1.Panel2.DisplayRectangle;
                    this.splitContainer1.Panel2.Controls.Add(moduleAlarmClassConfiguration);
                    this.splitContainer1.Panel2.Update();
                    moduleAlarmClassConfiguration.Show();
                    if (Globals.treePilih != "Beam")
                    {
                        lvWellCol("Beam");
                        loaddatalv("Beam");
                        Globals.treePilih = "Beam";
                        ttJenis.Text = "Beam Well";
                    }
                    break;

                case "ESP Well group Status":
                    //MessageBox.Show("All");
                    moduleWellgroupStatus = new WellgroupStatus();
                    moduleWellgroupStatus.Dock = DockStyle.Fill;
                    if (splitContainer1.Panel2.Controls.Count > 0)
                    {
                        splitContainer1.Panel2.Controls.RemoveAt(0);
                    }
                    this.splitContainer1.Panel2.Controls.Clear();
                    moduleWellgroupStatus.Bounds = splitContainer1.Panel2.DisplayRectangle;
                    this.splitContainer1.Panel2.Controls.Add(moduleWellgroupStatus);
                    this.splitContainer1.Panel2.Update();
                    moduleWellgroupStatus.Show();
                    if (Globals.treePilih != "Beam")
                    {
                        lvWellCol("Beam");
                        loaddatalv("Beam");
                        Globals.treePilih = "Beam";
                        ttJenis.Text = "Beam Well";
                    }
                    break;

                case "Alarm History":
                    //MessageBox.Show("All");
                    moduleAlarmHistory = new AlarmHistory();
                    moduleAlarmHistory.Dock = DockStyle.Fill;
                    if (splitContainer1.Panel2.Controls.Count > 0)
                    {
                        splitContainer1.Panel2.Controls.RemoveAt(0);
                    }
                    this.splitContainer1.Panel2.Controls.Clear();
                    moduleAlarmHistory.Bounds = splitContainer1.Panel2.DisplayRectangle;
                    this.splitContainer1.Panel2.Controls.Add(moduleAlarmHistory);
                    this.splitContainer1.Panel2.Update();
                    moduleAlarmHistory.Show();
                    if (Globals.treePilih != "Beam")
                    {
                        lvWellCol("Beam");
                        loaddatalv("Beam");
                        Globals.treePilih = "Beam";
                        ttJenis.Text = "Beam Well";
                    }
                    break;
                case "Beam Well Group Configuration":
                    //MessageBox.Show("All");
                    moduleBeamWellGroupConfiguration = new BeamWellGroupConfiguration();
                    moduleBeamWellGroupConfiguration.Dock = DockStyle.Fill;
                    if (splitContainer1.Panel2.Controls.Count > 0)
                    {
                        splitContainer1.Panel2.Controls.RemoveAt(0);
                    }
                    this.splitContainer1.Panel2.Controls.Clear();
                    moduleBeamWellGroupConfiguration.Bounds = splitContainer1.Panel2.DisplayRectangle;
                    this.splitContainer1.Panel2.Controls.Add(moduleBeamWellGroupConfiguration);
                    this.splitContainer1.Panel2.Update();
                    moduleBeamWellGroupConfiguration.Show();
                    if (Globals.treePilih != "Beam")
                    {
                        lvWellCol("Beam");
                        loaddatalv("Beam");
                        Globals.treePilih = "Beam";
                        ttJenis.Text = "Beam Well";
                    }
                    break;
                case "Group Descrete Config":
                    //MessageBox.Show("All");
                    moduleGroupDescreteConfig = new GroupDescreteConfig();
                    moduleGroupDescreteConfig.Dock = DockStyle.Fill;
                    if (splitContainer1.Panel2.Controls.Count > 0)
                    {
                        splitContainer1.Panel2.Controls.RemoveAt(0);
                    }
                    this.splitContainer1.Panel2.Controls.Clear();
                    moduleGroupDescreteConfig.Bounds = splitContainer1.Panel2.DisplayRectangle;
                    this.splitContainer1.Panel2.Controls.Add(moduleGroupDescreteConfig);
                    this.splitContainer1.Panel2.Update();
                    moduleGroupDescreteConfig.Show();
                    if (Globals.treePilih != "Beam")
                    {
                        lvWellCol("Beam");
                        loaddatalv("Beam");
                        Globals.treePilih = "Beam";
                        ttJenis.Text = "Beam Well";
                    }
                    break;
                case "Group Analog Config":
                    //MessageBox.Show("All");
                    moduleGroupAnalogConfig = new GroupAnalogConfig();
                    moduleGroupAnalogConfig.Dock = DockStyle.Fill;
                    if (splitContainer1.Panel2.Controls.Count > 0)
                    {
                        splitContainer1.Panel2.Controls.RemoveAt(0);
                    }
                    this.splitContainer1.Panel2.Controls.Clear();
                    moduleGroupAnalogConfig.Bounds = splitContainer1.Panel2.DisplayRectangle;
                    this.splitContainer1.Panel2.Controls.Add(moduleGroupAnalogConfig);
                    this.splitContainer1.Panel2.Update();
                    moduleGroupAnalogConfig.Show();
                    if (Globals.treePilih != "Beam")
                    {
                        lvWellCol("Beam");
                        loaddatalv("Beam");
                        Globals.treePilih = "Beam";
                        ttJenis.Text = "Beam Well";
                    }
                    break;
                case "Well Group Status":
                    //MessageBox.Show("All");
                    moduleWellGroupStatus = new LowisForm();
                    moduleWellGroupStatus.Dock = DockStyle.Fill;
                    if (splitContainer1.Panel2.Controls.Count > 0)
                    {
                        splitContainer1.Panel2.Controls.RemoveAt(0);
                    }
                    this.splitContainer1.Panel2.Controls.Clear();
                    moduleWellGroupStatus.Bounds = splitContainer1.Panel2.DisplayRectangle;
                    this.splitContainer1.Panel2.Controls.Add(moduleWellGroupStatus);
                    this.splitContainer1.Panel2.Update();
                    moduleWellGroupStatus.Show();
                    if (Globals.treePilih != "Beam")
                    {
                        lvWellCol("Beam");
                        loaddatalv("Beam");
                        Globals.treePilih = "Beam";
                        ttJenis.Text = "Beam Well";
                    }
                    break;
                case "PE Dashboard":
                    modulePEDashboard = new LowisForm();
                    modulePEDashboard.Dock = DockStyle.Fill;
                   
                    if (splitContainer1.Panel2.Controls.Count > 0)
                    {
                        splitContainer1.Panel2.Controls.RemoveAt(0);
                    }
                    this.splitContainer1.Panel2.Controls.Clear();
                    modulePEDashboard.Bounds = splitContainer1.Panel2.DisplayRectangle;
                    this.splitContainer1.Panel2.Controls.Add(modulePEDashboard);
                    this.splitContainer1.Panel2.Update();
                    modulePEDashboard.Show();
                    if (Globals.treePilih != "Beam")
                    {
                        lvWellCol("Beam");
                        loaddatalv("Beam");
                        Globals.treePilih = "Beam";
                        ttJenis.Text = "Beam Well";
                    }
                    break;
                case "Well Analysis":
                    //MessageBox.Show("All");
                    moduleWellAnalysis = new LowisForm();
                    moduleWellAnalysis.Dock = DockStyle.Fill;
                    if (splitContainer1.Panel2.Controls.Count > 0)
                    {
                        splitContainer1.Panel2.Controls.RemoveAt(0);
                    }
                    this.splitContainer1.Panel2.Controls.Clear();
                    moduleWellAnalysis.Bounds = splitContainer1.Panel2.DisplayRectangle;
                    this.splitContainer1.Panel2.Controls.Add(moduleWellAnalysis);
                    this.splitContainer1.Panel2.Update();
                    moduleWellAnalysis.Show();
                    if (Globals.treePilih != "Beam")
                    {
                        lvWellCol("Beam");
                        loaddatalv("Beam");
                        Globals.treePilih = "Beam";
                        ttJenis.Text = "Beam Well";
                    }
                    break;
                case "Configuration":
                    //MessageBox.Show("Alarms");
                    moduleConfiguration = new LowisForm();
                    moduleConfiguration.Dock = DockStyle.Fill;
                    if (splitContainer1.Panel2.Controls.Count > 0)
                    {
                        splitContainer1.Panel2.Controls.RemoveAt(0);
                    }
                    this.splitContainer1.Panel2.Controls.Clear();
                    moduleConfiguration.Bounds = splitContainer1.Panel2.DisplayRectangle;
                    this.splitContainer1.Panel2.Controls.Add(moduleConfiguration);
                    this.splitContainer1.Panel2.Update();
                    moduleConfiguration.Show();
                    if (Globals.treePilih != "Beam")
                    {
                        lvWellCol("Beam");
                        loaddatalv("Beam");
                        Globals.treePilih = "Beam";
                        ttJenis.Text = "Beam Well";
                    }
                    break;
                case "Welltest":
                    //MessageBox.Show("All");
                    moduleWelltest = new LowisForm();
                    moduleWelltest.Dock = DockStyle.Fill;
                    if (splitContainer1.Panel2.Controls.Count > 0)
                    {
                        splitContainer1.Panel2.Controls.RemoveAt(0);
                    }
                    this.splitContainer1.Panel2.Controls.Clear();
                    moduleWelltest.Bounds = splitContainer1.Panel2.DisplayRectangle;
                    this.splitContainer1.Panel2.Controls.Add(moduleWelltest);
                    this.splitContainer1.Panel2.Update();
                    moduleWelltest.Show();
                    if (Globals.treePilih != "Beam")
                    {
                        lvWellCol("Beam");
                        loaddatalv("Beam");
                        Globals.treePilih = "Beam";
                        ttJenis.Text = "Beam Well";
                    }
                    break;
                case "Well Failure":
                    //MessageBox.Show("Alarms");
                    moduleWellFailure = new LowisForm();
                    moduleWellFailure.Dock = DockStyle.Fill;
                    if (splitContainer1.Panel2.Controls.Count > 0)
                    {
                        splitContainer1.Panel2.Controls.RemoveAt(0);
                    }
                    this.splitContainer1.Panel2.Controls.Clear();
                    moduleWellFailure.Bounds = splitContainer1.Panel2.DisplayRectangle;
                    this.splitContainer1.Panel2.Controls.Add(moduleWellFailure);
                    this.splitContainer1.Panel2.Update();
                    moduleWellFailure.Show();
                    if (Globals.treePilih != "Beam")
                    {
                        lvWellCol("Beam");
                        loaddatalv("Beam");
                        Globals.treePilih = "Beam";
                        ttJenis.Text = "Beam Well";
                    }
                    break;

                case "Out of Spec High Peak":
                    //MessageBox.Show("All");
                    moduleOutofSpecHighPeak = new LowisForm();
                    moduleOutofSpecHighPeak.Dock = DockStyle.Fill;
                    if (splitContainer1.Panel2.Controls.Count > 0)
                    {
                        splitContainer1.Panel2.Controls.RemoveAt(0);
                    }
                    this.splitContainer1.Panel2.Controls.Clear();
                    moduleOutofSpecHighPeak.Bounds = splitContainer1.Panel2.DisplayRectangle;
                    this.splitContainer1.Panel2.Controls.Add(moduleOutofSpecHighPeak);
                    this.splitContainer1.Panel2.Update();
                    moduleOutofSpecHighPeak.Show();
                    if (Globals.treePilih != "Beam")
                    {
                        lvWellCol("Beam");
                        loaddatalv("Beam");
                        Globals.treePilih = "Beam";
                        ttJenis.Text = "Beam Well";
                    }
                    break;
                case "Parameter Mismatch":
                    //MessageBox.Show("Alarms");
                    moduleParameterMismatch = new LowisForm();
                    moduleParameterMismatch.Dock = DockStyle.Fill;
                    if (splitContainer1.Panel2.Controls.Count > 0)
                    {
                        splitContainer1.Panel2.Controls.RemoveAt(0);
                    }
                    this.splitContainer1.Panel2.Controls.Clear();
                    moduleParameterMismatch.Bounds = splitContainer1.Panel2.DisplayRectangle;
                    this.splitContainer1.Panel2.Controls.Add(moduleParameterMismatch);
                    this.splitContainer1.Panel2.Update();
                    moduleParameterMismatch.Show();
                    if (Globals.treePilih != "Beam")
                    {
                        lvWellCol("Beam");
                        loaddatalv("Beam");
                        Globals.treePilih = "Beam";
                        ttJenis.Text = "Beam Well";
                    }
                    break;
                case "Unconfigured Alarms":
                    //MessageBox.Show("All");
                    moduleUnconfiguredAlarms = new LowisForm();
                    moduleUnconfiguredAlarms.Dock = DockStyle.Fill;
                    if (splitContainer1.Panel2.Controls.Count > 0)
                    {
                        splitContainer1.Panel2.Controls.RemoveAt(0);
                    }
                    this.splitContainer1.Panel2.Controls.Clear();
                    moduleUnconfiguredAlarms.Bounds = splitContainer1.Panel2.DisplayRectangle;
                    this.splitContainer1.Panel2.Controls.Add(moduleUnconfiguredAlarms);
                    this.splitContainer1.Panel2.Update();
                    moduleUnconfiguredAlarms.Show();
                    if (Globals.treePilih != "Beam")
                    {
                        lvWellCol("Beam");
                        loaddatalv("Beam");
                        Globals.treePilih = "Beam";
                        ttJenis.Text = "Beam Well";
                    }
                    break;
                case "Unconfigured Cranks":
                    //MessageBox.Show("Alarms");
                    moduleUnconfiguredCranks = new LowisForm();
                    moduleUnconfiguredCranks.Dock = DockStyle.Fill;
                    if (splitContainer1.Panel2.Controls.Count > 0)
                    {
                        splitContainer1.Panel2.Controls.RemoveAt(0);
                    }
                    this.splitContainer1.Panel2.Controls.Clear();
                    moduleUnconfiguredCranks.Bounds = splitContainer1.Panel2.DisplayRectangle;
                    this.splitContainer1.Panel2.Controls.Add(moduleUnconfiguredCranks);
                    this.splitContainer1.Panel2.Update();
                    moduleUnconfiguredCranks.Show();
                    if (Globals.treePilih != "Beam")
                    {
                        lvWellCol("Beam");
                        loaddatalv("Beam");
                        Globals.treePilih = "Beam";
                        ttJenis.Text = "Beam Well";
                    }
                    break;
                case "Invalid Pump Eff./ SPM":
                    //MessageBox.Show("All");
                    moduleInvalidPumpEffSPM = new LowisForm();
                    moduleInvalidPumpEffSPM.Dock = DockStyle.Fill;
                    if (splitContainer1.Panel2.Controls.Count > 0)
                    {
                        splitContainer1.Panel2.Controls.RemoveAt(0);
                    }
                    this.splitContainer1.Panel2.Controls.Clear();
                    moduleInvalidPumpEffSPM.Bounds = splitContainer1.Panel2.DisplayRectangle;
                    this.splitContainer1.Panel2.Controls.Add(moduleInvalidPumpEffSPM);
                    this.splitContainer1.Panel2.Update();
                    moduleInvalidPumpEffSPM.Show();
                    if (Globals.treePilih != "Beam")
                    {
                        lvWellCol("Beam");
                        loaddatalv("Beam");
                        Globals.treePilih = "Beam";
                        ttJenis.Text = "Beam Well";
                    }
                    break;
                case "Old Cards":
                    //MessageBox.Show("Alarms");
                    moduleOldCards = new LowisForm();
                    moduleOldCards.Dock = DockStyle.Fill;
                    if (splitContainer1.Panel2.Controls.Count > 0)
                    {
                        splitContainer1.Panel2.Controls.RemoveAt(0);
                    }
                    this.splitContainer1.Panel2.Controls.Clear();
                    moduleOldCards.Bounds = splitContainer1.Panel2.DisplayRectangle;
                    this.splitContainer1.Panel2.Controls.Add(moduleOldCards);
                    this.splitContainer1.Panel2.Update();
                    moduleOldCards.Show();
                    if (Globals.treePilih != "Beam")
                    {
                        lvWellCol("Beam");
                        loaddatalv("Beam");
                        Globals.treePilih = "Beam";
                        ttJenis.Text = "Beam Well";
                    }
                    break;
                case "% Configured":
                    //MessageBox.Show("Alarms");
                    moduleConfigured = new LowisForm();
                    moduleConfigured.Dock = DockStyle.Fill;
                    if (splitContainer1.Panel2.Controls.Count > 0)
                    {
                        splitContainer1.Panel2.Controls.RemoveAt(0);
                    }
                    this.splitContainer1.Panel2.Controls.Clear();
                    moduleConfigured.Bounds = splitContainer1.Panel2.DisplayRectangle;
                    this.splitContainer1.Panel2.Controls.Add(moduleConfigured);
                    this.splitContainer1.Panel2.Update();
                    moduleConfigured.Show();
                    if (Globals.treePilih != "Beam")
                    {
                        lvWellCol("Beam");
                        loaddatalv("Beam");
                        Globals.treePilih = "Beam";
                        ttJenis.Text = "Beam Well";
                    }
                    break;

                case "24HR FOP":
                    //MessageBox.Show("All");
                    module24HRFOP = new LowisForm();
                    module24HRFOP.Dock = DockStyle.Fill;
                    if (splitContainer1.Panel2.Controls.Count > 0)
                    {
                        splitContainer1.Panel2.Controls.RemoveAt(0);
                    }
                    this.splitContainer1.Panel2.Controls.Clear();
                    module24HRFOP.Bounds = splitContainer1.Panel2.DisplayRectangle;
                    this.splitContainer1.Panel2.Controls.Add(module24HRFOP);
                    this.splitContainer1.Panel2.Update();
                    module24HRFOP.Show();
                    if (Globals.treePilih != "Beam")
                    {
                        lvWellCol("Beam");
                        loaddatalv("Beam");
                        Globals.treePilih = "Beam";
                        ttJenis.Text = "Beam Well";
                    }
                    break;
                case "High Cycles > 150":
                    //MessageBox.Show("Alarms");
                    moduleHighCycles150 = new LowisForm();
                    moduleHighCycles150.Dock = DockStyle.Fill;
                    if (splitContainer1.Panel2.Controls.Count > 0)
                    {
                        splitContainer1.Panel2.Controls.RemoveAt(0);
                    }
                    this.splitContainer1.Panel2.Controls.Clear();
                    moduleHighCycles150.Bounds = splitContainer1.Panel2.DisplayRectangle;
                    this.splitContainer1.Panel2.Controls.Add(moduleHighCycles150);
                    this.splitContainer1.Panel2.Update();
                    moduleHighCycles150.Show();
                    if (Globals.treePilih != "Beam")
                    {
                        lvWellCol("Beam");
                        loaddatalv("Beam");
                        Globals.treePilih = "Beam";
                        ttJenis.Text = "Beam Well";
                    }
                    break;
                case "Gearbox OverLoad > 110%":
                    //MessageBox.Show("All");
                    moduleGearboxOverLoad110 = new LowisForm();
                    moduleGearboxOverLoad110.Dock = DockStyle.Fill;
                    if (splitContainer1.Panel2.Controls.Count > 0)
                    {
                        splitContainer1.Panel2.Controls.RemoveAt(0);
                    }
                    this.splitContainer1.Panel2.Controls.Clear();
                    moduleGearboxOverLoad110.Bounds = splitContainer1.Panel2.DisplayRectangle;
                    this.splitContainer1.Panel2.Controls.Add(moduleGearboxOverLoad110);
                    this.splitContainer1.Panel2.Update();
                    moduleGearboxOverLoad110.Show();
                    if (Globals.treePilih != "Beam")
                    {
                        lvWellCol("Beam");
                        loaddatalv("Beam");
                        Globals.treePilih = "Beam";
                        ttJenis.Text = "Beam Well";
                    }
                    break;
                case "Low Runtime":
                    //MessageBox.Show("Alarms");
                    moduleLowRuntime = new LowisForm();
                    moduleLowRuntime.Dock = DockStyle.Fill;
                    if (splitContainer1.Panel2.Controls.Count > 0)
                    {
                        splitContainer1.Panel2.Controls.RemoveAt(0);
                    }
                    this.splitContainer1.Panel2.Controls.Clear();
                    moduleLowRuntime.Bounds = splitContainer1.Panel2.DisplayRectangle;
                    this.splitContainer1.Panel2.Controls.Add(moduleLowRuntime);
                    this.splitContainer1.Panel2.Update();
                    moduleLowRuntime.Show();
                    if (Globals.treePilih != "Beam")
                    {
                        lvWellCol("Beam");
                        loaddatalv("Beam");
                        Globals.treePilih = "Beam";
                        ttJenis.Text = "Beam Well";
                    }
                    break;
                case "Under Displaced":
                    //MessageBox.Show("All");
                    moduleUnderDisplaced = new LowisForm();
                    moduleUnderDisplaced.Dock = DockStyle.Fill;
                    if (splitContainer1.Panel2.Controls.Count > 0)
                    {
                        splitContainer1.Panel2.Controls.RemoveAt(0);
                    }
                    this.splitContainer1.Panel2.Controls.Clear();
                    moduleUnderDisplaced.Bounds = splitContainer1.Panel2.DisplayRectangle;
                    this.splitContainer1.Panel2.Controls.Add(moduleUnderDisplaced);
                    this.splitContainer1.Panel2.Update();
                    moduleUnderDisplaced.Show();
                    if (Globals.treePilih != "Beam")
                    {
                        lvWellCol("Beam");
                        loaddatalv("Beam");
                        Globals.treePilih = "Beam";
                        ttJenis.Text = "Beam Well";
                    }
                    break;
                case "% Optimized":
                    //MessageBox.Show("Alarms");
                    moduleOptimized = new LowisForm();
                    moduleOptimized.Dock = DockStyle.Fill;
                    if (splitContainer1.Panel2.Controls.Count > 0)
                    {
                        splitContainer1.Panel2.Controls.RemoveAt(0);
                    }
                    this.splitContainer1.Panel2.Controls.Clear();
                    moduleOptimized.Bounds = splitContainer1.Panel2.DisplayRectangle;
                    this.splitContainer1.Panel2.Controls.Add(moduleOptimized);
                    this.splitContainer1.Panel2.Update();
                    moduleOptimized.Show();
                    if (Globals.treePilih != "Beam")
                    {
                        lvWellCol("Beam");
                        loaddatalv("Beam");
                        Globals.treePilih = "Beam";
                        ttJenis.Text = "Beam Well";
                    }
                    break;

                case "Overloaded Rods":
                    //MessageBox.Show("Alarms");
                    moduleOverloadedRods = new LowisForm();
                    moduleOverloadedRods.Dock = DockStyle.Fill;
                    if (splitContainer1.Panel2.Controls.Count > 0)
                    {
                        splitContainer1.Panel2.Controls.RemoveAt(0);
                    }
                    this.splitContainer1.Panel2.Controls.Clear();
                    moduleOverloadedRods.Bounds = splitContainer1.Panel2.DisplayRectangle;
                    this.splitContainer1.Panel2.Controls.Add(moduleOverloadedRods);
                    this.splitContainer1.Panel2.Update();
                    moduleOverloadedRods.Show();
                    if (Globals.treePilih != "Beam")
                    {
                        lvWellCol("Beam");
                        loaddatalv("Beam");
                        Globals.treePilih = "Beam";
                        ttJenis.Text = "Beam Well";
                    }
                    break;
                case "Low Pump Efficiency":
                    //MessageBox.Show("Alarms");
                    moduleLowPumpEfficiency = new LowisForm();
                    moduleLowPumpEfficiency.Dock = DockStyle.Fill;
                    if (splitContainer1.Panel2.Controls.Count > 0)
                    {
                        splitContainer1.Panel2.Controls.RemoveAt(0);
                    }
                    this.splitContainer1.Panel2.Controls.Clear();
                    moduleLowPumpEfficiency.Bounds = splitContainer1.Panel2.DisplayRectangle;
                    this.splitContainer1.Panel2.Controls.Add(moduleLowPumpEfficiency);
                    this.splitContainer1.Panel2.Update();
                    moduleLowPumpEfficiency.Show();
                    if (Globals.treePilih != "Beam")
                    {
                        lvWellCol("Beam");
                        loaddatalv("Beam");
                        Globals.treePilih = "Beam";
                        ttJenis.Text = "Beam Well";
                    }
                    break;
                case "More Fluid Available":
                    //MessageBox.Show("Alarms");
                    moduleMoreFluidAvailable = new LowisForm();
                    moduleMoreFluidAvailable.Dock = DockStyle.Fill;
                    if (splitContainer1.Panel2.Controls.Count > 0)
                    {
                        splitContainer1.Panel2.Controls.RemoveAt(0);
                    }
                    this.splitContainer1.Panel2.Controls.Clear();
                    moduleMoreFluidAvailable.Bounds = splitContainer1.Panel2.DisplayRectangle;
                    this.splitContainer1.Panel2.Controls.Add(moduleMoreFluidAvailable);
                    this.splitContainer1.Panel2.Update();
                    moduleMoreFluidAvailable.Show();
                    if (Globals.treePilih != "Beam")
                    {
                        lvWellCol("Beam");
                        loaddatalv("Beam");
                        Globals.treePilih = "Beam";
                        ttJenis.Text = "Beam Well";
                    }
                    break;
                case "Production Decreasing":
                    //MessageBox.Show("Alarms");
                    moduleProductionDecreasing = new LowisForm();
                    moduleProductionDecreasing.Dock = DockStyle.Fill;
                    if (splitContainer1.Panel2.Controls.Count > 0)
                    {
                        splitContainer1.Panel2.Controls.RemoveAt(0);
                    }
                    this.splitContainer1.Panel2.Controls.Clear();
                    moduleProductionDecreasing.Bounds = splitContainer1.Panel2.DisplayRectangle;
                    this.splitContainer1.Panel2.Controls.Add(moduleProductionDecreasing);
                    this.splitContainer1.Panel2.Update();
                    moduleProductionDecreasing.Show();
                    if (Globals.treePilih != "Beam")
                    {
                        lvWellCol("Beam");
                        loaddatalv("Beam");
                        Globals.treePilih = "Beam";
                        ttJenis.Text = "Beam Well";
                    }
                    break;
                case "Questionable POC":
                    //MessageBox.Show("Alarms");
                    moduleQuestionablePOC = new LowisForm();
                    moduleQuestionablePOC.Dock = DockStyle.Fill;
                    if (splitContainer1.Panel2.Controls.Count > 0)
                    {
                        splitContainer1.Panel2.Controls.RemoveAt(0);
                    }
                    this.splitContainer1.Panel2.Controls.Clear();
                    moduleQuestionablePOC.Bounds = splitContainer1.Panel2.DisplayRectangle;
                    this.splitContainer1.Panel2.Controls.Add(moduleQuestionablePOC);
                    this.splitContainer1.Panel2.Update();
                    moduleQuestionablePOC.Show();
                    if (Globals.treePilih != "Beam")
                    {
                        lvWellCol("Beam");
                        loaddatalv("Beam");
                        Globals.treePilih = "Beam";
                        ttJenis.Text = "Beam Well";
                    }
                    break;
                case "Miscalibration of Data":
                    //MessageBox.Show("Alarms");
                    moduleMiscalibrationofData = new LowisForm();
                    moduleMiscalibrationofData.Dock = DockStyle.Fill;
                    if (splitContainer1.Panel2.Controls.Count > 0)
                    {
                        splitContainer1.Panel2.Controls.RemoveAt(0);
                    }
                    this.splitContainer1.Panel2.Controls.Clear();
                    moduleMiscalibrationofData.Bounds = splitContainer1.Panel2.DisplayRectangle;
                    this.splitContainer1.Panel2.Controls.Add(moduleMiscalibrationofData);
                    this.splitContainer1.Panel2.Update();
                    moduleMiscalibrationofData.Show();
                    if (Globals.treePilih != "Beam")
                    {
                        lvWellCol("Beam");
                        loaddatalv("Beam");
                        Globals.treePilih = "Beam";
                        ttJenis.Text = "Beam Well";
                    }
                    break;
                case "Units Under Utilized":
                    //MessageBox.Show("Alarms");
                    moduleUnitsUnderUtilized = new LowisForm();
                    moduleUnitsUnderUtilized.Dock = DockStyle.Fill;
                    if (splitContainer1.Panel2.Controls.Count > 0)
                    {
                        splitContainer1.Panel2.Controls.RemoveAt(0);
                    }
                    this.splitContainer1.Panel2.Controls.Clear();
                    moduleUnitsUnderUtilized.Bounds = splitContainer1.Panel2.DisplayRectangle;
                    this.splitContainer1.Panel2.Controls.Add(moduleUnitsUnderUtilized);
                    this.splitContainer1.Panel2.Update();
                    moduleUnitsUnderUtilized.Show();
                    if (Globals.treePilih != "Beam")
                    {
                        lvWellCol("Beam");
                        loaddatalv("Beam");
                        Globals.treePilih = "Beam";
                        ttJenis.Text = "Beam Well";
                    }
                    break;
                case "Candidates for Unit Upsize":
                    //MessageBox.Show("Alarms");
                    moduleCandidatesforUnitUpsize = new LowisForm();
                    moduleCandidatesforUnitUpsize.Dock = DockStyle.Fill;
                    if (splitContainer1.Panel2.Controls.Count > 0)
                    {
                        splitContainer1.Panel2.Controls.RemoveAt(0);
                    }
                    this.splitContainer1.Panel2.Controls.Clear();
                    moduleCandidatesforUnitUpsize.Bounds = splitContainer1.Panel2.DisplayRectangle;
                    this.splitContainer1.Panel2.Controls.Add(moduleCandidatesforUnitUpsize);
                    this.splitContainer1.Panel2.Update();
                    moduleCandidatesforUnitUpsize.Show();
                    if (Globals.treePilih != "Beam")
                    {
                        lvWellCol("Beam");
                        loaddatalv("Beam");
                        Globals.treePilih = "Beam";
                        ttJenis.Text = "Beam Well";
                    }
                    break;
                case "Savings From Balancing":
                    //MessageBox.Show("Alarms");
                    moduleSavingsFromBalancing = new LowisForm();
                    moduleSavingsFromBalancing.Dock = DockStyle.Fill;
                    if (splitContainer1.Panel2.Controls.Count > 0)
                    {
                        splitContainer1.Panel2.Controls.RemoveAt(0);
                    }
                    this.splitContainer1.Panel2.Controls.Clear();
                    moduleSavingsFromBalancing.Bounds = splitContainer1.Panel2.DisplayRectangle;
                    this.splitContainer1.Panel2.Controls.Add(moduleSavingsFromBalancing);
                    this.splitContainer1.Panel2.Update();
                    moduleSavingsFromBalancing.Show();
                    if (Globals.treePilih != "Beam")
                    {
                        lvWellCol("Beam");
                        loaddatalv("Beam");
                        Globals.treePilih = "Beam";
                        ttJenis.Text = "Beam Well";
                    }
                    break;

                case "Detail LW":
                    //MessageBox.Show("Alarms");
                    moduleDetailLW = new detailLW();
                    moduleDetailLW.Dock = DockStyle.Fill;
                    if (this.splitContainer1.Panel2.Controls.Count > 0)
                    {
                        //int tmpInt = splitContainer1.Panel2.Controls.Count;
                        //for (int i = 0; i < tmpInt; i++)
                        //{
                        //    this.splitContainer1.Panel2.Controls.RemoveAt(0);
                        //}
                        this.splitContainer1.Panel2.Controls.RemoveAt(0);
                    }
                    this.splitContainer1.Panel2.Controls.Clear();
                    moduleDetailLW.Bounds = splitContainer1.Panel2.DisplayRectangle;
                    this.splitContainer1.Panel2.Controls.Add(moduleDetailLW);
                    this.splitContainer1.Panel2.Update();
                    moduleDetailLW.Show();

                    //lvWellCol("Beam");
                    //loaddatalv("Beam");
                    break;

                case "Well Current Status":
                    //MessageBox.Show("Alarms");
                    moduleWellCurrentStatus = new WellCurrentStatus();
                    moduleWellCurrentStatus.Dock = DockStyle.Fill;
                    if (splitContainer1.Panel2.Controls.Count > 0)
                    {
                        splitContainer1.Panel2.Controls.RemoveAt(0);
                    }
                    this.splitContainer1.Panel2.Controls.Clear();
                    moduleWellCurrentStatus.Bounds = splitContainer1.Panel2.DisplayRectangle;
                    this.splitContainer1.Panel2.Controls.Add(moduleWellCurrentStatus);
                    this.splitContainer1.Panel2.Update();
                    moduleWellCurrentStatus.Show();
                    if (Globals.treePilih != "Beam")
                    {
                        lvWellCol("Beam");
                        loaddatalv("Beam");
                        Globals.treePilih = "Beam";
                        ttJenis.Text = "Beam Well";
                    }
                    break;

                // ESP GROUP TREND
                case "All ESP Well":
                    //MessageBox.Show("All");
                    moduleEspGroupAllEspWell = new EspGroup();
                    moduleEspGroupAllEspWell.Dock = DockStyle.Fill;
                    if (splitContainer1.Panel2.Controls.Count > 0)
                    {
                        splitContainer1.Panel2.Controls.RemoveAt(0);
                    }
                    this.splitContainer1.Panel2.Controls.Clear();
                    moduleEspGroupAllEspWell.Bounds = splitContainer1.Panel2.DisplayRectangle;
                    this.splitContainer1.Panel2.Controls.Add(moduleEspGroupAllEspWell);
                    this.splitContainer1.Panel2.Update();
                    moduleEspGroupAllEspWell.Show();
                    if (Globals.treePilih != "Esp")
                    {
                        lvWellCol("Esp");
                        loaddatalv("Esp");
                        Globals.treePilih = "Esp";
                        ttJenis.Text = "ESP Well";
                    }
                    break;
                case "Alarms":
                    //MessageBox.Show("All");
                    moduleEspGroupAlarms = new EspGroup();
                    moduleEspGroupAlarms.Dock = DockStyle.Fill;
                    if (splitContainer1.Panel2.Controls.Count > 0)
                    {
                        splitContainer1.Panel2.Controls.RemoveAt(0);
                    }
                    this.splitContainer1.Panel2.Controls.Clear();
                    moduleEspGroupAlarms.Bounds = splitContainer1.Panel2.DisplayRectangle;
                    this.splitContainer1.Panel2.Controls.Add(moduleEspGroupAlarms);
                    this.splitContainer1.Panel2.Update();
                    moduleEspGroupAlarms.Show();
                    if (Globals.treePilih != "Esp")
                    {
                        lvWellCol("Esp");
                        loaddatalv("Esp");
                        Globals.treePilih = "Esp";
                        ttJenis.Text = "ESP Well";
                    }
                    break;
                case "Alarms at G.O":
                    //MessageBox.Show("All");
                    moduleEspGroupAlarmsatGO = new EspGroup();
                    moduleEspGroupAlarmsatGO.Dock = DockStyle.Fill;
                    if (splitContainer1.Panel2.Controls.Count > 0)
                    {
                        splitContainer1.Panel2.Controls.RemoveAt(0);
                    }
                    this.splitContainer1.Panel2.Controls.Clear();
                    moduleEspGroupAlarmsatGO.Bounds = splitContainer1.Panel2.DisplayRectangle;
                    this.splitContainer1.Panel2.Controls.Add(moduleEspGroupAlarmsatGO);
                    this.splitContainer1.Panel2.Update();
                    moduleEspGroupAlarmsatGO.Show();
                    if (Globals.treePilih != "Esp")
                    {
                        lvWellCol("Esp");
                        loaddatalv("Esp");
                        Globals.treePilih = "Esp";
                        ttJenis.Text = "ESP Well";
                    }
                    break;
                case "Running":
                    //MessageBox.Show("All");
                    moduleEspGroupRunning = new EspGroup();
                    moduleEspGroupRunning.Dock = DockStyle.Fill;
                    if (splitContainer1.Panel2.Controls.Count > 0)
                    {
                        splitContainer1.Panel2.Controls.RemoveAt(0);
                    }
                    this.splitContainer1.Panel2.Controls.Clear();
                    moduleEspGroupRunning.Bounds = splitContainer1.Panel2.DisplayRectangle;
                    this.splitContainer1.Panel2.Controls.Add(moduleEspGroupRunning);
                    this.splitContainer1.Panel2.Update();
                    moduleEspGroupRunning.Show();
                    if (Globals.treePilih != "Esp")
                    {
                        lvWellCol("Esp");
                        loaddatalv("Esp");
                        Globals.treePilih = "Esp";
                        ttJenis.Text = "ESP Well";
                    }
                    break;
                case "In Service Well Type":
                    //MessageBox.Show("All");
                    moduleEspGroupInServiceWellType = new EspGroup();
                    moduleEspGroupInServiceWellType.Dock = DockStyle.Fill;
                    if (splitContainer1.Panel2.Controls.Count > 0)
                    {
                        splitContainer1.Panel2.Controls.RemoveAt(0);
                    }
                    this.splitContainer1.Panel2.Controls.Clear();
                    moduleEspGroupInServiceWellType.Bounds = splitContainer1.Panel2.DisplayRectangle;
                    this.splitContainer1.Panel2.Controls.Add(moduleEspGroupInServiceWellType);
                    this.splitContainer1.Panel2.Update();
                    moduleEspGroupInServiceWellType.Show();
                    if (Globals.treePilih != "Esp")
                    {
                        lvWellCol("Esp");
                        loaddatalv("Esp");
                        Globals.treePilih = "Esp";
                        ttJenis.Text = "ESP Well";
                    }
                    break;
                case "Out of Service":
                    //MessageBox.Show("All");
                    moduleEspGroupOutofService = new EspGroup();
                    moduleEspGroupOutofService.Dock = DockStyle.Fill;
                    if (splitContainer1.Panel2.Controls.Count > 0)
                    {
                        splitContainer1.Panel2.Controls.RemoveAt(0);
                    }
                    this.splitContainer1.Panel2.Controls.Clear();
                    moduleEspGroupOutofService.Bounds = splitContainer1.Panel2.DisplayRectangle;
                    this.splitContainer1.Panel2.Controls.Add(moduleEspGroupOutofService);
                    this.splitContainer1.Panel2.Update();
                    moduleEspGroupOutofService.Show();
                    if (Globals.treePilih != "Esp")
                    {
                        lvWellCol("Esp");
                        loaddatalv("Esp");
                        Globals.treePilih = "Esp";
                        ttJenis.Text = "ESP Well";
                    }
                    break;
                case "Down":
                    //MessageBox.Show("All");
                    moduleEspGroupDown = new EspGroup();
                    moduleEspGroupDown.Dock = DockStyle.Fill;
                    if (splitContainer1.Panel2.Controls.Count > 0)
                    {
                        splitContainer1.Panel2.Controls.RemoveAt(0);
                    }
                    this.splitContainer1.Panel2.Controls.Clear();
                    moduleEspGroupDown.Bounds = splitContainer1.Panel2.DisplayRectangle;
                    this.splitContainer1.Panel2.Controls.Add(moduleEspGroupDown);
                    this.splitContainer1.Panel2.Update();
                    moduleEspGroupDown.Show();
                    if (Globals.treePilih != "Esp")
                    {
                        lvWellCol("Esp");
                        loaddatalv("Esp");
                        Globals.treePilih = "Esp";
                        ttJenis.Text = "ESP Well";
                    }
                    break;
                case "Comm Fail":
                    //MessageBox.Show("All");
                    moduleEspGroupCommFail = new EspGroup();
                    moduleEspGroupCommFail.Dock = DockStyle.Fill;
                    if (splitContainer1.Panel2.Controls.Count > 0)
                    {
                        splitContainer1.Panel2.Controls.RemoveAt(0);
                    }
                    this.splitContainer1.Panel2.Controls.Clear();
                    moduleEspGroupCommFail.Bounds = splitContainer1.Panel2.DisplayRectangle;
                    this.splitContainer1.Panel2.Controls.Add(moduleEspGroupCommFail);
                    this.splitContainer1.Panel2.Update();
                    moduleEspGroupCommFail.Show();
                    if (Globals.treePilih != "Esp")
                    {
                        lvWellCol("Esp");
                        loaddatalv("Esp");
                        Globals.treePilih = "Esp";
                        ttJenis.Text = "ESP Well";
                    }
                    break;
                case "Comm Ok":
                    //MessageBox.Show("All");
                    moduleEspGroupCommOk = new EspGroup();
                    moduleEspGroupCommOk.Dock = DockStyle.Fill;
                    if (splitContainer1.Panel2.Controls.Count > 0)
                    {
                        splitContainer1.Panel2.Controls.RemoveAt(0);
                    }
                    this.splitContainer1.Panel2.Controls.Clear();
                    moduleEspGroupCommOk.Bounds = splitContainer1.Panel2.DisplayRectangle;
                    this.splitContainer1.Panel2.Controls.Add(moduleEspGroupCommOk);
                    this.splitContainer1.Panel2.Update();
                    moduleEspGroupCommOk.Show();
                    if (Globals.treePilih != "Esp")
                    {
                        lvWellCol("Esp");
                        loaddatalv("Esp");
                        Globals.treePilih = "Esp";
                        ttJenis.Text = "ESP Well";
                    }
                    break;
                case "rw":
                    modulerw = new rw();
                    modulerw.Dock = DockStyle.Fill;
                    if (splitContainer1.Panel2.Controls.Count > 0)
                    {
                        splitContainer1.Panel2.Controls.RemoveAt(0);
                    }
                    this.splitContainer1.Panel2.Controls.Clear();
                    modulerw.Bounds = splitContainer1.Panel2.DisplayRectangle;
                    this.splitContainer1.Panel2.Controls.Add(modulerw);
                    this.splitContainer1.Panel2.Update();
                    modulerw.Show();
                    if (Globals.treePilih != "Discrete")
                    {
                        lvWellCol("Discrete");
                        loaddatalv("Discrete");
                        Globals.treePilih = "Discrete";
                    }
                    break;
                case "rw2":
                    modulerw2 = new rw2();
                    modulerw2.Dock = DockStyle.Fill;
                    if (splitContainer1.Panel2.Controls.Count > 0)
                    {
                        splitContainer1.Panel2.Controls.RemoveAt(0);
                    }
                    this.splitContainer1.Panel2.Controls.Clear();
                    modulerw2.Bounds = splitContainer1.Panel2.DisplayRectangle;
                    this.splitContainer1.Panel2.Controls.Add(modulerw2);
                    this.splitContainer1.Panel2.Update();
                    modulerw2.Show();
                    if (Globals.treePilih != "Discrete")
                    {
                        lvWellCol("Discrete");
                        loaddatalv("Discrete");
                        Globals.treePilih = "Discrete";
                    }
                    break;
                case "bmgs":
                    modulePEDashboard = new LowisForm();
                    modulePEDashboard.Dock = DockStyle.Fill;
                   
                    if (splitContainer1.Panel2.Controls.Count > 0)
                    {
                        splitContainer1.Panel2.Controls.RemoveAt(0);
                    }
                    this.splitContainer1.Panel2.Controls.Clear();
                    modulePEDashboard.Bounds = splitContainer1.Panel2.DisplayRectangle;
                    this.splitContainer1.Panel2.Controls.Add(modulePEDashboard);
                    this.splitContainer1.Panel2.Update();
                   // Globals.parameterid = "";
                    //Globals.idsp = 0;
                    modulePEDashboard.Show();
                    if (Globals.treePilih != "Beam")
                    {
                        lvWellCol("Beam");
                        loaddatalv("Beam");
                        Globals.treePilih = "Beam";
                        ttJenis.Text = "Beam Well";
                    }
                    break;
            }
           
        }
        private void PopulateTreeView(int parentId, TreeNode parentNode)
        {
            dbCon.clearCache();
            Dictionary<string, object> paras = new Dictionary<string, object>();
            paras.Add("@param", "1");
            paras.Add("@parentid", parentId); 
            DataSet ds = dbCon.execprosedure("dbo.[spgettreeview]", paras);

            TreeNode childNode;
            
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                TreeNode t = new TreeNode();
                t.ImageIndex = 1;
                t.SelectedImageIndex = 2;
                t.Text =  dr["description"].ToString();
                t.Name = dr["treeviewmenuid"].ToString();
                t.Tag = dr["treeviewmenuid"].ToString(); //_acountsTb.Rows.IndexOf(dr);
                if (parentNode == null)
                {
                    tvMenu.Nodes.Add(t);
                    childNode = t;
                }
                else
                {
                    parentNode.Nodes.Add(t);
                    childNode = t;
                }
                PopulateTreeView(Convert.ToInt32(dr["treeviewmenuid"].ToString()), childNode);
            }
        }
        private void TreeNodeLoad()
        {
            tvMenu.ImageList = imageList1;
            tvwellnameScandate.ImageList = imageList1;
            PopulateTreeView(0,null);
            tvMenu.CheckBoxes = false;
            tvMenu.Nodes[0].ExpandAll();
        }
            private void TreeNodeLoadOLD()
        {
            object tag_object;
            TreeNode treeNode = new TreeNode();
            treeNode.Text = "RRL Well Condition";
            tag_object = new FactoryData("RRL Well Condition");
            treeNode.Tag = tag_object;
            // Add a main root treenode.
            tvMenu.Nodes.Add(treeNode);

            //treeNode = new TreeNode();
            //treeNode.Text = "ESP Well Condition";
            // Add a main root treenode.
           // tvMenu.Nodes.Add(treeNode);

            tvMenu.ImageList = imageList1;
            tvwellnameScandate.ImageList = imageList1;
            //tvAlarm.ImageList = imageList1;

            TreeNode node1 = new TreeNode("Dashboard");
            node1.ImageIndex = 1;
            node1.SelectedImageIndex = 2;
            tag_object = new PersonData("1");
            node1.Tag = tag_object;
            TreeNode node2 = new TreeNode("Well Group Status");
            node2.ImageIndex = 1;
            node2.SelectedImageIndex = 2;
            tag_object = new PersonData("1");
            node2.Tag = tag_object;
            TreeNode node3 = new TreeNode("Out Of Service");
            node3.ImageIndex = 1;
            node3.SelectedImageIndex = 2;
            TreeNode node4 = new TreeNode("In Service");
            node4.ImageIndex = 1;
            node4.SelectedImageIndex = 2;
            TreeNode node5 = new TreeNode("Stop");
            node5.ImageIndex = 1;
            node5.SelectedImageIndex = 2;
            TreeNode node6 = new TreeNode("Run Time Less than 14H/D");
            node6.ImageIndex = 1;
            node6.SelectedImageIndex = 2;
            TreeNode node6a = new TreeNode("24 Hours/Day Wells");
            node6.ImageIndex = 1;
            node6.SelectedImageIndex = 2;
            TreeNode node6b = new TreeNode("Pump Effeciency Low");
            node6.ImageIndex = 1;
            node6.SelectedImageIndex = 2;


            TreeNode[] array = new TreeNode[] { node1, node2, node3, node4, node5, node6, node6a, node6b };

            treeNode = new TreeNode("Main Menu", array);
            tag_object = new GroupData("1");
            treeNode.Tag = tag_object;
            TreeNode[] arrayx = new TreeNode[] { treeNode };
            //treeNode.SelectedImageIndex = 1;
            //tvMenu.Nodes.Add(treeNode);
            tvMenu.Nodes[0].Nodes.Add(treeNode);

            TreeNode node7 = new TreeNode("Out of Spec High Peak");
            node7.ImageIndex = 1;
            node7.SelectedImageIndex = 2;
            TreeNode node8 = new TreeNode("Parameter Mismatch");
            node8.ImageIndex = 1;
            node8.SelectedImageIndex = 2;
            TreeNode node9 = new TreeNode("Unconfigured Alarms");
            node9.ImageIndex = 1;
            node9.SelectedImageIndex = 2;
            TreeNode node10 = new TreeNode("Unconfigured Cranks");
            node10.ImageIndex = 1;
            node10.SelectedImageIndex = 2;
            TreeNode node11 = new TreeNode("Invalid Pump Eff./ SPM");
            node11.ImageIndex = 1;
            node11.SelectedImageIndex = 2;
            TreeNode node12 = new TreeNode("Old Cards");
            node12.ImageIndex = 1;
            node12.SelectedImageIndex = 2;
            TreeNode node13 = new TreeNode("% Configured");
            node13.ImageIndex = 1;
            node13.SelectedImageIndex = 2;
            TreeNode[] array2 = new TreeNode[] { node7, node8, node9, node10, node11, node12, node13 };
            treeNode = new TreeNode("Configure", array2);
            tag_object = new GroupData("1");
            treeNode.Tag = tag_object;
            //tvMenu.Nodes.Add(treeNode);
            tvMenu.Nodes[0].Nodes.Add(treeNode);

            TreeNode node14 = new TreeNode("FOP Good(24 hrs FOP)");
            node14.ImageIndex = 1;
            node14.SelectedImageIndex = 2;
            TreeNode node14a = new TreeNode("FOP Bad(24 hrs FOP & High Pump Slppage)");
            node14.ImageIndex = 1;
            node14.SelectedImageIndex = 2;
            TreeNode node14b = new TreeNode("Marginallgy Pump Off");
            node14.ImageIndex = 1;
            node14.SelectedImageIndex = 2;
            TreeNode node15 = new TreeNode("High Pump Cycle > 150 Cycles");
            node15.ImageIndex = 1;
            node15.SelectedImageIndex = 2;
            TreeNode node16 = new TreeNode("Gearbox OverLoad > 110%");
            node16.ImageIndex = 1;
            node16.SelectedImageIndex = 2;
            TreeNode node17 = new TreeNode("Low Runtime < 5 hrs");
            node17.ImageIndex = 1;
            node17.SelectedImageIndex = 2;
            TreeNode node18 = new TreeNode("Under Displaced");
            node18.ImageIndex = 1;
            node18.SelectedImageIndex = 2;
            TreeNode node18a = new TreeNode("Over Displaced");
            node18.ImageIndex = 1;
            node18.SelectedImageIndex = 2;
            TreeNode node19 = new TreeNode("% Optimized");
            node19.ImageIndex = 1;
            node19.SelectedImageIndex = 2;
            TreeNode[] array3 = new TreeNode[] { node14, node14a, node14b, node15, node16, node17, node18, node18a, node19 };
            treeNode = new TreeNode("Optimize", array3);
            tag_object = new GroupData("1");
            treeNode.Tag = tag_object;
            //tvMenu.Nodes.Add(treeNode);
            tvMenu.Nodes[0].Nodes.Add(treeNode);

            TreeNode node20 = new TreeNode("Overloaded Rods");
            node20.ImageIndex = 1;
            node20.SelectedImageIndex = 2;
            TreeNode node21 = new TreeNode("Low Pump Efficiency");
            node21.ImageIndex = 1;
            node21.SelectedImageIndex = 2;
            TreeNode node22 = new TreeNode("More Fluid Available");
            node22.ImageIndex = 1;
            node22.SelectedImageIndex = 2;
            TreeNode node23 = new TreeNode("Production Decreasing");
            node23.ImageIndex = 1;
            node23.SelectedImageIndex = 2;
            //TreeNode node24 = new TreeNode("Questionable POC");
            //node24.ImageIndex = 1;
            //node24.SelectedImageIndex = 2;
            //TreeNode node25 = new TreeNode("Miscalibration of Data");
            //node25.ImageIndex = 1;
            //node25.SelectedImageIndex = 2;
            //TreeNode node26 = new TreeNode("Units Under Utilized");
            //node26.ImageIndex = 1;
            //node26.SelectedImageIndex = 2;
            TreeNode node27 = new TreeNode("Candidates for Unit Upsize");
            node27.ImageIndex = 1;
            node27.SelectedImageIndex = 2;
            TreeNode node28 = new TreeNode("Savings From Balancing");
            node28.ImageIndex = 1;
            node28.SelectedImageIndex = 2;
            TreeNode[] array4 = new TreeNode[] { node20, node21, node22, node23,   node27, node28 };
            treeNode = new TreeNode("Analysis Perfomance", array4);
            tag_object = new GroupData("1");
            treeNode.Tag = tag_object;
            //tvMenu.Nodes.Add(treeNode);
            tvMenu.Nodes[0].Nodes.Add(treeNode);

            //tvMenu.Nodes.

            tvMenu.CheckBoxes = false;
            tvMenu.Nodes[0].ExpandAll();
        }
            private void TreeNodeLoad5() {
            TreeNode treeNode = new TreeNode();
            treeNode.Text = "RRL Well Condition";
            // Add a main root treenode.
            tvMenu.Nodes.Add(treeNode);

            treeNode = new TreeNode();
            treeNode.Text = "ESP Well Condition";
            // Add a main root treenode.
            tvMenu.Nodes.Add(treeNode);

            tvMenu.ImageList = imageList1;
            tvwellnameScandate.ImageList = imageList1;
            //tvAlarm.ImageList = imageList1;
            
            TreeNode node1 = new TreeNode("PE Dashboard");
            node1.ImageIndex = 1;
            node1.SelectedImageIndex = 2;
            TreeNode node2 = new TreeNode("Well Group Status");
            node2.ImageIndex = 1;
            node2.SelectedImageIndex = 2;
            TreeNode node3 = new TreeNode("Well Analysis");
            node3.ImageIndex = 1;
            node3.SelectedImageIndex = 2;
            TreeNode node4 = new TreeNode("Configuration");
            node4.ImageIndex = 1;
            node4.SelectedImageIndex = 2;
            TreeNode node5 = new TreeNode("Welltest");
            node5.ImageIndex = 1;
            node5.SelectedImageIndex = 2;
            TreeNode node6 = new TreeNode("Well Failure");
            node6.ImageIndex = 1;
            node6.SelectedImageIndex = 2;


            TreeNode[] array = new TreeNode[] { node1, node2, node3, node4, node5, node6 };

            treeNode = new TreeNode("Main Menu", array);

            TreeNode[] arrayx = new TreeNode[] { treeNode };
            //treeNode.SelectedImageIndex = 1;
            //tvMenu.Nodes.Add(treeNode);
            tvMenu.Nodes[0].Nodes.Add(treeNode);

            TreeNode node7 = new TreeNode("Out of Spec High Peak");
            node7.ImageIndex = 1;
            node7.SelectedImageIndex = 2;
            TreeNode node8 = new TreeNode("Parameter Mismatch");
            node8.ImageIndex = 1;
            node8.SelectedImageIndex = 2;
            TreeNode node9 = new TreeNode("Unconfigured Alarms");
            node9.ImageIndex = 1;
            node9.SelectedImageIndex = 2;
            TreeNode node10 = new TreeNode("Unconfigured Cranks");
            node10.ImageIndex = 1;
            node10.SelectedImageIndex = 2;
            TreeNode node11 = new TreeNode("Invalid Pump Eff./ SPM");
            node11.ImageIndex = 1;
            node11.SelectedImageIndex = 2;
            TreeNode node12 = new TreeNode("Old Cards");
            node12.ImageIndex = 1;
            node12.SelectedImageIndex = 2;
            TreeNode node13 = new TreeNode("% Configured");
            node13.ImageIndex = 1;
            node13.SelectedImageIndex = 2;
            TreeNode[] array2 = new TreeNode[] { node7, node8, node9, node10, node11, node12, node13 };
            treeNode = new TreeNode("Configure", array2);
            //tvMenu.Nodes.Add(treeNode);
            tvMenu.Nodes[0].Nodes.Add(treeNode);

            TreeNode node14 = new TreeNode("24HR FOP");
            node14.ImageIndex = 1;
            node14.SelectedImageIndex = 2;
            TreeNode node15 = new TreeNode("High Cycles > 150");
            node15.ImageIndex = 1;
            node15.SelectedImageIndex = 2;
            TreeNode node16 = new TreeNode("Gearbox OverLoad > 110%");
            node16.ImageIndex = 1;
            node16.SelectedImageIndex = 2;
            TreeNode node17 = new TreeNode("Low Runtime < 5");
            node17.ImageIndex = 1;
            node17.SelectedImageIndex = 2;
            TreeNode node18 = new TreeNode("Under Displaced");
            node18.ImageIndex = 1;
            node18.SelectedImageIndex = 2;
            TreeNode node19 = new TreeNode("% Optimized");
            node19.ImageIndex = 1;
            node19.SelectedImageIndex = 2;
            TreeNode[] array3 = new TreeNode[] { node14, node15, node16, node17, node18, node19 };
            treeNode = new TreeNode("Optimize", array3);
            //tvMenu.Nodes.Add(treeNode);
            tvMenu.Nodes[0].Nodes.Add(treeNode);

            TreeNode node20 = new TreeNode("Overloaded Rods");
            node20.ImageIndex = 1;
            node20.SelectedImageIndex = 2;
            TreeNode node21 = new TreeNode("Low Pump Efficiency");
            node21.ImageIndex = 1;
            node21.SelectedImageIndex = 2;
            TreeNode node22 = new TreeNode("More Fluid Available");
            node22.ImageIndex = 1;
            node22.SelectedImageIndex = 2;
            TreeNode node23 = new TreeNode("Production Decreasing");
            node23.ImageIndex = 1;
            node23.SelectedImageIndex = 2;
            TreeNode node24 = new TreeNode("Questionable POC");
            node24.ImageIndex = 1;
            node24.SelectedImageIndex = 2;
            TreeNode node25 = new TreeNode("Miscalibration of Data");
            node25.ImageIndex = 1;
            node25.SelectedImageIndex = 2;
            TreeNode node26 = new TreeNode("Units Under Utilized");
            node26.ImageIndex = 1;
            node26.SelectedImageIndex = 2;
            TreeNode node27 = new TreeNode("Candidates for Unit Upsize");
            node27.ImageIndex = 1;
            node27.SelectedImageIndex = 2;
            TreeNode node28 = new TreeNode("Savings From Balancing");
            node28.ImageIndex = 1;
            node28.SelectedImageIndex = 2;
            TreeNode[] array4 = new TreeNode[] { node20, node21, node22, node23, node24, node25, node26, node27, node28 };
            treeNode = new TreeNode("Analysis Perfomance", array4);
            //tvMenu.Nodes.Add(treeNode);
            tvMenu.Nodes[0].Nodes.Add(treeNode);

            //tvMenu.Nodes.

            tvMenu.CheckBoxes = false;
            tvMenu.Nodes[0].ExpandAll();
            //tvMenu.Nodes[1].ExpandAll();
            //tvMenu.Nodes[2].ExpandAll();

            //TreeNode node29 = new TreeNode("Well Name");
            //node29.ImageIndex = 1;
            //node29.SelectedImageIndex = 2;
            //tvAlarm.Nodes.Add(node29);

            //TreeNode node30 = new TreeNode("Scan Date");
            //node30.ImageIndex = 1;
            //node30.SelectedImageIndex = 2;
            //tvAlarm.Nodes.Add(node30);

            //TreeNode node31 = new TreeNode("Alarm");
            //node31.ImageIndex = 1;
            //node31.SelectedImageIndex = 2;
            //tvAlarm.Nodes.Add(node31);

            TreeNode node29 = new TreeNode("All ESP Well");
            node29.ImageIndex = 1;
            node29.SelectedImageIndex = 2;
            TreeNode node30 = new TreeNode("Alarms");
            node30.ImageIndex = 1;
            node30.SelectedImageIndex = 2;
            TreeNode node31 = new TreeNode("Alarms at G.O");
            node31.ImageIndex = 1;
            node31.SelectedImageIndex = 2;
            TreeNode node32 = new TreeNode("Running");
            node32.ImageIndex = 1;
            node32.SelectedImageIndex = 2;
            TreeNode node33 = new TreeNode("In Service Well Type");
            node33.ImageIndex = 1;
            node33.SelectedImageIndex = 2;
            TreeNode node34 = new TreeNode("Out of Service");
            node34.ImageIndex = 1;
            node34.SelectedImageIndex = 2;
            TreeNode node35 = new TreeNode("Down");
            node35.ImageIndex = 1;
            node35.SelectedImageIndex = 2;
            TreeNode node36 = new TreeNode("Comm Fail");
            node36.ImageIndex = 1;
            node36.SelectedImageIndex = 2;
            TreeNode node37 = new TreeNode("Comm Ok");
            node37.ImageIndex = 1;
            node37.SelectedImageIndex = 2;


            TreeNode[] array5 = new TreeNode[] { node29, node30, node31, node32, node33, node34, node35, node36, node37 };

           

           // treeNode = new TreeNode("ESP Well Conditions", array5);
            tvMenu.Nodes[1].Nodes.Add(node29);
            tvMenu.Nodes[1].Nodes.Add(node30);
            tvMenu.Nodes[1].Nodes.Add(node31);
            tvMenu.Nodes[1].Nodes.Add(node32);
            tvMenu.Nodes[1].Nodes.Add(node33);
            tvMenu.Nodes[1].Nodes.Add(node34);
            tvMenu.Nodes[1].Nodes.Add(node35);
            tvMenu.Nodes[1].Nodes.Add(node36);
            tvMenu.Nodes[1].Nodes.Add(node37);
            //treeNode.SelectedImageIndex = 1;
            //tvAlarm.Nodes.Add(treeNode);
            //tvAlarm.CheckBoxes = false;
            //tvAlarm.Nodes[0].ExpandAll();
            //tvMenu.Nodes[3].ExpandAll();
        }
        private void frmMain_Load(object sender, EventArgs e)
        {
            TreeNodeLoad();
            //splitContainer3.Panel2.Hide();
            //splitContainer3.Panel2Collapsed = true;
            //splitContainer3.Panel2.Height = 20;
            ttJenis.Text = "";
            favDialog = new frmFav();
        }

        public void higlightlistview(string type) {
            int index;
            ListViewItem item1;
            lvWell.SelectedItems.Clear();
            switch (type)
            {
                case "Beam":
                    if (lvWell.Items.Count > 0)
                    {
                        item1 = lvWell.FindItemWithText(Globals.ForeignKey);
                        if (item1!=null)
                        {
                            index = item1.Index;
                            lvWell.Items[index].Selected = true;
                            lvWell.Select();
                        }
                    }
                    break;
                case "Esp":
                    if (lvWell.Items.Count > 0)
                    {
                        item1 = lvWell.FindItemWithText(Globals.ForeignKey);
                        if (item1!=null)
                        {
                            index = item1.Index;
                            lvWell.Items[index].Selected = true;
                            lvWell.Select();
                        }
                    }
                    break;
            }
        }


        private void lvWellCol(string type) {
            lvWell.View = View.Details;
            lvWell.GridLines = true;
            lvWell.FullRowSelect = true;

            switch (type) {
                case "Beam":
                    lvWell.Columns.Add("Well Name", 100);
                    lvWell.Columns.Add("Scan Time", 85);
                    lvWell.Columns.Add("Alarm", 80);
                    break;
                case "Esp":
                    lvWell.Columns.Add("Well Name", 100);
                    lvWell.Columns.Add("Well Type", 85);
                    lvWell.Columns.Add("Latest Test Date", 80);
                    break;
                case "Discrete":
                    lvWell.Columns.Add("Facility Well Name", 100);
                    lvWell.Columns.Add("Discrete Point Description", 85);
                    lvWell.Columns.Add("Current State", 80);
                    break;
            }
            //Add column header
           

        }

        private void tvMenu_Click(object sender, EventArgs e)
        {
            string tmp = e.ToString().Trim();
       
        }

        private void tvMenu_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            string tmp = e.Node.Text;
            Globals.formPilih = tmp;
            if (e.Button == MouseButtons.Left)
            {
                if(tmp == "Well Group Status")
                {
                    Globals.parameterid = "0";
                    Globals.idsp = 0;
                }
                else if (tmp == "Out Of Service")
                {
                    Globals.parameterid = "1";
                    Globals.idsp = 1;
                }
                else if (tmp == "In Service")
                {
                    Globals.parameterid = "2";
                    Globals.idsp = 2;
                }
                else if (tmp == "Stop")
                {
                    Globals.parameterid = "3";
                    Globals.idsp = 3;
                }
                else if (tmp == "Run Time Less than 14H/D")
                {
                    Globals.parameterid = "4";
                    Globals.idsp = 4;
                }
                else if (tmp == "24 Hours/Day Wells")
                {
                    Globals.parameterid = "5";
                    Globals.idsp = 5;
                }
                else if (tmp == "FOP Good(24 hrs FOP)")
                {
                    Globals.parameterid = "14";
                    Globals.idsp = 14;
                }
                else if (tmp == "FOP Bad(24 hrs FOP & High Pump Slppage)")
                {
                    Globals.parameterid = "15";
                    Globals.idsp = 15;
                }
                else if (tmp == "High Pump Cycle > 150 Cycles")
                {
                    Globals.parameterid = "17";
                    Globals.idsp = 17;
                }
                else if (tmp == "Low Runtime < 5 hrs")
                {
                    Globals.parameterid = "19";
                    Globals.idsp = 19;
                }




                ShowModule("bmgs");
            }
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnsurv_Click(object sender, EventArgs e)
        {
            if (Globals.ForeignKey == "")
            {
                MessageBox.Show("Please select item first for check item data detail", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            ShowModule("Detail LW");
        }

        private void tvMenu_MouseUp(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Right)
            {
                Point p = new Point(e.X, e.Y);
                TreeNode node = tvMenu.GetNodeAt(p);
                if (node != null)
                {
                    m_OldSelectNode = tvMenu.SelectedNode;
                    tvMenu.SelectedNode = node;

                    switch (Convert.ToString(node.Text))
                    {
                        case "Well Group Status":
                            contextMenuStrip1.Show(tvMenu, p);
                            break;
                        case "PE Dashboard":
                            contextMenuStrip1.Show(tvMenu, p);
                            break;
                        case "Well Analysis":
                            contextMenuStrip1.Show(tvMenu, p);
                            break;
                        case "Configuration":
                            contextMenuStrip1.Show(tvMenu, p);
                            break;
                        case "Welltest":
                            contextMenuStrip1.Show(tvMenu, p);
                            break;
                        case "Well Failure":
                            contextMenuStrip1.Show(tvMenu, p);
                            break;

                        case "Out of Spec High Peak":
                            contextMenuStrip1.Show(tvMenu, p);
                            break;
                        case "Parameter Mismatch":
                            contextMenuStrip1.Show(tvMenu, p);
                            break;
                        case "Unconfigured Alarms":
                            contextMenuStrip1.Show(tvMenu, p);
                            break;
                        case "Unconfigured Cranks":
                            contextMenuStrip1.Show(tvMenu, p);
                            break;
                        case "Invalid Pump Eff./ SPM":
                            contextMenuStrip1.Show(tvMenu, p);
                            break;
                        case "Old Cards":
                            contextMenuStrip1.Show(tvMenu, p);
                            break;
                        case "% Configured":
                            contextMenuStrip1.Show(tvMenu, p);
                            break;

                        case "24HR FOP":
                            contextMenuStrip1.Show(tvMenu, p);
                            break;
                        case "High Cycles > 150":
                            contextMenuStrip1.Show(tvMenu, p);
                            break;
                        case "Gearbox OverLoad > 110%":
                            contextMenuStrip1.Show(tvMenu, p);
                            break;
                        case "Low Runtime < 5":
                            contextMenuStrip1.Show(tvMenu, p);
                            break;
                        case "Under Displaced":
                            contextMenuStrip1.Show(tvMenu, p);
                            break;
                        case "% Optimized":
                            contextMenuStrip1.Show(tvMenu, p);
                            break;

                        case "Overloaded Rods":
                            contextMenuStrip1.Show(tvMenu, p);
                            break;
                        case "Low Pump Efficiency":
                            contextMenuStrip1.Show(tvMenu, p);
                            break;
                        case "More Fluid Available":
                            contextMenuStrip1.Show(tvMenu, p);
                            break;
                        case "Production Decreasing":
                            contextMenuStrip1.Show(tvMenu, p);
                            break;
                        case "Questionable POC":
                            contextMenuStrip1.Show(tvMenu, p);
                            break;
                        case "Miscalibration of Data":
                            contextMenuStrip1.Show(tvMenu, p);
                            break;
                        case "Units Under Utilized":
                            contextMenuStrip1.Show(tvMenu, p);
                            break;
                        case "Candidates for Unit Upsize":
                            contextMenuStrip1.Show(tvMenu, p);
                            break;
                        case "Savings From Balancing":
                            contextMenuStrip1.Show(tvMenu, p);
                            break;

                    }

                }
            }
        }

        private void beamValveCheckWorkBenchToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void buildUpToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void configurationToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void statusToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void productionsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void reportToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btnconfig_Click(object sender, EventArgs e)
        {
            //if (Globals.ForeignKey == "")
            //{
            //    MessageBox.Show("Please select item first for check item data detail", "Error",
            //        MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}
            //ShowModule("Detail LW");

            ShowModule("Test Temp");
        }

        public void btnanalysis_Click(object sender, EventArgs e)
        {
            if (Globals.ForeignKey == "")
            {
                MessageBox.Show("Please select item first for check item data detail", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (ButtonFirstFormClicked != null)
                ButtonFirstFormClicked(sender, e);
            ShowModule("Detail LW");
        }

        private void btnworkplan_Click(object sender, EventArgs e)
        {
            if (Globals.ForeignKey == "")
            {
                MessageBox.Show("Please select item first for check item data detail", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            ShowModule("Detail LW");
        }

        private void btnservice_Click(object sender, EventArgs e)
        {
            if (Globals.ForeignKey == "")
            {
                MessageBox.Show("Please select item first for check item data detail", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            ShowModule("Detail LW");
        }

        private void btnscorecard_Click(object sender, EventArgs e)
        {
            if (Globals.ForeignKey == "")
            {
                MessageBox.Show("Please select item first for check item data detail", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            ShowModule("Detail LW");
        }

        private void beamAnalysisHistoryToolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void wellCurrentStatusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Globals.formPilih = "wcs";
            ShowModule("Beam Well Current Status Detail");
             //ShowModule("Well Current Status");
            //switch (Globals.treePilih) {
            //    case "Beam":
            //        ShowModule("Beam Well Current Status");
            //        break;
            //    case "Esp":
            //        ShowModule("ESP Well Current Status");
            //        break;
            //}
            
           
        }

        private void purgeStoreToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            ShowModule("Group Descrete Config");
        }

        private void manageViewsToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            ShowModule("Group Analog Config");
        }

        private void beamValveCheckWorkbenchToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            ShowModule("Beam Well Group Configuration");
        }

        private void beamAnalysisHistoryToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ShowModule("Alarm History"); 
        }

        private void loaddatalv(string type) {
            Dictionary<string, object> paras = new Dictionary<string, object>();
            DataSet ds;
            DataRow dr;
            ListViewItem listitem;
            switch (type) {
                case "Beam":
                    paras.Add("@param", "");
                    ds = dbCon.execprosedure("dbo.[prosedur_getdataWellGroupStatus]", paras);
                    if (ds.Tables.Count > 0)
                    {
                        for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                        {
                            dr = ds.Tables[0].Rows[i];
                            listitem = new ListViewItem(dr[1].ToString());
                            listitem.SubItems.Add("| " + dr[4].ToString());
                            listitem.SubItems.Add("| " + dr[5].ToString());
                            lvWell.Items.Add(listitem);
                        }
                    }
                    break;

                case "Esp":
                    paras.Add("@param", "");
                    ds = dbCon.execprosedure("dbo.[prosedur_getdataEspTrend]", paras);
                    if (ds.Tables.Count > 0)
                    {
                        for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                        {
                            dr = ds.Tables[0].Rows[i];
                            listitem = new ListViewItem(dr[0].ToString());
                            listitem.SubItems.Add("| " + dr[1].ToString());
                            listitem.SubItems.Add("| " + dr[2].ToString());
                            lvWell.Items.Add(listitem);
                        }
                    }
                    break;

                case "Discrete":
                    paras.Add("@param", "");
                    ds = dbCon.execprosedure("dbo.[prosedur_getdataGroupdescretestatus]", paras);
                    if (ds.Tables.Count > 0)
                    {
                        for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                        {
                            dr = ds.Tables[0].Rows[i];
                            listitem = new ListViewItem(dr[0].ToString());
                            listitem.SubItems.Add("| " + dr[1].ToString());
                            listitem.SubItems.Add("| " + dr[2].ToString());
                            lvWell.Items.Add(listitem);
                        }
                    }
                    break;
            }
            
        }

        private void tvMenu_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void tvAlarm_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void beamAnalysisHistoryToolStripMenuItem9_Click(object sender, EventArgs e)
        {
            ShowModule("ESP Well group Status");
        }

        private void beamAnalysisHistoryToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            ShowModule("Alarm Class Configuration");
        }

        private void currentCycleManagementToolStripMenuItem9_Click(object sender, EventArgs e)
        {
            Globals.formPilih = "gas";
            ShowModule("Group Analog Status");
        }

        private void defaultWellModelFileToolStripMenuItem9_Click(object sender, EventArgs e)
        {
            Globals.formPilih = "gds";
            ShowModule("Group Discrete Status");
        }

        private void beamChartViewerToolStripMenuItem10_Click(object sender, EventArgs e)
        {
            ShowModule("Most Recent Test");
        }

        private void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
        {
            //NOTE : Never play with the UI thread here...

            //time consuming operation
            for (int i = 0; i < 100; i++)
            {
                Thread.Sleep(100);
                m_oWorker.ReportProgress(i);

                //If cancel button was pressed while the execution is in progress
                //Change the state from cancellation ---> cancel'ed
                if (m_oWorker.CancellationPending)
                {
                    e.Cancel = true;
                    m_oWorker.ReportProgress(0);
                    return;
                }

            }

            //Report 100% completion on operation completed
            m_oWorker.ReportProgress(100);
        }

        private void backgroundWorker2_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            // this runs on the UI thread
            //Loading_Off();
        }

        private void backgroundWorker2_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
        }

        private void highlightgrid(string namaform) {

            namaform = "";
            /*switch (selectTree) {
                case "Beam":
                    modulePEDashboard.HighlightGrid();
                    break;
                case "Esp":
                    break;
            }*/
            Globals.SelectListView = lvWell.SelectedItems[0].SubItems[0].Text.ToString().Trim();
            Globals.ForeignKey = lvWell.SelectedItems[0].SubItems[0].Text.ToString().Trim();
            switch (namaform)
            {
                case "Test Temp":
                    
                   // highlightgrid(Globals.treePilih);
                    break;

                case "Beam Well Current Status Detail":
                    //moduleBeamWellCurrentStatus
                    break;

                case "Discrete Status":
                    moduleDiscreteStatus.HighlightGrid();
                    break;

                case "ESP Well Current Status Detail":
                    //moduleespwe
                    break;

                case "Beam Well Current Status":
                    //moduleBeamWellCurrentStatus.hig
                    break;

                case "ESP Well Current Status":
                    //moduleESPWellCurrentStatus.ho
                    break;

                case "Most Recent Test":
                    moduleMostrecenttest.HighlightGrid();
                    break;

                case "Group Discrete Status":
                    moduleDiscreteStatus.HighlightGrid();
                    break;

                case "Group Analog Status":
                    moduleGroupAnalogStatus.HighlightGrid();
                    break;

                case "Alarm Class Configuration":
                    moduleAlarmClassConfiguration.HighlightGrid();
                    break;

                case "ESP Well group Status":
                    //moduleESPWellCurrentStatus
                    break;

                case "Alarm History":
                    moduleAlarmHistory.HighlightGrid();
                    break;
                case "Beam Well Group Configuration":
                    moduleBeamWellGroupConfiguration.HighlightGrid();
                    break;
                case "Group Descrete Config":
                    moduleGroupDescreteConfig.HighlightGrid();
                    break;
                case "Group Analog Config":
                    moduleGroupAnalogConfig.HighlightGrid();
                    break;
                case "Well Group Status":
                    moduleWellGroupStatus.HighlightGrid();
                    break;
                case "PE Dashboard":
                    modulePEDashboard.HighlightGrid();
                    break;
                case "Well Analysis":
                    moduleWellAnalysis.HighlightGrid();
                    break;
                case "Configuration":
                    moduleConfiguration.HighlightGrid();
                    break;
                case "Welltest":
                    moduleWelltest.HighlightGrid();
                    break;
                case "Well Failure":
                    moduleWellFailure.HighlightGrid();
                    break;

                case "Out of Spec High Peak":
                    moduleOutofSpecHighPeak.HighlightGrid();
                    break;
                case "Parameter Mismatch":
                    moduleParameterMismatch.HighlightGrid();
                    break;
                case "Unconfigured Alarms":
                    moduleUnconfiguredAlarms.HighlightGrid();
                    break;
                case "Unconfigured Cranks":
                    moduleUnconfiguredCranks.HighlightGrid();
                    break;
                case "Invalid Pump Eff./ SPM":
                    moduleInvalidPumpEffSPM.HighlightGrid();
                    break;
                case "Old Cards":
                    moduleOldCards.HighlightGrid();
                    break;
                case "% Configured":
                    moduleConfigured.HighlightGrid();
                    break;

                case "24HR FOP":
                    module24HRFOP.HighlightGrid();
                    break;
                case "High Cycles > 150":
                    moduleHighCycles150.HighlightGrid();
                    break;
                case "Gearbox OverLoad > 110%":
                    moduleGearboxOverLoad110.HighlightGrid();
                    break;
                case "Low Runtime":
                    moduleLowRuntime.HighlightGrid();
                    break;
                case "Under Displaced":
                    moduleUnderDisplaced.HighlightGrid();
                    break;
                case "% Optimized":
                    moduleOptimized.HighlightGrid();
                    break;

                case "Overloaded Rods":
                    moduleOverloadedRods.HighlightGrid();
                    break;
                case "Low Pump Efficiency":
                    moduleLowPumpEfficiency.HighlightGrid();
                    break;
                case "More Fluid Available":
                    moduleMoreFluidAvailable.HighlightGrid();
                    break;
                case "Production Decreasing":
                    moduleProductionDecreasing.HighlightGrid();
                    break;
                case "Questionable POC":
                    moduleQuestionablePOC.HighlightGrid();
                    break;
                case "Miscalibration of Data":
                    moduleMiscalibrationofData.HighlightGrid();
                    break;
                case "Units Under Utilized":
                    moduleUnitsUnderUtilized.HighlightGrid();
                    break;
                case "Candidates for Unit Upsize":
                    moduleCandidatesforUnitUpsize.HighlightGrid();
                    break;
                case "Savings From Balancing":
                    moduleSavingsFromBalancing.HighlightGrid();
                    break;

                case "Detail LW":
                    
                    break;

                case "Well Current Status":
                    //moduleWellCurrentStatus.HighlightGrid();

                    break;

                // ESP GROUP TREND
                case "All ESP Well":
                    moduleEspGroupAllEspWell.HighlightGrid();
                    break;
                case "Alarms":
                    moduleEspGroupAlarms.HighlightGrid();
                    break;
                case "Alarms at G.O":
                    moduleEspGroupAlarmsatGO.HighlightGrid();
                    break;
                case "Running":
                    moduleEspGroupRunning.HighlightGrid();
                    break;
                case "In Service Well Type":
                    moduleEspGroupInServiceWellType.HighlightGrid();
                    break;
                case "Out of Service":
                    moduleEspGroupOutofService.HighlightGrid();
                    break;
                case "Down":
                    moduleEspGroupDown.HighlightGrid();
                    break;
                case "Comm Fail":
                    moduleEspGroupCommFail.HighlightGrid();
                    break;
                case "Comm Ok":
                    moduleEspGroupCommOk.HighlightGrid();
                    break;
            }
        }

        private void lvWell_Click(object sender, EventArgs e)
        {
            Globals.ForeignKey = lvWell.SelectedItems[0].SubItems[0].Text.ToString().Trim();
            Globals.winformjudul = "ePetro - Production Optimization System [Well Name: " + Globals.ForeignKey + "]";
            this.Text = Globals.winformjudul;
            if (Globals.formPilih == "wcs")
            {
                //Globals.ForeignKey = lvWell.SelectedItems[0].SubItems[0].Text.ToString().Trim();
                Globals.winformjudul = "ePetro - Production Optimization System [Beam Well Current Status Detail] [Well Name: " + Globals.ForeignKey + "]";
                this.Text = Globals.winformjudul;
                ShowModule("Beam Well Current Status Detail");
            }
            else if (Globals.formPilih == "rw2")
            {
                 
                ShowModule("rw2");
            }
            else if (Globals.formPilih == "gas" || Globals.formPilih == "gas2")
            {
                Globals.winformjudul = "ePetro - Production Optimization System [Group Analog Status] [Well Name: " + Globals.ForeignKey + "]";
                Globals.formPilih = "gas2";
                ShowModule("Group Analog Status");
            }
            else if (Globals.formPilih == "gds" || Globals.formPilih == "gds2")
            {
                Globals.winformjudul = "ePetro - Production Optimization System [Group Discrete Status] [Well Name: " + Globals.ForeignKey + "]";
                Globals.formPilih = "gds2";
                ShowModule("Group Discrete Status");
            } 
            else
            {
                Globals.winformjudul = "ePetro - Production Optimization System [Detail LW] [Well Name: " + Globals.ForeignKey + "]";
                ShowModule("Detail LW");
                //  ShowModule("Beam Well Current Status Detail");
                // this.highlightgrid(Globals.formPilih);
            }
        }
        private void trvOrg_MouseDown(object sender, MouseEventArgs e)
        {
            // Make sure this is the right button.
            if (e.Button != MouseButtons.Right) return;

            // Select this node.
            TreeNode node_here = tvMenu.GetNodeAt(e.X, e.Y);
            tvMenu.SelectedNode = node_here;

            // See if we got a node.
            if (node_here == null) return;

            // See what kind of object this is and
            // display the appropriate popup menu.
            if (node_here.Tag is FactoryData)
                contexmroot.Show(tvMenu, new Point(e.X, e.Y));
            else if (node_here.Tag is GroupData)
                contexmgroup.Show(tvMenu, new Point(e.X, e.Y));
            else if (node_here.Tag is PersonData)
                contexmitem.Show(tvMenu, new Point(e.X, e.Y));
        }

      
        private void beamWellCurrentStatusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //ShowModule("Beam Well Current Status");
        }

        private void eSPWellCurrentStatusToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void splitContainer2_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tvAlarm_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            string tmp = e.Node.Text;
            Globals.formPilih = tmp;
            if (e.Button == MouseButtons.Left)
            {
                ShowModule(tmp);
            }
        }

        private void beamAnalysisWorkbenchToolStripMenuItem9_Click(object sender, EventArgs e)
        {
            Globals.formPilih = "gas2";
            ShowModule("Group Analog Status");
        }

        private void beamChartWorkbenchToolStripMenuItem9_Click(object sender, EventArgs e)
        {
            Globals.formPilih = "gds2";
            ShowModule("Discrete Status");
        }

        private void beamDesignWorkbenchToolStripMenuItem9_Click(object sender, EventArgs e)
        {

        }

        private void splitContainer3_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void lvWell_DoubleClick(object sender, EventArgs e)
        {
            
            ShowModule("Detail LW");
        }

        private void beamValveCheckWorkbenchToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            Globals.winformjudul = "ePetro - Production Optimization System [RTU Read-Write] [Well Name: " + Globals.ForeignKey + "]";
            Globals.formPilih = "rw2";
            this.Text = Globals.winformjudul;
            ShowModule("rw2");
        }

        private void controlParametersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Globals.formPilih = "rw";
            ShowModule("rw");
        }

        private void wellStatusToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void beamChartViewerToolStripMenuItem9_Click(object sender, EventArgs e)
        {
            ShowModule("bmgs");
        }

        private void diagnosticReportToolStripMenuItem8_Click(object sender, EventArgs e)
        {

        }

        private void manageViewsToolStripMenuItem8_Click(object sender, EventArgs e)
        {

        }

        private void purgeStoreToolStripMenuItem8_Click(object sender, EventArgs e)
        {

        }

        private void webBrowserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            browser brsr = new browser();
            brsr.ShowDialog();
        }

        private void addGroupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TreeNode _selectedNode = tvMenu.SelectedNode;

            tvmenu tv = new tvmenu();
            tv.parentname = _selectedNode.Text;
            tv.parentid = _selectedNode.Tag.ToString();
            tv.currentid = "0";
            tv.currentname = "";
            tv.ShowDialog();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TreeNode _selectedNode = tvMenu.SelectedNode;
            tvmenu tv = new tvmenu();
            tv.parentname = _selectedNode.Parent.Text;
            tv.parentid = _selectedNode.Parent.Tag.ToString();
            tv.currentid = _selectedNode.Tag.ToString();
            tv.currentname = _selectedNode.Text;
            tv.ShowDialog();
        }

        private void beamChartViewerToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            lw.FormBeamWell f;
            f = new lw.FormBeamWell();
            f.DoShow("test1", false);
        }

        private void beamAnalysisWorkbenchToolStripMenuItem4_Click(object sender, EventArgs e)
        {

        }

        private void btnfav_Click(object sender, EventArgs e)
        {
            //
            
            favDialog.Show();
        }

        private void tvMenu_AfterSelect_1(object sender, TreeViewEventArgs e)
        {

        }

        private void lvWell_ItemDrag(object sender, ItemDragEventArgs e)
        {
            this.favDialog.Focus();
            //this.favDialog.Controls
            //favDialog.Controls.IndexOf[1].;
            var items = new List<ListViewItem>();
            // add dragged one first
            items.Add((ListViewItem)e.Item);
        }
    }
    public class FactoryData
    {
        public string Name = "";

        // Initializing constructor.
        public FactoryData(string new_name)
        {
            Name = new_name;
        }
    }
    public class GroupData
    {
        public string Name = "";
        public List<string> Projects = new List<string>();

        // Initializing constructor.
        public GroupData(string new_name, params string[] project_names)
        {
            Name = new_name;
            for (int i = 0; i <= project_names.GetUpperBound(0); i++)
            {
                Projects.Add(project_names[i]);
            }
        }
    }
    public class PersonData
    {
        public string Name = "";
        public List<string> Projects = new List<string>();

        // Initializing constructor.
        public PersonData(string new_name, params string[] project_names)
        {
            Name = new_name;
            for (int i = 0; i <= project_names.GetUpperBound(0); i++)
            {
                Projects.Add(project_names[i]);
            }
        }
    }
}
