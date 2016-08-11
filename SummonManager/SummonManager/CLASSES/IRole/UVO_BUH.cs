using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SummonManager.CLASSES.IRole_namespace;
using System.Windows.Forms;
using SummonManager.CLASSES;



namespace SummonManager
{

    public class UVO_BUH  :  IRole
    {

        public override string GetRoleName()
        {
            return "Бухгалтерия";
        }

        public override void ssLoad(ShowSummon ss)
        {
            DBSummon dbs = new DBSummon();
            if (ss.SVO.IDSTATUS == 12)
            {

                dbs.SetViewed(ss.SVO.ID);
            }
            DisableAbsolute(ss);
            LoadSummon(ss);
            EnableInitial(ss);
        }


        public override void EnableInitial(ShowSummon ss)
        {
            ss.bEdit.Enabled = true;
            ss.summonTransfer1.Enabled = false;
            ss.summonTransfer2.Enabled = false;

        }
        public override void EnableEdit(ShowSummon ss)
        {
            EnableAll(ss);
        }
        private void EnableAll(ShowSummon ss)
        {
            ss.chbDocsRdy.Enabled = true;
            ss.chbBillPayed.Enabled = true;

            ss.bEdit.Enabled = false;
            ss.bSave.Enabled = true;
        }

        public override void MyRemarksWP(DataGridView dgWP)
        {
            foreach (DataGridViewRow r in dgWP.Rows)
            {
                r.Visible = false;
            }
        }
        public override bool IsMyWPRemark(string DOCNAME)
        {
            return false;
        }
        public override void MyRemarksSmm(DataGridView dgSumm)
        {
            foreach (DataGridViewRow r in dgSumm.Rows)
            {
                r.Visible = false;
            }
        }
        public override bool IsMySmmRemark(string DOCNAME)
        {
            return false;
        }	
    }
}
