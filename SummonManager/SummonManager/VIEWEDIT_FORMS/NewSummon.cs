using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using SummonManager.CLASSES.IRole_namespace;

namespace SummonManager
{
    public partial class NewSummon : Form
    {
        private DBSummon dbs;
        private IRole UVO;
        private int IDNEWSUMMON;
        public NewSummon(IRole uvo)
        {
            InitializeComponent();
            this.UVO = uvo;
            dbs = new DBSummon();
            // tbIDS.Text = dbs.GetNextNumber();
            tbIDS.Text = "<не определено>";

            IDNEWSUMMON = dbs.AddNIPSummon();
            dtpCREATED.Value = DateTime.Now;

            cbSISP.SelectedIndex = 0;

            DBCustomer dbc = new DBCustomer();
            cbCustomers.ValueMember = "ID";
            cbCustomers.DisplayMember = "CNAME";
            cbCustomers.DataSource = dbc.GetAllCustomers();

            /*DBWPName dbwp = new DBWPName();
            cbWPNAME.ValueMember = "ID";
            cbWPNAME.DisplayMember = "WPNAME";
            cbWPNAME.DataSource = dbwp.GetAllWPNames();*/

            DBAccept dbacc = new DBAccept();
            cbAccept.ValueMember = "ID";
            cbAccept.DisplayMember = "ANAME";
            cbAccept.DataSource = dbacc.GetAllAccept();

            DBPacking dbp = new DBPacking();
            cbPacking.ValueMember = "ID";
            cbPacking.DisplayMember = "PNAME";
            cbPacking.DataSource = dbp.GetAll();

            //DBEXTCABLE dbec = new DBEXTCABLE();
            //cbExtCable.ValueMember = "ID";
            //cbExtCable.DisplayMember = "EXTCABLENAME";
            //cbExtCable.DataSource = dbec.GetAllEXTCABLENames();

            //DBMountingKit dbmk = new DBMountingKit();
            //cbMountingKit.ValueMember = "ID";
            //cbMountingKit.DisplayMember = "MOUNTINGKITNAME";
            //cbMountingKit.DataSource = dbmk.GetAllDBMountingKitNames();
            //cbMountingKit.SelectedIndex = 0;


           // UIProc ui = new UIProc();
            //ui.LoadExtCables(dgv, this.IDNEWSUMMON.ToString());
            //LoadExtCables();
            pickWPName1.Init(UVO);
            cbCONTRACTTYPE.SelectedIndex = 0;

        }
        private void NewSummon_Load(object sender, EventArgs e)
        {
            DBCustomer dbc = new DBCustomer();
            //cbCustomers.ValueMember = "ID";
            //cbCustomers.DisplayMember = "CNAME";
            //cbCustomers.DataSource = dbc.GetAllCustomers();

            cbCustDept.ValueMember = "ID";
            cbCustDept.DisplayMember = "DEPTNAME";
            cbCustDept.DataSource = dbc.GetDeptsByIDCustomer(cbCustomers.SelectedValue.ToString());

        
        }
        private void cbCustomers_SelectedIndexChanged(object sender, EventArgs e)
        {
            DBCustomer dbc = new DBCustomer();
            cbCustDept.DataSource = dbc.GetDeptsByIDCustomer(cbCustomers.SelectedValue.ToString());

        }
        private void button2_Click(object sender, EventArgs e)
        {
            //NewCustomer nc = new NewCustomer();
            //nc.ShowDialog();
            Customers c = new Customers();
            c.ShowDialog();
            DBCustomer dbc = new DBCustomer();
            cbCustomers.DataSource = dbc.GetAllCustomers();

            cbCustDept.DataSource = dbc.GetDeptsByIDCustomer(cbCustomers.SelectedValue.ToString());
            //cbCustomers.SelectedValue = SVO.IDCUSTOMER;
        }



