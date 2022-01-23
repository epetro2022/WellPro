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
    public partial class ESPWellCurrentStatusMain : DevExpress.XtraEditors.XtraUserControl
    {
        DB dbCon;
        frmMain frm;
        public ESPWellCurrentStatusMain()
        {
            InitializeComponent();
            dbCon = new DB(Globals.getstringco());
        }

        private void ESPWellCurrentStatusMain_Load(object sender, EventArgs e)
        {
            dbCon.clearCache();
            Dictionary<string, object> paras = new Dictionary<string, object>();
            paras.Add("@param", "");
            DataSet ds = dbCon.execprosedure("dbo.[prosedur_getdataESPWellgroupStatus]", paras);
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
            frm.ShowModule("ESP Well Current Status Detail");
            frm.Show();
        }

        public void HighlightGrid()
        {
            if (Globals.SelectListView != "")
            {
                int rowHandle = GetRowHandleByColumnValue(gvLowis, "WellNameLWNAME", Globals.SelectListView);
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
    }
}
