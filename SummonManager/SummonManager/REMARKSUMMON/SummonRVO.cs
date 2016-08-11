using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SummonManager.CLASSES;
using System.Data;

namespace SummonManager
{
    public class SummonRVO
    {
        public string ID;
        public string IDSUMMON;
        public string DOCUMENTNAME;
        public DateTime DATEREMARK;
        public string IDCREATOR;
        public string REMARK;
        public bool CLOSED;
        public string CLOSINGCOMMENT;
        public DateTime DATECLOSE;
        public string IDCLOSER;

        public SummonRVO()
        {

        }
        public static SummonRVO RemarkVOByID(string id)
        {
            return new DBRemarkSUMMON().GetRemarkByID(id);
        }

        public static DataTable RemarkVOByID(string IDSUMMON, string DOCUMENTNAME)
        {
            return new DBRemarkSUMMON().GetRemarksByIDSDOC(DOCUMENTNAME, IDSUMMON);
        }





    }
}
