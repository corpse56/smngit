using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SummonManager.CLASSES.IRole_namespace;
using System.Windows.Forms;
using SummonManager.CLASSES;



namespace SummonManager
{

    public class UVO_SCHEM  :  IRole
    {


        public override string GetRoleName()
        {
            return "Схемотехник";
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
            if (ss.SVO.WPTYPE == "WPNAMELIST")
            {
                ss.bEditWP.Enabled = true;
            }
        }
        public override void EnableEdit(ShowSummon ss)
        {
           // EnableAll(ss);
        }
        private void EnableAll(ShowSummon ss)
        {
            //ss.bEdit.Enabled = false;
            //ss.bSave.Enabled = true;

        }
        public override void MyRemarksWP(DataGridView dgWP)
        {
            foreach (DataGridViewRow r in dgWP.Rows)
            {
                if ((r.Cells["DOCUMENTNAME"].Value.ToString() != "WIRINGDIAGRAM"))
                {
                    r.Visible = false;
                }
                else
                {
                    r.Visible = true;
                }
                //r.Visible = !((r.Cells["DOCUMENTNAME"].Value.ToString() != "WIRINGDIAGRAM"));
            }
        }

    }
}
