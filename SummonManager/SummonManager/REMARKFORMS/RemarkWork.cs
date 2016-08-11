using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SummonManager.CLASSES.IRole_namespace;

namespace SummonManager
{
    public partial class RemarkWork : Form
    {
        string ID;
        public string comtext;
        public bool result = false;

        WP_RVO RVO;
        IRole UVO;
        string RemarkType;
        //string IDREMARK;
        public RemarkWork(string id_, IRole uvo, string remarktype)
        {
            InitializeComponent();
            this.ID = id_;
            this.UVO = uvo;
            this.RemarkType = remarktype;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (this.RemarkType == "WP")
            {
                RVO = WP_RVO.RemarkVOByID(this.ID);
                DBRemarkWP dbr = new DBRemarkWP(UVO);
                RVO.CLOSED = true;
                RVO.CLOSINGCOMMENT = textBox1.Text;
                RVO.DATECLOSE = DateTime.Now;
                RVO.IDCLOSER = UVO.id;
                dbr.Edit(RVO);
            }
            else
            {
                SummonRVO RVO = SummonRVO.RemarkVOByID(this.ID);
                DBRemarkSUMMON dbr = new DBRemarkSUMMON();
                RVO.CLOSED = true;
                RVO.CLOSINGCOMMENT = textBox1.Text;
                RVO.DATECLOSE = DateTime.Now;
                RVO.IDCLOSER = UVO.id;
                dbr.Edit(RVO);
            }
            MessageBox.Show("Замечание успешно отработано!");
            
            Close();
        }
    }
}
