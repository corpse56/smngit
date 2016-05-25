using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SummonManager.CLASSES.IRole_namespace;

namespace SummonManager
{
    public partial class fAdminChangeStatus : Form
    {
        SummonVO SVO;
        IRole UVO;
        public fAdminChangeStatus(SummonVO svo, IRole uvo)
        {
            InitializeComponent();
            
            this.SVO = svo;
            this.UVO = uvo;
        }

        private void fAdminChangeStatus_Load(object sender, EventArgs e)
        {
            DBCurStatus dbcs = new DBCurStatus();
            comboBox1.ValueMember = "ID";
            comboBox1.DisplayMember = "SNAME";
            comboBox1.DataSource = dbcs.GetAllStatuses();
            comboBox1.SelectedValue = SVO.IDSTATUS;
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Укажите причину смены статуса!");
                return;
            }
            DBCurStatus dbcs = new DBCurStatus();
            dbcs.ChangeStatus(this.SVO, (int)comboBox1.SelectedValue, textBox1.Text, this.UVO.id);

            MessageBox.Show("Статус успешно изменён!");
            Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
