
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
    public partial class GroupAnalogConfig : DevExpress.XtraEditors.XtraUserControl
    {
        DB dbCon;
        public GroupAnalogConfig()
        {
            InitializeComponent();
            dbCon = new DB(Globals.getstringco());
        }

        public void HighlightGrid()
        {
            if (Globals.SelectListView != "")
            {
                int rowHandle = GetRowHandleByColumnValue(gvLowis, "LWNAME", Globals.SelectListView);
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
        private void GroupAnalogConfig_Load(object sender, EventArgs e)
        {
            dbCon.clearCache();
            Dictionary<string, object> paras = new Dictionary<string, object>();
            paras.Add("@param",Globals.ForeignKey);
            DataSet ds = dbCon.execprosedure("dbo.[prosedur_getdataGroupAnalogConfig]", paras);
            if (ds.Tables.Count < 1)
            {
                //MessageBox.Show(ds.Tables[0].Rows.Count.ToString());
                MessageBox.Show("Database execute timeout", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            gdLowis.DataSource = ds.Tables[0];
            gdLowis.Cursor = Cursors.Hand;
            this.gdLowis.Refresh();
        }

        private void GroupAnalogConfig_Click(object sender, EventArgs e)
        {
           
        }

        private void GroupAnalogConfig_MouseUp(object sender, MouseEventArgs e)
        {
            
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
        }

        private void gdLowis_MouseDown(object sender, MouseEventArgs e)
        {
            foreach (int i in gvLowis.GetSelectedRows())
            {
                DataRow row = gvLowis.GetDataRow(i);
                Globals.ForeignKey = row[1].ToString().Trim();
            }
        }
    }
}
