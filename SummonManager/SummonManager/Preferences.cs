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
    public partial class Preferences : Form
    {
        int UserID;

        Control CurrentControl = null;
        MainF mf;
        public Preferences(int UserID_,MainF mf_)
        {
            InitializeComponent();
            this.UserID = UserID_;
            Type RefreshTimeSelectControl_type = typeof(RefreshTimeSelectControl);
            Type ColorSelectControl_type = typeof(ColorSelectControl);
            treeView1.Nodes[0].Nodes["FrequencyNode"].Tag = (object)RefreshTimeSelectControl_type;
            //treeView1.Nodes[0].Tag = RefreshTimeSelectControl_type;
            //treeView1.Nodes[0].Nodes["ColorNode"].Tag = (object)ColorSelectControl_type;
            //treeView1.Nodes[1].Tag = ColorSelectControl_type;
            this.mf = mf_;
            treeView1.ExpandAll();
        }

        private void treeView1_Click(object sender, EventArgs e)
        {
            
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Tag == null)
            {
                button1.Enabled = false;
                return;
            }
            Control c = (Control)Activator.CreateInstance((Type)e.Node.Tag);
            if (CurrentControl != null)
            {
                CurrentControl.Controls.Remove(CurrentControl);
                CurrentControl.Dispose();
            }
            CurrentControl = c;
            panel1.Controls.Add(CurrentControl);

            LoadPreferences(CurrentControl);
            button1.Enabled = true;
        }

        private void LoadPreferences(Control CurrentControl)
        {
            DBPreferences dbp = new DBPreferences(UserID);
            string t = CurrentControl.GetType().Name.ToString();
            switch (t)
            {
                case "RefreshTimeSelectControl":
                    RefreshTimeSelectControl rtsc = (RefreshTimeSelectControl)CurrentControl;
                    if (dbp.RefreshTime == 10 * 60000)
                    {
                        rtsc.radioButton1.Checked = true;
                    }
                    if (dbp.RefreshTime == 30 * 60000)
                    {
                        rtsc.radioButton2.Checked = true;
                    }
                    if (dbp.RefreshTime == 60 * 60000)
                    {
                        rtsc.radioButton3.Checked = true;
                    }
                    if (dbp.RefreshTime == 120 * 60000)
                    {
                        rtsc.radioButton4.Checked = true;
                    }
                    if (dbp.RefreshTime == 180 * 60000)
                    {
                        rtsc.radioButton5.Checked = true;
                    }
                    if (dbp.RefreshTime == 240 * 60000)
                    {
                        rtsc.radioButton6.Checked = true;
                    }
                    break;
                case "ColorSelectControl":
                    ColorSelectControl csc = (ColorSelectControl)CurrentControl;
                    if (dbp.NoteColor == csc.panel1.BackColor.ToArgb())
                    {
                        csc.radioButton1.Checked = true;
                    }
                    if (dbp.NoteColor == csc.panel2.BackColor.ToArgb())
                    {
                        csc.radioButton2.Checked = true;
                    }
                    if (dbp.NoteColor == csc.panel3.BackColor.ToArgb())
                    {
                        csc.radioButton3.Checked = true;
                    }
                    if (dbp.NoteColor == csc.panel4.BackColor.ToArgb())
                    {
                        csc.radioButton4.Checked = true;
                    }
                    if (dbp.NoteColor == csc.panel5.BackColor.ToArgb())
                    {
                        csc.radioButton5.Checked = true;
                    }
                    break;
            }
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DBPreferences dbp = new DBPreferences(this.UserID);
            switch (CurrentControl.GetType().Name)
            {
                case "RefreshTimeSelectControl":
                    RefreshTimeSelectControl rtsc = (RefreshTimeSelectControl)CurrentControl;
                    if (rtsc.radioButton1.Checked)
                    {
                        dbp.SaveRefreshTime(UserID.ToString(), 10 * 60000);
                        mf.SetRefreshTime(10 * 60000);
                    }
                    if (rtsc.radioButton2.Checked)
                    {
                        dbp.SaveRefreshTime(UserID.ToString(), 30 * 60000);
                        mf.SetRefreshTime(30 * 60000);
                    }
                    if (rtsc.radioButton3.Checked)
                    {
                        dbp.SaveRefreshTime(UserID.ToString(), 60 * 60000);
                        mf.SetRefreshTime(60 * 60000);
                    }
                    if (rtsc.radioButton4.Checked)
                    {
                        dbp.SaveRefreshTime(UserID.ToString(), 120 * 60000);
                        mf.SetRefreshTime(120 * 60000);
                    }
                    if (rtsc.radioButton5.Checked)
                    {
                        dbp.SaveRefreshTime(UserID.ToString(), 180 * 60000);
                        mf.SetRefreshTime(180 * 60000);
                    }
                    if (rtsc.radioButton6.Checked)
                    {
                        dbp.SaveRefreshTime(UserID.ToString(), 240 * 60000);
                        mf.SetRefreshTime(240 * 60000);
                    }
                    break;
                case "ColorSelectControl":
                    ColorSelectControl csc = (ColorSelectControl)CurrentControl;
                    if (csc.radioButton1.Checked)
                    {
                        dbp.SaveNoteColor(UserID.ToString(), csc.panel1.BackColor.ToArgb());
                        mf.SetNoteColor(csc.panel1.BackColor.ToArgb());
                    }
                    if (csc.radioButton2.Checked)
                    {
                        dbp.SaveNoteColor(UserID.ToString(), csc.panel2.BackColor.ToArgb());
                        mf.SetNoteColor(csc.panel2.BackColor.ToArgb());
                    }
                    if (csc.radioButton3.Checked)
                    {
                        dbp.SaveNoteColor(UserID.ToString(), csc.panel3.BackColor.ToArgb());
                        mf.SetNoteColor(csc.panel3.BackColor.ToArgb());
                    }
                    if (csc.radioButton4.Checked)
                    {
                        dbp.SaveNoteColor(UserID.ToString(), csc.panel4.BackColor.ToArgb());
                        mf.SetNoteColor(csc.panel4.BackColor.ToArgb());
                    }
                    if (csc.radioButton5.Checked)
                    {
                        dbp.SaveNoteColor(UserID.ToString(), csc.panel5.BackColor.ToArgb());
                        mf.SetNoteColor(csc.panel5.BackColor.ToArgb());
                    }
                    break;
            }
            button1.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button1.Enabled)
            {
                button1_Click(sender, e);
            }
            Close();
        }


    }
}
