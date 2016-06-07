using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SummonManager.CLASSES;
using SummonManager.Controls;
using SummonManager.CLASSES.IRole_namespace;
using System.Data.SqlClient;

namespace SummonManager
{
    public partial class NewREMARKWP : Form
    {
        RemarkWPVO RVO;
        RemarkSummonVO RVOS;
        IRole UVO;

        public NewREMARKWP(RemarkWPVO rvo,RemarkSummonVO rvos,IRole uvo)
        {
            this.RVO = rvo;
            this.RVOS = rvos;
            this.UVO = uvo;
            InitializeComponent();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (RVO != null)
            {
                RVO.REMARK = tbRemark.Text;
                RVO.IDCREATOR = UVO.id;
                RVO.DATEREMARK = DateTime.Now;
                DBRemarkWP dbr = new DBRemarkWP();
                dbr.AddNew(RVO);
            }
            else
            {
                RVOS.REMARK = tbRemark.Text;
                RVOS.IDCREATOR = UVO.id;
                RVOS.DATEREMARK = DateTime.Now;
                DBRemarkSUMMON dbr = new DBRemarkSUMMON();
                dbr.AddNew(RVOS);
            }
            MessageBox.Show("Замечание успешно добавлено!");
            Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void NewREMARKWP_Load(object sender, EventArgs e)
        {
            
        }


       
    }
}
