using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace SummonManager
{
    class DBPayStatus:DB
    {
        public DBPayStatus() { }

        public DataTable GetAllStatus()
        {
            DA.SelectCommand.CommandText = "select * from " + Base.BaseName + "..PAYSTATUS order by ID";
            DS = new DataSet();
            DA.Fill(DS, "t");
            return DS.Tables["t"];
        }
        public string GetStatusByID(string id)
        {
            DA.SelectCommand.CommandText = "select SNAME from " + Base.BaseName + "..PAYSTATUS where ID = " + id;
            DS = new DataSet();
            DA.Fill(DS, "t");
            return DS.Tables["t"].Rows[0]["SNAME"].ToString();
        }
    }
}
