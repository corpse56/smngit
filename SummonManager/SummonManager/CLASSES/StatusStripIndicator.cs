using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using SummonManager.CLASSES.IRole_namespace;

namespace SummonManager.CLASSES
{
    class StatusStripIndicator
    {
        StatusStrip SS;
        ToolStripStatusLabel tslVersionLabel;

        ToolStripStatusLabel tslConnectors;
        ToolStripStatusLabel tslConnectorsForOrder;
        ToolStripStatusLabel tslConnectorsInStock;
        ToolStripStatusLabel tslFasteners;
        ToolStripStatusLabel tslFastenersForOrder;
        ToolStripStatusLabel tslFastenersInStock;
        ToolStripStatusLabel tslHardwareForeign;
        ToolStripStatusLabel tslHardwareForeignForOrder;
        ToolStripStatusLabel tslHardwareForeignInStock;
        ToolStripStatusLabel tslHardware;
        ToolStripStatusLabel tslHardwareForOrder;
        ToolStripStatusLabel tslHardwareInStock;
        ToolStripStatusLabel tslPacking;
        ToolStripStatusLabel tslPackingForOrder;
        ToolStripStatusLabel tslPackingInStock;
        ToolStripStatusLabel tslShild;
        ToolStripStatusLabel tslShildForOrder;
        ToolStripStatusLabel tslShildInStock;
        ToolStripStatusLabel tslWideSpace;
        ToolStripStatusLabel tslNarrowSpace;

