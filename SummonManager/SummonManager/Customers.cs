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
    public partial class Customers : Form
    {
        public Customers()
        {
            InitializeComponent();



            //dgCust.Columns["CONTACTEXE"].Width = 230;
            //dgCust.Columns["CONTACTEXE"].HeaderText = "ФИО и контакты с исполнителем";
            //dgCust.Columns["CONTACTFINLOG"].Width = 230;
            //dgCust.Columns["CONTACTFINLOG"].HeaderText = "Контакты с финансово логистической службой";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            NewCustomer nc = new NewCustomer();
            nc.ShowDialog();
            DBCustomer dbc = new DBCustomer();
            dgCust.DataSource = dbc.GetAllCustomers();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dgCust.SelectedRows.Count != 1)
            {
                MessageBox.Show("Не выбрано ни одной строки!");
                return;
            }
            EditCustomer ec = new EditCustomer(dgCust.SelectedRows[0].Cells["ID"].Value.ToString());
            ec.ShowDialog();
            DBCustomer dbc = new DBCustomer();
            dgCust.DataSource = dbc.GetAllCustomers();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            fAddCustomerDept facd = new fAddCustomerDept(dgCust.SelectedRows[0].Cells["ID"].Value.ToString());
            facd.ShowDialog();
            string id = dgCust.SelectedRows[0].Cells["ID"].Value.ToString();
            Customers_Load(sender, e);
            DBCustomer dbc = new DBCustomer();
            foreach (DataGridViewRow r in dgCust.Rows)
            {
                if (r.Cells["ID"].Value.ToString() == id)
                {
                    dgCust.FirstDisplayedScrollingRowIndex = r.Index;
                    r.Selected = true;
                    break;
                }
            }
            dgDept.DataSource = dbc.GetDeptsByIDCustomer(id);
            MessageBox.Show("Отдел успешно добавлен!");
            
        }

        private void Customers_Load(object sender, EventArgs e)
        {
            DBCustomer dbc = new DBCustomer();
            dgCust.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dgCust.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            dgCust.DataSource = dbc.GetAllCustomers();
            dgCust.Columns["ID"].Visible = false;
            dgCust.Columns["CNAME"].Width = 250;
            dgCust.Columns["CNAME"].HeaderText = "Название";
            dgCust.Columns["CONTACT"].Width = 250;
            dgCust.Columns["CONTACT"].HeaderText = "ФИО и контакты с руководителем";
            dgCust.Columns["ADDRESS"].Width = 250;
            dgCust.Columns["ADDRESS"].HeaderText = "Адрес";

            dgDept.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dgDept.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            dgDept.DataSource = dbc.GetDeptsByIDCustomer(dgCust.SelectedRows[0].Cells["ID"].Value.ToString());
            dgDept.Columns["ID"].Visible = false;
            dgDept.Columns["DEPTNAME"].Width = 250;
            dgDept.Columns["DEPTNAME"].HeaderText = "Название отдела";
            dgDept.Columns["CONTACTEXE"].Width = 250;
            dgDept.Columns["CONTACTEXE"].HeaderText = "ФИО и контакты с исполнителем";
            dgDept.Columns["CONTACTFINLOG"].Width = 250;
            dgDept.Columns["CONTACTFINLOG"].HeaderText = "Контакты с финансово логистической службой";


        }

        private void dgCust_SelectionChanged(object sender, EventArgs e)
        {

            if (dgCust.SelectedRows.Count == 0) return;
            DBCustomer dbc = new DBCustomer();

            dgDept.DataSource = dbc.GetDeptsByIDCustomer(dgCust.SelectedRows[0].Cells["ID"].Value.ToString());
            dgDept.Columns["ID"].Visible = false;
            dgDept.Columns["DEPTNAME"].Width = 250;
            dgDept.Columns["DEPTNAME"].HeaderText = "Название отдела";
            dgDept.Columns["CONTACTEXE"].Width = 250;
            dgDept.Columns["CONTACTEXE"].HeaderText = "ФИО и контакты с исполнителем";
            dgDept.Columns["CONTACTFINLOG"].Width = 250;
            dgDept.Columns["CONTACTFINLOG"].HeaderText = "Контакты с финансово логистической службой";

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (dgDept.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите отдел!");
                return;
            }
            fEditCustomersDept fecd = new fEditCustomersDept(dgDept.SelectedRows[0].Cells["ID"].Value.ToString());
            fecd.ShowDialog();
            DBCustomer dbc = new DBCustomer();

            dgDept.DataSource = dbc.GetDeptsByIDCustomer(dgCust.SelectedRows[0].Cells["ID"].Value.ToString());
            MessageBox.Show("Отдел успешно изменён!");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            dgCust.CurrentCell = null;
            dgDept.DataSource = null;
            foreach (DataGridViewRow r in dgCust.Rows)
            {
                if (textBox1.Text == "")
                {
                    r.Visible = true;
                    continue;
                }
                if (!r.Cells["CNAME"].Value.ToString().ToLower().Contains(textBox1.Text.ToLower()))
                {
                    r.Visible = false;
                }
                else
                {
                    r.Visible = true;
                }

            }
        }
    }
}
