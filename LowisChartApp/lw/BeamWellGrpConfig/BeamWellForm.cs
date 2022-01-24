using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LowisChartApp.ds.BeamWellGroupConfiguration.BeamWellDataSetTableAdapters;
using LowisChartApp.ds.BeamWellGroupConfiguration;
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
                beam_Well_Group_ConfigurationTableAdapter1.FillByNone(beamWellDataSet1.Beam_Well_Group_Configuration);
                //beamWellTableAdapter1.FillByNone(beamWellDataSet1.BeamWell);

                BeamWellDataSet.Beam_Well_Group_ConfigurationRow nr = (BeamWellDataSet.Beam_Well_Group_ConfigurationRow)beamWellDataSet1.Beam_Well_Group_Configuration.NewRow();
                //BeamWellDataSet.BeamWellRow nr = (BeamWellDataSet.BeamWellRow) beamWellDataSet1.BeamWell.NewRow();
                nr.LWNAME = "";
                beamWellDataSet1.Beam_Well_Group_Configuration.Rows.Add(nr);
                //beamWellDataSet1.BeamWell.Rows.Add(nr);
                
                
            }
            else
            {
                beam_Well_Group_ConfigurationTableAdapter1.FillByName(beamWellDataSet1.Beam_Well_Group_Configuration,  wellname);
                //beamWellTableAdapter1.FillByWellName(beamWellDataSet1.BeamWell, wellname);
                BeamWellDataSet.Beam_Well_Group_ConfigurationRow nr = (BeamWellDataSet.Beam_Well_Group_ConfigurationRow) beamWellDataSet1.Beam_Well_Group_Configuration.Rows[0];
                //BeamWellDataSet.BeamWellRow nr = (BeamWellDataSet.BeamWellRow) beamWellDataSet1.BeamWell.Rows[0];

                try
                {
                    rbxCasingVelveOpenYes.Checked = (nr.CasingValveOpen == "Y");
                }
                catch (global::System.Data.StrongTypingException e)
                {
                    rbxCasingVelveOpenNo.Checked = true;
                }

                try
                {
                    rbxUseFluidInertiaYes.Checked = (nr.FluidInertiaforAna == "Y");
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
            Validate();
            bindingSource1.EndEdit();

            BeamWellDataSet.Beam_Well_Group_ConfigurationRow nr = (BeamWellDataSet.Beam_Well_Group_ConfigurationRow) beamWellDataSet1.Beam_Well_Group_Configuration.Rows[0];
            //BeamWellDataSet.BeamWellRow nr = (BeamWellDataSet.BeamWellRow)beamWellDataSet1.BeamWell.Rows[0];
            nr.CasingValveOpen = (rbxCasingVelveOpenYes.Checked) ? "Y" : "N";
            nr.FluidInertiaforAna = (rbxUseFluidInertiaYes.Checked) ? "Y" : "N";

            beam_Well_Group_ConfigurationTableAdapter1.Update(beamWellDataSet1.Beam_Well_Group_Configuration);

            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
