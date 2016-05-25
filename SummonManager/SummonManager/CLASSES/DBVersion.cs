using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SummonManager.CLASSES
{
    class DBVersion : DB
    {
        public DBVersion() { }

        public int GetVersionNumber()
        {
            DA.SelectCommand.CommandText = "select [VERSIONNUMBER] from " + Base.BaseName + "..[VERSIONINFO]";
            try
            {
                DA.Fill(DS, "t");
            }
            catch
            {
                return -1;
            }
            return (int)DS.Tables["t"].Rows[0][0];
        }

        internal void UpdateVersion(int LastVersion)
        {
            DA.UpdateCommand.CommandText = "update " + Base.BaseName + "..VERSIONINFO set [VERSIONNUMBER]  = "+LastVersion;
            DA.UpdateCommand.Connection.Open();
            DA.UpdateCommand.ExecuteNonQuery();
            DA.UpdateCommand.Connection.Close();
        }
    }
}
