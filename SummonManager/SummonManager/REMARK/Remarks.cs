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

        private void bWPWork_Click(object sender, EventArgs e)
        {
            if (dgWP.SelectedRows.Count != 1)
            {
                MessageBox.Show("Не выбрано ни одной строки!");
                return;
            }
            RemarkWork rw = new RemarkWork(dgWP.SelectedRows[0].Cells["ID"].Value.ToString(),UVO,"WP");
            rw.ShowDialog();

            Remarks_Load(sender, e);
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
            DBRemarkWP dbr = new DBRemarkWP();
            dgWP.DataSource = dbr.GetAll();
            //"select IDWP,DOCUMENTNAME,DATEREMARK,B.FIO creator,C.ROLENAME createrole, " +
            //                               " CLOSED,CLOSINGCOMMENT,DATECLOSE,D.FIO closer,E.ROLENAME closerole " +
            dgWP.Columns["IDWP"].Width = 70;
            dgWP.Columns["IDWP"].HeaderText = "№ изделия";
            dgWP.Columns["DOCUMENTNAME"].Visible = false;
            dgWP.Columns["ID"].Visible = false;

            dgWP.Columns["DOCUMENTNAME_RUS"].Width = 150;
            dgWP.Columns["DOCUMENTNAME_RUS"].HeaderText = "Документ";
            dgWP.Columns["DATEREMARK"].Width = 80;
            dgWP.Columns["DATEREMARK"].HeaderText = "Дата создания";
            dgWP.Columns["creator"].Width = 100;
            dgWP.Columns["creator"].HeaderText = "Создатель";
            dgWP.Columns["createrole"].Width = 150;
            dgWP.Columns["createrole"].HeaderText = "Роль создателя";
            dgWP.Columns["creator"].Width = 80;
            dgWP.Columns["creator"].HeaderText = "Создатель";
            dgWP.Columns["CLOSED"].Width = 100;
            dgWP.Columns["CLOSED"].HeaderText = "Статус";
            dgWP.Columns["CLOSINGCOMMENT"].Width = 80;
            dgWP.Columns["CLOSINGCOMMENT"].HeaderText = "Комментарий после отработки";
            dgWP.Columns["DATECLOSE"].Width = 100;
            dgWP.Columns["DATECLOSE"].HeaderText = "Дата отработки";
            dgWP.Columns["closer"].Width = 100;
            dgWP.Columns["closer"].HeaderText = "Кто отработал";
            dgWP.Columns["closerole"].Width = 100;
            dgWP.Columns["closerole"].HeaderText = "Роль отработавшего";


            DBRemarkSUMMON dbrs = new DBRemarkSUMMON();
            dgSumm.DataSource = dbrs.GetAll();
            //"select IDWP,DOCUMENTNAME,DATEREMARK,B.FIO creator,C.ROLENAME createrole, " +
            //                               " CLOSED,CLOSINGCOMMENT,DATECLOSE,D.FIO closer,E.ROLENAME closerole " +
            dgSumm.Columns["IDSUMMON"].Width = 70;
            dgSumm.Columns["IDSUMMON"].HeaderText = "№ извещения";
            dgSumm.Columns["DOCUMENTNAME"].Visible = false;
            dgSumm.Columns["ID"].Visible = false;

            dgSumm.Columns["DOCUMENTNAME_RUS"].Width = 150;
            dgSumm.Columns["DOCUMENTNAME_RUS"].HeaderText = "Документ";
            dgSumm.Columns["DATEREMARK"].Width = 80;
            dgSumm.Columns["DATEREMARK"].HeaderText = "Дата создания";
            dgSumm.Columns["creator"].Width = 100;
            dgSumm.Columns["creator"].HeaderText = "Создатель";
            dgSumm.Columns["createrole"].Width = 150;
            dgSumm.Columns["createrole"].HeaderText = "Роль создателя";
            dgSumm.Columns["creator"].Width = 80;
            dgSumm.Columns["creator"].HeaderText = "Создатель";
            dgSumm.Columns["CLOSED"].Width = 100;
            dgSumm.Columns["CLOSED"].HeaderText = "Статус";
            dgSumm.Columns["CLOSINGCOMMENT"].Width = 80;
            dgSumm.Columns["CLOSINGCOMMENT"].HeaderText = "Комментарий после отработки";
            dgSumm.Columns["DATECLOSE"].Width = 100;
            dgSumm.Columns["DATECLOSE"].HeaderText = "Дата отработки";
            dgSumm.Columns["closer"].Width = 100;
            dgSumm.Columns["closer"].HeaderText = "Кто отработал";
            dgSumm.Columns["closerole"].Width = 100;
            dgSumm.Columns["closerole"].HeaderText = "Роль отработавшего";
        }

        private void bSummWork_Click(object sender, EventArgs e)
        {
            if (dgSumm.SelectedRows.Count != 1)
            {
                MessageBox.Show("Не выбрано ни одной строки!");
                return;
            }
            RemarkWork rw = new RemarkWork(dgSumm.SelectedRows[0].Cells["ID"].Value.ToString(), UVO, "SUMMON");
            rw.ShowDialog();

            Remarks_Load(sender, e);
        }
    }
}
