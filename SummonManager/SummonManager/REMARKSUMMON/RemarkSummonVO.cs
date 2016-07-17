using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SummonManager.CLASSES;

namespace SummonManager
{
    public class RemarkSummonVO
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

        public RemarkSummonVO()
        {

        }
        public static RemarkSummonVO RemarkVOByID(string id)
        {
            return new DBRemarkSUMMON().GetRemarkByID(id);
        }

        public static RemarkSummonVO RemarkVOByID(string IDWP, string DOCUMENTNAME)
        {
            return new DBRemarkSUMMON().GetRemarkByIDWPDOC(DOCUMENTNAME, IDWP);
        }





    }
}
