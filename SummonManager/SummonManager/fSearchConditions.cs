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
    public partial class fSearchConditions : Form
    {
        MainF mf;
        public fSearchConditions(MainF mf_)
        {
            InitializeComponent();
            DBWPName dbwp = new DBWPName();
            cbWPNAME.ValueMember = "ID";
            cbWPNAME.DisplayMember = "WPNAME";
            cbWPNAME.DataSource = dbwp.GetAllWPNames();
            //cbWPNAME.SelectedValue = SVO.IDWPNAME;f.......
            this.mf = mf_;
        }

        private void bSearch_Click(object sender, EventArgs e)
        {
            if ((!checkBox1.Checked) && (!checkBox2.Checked) && (!checkBox3.Checked))
            {
                MessageBox.Show("Введите условия для поиска!");
                return;
            }
            if (checkBox3.Checked)
            {
                if (tbCONTRACT.Text == "")
                {
                    MessageBox.Show("Введите или отключите фильтр по номеру счёта!");
                    return;
                }
            }
            bool dates = false;
            string contr = "";
            int idwp = -1;
            if (checkBox1.Checked)
            {
                dates = true;
            }
            else
            {
                dates = false;
            }
            if (checkBox2.Checked)
            {
                idwp = (int)cbWPNAME.SelectedValue;
            }
            else
            {
                idwp = -1;
            }
            if (checkBox3.Checked)
            {
                contr = tbCONTRACT.Text;
            }
            else
            {
                contr = "-1";
            }
            DBSearch dbs = new DBSearch();
            DataTable t = dbs.GetSearchResults(idwp, contr, dateTimePicker1.Value, dateTimePicker2.Value, dates);
            
            fSearchResults fsr = new fSearchResults(t,this.mf);
            fsr.ShowDialog();
            if (fsr.Finished)
            {
                Close();
            }
        }

        private void bCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                dateTimePicker1.Enabled = true;
                dateTimePicker2.Enabled = true;
                label4.Enabled = true;
                label5.Enabled = true;
            }
            else
            {
                dateTimePicker1.Enabled = false;
                dateTimePicker2.Enabled = false;
                label4.Enabled = false;
                label5.Enabled = false;
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                tbCONTRACT.Enabled = true;
            }
            else
            {
                tbCONTRACT.Enabled = false;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                cbWPNAME.Enabled = true;
            }
            else
            {
                cbWPNAME.Enabled = false;
            }

        }
    }
}
