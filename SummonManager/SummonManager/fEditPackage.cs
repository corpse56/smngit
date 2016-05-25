using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SummonManager.CLASSES;
using SummonManager.CLASSES.IRole_namespace;

namespace SummonManager
{
    public partial class fEditPackage : Form
    {
        public WPTYPE WPT;
        public int IDWP;
        IRole UVO;
        public fEditPackage(WPTYPE wpt, int idwp, IRole uvo)
        {
            InitializeComponent();
            this.WPT = wpt;
            this.IDWP = idwp;
            this.UVO = uvo;
            
        }

        private void bClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bAdd_Click(object sender, EventArgs e)
        {

            PickIntoPackage pick = new PickIntoPackage(UVO, WPT);
            pick.ShowDialog();

            if (pick.PickedID == 0) return;
            if (WPT == WPTYPE.CABLELIST)
            {
                DBCableList dbc = new DBCableList();
                dbc.AddToPackage(IDWP, pick.PickedID, pick.getCount());
            }
            if (WPT == WPTYPE.ZHGUTLIST)
            {
                DBZhgutList dbz = new DBZhgutList();
                dbz.AddToPackage(IDWP, pick.PickedID, pick.getCount());
            }
            fEditExtCablePack_Load(sender, e);
        }

        private void bDel_Click(object sender, EventArgs e)
        {
            if (dgv.SelectedRows.Count == 0)
            {
                MessageBox.Show("Ничего не выбрано!");
                return;
            }

            DialogResult dr = MessageBox.Show("Вы действительно хотите удалить выбранную позицию из комплекта?", "Внимание!", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (dr == DialogResult.No)
            {
                return;
            }
            if (WPT == WPTYPE.CABLELIST)
            {
                DBCableList dbcab = new DBCableList();
                dbcab.RemoveFromPackage((int)dgv.SelectedRows[0].Cells["idc"].Value);

            }
            if (WPT == WPTYPE.ZHGUTLIST)
            {
                DBZhgutList dbz = new DBZhgutList();
                dbz.RemoveFromPackage((int)dgv.SelectedRows[0].Cells["idz"].Value);

            }

            MessageBox.Show("Позиция успешно удалена!");

            fEditExtCablePack_Load(sender, e);

        }

        private void fEditExtCablePack_Load(object sender, EventArgs e)
        {
            if (WPT == WPTYPE.CABLELIST)
            {
                this.Text = "Редактирование комплекта кабелей";
                DBCableList dbc = new DBCableList();
                dgv.DataSource = dbc.GetPackage(this.IDWP);
                dgv.Columns["name"].HeaderText = "Название кабеля";
                dgv.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
                dgv.Columns["idc"].Visible = false;
                dgv.Columns["nn"].HeaderText = "№№";
                dgv.Columns["nn"].Width = 30;
                dgv.Columns["name"].Width = 500;
                dgv.Columns["CNT"].HeaderText = "Количество";
                dgv.Columns["CNT"].Width = 150;
                int i = 0;
                foreach (DataGridViewRow r in dgv.Rows)
                {
                    r.Cells["nn"].Value = ++i;
                }
            }
            if (WPT == WPTYPE.ZHGUTLIST)
            {
                this.Text = "Редактирование комплекта жгутов";
                DBZhgutList dbz = new DBZhgutList();
                dgv.DataSource = dbz.GetPackage(this.IDWP);
                dgv.Columns["name"].HeaderText = "Название жгута";
                dgv.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
                dgv.Columns["idz"].Visible = false;
                dgv.Columns["nn"].HeaderText = "№№";
                dgv.Columns["nn"].Width = 30;
                dgv.Columns["name"].Width = 500;
                dgv.Columns["CNT"].HeaderText = "Количество";
                dgv.Columns["CNT"].Width = 150;
                int i = 0;
                foreach (DataGridViewRow r in dgv.Rows)
                {
                    r.Cells["nn"].Value = ++i;
                }
            }

        }

    }
}
