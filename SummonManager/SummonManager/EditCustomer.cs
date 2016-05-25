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
    public partial class EditCustomer : Form
    {
        private string ID;
        public EditCustomer(string id)
        {
            InitializeComponent();
            this.ID = id;
            DBCustomer dbc = new DBCustomer();
            DataTable customer = dbc.GetCustomerByID(id);
            tbName.Text = customer.Rows[0]["CNAME"].ToString();
            tbAddress.Text = customer.Rows[0]["ADDRESS"].ToString();
            tbDir.Text = customer.Rows[0]["CONTACT"].ToString();
            //tbExe.Text = customer.Rows[0]["CONTACTEXE"].ToString();
            //tbFin.Text = customer.Rows[0]["CONTACTFINLOG"].ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if ((tbName.Text == ""))
            {
                MessageBox.Show("Заполните название организации!");
                return;
            }
            DBCustomer dbc = new DBCustomer();
            dbc.EditCustomer(tbName.Text, tbAddress.Text,this.ID,tbDir.Text);
            MessageBox.Show("Закказчик успешно изменён!");
            Close();

        }
    }
}
