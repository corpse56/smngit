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
    public partial class Packing : Form
    {
        public Packing()
        {
            InitializeComponent();
            DBPacking dbwp = new DBPacking();
            dgWP.DataSource = dbwp.GetAll();
            dgWP.Columns["ID"].Visible = false;
            dgWP.Columns["PNAME"].HeaderText = "Наименование упаковки";
            dgWP.Columns["PNAME"].Width = 350;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            NewPacking nwp = new NewPacking();
            nwp.ShowDialog();
            DBPacking dbwp = new DBPacking();
            dgWP.DataSource = dbwp.GetAll();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            EditPacking ew = new EditPacking(dgWP.SelectedRows[0].Cells["ID"].Value.ToString());
            ew.ShowDialog();
            DBPacking dbwp = new DBPacking();
            dgWP.DataSource = dbwp.GetAll();

        }
    }
}
