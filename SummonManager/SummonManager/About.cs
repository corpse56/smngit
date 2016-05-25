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
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
            label3.Text = "Версия " + MainF.ProgramVersion;
        }
    }
}