        ToolStripStatusLabel tslBillPayedColor;
        ToolStripStatusLabel tslDocsReadyColor;
        ToolStripStatusLabel tslBillPayedText;
        ToolStripStatusLabel tslDocsReadyText;
        Roles ROLE;
        public StatusStripIndicator(StatusStrip ss, Roles role, ToolStripStatusLabel tslVersion)
        {
            SS = ss;
            tslVersionLabel = (ToolStripStatusLabel)SS.Items["tslVersionLabel"];
            ClearStatusStrip();
            ROLE = role;
                //case Roles.Buhgalter: case Roles.Manager:
            tslBillPayedColor = new ToolStripStatusLabel();
            tslBillPayedColor.Text = "   ";
            SS.Items.Insert(SS.Items.IndexOf(tslVersionLabel), tslBillPayedColor);
            tslBillPayedText = new ToolStripStatusLabel();
            tslBillPayedText.Text = "Счёт оплачен 100%;";
            SS.Items.Add(tslBillPayedText);
            SS.Items.Insert(SS.Items.IndexOf(tslVersionLabel), tslBillPayedText);

            tslDocsReadyColor = new ToolStripStatusLabel();
            tslDocsReadyColor.Text = "   ";
            SS.Items.Insert(SS.Items.IndexOf(tslVersionLabel), tslDocsReadyColor);
            tslWideSpace = new ToolStripStatusLabel();
            tslWideSpace.Text = "    ";
            SS.Items.Insert(SS.Items.IndexOf(tslVersionLabel), tslWideSpace);
            tslDocsReadyText = new ToolStripStatusLabel();
            tslDocsReadyText.Text = "Документы готовы;";
            SS.Items.Insert(SS.Items.IndexOf(tslVersionLabel), tslDocsReadyText);
                    //break;
            switch (role)
            {
                case Roles.Ozis:
                    tslWideSpace = new ToolStripStatusLabel();
                    tslWideSpace.Text = "    ";

                    tslHardwareForOrder = new ToolStripStatusLabel();
                    tslHardwareForOrder.Text = "   ";
                    SS.Items.Insert(SS.Items.IndexOf(tslVersionLabel), tslHardwareForOrder);
                    tslNarrowSpace = new ToolStripStatusLabel();
                    tslNarrowSpace.Text = " ";
                    SS.Items.Insert(SS.Items.IndexOf(tslVersionLabel), tslNarrowSpace);
                    tslHardwareInStock = new ToolStripStatusLabel();
                    tslHardwareInStock.Text = "   ";
                    SS.Items.Insert(SS.Items.IndexOf(tslVersionLabel), tslHardwareInStock);
                    tslHardware = new ToolStripStatusLabel();
                    tslHardware.Text = "Комплектующие;";
                    SS.Items.Insert(SS.Items.IndexOf(tslVersionLabel), tslHardware);
                    SS.Items.Insert(SS.Items.IndexOf(tslVersionLabel), tslWideSpace);

                    tslHardwareForeignForOrder = new ToolStripStatusLabel();
                    tslHardwareForeignForOrder.Text = "   ";
                    SS.Items.Insert(SS.Items.IndexOf(tslVersionLabel), tslHardwareForeignForOrder);
                    tslNarrowSpace = new ToolStripStatusLabel();
                    tslNarrowSpace.Text = " ";
                    SS.Items.Insert(SS.Items.IndexOf(tslVersionLabel), tslNarrowSpace);
                    tslHardwareForeignInStock = new ToolStripStatusLabel();
                    tslHardwareForeignInStock.Text = "   ";
                    SS.Items.Insert(SS.Items.IndexOf(tslVersionLabel), tslHardwareForeignInStock);
                    tslHardwareForeign = new ToolStripStatusLabel();
                    tslHardwareForeign.Text = "Комплектующие иностранные;;";
                    SS.Items.Insert(SS.Items.IndexOf(tslVersionLabel), tslHardwareForeign);
                    SS.Items.Insert(SS.Items.IndexOf(tslVersionLabel), tslWideSpace);

                    tslConnectorsForOrder = new ToolStripStatusLabel();
                    tslConnectorsForOrder.Text = "   ";
                    SS.Items.Insert(SS.Items.IndexOf(tslVersionLabel), tslConnectorsForOrder);
                    tslNarrowSpace = new ToolStripStatusLabel();
                    tslNarrowSpace.Text = " ";
                    SS.Items.Insert(SS.Items.IndexOf(tslVersionLabel), tslNarrowSpace);
                    tslConnectorsInStock = new ToolStripStatusLabel();
                    tslConnectorsInStock.Text = "   ";
                    SS.Items.Insert(SS.Items.IndexOf(tslVersionLabel), tslConnectorsInStock);
                    tslConnectors = new ToolStripStatusLabel();
                    tslConnectors.Text = "Соединители;";
                    SS.Items.Insert(SS.Items.IndexOf(tslVersionLabel), tslConnectors);
                    SS.Items.Insert(SS.Items.IndexOf(tslVersionLabel), tslWideSpace);

                    tslFastenersForOrder = new ToolStripStatusLabel();
                    tslFastenersForOrder.Text = "   ";
                    SS.Items.Insert(SS.Items.IndexOf(tslVersionLabel), tslFastenersForOrder);
                    tslNarrowSpace = new ToolStripStatusLabel();
                    tslNarrowSpace.Text = " ";
                    SS.Items.Insert(SS.Items.IndexOf(tslVersionLabel), tslNarrowSpace);
                    tslFastenersInStock = new ToolStripStatusLabel();
                    tslFastenersInStock.Text = "   ";
                    SS.Items.Insert(SS.Items.IndexOf(tslVersionLabel), tslFastenersInStock);
                    tslFasteners = new ToolStripStatusLabel();
                    tslFasteners.Text = "Материалы и крепёж;";
                    SS.Items.Insert(SS.Items.IndexOf(tslVersionLabel), tslFasteners);
                    SS.Items.Insert(SS.Items.IndexOf(tslVersionLabel), tslWideSpace);

                    tslShildForOrder = new ToolStripStatusLabel();
                    tslShildForOrder.Text = "   ";
                    SS.Items.Insert(SS.Items.IndexOf(tslVersionLabel), tslShildForOrder);
                    tslNarrowSpace = new ToolStripStatusLabel();
                    tslNarrowSpace.Text = " ";
                    SS.Items.Insert(SS.Items.IndexOf(tslVersionLabel), tslNarrowSpace);
                    tslShildInStock = new ToolStripStatusLabel();
                    tslShildInStock.Text = "   ";
                    SS.Items.Insert(SS.Items.IndexOf(tslVersionLabel), tslShildInStock);
                    tslShild = new ToolStripStatusLabel();
                    tslShild.Text = "Шильды;";
                    SS.Items.Insert(SS.Items.IndexOf(tslVersionLabel), tslShild);
                    SS.Items.Insert(SS.Items.IndexOf(tslVersionLabel), tslWideSpace);

                    tslPackingForOrder = new ToolStripStatusLabel();
                    tslPackingForOrder.Text = "   ";
                    SS.Items.Insert(SS.Items.IndexOf(tslVersionLabel), tslPackingForOrder);
                    tslNarrowSpace = new ToolStripStatusLabel();
                    tslNarrowSpace.Text = " ";
                    SS.Items.Insert(SS.Items.IndexOf(tslVersionLabel), tslNarrowSpace);
                    tslPackingInStock = new ToolStripStatusLabel();
                    tslPackingInStock.Text = "   ";
                    SS.Items.Insert(SS.Items.IndexOf(tslVersionLabel), tslPackingInStock);
                    tslPacking = new ToolStripStatusLabel();
                    tslPacking.Text = "Упаковка;";
                    SS.Items.Insert(SS.Items.IndexOf(tslVersionLabel), tslPacking);
                    SS.Items.Insert(SS.Items.IndexOf(tslVersionLabel), tslWideSpace);
                    break;
            }
        }
        public void PDBVisible()
        {
            tslConnectors.Visible = true;
            tslConnectorsForOrder.Visible = true;
            tslConnectorsInStock.Visible = true;
            tslFasteners.Visible = true;
            tslFastenersForOrder.Visible = true;
            tslFastenersInStock.Visible = true;
            tslHardwareForeign.Visible = true;
            tslHardwareForeignForOrder.Visible = true;
            tslHardwareForeignInStock.Visible = true;
            tslHardware.Visible = true;
            tslHardwareForOrder.Visible = true;
            tslHardwareInStock.Visible = true;
            tslPacking.Visible = true;
            tslPackingForOrder.Visible = true;
            tslPackingInStock.Visible = true;
            tslShild.Visible = true;
            tslShildForOrder.Visible = true;
            tslShildInStock.Visible = true;
            tslWideSpace.Visible = true;
            tslNarrowSpace.Visible = true;

        }
        public void PDBNOTVisible()
        {
            tslConnectors.Visible = false;
            tslConnectorsForOrder.Visible = false;
            tslConnectorsInStock.Visible = false;
            tslFasteners.Visible = false;
            tslFastenersForOrder.Visible = false;
            tslFastenersInStock.Visible = false;
            tslHardwareForeign.Visible = false;
            tslHardwareForeignForOrder.Visible = false;
            tslHardwareForeignInStock.Visible = false;
            tslHardware.Visible = false;
            tslHardwareForOrder.Visible = false;
            tslHardwareInStock.Visible = false;
            tslPacking.Visible = false;
            tslPackingForOrder.Visible = false;
            tslPackingInStock.Visible = false;
            tslShild.Visible = false;
            tslShildForOrder.Visible = false;
            tslShildInStock.Visible = false;
            tslWideSpace.Visible = false;
            tslNarrowSpace.Visible = false;
        }
        public void BuhManVisible()
        {
            tslBillPayedColor.Visible = true;
            tslBillPayedText.Visible = true;
            tslDocsReadyColor.Visible = true;
            tslWideSpace.Visible = true;
            tslDocsReadyText.Visible = true;
        }
        public void BuhManNotVisible()
        {
            tslBillPayedColor.Visible = false;
            tslBillPayedText.Visible = false;
            tslDocsReadyColor.Visible = false;
            tslWideSpace.Visible = false;
            tslDocsReadyText.Visible = false;
        }
        public void ClearStatusStrip()
        {
            SS.Items.Clear();
            SS.Items.Add(tslVersionLabel);
            //for (int i = 0; i < SS.Items.Count;i++ )
            //{
            //    if (SS.Items[i].Name != "tslVersionLabel")
            //    {
            //        SS.Items.Remove(SS.Items[i]);
            //    }
            //}
            //GC.Collect();
        }
        private bool visible = true;
        public bool Visible
        {
            get
            {
                return visible;
            }
            set
            {
                if (value)
                {
                    BuhManVisible();
                    switch (ROLE)
                    {
                        //case Roles.Manager: case Roles.Buhgalter:
                        //    BuhManVisible();
                        //    break;
                        case Roles.Ozis:
                            PDBVisible();
                            break;
                    }
                }
                else
                {
                    BuhManNotVisible();
                    switch (ROLE)
                    {
                        //case Roles.Manager: case Roles.Buhgalter:
                        //    BuhManNotVisible();
                        //    break;
                        case Roles.Ozis:
                            PDBNOTVisible();
                            break;
                    }
                }
            }
        }
        public void Paint(string IDSUMMON)
        {
            SummonVO SVO = SummonVO.SummonVOByID(IDSUMMON);
            tslBillPayedColor.BackColor = (SVO.BILLPAYED) ? Color.Green : Color.Red;
            tslDocsReadyColor.BackColor = (SVO.DOCSREADY) ? Color.Green : Color.Red;
            switch (ROLE)
            {
                //case Roles.Manager: case Roles.Buhgalter:
                    //SummonVO SVO = SummonVO.SummonVOByID(IDSUMMON);
                    //tslBillPayedColor.BackColor = (SVO.BILLPAYED) ? Color.Green : Color.Red;
                    //tslDocsReadyColor.BackColor = (SVO.DOCSREADY) ? Color.Green : Color.Red;
                    //break;
                case Roles.Ozis:
                    DBPURCHASEDMATERIALS dbpm_s = new DBPURCHASEDMATERIALS();
                    PurchMaterials pm_s;
                    pm_s = dbpm_s.Get(IDSUMMON);
                    tslConnectorsForOrder.BackColor = (pm_s.CONNECTORSFORORDER) ? Color.Green : Color.Red;
                    tslConnectorsInStock.BackColor = (pm_s.CONNECTORSINSTOCK) ? Color.Green : Color.Red;
                    tslFastenersForOrder.BackColor = (pm_s.MATERIALSANDFASTENERSFORORDER) ? Color.Green : Color.Red;
                    tslFastenersInStock.BackColor = (pm_s.MATERIALSANDFASTENERSINSTOCK) ? Color.Green : Color.Red;
                    tslHardwareForeignForOrder.BackColor = (pm_s.HARWAREFOREIGNFORORDER) ? Color.Green : Color.Red;
                    tslHardwareForeignInStock.BackColor = (pm_s.HARWAREFOREIGNINSTOCK) ? Color.Green : Color.Red;
                    tslHardwareForOrder.BackColor = (pm_s.HARDWAREFORORDER) ? Color.Green : Color.Red;
                    tslHardwareInStock.BackColor = (pm_s.HARDWAREINSTOCK) ? Color.Green : Color.Red;
                    tslPackingForOrder.BackColor = (pm_s.PACKINGFORORDER) ? Color.Green : Color.Red;
                    tslPackingInStock.BackColor = (pm_s.PACKINGINSTOCK) ? Color.Green : Color.Red;
                    tslShildForOrder.BackColor = (pm_s.SHILDSFORORDER) ? Color.Green : Color.Red;
                    tslShildInStock.BackColor = (pm_s.SHILDSINSTOCK) ? Color.Green : Color.Red;
                    break;
            }
        }
    }
}
