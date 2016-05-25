using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SummonManager.CLASSES.IRole_namespace;
using System.Windows.Forms;
using SummonManager.CLASSES;



namespace SummonManager
{

    public class UVO_MONT  :  IRole
    {


        public override string GetRoleName()
        {
            return "Монтажный отдел";
        }

        public override void ssLoad(ShowSummon ss)
        {
            DBSummon dbs = new DBSummon();

            if ((ss.SVO.IDSTATUS == 15) || (ss.SVO.IDSTATUS == 18) || (ss.SVO.IDSUBST == 15) || (ss.SVO.IDSUBST == 18))
            {
                dbs.SetViewed(ss.SVO.ID);
            }
            DisableAbsolute(ss);
            LoadSummon(ss);
            EnableInitial(ss);
        }


        public override void EnableInitial(ShowSummon ss)
        {
            ss.summonTransfer1.Enabled = true;
            ss.summonTransfer1.Enabled = true;
            //ss.bEditWP.Enabled = true;
        }
        public override void EnableEdit(ShowSummon ss)
        {
            //EnableAll(ss);
        }
        private void EnableAll(ShowSummon ss)
        {
            //ss.bEdit.Enabled = false;
            //ss.bSave.Enabled = true;

        }

    }
}
