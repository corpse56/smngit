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
    public partial class Users : Form
    {
        public Users()
        {
            InitializeComponent();
            DBUser dbu = new DBUser();
            dgCust.DataSource = dbu.GetAllUsers();
            dgCust.Columns["ID"].Visible = false;
            dgCust.Columns["FIO"].Width = 200;
            dgCust.Columns["FIO"].HeaderText = "ФИО";
            dgCust.Columns["LOGIN"].Width = 100;
            dgCust.Columns["LOGIN"].HeaderText = "Логин";
            dgCust.Columns["PASS"].Width = 100;
            dgCust.Columns["PASS"].HeaderText = "Пароль";
            dgCust.Columns["ROLENAME"].Width = 150;
            dgCust.Columns["ROLENAME"].HeaderText = "Роль";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            NewUser nu = new NewUser();
            nu.ShowDialog();
            DBUser dbu = new DBUser();
            dgCust.DataSource = dbu.GetAllUsers();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dgCust.SelectedRows.Count != 1)
            {
                MessageBox.Show("Не выбрано ни одной строки!");
                return;
            }
            EditUser eu = new EditUser(dgCust.SelectedRows[0].Cells["ID"].Value.ToString());
            eu.ShowDialog();
            DBUser dbu = new DBUser();
            dgCust.DataSource = dbu.GetAllUsers();

        }
    }
}
