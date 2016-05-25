using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace SummonManager
{
    public class DB
    {
        public SqlDataAdapter DA;
        public DataSet DS;
        //SqlConnection Con;
        public DB()
        {
            DA = new SqlDataAdapter();
            DA.SelectCommand = new SqlCommand();
            DA.SelectCommand.Connection = new SqlConnection(MainF.ConnectionString);
            DA.UpdateCommand = new SqlCommand();
            DA.UpdateCommand.Connection = new SqlConnection(MainF.ConnectionString);
            DA.InsertCommand = new SqlCommand();
            DA.InsertCommand.Connection = new SqlConnection(MainF.ConnectionString);
            DA.DeleteCommand = new SqlCommand();
            DA.DeleteCommand.Connection = new SqlConnection(MainF.ConnectionString);
            DS = new DataSet();
        }
    }
}
