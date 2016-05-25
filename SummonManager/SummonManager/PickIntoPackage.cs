using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SummonManager.CLASSES;
using SummonManager.CLASSES.IRole_namespace;

namespace SummonManager
{
    public partial class PickIntoPackage : Form
    {
        IRole UVO;
        WPTYPE WPT;
        public PickIntoPackage(IRole uvo, WPTYPE wpt)
        {
            InitializeComponent();
            this.WPT = wpt;
            if (WPT == WPTYPE.ZHGUTLIST)
            {
                this.Text = "Выбор жгута для комплекта жгутов рабочего изделия";
            }
            if (WPT == WPTYPE.CABLELIST)
            {
                this.Text = "Выбор кабеля для комплекта кабелей рабочего изделия";
            }


            this.UVO = uvo;
        }

        private void bClose_Click(object sender, EventArgs e)
        {
            Close();
        }





        private void WPName_Load(object sender, EventArgs e)
        {
            if (WPT == WPTYPE.CABLELIST)
            {
                DBCategory dbc = new DBCategory("CABLELIST");
                cbCAT.ValueMember = "ID";
                cbCAT.DisplayMember = "CATEGORYNAME";
                cbCAT.DataSource = dbc.GetAll();
                cbCAT.SelectedValue = 13;
                DBCableList dbcab = new DBCableList();
                dgWP.DataSource = dbcab.GetAllCables();
                ShowDGV_CABLE();
            }
            if (WPT == WPTYPE.ZHGUTLIST)
            {
                DBCategory dbc = new DBCategory("ZHGUTLIST");
                cbCAT.ValueMember = "ID";
                cbCAT.DisplayMember = "CATEGORYNAME";
                cbCAT.DataSource = dbc.GetAll();
                cbCAT.SelectedValue = 15;
                DBZhgutList dbz = new DBZhgutList();
                dgWP.DataSource = dbz.GetAllZhguts();
                ShowDGV_ZHGUT();
            }

            


        }

