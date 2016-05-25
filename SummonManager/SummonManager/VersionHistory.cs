using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Reflection;

namespace SummonManager
{
    public partial class VersionHistory : Form
    {
        public VersionHistory()
        {
            InitializeComponent();
            panel1.MouseWheel += new MouseEventHandler(panel1_MouseWheel);
            //panel1.TabIndex = 0;
            //panel1.Focus();
        }

        void panel1_MouseWheel(object sender, MouseEventArgs e)
        {
            if ((e.Delta) > 0)
            {

                if (panel1.VerticalScroll.Value - 2 >= panel1.VerticalScroll.Minimum)
                    panel1.VerticalScroll.Value -= 2;
                else
                    panel1.VerticalScroll.Value = panel1.VerticalScroll.Minimum;
            }
            else
            {
                if (panel1.VerticalScroll.Value + 2 <= panel1.VerticalScroll.Maximum)
                    panel1.VerticalScroll.Value += 2;
                else
                    panel1.VerticalScroll.Value = panel1.VerticalScroll.Maximum;
            }
        }

        private void VersionHistory_Load(object sender, EventArgs e)
        {
            label1.Text = "";
            //string[] lines = System.IO.File.ReadAllLines("список изменений.txt");
            string d = SummonManager.Properties.Resources.Version_History;

            label1.Text = d;
            //foreach (string line in lines)
            //{
            //    label1.Text += line+"\n";
            //}
            
        }

        private void panel1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void panel1_MouseEnter(object sender, EventArgs e)
        {
            panel1.Focus();
        }
    }
}
