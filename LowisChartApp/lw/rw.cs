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
    public partial class rw : DevExpress.XtraEditors.XtraUserControl
    {
        
        public OPCServer MyOPCServer = new OPCServer();
        public OPCGroup My_OPCGroup = null;
        OPCItem MyOPCItem;
        int[] MyServerHandles = new int[200];
        object[] MyValues = new object[200];
        public Array MyErrors;
        int rowgrid = 0;

     
        public partial struct strOPCServer
        {
            public OPCServer MyServer;
            public object MyGroup;
            public OPCItem MyItem;
            public Array ServerHandles;
            public Array Errors;
            public Array Values;
            public int MonCount;
        }

        public partial struct strcMonItem
        {
            public int _Server;
            public string _Name;
            public object _Value;
            public int _Index;
            public object _ServerHandles;
        }

        public strcMonItem[] MonItem;
        public rw()
        {
            InitializeComponent();

        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                MyOPCServer.Connect(txtServerName.Text, txtServer.Text);
                My_OPCGroup = MyOPCServer.OPCGroups.Add("MyOPCGroup");
                My_OPCGroup.IsActive = true;
                My_OPCGroup.IsSubscribed = true;
                My_OPCGroup.UpdateRate = 1000;    //1 second
                My_OPCGroup.DataChange += new DIOPCGroupEvent_DataChangeEventHandler(My_OPCGroup_DataChange);
                My_OPCGroup.AsyncWriteComplete += new DIOPCGroupEvent_AsyncWriteCompleteEventHandler(My_OPCGroup_AsyncWriteComplete);
                My_OPCGroup.AsyncReadComplete += new DIOPCGroupEvent_AsyncReadCompleteEventHandler(My_OPCGroup_AsyncReadComplete);
                btnConnect.Enabled = false;
                btnDisconnect.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Connect! \r\n" + ex.Message);
            }
        }

        private void My_OPCGroup_DataChange(int TransactionID, int NumItems, ref Array ClientHandles, ref Array ItemValues, ref Array Qualities, ref Array TimeStamps)
        {
            //txtReadVal.Text = ItemValues.GetValue(1).ToString();
            for(int i=1; i<=NumItems; i++)
            {
                int iHandles = int.Parse( ClientHandles.GetValue(i).ToString());
                dataOPC.Rows[iHandles-1].Cells[3].Value = string.Join(",", ItemValues.GetValue(i).ToString());
              string lts= string.Join(",", ItemValues.GetValue(i).ToString());
            }

            //if (ItemValues.Length == 1)
            //{
            //    dataOPC.Rows[1].Cells[3].Value = ItemValues.GetValue(1).ToString();
            //}
            //else if (ItemValues.Length == 2)
            //{
            //    dataOPC.Rows[1].Cells[3].Value = ItemValues.GetValue(1).ToString();
            //    dataOPC.Rows[2].Cells[3].Value = ItemValues.GetValue(2).ToString();
            //}
            //else if (ItemValues.Length == 3)
            //{
            //    dataOPC.Rows[1].Cells[3].Value = ItemValues.GetValue(1).ToString();
            //    dataOPC.Rows[2].Cells[3].Value = ItemValues.GetValue(2).ToString();
            //    dataOPC.Rows[3].Cells[3].Value = ItemValues.GetValue(3).ToString();
            //}
        }

        private void My_OPCGroup_AsyncReadComplete(int TransactionID, int NumItems, ref Array ClientHandles, ref Array ItemValues, ref Array Qualities, ref Array TimeStamps, ref Array Errors)
        {
            // txtReadVal.Text = ItemValues.GetValue(1).ToString();
            //dataOPC.Rows[rowgrid].Cells[2].Value = ItemValues.Length.ToString();// ItemValues.GetValue(1).ToString();
        }

        private void My_OPCGroup_AsyncWriteComplete(int TransactionID, int NumItems, ref System.Array ClientHandles, ref System.Array Errors)
        {
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            My_OPCGroup.IsSubscribed = false;
            My_OPCGroup.IsActive = false;
            MyOPCServer.OPCGroups.RemoveAll();
            btnDisconnect.Enabled = false;
            btnConnect.Enabled = true;
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            My_OPCGroup.IsActive = true;
            //if (My_OPCGroup.OPCItems.Count > 0)
            //{
            //    My_OPCGroup.OPCItems.Remove(1, MyServerHandles, out MyErrors);
            //} 
            MyOPCItem = My_OPCGroup.OPCItems.AddItem(txtItem.Text, 1);
            MyServerHandles[1] = MyOPCItem.ServerHandle;
            //MyOPCItem = My_OPCGroup.OPCItems.AddItem("Simulation Examples.Functions.User2", 2);
            //MyServerHandles[2] = MyOPCItem.ServerHandle;
            //MyOPCItem = My_OPCGroup.OPCItems.AddItem("Simulation Examples.Functions.User3", 3); 
            //MyServerHandles[3] = MyOPCItem.ServerHandle;
            //MyOPCItem = My_OPCGroup.OPCItems.AddItem("Simulation Examples.Functions.User4", 4);
            //MyServerHandles[4] = MyOPCItem.ServerHandle;
           // My_OPCGroup.IsActive = false;

        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            int transID;
            My_OPCGroup.AsyncRead(1, MyServerHandles, out MyErrors, DateTime.Now.Second, out transID);


            //     MyOPCGroup(iOPC).AsyncRead(numItems, MyOPCServer(iOPC).ServerHandles, MyOPCServer(iOPC).Errors, Second(Now), Second(Now))

            //MyOPCGroup(iOPC).AsyncRead(numItems, MyOPCServer(iOPC).ServerHandles, MyOPCServer(iOPC).Errors, Second(Now), Second(Now))

            //   MyOPCGroup(iOPC).AsyncRead(numItems, MyOPCServer(iOPC).ServerHandles, MyOPCServer(iOPC).Errors, Second(Now), Second(Now))
        }

        private void btnWrite_Click(object sender, EventArgs e)
        {
            MyValues[1] = txtWriteVal.Text;
            int transID;
            My_OPCGroup.AsyncWrite(1, MyServerHandles, MyValues, out MyErrors, DateTime.Now.Second, out transID);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            object LocalServer;
            LocalServer = MyOPCServer.GetOPCServers(txtServer.Text);
            // lstOPCServer.Nodes.Clear();
            foreach (var tmp in (IEnumerable)LocalServer)
            {
                string insta = tmp.ToString();
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                dataOPC.Enabled = true;
                var indeks =1;
                for (int i=0; i<20; i++)
                {
                    string itemName = "item name" + i.ToString();
                   
                     
                    dataOPC.Rows.Add();
                    dataOPC.Rows[i].Cells[0].Value = indeks.ToString();
                    dataOPC.Rows[i].Cells[1].Value = itemName;
                    indeks += 1;
                }    
          
            }
            catch (Exception ex)
            {
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
            foreach (DataGridViewRow row in dataOPC.Rows)
            {
                string opcs = row.Cells[1].Value.ToString();
                rowgrid += 1;
                //More code here
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("name");

            for (int j = 0; j < 10; j++)

            {

                dt.Rows.Add("");

            }

            this.dataGridView1.DataSource = dt;

            this.dataGridView1.Columns[0].Width = 200;



            /*

             * First method : Convert to an existed cell type such ComboBox cell,etc

             */



            DataGridViewComboBoxCell ComboBoxCell = new DataGridViewComboBoxCell();

            ComboBoxCell.Items.AddRange(new string[] { "aaa", "bbb", "ccc" });

            this.dataGridView1[0, 0] = ComboBoxCell;

            this.dataGridView1[0, 0].Value = "bbb";



            DataGridViewTextBoxCell TextBoxCell = new DataGridViewTextBoxCell();

            this.dataGridView1[0, 1] = TextBoxCell;

            this.dataGridView1[0, 1].Value = "some text";



            DataGridViewCheckBoxCell CheckBoxCell = new DataGridViewCheckBoxCell();

            CheckBoxCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            this.dataGridView1[0, 2] = CheckBoxCell;

            this.dataGridView1[0, 2].Value = true;



            /*

             * Second method : Add control to the host in the cell

             */

            DateTimePicker dtp = new DateTimePicker();

            dtp.Value = DateTime.Now.AddDays(-10);

            //add DateTimePicker into the control collection of the DataGridView

            this.dataGridView1.Controls.Add(dtp);

            //set its location and size to fit the cell

            dtp.Location = this.dataGridView1.GetCellDisplayRectangle(0, 3, true).Location;

            dtp.Size = this.dataGridView1.GetCellDisplayRectangle(0, 3, true).Size;
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
