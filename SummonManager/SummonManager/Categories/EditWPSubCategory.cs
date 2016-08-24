using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SummonManager.CLASSES;
using System.Diagnostics;

namespace SummonManager
{
    public partial class EditWPSubCategory: Form
    {
        int IDCat;
        string ENTITY;//сущность, которой принадлежат категории
        public EditWPSubCategory(int IDCat,string Entity_)
        {
            this.ENTITY = Entity_;
            InitializeComponent();
            this.IDCat = IDCat;
            DBSubCategory dbc = new DBSubCategory();
            dgWP.DataSource = dbc.GetAll(IDCat);
            dgWP.Columns["ID"].Visible = false;
            dgWP.Columns["IDCATEGORY"].Visible = false;
            dgWP.Columns["SUBCATNAME"].HeaderText = "Наименование подкатегории";
            dgWP.Columns["SUBCATNAME"].Width = 200;

            this.Text = "Подкатегории категории \"" + new DBCategory(this.ENTITY).GetName(IDCat) + "\"";
            switch (this.ENTITY)
            {
                case "WPNAMELIST":
                    this.Text = "Подкатегории изделия";
                    break;
                case "CABLELIST":
                    this.Text = "Подкатегории кабелей";
                    break;
                case "ZHGUTLIST":
                    this.Text = "Подкатегории жгутов";
                    break;
                case "RUNCARDLIST":
                    this.Text = "Подкатегории технологических карт";
                    break;
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dgWP.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите подкатегорию!");
                return;
            }

            NewSubCategory n = new NewSubCategory((int)dgWP.SelectedRows[0].Cells["IDCATEGORY"].Value);
            n.ShowDialog();
            dgWP.DataSource = new DBSubCategory().GetAll(IDCat);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dgWP.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите строку!");
                return;
            }
            if ((dgWP.SelectedRows[0].Cells["SUBCATNAME"].Value.ToString().ToUpper() == "ВСЕ") || (dgWP.SelectedRows[0].Cells["SUBCATNAME"].Value.ToString() == "НЕ ПРИСВОЕНО"))
            {
                MessageBox.Show("Вы не можете изменить эту подкатегорию, так как она является системной!");
                return;
            }
            NewSubCategory n = new NewSubCategory(dgWP.SelectedRows[0].Cells["SUBCATNAME"].Value.ToString(), (int)dgWP.SelectedRows[0].Cells["ID"].Value, IDCat);
            n.ShowDialog();
            dgWP.DataSource = new DBSubCategory().GetAll(IDCat);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (dgWP.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите строку!");
                return;
            }
            if ((dgWP.SelectedRows[0].Cells["SUBCATNAME"].Value.ToString().ToUpper() == "ВСЕ") || (dgWP.SelectedRows[0].Cells["SUBCATNAME"].Value.ToString() == "НЕ ПРИСВОЕНО"))
            {
                MessageBox.Show("Вы не можете удалить эту подкатегорию, так как она является системной!");
                return;
            }

            //DialogResult dr = MessageBox.Show("После удаления подкатегории все изделия этой подкатегории получат пустую подкатегорию! Вы действительно хотите удалить подкатегорию?", "Внимание!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            //if (dr == DialogResult.Yes)
            try
            {
                new DBSubCategory().Delete(dgWP.SelectedRows[0].Cells["ID"].Value.ToString());
                MessageBox.Show("Подкатегория успешно удалена!");
            }
            catch
            {
                MessageBox.Show("Вы не можете удалить эту подкатегорию, так как существуют изделия с такой подкатегорией!");
                return;
            }
            dgWP.DataSource = new DBSubCategory().GetAll(IDCat);

        }

        

        

       
    }
}
