using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SummonManager.Controls;
using SummonManager.CLASSES.IRole_namespace;
using System.Drawing;

namespace SummonManager.CLASSES
{
    public enum WPTYPE { WPNAMELIST, CABLELIST, ZHGUTLIST}
    public static class WPTYPETOSTRING
    {
        public static string ToString(WPTYPE WPT)
        {
            switch (WPT)
            {
                case WPTYPE.WPNAMELIST:
                    return "WPNAMELIST";
                case WPTYPE.ZHGUTLIST:
                    return "ZHGUTLIST";
                case WPTYPE.CABLELIST:
                    return "CABLELIST";
            }
            return "";
        }
    }


    public class WPNameVO : IProduct
    {
        
        public WPNameVO()
        {
            //DBWPName dbwp = new DBWPName();
            //this = dbwp.GetWP(ID);
            //this.WPType = wpt;
            
        }
        internal static WPNameVO WPNameVOByID(int id)
        {
            return new DBWPName().GetWPNameByID(id);
        }

        public WPTYPE WPType; 
        public int ID;
        public string WPName;
        public int IDCat;
        public int IDSubCat;
        public string DecNum;
        public string WIRINGDIAGRAM;
        public string TECHREQ;
        public string COMPOSITION;
        public string CONFIGURATION;
        public string DIMENDRAWING;
        public string SBORKA3D;
        public string MECHPARTS;
        public List<ZhgutVO> ZHGUTS;
        public List<CableVO> CABLES;
        public string SHILDS;
        public string PACKAGING;
        public string PASSPORT;
        public string MANUAL;
        public string PACKINGLIST;
        public string PowerSupply;
        public string Note;

        public bool COMPOSITIONREQ;
        public bool DIMENSIONALDRAWINGREQ	;
        //public bool POWERSUPPLYREQ	;
        public bool CONFIGURATIONREQ;	
        public bool WIRINGDIAGRAMREQ;	
        public bool TECHREQREQ	;
        public bool SBORKA3DREQ	;
        public bool MECHPARTSREQ;	
        public bool SHILDSREQ	;
        public bool PACKAGINGREQ	;
        public bool PASSPORTREQ	;
        public bool MANUALREQ	;
        public bool PACKINGLISTREQ	;
        public bool SOFTWAREREQ	;
        public bool CABLELISTREQ;	
        public bool ZHGUTLISTREQ;	
        public bool RUNCARDLISTREQ	;
        public bool CIRCUITBOARDLISTREQ;

