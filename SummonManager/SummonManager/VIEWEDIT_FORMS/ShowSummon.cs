using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using SummonManager.CLASSES;
using SummonManager.CLASSES.IRole_namespace;

namespace SummonManager
{
    public partial class ShowSummon : Form
    {
        public SummonVO SVO;
        public IRole UVO;
        public ShowSummon(IRole uvo,SummonVO svo)
        {
            this.UVO = uvo;
            this.SVO = svo;
            InitializeComponent(); 
        }

        private void cbCustomers_SelectedIndexChanged(object sender, EventArgs e)
        {
            DBCustomer dbc = new DBCustomer();
            cbCustDept.DataSource = dbc.GetDeptsByIDCustomer(cbCustomers.SelectedValue.ToString());

        }


        private void bSave_Click(object sender, EventArgs e)
        {
            UVO.SaveSummon(this);
            UVO.DisableAbsolute(this);
            UVO.EnableInitial(this);

        }
        private void bEdit_Click(object sender, EventArgs e)
        {
            UVO.EnableEdit(this);
        }


        private void chbDeterm_CheckedChanged(object sender, EventArgs e)
        {
            /*if (chbDeterm.Checked)
                dtpAPPROX.Enabled = false;
            else
                dtpAPPROX.Enabled = true;*/
        }


        public DateTime? dtpApproxAtLoad;

        private void ShowSummon_Load(object sender, EventArgs e)
        {

            UVO.ssLoad(this);

            InitTableLayout();

            if ((this.Tag != null) && (this.Tag.ToString() == "finished"))
            {
                this.Text = "Просмотр завершённого извещения";
                this.summonNotes1.button1.Enabled = false;
                this.summonNotes1.button2.Enabled = false;
                this.summonNotes1.button3.Enabled = false;
            }
            else
            {
                this.Text = "Просмотр извещения (" + UVO.GetRoleName() + ")";
            }

        }





        private void InitTableLayout()
        {
            tableLayoutPanel1.Controls.Clear();
            tableLayoutPanel1.RowStyles.Clear();
            tableLayoutPanel1.RowCount = 0;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            SVO.ProductVO.FillTableLayoutPanel(tableLayoutPanel1,UVO);
        }

        private void bPurchMat_Click(object sender, EventArgs e)
        {
            PurchasedMaterials fpm = new PurchasedMaterials(SVO.ID);
            fpm.ShowDialog();
        }

        private void bEditCustomers_Click(object sender, EventArgs e)
        {
            Customers c = new Customers();
            c.ShowDialog();
            DBCustomer dbc = new DBCustomer();
            cbCustomers.DataSource = dbc.GetAllCustomers();
            cbCustomers.SelectedValue = SVO.IDCUSTOMER;

            cbCustDept.DataSource = dbc.GetDeptsByIDCustomer(cbCustomers.SelectedValue.ToString());

        }

        private void bDelSummon_Click(object sender, EventArgs e)//админ
        {
            if ((SVO.IDSTATUS != 1) && (UVO.Role == Roles.Manager))
            {
                MessageBox.Show("Вы можете удалить извещение только со статусом \"Новое\"!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                if (MessageBox.Show("Вы действительно хотите удалить это извещение?", "Внимание!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    return;
                }
                else
                {
                    DBSummon dbs = new DBSummon();
                    dbs.DeleteSummonByID(SVO.ID);
                    MessageBox.Show("Извещение успешно удалено!");
                    Close();
                }
            }
            if (UVO.Role == Roles.Admin)
            {
                if (MessageBox.Show("Вы действительно хотите удалить это извещение?", "Внимание!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    return;
                }
                else
                {
                    DBSummon dbs = new DBSummon();
                    dbs.DeleteSummonByID(SVO.ID);
                    MessageBox.Show("Извещение успешно удалено!");
                    Close();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Customers c = new Customers();
            c.ShowDialog();
            DBCustomer dbc = new DBCustomer();
            cbCustomers.DataSource = dbc.GetAllCustomers();
            cbCustomers.SelectedValue = SVO.IDCUSTOMER;

            cbCustDept.DataSource = dbc.GetDeptsByIDCustomer(cbCustomers.SelectedValue.ToString());

        }

        private void bPrint_Click(object sender, EventArgs e)
        {
            DBSummon dbs = new DBSummon();
            SummonVO svo = dbs.GetSummonByIDS(tbIDS.Text);
            SummonVOForReport svor = new SummonVOForReport(svo);
            List<SummonVOForReport> sl = new List<SummonVOForReport>();
            sl.Add(svor);
            ShowReport sr = new ShowReport(sl);
            sr.ShowDialog();
        }

        private void bCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bEditWP_Click(object sender, EventArgs e)
        {
            IProduct pr = SVO.ProductVO;
            pr.ViewEdit(UVO);
            SVO.ProductVO = ProductFactory.Create(SVO.IDWPNAME, SVO.WPTYPE);

            InitTableLayout();
            
        }

        private void bViewWP_Click(object sender, EventArgs e)
        {
            IProduct pr = SVO.ProductVO;
            pr.ViewOnly(UVO);

        }

        private void bChangeProduct_Click(object sender, EventArgs e)
        {
            WPName wp = new WPName(true, UVO, SVO.ProductVO.GetProductType(),true);
            wp.ShowDialog();
            if (wp.PickedID == 0)
            {
                return;
            }

            var PickedProduct = ProductFactory.Create(wp.PickedID, wp.PickedType);

            SVO.ProductVO = PickedProduct;
            SVO.IDWPNAME = PickedProduct.GetID();
            DBSummon dbs = new DBSummon();
            dbs.SaveSummon(SVO);
            ShowSummon_Load(sender, e);

            
        }

        private void panel1_MouseEnter(object sender, EventArgs e)
        {
            panel1.Focus();
        }

        private void tableLayoutPanel1_MouseEnter(object sender, EventArgs e)
        {
            tableLayoutPanel1.Focus();
        }

        private void bRemarks_Click(object sender, EventArgs e)
        {
            Remarks r = new Remarks(UVO);
            r.ShowDialog();

        }

       




    }
}
