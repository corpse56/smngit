using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SummonManager.CLASSES.IRole_namespace;
using System.Windows.Forms;
using SummonManager.CLASSES;



namespace SummonManager
{

    public class UVO_DIRECTOR  :  IRole
    {


        public override string GetRoleName()
        {
            return "Директор";
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
        }
        public override void EnableEdit(ShowSummon ss)
        {
            EnableAll(ss);
        }
        private void EnableAll(ShowSummon ss)
        {

        }
        public override void MyRemarksWP(DataGridView dgWP)
        {
            foreach (DataGridViewRow r in dgWP.Rows)
            {
                r.Visible = false;
            }
        }
    }
}
