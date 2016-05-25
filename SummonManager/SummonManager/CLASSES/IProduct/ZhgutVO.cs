using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SummonManager.CLASSES.IRole_namespace;
using SummonManager.Controls;

namespace SummonManager.CLASSES
{
    public class ZhgutVO :IProduct
    {
        public ZhgutVO() { }

        public static ZhgutVO GetZhgutVOByID(int ID)
        {
            return new DBZhgutList().GetZhgutVOByID(ID);

        }
        public WPTYPE WPType;
        public int ID;
        public string WPName;
        public int IDCat;
        public int IDSubCat;
        public string DecNum;
        public string ZHGUTPATH;
        public string NOTE;

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
            NewZHGUT f = new NewZHGUT(this, "VIEWONLY", UVO);
            f.ShowDialog();
        }
        void IProduct.ViewEdit(IRole UVO)
        {
            NewZHGUT f = new NewZHGUT(this, "EDIT", UVO);
            f.ShowDialog();
        }
        void IProduct.FillTableLayoutPanel(TableLayoutPanel TLP, IRole UVO)
        {
            ZhgutVO wp = (ZhgutVO)this;

            TextBox tb = new TextBox();
            DBCategory dbc = new DBCategory("ZHGUTLIST");
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
            pf.Init(wp.ZHGUTPATH, true, false, false, true, Roles.Inzhener, UVO.Role, "VIEWONLY");
            pf.bDelVisible = false;
            pf.bPathVisible = false;
            pf.tbPath.Dock = DockStyle.Fill;
            pf.Dock = DockStyle.Fill;
            UIWorks.AddToTLP(TLP, "Изготовление жгута", pf);

        }

        
    }
}