        private void ShowDGV()
        {
            dgWP.Columns["ID"].Visible = false;
            dgWP.Columns["CATEGORYNAME"].HeaderText = "Категория";
            dgWP.Columns["SUBCATNAME"].HeaderText = "Подкатегория";
            dgWP.Columns["DECNUM"].HeaderText = "Децимальный номер";
            dgWP.Columns["NOTE"].HeaderText = "Примечание";
            dgWP.Columns["SUBCATNAME"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgWP.Columns["CATEGORYNAME"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgWP.Columns["DECNUM"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgWP.Columns["NOTE"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgWP.Columns["CATEGORYNAME"].FillWeight = 100;
            dgWP.Columns["SUBCATNAME"].FillWeight = 100;
            dgWP.Columns["DECNUM"].FillWeight = 200;
            dgWP.Columns["NOTE"].FillWeight = 200;

        }

        private void ShowDGV_ZHGUT()
        {
            ShowDGV();
            dgWP.Columns["ZHGUTNAME"].HeaderText = "Наименование жгута";
            dgWP.Columns["ZHGUTPATH"].HeaderText = "Жгут изготовление";
            foreach (DataGridViewRow r in dgWP.Rows)
            {
                r.Cells["ZHGUTPATH"].Tag = r.Cells["ZHGUTPATH"].Value;
                r.Cells["ZHGUTPATH"].Value = r.Cells["ZHGUTPATH"].Tag.ToString().Substring(r.Cells["ZHGUTPATH"].Tag.ToString().LastIndexOf("\\") + 1);
            }
            dgWP.Columns["ZHGUTNAME"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgWP.Columns["ZHGUTPATH"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgWP.Columns["ZHGUTNAME"].FillWeight = 250;
            dgWP.Columns["ZHGUTPATH"].FillWeight = 250;
        }
        private void ShowDGV_CABLE()
        {
            ShowDGV();
            dgWP.Columns["CABLENAME"].HeaderText = "Наименование кабеля";
            dgWP.Columns["DIMENSIONALDRAWING"].HeaderText = "Сборочный чертёж";
            dgWP.Columns["CONNECTORS"].HeaderText = "Соединители";
            dgWP.Columns["CLENGTH"].HeaderText = "Длина";

            foreach (DataGridViewRow r in dgWP.Rows)
            {
                r.Cells["DIMENSIONALDRAWING"].Tag = r.Cells["DIMENSIONALDRAWING"].Value;
                r.Cells["DIMENSIONALDRAWING"].Value = r.Cells["DIMENSIONALDRAWING"].Tag.ToString().Substring(r.Cells["DIMENSIONALDRAWING"].Tag.ToString().LastIndexOf("\\") + 1);
            }
            dgWP.Columns["CONNECTORS"].FillWeight = 150;
            dgWP.Columns["CLENGTH"].FillWeight = 70;
            dgWP.Columns["CABLENAME"].FillWeight = 250;
            dgWP.Columns["DIMENSIONALDRAWING"].FillWeight = 250;
            dgWP.Columns["CABLENAME"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgWP.Columns["DIMENSIONALDRAWING"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgWP.Columns["CONNECTORS"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgWP.Columns["CLENGTH"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

        }




        public int PickedID;
        public WPTYPE PickedType;
        private void bChoose_Click(object sender, EventArgs e)//Выбрать
        {
            if (dgWP.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите изделие!");
                return;
            }
            PickedID = (int)dgWP.SelectedRows[0].Cells["ID"].Value;
            if (WPT == WPTYPE.ZHGUTLIST)
            {
                PickedType = WPTYPE.ZHGUTLIST;
            }
            if (WPT == WPTYPE.CABLELIST)
            {
                PickedType = WPTYPE.CABLELIST;
            }

            Close();
        }

        private void dgWP_DoubleClick(object sender, EventArgs e)
        {
            if (bChoose.Visible == true)
            {
                PickedID = (int)dgWP.SelectedRows[0].Cells["ID"].Value;
                Close();
            }

        }

       
        private void cbCAT_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((cbCAT.Text.ToUpper() == "ВСЕ") || (cbCAT.Text.ToUpper() == "НЕ ПРИСВОЕНО"))
            {
                cbSubCat.Text = "";
                cbSubCat.Enabled = false;
            }
            else
            {
                cbSubCat.Enabled = true;
                DBSubCategory dbs = new DBSubCategory();
                cbSubCat.ValueMember = "ID";
                cbSubCat.DisplayMember = "SUBCATNAME";
                cbSubCat.DataSource = dbs.GetAll(Convert.ToInt32(cbCAT.SelectedValue));
                //cbSubCat.SelectedItem = cbCAT.Items[0];
                cbSubCat.SelectedIndex = 1;
            }
            switch (WPT)
            {
                case  WPTYPE.ZHGUTLIST://zhgut
                    FillDGV_ZHGUTLIST();
                    break;
                case  WPTYPE.CABLELIST://cable
                    FillDGV_CABLELIST();
                    break;
            }

        }
        private void cbSubCat_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (WPT)
            {
                case  WPTYPE.ZHGUTLIST://zhgut
                    dgWP.DataSource = new DBZhgutList().GetCategoryZhgutList(Convert.ToInt32(cbCAT.SelectedValue), Convert.ToInt32(cbSubCat.SelectedValue));
                    break;
                case  WPTYPE.CABLELIST://cable
                    dgWP.DataSource = new DBCableList().GetCategoryCableList(Convert.ToInt32(cbCAT.SelectedValue), Convert.ToInt32(cbSubCat.SelectedValue));
                    break;
            }
            

        }




        private void FillDGV_ZHGUTLIST()
        {           
            if (cbSubCat.Enabled)
            {
                dgWP.DataSource = new DBZhgutList().GetCategoryZhgutList(Convert.ToInt32(cbCAT.SelectedValue), Convert.ToInt32(cbSubCat.SelectedValue));
            }
            else
            {
                dgWP.DataSource = new DBZhgutList().GetCategoryZhgutList(Convert.ToInt32(cbCAT.SelectedValue));
            }
            ShowDGV_ZHGUT();
        }
        private void FillDGV_CABLELIST()
        {
            if (cbSubCat.Enabled)
            {
                dgWP.DataSource = new DBCableList().GetCategoryCableList(Convert.ToInt32(cbCAT.SelectedValue), Convert.ToInt32(cbSubCat.SelectedValue));
            }
            else
            {
                dgWP.DataSource = new DBCableList().GetCategoryCableList(Convert.ToInt32(cbCAT.SelectedValue));
            }
            ShowDGV_CABLE();
        }

        private void dgWP_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            bview_Click_1(sender, e);
        }

        private void bview_Click_1(object sender, EventArgs e)
        {
            if (dgWP.SelectedRows.Count == 0)
            {
                return;
            }
            if (WPT == WPTYPE.ZHGUTLIST)
            {
                NewZHGUT ew = new NewZHGUT(ZhgutVO.GetZhgutVOByID(Convert.ToInt32(dgWP.SelectedRows[0].Cells["ID"].Value)), "VIEWONLY", UVO);
                ew.ShowDialog();
            }
            if (WPT == WPTYPE.CABLELIST)
            {
                NewCABLE ew = new NewCABLE(CableVO.GetCableVOByID(Convert.ToInt32(dgWP.SelectedRows[0].Cells["ID"].Value)), "VIEWONLY", UVO);
                ew.ShowDialog();
            }
        }





        internal int getCount()
        {
            return Convert.ToInt32(numericUpDown1.Value);
        }
    }
}
