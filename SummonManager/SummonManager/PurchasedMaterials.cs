using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SummonManager
{
    public partial class PurchasedMaterials : Form
    {
        string IDS;
        public PurchasedMaterials(string IDS_)
        {
            InitializeComponent();
            this.IDS = IDS_;

        }

        private void PurchasedMaterials_Load(object sender, EventArgs e)
        {
            DBPURCHASEDMATERIALS dbpm = new DBPURCHASEDMATERIALS();
            PurchMaterials pm = new PurchMaterials();
            pm = dbpm.Get(IDS);
            chbHardwareForOrder.Checked = pm.HARDWAREFORORDER;
            chbHardwareInStock.Checked = pm.HARDWAREINSTOCK;
            chbHardwareForeignForOrder.Checked = pm.HARWAREFOREIGNFORORDER;
            chbHardwareForeignInStock.Checked = pm.HARWAREFOREIGNINSTOCK;
            chbConnectorsForOrder.Checked = pm.CONNECTORSFORORDER;
            chbConnectorsInStock.Checked = pm.CONNECTORSINSTOCK;
            chbMaterialsAndFastenersForOrder.Checked = pm.MATERIALSANDFASTENERSFORORDER;
            chbMaterialsAndFastenersInStock.Checked = pm.MATERIALSANDFASTENERSINSTOCK;
            chbShildsForOrder.Checked = pm.SHILDSFORORDER;
            chbShildsInStock.Checked = pm.SHILDSINSTOCK;
            chbPackingForOrder.Checked = pm.PACKINGFORORDER;
            chbPackingInStock.Checked = pm.PACKINGINSTOCK;

        }

        private void bCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bSave_Click(object sender, EventArgs e)
        {
            DBPURCHASEDMATERIALS dbpm = new DBPURCHASEDMATERIALS();
            PurchMaterials pm = dbpm.Get(IDS);
            
            pm.HARDWAREFORORDER = chbHardwareForOrder.Checked ;
            pm.HARDWAREINSTOCK = chbHardwareInStock.Checked;
            pm.HARWAREFOREIGNFORORDER = chbHardwareForeignForOrder.Checked ;
            pm.HARWAREFOREIGNINSTOCK = chbHardwareForeignInStock.Checked;
            pm.CONNECTORSFORORDER = chbConnectorsForOrder.Checked;
            pm.CONNECTORSINSTOCK = chbConnectorsInStock.Checked ;
            pm.MATERIALSANDFASTENERSFORORDER = chbMaterialsAndFastenersForOrder.Checked ;
            pm.MATERIALSANDFASTENERSINSTOCK = chbMaterialsAndFastenersInStock.Checked ;
            pm.SHILDSFORORDER = chbShildsForOrder.Checked ;
            pm.SHILDSINSTOCK = chbShildsInStock.Checked ;
            pm.PACKINGFORORDER = chbPackingForOrder.Checked ;
            pm.PACKINGINSTOCK = chbPackingInStock.Checked ;

            
            dbpm.Save(pm, IDS);
            MessageBox.Show("Сохранено успешно!");
            Close();
        }
    }
}
