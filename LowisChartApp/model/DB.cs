using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace LowisChartApp.model
{
    public class DB
    {
        SqlConnection Conn = null;
        string constring = "";
        public DB(string _connstring)
        {
            constring = _connstring;
        }

        public void clearCache() {
            try
            {
                SqlDataAdapter adapter;
                this.open();
                SqlCommand command = new SqlCommand("DBCC FREEPROCCACHE", Conn);
                command.Dispose();
                this.close();
            }
            catch (Exception excep)
            {
                Console.WriteLine(excep.ToString());
                //return new DataSet();//DBNull.Value;
            }
            finally
            {
              
                if (Conn != null)
                {
                    Conn.Close();
                    Conn.Dispose();
                }
            }
        }

        public DataSet execprosedure(string spname, Dictionary<string, object> Param)
        {
            try
            {
                this.open();
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
                adapter.Dispose();
                command.Dispose();
                this.close();
                return ds;
            }
            catch (Exception excep)
            {
                Console.WriteLine(excep.ToString());
                return new DataSet();//DBNull.Value;
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
        public int execprosedureinup(string spname, Dictionary<string, object> Param)
        {
            try
            {
                this.open();
                
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

              
                SqlCommand command = new SqlCommand();

                DataSet ds = new DataSet();
                command.Connection = Conn;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = spname;
                if (command.Connection.State == ConnectionState.Closed)
                {
                    command.Connection.Open();
                }


                if (Param != null)
                {

                    foreach (KeyValuePair<string, object> param_item in Param)
                    {
                        command.Parameters.Add(new SqlParameter(param_item.Key, param_item.Value));
                    }

                }
                command.ExecuteNonQuery();
                //Dispose();
                //command.Connection.Close();
                //Dispose();
                //return 
                //adapter = new SqlDataAdapter(command);
                //adapter.Fill(ds);
                //adapter.Dispose();
                command.Dispose();
                this.close();
                return (int)command.Parameters["ReturnValue"].Value; 
            }
            catch (Exception excep)
            {
                Console.WriteLine(excep.ToString());
                return 0;//DBNull.Value;
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
