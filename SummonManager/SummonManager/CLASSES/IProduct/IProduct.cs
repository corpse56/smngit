using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SummonManager.CLASSES.IRole_namespace;

namespace SummonManager.CLASSES
{
    public interface IProduct
    {
        string GetName();
        WPTYPE GetProductType();
        int GetID();
        void ViewOnly(IRole UVO);
        void ViewEdit(IRole UVO);

        void FillTableLayoutPanel(TableLayoutPanel TLP, IRole UVO);

    }
    class ProductFactory
    {

        public static IProduct Create(int ID, string WPTYPE)
        {
            switch (WPTYPE)
            {
                case "WPNAMELIST":
                    return WPNameVO.WPNameVOByID(ID);

                case "ZHGUTLIST":
                    return ZhgutVO.GetZhgutVOByID(ID);

                case "CABLELIST":
                    return CableVO.GetCableVOByID(ID);

            }
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Неизвестный тип продукта : \"{0}\"!", WPTYPE);

            throw new Exception(sb.ToString());
        }



        internal static IProduct Create(int ID, WPTYPE wPTYPE)
        {
            return ProductFactory.Create(ID, WPTYPETOSTRING.ToString(wPTYPE));
        }

        internal static IProduct Create(string ID, string wPTYPE)
        {
            return ProductFactory.Create(int.Parse(ID), wPTYPE);
        }
    }
}