        public string LENGTH;
        public string WIDTH;
        public string HEIGHT;
        public string WEIGHT;


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
            NewWPN f = new NewWPN(this, "VIEWONLY", UVO);
            f.ShowDialog();
        }
        void IProduct.ViewEdit(IRole UVO)
        {
            NewWPN f = new NewWPN(this, "EDIT", UVO);
            f.ShowDialog();
        }
        void IProduct.FillTableLayoutPanel(TableLayoutPanel TLP, IRole UVO)
        {
            //===============================================================Inzhener
            WPNameVO wp = (WPNameVO)this;
            if (wp.COMPOSITIONREQ)
            {
                PathField pf = new PathField();
                pf.Tag = Roles.Inzhener;
                pf.Init(wp.COMPOSITION, true, false, false, true, Roles.Inzhener, "VIEWONLY", UVO, "COMPOSITION",null,wp);
                pf.bDelVisible = false;
                pf.bPathVisible = false;
                pf.tbPath.Dock = DockStyle.Fill;
                pf.Dock = DockStyle.Fill;
                //pf.tbPath.Dock = DockStyle.Left;
                //pf.tbPath.Anchor = AnchorStyles.Left | AnchorStyles.Right;
                pf.bRemark.Visible = false;
                UIWorks.AddToTLP(TLP, "Состав изделия", pf);
            }
            if (wp.TECHREQREQ)
            {
                PathField pf = new PathField();
                pf.Tag = Roles.Inzhener;
                pf.Init(wp.TECHREQ, true, false, false, true, Roles.Inzhener, "VIEWONLY", UVO, "TECHREQ", null, wp);
                pf.bDelVisible = false;
                pf.bPathVisible = false;
                pf.tbPath.Dock = DockStyle.Fill;
                pf.Dock = DockStyle.Fill;
                pf.bRemark.Visible = false;
                UIWorks.AddToTLP(TLP, "Технические требования", pf);
            }
            if (wp.CONFIGURATIONREQ)
            {
                PathField pf = new PathField();
                pf.Tag = Roles.Inzhener;
                pf.Init(wp.CONFIGURATION, true, false, false, true, Roles.Inzhener, "VIEWONLY", UVO, "CONFIGURATION", null, wp);
                pf.bDelVisible = false;
                pf.bPathVisible = false;
                pf.tbPath.Dock = DockStyle.Fill;
                pf.Dock = DockStyle.Fill;
                pf.bRemark.Visible = false;
                UIWorks.AddToTLP(TLP, "Конфигурация", pf);
            }
            //===============================================================Constructor
            if (wp.DIMENSIONALDRAWINGREQ)
            {
                PathField pf = new PathField();
                pf.Tag = Roles.Constructor;
                pf.Init(wp.DIMENDRAWING, true, false, false, true, Roles.Constructor, "VIEWONLY", UVO, "DIMENSIONALDRAWING", null, wp);
                pf.bDelVisible = false;
                pf.bPathVisible = false;
                pf.tbPath.Dock = DockStyle.Fill;
                pf.Dock = DockStyle.Fill;
                pf.bRemark.Visible = false;
                UIWorks.AddToTLP(TLP, "Габаритный чертёж", pf);
            }
            if (wp.SBORKA3DREQ)
            {
                PathField pf = new PathField();
                pf.Tag = Roles.Constructor;
                pf.Init(wp.SBORKA3D, true, false, false, true, Roles.Constructor, "VIEWONLY", UVO, "SBORKA3D", null, wp);
                pf.bDelVisible = false;
                pf.bPathVisible = false;
                pf.tbPath.Dock = DockStyle.Fill;
                pf.Dock = DockStyle.Fill;
                pf.bRemark.Visible = false;
                UIWorks.AddToTLP(TLP, "3Д сборка", pf);
            }
            if (wp.MECHPARTSREQ)
            {
                PathField pf = new PathField();
                pf.Tag = Roles.Constructor;
                pf.Init(wp.MECHPARTS, true, false, false, true, Roles.Constructor, "VIEWONLY", UVO, "MECHPARTS", null, wp);
                pf.bDelVisible = false;
                pf.bPathVisible = false;
                pf.tbPath.Dock = DockStyle.Fill;
                pf.Dock = DockStyle.Fill;
                pf.bRemark.Visible = false;
                UIWorks.AddToTLP(TLP, "Проект механических деталей", pf);
            }
            if (wp.SHILDSREQ)
            {
                PathField pf = new PathField();
                pf.Tag = Roles.Constructor;
                pf.Init(wp.SHILDS, true, false, false, true, Roles.Constructor, "VIEWONLY", UVO, "SHILDS", null, wp);
                pf.bDelVisible = false;
                pf.bPathVisible = false;
                pf.tbPath.Dock = DockStyle.Fill;
                pf.Dock = DockStyle.Fill;
                pf.bRemark.Visible = false;
                UIWorks.AddToTLP(TLP, "Шильды", pf);
            }
            /*if (wp.PLANKAREQ)
            {
                PathField pf = new PathField();
                pf.Tag = Roles.Constructor;
                pf.Init(wp.PLANKA, true, false, false, true, Roles.Constructor, UVO.Role);
                pf.bDelVisible = false;
                pf.bPathVisible = false;
                pf.tbPath.Width += 150;
                UIWorks.AddToTLP(TLP, "Планка фирменная", pf);
            }*/
            if (wp.PACKAGINGREQ)
            {
                PathField pf = new PathField();
                pf.Tag = Roles.Constructor;
                pf.Init(wp.PACKAGING, true, false, false, true, Roles.Constructor, "VIEWONLY", UVO, "PACKAGING", null, wp);
                pf.bDelVisible = false;
                pf.bPathVisible = false;
                pf.tbPath.Dock = DockStyle.Fill;
                pf.Dock = DockStyle.Fill;
                pf.bRemark.Visible = false;
                UIWorks.AddToTLP(TLP, "Упаковка", pf);
            }
            //===================================================================================TEHNOLOG

            //===================================================================================shemotehbik
            if (wp.WIRINGDIAGRAMREQ)
            {
                PathField pf = new PathField();
                pf.Tag = Roles.Shemotehnik;
                pf.Init(wp.WIRINGDIAGRAM, true, false, false, true, Roles.Shemotehnik, "VIEWONLY", UVO, "WIRINGDIAGRAM", null, wp);
                pf.bDelVisible = false;
                pf.bPathVisible = false;
                pf.tbPath.Dock = DockStyle.Fill;
                pf.Dock = DockStyle.Fill;
                pf.bRemark.Visible = false;
                UIWorks.AddToTLP(TLP, "Схема электрическая монтажная", pf);
            }




            //===================================================================================OTD
            //if (wp.PASSPORTREQ)
            //{
            //    PathField pf = new PathField();
            //    pf.Tag = Roles.OTD;
            //    pf.Init(wp.PASSPORT, true, false, false, true, Roles.OTD, UVO.Role, "VIEWONLY");
            //    pf.bDelVisible = false;
            //    pf.bPathVisible = false;
            //    pf.tbPath.Dock = DockStyle.Fill;
            //    pf.Dock = DockStyle.Fill;
            //    UIWorks.AddToTLP(TLP, "Паспорт/ЭТ", pf);
            //}
            //if (wp.MANUALREQ)
            //{
            //    PathField pf = new PathField();
            //    pf.Tag = Roles.OTD;
            //    pf.Init(wp.MANUAL, true, false, false, true, Roles.OTD, UVO.Role, "VIEWONLY");
            //    pf.bDelVisible = false;
            //    pf.bPathVisible = false;
            //    pf.tbPath.Dock = DockStyle.Fill;
            //    pf.Dock = DockStyle.Fill;
            //    UIWorks.AddToTLP(TLP, "РЭ", pf);
            //}
            //if (wp.PACKINGLISTREQ)
            //{
            //    PathField pf = new PathField();
            //    pf.Tag = Roles.OTD;
            //    pf.Init(wp.PACKINGLIST, true, false, false, true, Roles.OTD, UVO.Role, "VIEWONLY");
            //    pf.bDelVisible = false;
            //    pf.bPathVisible = false;
            //    pf.tbPath.Dock = DockStyle.Fill;
            //    pf.Dock = DockStyle.Fill;
            //    UIWorks.AddToTLP(TLP, "Лист упаковочный", pf);
            //}

            
            //===================================================================================OTK
            /*if (wp.SERIALREQ)
            {
                PathField pf = new PathField();
                pf.Tag = Roles.OTK;
                pf.Init(wp.SERIAL, true, false, false, true, Roles.OTK, UVO.Role);
                pf.bDelVisible = false;
                pf.bPathVisible = false;
                pf.tbPath.Width += 150;
                UIWorks.AddToTLP(TLP, "Серийные номера", pf);
            }*/

            TextBox tb = new TextBox();
            tb.Tag = Roles.OTK;
            tb.Text = wp.LENGTH;
            tb.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tb.ReadOnly = true;
            tb.Dock = DockStyle.Fill;
            if ((tb.Text == "") && (UVO.Role == Roles.OTK))
            {
                tb.BackColor = Color.Tomato;
            }
            UIWorks.AddToTLP(TLP, "Длина", tb);

            tb = new TextBox();
            tb.Tag = Roles.OTK;
            tb.Text = wp.WIDTH;
            tb.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tb.ReadOnly = true;
            tb.Dock = DockStyle.Fill;
            if ((tb.Text == "") && (UVO.Role == Roles.OTK))
            {
                tb.BackColor = Color.Tomato;
            }
            UIWorks.AddToTLP(TLP, "Ширина", tb);

            tb = new TextBox();
            tb.Tag = Roles.OTK;
            tb.Text = wp.HEIGHT;
            tb.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tb.ReadOnly = true;
            tb.Dock = DockStyle.Fill;
            if ((tb.Text == "") && (UVO.Role == Roles.OTK))
            {
                tb.BackColor = Color.Tomato;
            }
            UIWorks.AddToTLP(TLP, "Высота", tb);

            tb = new TextBox();
            tb.Tag = Roles.OTK;
            tb.Text = wp.WEIGHT;
            tb.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tb.ReadOnly = true;
            tb.Dock = DockStyle.Fill;
            if ((tb.Text == "") && (UVO.Role == Roles.OTK))
            {
                tb.BackColor = Color.Tomato;
            }
            UIWorks.AddToTLP(TLP, "Вес", tb);

        }



    }
}
