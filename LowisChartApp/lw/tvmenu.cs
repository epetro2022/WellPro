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
    public partial class tvmenu : Form
    {
        public string parentname, parentid, currentid, currentname,status;

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public tvmenu()
        {
            InitializeComponent();
        }

        private void tvmenu_Load(object sender, EventArgs e)
        {
            lblID.Text = currentid;
            lblParentID.Text = parentid;
            txtMenuName.Text = currentname;
            txtParentName.Text = parentname;
            if(status=="0")
            {
                lbljudul.Text = "Add New TreeView Menu";
            }
            else
            {
                lbljudul.Text = "Edit TreeView Menu";
            }
        }
    }
}
