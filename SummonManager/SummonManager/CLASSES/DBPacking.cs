using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace SummonManager
{
    class DBPacking :DB
    {
        public DBPacking() { }

        public DataTable GetAll()
        {
            DA.SelectCommand.CommandText = "select * from " + Base.BaseName + "..PACKINGLIST";
            DA.Fill(DS, "t");
            return DS.Tables["t"];
        }
        public void AddNew(string p)
        {
            DA.InsertCommand.CommandText = "insert into " + Base.BaseName + "..PACKINGLIST (PNAME) values ('" + p + "')";
            DA.InsertCommand.Connection.Open();
            DA.InsertCommand.ExecuteNonQuery();
            DA.InsertCommand.Connection.Close();
        }
        internal string Get(string p)
        {
            DA.SelectCommand.CommandText = "select * from " + Base.BaseName + "..PACKINGLIST where ID = " + p;
            DA.Fill(DS, "t");
            return DS.Tables["t"].Rows[0]["PNAME"].ToString();
        }
        internal void Edit(string p, string id)
        {
            DA.UpdateCommand.CommandText = "update " + Base.BaseName + "..PACKINGLIST set PNAME  = '" + p + "'" +
                                            " where ID = " + id;
            DA.UpdateCommand.Connection.Open();
            DA.UpdateCommand.ExecuteNonQuery();
            DA.UpdateCommand.Connection.Close();
        }
    }
}
