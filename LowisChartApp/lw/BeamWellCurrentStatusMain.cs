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



namespace LowisChartApp.lw
{
    public partial class BeamWellCurrentStatusMain : DevExpress.XtraEditors.XtraUserControl
    {
        DB dbCon;
        frmMain frm;
        public BeamWellCurrentStatusMain()
        {
            InitializeComponent();
            dbCon = new DB(Globals.getstringco());
        }

        public void HighlightGrid()
        {
            if (Globals.SelectListView != "")
            {
                int rowHandle = GetRowHandleByColumnValue(gvLowis, "WellName", Globals.SelectListView);
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
        private void BeamWellCurrentStatusMain_Load(object sender, EventArgs e)
        {
            dbCon.clearCache();
            Dictionary<string, object> paras = new Dictionary<string, object>();
            paras.Add("@param", "");
            DataSet ds = dbCon.execprosedure("dbo.[prosedur_getdatabeamWellGroupStatus]", paras);
            if (ds.Tables.Count < 1)
            {
                //MessageBox.Show(ds.Tables[0].Rows.Count.ToString());
                MessageBox.Show("Database execute timeout", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //MessageBox.Show(ds.Tables[0].Rows.Count.ToString());
            gdLowis.DataSource = ds.Tables[0];
            gdLowis.Cursor = Cursors.Hand;
            this.gdLowis.Refresh();
            //if (Globals.SelectListView != "")
            //{
            //    int rowHandle = GetRowHandleByColumnValue(gvLowis, "WELLNAME", Globals.SelectListView);
            //    gvLowis.FocusedRowHandle = rowHandle;
            //}
        }

        private void gdLowis_DoubleClick(object sender, EventArgs e)
        {
            foreach (int i in gvLowis.GetSelectedRows())
            {
                DataRow row = gvLowis.GetDataRow(i);
                Globals.ForeignKey = row[0].ToString().Trim();
            }
            //frm = new frmMain();
            //frm.ShowModule("Detail LW");
            //frm.Show();
            frm = (frmMain)Application.OpenForms["frmMain"];
            frm.ShowModule("Beam Well Current Status Detail");
            frm.Show();
        }
    }
}
