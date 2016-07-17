using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SummonManager.CLASSES.IRole_namespace;
using System.Windows.Forms;
using SummonManager.CLASSES;



namespace SummonManager
{

    public class UVO_CONSTR  :  IRole
    {


        public override string GetRoleName()
        {
            return "Конструктор";
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
            ss.bEdit.Enabled = true;


        }
        public override void EnableEdit(ShowSummon ss)
        {
            EnableAll(ss);
        }
        private void EnableAll(ShowSummon ss)
        {
            ss.bEdit.Enabled = false;
            ss.bSave.Enabled = true;


            //if (ss.pfPLANKA.Required)
            {
                ss.pfPLANKA.Enabled = true;
                ss.pfPLANKA.ACCESSMODE = "EDIT";
                ss.pfPLANKA.RequiredEnabled = true;
            }


        }
        public override void MyRemarksWP(DataGridView dgWP)
        {
            foreach (DataGridViewRow r in dgWP.Rows)
            {
                if ((r.Cells["DOCUMENTNAME"].Value.ToString() != "DIMESIONALDRAWING") ||
                    (r.Cells["DOCUMENTNAME"].Value.ToString() != "SBORKA3D") ||
                    (r.Cells["DOCUMENTNAME"].Value.ToString() != "MECHPARTS") ||
                    (r.Cells["DOCUMENTNAME"].Value.ToString() != "SHILDS") ||
                    (r.Cells["DOCUMENTNAME"].Value.ToString() != "PACKAGING") )
                {
                    r.Visible = false;
                }
                else
                {
                    r.Visible = true;
                }

            }
        }
    }
}
