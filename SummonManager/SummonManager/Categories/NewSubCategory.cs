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
    public partial class NewSubCategory : Form
    {
        bool edit = false;
        int editID, IDSubCat,IDCat;
        public NewSubCategory(int idCat)
        {
            InitializeComponent();
            IDCat = idCat;
        }
        public NewSubCategory(string subcat, int IDSubCat, int idCat)
        {
            InitializeComponent();
            textBox1.Text = subcat;
            this.Text = "Изменение подкатегории";
            edit = true;
            editID = IDSubCat;
            button2.Text = "Изменить";
            IDCat = idCat;
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

            if (edit)
            {
                DBSubCategory dbwp = new DBSubCategory();
                dbwp.Edit(textBox1.Text, editID.ToString());
                MessageBox.Show("Подкатегория успешно изменена!");
            }
            else
            {
                DBSubCategory dbwp = new DBSubCategory();
                dbwp.AddNew(textBox1.Text,IDCat);
                MessageBox.Show("Подкатегория успешно добавлена!");
            }
            Close();
        }
    }
}
