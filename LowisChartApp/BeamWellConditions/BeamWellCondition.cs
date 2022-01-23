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

namespace LowisChartApp.BeamWellConditions
{
    public partial class BeamWellCondition : DevExpress.XtraEditors.XtraUserControl
    {
        DB dbCon;
        public BeamWellCondition()
        {
            InitializeComponent();
            dbCon = new DB(Globals.getstringco());
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BeamWellCondition_Load(object sender, EventArgs e)
        {
            Dictionary<string, object> paras = new Dictionary<string, object>();
            paras.Add("@param", "");
            DataSet ds = dbCon.execprosedure("dbo.[prosedur_getdataAlarms]", paras);
            if (ds.Tables.Count < 1)
            {
                //MessageBox.Show(ds.Tables[0].Rows.Count.ToString());
                MessageBox.Show("Database execute timeout", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            gdlowis.DataSource = ds.Tables[0];
            this.gdlowis.Refresh();
        }

        private void gvlowis_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        {
            GridView View = sender as GridView;
            if (e.RowHandle >= 0)
            {
                string category = View.GetRowCellDisplayText(e.RowHandle, View.Columns["AlarmMessage"]);
                if (category != "")
                {
                    e.Appearance.BackColor = Color.Yellow;
                    //e.Appearance.BackColor2 = Color.SeaShell;
                }
            }
        }
    }
}
