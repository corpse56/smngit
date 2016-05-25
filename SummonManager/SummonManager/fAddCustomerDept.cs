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
    public partial class fAddCustomerDept : Form
    {
        string IDC;

        public fAddCustomerDept(string idc)
        {
            InitializeComponent();
            IDC = idc;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Наименование отдела не может быть пустым!");
                return;
            }
            DBCustomer dbc = new DBCustomer();
            dbc.AddDeptToCustomer(this.IDC,textBox1.Text, textBox2.Text, textBox3.Text);
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
