using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SummonManager.CLASSES;
using SummonManager.CLASSES.IRole_namespace;

namespace SummonManager.Controls
{
    public partial class PickWPName : UserControl
    {
        IRole UVO;
        public PickWPName(IRole UVO_)
        {
            InitializeComponent();
            this.UVO = UVO_;
        }
        public PickWPName()
        {
            InitializeComponent();
        }
        public void Init(IRole uvo)
        {
            this.UVO = uvo;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            WPName wp = new WPName(true,UVO, WPTYPE.WPNAMELIST,false);
            wp.ShowDialog();
            if (wp.PickedID == 0)
            {
                return;
            }

            PickedProduct = ProductFactory.Create(wp.PickedID, wp.PickedType);
            textBox1.Text = PickedProduct.GetName();
        }
        public IProduct PickedProduct;
    }
}