        private void bCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bAdd_Click(object sender, EventArgs e)
        {

            if (pickWPName1.textBox1.Text == "")
            {
                MessageBox.Show("Выбеоите изделие!");
                return;
            }
            if (tbQUANTITY.Value == 0)
            {
                MessageBox.Show("Введите количество изделий!");
                return;
            }
            if (cbCustDept.Items.Count == 0)
            {
                MessageBox.Show("Необходиом добавить хотя бы один отдел заказчика!");
                return;
            }
            if (MessageBox.Show("Вы действительно хотите сохранить и передать в ПДБ?", "Внимание!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }
            DBSummon dbs = new DBSummon();
            SummonVO SVO = new SummonVO();
            SVO.ID = this.IDNEWSUMMON.ToString();
            SVO.IDS = dbs.GetNextNumber();
            SVO.ACCEPTANCE = cbAccept.Text;
            SVO.CONTRACT = tbCONTRACT.Text;
            SVO.CREATED = DateTime.Now;
            SVO.DELIVERY = tbDELIVERY.Text;
            SVO.IDCUSTOMER = cbCustomers.SelectedValue.ToString();
            SVO.PAYSTATUS = tbPAYSTATUS.Text;
            SVO.IDSTATUS = 2;
            SVO.NOTE = tbNote.Text;
            SVO.PTIME = dtpPTIME.Value;
            SVO.QUANTITY = (int)tbQUANTITY.Value;
            SVO.SHIPPING = tbSHIPPING.Text;
            if (cbSISP.SelectedIndex == 0)
                SVO.SISP = false;
            else
                SVO.SISP = true;
            SVO.IDWPNAME = pickWPName1.PickedProduct.GetID();
            SVO.WPTYPE = pickWPName1.PickedProduct.GetProductType().ToString();
            SVO.IDACCEPT = (int)cbAccept.SelectedValue;
            SVO.IDPACKING = (int)cbPacking.SelectedValue;
            //SVO.IDMOUNTINGKIT = (int)cbMountingKit.SelectedValue;
            SVO.IDCUSTOMERDEPT = (int)cbCustDept.SelectedValue;
            //SVO.PASSDATE = null;
            SVO.VIEWED = false;
            SVO.NOTEPDB = "";
            SVO.DOCSREADY = false;
            SVO.BILLPAYED = false;
            SVO.CONTRACTTYPE = cbCONTRACTTYPE.Text;
            SVO.BILLNUMBER = tbBillNumber.Text;
            SVO.PACKINGLISTREQ = true;
            SVO.PASSPORTREQ = true;
            SVO.PLANKAREQ = true;
            SVO.SERIALREQ = true;
            SVO.MANUALREQ = true;

            dbs.AddNewSummon(SVO,UVO);
            //MessageBox.Show("Извещение успешно создано и передано в ОЗиС!");
            this.Close();
        }


        private void bSave_Click(object sender, EventArgs e)
        {

            if (pickWPName1.textBox1.Text == "")
            {
                MessageBox.Show("Выберите изделие!");
                return;
            }
            if (tbQUANTITY.Value == 0)
            {
                MessageBox.Show("Введите количество изделий!");
                return;
            }
            if (cbCustDept.Items.Count == 0)
            {
                MessageBox.Show("Необходиом добавить хотя бы один отдел заказчика!");
                return;
            }
            DBSummon dbs = new DBSummon();
            SummonVO SVO = new SummonVO();
            SVO.ID = this.IDNEWSUMMON.ToString();
            SVO.IDS = dbs.GetNextNumber();
            SVO.ACCEPTANCE = cbAccept.Text;
            SVO.CONTRACT = tbCONTRACT.Text;
            SVO.CREATED = DateTime.Now;
            SVO.DELIVERY = tbDELIVERY.Text;
            SVO.IDCUSTOMER = cbCustomers.SelectedValue.ToString();
            SVO.PAYSTATUS = tbPAYSTATUS.Text;
            SVO.IDSTATUS = 1;
            SVO.NOTE = tbNote.Text;
            SVO.PTIME = dtpPTIME.Value;
            SVO.QUANTITY = (int)tbQUANTITY.Value;
            SVO.SHIPPING = tbSHIPPING.Text;
            if (cbSISP.SelectedIndex == 0)
                SVO.SISP = false;
            else
                SVO.SISP = true;
            SVO.IDACCEPT = (int)cbAccept.SelectedValue;
            SVO.IDWPNAME = pickWPName1.PickedProduct.GetID();
            SVO.WPTYPE = pickWPName1.PickedProduct.GetProductType().ToString();
            SVO.IDPACKING = (int)cbPacking.SelectedValue;
            SVO.IDCUSTOMERDEPT = (int)cbCustDept.SelectedValue;
            SVO.VIEWED = true;
            SVO.NOTEPDB = "";
            SVO.BILLPAYED = false;
            SVO.DOCSREADY = false;
            SVO.CONTRACTTYPE = cbCONTRACTTYPE.Text;
            SVO.BILLNUMBER = tbBillNumber.Text;

            SVO.PACKINGLISTREQ = true;
            SVO.PASSPORTREQ = true;
            SVO.PLANKAREQ = true;
            SVO.SERIALREQ = true;
            SVO.MANUALREQ = true;

            /*if (chbDeterm.Checked)
                SVO.PASSDATE = null;
            else
                SVO.PASSDATE = dtpAPPROX.Value;*/

            dbs.SaveNewSummon(SVO,UVO);
            tbIDS.Text = SVO.IDS;
            MessageBox.Show("Извещение успешно создано! Извещению присвоен номер: "+SVO.IDS);
            this.Close();
        }
        private void chbDeterm_CheckedChanged(object sender, EventArgs e)
        {
            /*if (chbDeterm.Checked)
                dtpAPPROX.Enabled = false;
            else
                dtpAPPROX.Enabled = true;*/

        }


//        private void bEditExtCablePack_Click(object sender, EventArgs e)
//        {
//            fEditExtCablePack fecp = new fEditExtCablePack(this.IDNEWSUMMON.ToString());
//            fecp.ShowDialog();
//            UIProc ui = new UIProc();
//            ui.LoadExtCables(dgv, this.IDNEWSUMMON.ToString());

////            LoadExtCables();
//        }


        private void dtpPTIME_ValueChanged(object sender, EventArgs e)
        {

        }

      
       


    }
}
