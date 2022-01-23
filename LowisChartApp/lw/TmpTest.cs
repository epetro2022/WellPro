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
using System.Diagnostics;

namespace LowisChartApp.lw
{
    public partial class TmpTest : DevExpress.XtraEditors.XtraUserControl
    {
        DB dbCon;
        BackgroundWorker bg;
        Boolean stopwork = true;
        public TmpTest()
        {
            InitializeComponent();
            dbCon = new DB(Globals.getstringco());
            bg = new BackgroundWorker();
        }

        private void TmpTest_Load(object sender, EventArgs e)
        {
            //Dictionary<string, object> paras = new Dictionary<string, object>();
            //DataSet ds = dbCon.execprosedure("dbo.[prosedur_getdataWellGroupStatus]", paras);

            try
            {

                bg.DoWork += bg_DoWork;
                //bg.RunWorkerCompleted += bg_RunWorkerCompleted;
                bg.RunWorkerAsync();
                pgbUpdateMarks.Maximum = 60;
                Stopwatch st = new Stopwatch();
                st.Start();
                while (stopwork)
                {
                    pgbUpdateMarks.Value = st.Elapsed.Seconds;
                }
                pgbUpdateMarks.Value = 0;
                MessageBox.Show("Executed sucessfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void bg_DoWork(object sender, DoWorkEventArgs e)
        {

            Dictionary<string, object> paras = new Dictionary<string, object>();
            paras.Add("@param", "");
            DataSet ds = dbCon.execprosedure("dbo.[prosedur_getdataWellGroupStatus]", paras);
            stopwork = false;
        }
    }
}
