using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LowisChartApp.ds.BeamWellDataSetTableAdapters;
using LowisChartApp.ds;

namespace LowisChartApp.lw
{
    public partial class FormBeamWell : Form
    {
        BeamWellTableAdapter dta = new BeamWellTableAdapter();
        string oldWellName;

        public FormBeamWell()
        {
            InitializeComponent();
        }

        public void DoShow(string wellname = "", bool showed = true)
        {
            oldWellName = wellname;
            rbxCasingVelveOpenNo.Checked = true;
            rbxUseFluidInertiaNo.Checked = true;

            if (wellname == "")
            { 
                beamWellTableAdapter1.FillByNone(beamWellDataSet1.BeamWell);

                BeamWellDataSet.BeamWellRow nr = (BeamWellDataSet.BeamWellRow) beamWellDataSet1.BeamWell.NewRow();
                nr.wellname = "";
                beamWellDataSet1.BeamWell.Rows.Add(nr);
                
                
            }
            else
            {
                beamWellTableAdapter1.FillByWellName(beamWellDataSet1.BeamWell, wellname);
                BeamWellDataSet.BeamWellRow nr = (BeamWellDataSet.BeamWellRow) beamWellDataSet1.BeamWell.Rows[0];

                try
                {
                    rbxCasingVelveOpenYes.Checked = (nr.Casing_Valve_Open == "Y");
                }
                catch (global::System.Data.StrongTypingException e)
                {
                    rbxCasingVelveOpenNo.Checked = true;
                }

                try
                {
                    rbxUseFluidInertiaYes.Checked = (nr.Use_Fluid_Insertia_For_Analysis == "Y");
                }
                catch (global::System.Data.StrongTypingException e)
                {
                    rbxUseFluidInertiaNo.Checked = true;
                }

            }

            if (showed) ShowDialog();
        }

        private void FormBeamWell_Load(object sender, EventArgs e)
        {
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            bindingSource1.EndEdit();

            BeamWellDataSet.BeamWellRow nr = (BeamWellDataSet.BeamWellRow)beamWellDataSet1.BeamWell.Rows[0];
            nr.Casing_Valve_Open = (rbxCasingVelveOpenYes.Checked) ? "Y" : "N";
            nr.Use_Fluid_Insertia_For_Analysis = (rbxUseFluidInertiaYes.Checked) ? "Y" : "N";

            beamWellTableAdapter1.Update(beamWellDataSet1.BeamWell);

            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
