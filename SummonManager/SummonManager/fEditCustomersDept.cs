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
    public partial class fEditCustomersDept : Form
    {
        string IDD;
        public fEditCustomersDept(string idd)
        {
            InitializeComponent();
            IDD = idd;
            DBCustomer dbc = new DBCustomer();
            DataTable t = dbc.GetDeptByID(IDD);
            textBox1.Text = t.Rows[0]["DEPTNAME"].ToString();
            textBox2.Text = t.Rows[0]["CONTACTEXE"].ToString();
            textBox3.Text = t.Rows[0]["CONTACTFINLOG"].ToString();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Название отдела не может быть пустым!");
                return;
            }
            DBCustomer dbc = new DBCustomer();
            dbc.EditDept(IDD,textBox1.Text, textBox2.Text, textBox3.Text);
            Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
