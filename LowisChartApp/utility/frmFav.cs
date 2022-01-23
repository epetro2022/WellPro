using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LowisChartApp.utility;
using LowisChartApp.model;

namespace LowisChartApp.utility
{
    public partial class frmFav : Form
    {
        string namanode;
        DB dbCon;
        DataTable dt;
        TreeNode parentNode = null;
        public frmFav()
        {
            dbCon = new DB(Globals.getstringco());
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            MsgBox.SetLanguage(MsgBox.Language.English);
            //   DialogResult res = MsgBox.ShowDialog("Masukan nama node:",
            //"Textbox Nama Node",   //Text message (mandatory), Title (optional)
            //    MsgBox.Icon.Question, //Set icon type (default info)
            //    MsgBox.Buttons.OkCancel, //Set buttons (default ok)
            //    MsgBox.Type.TextBox, //Set type (default nothing)
            //    null, //String field as ComboBox items (default null)
            //    true, //Set visible in taskbar (default false)
            //    new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold)); ; ; //Set 
            DialogResult res = MsgBox.ShowDialog("Masukan nama node:", "Tambah Node",   //Text message (mandatory), Title (optional)
               MsgBox.Icon.Question,                                                                         //Set icon type Error/Exclamation/Question/Warning (default info)
               MsgBox.Buttons.OkCancel,                                                                      //Set buttons set OK/OKcancel/YesNo/YesNoCancel (default ok)
               MsgBox.Type.TextBox,                                                                         //Set type ComboBox/TextBox/Nothing (default nothing)
               new string[] { "Item1", "Item2", "Item3" },                                                        //Set string field as ComboBox items (default null)
               true,                                                                                           //Set visible in taskbar (default false)
               new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold));

            //Check InputBox result
            if (res == System.Windows.Forms.DialogResult.OK || res == System.Windows.Forms.DialogResult.Yes)
               namanode= MsgBox.ResultValue; //Get returned value

            TreeNode mainNode = new TreeNode();
            mainNode.Name = namanode;
            mainNode.Text = namanode;
            this.tvFav.Nodes.Add(mainNode);
        }

        private void frmFav_Load(object sender, EventArgs e)
        {
            tvFav.ImageList = imageList1;
            dbCon.clearCache();
            //gdLowis.DataSource = null;
            Dictionary<string, object> paras = new Dictionary<string, object>();
            paras = null;
            //paras.Add("@param", Globals.parameterid);
            //paras.Add("@id", Globals.idsp);
            DataSet ds = dbCon.execprosedure("dbo.[proc_getmenuparentfav]", paras);
            dt = new DataTable();
            dt = ds.Tables[0];
            foreach (DataRow dr in dt.Rows)

            {

                parentNode = tvFav.Nodes.Add(dr["mainmenu"].ToString());
                PopulateTreeView(Convert.ToInt32(dr["id_table"].ToString()), parentNode);


            }
        }
        private void PopulateTreeView(int parentId, TreeNode parentNode)
        {
            Dictionary<string, object> paras = new Dictionary<string, object>();
            //paras = null;
            paras.Add("@menuparval", parentId);
            //paras.Add("@id", Globals.idsp);
            DataSet ds = dbCon.execprosedure("dbo.[proc_getmenusubmenufav]", paras);
            DataTable dtchildc = new DataTable();
            dtchildc = ds.Tables[0];
            //dachildmnuc.Fill(dtchildc);
            TreeNode childNode;
            foreach (DataRow dr in dtchildc.Rows)

            {
                if (parentNode == null)
                    childNode = tvFav.Nodes.Add(dr["menusubmenu"].ToString());
                else
                    childNode = parentNode.Nodes.Add(dr["menusubmenu"].ToString());
                PopulateTreeView(Convert.ToInt32(dr["id_table"].ToString()), childNode);

            }
        }

        private void tvFav_ItemDrag(object sender, ItemDragEventArgs e)
        {
            string tmp="";
        }

        private void frmFav_DragEnter(object sender, DragEventArgs e)
        {
            string tmp = "";
        }

        private void frmFav_DragDrop(object sender, DragEventArgs e)
        {
            string tmp = "";
        }

        private void tvFav_DragDrop(object sender, DragEventArgs e)
        {
            string tmp = "";
        }

        private void frmFav_MouseDown(object sender, MouseEventArgs e)
        {
            string tmp = "";
        }
    }
}
