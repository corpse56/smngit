using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SummonManager.CLASSES.IRole_namespace;

namespace SummonManager
{
    public partial class SummonNotes : UserControl
    {
        public string ID = "0";
        public IRole UVO;
        public SummonVO SVO;
        public void Init(string ID_,IRole UVO_,SummonVO SVO_)
        {
            this.ID = ID_;
            this.UVO = UVO_;
            this.SVO = SVO_;
            if (UVO.Role != Roles.Admin)
            {
                button3.Visible = false;
            }
        }
        public SummonNotes()
        {
            InitializeComponent();

            dgNote.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dgNote.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgNote.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DBSummonNotes DBSN = new DBSummonNotes();
            dgNote.DataSource = DBSN.GetAllNotesByIDSummon(ID);

            dgNote.Columns["ID"].Visible = false;
            dgNote.Columns["IDSUMMON"].Visible = false;
            dgNote.Columns["CREATED"].HeaderText = "Дата";
            dgNote.Columns["CREATED"].Width = 70;
            dgNote.Columns["CREATED"].DefaultCellStyle.Format = "dd.MM.yyyy HH:mm";
            dgNote.Columns["ROLENAME"].HeaderText = "Отдел";
            dgNote.Columns["ROLENAME"].Width = 80;
            dgNote.Columns["FIO"].HeaderText = "ФИО";
            dgNote.Columns["FIO"].Width = 90;
            dgNote.Columns["NOTE"].HeaderText = "Примечание";
            dgNote.Columns["NOTE"].Width = 260;

        }

        private void SummonNotes_Load(object sender, EventArgs e)
        {

        }
        public void Reload()
        {
            DBSummonNotes DBSN = new DBSummonNotes();
            dgNote.DataSource = DBSN.GetAllNotesByIDSummon(ID);
            if (dgNote.RowCount >= 1)
            {
                dgNote.FirstDisplayedScrollingRowIndex = dgNote.RowCount - 1;
            }

        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Reload();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fAddNote fan = new fAddNote(this.ID,this.UVO.id);
            fan.ShowDialog();
            this.Reload();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dgNote.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите строку!");
                return;
            }

            fEditNote fen = new fEditNote(dgNote.SelectedRows[0].Cells["ID"].Value.ToString(),dgNote.SelectedRows[0].Cells["NOTE"].Value.ToString());
            fen.ShowDialog();
            Reload();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }



    }
}
