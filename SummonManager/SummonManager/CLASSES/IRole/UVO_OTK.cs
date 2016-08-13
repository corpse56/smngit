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

            //if (ss.pfSERIAL.Required)
            {
                ss.pfSERIAL.ACCESSMODE = "EDIT";
                ss.pfSERIAL.Enabled = true;
                ss.pfSERIAL.RequiredEnabled = true;
            }


            /*ss.chbDeterm.Enabled = true;
            if (ss.chbDeterm.Checked)
                ss.dtpAPPROX.Enabled = false;
            else
                ss.dtpAPPROX.Enabled = true;*/
        }
        public override void MyRemarksWP(DataGridView dgWP)
        {
            dgWP.CurrentCell = null;
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
            dgSumm.CurrentCell = null;
            foreach (DataGridViewRow r in dgSumm.Rows)
            {
                if (r.Cells["CLOSED"].Value.ToString() == "Открыто")
                {
                    if (r.Cells["DOCUMENTNAME"].Value.ToString() != "SERIAL")
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
        public override bool IsMySmmRemark(string DOCNAME)
        {
            return (DOCNAME != "SERIAL") ? false : true;
        }	
    }
}
