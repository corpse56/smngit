using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SummonManager.CLASSES;

namespace SummonManager
{
    public partial class EditWPN : Form
    {
        int IDW;
        bool viewonly = false;
        public EditWPN(int idw,bool viewOnly)
        {
            InitializeComponent();
            if (viewOnly)
            {
                this.viewonly = viewOnly;
                button2.Visible = false;
                this.Text = "Просмотр сведений об изделии";
                tbName.ReadOnly = true;
                tbNote.ReadOnly = true;
                tbPowerSupply.ReadOnly = true;
                tbDecNum.ReadOnly = true;
                tbConfiguration.ReadOnly = true;
                cbCategory.Enabled = false;
                cbSubCategory.Enabled = false;
            }
            this.IDW = idw;
            DBWPName dbwp = new DBWPName();
            WPNameVO wp = WPNameVO.WPNameVOByID(this.IDW);
            tbName.Text = wp.WPName;
            cbCategory.SelectedValue = wp.IDCat;
            cbSubCategory.SelectedValue = wp.IDSubCat;
            tbDecNum.Text = wp.DecNum;
            tbPowerSupply.Text = wp.PowerSupply;
            tbConfiguration.Text = wp.CONFIGURATION;
            tbNote.Text = wp.Note;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (tbName.Text == "")
            {
                MessageBox.Show("Введите наименование!");
                return;
            }

            DBWPName dbwp = new DBWPName();
            WPNameVO wp = new WPNameVO();
            wp.WPName = tbName.Text;
            wp.IDCat = Convert.ToInt32(cbCategory.SelectedValue);
            wp.IDSubCat = Convert.ToInt32(cbSubCategory.SelectedValue);
            wp.DecNum = tbDecNum.Text;
            wp.COMPOSITION = pfComposition.FullPath;//.bOpen.Tag.ToString();
            wp.DIMENDRAWING = pfDimDrawing.FullPath;//.bOpen.Tag.ToString();
            wp.PowerSupply = tbPowerSupply.Text;
            wp.CONFIGURATION = tbConfiguration.Text;
            wp.Note = tbNote.Text;
            wp.ID = this.IDW;
            dbwp.EditWP(wp);
            MessageBox.Show("Наименование успешно изменено!");
            Close();
        }

        private void EditWPN_Load(object sender, EventArgs e)
        {
            DBCategory dbc = new DBCategory("WPNAMELIST");
            cbCategory.ValueMember = "ID";
            cbCategory.DisplayMember = "CATEGORYNAME";
            cbCategory.DataSource = dbc.GetAllExceptAll();

            DBWPName dbwp = new DBWPName();
            WPNameVO wp = WPNameVO.WPNameVOByID(this.IDW);

            cbCategory.SelectedValue = wp.IDCat;

            LoadSubs((int)cbCategory.SelectedValue);


        }
        private void LoadSubs(int idCat)
        {
            if ((idCat == 1) || (idCat == 2))
            {
                cbSubCategory.Text = "";
                cbSubCategory.Enabled = false;
            }
            if (!viewonly)
            {
                cbSubCategory.Enabled = true;
            }
            DBSubCategory dbs = new DBSubCategory();
            cbSubCategory.ValueMember = "ID";
            cbSubCategory.DisplayMember = "SUBCATNAME";
            cbSubCategory.DataSource = dbs.GetAllExceptAll(idCat);

            DBWPName dbwp = new DBWPName();
            WPNameVO wp = WPNameVO.WPNameVOByID(this.IDW);
            cbSubCategory.SelectedValue = wp.IDSubCat;
            
        }

        private void cbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadSubs((int)cbCategory.SelectedValue);

        }

    }
}
