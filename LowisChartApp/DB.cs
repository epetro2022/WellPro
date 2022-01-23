using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace NaveBarExample.model
{
    public class DB
    {
        SqlConnection Conn = null;
        string constring = "";
        public DB(string _connstring)
        {
            constring = _connstring;
        }

        public DataSet execprosedure(string spname, Dictionary<string, object> Param)
        {
            try
            {
                open();
                //SqlCommand cmd = new SqlCommand(spname, Conn);
                //cmd.CommandType = CommandType.Text;
                /*if (paramsp.GetLength(0) > 0) {
                    int i = 0;
                    string tmp = "";
                    tmp = "@"+paramsp[i, 0];
                    for (i = 0; i < paramsp.GetLength(0); i++) {
                        
                        cmd.Parameters.AddWithValue(tmp, paramsp[i, 1]);
                    }
                }*/
                //SqlDataAdapter sda = new SqlDataAdapter();

                // sda.SelectCommand = cmd;

                //DataSet ds = new DataSet();
                //sda.Fill(ds, "cam");

                //cmd.ExecuteNonQuery();

                SqlDataAdapter adapter;
                SqlCommand command = new SqlCommand();

                DataSet ds = new DataSet();
                command.Connection = Conn;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = spname;

                if (Param != null)
                {

                    foreach (KeyValuePair<string, object> param_item in Param)
                    {
                        command.Parameters.Add(new SqlParameter(param_item.Key, param_item.Value));
                    }

                }

                adapter = new SqlDataAdapter(command);
                adapter.Fill(ds);
                close();
                return ds;
            }
            catch (Exception excep)
            {
                Console.WriteLine(excep.ToString());
                return null;
            }
            finally
            {
                /*if (MyReader != null)
                {
                    MyReader.Close();
                    MyReader.Dispose();
                }*/
                if (Conn != null)
                {
                    Conn.Close();
                    Conn.Dispose();
                }
            }
        }
        public void open()
        {
            Conn = new SqlConnection(constring);
        }
        public void close()
        {
            Conn.Close();
            Conn.Dispose();
        }
    }
}
