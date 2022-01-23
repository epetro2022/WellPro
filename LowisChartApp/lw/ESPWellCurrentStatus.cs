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

namespace LowisChartApp.lw
{
    public partial class ESPWellCurrentStatus : DevExpress.XtraEditors.XtraUserControl
    {
        DB dbCon;
        public ESPWellCurrentStatus()
        {
            InitializeComponent();
            dbCon = new DB(Globals.getstringco());
        }

        private DataTable loaddata()
        {
            Dictionary<string, object> paras = new Dictionary<string, object>();
            paras.Add("@param", Globals.ForeignKey);
            DataSet ds = dbCon.execprosedure("dbo.[prosedur_getdataESPWellgroupStatusDetil]", paras);
            return ds.Tables[0];
        }

        private void label33_Click(object sender, EventArgs e)
        {

        }

        private void label32_Click(object sender, EventArgs e)
        {

        }

        private void label34_Click(object sender, EventArgs e)
        {

        }

        private void label35_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void lblCardAreaLastStrAverageToday_Click(object sender, EventArgs e)
        {

        }

        private void lblCasingPressCurrent_Click(object sender, EventArgs e)
        {

        }

        private void lblCardAreaLastStrCurrent_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click_1(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void lblCasingPressAverageToday_Click(object sender, EventArgs e)
        {

        }

        private void label70_Click(object sender, EventArgs e)
        {

        }

        private void label58_Click(object sender, EventArgs e)
        {

        }

        private void label74_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void ESPWellCurrentStatus_Load(object sender, EventArgs e)
        {
            lblwellname.Text = Globals.ForeignKey;
            DataTable dt = this.loaddata();

            lblAVGPumpGradeWtAverageToday.Text = dt.Rows[0][0].ToString().Trim();
            lblAVGTubeGradeWTAverageToday.Text = dt.Rows[0][1].ToString().Trim();
            lblCalCangFLRateAverageToday.Text = dt.Rows[0][2].ToString().Trim();
            lblCasingChokeAverageToday.Text = dt.Rows[0][3].ToString().Trim();
            lblCasingPressAverageToday.Text = dt.Rows[0][4].ToString().Trim();
            lblCAsingLinePressAverageToday.Text = dt.Rows[0][5].ToString().Trim();
            lblCasingGasFlowRateAverageToday.Text = dt.Rows[0][6].ToString().Trim();
            lblDrawDownAverageToday.Text = dt.Rows[0][7].ToString().Trim();
            lblESPDeepPressAverageToday.Text = dt.Rows[0][8].ToString().Trim();
            lblESPIntakePressAverageToday.Text = dt.Rows[0][9].ToString().Trim();
            lblESPInchargepressAverageToday.Text = dt.Rows[0][10].ToString().Trim();
            lblFAPCalAverageToday.Text = dt.Rows[0][11].ToString().Trim();
            lblFAPWTAverageToday.Text = dt.Rows[0][12].ToString().Trim();
            lblFlowLinePressAverageToday.Text = dt.Rows[0][13].ToString().Trim();
            lblFlowLineTempAverageToday.Text = dt.Rows[0][14].ToString().Trim();
            lblFlowTubingPressAverageToday.Text = dt.Rows[0][15].ToString().Trim();
            lblInstTubingGradeAverageToday.Text = dt.Rows[0][16].ToString().Trim();
            lblInstTubingTempAverageToday.Text = dt.Rows[0][17].ToString().Trim();
            lblMotorCurrentAverageToday.Text = dt.Rows[0][18].ToString().Trim();
            lblMotorLeakCurrentAverageToday.Text = dt.Rows[0][19].ToString().Trim();
            lblMotorPowerAverageToday.Text = dt.Rows[0][20].ToString().Trim();
            lblMotorTempAverageToday.Text = dt.Rows[0][21].ToString().Trim();
            lblMotorTrqCurrentAverageToday.Text = dt.Rows[0][22].ToString().Trim();
            lblMotorVibrationAverageToday.Text = dt.Rows[0][23].ToString().Trim();
            lblmotorVoltageAverageToday.Text = dt.Rows[0][24].ToString().Trim();
            lblPimpIntakePressWTAverageToday.Text = dt.Rows[0][25].ToString().Trim();
            lblQophzSWGAverageToday.Text = dt.Rows[0][26].ToString().Trim();
            lblQophzSurfaceAverageToday.Text = dt.Rows[0][27].ToString().Trim();
            lblRateChangeofPIPAverageToday.Text = dt.Rows[0][28].ToString().Trim();
            lblTubingChokeAverageToday.Text = dt.Rows[0][29].ToString().Trim();
            lblWFDPrequencyAverageToday.Text = dt.Rows[0][30].ToString().Trim();
            lblWFDNumStartAverageToday.Text = dt.Rows[0][31].ToString().Trim();
            lblWellTestFluidAverageToday.Text = dt.Rows[0][32].ToString().Trim();
            lblWellTestPreqAverageToday.Text = dt.Rows[0][33].ToString().Trim();

            lblAVGPumpGrade_Wtcurrent.Text = dt.Rows[0][0].ToString().Trim();
            lblAVGTubeGrade_WtCurrent.Text = dt.Rows[0][1].ToString().Trim();
            lblCalCsngFlRateCurrent.Text = dt.Rows[0][2].ToString().Trim();
            lblCasingChokeCurrent.Text = dt.Rows[0][3].ToString().Trim();
            lblCasingPressCurrent.Text = dt.Rows[0][4].ToString().Trim();
            lblCasingLinePressCurrent.Text = dt.Rows[0][5].ToString().Trim();
            lblCAsingGasFlowRateCurrent.Text = dt.Rows[0][6].ToString().Trim();
            lblDrawDownCurrent.Text = dt.Rows[0][7].ToString().Trim();
            lblESPDeepPressCurrent.Text = dt.Rows[0][8].ToString().Trim();
            lblEspIntakePressCurrent.Text = dt.Rows[0][9].ToString().Trim();
            lblESPInchargePressCurrent.Text = dt.Rows[0][10].ToString().Trim();
            lblFAPCalCurrent.Text = dt.Rows[0][11].ToString().Trim();
            lblFAPWTCurrent.Text = dt.Rows[0][12].ToString().Trim();
            lblFlowLinePressCurrent.Text = dt.Rows[0][13].ToString().Trim();
            lblFlowLineTempCurrent.Text = dt.Rows[0][14].ToString().Trim();
            lblFlowTubingPressCurrent.Text = dt.Rows[0][15].ToString().Trim();
            lblInstTubingGradeCurrent.Text = dt.Rows[0][16].ToString().Trim();
            lblInstTubingTempCurrent.Text = dt.Rows[0][17].ToString().Trim();
            lblMotorCurrentCurrent.Text = dt.Rows[0][18].ToString().Trim();
            lblMotorLeakCurrentCurrent.Text = dt.Rows[0][19].ToString().Trim();
            lblMotorPowerCurrent.Text = dt.Rows[0][20].ToString().Trim();
            lblMotorTempCurrent.Text = dt.Rows[0][21].ToString().Trim();
            lblMotorTrqCurrentCurrent.Text = dt.Rows[0][22].ToString().Trim();
            lblMotorVibrationCurrent.Text = dt.Rows[0][23].ToString().Trim();
            lblMotorVoltageCurrent.Text = dt.Rows[0][24].ToString().Trim();
            lblPimpIntakePressWTCurrent.Text = dt.Rows[0][25].ToString().Trim();
            lblQophzSWGCurrent.Text = dt.Rows[0][26].ToString().Trim();
            lblQopSurfaceCurrent.Text = dt.Rows[0][27].ToString().Trim();
            lblRateChangeofPIPCurrent.Text = dt.Rows[0][28].ToString().Trim();
            lblTubingChokeCurrent.Text = dt.Rows[0][29].ToString().Trim();
            lblWFDPrequencyCurrent.Text = dt.Rows[0][30].ToString().Trim();
            lblWFDNumStartCurrent.Text = dt.Rows[0][31].ToString().Trim();
            lblWellTestFluidCurrent.Text = dt.Rows[0][32].ToString().Trim();
            lblWellTestPreqCurrent.Text = dt.Rows[0][33].ToString().Trim();

            lblGasLookDiscretes.Text = "0.0";
            lblHTShutdownWarn.Text = "0.0";
        }
    }
}
