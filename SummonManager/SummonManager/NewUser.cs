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
    public partial class NewUser : Form
    {
        public NewUser()
        {
            InitializeComponent();
            DBUser dbu = new DBUser();
            cbRole.ValueMember = "ID";
            cbRole.DisplayMember = "ROLENAME";
            cbRole.DataSource = dbu.GetAllRoles();
            //cbRole.SelectedValue = SVO.IDCUSTOMER;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DBUser dbu = new DBUser();
            dbu.AddNewUser(textBox1.Text,textBox2.Text,textBox3.Text,(int)cbRole.SelectedValue);
            MessageBox.Show("Пользователь успешно добавлен!");
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }


    }
}
