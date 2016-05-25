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
    public partial class EditUser : Form
    {
        string IDU;
        public EditUser(string idu)
        {
            InitializeComponent();
            this.IDU = idu;
            DBUser dbu = new DBUser();
            DataTable user = dbu.GetUser(idu);
            cbRole.ValueMember = "ID";
            cbRole.DisplayMember = "ROLENAME";
            cbRole.DataSource = dbu.GetAllRoles();
            cbRole.SelectedValue = (int)user.Rows[0]["ROLE"];

            textBox1.Text = user.Rows[0]["FIO"].ToString();
            textBox2.Text = user.Rows[0]["LOGIN"].ToString();
            textBox3.Text = user.Rows[0]["PASS"].ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DBUser dbu = new DBUser();
            dbu.EditUser(textBox1.Text,textBox2.Text,textBox3.Text,((int)cbRole.SelectedValue).ToString(),this.IDU);
            MessageBox.Show("Пользователь успешно изменён!");
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }


    }
}
