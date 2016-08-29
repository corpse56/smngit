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
    public partial class fSearchResults : Form
    {
        public bool Finished = true;
        public MainF mf;
        public fSearchResults(DataTable t,MainF mf_)
        {
            InitializeComponent();
            this.mf = mf_;
            dgSummon.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dgSummon.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgSummon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgSummon.DataSource = t;
            dgSummon.Columns["id"].Visible = false;
            dgSummon.Columns["ids"].HeaderText = "Номер извещения";
            dgSummon.Columns["ids"].Width = 80;
            dgSummon.Columns["wname"].HeaderText = "Наименование изделия";
            dgSummon.Columns["wname"].Width = 140;
            dgSummon.Columns["cust"].HeaderText = "Заказчик";
            dgSummon.Columns["cust"].Width = 190;
            dgSummon.Columns["sts"].HeaderText = "Статус";
            dgSummon.Columns["sts"].Width = 100;
            //dgSummon.Columns["dt"].HeaderText = "Дата смены статуса";
            //dgSummon.Columns["dt"].Width = 130;
            //dgSummon.Columns["dt"].ValueType = typeof(DateTime);
            //dgSummon.Columns["dt"].DefaultCellStyle.Format = "dd.MM.yyyy HH:mm";
            dgSummon.Columns["note"].HeaderText = "Примечание";
            dgSummon.Columns["note"].Width = 250;
            dgSummon.Columns["ptime"].HeaderText = "Срок сдачи изделия";
            dgSummon.Columns["ptime"].Width = 130;
            dgSummon.Columns["ptime"].DefaultCellStyle.Format = "dd.MM.yyyy HH:mm";
            dgSummon.Columns["passd"].HeaderText = "Ориенти ровочная дата передачи";
            dgSummon.Columns["passd"].Width = 85;
            dgSummon.Columns["passd"].ValueType = typeof(string);
            dgSummon.Columns["passd"].DefaultCellStyle.Format = "dd.MM.yyyy";
            dgSummon.Columns["cause"].HeaderText = "Причина смены статуса";
            dgSummon.Columns["cause"].Width = 130;
            dgSummon.Columns["qty"].HeaderText = "Кол-во";
            dgSummon.Columns["qty"].Width = 50;
            dgSummon.Columns["idstatus"].Visible = false;
            dgSummon.Columns["contr"].Visible = false;
            dgSummon.Columns["idwp"].Visible = false;
            dgSummon.Columns["cre"].Visible = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Finished = true;
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Finished = false;
            Close();
        }

        private void просмотрИРедактированиеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //mf.ViewEditMenuItem_Click(sender, e);
            if (dgSummon.SelectedRows.Count == 0)
            {
                MessageBox.Show("Извещение не выбрано!");
                return;
            }
            DBSummon dbs = new DBSummon();
            SummonVO svo = dbs.GetSummonByIDS(dgSummon.SelectedRows[0].Cells["ids"].Value.ToString());
            PreviousState ps = new PreviousState(dgSummon);

            ShowSummon ss = new ShowSummon(mf.UVO,svo);
            ss.ShowDialog();

            //switch (mf.UVO.Role)
            //{
            //    case Roles.Manager:
            //        ShowSummon ss = new ShowSummon(mf.UVO,svo);
            //        ss.ShowDialog();
            //        break;
            //    case Roles.Ozis:
            //        ShowSummonOZIS ssozis = new ShowSummonOZIS(svo.IDS, mf.UVO,svo.ID);
            //        ssozis.ShowDialog();
            //        break;
            //    case Roles.Prod:
            //        ShowSummonPROD ssprod = new ShowSummonPROD(svo.IDS, mf.UVO,svo.ID);
            //        ssprod.ShowDialog();
            //        break;
            //    case Roles.OTK:
            //        ShowSummonOTK ssotk = new ShowSummonOTK(svo.IDS, mf.UVO,svo.ID);
            //        ssotk.ShowDialog();
            //        break;
            //    case Roles.Ware:
            //        ShowSummonWare ssware = new ShowSummonWare(svo.IDS, mf.UVO,svo.ID);
            //        ssware.ShowDialog();
            //        break;
            //    case Roles.Logist:
            //        ShowSummonLOG ssLOG = new ShowSummonLOG(svo.IDS, mf.UVO,svo.ID);
            //        ssLOG.ShowDialog();
            //        break;
            //    case Roles.Director:
            //        ShowSummonDIR ssDIR = new ShowSummonDIR(svo.IDS, mf.UVO,svo.ID);
            //        ssDIR.ShowDialog();
            //        break;
            //    case Roles.Wsh:
            //        ShowSummonWSH ssWSH = new ShowSummonWSH(svo.IDS, mf.UVO,svo.ID);
            //        ssWSH.ShowDialog();
            //        break;
            //    case Roles.Admin:
            //        ShowSummonDIR ssadmin = new ShowSummonDIR(svo.IDS, mf.UVO,svo.ID);
            //        ssadmin.ShowDialog();
            //        break;
            //}
            ReloadData();
            ps.Restore();
        }
        private void ReloadData()
        {
            DBMain dbMain = new DBMain();
            dgSummon.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dgSummon.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgSummon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgSummon.DataSource = dbMain.GetMainView(mf.UVO.Role,mf.UVO);
            dgSummon.Columns["ids"].HeaderText = "Номер извещения";
            dgSummon.Columns["ids"].Width = 80;
            dgSummon.Columns["wname"].HeaderText = "Наименование изделия";
            dgSummon.Columns["wname"].Width = 140;
            dgSummon.Columns["cust"].HeaderText = "Заказчик";
            dgSummon.Columns["cust"].Width = 190;
            dgSummon.Columns["sts"].HeaderText = "Статус";
            dgSummon.Columns["sts"].Width = 100;
            //dgSummon.Columns["dt"].HeaderText = "Дата смены статуса";
            //dgSummon.Columns["dt"].Width = 130;
            //dgSummon.Columns["dt"].ValueType = typeof(DateTime);
            //dgSummon.Columns["dt"].DefaultCellStyle.Format = "dd.MM.yyyy HH:mm";
            dgSummon.Columns["note"].HeaderText = "Примечание";
            dgSummon.Columns["note"].Width = 250;
            dgSummon.Columns["ptime"].HeaderText = "Срок сдачи изделия";
            dgSummon.Columns["ptime"].Width = 130;
            dgSummon.Columns["ptime"].DefaultCellStyle.Format = "dd.MM.yyyy HH:mm";
            dgSummon.Columns["passd"].HeaderText = "Ориенти ровочная дата передачи";
            dgSummon.Columns["passd"].Width = 85;
            dgSummon.Columns["passd"].ValueType = typeof(string);
            dgSummon.Columns["passd"].DefaultCellStyle.Format = "dd.MM.yyyy";
            dgSummon.Columns["cause"].HeaderText = "Причина смены статуса";
            dgSummon.Columns["cause"].Width = 130;
            dgSummon.Columns["idstatus"].Visible = false;
            foreach (DataGridViewRow r in dgSummon.Rows)
            {
                if (r.Cells["sts"].Value.ToString().Contains("доработ"))
                {
                    //r.DefaultCellStyle.BackColor = Color.Red;
                }
            }
            PaintDG();
        }
        private void PaintDG()
        {
            switch (mf.UVO.Role)
            {
                case Roles.Prod:
                    foreach (DataGridViewRow r in dgSummon.Rows)
                    {
                        string idst = r.Cells["idstatus"].Value.ToString();
                        string pass = r.Cells["passd"].Value.ToString();

                        if (idst == "4")
                        {
                            r.DefaultCellStyle.BackColor = Color.LightGreen;
                        }
                        if ((idst == "3") && (pass != "не определено"))
                        {
                            r.DefaultCellStyle.BackColor = Color.Yellow;
                        }
                    }
                    break;
            }
        }
        private void печатьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
           // mf.PrintMenuItem_Click(sender, e);
            if (dgSummon.SelectedRows.Count == 0)
            {
                MessageBox.Show("Извещение не выбрано!");
                return;
            }
            DBSummon dbs = new DBSummon();
            SummonVO svo = dbs.GetSummonByIDS(dgSummon.SelectedRows[0].Cells["ids"].Value.ToString());
            SummonVOForReport svor = new SummonVOForReport(svo);
            List<SummonVOForReport> sl = new List<SummonVOForReport>();
            sl.Add(svor);
            ShowReport sr = new ShowReport(sl);
            sr.ShowDialog();
        }

        private void просмотрИсторииСтатусовToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //mf.HistoryMenuItem_Click(sender, e);
            if (dgSummon.SelectedRows.Count == 0)
            {
                MessageBox.Show("Извещение не выбрано!");
                return;
            }
            StatusHistory sh = new StatusHistory(dgSummon.SelectedRows[0].Cells["id"].Value.ToString());
            sh.ShowDialog();
        }


        private void dgSummon_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (e.RowIndex != -1)
                {
                    dgSummon.Rows[e.RowIndex].Selected = true;
                    ContMenu.Show(MousePosition.X, MousePosition.Y);
                }
            }
        }

        private void fSearchResults_FormClosing(object sender, FormClosingEventArgs e)
        {
            Finished = false;
        }
        bool lastSortAscending = false;

        private void dgSummon_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex == 1)
            {
                lastSortAscending = !lastSortAscending;
                if (lastSortAscending)
                {
                    dgSummon.Sort(dgSummon.Columns[0], ListSortDirection.Ascending);
                    
                }
                else
                {
                    dgSummon.Sort(dgSummon.Columns[0], ListSortDirection.Descending);
                    
                }
            }

        }

        private void dgSummon_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex == -1) return;

            if (dgSummon.SelectedRows.Count == 0)
            {
                MessageBox.Show("Извещение не выбрано!");
                return;
            }
            DBSummon dbs = new DBSummon();
            SummonVO svo = dbs.GetSummonByIDS(dgSummon.SelectedRows[0].Cells["ids"].Value.ToString());
            PreviousState ps = new PreviousState(dgSummon);

            ShowSummon ss = new ShowSummon(mf.UVO, svo);
            ss.ShowDialog();

        }
    }
}
