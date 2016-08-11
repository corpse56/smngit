using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SummonManager.CLASSES.IRole_namespace;
using System.Windows.Forms;
using SummonManager.CLASSES;



namespace SummonManager
{

    public class UVO_SIMPLEINZH  :  IRole
    {


        public override string GetRoleName()
        {
            return "Инженер";
        }

        public override void ssLoad(ShowSummon ss)
        {
            DisableAbsolute(ss);
            LoadSummon(ss);
            EnableInitial(ss);
        }


        public override void EnableInitial(ShowSummon ss)
        {
            ss.summonTransfer1.Enabled = false;
            ss.summonTransfer1.Enabled = false;
            ss.bEditWP.Enabled = true;

        }
        public override void EnableEdit(ShowSummon ss)
        {
            //EnableAll(ss);
        }
        private void EnableAll(ShowSummon ss)
        {
            //ss.bEdit.Enabled = false;
           // ss.bSave.Enabled = true;

        }
        public override void MyRemarksWP(DataGridView dgWP)
        {
            foreach (DataGridViewRow r in dgWP.Rows)
            {
                if (r.Cells["CLOSED"].Value.ToString() == "Открыто")
                {
                    if ((r.Cells["DOCUMENTNAME"].Value.ToString() != "TECHREQ") &&
                        (r.Cells["DOCUMENTNAME"].Value.ToString() != "COMPOSITION") &&
                        (r.Cells["DOCUMENTNAME"].Value.ToString() != "CONFIGURATION"))
                    {
                        r.Visible = false;
                    }
                    else
                    {
                        r.Visible = true;
                    }
                }
                else
                {
                    r.Visible = false;
                }
            }
        }
        public override bool IsMyWPRemark(string DOCNAME)
        {
            return ((DOCNAME != "TECHREQ") &&
                   (DOCNAME != "COMPOSITION") &&
                   (DOCNAME != "CONFIGURATION")) ? false : true;

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
