using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SummonManager.CLASSES.IRole_namespace;
using System.Windows.Forms;
using SummonManager.CLASSES;



namespace SummonManager
{

    public class UVO_OTK  :  IRole
    {


        public override string GetRoleName()
        {
            return "ОТК";
        }

        public override void ssLoad(ShowSummon ss)
        {
            DBSummon dbs = new DBSummon();

            if ((ss.SVO.IDSTATUS == 2) || (ss.SVO.IDSTATUS == 7) || (ss.SVO.IDSTATUS == 16))
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
            ss.bEditWP.Enabled = true;


        }
        public override void EnableEdit(ShowSummon ss)
        {
            //if ((ss.SVO.IDSTATUS != 7) && (ss.SVO.IDSTATUS != 16))
            //{
                //MessageBox.Show("Вы не можете редактировать это извещение, так как не являетесь в данный момент ответственным лицом за это извещение или оно пришло от монтажников!");
                //MessageBox.Show("Вы можете редактировать только поле \"Серийные номера\", так как не являетесь в данный момент ответственным лицом за это извещение или оно пришло от монтажников!");
                //return;
            //}
            //else
            //{
                EnableAll(ss);
            //}
        }
        private void EnableAll(ShowSummon ss)
        {
            ss.summonTransfer1.Enabled = false;
            ss.summonTransfer2.Enabled = false;
            ss.bEdit.Enabled = false;
            ss.bSave.Enabled = true;

            if (ss.pfSERIAL.Required)
            {
                ss.pfSERIAL.ACCESSMODE = "EDIT";
                ss.pfSERIAL.Enabled = true;
            }


            /*ss.chbDeterm.Enabled = true;
            if (ss.chbDeterm.Checked)
                ss.dtpAPPROX.Enabled = false;
            else
                ss.dtpAPPROX.Enabled = true;*/
        }

    }
}
