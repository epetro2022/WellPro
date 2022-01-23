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
using OPCAutomation;
using System.Collections;
namespace LowisChartApp.lw
{
    public partial class rw2 : DevExpress.XtraEditors.XtraUserControl
    {
        DB dbCon;
        frmMain frm;

        public OPCServer MyOPCServer = new OPCServer();
        public OPCGroup My_OPCGroup = null;
        public OPCGroup My_OPCGroupw = null;
        OPCItem MyOPCItem;
        OPCItem MyOPCItemw;
        int[] MyServerHandles = new int[200];
        int[] MyServerHandlesw = new int[200];
        object[] MyValues = new object[200];
        object[] MyValuesw = new object[200];
        public Array MyErrors;
        int rowgrid = 0;

         
        public rw2()
        {
            InitializeComponent();
            dbCon = new DB(Globals.getstringco());





            if (Globals.ForeignKey.Trim().Length > 0)
            {
                fillgrid("0", 0, 0, txtfunction.Text,0);
            }
            else 
            {
                MessageBox.Show("Please select the well name ");
            }





        }

        private void My_OPCGroup_DataChange(int TransactionID, int NumItems, ref Array ClientHandles, ref Array ItemValues, ref Array Qualities, ref Array TimeStamps)
        {
             
            for (int i = 1; i <= NumItems; i++)
            {
                int iHandles = int.Parse(ClientHandles.GetValue(i).ToString());
                dataOPC.Rows[iHandles - 1].Cells[3].Value = ItemValues.GetValue(i).ToString();
            }

             
        }

        private void My_OPCGroup_AsyncReadComplete(int TransactionID, int NumItems, ref Array ClientHandles, ref Array ItemValues, ref Array Qualities, ref Array TimeStamps, ref Array Errors)
        {
            // txtReadVal.Text = ItemValues.GetValue(1).ToString();
            //dataOPC.Rows[rowgrid].Cells[2].Value = ItemValues.Length.ToString();// ItemValues.GetValue(1).ToString();
        }

