using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace SummonManager
{
    class DBMountingKit :DB
    {
        public DBMountingKit() { }

        public DataTable GetAllDBMountingKitNames()
        {
            DA.SelectCommand.CommandText = "select * from " + Base.BaseName + "..MOUNTINGKITLIST order by MOUNTINGKITNAME";
            DA.Fill(DS, "t");
            return DS.Tables["t"];
        }

        internal void AddNewMOUNTINGKIT(string p)
        {
            DA.InsertCommand.CommandText = "insert into " + Base.BaseName + "..MOUNTINGKITLIST (MOUNTINGKITNAME) values ('" + p + "')";
            DA.InsertCommand.Connection.Open();
            DA.InsertCommand.ExecuteNonQuery();
            DA.InsertCommand.Connection.Close();
        }

        internal string GetMOUNTINGKIT(string p)
        {
            DA.SelectCommand.CommandText = "select * from " + Base.BaseName + "..MOUNTINGKITLIST where ID = " + p;
            DA.Fill(DS, "t");
            return DS.Tables["t"].Rows[0]["MOUNTINGKITNAME"].ToString();
        }

        internal void EditMOUNTINGKIT(string p,string id)
        {
            DA.UpdateCommand.CommandText = "update " + Base.BaseName + "..MOUNTINGKITLIST set MOUNTINGKITNAME  = '" + p + "'" +
                                            " where ID = " + id;
            DA.UpdateCommand.Connection.Open();
            DA.UpdateCommand.ExecuteNonQuery();
            DA.UpdateCommand.Connection.Close();
        }

    }
}
