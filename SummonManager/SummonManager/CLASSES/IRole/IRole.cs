using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SummonManager.CLASSES.IRole_namespace
{
    public enum Roles { nol, Manager, Ozis, Prod, OTK, Ware, Logist, Admin, Director, Wsh, Montage, Constructor,Inzhener, Buhgalter, SimpleInzhener, Shemotehnik, Tehnolog, OTD, MainMontage}

    public class IRole
    {
        public string Fio;
        public string Login;
        public string Pass;
        public Roles Role;
        public string id;


        public virtual string GetRoleName() { return Role.ToString(); }

        ///вызывается в методе Load формы редактирования извещение ShowSummon
        public virtual void ssLoad(ShowSummon ss) { }

        public override string ToString()
        {
            switch (this.Role)
            {
                case Roles.Admin:
                    return "Администратор";
                case Roles.Constructor:
                    return "Конструктор";
                case Roles.Director:
                    return "Директор";
                case Roles.Logist:
                    return "Отдел логистики";
                case Roles.Manager:
                    return "Менеджер";
                case Roles.Montage:
                    return "Монтажники";
                case Roles.nol:
                    return "без роли";
                case Roles.OTK:
                    return "ОТК";
                case Roles.Ozis:
                    return "ПДБ";
                case Roles.Prod:
                    return "Производство";
                case Roles.Ware:
                    return "Коммерческий отдел";
                case Roles.Wsh:
                    return "Цех";
                case Roles.Inzhener:
                    return "Главный инженер";
                case Roles.Buhgalter:
                    return "Бухгалтер";
                case Roles.SimpleInzhener:
                    return "Инженер";
                case Roles.Shemotehnik:
                    return "Схемотехник";
                case Roles.Tehnolog:
                    return "Технолог";
                case Roles.OTD:
                    return "ОТД";
                default:
                    return "не определено";
            }
        }

        public void DisableAbsolute(ShowSummon ss)
        {
            ss.tbQUANTITY.ReadOnly = true;
            ss.tbSHIPPING.ReadOnly = true;
            ss.tbCONTRACT.ReadOnly = true;
            ss.tbDELIVERY.ReadOnly = true;
            ss.tbPayStatus.ReadOnly = true;
            ss.tbStatus.ReadOnly = true;
            ss.tbSubStatus.ReadOnly = true;
            ss.tbBillNumber.ReadOnly = true;

            ss.cbPacking.ReadOnly = true;
            //ss.cbMountingKit.ReadOnly = true;
            ss.cbCustDept.ReadOnly = true;
            ss.cbAccept.ReadOnly = true;
            ss.cbCustomers.ReadOnly = true;
            ss.cbSISP.ReadOnly = true;
            ss.cbCONTRACTTYPE.ReadOnly = true;

            ss.dtpPTIME.Enabled = false;
            //ss.dtpAPPROX.Enabled = false;

            //ss.chbDeterm.Enabled = false;
            ss.chbBillPayed.Enabled = false;
            ss.chbDocsRdy.Enabled = false;

            ss.bEdit.Enabled = false;
            ss.bSave.Enabled = false;
            ss.bPrint.Enabled = true;
            ss.bDelSummon.Enabled = false;
            ss.bEditCustomers.Enabled = false;
            ss.bEditWP.Enabled = false;
            ss.bPurchMat.Enabled = false;
            ss.bChangeProduct.Enabled = false;

            ss.summonTransfer1.Enabled = true;
            ss.summonTransfer2.Enabled = true;

            ss.pfPLANKA.Init(ss.SVO.PLANKA, ss.SVO.PLANKAREQ, false, true, false, Roles.Constructor, "VIEWONLY", this, "PLANKA",ss.SVO,null);
            ss.pfSERIAL.Init(ss.SVO.SERIAL, ss.SVO.SERIALREQ, false, true, false, Roles.OTK, "VIEWONLY", this, "SERIAL",ss.SVO,null);
            //ss.summonNotes1.button1.Enabled = false;

            ss.pfPASSPORT.Init(ss.SVO.PASSPORT, ss.SVO.PASSPORTREQ, false, true, false, Roles.OTD,  "VIEWONLY", this, "PASSPORT",ss.SVO,null);
            ss.pfMANUAL.Init(ss.SVO.MANUAL, ss.SVO.MANUALREQ, false, true, false, Roles.OTD,  "VIEWONLY", this, "MANUAL",ss.SVO,null);
            ss.pfPACKINGLIST.Init(ss.SVO.PACKINGLIST, ss.SVO.PACKINGLISTREQ, false, true, false, Roles.OTD, "VIEWONLY", this, "PACKINGLIST",ss.SVO,null);
            //ss.tbLENGTH.Enabled = false;
            //ss.tbWIDTH.Enabled = false;
            //ss.tbHEIGHT.Enabled = false;
            //ss.tbWEIGHT.Enabled = false;

        }//эта невиртуальная потому что для всех ролей одинаковый код
        protected void LoadSummon(ShowSummon ss)
        {
            ss.tbIDS.Text = ss.SVO.IDS;

            DBCustomer dbc = new DBCustomer();
            ss.cbCustomers.ValueMember = "ID";
            ss.cbCustomers.DisplayMember = "CNAME";
            ss.cbCustomers.DataSource = dbc.GetAllCustomers();
            ss.cbCustomers.SelectedValue = ss.SVO.IDCUSTOMER;

            if (ss.SVO.SISP)
                ss.cbSISP.SelectedIndex = 1;
            else
                ss.cbSISP.SelectedIndex = 0;

            DBAccept dbacc = new DBAccept();
            ss.cbAccept.ValueMember = "ID";
            ss.cbAccept.DisplayMember = "ANAME";
            ss.cbAccept.DataSource = dbacc.GetAllAccept();
            ss.cbAccept.SelectedValue = ss.SVO.IDACCEPT;

            DBPacking dbp = new DBPacking();
            ss.cbPacking.ValueMember = "ID";
            ss.cbPacking.DisplayMember = "PNAME";
            ss.cbPacking.DataSource = dbp.GetAll();
            ss.cbPacking.SelectedValue = ss.SVO.IDPACKING;

            //DBMountingKit dbmk = new DBMountingKit();
            //ss.cbMountingKit.ValueMember = "ID";
            //ss.cbMountingKit.DisplayMember = "MOUNTINGKITNAME";
            //ss.cbMountingKit.DataSource = dbmk.GetAllDBMountingKitNames();
            //ss.cbMountingKit.SelectedValue = ss.SVO.IDMOUNTINGKIT;


            ss.tbCONTRACT.Text = ss.SVO.CONTRACT;
            ss.tbDELIVERY.Text = ss.SVO.DELIVERY;
            ss.tbQUANTITY.Value = ss.SVO.QUANTITY;
            ss.tbSHIPPING.Text = ss.SVO.SHIPPING;
            ss.dtpCREATED.Value = ss.SVO.CREATED;
            ss.dtpPTIME.Value = ss.SVO.PTIME;
            ss.tbPayStatus.Text = ss.SVO.PAYSTATUS;
            ss.tbBillNumber.Text = ss.SVO.BILLNUMBER;
            /*if (ss.SVO.PASSDATE == null)
            {
                ss.chbDeterm.Checked = true;
                ss.dtpAPPROX.Enabled = false;
            }
            else
            {
                ss.chbDeterm.Checked = false;
                ss.dtpAPPROX.Enabled = false;
                ss.dtpAPPROX.Value = (DateTime)ss.SVO.PASSDATE;
            }*/
            ss.tbStatus.Text = ss.SVO.STATUSNAME;
            ss.tbSubStatus.Text = ss.SVO.SUBSTATUSNAME;
            ss.chbBillPayed.Checked = ss.SVO.BILLPAYED;
            ss.chbDocsRdy.Checked = ss.SVO.DOCSREADY;

            if ((ss.Tag != null) &&(ss.Tag.ToString() == "finished"))           

            {
                ss.summonTransfer1.Visible = false;
                ss.summonTransfer2.Visible = false;
            }
            else
            {
                ss.summonNotes1.Init(ss.SVO.ID, this, ss.SVO);
                ss.summonNotes1.Reload();

                ss.summonTransfer1.Init(ss.SVO, this, ss);
                if ((ss.SVO.ProductVO.GetProductType() == WPTYPE.CABLELIST) || (ss.SVO.ProductVO.GetProductType() == WPTYPE.ZHGUTLIST))
                {
                    ss.summonTransfer2.Visible = false;
                }
                ss.summonTransfer2.InitSub(ss.SVO, this, ss);
            }
            ss.wpNameView1.Init(ss.SVO.ProductVO.GetID(), ss.SVO.ProductVO.GetProductType(), this, ss.SVO);

            ss.cbCustDept.ValueMember = "ID";
            ss.cbCustDept.DisplayMember = "DEPTNAME";
            ss.cbCustDept.DataSource = dbc.GetDeptsByIDCustomer(ss.cbCustomers.SelectedValue.ToString());
            ss.cbCustDept.SelectedValue = ss.SVO.IDCUSTOMERDEPT;
            if ((ss.Tag == null) )
            {
                DBSummon dbs = new DBSummon();
                dbs.AddSummonView(ss.SVO, this);
            }
            //ss.dtpApproxAtLoad = ss.SVO.PASSDATE;

            ss.cbCONTRACTTYPE.Text = ss.SVO.CONTRACTTYPE;



            //pfMETAL.IsPath = true;
        }//эта тоже

        public virtual void EnableEdit(ShowSummon ss)//включает контролы, которые можно редактировать этой ролью
        { }
        public virtual void EnableInitial(ShowSummon ss)//включает контролы, которые должны быть активны для роли
        { }
        public void SaveSummon(ShowSummon ss)
        {
            if (ss.tbQUANTITY.Value == 0)
            {
                MessageBox.Show("Введите количество изделий!");
                return;
            }
            if (ss.cbCustDept.SelectedValue == null)
            {
                MessageBox.Show("Добавьте отдел заказчика!");
                return;
            }
            DBSummon dbs = new DBSummon();
            SummonVO SVO = new SummonVO();
            SVO = SummonVO.SummonVOByID(ss.SVO.ID);
            SVO.ID = ss.SVO.ID;
            SVO.IDS = ss.tbIDS.Text;
            SVO.ACCEPTANCE = ss.cbAccept.Text;
            SVO.CONTRACT = ss.tbCONTRACT.Text;
            SVO.CREATED = ss.SVO.CREATED;
            SVO.DELIVERY = ss.tbDELIVERY.Text;
            SVO.IDCUSTOMER = ss.cbCustomers.SelectedValue.ToString();
            SVO.IDCUSTOMERDEPT = (int)ss.cbCustDept.SelectedValue;
            SVO.PAYSTATUS = ss.tbPayStatus.Text;
            SVO.IDSTATUS = 1;//тута просто фейковую единичку ставим, потом при занесении в базу проставится нормальный статус
            SVO.PTIME = ss.dtpPTIME.Value;
            SVO.QUANTITY = (int)ss.tbQUANTITY.Value;
            SVO.SHIPPING = ss.tbSHIPPING.Text;

            if (ss.cbSISP.SelectedIndex == 0)
                SVO.SISP = false;
            else
                SVO.SISP = true;
            SVO.IDACCEPT = (int)ss.cbAccept.SelectedValue;
            SVO.IDPACKING = (int)ss.cbPacking.SelectedValue;
            /*SVO.IDMOUNTINGKIT = (int)ss.cbMountingKit.SelectedValue;
            if (ss.chbDeterm.Checked)
            {
                SVO.PASSDATE = null;
            }
            else
            {
                SVO.PASSDATE = ss.dtpAPPROX.Value;
            }*/
            SVO.BILLPAYED = ss.chbBillPayed.Checked;
            SVO.DOCSREADY = ss.chbDocsRdy.Checked;
            SVO.VIEWED = true;
            SVO.CONTRACTTYPE = ss.cbCONTRACTTYPE.Text;
            SVO.PLANKA = (ss.pfPLANKA.FullPath == "<нет>") ? null : ss.pfPLANKA.FullPath; 
            SVO.PLANKAREQ = ss.pfPLANKA.Required;
            SVO.SERIAL = (ss.pfSERIAL.FullPath == "<нет>") ? null : ss.pfSERIAL.FullPath;
            SVO.SERIALREQ = ss.pfSERIAL.Required;
            SVO.BILLNUMBER = ss.tbBillNumber.Text;

            SVO.PASSPORT = (ss.pfPASSPORT.FullPath == "<нет>") ? null : ss.pfPASSPORT.FullPath;
            SVO.PASSPORTREQ = ss.pfPASSPORT.Required;
            SVO.MANUAL = (ss.pfMANUAL.FullPath == "<нет>") ? null : ss.pfMANUAL.FullPath;
            SVO.MANUALREQ = ss.pfMANUAL.Required;
            SVO.PACKINGLIST = (ss.pfPACKINGLIST.FullPath == "<нет>") ? null : ss.pfPACKINGLIST.FullPath;
            SVO.PACKINGLISTREQ = ss.pfPACKINGLIST.Required;
            //SVO.LENGTH = ss.tbLENGTH.Text;
            //SVO.WIDTH = ss.tbWIDTH.Text;
            //SVO.HEIGHT = ss.tbHEIGHT.Text;
            //SVO.WEIGHT = ss.tbWEIGHT.Text;

            dbs.SaveSummon(SVO);
            ss.SVO = SVO;
            /*if (ss.dtpApproxAtLoad != SVO.PASSDATE)
            {
                dbs.PassDateChanged(SVO.ID);
            }*/
            MessageBox.Show("Извещение успешно сохранено!");



        }


       

        public virtual void MyRemarksWP(DataGridView dgWP)
        {
            
        }

        internal void AllRemarksWP(DataGridView dgWP)//сделать все замечания видимыми
        {
            foreach (DataGridViewRow r in dgWP.Rows)
            {
                r.Visible = true;
            }
        }
    }

    public class UserFactory
    {
        public static IRole CreateUser(Roles role)
        {
            IRole result = new IRole();
            switch (role)
            {
                case Roles.Manager:
                    result = new UVO_MANAGER();
                    break;
                case Roles.Ozis:
                    result = new UVO_PDB();
                    break;
                case Roles.Prod:
                    result = new UVO_PROD();
                    break;
                case Roles.Wsh:
                    result = new UVO_WSH();
                    break;
                case Roles.OTK:
                    result = new UVO_OTK();
                    break;
                case Roles.Constructor:
                    result = new UVO_CONSTR();
                    break;
                case Roles.Logist:
                    result = new UVO_LOGIST();
                    break;
                case Roles.Buhgalter:
                    result = new UVO_BUH();
                    break;
                case Roles.Director:
                    result = new UVO_DIRECTOR();
                    break;
                case Roles.Inzhener:
                    result = new UVO_INZH();
                    break;
                case Roles.SimpleInzhener:
                    result = new UVO_SIMPLEINZH();
                    break;
                case Roles.Montage:
                    result = new UVO_MONT();
                    break;
                case Roles.OTD:
                    result = new UVO_OTD();
                    break;
                case Roles.Shemotehnik:
                    result = new UVO_SCHEM();
                    break;
                case Roles.Ware:
                    result = new UVO_WARE();
                    break;
                case Roles.Tehnolog:
                    result = new UVO_TECHNO();
                    break;
                case Roles.Admin:
                    result = new UVO_ADMIN();
                    break;
                case Roles.MainMontage:
                    result = new UVO_MAINMONTAGE();
                    break;
                default:
                    result = new UVO_DIRECTOR();
                    break;
            }
            result.Role = role;
            return result;

        }
    }



}
