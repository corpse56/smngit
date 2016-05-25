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
    public partial class ColorSelectControl : UserControl
    {
            public ColorSelectControl()
            {
                InitializeComponent();
            }

            private void panel1_Click(object sender, EventArgs e)
            {
                radioButton1.Checked = true;
            }

            private void panel2_Click(object sender, EventArgs e)
            {
                radioButton2.Checked = true;

            }

            private void panel3_Click(object sender, EventArgs e)
            {
                radioButton3.Checked = true;

            }

            private void panel4_Click(object sender, EventArgs e)
            {
                radioButton4.Checked = true;

            }

            private void panel5_Click(object sender, EventArgs e)
            {
                radioButton5.Checked = true;

            }
    }
}
