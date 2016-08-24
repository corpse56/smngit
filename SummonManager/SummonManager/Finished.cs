using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SummonManager
{
    public partial class Finished : Form
    {
        public Finished()
        {
            InitializeComponent();

            DBMain dbMain = new DBMain();
            dgSummon.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dgSummon.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgSummon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            //dgSummon.DataSource = dbMain.GetMainView(UVO.Role);
            dgSummon.DataSource = dbMain.GetMainViewFinished();
            //dgSummon.Columns["id"].Visible = false;
            //dgSummon.Columns["ids_srt"].Visible = false;
            //dgSummon.Columns["ids"].HeaderText = "Номер извещения";
            //dgSummon.Columns["ids"].Width = 100;
            //dgSummon.Columns["wname"].HeaderText = "Наименование изделия";
            //dgSummon.Columns["wname"].Width = 150;
            //dgSummon.Columns["cust"].HeaderText = "Заказчик";
            //dgSummon.Columns["cust"].Width = 190;
            //dgSummon.Columns["sts"].HeaderText = "Статус";
            //dgSummon.Columns["sts"].Width = 100;
            //dgSummon.Columns["dt"].HeaderText = "Дата смены статуса";
            //dgSummon.Columns["dt"].Width = 130;
            ////dgSummon.Columns["dt"].ValueType = typeof(DateTime);
            //dgSummon.Columns["dt"].DefaultCellStyle.Format = "dd.MM.yyyy HH:mm";
            //dgSummon.Columns["note"].HeaderText = "Примечание";
            //dgSummon.Columns["note"].Width = 250;
            //dgSummon.Columns["ptime"].HeaderText = "Срок сдачи изделия";
            //dgSummon.Columns["ptime"].Width = 130;
            //dgSummon.Columns["ptime"].DefaultCellStyle.Format = "dd.MM.yyyy HH:mm";
            //dgSummon.Columns["passd"].HeaderText = "Ориенти ровочная дата передачи";
            //dgSummon.Columns["passd"].Width = 85;
            //dgSummon.Columns["passd"].ValueType = typeof(string);
            //dgSummon.Columns["passd"].DefaultCellStyle.Format = "dd.MM.yyyy";
            //dgSummon.Columns["cause"].HeaderText = "Причина смены статуса";
            //dgSummon.Columns["cause"].Width = 130;
            //dgSummon.Columns["cause"].Visible = false;
            //dgSummon.Columns["qty"].HeaderText = "Кол-во";
            //dgSummon.Columns["qty"].Width = 50;
            //dgSummon.Columns["passd"].Visible = false;
            //dgSummon.Columns["idstatus"].Visible = false;
            //dgSummon.Columns["vw"].Visible = false;
            //dgSummon.Columns["dview"].Visible = false;
            //dgSummon.Columns["pdc"].Visible = false;
            //dgSummon.Columns["ncre"].Visible = false;
            dgSummon.Columns["id"].Visible = false;
            dgSummon.Columns["ids"].HeaderText = "Номер извещения";
            dgSummon.Columns["wname"].HeaderText = "Наименование изделия";
            dgSummon.Columns["cust"].HeaderText = "Заказчик";
            dgSummon.Columns["sts"].HeaderText = "Статус";
            dgSummon.Columns["subst"].HeaderText = "Субстатус";
            dgSummon.Columns["sisp"].HeaderText = "СИ и СП";
            dgSummon.Columns["note"].HeaderText = "Примечание";
            dgSummon.Columns["ptime"].HeaderText = "Срок сдачи изделия";
            dgSummon.Columns["ptime"].DefaultCellStyle.Format = "dd.MM.yyyy HH:mm";
            dgSummon.Columns["passd"].HeaderText = "Ориенти ровочная дата передачи";
            dgSummon.Columns["passd"].Visible = false;
            dgSummon.Columns["passd"].DefaultCellStyle.Format = "dd.MM.yyyy";
            dgSummon.Columns["techreq"].HeaderText = "Технические требования";
            dgSummon.Columns["qty"].HeaderText = "Кол-во";
            dgSummon.Columns["idstatus"].Visible = false;
            dgSummon.Columns["ids_srt"].Visible = false;
            dgSummon.Columns["vw"].Visible = false;
            dgSummon.Columns["dview"].Visible = false;
            dgSummon.Columns["dview"].ValueType = typeof(DateTime);
            dgSummon.Columns["pdc"].Visible = false;
            dgSummon.Columns["pdc"].ValueType = typeof(DateTime);
            dgSummon.Columns["ncre"].Visible = false;
            dgSummon.Columns["ncre"].ValueType = typeof(DateTime);
            dgSummon.Columns["paint_constr"].Visible = false;
            dgSummon.Columns["paint_inzh"].Visible = false;
            dgSummon.Columns["paint_otk"].Visible = false;
            dgSummon.Columns["shild_ordered"].Visible = false;
            dgSummon.Columns["idsubst"].Visible = false;
            dgSummon.Columns["paint_OTD"].Visible = false;
            dgSummon.Columns["paint_shemotehnik"].Visible = false;

            //dgSummon.Columns["qty"].Width = 50;
            //dgSummon.Columns["cause"].Width = 130;
            //dgSummon.Columns["passd"].Width = 85;
            //dgSummon.Columns["ptime"].Width = 130;
            //dgSummon.Columns["note"].Width = 250;
            //dgSummon.Columns["dt"].Width = 130;
            //dgSummon.Columns["ids"].Width = 80;
            //dgSummon.Columns["wname"].Width = 140;
            //dgSummon.Columns["cust"].Width = 190;
            //dgSummon.Columns["sts"].Width = 100;

            dgSummon.Columns["qty"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgSummon.Columns["techreq"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgSummon.Columns["passd"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgSummon.Columns["ptime"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgSummon.Columns["note"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgSummon.Columns["sisp"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgSummon.Columns["ids"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgSummon.Columns["wname"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgSummon.Columns["cust"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgSummon.Columns["sts"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgSummon.Columns["subst"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dgSummon.Columns["qty"].FillWeight = 50;
            dgSummon.Columns["techreq"].FillWeight = 130;
            dgSummon.Columns["passd"].FillWeight = 85;
            dgSummon.Columns["ptime"].FillWeight = 100;
            dgSummon.Columns["note"].FillWeight = 250;
            dgSummon.Columns["sisp"].FillWeight = 50;
            dgSummon.Columns["ids"].FillWeight = 80;
            dgSummon.Columns["wname"].FillWeight = 140;
            dgSummon.Columns["cust"].FillWeight = 190;
            dgSummon.Columns["sts"].FillWeight = 100;
            dgSummon.Columns["subst"].FillWeight = 100;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dgSummon.SelectedRows.Count == 0)
            {
                MessageBox.Show("Извещение не выбрано!");
                return;
            }
            StatusHistory sh = new StatusHistory(dgSummon.SelectedRows[0].Cells["id"].Value.ToString());
            sh.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DBSummon dbs = new DBSummon();
            SummonVO svo = dbs.GetSummonByIDS(dgSummon.SelectedRows[0].Cells["ids"].Value.ToString());
            SummonVOForReport svor = new SummonVOForReport(svo);
            List<SummonVOForReport> sl = new List<SummonVOForReport>();
            sl.Add(svor);
            ShowReport sr = new ShowReport(sl);
            sr.ShowDialog();
        }

        private void dgSummon_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex == -1) return;
            DBSummon dbs = new DBSummon();
            SummonVO svo = dbs.GetSummonByIDS(dgSummon.SelectedRows[0].Cells["ids"].Value.ToString());



            //ShowSummonDIR ssDIR = new ShowSummonDIR(svo.IDS, null, svo.ID);
            //ssDIR.ShowDialog();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (dgSummon.SelectedRows.Count == 0) return;
            DBSummon dbs = new DBSummon();
            SummonVO svo = dbs.GetSummonByIDS(dgSummon.SelectedRows[0].Cells["ids"].Value.ToString());


            ShowSummon ss = new ShowSummon(new UVO_DIRECTOR(),svo);
            ss.Tag = "finished";
            ss.ShowDialog();
            //ShowSummonDIR ssDIR = new ShowSummonDIR(svo.IDS, null, svo.ID);
            //ssDIR.ShowDialog();
        }
    }
}
