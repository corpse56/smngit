using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SummonManager.CLASSES.IRole_namespace;
using System.Windows.Forms;
using SummonManager.CLASSES;



namespace SummonManager
{

    public class UVO_OTD  :  IRole
    {


        public override string GetRoleName()
        {
            return "Отдел технической документации";
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

            ss.bEdit.Enabled = true;

            /*if (ss.SVO.WPTYPE == "WPNAMELIST")
            {
                ss.bEditWP.Enabled = true;
            }*/ //так как поля, за которые ответственна эта роль ОТД переехали в извещение, то соответственно редактировать ничего не надо.
        }
        public override void EnableEdit(ShowSummon ss)
        {
            EnableAll(ss);
        }
        private void EnableAll(ShowSummon ss)
        {
            //ss.bEdit.Enabled = false;
            //ss.bSave.Enabled = true;
            
            ss.bEdit.Enabled = false;
            ss.bSave.Enabled = true;

            //if (ss.pfPASSPORT.Required)
            {
                ss.pfPASSPORT.ACCESSMODE = "EDIT";
                ss.pfPASSPORT.Enabled = true;
                ss.pfPASSPORT.RequiredEnabled = true;
            }
            //if (ss.pfMANUAL.Required)
            {
                ss.pfMANUAL.ACCESSMODE = "EDIT";
                ss.pfMANUAL.Enabled = true;
                ss.pfMANUAL.RequiredEnabled = true;
            }
            //if (ss.pfPACKINGLIST.Required)
            {
                ss.pfPACKINGLIST.ACCESSMODE = "EDIT";
                ss.pfPACKINGLIST.Enabled = true;
                ss.pfPACKINGLIST.RequiredEnabled = true;
            }
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
                if (r.Cells["CLOSED"].Value.ToString() == "Открыто")
                {
                    if ((r.Cells["DOCUMENTNAME"].Value.ToString() != "PASSPORT") &&
                        (r.Cells["DOCUMENTNAME"].Value.ToString() != "MANUAL") &&
                        (r.Cells["DOCUMENTNAME"].Value.ToString() != "PACKINGLIST"))
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
            return ((DOCNAME != "PASSPORT") &&
                   (DOCNAME != "MANUAL") &&
                   (DOCNAME != "PACKINGLIST")) ? false : true;
        }
    }
}
