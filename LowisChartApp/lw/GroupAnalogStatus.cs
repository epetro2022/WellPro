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
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid;
using System.Collections;
using DevExpress.XtraCharts;
// ok
namespace LowisChartApp.lw
{
    public partial class GroupAnalogStatus : DevExpress.XtraEditors.XtraUserControl
    {
        DB dbCon;
        public GroupAnalogStatus()
        {
            InitializeComponent();
            dbCon = new DB(Globals.getstringco());
        }

        public void HighlightGrid()
        {
            if (Globals.SelectListView != "")
            {
                int rowHandle = GetRowHandleByColumnValue(gvLowis, "FacilityWellName", Globals.SelectListView);
                gvLowis.FocusedRowHandle = rowHandle;
            }
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
        private void GroupAnalogStatus_Load(object sender, EventArgs e)
        {
            dbCon.clearCache();
            Dictionary<string, object> paras = new Dictionary<string, object>();
            if (Globals.formPilih == "gas")
            {
                paras.Add("@param", "");
            }
            else
            {
                paras.Add("@param", Globals.ForeignKey);
            }
            DataSet ds = dbCon.execprosedure("dbo.[prosedur_getdataGroupanalogstatus]", paras);
            if (ds.Tables.Count < 1)
            {
                //MessageBox.Show(ds.Tables[0].Rows.Count.ToString());
                MessageBox.Show("Database execute timeout", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            gdLowis.DataSource = ds.Tables[0];
            gdLowis.Cursor = Cursors.Hand;
            this.gdLowis.Refresh();

            //// Access the type-specific options of the diagram.
            //((XYDiagram)chartanalogtrend.Diagram).EnableAxisXZooming = true;

            //// Hide the legend (if necessary).
            //chartanalogtrend.Legend.Visibility = DevExpress.Utils.DefaultBoolean.False;

            // Add a title to the chart (if necessary).
            chartanalogtrend.Titles.Add(new ChartTitle());
        }

        private void gdLowis_Click(object sender, EventArgs e)
        {
            foreach (int i in gvLowis.GetSelectedRows())
            {
                DataRow row = gvLowis.GetDataRow(i);
                Globals.ForeignKey = row[1].ToString().Trim();
            }
        }

        private void gdLowis_MouseUp(object sender, MouseEventArgs e)
        {
            foreach (int i in gvLowis.GetSelectedRows())
            {
                DataRow row = gvLowis.GetDataRow(i);
                Globals.ForeignKey = row[1].ToString().Trim();
            }
            string tmp;
        }

        private void gvLowis_RowClick(object sender, RowClickEventArgs e)
        {
            Int32[] selectedRowHandles = gvLowis.GetSelectedRows();
            ArrayList rows = new ArrayList();
            string FacilityWellName = "";
            string AnalogPointDescription = "";
            for (int i = 0; i < selectedRowHandles.Length; i++)
            {
                int selectedRowHandle = selectedRowHandles[i];
                if (selectedRowHandle >= 0)
                    rows.Add(gvLowis.GetDataRow(selectedRowHandle));
            }

            for (int i = 0; i < rows.Count; i++)
            {
                DataRow row = rows[i] as DataRow;
                FacilityWellName = row["FacilityWellName"].ToString();
                AnalogPointDescription = row["AnalogPointDescription"].ToString();
            }

            //string FacilityWellName = (sender as GridView).GetFocusedRowCellValue("FacilityWellName").ToString();
            //string AnalogPointDescription = (sender as GridView).GetFocusedRowCellValue("AnalogPointDescription").ToString();
            dbCon.clearCache();
            Dictionary<string, object> paras = new Dictionary<string, object>();
            paras.Add("@wellname", FacilityWellName);
            paras.Add("@Analog_Desc", AnalogPointDescription);
            DataSet ds = dbCon.execprosedure("dbo.[prosedur_getdataanalogtrendnew]", paras);
            if (ds.Tables.Count < 1)
            {
                //MessageBox.Show(ds.Tables[0].Rows.Count.ToString());
                MessageBox.Show("Database execute timeout, chart analog trend can't be show", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                chartanalogtrend.DataSource = null;
                chartanalogtrend.Series.Clear();
                Series series1 = new Series("Series 1", ViewType.Spline);
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    //Console.WriteLine(row["ImagePath"]);
                    series1.Points.Add(new SeriesPoint(row["timestamp"], row["VALUE"]));

                }
                //gdLowis.DataSource = ds.Tables[0];
                //// Add the series to the chart.
                chartanalogtrend.Series.Add(series1);
                //lineChart.Series.Add(series2);

                // Set the numerical argument scale types for the series,
                // as it is qualitative, by default.
                series1.ArgumentScaleType = ScaleType.DateTime;

                // Access the view-type-specific options of the series.
                ((LineSeriesView)series1.View).MarkerVisibility = DevExpress.Utils.DefaultBoolean.True;
                ((LineSeriesView)series1.View).LineMarkerOptions.Kind = MarkerKind.Circle;
                ((LineSeriesView)series1.View).LineStyle.DashStyle = DashStyle.Solid;

          
                chartanalogtrend.Titles[0].Text = "Analog Trend Wellname : " + FacilityWellName + "-" + AnalogPointDescription;
                chartanalogtrend.RefreshData();
            }
        }
    }
}
