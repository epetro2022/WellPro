using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LowisChartApp.lw
{
    public partial class BeamWellGroupConfig : UserControl
    {
        public BeamWellGroupConfig()
        {
            InitializeComponent();
        }

        private void BeamWellGroupConfig_Load(object sender, EventArgs e)
        {
            beam_Well_Group_ConfigurationTableAdapter.Fill(beamWellDataSet.Beam_Well_Group_Configuration);
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            BeamWellGroupConfig_Load(sender, e);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            LowisChartApp.lw.FormBeamWell f = new LowisChartApp.lw.FormBeamWell();
            f.DoShow();
            BeamWellGroupConfig_Load(sender, e);
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            LowisChartApp.lw.FormBeamWell f = new LowisChartApp.lw.FormBeamWell();
            DataGridViewSelectedRowCollection rows = dataGridView1.SelectedRows;
            string name = rows[0].Cells[0].Value.ToString();
            f.DoShow(name);
            BeamWellGroupConfig_Load(sender, e);
        }
    }
}
