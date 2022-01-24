﻿using System;
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
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid;
using System.Threading;
using System.Configuration;


namespace LowisChartApp.lw
{
    public partial class LowisForm : DevExpress.XtraEditors.XtraUserControl
    {
        DB dbCon;
        frmMain frm; 
        private Thread workerThread = null;
        public LowisForm()
        {
            InitializeComponent();
            dbCon = new DB(Globals.getstringco());
            // This line of code is generated by Data Source Configuration Wizard
            // Fill a SqlDataSource
            //sqlDataSource1.Fill();
        }

        private int GetRowHandleByColumnValue(GridView view, string ColumnFieldName, object value)
        {
            int result = GridControl.InvalidRowHandle;
            for (int i = 0; i < view.RowCount; i++)
            {
                //string tmp = view.GetDataRow(i)[ColumnFieldName].ToString();
                if (view.GetDataRow(i)[ColumnFieldName].ToString().Trim().Equals(value))
                    return i;
            }
            return result;
        }

        private void gdLowis_Click(object sender, EventArgs e)
        {
            string abc = "232", abce=String.Empty;
        }

        private void LoadData()
        {
            // some work takes 5 sec
            Thread.Sleep(Convert.ToInt32(ConfigurationManager.AppSettings["sleep"]));
        }

        private void LowisForm_Load(object sender, EventArgs e)
        {
            dbCon.clearCache();
            gdLowis.DataSource = null;
            Dictionary<string, object> paras = new Dictionary<string, object>();
            paras.Add("@param", Globals.parameterid);
            paras.Add("@id", Globals.idsp);
            //pgbar.Visible = true;
            //pgbar.Style = ProgressBarStyle.Marquee;

            //// start the job and the timer, which polls the thread

            //workerThread = new Thread(LoadData);
            //workerThread.Start();
            //timer1.Interval = 100;
            //timer1.Start();
            DataSet ds = dbCon.execprosedure("dbo.[prosedur_getdataWellGroupStatus2]", paras);

            //MessageBox.Show(ds.Tables[0].Rows.Count.ToString());
            //(ds.Tables[0].Rows.Count < 0)
            if (ds.Tables.Count<1)
            {
                //MessageBox.Show(ds.Tables[0].Rows.Count.ToString());
                MessageBox.Show("Database execute timeout", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
                return;
            }
            gdLowis.DataSource = ds.Tables[0];
            gdLowis.Cursor = Cursors.Hand;
            this.gdLowis.Refresh();
            if (Globals.SelectListView != "")
            {
                int rowHandle = GetRowHandleByColumnValue(gvLowis, "WELLNAME", Globals.SelectListView);
                gvLowis.FocusedRowHandle = rowHandle;
            }
        }

        private void pasteToolStripButton2_Click(object sender, EventArgs e)
        {

        }

        private void prosedurgetdataWellGroupStatusBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void gdLowis_Click_1(object sender, EventArgs e)
        {
           
        }

        

        public void higlightlistview(string type)
        {
           
            /*int index;
            switch (type)
            {
                case "Beam":
                    if (Globals.SelectListView != "")
                    {
                        int rowHandle = GetRowHandleByColumnValue(gvLowis, "WELLNAME", Globals.SelectListView);
                        gvLowis.FocusedRowHandle = rowHandle;
                    }
                    break;
                case "Esp":
                    
                    break;
            }*/
        }

        private void gdLowis_MouseClick(object sender, MouseEventArgs e)
        {
            //private frmMain _mainForm = new frmMain();   
            foreach (int i in gvLowis.GetSelectedRows())
            {
                DataRow row = gvLowis.GetDataRow(i);
                Globals.ForeignKey = row[1].ToString().Trim();
            }
            //frmMain.
            frm = (frmMain)Application.OpenForms["frmMain"];
            frm.higlightlistview("Beam");
            //frm.ShowModule("Detail LW");
            //frm.Show();
        }

        public void HighlightGrid() {
            if (Globals.SelectListView != "")
            {
                int rowHandle = GetRowHandleByColumnValue(gvLowis, "WELLNAME", Globals.SelectListView);
                gvLowis.FocusedRowHandle = rowHandle;
            }
        }

        private void gdLowis_MouseDown(object sender, MouseEventArgs e)
        {
            foreach (int i in gvLowis.GetSelectedRows())
            {
                DataRow row = gvLowis.GetDataRow(i);
                Globals.ForeignKey = row[1].ToString().Trim();
            }
            frm = (frmMain)Application.OpenForms["frmMain"];
            frm.higlightlistview("Beam");
        }
        string Leftstr(string input, int count)
        {
            return input.Substring(0, Math.Min(input.Length, count));
        }
        private void gvLowis_RowStyle(object sender, RowStyleEventArgs e)
        {
            GridView View = sender as GridView;
            if (e.RowHandle >= 0)
            {
                string ALARM = View.GetRowCellDisplayText(e.RowHandle, View.Columns["ALARM"]).Trim();
                string MOTORSTAT = View.GetRowCellDisplayText(e.RowHandle, View.Columns["MOTORSTAT"]).Trim();
                string HOSTMODE = View.GetRowCellDisplayText(e.RowHandle, View.Columns["HOSTMODE"]).Trim();
                if (MOTORSTAT != "")
                {
                    e.Appearance.BackColor = Color.Red;
                    //e.Appearance.BackColor2 = Color.SeaShell;
                }
                 if (ALARM != "")
                {
                    e.Appearance.BackColor = Color.Yellow;
                    //e.Appearance.BackColor2 = Color.SeaShell;
                }
                 if (ALARM == "")
                {
                    e.Appearance.BackColor = Color.LightGreen;
                    //e.Appearance.BackColor2 = Color.SeaShell;
                }
                if (Leftstr(ALARM,7) == "ComFail")
                {
                    e.Appearance.BackColor = Color.White;
                    //e.Appearance.BackColor2 = Color.SeaShell;
                }
                // if (HOSTMODE!="") {
                //    e.Appearance.BackColor = Color.Magenta;
                //}
            }
        }

        private void gdLowis_DoubleClick(object sender, EventArgs e)
        {
            foreach (int i in gvLowis.GetSelectedRows())
            {
                DataRow row = gvLowis.GetDataRow(i);
                Globals.ForeignKey = row[1].ToString().Trim();
            }
            //frm = new frmMain();
            //frm.ShowModule("Detail LW");
            //frm.Show();
            frm = (frmMain)Application.OpenForms["frmMain"];
            frm.ShowModule("Detail LW");
            frm.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (workerThread == null)
            {
                timer1.Stop();
                return;
            }

            // still works: exiting
            if (workerThread.IsAlive)
                return;

            // finished
            //btnImport.Enabled = true;
            timer1.Stop();
            pgbar.Visible = false;
            workerThread = null;
        }

        private void btnScan_Click(object sender, EventArgs e)
        {
            BeamWellCurrentStatus bcs = new BeamWellCurrentStatus();
            bcs.lblWellName.Text = Globals.ForeignKey;
            bcs.button1_Click(sender, e);



            dbCon.clearCache();
            gdLowis.DataSource = null;
            Dictionary<string, object> paras = new Dictionary<string, object>();
            paras.Add("@param", Globals.parameterid);
            paras.Add("@id", Globals.idsp);
            //pgbar.Visible = true;
            //pgbar.Style = ProgressBarStyle.Marquee;

            //// start the job and the timer, which polls the thread

            //workerThread = new Thread(LoadData);
            //workerThread.Start();
            //timer1.Interval = 100;
            //timer1.Start();
            DataSet ds = dbCon.execprosedure("dbo.[prosedur_getdataWellGroupStatus2]", paras);

            //MessageBox.Show(ds.Tables[0].Rows.Count.ToString());
            //(ds.Tables[0].Rows.Count < 0)
            if (ds.Tables.Count < 1)
            {
                //MessageBox.Show(ds.Tables[0].Rows.Count.ToString());
                MessageBox.Show("Database execute timeout", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }
            gdLowis.DataSource = ds.Tables[0];
            gdLowis.Cursor = Cursors.Hand;
            this.gdLowis.Refresh();
            if (Globals.SelectListView != "")
            {
                int rowHandle = GetRowHandleByColumnValue(gvLowis, "WELLNAME", Globals.SelectListView);
                gvLowis.FocusedRowHandle = rowHandle;
            }



        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            frm = (frmMain)Application.OpenForms["frmMain"];
            frm.ShowModule("Map");
            frm.Show();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {

        }
    }
}
