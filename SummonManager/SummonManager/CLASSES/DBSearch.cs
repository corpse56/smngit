using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace SummonManager
{
    class DBSearch : DB
    {
        public DBSearch() { }

        public DataTable GetSearchResults(int IDWPName, string Contract, DateTime start, DateTime end, bool dates)
        {
            DA.SelectCommand.Parameters.Add("idwp", SqlDbType.Int);
            DA.SelectCommand.Parameters.Add("contr", SqlDbType.NVarChar);
            DA.SelectCommand.Parameters.Add("start", SqlDbType.DateTime);
            DA.SelectCommand.Parameters.Add("end", SqlDbType.DateTime);

            DA.SelectCommand.Parameters["idwp"].Value = IDWPName;
            DA.SelectCommand.Parameters["contr"].Value = Contract;
            DA.SelectCommand.Parameters["start"].Value = start.Date;
            DA.SelectCommand.Parameters["end"].Value = end.Date;

            DA.SelectCommand.CommandText = "select * from " + Base.BaseName + "..SEARCHVIEW where 1=1 ";

            if (IDWPName != -1)
            {
                DA.SelectCommand.Parameters["idwp"].Value = IDWPName;
                DA.SelectCommand.CommandText += " and idwp = @idwp ";
            }
            if (Contract != "-1")
            {
                DA.SelectCommand.Parameters["contr"].Value = Contract;
                DA.SelectCommand.CommandText += " and contr like '%'+@contr+'%' ";
            }
            if (dates)
            {
                DA.SelectCommand.Parameters["start"].Value = start.Date;
                DA.SelectCommand.Parameters["end"].Value = end.Date;

                DA.SelectCommand.CommandText += " and cast(cast(cre as nvarchar(11)) as datetime) between @start and @end ";
            }
            DA.SelectCommand.CommandText += " order by ids";
            int i = DA.Fill(DS, "t");
            return DS.Tables["t"];
        }
    }
}
