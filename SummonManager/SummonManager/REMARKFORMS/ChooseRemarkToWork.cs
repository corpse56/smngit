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
    public partial class ChooseRemarkToWork : Form
    {
        public bool result = false;

        WP_RVO RVO;
        IRole UVO;
        string RemarkType;
        string DOCUMENTNAME;
        string ID;
        public ChooseRemarkToWork(string docname, IRole uvo, string remarktype, string id)
        {
            InitializeComponent();
            this.UVO = uvo;
            this.DOCUMENTNAME = docname;
            this.RemarkType = remarktype;
            this.ID = id;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dgRemark.SelectedRows.Count == 0)
            {
                MessageBox.Show("Замечение не выбрано!");
                return;
            }
            if (RemarkType == "WP")
            {
                RemarkWork rw = new RemarkWork(dgRemark.SelectedRows[0].Cells["ID"].Value.ToString(), UVO, "WP");
                rw.ShowDialog();
            }
            else
            {
                RemarkWork rw = new RemarkWork(dgRemark.SelectedRows[0].Cells["ID"].Value.ToString(), UVO, "SUMMON");
                rw.ShowDialog();
            }
            Close();
        }

        private void ChooseRemarkToWork_Load(object sender, EventArgs e)
        {
            if (RemarkType == "WP")
            {
                DBRemarkWP dbr = new DBRemarkWP(UVO);
                dgRemark.DataSource = dbr.GetRemarksByIDWPDOC(DOCUMENTNAME,ID);
                dgRemark.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
                dgRemark.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                dgRemark.Columns["WP"].FillWeight = 70;
                dgRemark.Columns["WP"].HeaderText = "№ изделия";
                dgRemark.Columns["IDWP"].Visible = false;
                dgRemark.Columns["DOCUMENTNAME"].Visible = false;
                dgRemark.Columns["ID"].Visible = false;
                dgRemark.Columns["DOCUMENTNAME_RUS"].FillWeight = 100;
                dgRemark.Columns["DOCUMENTNAME_RUS"].HeaderText = "Документ";
                dgRemark.Columns["REMARK"].FillWeight = 200;
                dgRemark.Columns["REMARK"].HeaderText = "Проблема";
                dgRemark.Columns["DATEREMARK"].FillWeight = 80;
                dgRemark.Columns["DATEREMARK"].HeaderText = "Дата создания";
                dgRemark.Columns["createrole"].FillWeight = 80;
                dgRemark.Columns["createrole"].HeaderText = "Роль создателя";
                dgRemark.Columns["creator"].FillWeight = 80;
                dgRemark.Columns["creator"].HeaderText = "Создатель";
                dgRemark.Columns["CLOSED"].Visible = false;
                dgRemark.Columns["CLOSINGCOMMENT"].Visible = false;
                dgRemark.Columns["DATECLOSE"].Visible = false;
                dgRemark.Columns["closer"].Visible = false;
                dgRemark.Columns["closerole"].Visible = false;

                dgRemark.Columns["WP"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgRemark.Columns["DOCUMENTNAME_RUS"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgRemark.Columns["REMARK"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgRemark.Columns["DATEREMARK"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgRemark.Columns["createrole"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgRemark.Columns["creator"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            else
            {
                DBRemarkSUMMON dbrs = new DBRemarkSUMMON();
                dgRemark.DataSource = dbrs.GetRemarksByIDSDOC(DOCUMENTNAME, ID);
                dgRemark.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
                dgRemark.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

                dgRemark.Columns["IDS"].FillWeight = 70;
                dgRemark.Columns["IDS"].HeaderText = "№ извещения";
                dgRemark.Columns["IDSUMMON"].Visible = false;
                dgRemark.Columns["DOCUMENTNAME"].Visible = false;
                dgRemark.Columns["ID"].Visible = false;

                dgRemark.Columns["DOCUMENTNAME_RUS"].FillWeight = 100;
                dgRemark.Columns["DOCUMENTNAME_RUS"].HeaderText = "Документ";
                dgRemark.Columns["REMARK"].FillWeight = 200;
                dgRemark.Columns["REMARK"].HeaderText = "Проблема";
                dgRemark.Columns["DATEREMARK"].FillWeight = 80;
                dgRemark.Columns["DATEREMARK"].HeaderText = "Дата создания";
                dgRemark.Columns["creator"].FillWeight = 80;
                dgRemark.Columns["creator"].HeaderText = "Создатель";
                dgRemark.Columns["createrole"].FillWeight = 80;
                dgRemark.Columns["createrole"].HeaderText = "Роль создателя";
                dgRemark.Columns["CLOSED"].Visible = false;
                dgRemark.Columns["CLOSINGCOMMENT"].Visible = false;
                dgRemark.Columns["DATECLOSE"].Visible = false;
                dgRemark.Columns["closer"].Visible = false;
                dgRemark.Columns["closerole"].Visible = false;
                dgRemark.Columns["IDS"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgRemark.Columns["DOCUMENTNAME_RUS"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgRemark.Columns["REMARK"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgRemark.Columns["DATEREMARK"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgRemark.Columns["createrole"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgRemark.Columns["creator"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }


        }
    }
}
