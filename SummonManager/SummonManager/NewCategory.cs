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
    public partial class NewCategory : Form
    {
        string ENTITY;
        public NewCategory(string Entity_)
        {
            this.ENTITY = Entity_;
            InitializeComponent();
            switch (this.ENTITY)
            {
                case "WPNAMELIST":
                    this.Text = "Добавление новой категории изделия";
                    break;
                case "CABLELIST":
                    this.Text = "Добавление новой категории кабелей";
                    break;
                case "ZHGUTLIST":
                    this.Text = "Добавление новой категории жгутов";
                    break;
                case "RUNCARDLIST":
                    this.Text = "Добавление новой категории технологических карт";
                    break;
            }
        }
        bool edit = false;
        int editID;
        public NewCategory(string cat,int id)
        {
            InitializeComponent();
            textBox1.Text = cat;
            this.Text = "Изменение категории";
            edit = true;
            editID = id;
            button2.Text = "Изменить";
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
                DBCategory dbwp = new DBCategory(this.ENTITY);
                dbwp.Edit(textBox1.Text, editID.ToString());
                MessageBox.Show("Категория успешно изменена!");
            }
            else
            {
                DBCategory dbwp = new DBCategory(ENTITY);
                dbwp.AddNew(textBox1.Text);
                MessageBox.Show("Категория успешно добавлена!");
            }
            Close();
        }
    }
}
