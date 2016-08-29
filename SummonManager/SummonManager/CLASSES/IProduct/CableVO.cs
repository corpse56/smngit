using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SummonManager.CLASSES.IRole_namespace;
using SummonManager.Controls;

namespace SummonManager.CLASSES
{
    public class CableVO : IProduct
    {
        public CableVO() 
        {
            this.WPType = WPTYPE.CABLELIST;
        }

        public static CableVO GetCableVOByID(int ID)
        {
            return new DBCableList().GetCableVOByID(ID);

        }
        public WPTYPE WPType;
        public int ID;
        public string WPName;
        public int IDCat;
        public int IDSubCat;
        public string DecNum;
        public string DIMENDRAWING;
        public string CONECTORS;
        public string CLENGTH;
        public string NOTE;
        public string MECHPARTS;

        string IProduct.GetName()
        {
            return WPName + " " + DecNum;
        }
        WPTYPE IProduct.GetProductType()
        {
            return this.WPType;
        }
        int IProduct.GetID()
        {
            return this.ID;
        }
        void IProduct.ViewOnly(IRole UVO)
        {
            NewCABLE f = new NewCABLE(this, "VIEWONLY", UVO);
            f.ShowDialog();
        }
        void IProduct.ViewEdit(IRole UVO)
        {
            NewCABLE f = new NewCABLE(this, "EDIT", UVO);
            f.ShowDialog();
        }

        void IProduct.FillTableLayoutPanel(TableLayoutPanel TLP, IRole UVO)
        {
            CableVO wp = (CableVO)this;

            TextBox tb = new TextBox();
            DBCategory dbc = new DBCategory("CABLELIST");
            tb.Text = dbc.GetName(wp.IDCat);
            tb.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tb.ReadOnly = true;
            tb.Dock = DockStyle.Fill;
            UIWorks.AddToTLP(TLP, "Категория", tb);

            tb = new TextBox();
            DBSubCategory dbsc = new DBSubCategory();
            tb.Text = dbsc.GetName(wp.IDSubCat);
            tb.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tb.ReadOnly = true;
            tb.Dock = DockStyle.Fill;
            UIWorks.AddToTLP(TLP, "Подкатегория", tb);

            PathField pf = new PathField();
            pf.Tag = Roles.Inzhener;
            pf.Init(wp.DIMENDRAWING, true, false, false, true, Roles.Inzhener, "VIEWONLY", UVO, "DIMENSIONALDRAWING_CABLE",null,wp);
            pf.bDelVisible = false;
            pf.bPathVisible = false;
            pf.tbPath.Width += 150;
            pf.tbPath.Dock = DockStyle.Fill;
            pf.Dock = DockStyle.Fill;
            pf.bRemark.Visible = false;

            UIWorks.AddToTLP(TLP, "Сборочный чертёж", pf);

            pf = new PathField();
            pf.Tag = Roles.Inzhener;
            pf.Init(wp.MECHPARTS, true, false, false, true, Roles.Inzhener, "VIEWONLY", UVO, "MECHPARTS_CABLE", null, wp);
            pf.bDelVisible = false;
            pf.bPathVisible = false;
            pf.tbPath.Width += 150;
            pf.tbPath.Dock = DockStyle.Fill;
            pf.Dock = DockStyle.Fill;
            pf.bRemark.Visible = false;

            UIWorks.AddToTLP(TLP, "Проект мех. деталей", pf);

            tb = new TextBox();
            tb.Text = wp.CONECTORS;
            tb.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tb.ReadOnly = true;
            tb.Dock = DockStyle.Fill;
            UIWorks.AddToTLP(TLP, "Соединители", tb);

            tb = new TextBox();
            tb.Text = wp.CLENGTH;
            tb.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tb.ReadOnly = true;
            tb.Dock = DockStyle.Fill;
            UIWorks.AddToTLP(TLP, "Длина", tb);

        }

    }
}
