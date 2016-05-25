using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SummonManager.Controls;

namespace SummonManager.CLASSES
{
    public static class UIWorks
    {
        public static void AddToTLP(TableLayoutPanel TLP,string LableText,PathField pf)
        {
            TLP.RowCount = TLP.RowCount + 1;
            TLP.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            Label l = new Label();
            l.Text = LableText;
            l.AutoSize = false;
            l.Size = new System.Drawing.Size(174, 38);
            
            TLP.Controls.Add(l, 0, TLP.RowCount - 1);
            TLP.Controls.Add(pf, 1, TLP.RowCount - 1);
        }


        internal static void AddToTLP(TableLayoutPanel TLP, string LableText, TextBox tb)
        {
            TLP.RowCount = TLP.RowCount + 1;
            TLP.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            Label l = new Label();
            l.Text = LableText;
            l.AutoSize = false;
            l.Size = new System.Drawing.Size(174, 38);

            TLP.Controls.Add(l, 0, TLP.RowCount - 1);
            TLP.Controls.Add(tb, 1, TLP.RowCount - 1);
        }
    }
}
