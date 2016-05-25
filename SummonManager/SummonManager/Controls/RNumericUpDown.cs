using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SummonManager
{
    public partial class RNumericUpDown : NumericUpDown
    {
        public override void DownButton()
        {
            if (ReadOnly)
                return;
            base.DownButton();
        }

        public override void UpButton()
        {
            if (ReadOnly)
                return;
            base.UpButton();
        }
    }
}
