using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SummonManager.CLASSES;

namespace SummonManager
{
    public class WP_RVO
    {
        public string ID;
        public string IDWP;
        public string DOCUMENTNAME;
        public DateTime DATEREMARK;
        public string IDCREATOR;
        public string REMARK;
        public bool CLOSED;
        public string CLOSINGCOMMENT;
        public DateTime DATECLOSE;
        public string IDCLOSER;

        public WP_RVO()
        {

        }
        public static WP_RVO RemarkVOByID(string id)
        {
            return new DBRemarkWP().GetRemarkByID(id);
        }

        public static WP_RVO RemarkVOByID(string IDWP,string DOCUMENTNAME)
        {
            return new DBRemarkWP().GetRemarkByIDWPDOC(DOCUMENTNAME,IDWP);
        }





    }
}
