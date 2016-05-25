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
    public partial class fAddNote : Form
    {
        string id;
        string idu;
        public string notetext = "";
        public bool result = false;

        public fAddNote(string id_,string idu_)
        {
            InitializeComponent();
            this.id = id_;
            this.idu = idu_;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 750)
            {
                MessageBox.Show("Вы превысили ограничение в 750 знаков для одного примечания! ("+textBox1.Text.Length+")");
                return;
            }
            result = true;
            DBSummonNotes dbsn = new DBSummonNotes();
            dbsn.AddNote(id,textBox1.Text,idu);
            //MessageBox.Show("Сохранено успешно!");
            Close();
        }
    }
}
