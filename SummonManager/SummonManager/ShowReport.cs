using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
namespace SummonManager
{
    public partial class ShowReport : Form
    {
        public ShowReport(List<SummonVOForReport> sl)
        {
            InitializeComponent();
            RepSummon rs = new RepSummon();
            rs.SetDataSource(sl);
            RepViewer.ReportSource = rs;
            //LineObject L23 = rs.Section2.ReportObjects["Line23"] as LineObject;
            //FieldObject PN2 = rs.Section2.ReportObjects["PageNumber2"] as FieldObject;
            //TextObject T = rs.Section2.ReportObjects["Text43"] as TextObject;
            //T.Top
            //T.Text = PN2.;
            //string SectName = L23.EndSectionName;
            
        }
    }
}
