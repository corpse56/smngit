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
    public partial class StatusHistory : Form
    {
        private string IDS;
        public StatusHistory(string ids)
        {
            InitializeComponent();
            this.IDS = ids;
            DBSummon dbs = new DBSummon();
            dgHistory.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dgHistory.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            bool rr = dgHistory.AutoGenerateColumns;
            dgHistory.DataSource = dbs.GetHistory(ids);
            dgHistory.Columns["ids"].HeaderText = "Номер извещения";
            dgHistory.Columns["sts"].HeaderText = "Статус";
            dgHistory.Columns["chg"].HeaderText = "Дата";
            dgHistory.Columns["cause"].HeaderText = "Причина смены статуса";
            dgHistory.Columns["fio"].HeaderText = "Пользователь";
            dgHistory.Columns["ids"].Width = 70;
            dgHistory.Columns["sts"].Width = 120;
            dgHistory.Columns["chg"].Width = 90;
            dgHistory.Columns["chg"].DefaultCellStyle.Format = "dd.MM.yyyy HH:mm";
            dgHistory.Columns["ts"].HeaderText = "Время в текущем статусе";
            dgHistory.Columns["ts"].Width = 150;
            //dgHistory.Columns["ts"].DefaultCellStyle.Format = TimeSpan.FromMinutes(;

            dgHistory.Columns["cause"].Width = 300;
            dgHistory.Columns["fio"].Width = 150;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dgHistory_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 5)
            {
                int min = Convert.ToInt32(e.Value);
                TimeSpan ts = new TimeSpan(0, min, 0);
                if (e.Value != null && e.Value != DBNull.Value)
                    e.Value = ts.Days.ToString() + " д. " +
                               ts.Hours.ToString() + " ч. " +
                                ts.Minutes.ToString() + " м.";
            }
        }
    }
}
