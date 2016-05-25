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
    public partial class EditPacking : Form
    {
        string IDW;
        public EditPacking(string idw)
        {
            InitializeComponent();
            this.IDW = idw;
            DBPacking dbwp = new DBPacking();
            textBox1.Text = dbwp.Get(this.IDW);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Введите наименование!");
                return;
            }
            DBPacking dbwp = new DBPacking();
            dbwp.Edit(textBox1.Text,this.IDW);
            MessageBox.Show("Наименование успешно изменено!");
            Close();
        }
    }
}