        private void My_OPCGroup_AsyncWriteComplete(int TransactionID, int NumItems, ref System.Array ClientHandles, ref System.Array Errors)
        {
        }




        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            fillgrid("1",0,0,txtfunction.Text,0);
        }
        void fillgrid(string parame,int mulai,int akhir,string fungsi,int bacaopc)
        {
            string current = lblCurrent.Text;
            lblCurrent.Text = parame;
            try
            {
                dbCon.clearCache();
                Dictionary<string, object> paras = new Dictionary<string, object>();
                paras.Add("@param", parame);
                paras.Add("@mulai", mulai);
                paras.Add("@akhir", akhir);
                paras.Add("@sin", fungsi);
                paras.Add("@wellname", Globals.ForeignKey);
                DataSet ds = dbCon.execprosedure("dbo.[spgetparamcon]", paras);

                dataOPC.Rows.Clear();
                dataOPC.Enabled = true;
                int i = 0, indeks = 1;
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    string itemName = dr["description"].ToString();
                    string functionname = dr["colfunction"].ToString().Trim();
                    string hostdb = dr["host_value"].ToString();

                    dataOPC.Rows.Add();

                    dataOPC.Rows[i].Cells[0].Value = itemName;
                    dataOPC.Rows[i].Cells[1].Value = dr["param"].ToString();
                    dataOPC.Rows[i].Cells["colfunction"].Value = dr["colfunction"].ToString();
                    dataOPC.Rows[i].Cells["colhost"].Value = hostdb;
                    dataOPC.Rows[i].Cells["colrtu"].Value = "...";
                    i += 1;
                    indeks += 1;
                }

            }
            catch (Exception ex)
            {

            }
            //if (current != lblCurrent.Text)
            //{
            if (bacaopc > 0)
            {
                if (current != "0" && lblOPC.Text != "0")
                {
                   
                    My_OPCGroup.IsSubscribed = false;
                    My_OPCGroup.IsActive = false;
                    MyOPCServer.OPCGroups.RemoveAll();
                }
                try
                {
                    lblOPC.Text = "1";
                    MyOPCServer.Connect("asi.OPC", "127.0.0.1");
                    My_OPCGroup = MyOPCServer.OPCGroups.Add("MyOPCGroup");
                    My_OPCGroup.IsActive = true;
                    My_OPCGroup.IsSubscribed = true;
                    My_OPCGroup.UpdateRate = 1000;    //1 second
                    My_OPCGroup.DataChange += new DIOPCGroupEvent_DataChangeEventHandler(My_OPCGroup_DataChange);
                    My_OPCGroup.AsyncWriteComplete += new DIOPCGroupEvent_AsyncWriteCompleteEventHandler(My_OPCGroup_AsyncWriteComplete);
                    My_OPCGroup.AsyncReadComplete += new DIOPCGroupEvent_AsyncReadCompleteEventHandler(My_OPCGroup_AsyncReadComplete);
                    //btnConnect.Enabled = false;
                    //btnDisconnect.Enabled = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error Connect! \r\n" + ex.Message);
                }
                //}

                // My_OPCGroup.IsActive = true;
                int rowg = 1;
                foreach (DataGridViewRow row in dataOPC.Rows)
                {
                    if (row.Cells["colfunction"].Value != null)
                    {
                        string str1 = row.Cells["colfunction"].Value.ToString();
                        string str2 = rowg.ToString();// row.Cells["coladdress"].Value.ToString();

                        MyOPCItem = My_OPCGroup.OPCItems.AddItem(str1, int.Parse(str2));
                        MyServerHandles[int.Parse(str2)] = MyOPCItem.ServerHandle;

                        rowg += 1;
                    }
                }

                //  My_OPCGroup.IsActive = false;
            }

        }
        private void button3_Click(object sender, EventArgs e)
        {
           // fillgrid(lblCurrent.Text,0,0);

            try
            {
               
                if (lblCurrent.Text == "0")
                {
                    fillgrid("1", int.Parse(txtmulai.Text), int.Parse(txtakhir.Text), txtfunction.Text, 1);
                }
                else
                {
                    fillgrid(lblCurrent.Text, int.Parse(txtmulai.Text), int.Parse(txtakhir.Text), txtfunction.Text, 1);
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("start and end address must be integer");
            }


            //My_OPCGroup.IsActive = true;
            ////if (My_OPCGroup.OPCItems.Count > 0)
            ////{
            ////    My_OPCGroup.OPCItems.Remove(1, MyServerHandles, out MyErrors);
            ////} 
            //MyOPCItem = My_OPCGroup.OPCItems.AddItem("Simulation Examples.Functions.User1", 1);
            //MyServerHandles[1] = MyOPCItem.ServerHandle;
            //MyOPCItem = My_OPCGroup.OPCItems.AddItem("Simulation Examples.Functions.User2", 2);
            //MyServerHandles[2] = MyOPCItem.ServerHandle;
            //MyOPCItem = My_OPCGroup.OPCItems.AddItem("Simulation Examples.Functions.User3", 3);
            //MyServerHandles[3] = MyOPCItem.ServerHandle;
            //MyOPCItem = My_OPCGroup.OPCItems.AddItem("Simulation Examples.Functions.User4", 4);
            //MyServerHandles[4] = MyOPCItem.ServerHandle;
            //MyOPCItem = My_OPCGroup.OPCItems.AddItem("Channel1.Device1.Tag2", 5);
            //MyServerHandles[5] = MyOPCItem.ServerHandle;
            //My_OPCGroup.IsActive = false;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            dbCon.clearCache();
            //    MyValues[5] = DateTime.Now.Second.ToString();
            //    int transID;
            //    My_OPCGroup.AsyncWrite(5, MyServerHandles, MyValues, out MyErrors, DateTime.Now.Second, out transID);
            foreach (DataGridViewRow row in dataOPC.Rows)
            {
                if (row.Cells["colfunction"].Value != null)
                {
                    if (row.Cells["colrtu"].Value != null)
                    {
                        string straddress = row.Cells["coladdress"].Value.ToString();

                        string strhost = String.Empty;
                        if (row.Cells["colhost"].Value != null)
                        {
                            strhost = row.Cells["colhost"].Value.ToString();
                        }
                        string strrtu = row.Cells["colrtu"].Value.ToString();

                        Dictionary<string, object> paras = new Dictionary<string, object>();
                        paras.Add("@address", straddress);
                        paras.Add("@nilaih", strhost);
                        paras.Add("@nilair", strrtu);
                        paras.Add("@by", "admin");
                        paras.Add("@wellname", Globals.ForeignKey);
                        dbCon.execprosedureinup("spwritehost", paras);
                    }
                    else
                    {
                        MessageBox.Show("please klik button read first");
                        return;
                        
                        
                    }
                }
            }
           
                fillgrid(lblCurrent.Text, int.Parse(txtmulai.Text), int.Parse(txtakhir.Text), txtfunction.Text, 0);
               
            MessageBox.Show("Data Submit successfully");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int rowcount = 1;
            foreach (DataGridViewRow row in dataOPC.Rows)
            {
                if (row.Cells["colhost"].Value != null)
                {
                   // string straddress = row.Cells["coladdress"].Value.ToString();
                    string strhost = row.Cells["colhost"].Value.ToString();
                   // string strrtu = row.Cells["colrtu"].Value.ToString();
                   // MyValues[rowcount] = strhost;
                    if(row.Cells["colhost"].Style.BackColor==System.Drawing.Color.Yellow)
                    {
                        MyValues[rowcount] = strhost;
                        
                      //  MyServerHandles[rowcount] = MyOPCItem.ServerHandle;
                       int transID;
                       My_OPCGroup.AsyncWrite(rowcount, MyServerHandles, MyValues, out MyErrors, DateTime.Now.Second, out transID);
                    }


                }
                rowcount += 1;
            }
            

            // MyValues[6] = "22212";

            MessageBox.Show("Data Submit successfully");

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            fillgrid("2",0,0, txtfunction.Text,0);
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           // fillgrid("3");
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            fillgrid("4",0,0, txtfunction.Text,0);
        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            fillgrid("5",0,0, txtfunction.Text,0);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataOPC.Rows)
            {
                if (row.Cells["colfunction"].Value != null)
                {
                    string str1 = row.Cells["colrtu"].Value.ToString();
                    // string str2 = row.Cells["coladdress"].Value.ToString();


                    row.Cells["colhost"].Value = str1;

                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                fillgrid("100", int.Parse(txtmulai.Text), int.Parse(txtakhir.Text), txtfunction.Text,1);
            }
            catch(Exception exc)
            {
                MessageBox.Show("start and end address must be integer");
            }
        }
    }
}
