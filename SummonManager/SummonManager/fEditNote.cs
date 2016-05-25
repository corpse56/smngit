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
    public partial class fEditNote : Form
    {
        string idnote;
        DBSummon dbs;
        SummonVO SVO;
        public string notetext = "";
        public bool result = false;
        public fEditNote(string idnote_,string notetext_)
        {
            InitializeComponent();
            this.idnote = idnote_;
            this.notetext = notetext_;
            textBox1.Text = notetext_;
            //dbs = new DBSummon();
            //SVO = dbs.GetSummonByIDS(ids);
            //textBox1.Text = SVO.NOTE;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            /*SVO.NOTE = textBox1.Text;
            dbs.SaveSummon(SVO);
            notetext = textBox1.Text;*/

            if (textBox1.Text == "")
            {
                MessageBox.Show("Введите текст!");
                return;
            }
            DBSummonNotes dbsn = new DBSummonNotes();
            dbsn.UpdateNote(idnote, textBox1.Text);
            result = true;
            MessageBox.Show("Сохранено успешно!");
            Close();
        }
    }
}
