﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SummonManager.CLASSES.IRole_namespace;
using System.Windows.Forms;
using SummonManager.CLASSES;



namespace SummonManager
{

    public class UVO_WARE  :  IRole
    {


        public override string GetRoleName()
        {
            return "Коммерческий отдел";
        }

        public override void ssLoad(ShowSummon ss)
        {
            DBSummon dbs = new DBSummon();

            if (ss.SVO.IDSTATUS == 9)
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
            //ss.bEdit.Enabled = true;
            
        }
        public override void EnableEdit(ShowSummon ss)
        {
            /*if (ss.SVO.IDSTATUS != 9)
            {
                MessageBox.Show("Вы не можете редактировать это извещение, так как не являетесь в данный момент ответственным лицом за это извещение!");
                return;
            }
            EnableAll(ss);*/
        }
        private void EnableAll(ShowSummon ss)
        {
            ss.summonTransfer1.Enabled = false;
            ss.bEdit.Enabled = false;
            ss.bSave.Enabled = true;
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
                r.Visible = false;
            }
        }
        public override bool IsMySmmRemark(string DOCNAME)
        {
            return false;
        }	
    }
}
