using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace SummonManager
{
    class DBAccept:DB
    {
        public DBAccept()        {        }

        public DataTable GetAllAccept()
        {
            DA.SelectCommand.CommandText = "select * from " + Base.BaseName + "..ACCEPTLIST";
            DA.Fill(DS, "t");
            return DS.Tables["t"];
        }
    }
}
