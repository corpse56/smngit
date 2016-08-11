using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SummonManager.CLASSES.IRole_namespace;
using SummonManager.CLASSES;

namespace SummonManager
{
    public partial class Remarks : Form
    {
        IRole UVO;
        public Remarks(IRole UVO_)
        {
            InitializeComponent();
            this.UVO = UVO_;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        
        private void button3_Click(object sender, EventArgs e)
        {
            if (dgWP.SelectedRows.Count != 1)
            {
                MessageBox.Show("Не выбрано ни одной строки!");
                return;
            }
            EditUser eu = new EditUser(dgWP.SelectedRows[0].Cells["ID"].Value.ToString());
            eu.ShowDialog();
            DBUser dbu = new DBUser();
            dgWP.DataSource = dbu.GetAllUsers();

        }


        private void bGoToWP_Click(object sender, EventArgs e)
        {  
            if (dgWP.SelectedRows.Count != 1)
            {
                MessageBox.Show("Не выбрано ни одной строки!");
                return;
            }

            IProduct pr = WPNameVO.WPNameVOByID(Convert.ToInt32(dgWP.SelectedRows[0].Cells["IDWP"].Value));
            pr.ViewOnly(UVO);
            Remarks_Load(sender, e);

        }

        private void bGoToSummon_Click(object sender, EventArgs e)
        {
            if (dgSumm.SelectedRows.Count == 0)
            {
                MessageBox.Show("Извещение не выбрано!");
                return;
            }
            DBSummon dbs = new DBSummon();
            SummonVO svo = dbs.GetSummonByID(dgSumm.SelectedRows[0].Cells["IDSUMMON"].Value.ToString());

            ShowSummon ss = new ShowSummon(UVO, svo);
            ss.ShowDialog();
            Remarks_Load(sender, e);

        }

        private void Remarks_Load(object sender, EventArgs e)
        {
            DBRemarkWP dbr = new DBRemarkWP(UVO);
            dgWP.DataSource = dbr.GetAll();

            DBRemarkSUMMON dbrs = new DBRemarkSUMMON();
            dgSumm.DataSource = dbrs.GetAll();
        


            if (rbAllRemarks.Checked)
            {
                UVO.AllRemarksWP(dgWP);
                UVO.AllRemarksSmm(dgSumm);
            }
            else if (rbMyRemarks.Checked)
            {
                UVO.MyRemarksWP(dgWP);
                UVO.MyRemarksSmm(dgSumm);
            }
            else if (rbFinishedRemarks.Checked)
            {
                UVO.FinishedRemarksWP(dgWP);
                UVO.FinishedRemarksSmm(dgSumm);
            }
            else
            {
                UVO.AllRemarksWP(dgWP);
                UVO.AllRemarksSmm(dgSumm);
            }


            dgWP.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dgWP.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgWP.Columns["WP"].FillWeight = 70;
            dgWP.Columns["WP"].HeaderText = "№ изделия";
            dgWP.Columns["IDWP"].Visible = false;
            dgWP.Columns["DOCUMENTNAME"].Visible = false;
            dgWP.Columns["ID"].Visible = false;
            dgWP.Columns["DOCUMENTNAME_RUS"].FillWeight = 100;
            dgWP.Columns["DOCUMENTNAME_RUS"].HeaderText = "Документ";
            dgWP.Columns["REMARK"].FillWeight = 200;
            dgWP.Columns["REMARK"].HeaderText = "Проблема";
            dgWP.Columns["DATEREMARK"].FillWeight = 80;
            dgWP.Columns["DATEREMARK"].HeaderText = "Дата создания";
            dgWP.Columns["createrole"].FillWeight = 80;
            dgWP.Columns["createrole"].HeaderText = "Роль создателя";
            dgWP.Columns["creator"].FillWeight = 80;
            dgWP.Columns["creator"].HeaderText = "Создатель";
            dgWP.Columns["CLOSED"].FillWeight = 70;
            dgWP.Columns["CLOSED"].HeaderText = "Статус";
            dgWP.Columns["CLOSINGCOMMENT"].FillWeight = 150;
            dgWP.Columns["CLOSINGCOMMENT"].HeaderText = "Комментарий после отработки";
            dgWP.Columns["DATECLOSE"].FillWeight = 80;
            dgWP.Columns["DATECLOSE"].HeaderText = "Дата отработки";
            dgWP.Columns["closer"].FillWeight = 80;
            dgWP.Columns["closer"].HeaderText = "Кто отработал";
            dgWP.Columns["closerole"].FillWeight = 80;
            dgWP.Columns["closerole"].HeaderText = "Роль отработавшего";

            dgWP.Columns["WP"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgWP.Columns["DOCUMENTNAME_RUS"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgWP.Columns["REMARK"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgWP.Columns["DATEREMARK"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgWP.Columns["createrole"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgWP.Columns["creator"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgWP.Columns["CLOSED"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgWP.Columns["CLOSINGCOMMENT"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgWP.Columns["DATECLOSE"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgWP.Columns["closer"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgWP.Columns["closerole"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;



            dgWP.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dgWP.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            dgSumm.Columns["IDS"].FillWeight = 70;
            dgSumm.Columns["IDS"].HeaderText = "№ извещения";
            dgSumm.Columns["IDSUMMON"].Visible = false;
            dgSumm.Columns["DOCUMENTNAME"].Visible = false;
            dgSumm.Columns["ID"].Visible = false;

            dgSumm.Columns["DOCUMENTNAME_RUS"].FillWeight = 100;
            dgSumm.Columns["DOCUMENTNAME_RUS"].HeaderText = "Документ";
            dgSumm.Columns["REMARK"].FillWeight = 200;
            dgSumm.Columns["REMARK"].HeaderText = "Проблема";
            dgSumm.Columns["DATEREMARK"].FillWeight = 80;
            dgSumm.Columns["DATEREMARK"].HeaderText = "Дата создания";
            dgSumm.Columns["creator"].FillWeight = 80;
            dgSumm.Columns["creator"].HeaderText = "Создатель";
            dgSumm.Columns["createrole"].FillWeight = 80;
            dgSumm.Columns["createrole"].HeaderText = "Роль создателя";
            dgSumm.Columns["CLOSED"].FillWeight = 70;
            dgSumm.Columns["CLOSED"].HeaderText = "Статус";
            dgSumm.Columns["CLOSINGCOMMENT"].FillWeight = 150;
            dgSumm.Columns["CLOSINGCOMMENT"].HeaderText = "Комментарий после отработки";
            dgSumm.Columns["DATECLOSE"].FillWeight = 80;
            dgSumm.Columns["DATECLOSE"].HeaderText = "Дата отработки";
            dgSumm.Columns["closer"].FillWeight = 80;
            dgSumm.Columns["closer"].HeaderText = "Кто отработал";
            dgSumm.Columns["closerole"].FillWeight = 80;
            dgSumm.Columns["closerole"].HeaderText = "Роль отработавшего";
            dgSumm.Columns["IDS"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgSumm.Columns["DOCUMENTNAME_RUS"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgSumm.Columns["REMARK"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgSumm.Columns["DATEREMARK"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgSumm.Columns["createrole"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgSumm.Columns["creator"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgSumm.Columns["CLOSED"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgSumm.Columns["CLOSINGCOMMENT"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgSumm.Columns["DATECLOSE"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgSumm.Columns["closer"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgSumm.Columns["closerole"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void bWPWork_Click(object sender, EventArgs e)
        {
            if (dgWP.SelectedRows.Count != 1)
            {
                MessageBox.Show("Не выбрано ни одной строки!");
                return;
            }
            if (dgWP.SelectedRows[0].Cells["CLOSED"].Value.ToString() == "Отработано")
            {
                MessageBox.Show("Нельзя отработать уже отработанное замечание!");
                return;
            }
            if (!UVO.IsMyWPRemark(dgWP.SelectedRows[0].Cells["DOCUMENTNAME"].Value.ToString()) && (dgWP.SelectedRows[0].Cells["CLOSED"].Value.ToString() != "Отработано"))
            {
                MessageBox.Show("Нельзя отработать замечание по документу, за который вы не ответственны!");
                return;
            }

            RemarkWork rw = new RemarkWork(dgWP.SelectedRows[0].Cells["ID"].Value.ToString(), UVO, "WP");
            rw.ShowDialog();


            Remarks_Load(sender, e);
        }

        private void bSummWork_Click(object sender, EventArgs e)
        {
            if (dgSumm.SelectedRows.Count != 1)
            {
                MessageBox.Show("Не выбрано ни одной строки!");
                return;
            }
            if (dgSumm.SelectedRows[0].Cells["CLOSED"].Value.ToString() == "Отработано")
            {
                MessageBox.Show("Нельзя отработать уже отработанное замечание!");
                return;
            }
            if (!UVO.IsMySmmRemark(dgSumm.SelectedRows[0].Cells["DOCUMENTNAME"].Value.ToString()) && (dgWP.SelectedRows[0].Cells["CLOSED"].Value.ToString() != "Отработано"))
            {
                MessageBox.Show("Нельзя отработать замечание по документу, за который вы не ответственны!");
                return;
            }

            RemarkWork rw = new RemarkWork(dgSumm.SelectedRows[0].Cells["ID"].Value.ToString(), UVO, "SUMMON");
            rw.ShowDialog();

            Remarks_Load(sender, e);
        }

       

        private void rbMyRemarks_CheckedChanged(object sender, EventArgs e)
        {
            Remarks_Load(sender, e);
        }

        private void rbAllRemarks_CheckedChanged(object sender, EventArgs e)
        {
            Remarks_Load(sender, e);

        }

        private void rbFinishedRemarks_CheckedChanged(object sender, EventArgs e)
        {
            Remarks_Load(sender, e);

        }

       

       
    }
}
