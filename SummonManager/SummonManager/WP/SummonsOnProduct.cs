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
    public partial class SummonsOnProduct : Form
    {
        private string IDPRODUCT;
        private IRole UVO;
        public SummonsOnProduct(string IDPRODUCT_,IRole UVO_)
        {
            InitializeComponent();
            this.UVO = UVO_;
            this.IDPRODUCT = IDPRODUCT_;
            DBSummon dbs = new DBSummon();
            this.Text += new DBProduct().GetProductName(IDPRODUCT);
            dgSummOnProd.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dgSummOnProd.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            bool rr = dgSummOnProd.AutoGenerateColumns;
            dgSummOnProd.DataSource = dbs.GetSummonsOnProductID(this.IDPRODUCT);
            dgSummOnProd.Columns["IDS"].HeaderText = "Номер извещения";
            dgSummOnProd.Columns["IDS"].Width = 150;
            dgSummOnProd.Columns["ID"].Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        

        private void button2_Click(object sender, EventArgs e)
        {
            if (dgSummOnProd.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите извещение!");
                return;
            }
            SummonVO SVO = SummonVO.SummonVOByID(dgSummOnProd.SelectedRows[0].Cells["ID"].Value.ToString());

            
            ShowSummon ss = new ShowSummon(this.UVO, SVO);
            if (SVO.STATUSNAME == "Завершено")
            {
                ss = new ShowSummon(new UVO_DIRECTOR(), SVO);
            }
            ss.ShowDialog();
        }

        private void dgSummOnProd_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex == -1) return;
            button2_Click(sender, e);
        }
    }
}
