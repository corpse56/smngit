using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Diagnostics;
using SummonManager.CLASSES;
using SummonManager.CLASSES.IRole_namespace;
using SummonManager.Properties;

namespace SummonManager
{
    public struct Base
    {
        public static string BaseName = "ALPHA";
    }
    public partial class MainF : Form
    {
        //public static string EConnectionString = "metadata=res://*/SM.csdl|res://*/SM.ssdl|res://*/SM.msl;provider=System.Data.SqlClient;provider connection string=\"Data Source=CORPS-ПК\\SQLEXPRESS;Initial Catalog=" + Base.BaseName + ";Persist Security Info=True;User ID=summon;Password=summon;MultipleActiveResultSets=True\"";
        //public static string ConnectionString = "Data Source=CORPS-ПК\\SQLEXPRESS;Initial Catalog=" + Base.BaseName + ";Persist Security Info=True;User ID=summon;Password=summon;MultipleActiveResultSets=True";
        
        //public static string ConnectionString = "Data Source=127.0.0.1;Initial Catalog=" + Base.BaseName + ";Persist Security Info=True;User ID=summon;Password=summon;MultipleActiveResultSets=True";
        //public static string ConnectionString = "Data Source=127.0.0.1\\SQL2008R2;Initial Catalog=" + Base.BaseName + ";Persist Security Info=True;User ID=summon;Password=summon;MultipleActiveResultSets=True";
        
        public static string ConnectionString = "Data Source=10.177.100.7,2301;Initial Catalog=" + Base.BaseName + ";Persist Security Info=True;User ID=summon;Password=summon;MultipleActiveResultSets=True";
        public IRole UVO;
        public int PrivateNoteColor;
        public int RefreshTime;
        public static string ProgramVersion = "2.18";
        public static int VersionNumber = 218;
        //работаем над системой замечаний
        public MainF()
        {
            InitializeComponent();
        }
        private void AllocateRoles()
        {
            switch (UVO.Role)
            {
                case Roles.Admin:
                    NewMenuItem.Enabled = false;
                    toolStripButton1.Enabled = false;
                    MySummonsTSB.Enabled = false;
                    SpravochnikiEnable();
                    пользователиToolStripMenuItem.Enabled = true;

                    break;
                case Roles.Montage: case Roles.MainMontage:
                    SpravochnikiDisable();
                    NewMenuItem.Enabled = false;
                    toolStripButton1.Enabled = false;
                    MySummonsTSB.Enabled = true;
                    break;
                case Roles.Director:
                    SpravochnikiDisable();
                    NewMenuItem.Enabled = false;
                    toolStripButton1.Enabled = false;
                    MySummonsTSB.Enabled = false;
                    break;
                case Roles.Logist:
                    SpravochnikiDisable();
                    NewMenuItem.Enabled = false;
                    toolStripButton1.Enabled = false;
                    MySummonsTSB.Enabled = true;
                    break;
                case Roles.Manager:
                    NewMenuItem.Enabled = true;
                    toolStripButton1.Enabled = true;
                    SpravochnikiEnable();
                    пользователиToolStripMenuItem.Enabled = false;
                    MySummonsTSB.Enabled = true;
                    break;
                case Roles.OTK:
                    SpravochnikiDisable();
                    NewMenuItem.Enabled = false;
                    toolStripButton1.Enabled = false;
                    MySummonsTSB.Enabled = true;
                    break;
                case Roles.Ozis:
                    SpravochnikiDisable();
                    NewMenuItem.Enabled = false;
                    toolStripButton1.Enabled = false;
                    MySummonsTSB.Enabled = true;
                    break;
                case Roles.Prod:
                    SpravochnikiDisable();
                    NewMenuItem.Enabled = false;
                    toolStripButton1.Enabled = false;
                    MySummonsTSB.Enabled = true;
                    break;
                case Roles.Ware:
                    SpravochnikiDisable();
                    NewMenuItem.Enabled = false;
                    toolStripButton1.Enabled = false;
                    MySummonsTSB.Enabled = true;
                    break;
                case Roles.Wsh:
                    SpravochnikiDisable();
                    NewMenuItem.Enabled = false;
                    toolStripButton1.Enabled = false;
                    MySummonsTSB.Enabled = true;
                    break;
                case Roles.Constructor:
                    SpravochnikiDisable(); 
                    NewMenuItem.Enabled = false;
                    toolStripButton1.Enabled = false;
                    MySummonsTSB.Enabled = true;
                    break;
                case Roles.Inzhener:

                    if (UVO.Login == "atrofimenkov")
                    {
                        SpravochnikiEnable(); //исключение для Андрюхи
                    }
                    else
                    {
                        SpravochnikiDisable();
                    }
                    NewMenuItem.Enabled = false;
                    toolStripButton1.Enabled = false;
                    MySummonsTSB.Enabled = true;
                    break;
                case Roles.Buhgalter:
                    SpravochnikiDisable();
                    NewMenuItem.Enabled = false;
                    toolStripButton1.Enabled = false;
                    //MySummonsTSB.Enabled = false;
                    break;
                case Roles.SimpleInzhener:
                    SpravochnikiDisable();
                    NewMenuItem.Enabled = false;
                    toolStripButton1.Enabled = false;
                    //MySummonsTSB.Enabled = false;
                    break;
                case Roles.Tehnolog:
                    SpravochnikiDisable();
                    NewMenuItem.Enabled = false;
                    toolStripButton1.Enabled = false;
                    //MySummonsTSB.Enabled = false;
                    break;
                case Roles.Shemotehnik:
                    SpravochnikiDisable();
                    NewMenuItem.Enabled = false;
                    toolStripButton1.Enabled = false;
                    //MySummonsTSB.Enabled = false;
                    break;
                case Roles.OTD:
                    SpravochnikiDisable();
                    NewMenuItem.Enabled = false;
                    toolStripButton1.Enabled = false;
                    //MySummonsTSB.Enabled = false;
                    break;
            }
        }
        public void SpravochnikiDisable()
        {
            справочникиToolStripMenuItem.Enabled = true;
            заказчикиToolStripMenuItem.Enabled = false;
            пользователиToolStripMenuItem.Enabled = false;
            наименованиеИзделияToolStripMenuItem.Enabled = true;//открыто всем на чтение
            упаковкаToolStripMenuItem.Enabled = false;
        }
        
        public void SpravochnikiEnable()
        {
            справочникиToolStripMenuItem.Enabled = true;
            заказчикиToolStripMenuItem.Enabled = true;
            пользователиToolStripMenuItem.Enabled = true;
            наименованиеИзделияToolStripMenuItem.Enabled = true;
            упаковкаToolStripMenuItem.Enabled = true;
        }
        PreviousState ps = null;
        bool InitialReload = true;
        private void ReloadData()
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            if (!InitialReload)
            {
                ps = new PreviousState(dgSummon,TStbs.Text);
            }
            sw.Stop();
            //MessageBox.Show("ps = new PreviousState(dgSummon,TStbs.Text);" + (sw.ElapsedMilliseconds / 100.0).ToString());

            DBMain dbMain = new DBMain();
            dgSummon.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dgSummon.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgSummon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            sw.Reset();
            sw.Start();
            if (MySummonsTSB.Checked)
            {
                dgSummon.DataSource = dbMain.GetMainViewMy(UVO.Role,UVO);
            }
            else
            {
                dgSummon.DataSource = dbMain.GetMainView(UVO.Role,UVO);
            }
            sw.Stop();
            //MessageBox.Show("dgSummon.DataSource = dbMain.GetMainView" + (sw.ElapsedMilliseconds / 100.0).ToString());
            if (InitialReload)
            {
                dgSummon.Columns["id"].Visible = false;
                dgSummon.Columns["ids"].HeaderText = "Номер извещения";
                dgSummon.Columns["remark_exist"].HeaderText = "Заме чание";
                dgSummon.Columns["contract_type"].HeaderText = "Тип договора";
                dgSummon.Columns["wname"].HeaderText = "Наименование изделия";
                dgSummon.Columns["cust"].HeaderText = "Заказчик";
                dgSummon.Columns["sts"].HeaderText = "Статус";
                dgSummon.Columns["subst"].HeaderText = "Субстатус";
                dgSummon.Columns["sisp"].HeaderText = "СИ и СП";
                dgSummon.Columns["note"].HeaderText = "Примечание";
                dgSummon.Columns["ptime"].HeaderText = "Срок сдачи изделия";
                dgSummon.Columns["ptime"].DefaultCellStyle.Format = "dd.MM.yyyy HH:mm";
                //dgSummon.Columns["passd"].HeaderText = "Ориенти ровочная дата передачи";
                //dgSummon.Columns["passd"].ValueType = typeof(string);
                //dgSummon.Columns["passd"].DefaultCellStyle.Format = "dd.MM.yyyy";
                dgSummon.Columns["techreq"].HeaderText = "Технические требования";
                dgSummon.Columns["qty"].HeaderText = "Кол-во";
                dgSummon.Columns["idstatus"].Visible = false;
                dgSummon.Columns["ids_srt"].Visible = false;
                dgSummon.Columns["vw"].Visible = false;
                dgSummon.Columns["dview"].Visible = false;
                dgSummon.Columns["dview"].ValueType = typeof(DateTime);
                dgSummon.Columns["pdc"].Visible = false;
                dgSummon.Columns["pdc"].ValueType = typeof(DateTime);
                dgSummon.Columns["ncre"].Visible = false;
                dgSummon.Columns["ncre"].ValueType = typeof(DateTime);
                dgSummon.Columns["paint_constr"].Visible = false;
                dgSummon.Columns["paint_inzh"].Visible = false;
                dgSummon.Columns["paint_otk"].Visible = false;
                dgSummon.Columns["shild_ordered"].Visible = false;//paint_ozis
                dgSummon.Columns["idsubst"].Visible = false;
                dgSummon.Columns["paint_shemotehnik"].Visible = false;
                dgSummon.Columns["paint_OTD"].Visible = false;
                dgSummon.Columns["passd"].Visible = false;
                dgSummon.Columns["remark_exist_paint"].Visible = false;


                //dgSummon.Columns["qty"].Width = 50;
                //dgSummon.Columns["cause"].Width = 130;
                //dgSummon.Columns["passd"].Width = 85;
                //dgSummon.Columns["ptime"].Width = 130;
                //dgSummon.Columns["note"].Width = 250;
                //dgSummon.Columns["dt"].Width = 130;
                //dgSummon.Columns["ids"].Width = 80;
                //dgSummon.Columns["wname"].Width = 140;
                //dgSummon.Columns["cust"].Width = 190;
                //dgSummon.Columns["sts"].Width = 100;
                sw.Reset();
                sw.Start();
                
                dgSummon.Columns["qty"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgSummon.Columns["techreq"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                //dgSummon.Columns["passd"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgSummon.Columns["ptime"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgSummon.Columns["note"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgSummon.Columns["sisp"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgSummon.Columns["ids"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgSummon.Columns["wname"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgSummon.Columns["cust"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgSummon.Columns["sts"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgSummon.Columns["subst"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgSummon.Columns["contract_type"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgSummon.Columns["remark_exist"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                dgSummon.Columns["qty"].FillWeight = 50;
                dgSummon.Columns["techreq"].FillWeight = 130;
                //dgSummon.Columns["passd"].FillWeight = 85;
                dgSummon.Columns["ptime"].FillWeight = 100;
                dgSummon.Columns["note"].FillWeight = 250;
                dgSummon.Columns["sisp"].FillWeight = 50;
                dgSummon.Columns["ids"].FillWeight = 80;
                dgSummon.Columns["wname"].FillWeight = 140;
                dgSummon.Columns["cust"].FillWeight = 190;
                dgSummon.Columns["sts"].FillWeight = 100;
                dgSummon.Columns["subst"].FillWeight = 100;
                dgSummon.Columns["contract_type"].FillWeight = 60;
                dgSummon.Columns["remark_exist"].FillWeight = 30;
            }
            foreach (DataGridViewRow r in dgSummon.Rows)
            {
                r.Cells["techreq"].Tag = r.Cells["techreq"].Value;
                r.Cells["techreq"].Value = r.Cells["techreq"].Tag.ToString().Substring(r.Cells["techreq"].Tag.ToString().LastIndexOf("\\") + 1);
                /*if ((int)r.Cells["remark_exist"].Value == 1)
                {
                    r.Cells["remark_exist"].
                }*/
            }
            sw.Stop();
            //MessageBox.Show("dgSummon.FillWeight=" + (sw.ElapsedMilliseconds / 100.0).ToString());


            InitialSort();//это надо потом убрать и заняться восстановлением предыдущего состояния грид
            sw.Reset();
            sw.Start();

            sw.Stop();
            //MessageBox.Show("PaintDG();" + (sw.ElapsedMilliseconds / 100.0).ToString());

            sw.Reset();
            sw.Start();

///////////////////////////////////////////////

            FillNotifications();
            if (UVO == null) return;

            switch (UVO.Role)
            {
                case Roles.OTK:
                    NotifyMeOTK();
                    break;
                case Roles.Constructor:
                    NotifyMeCONSTR();
                    break;
                case Roles.Ozis:
                    NotifyMePDB();
                    break;
                case Roles.Buhgalter:
                    NotifyMeBUH();
                    break;
                case Roles.Manager:
                    NotifyMeMANAGER();
                    break;
            }
/////////////////////////////////////////////// это нужно рефакторить
            sw.Stop();
            //MessageBox.Show("FillNotifications();" + (sw.ElapsedMilliseconds / 100.0).ToString());

            sw.Reset();
            sw.Start();

            if (!InitialReload)
            {
                ps.Restore();
            }
            InitialReload = false;
            sw.Stop();
            PaintDG();

            //MessageBox.Show("ps.Restore();" + (sw.ElapsedMilliseconds / 100.0).ToString());

        }





        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void заказчикиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Customers c = new Customers();
            c.ShowDialog();
        }



        private void dgSummon_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex == -1) return;
            //PreviousState ps = new PreviousState(dgSummon);
            this.ViewEditMenuItem_Click(sender, e);
            //ReloadData();
            //ps.Restore();

        }

        private void пользователиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Users u = new Users();
            u.ShowDialog();
        }

        private void наименованиеИзделияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WPName wp = new WPName(false,this.UVO, WPTYPE.WPNAMELIST,false);
            wp.ShowDialog();
        }

        private void упаковкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Packing p = new Packing();
            p.ShowDialog();
        }


        private void dgSummon_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (e.RowIndex != -1)
                {
                    dgSummon.Rows[e.RowIndex].Selected = true;
                    ContMenu.Show(MousePosition.X, MousePosition.Y);
                }
            }
        }


        private void newtoolStripButton(object sender, EventArgs e)
        {
            NewMenuItem_Click(sender, e);
        }

        private void viewedittoolStripButton_Click(object sender, EventArgs e)
        {
            ViewEditMenuItem_Click(sender, e);
        }

        private void FinishedtoolStripButton_Click(object sender, EventArgs e)
        {
            FinishedMenuItem_Click(sender, e);
        }

        public void ViewHistory()
        {
            if (dgSummon.SelectedRows.Count == 0)
            {
                MessageBox.Show("Извещение не выбрано!");
                return;
            }
            StatusHistory sh = new StatusHistory(dgSummon.SelectedRows[0].Cells["ids"].Value.ToString());
            sh.ShowDialog();
        }
        public void HistoryMenuItem_Click(object sender, EventArgs e)
        {

            ViewHistory();
        }
        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            ViewHistory();
        }
        private void HistorytoolStripButton_Click(object sender, EventArgs e)
        {
            if (dgSummon.SelectedRows.Count == 0)
            {
                MessageBox.Show("Извещение не выбрано!");
                return;
            }
            StatusHistory sh = new StatusHistory(dgSummon.SelectedRows[0].Cells["ids"].Value.ToString());
            sh.ShowDialog();
        }
        private void просмотрИсторииСтатусовToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewHistory();
        }

        private void PrinttoolStripButton_Click(object sender, EventArgs e)
        {
            PrintMenuItem_Click(sender, e);
        }

        private void NewMenuItem_Click(object sender, EventArgs e)
        {
            NewSummon ns = new NewSummon(UVO);
            ns.ShowDialog();
            ReloadData();

        }

        public void ViewEditMenuItem_Click(object sender, EventArgs e)
        {
            if (dgSummon.SelectedRows.Count == 0)
            {
                MessageBox.Show("Извещение не выбрано!");
                return;
            }
            DBSummon dbs = new DBSummon();
            SummonVO svo = dbs.GetSummonByIDS(dgSummon.SelectedRows[0].Cells["ids"].Value.ToString());
            PreviousState ps = new PreviousState(dgSummon,TStbs.Text);

            ShowSummon ss = new ShowSummon(UVO, svo);
            ss.ShowDialog();

            ReloadData();
        }

        private void FinishedMenuItem_Click(object sender, EventArgs e)
        {
            Finished f = new Finished();
            f.ShowDialog();

        }



        public void PrintMenuItem_Click(object sender, EventArgs e)
        {

            if (dgSummon.SelectedRows.Count == 0)
            {
                MessageBox.Show("Извещение не выбрано!");
                return;
            }
            DBSummon dbs = new DBSummon();
            SummonVO svo = dbs.GetSummonByIDS(dgSummon.SelectedRows[0].Cells["ids"].Value.ToString());
            SummonVOForReport svor = new SummonVOForReport(svo);
            List<SummonVOForReport> sl = new List<SummonVOForReport>();
            sl.Add(svor);
            ShowReport sr = new ShowReport(sl);
            sr.ShowDialog();


        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About a = new About();
            a.ShowDialog();
        }
      
        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //// Показываем наше окно (чтобы оно появилось в таскбаре)
            //this.Show();
            //// Разворачиваем окно
            //WindowState = FormWindowState.Normal;
            //// Прячем за собой иконку в трее
            //notifyIcon1.Visible = false;

            this.Show();
            this.WindowState = FormWindowState.Maximized;
            this.ShowInTaskbar = true;
            //notifyIcon1.Visible = false;

        }
        private void Main_Resize(object sender, EventArgs e)
        {
            //if (this.WindowState == FormWindowState.Minimized)
            //{
            //    notifyIcon1.Visible = true;
            //    //this.WindowState = FormWindowState.Minimized;

            //    this.ShowInTaskbar = false;
            //}

            if (FormWindowState.Minimized == this.WindowState)
            {
                notifyIcon1.Visible = true;
               // notifyIcon1.ShowBalloonTip(500);
                this.Hide();
            }

            else if (FormWindowState.Normal == this.WindowState)
            {
                notifyIcon1.Visible = false;
            }
        }
        StatusStripIndicator SSI;
        private void Main_Load(object sender, EventArgs e)
        {

            Auth au = new Auth();
            au.ShowDialog();
            if (au.DialogResult == DialogResult.Cancel)
            {
                this.Close();
            }
            else
            {
                this.UVO = au.UVO;
                DBPreferences dbp = new DBPreferences(int.Parse(UVO.id));
                this.PrivateNoteColor = dbp.NoteColor;
                this.RefreshTime = dbp.RefreshTime;
                timer1.Interval = this.RefreshTime;
                tslVersionLabel.Text = "v" + MainF.ProgramVersion;

                SSI = new StatusStripIndicator(statusStrip1, UVO.Role, tslVersionLabel);
                ReloadData();
                AllocateRoles();
                this.Text = "Менеджер извещений ("+this.UVO.Fio+" - "+this.UVO.ToString()+")";
                this.BringToFront();
                CheckVersion();
            }
            

        }

        
        private void PaintDG()
        {
            //PaintPrivateNote();
            string ntfy = "Вы стали ответственным за извещение(я) № ";
            switch (this.UVO.Role)
            {
                case Roles.Manager:
                    foreach (DataGridViewRow r in dgSummon.Rows)
                    {
                        string idst = r.Cells["idstatus"].Value.ToString();
                        bool vw = (bool)r.Cells["vw"].Value;
                        if ((idst == "1"))
                        {
                            r.DefaultCellStyle.BackColor = Color.LightGreen;
                            if ((!vw) && (idst == "11"))
                            {
                                r.DefaultCellStyle.BackColor = Color.Orange;
                                ntfy += r.Cells["ids"].Value.ToString()+", ";
                            }
                        }
                    }
                    if (ntfy.TrimEnd().LastIndexOf("№") != ntfy.Length - 2)
                    {
                        ntfy = ntfy.Remove(ntfy.LastIndexOf(","));
                        notifyIcon1.ShowBalloonTip(29000, "Новое извещение!", ntfy, ToolTipIcon.Warning);
                    }
                    break;
                case Roles.Prod:
                    foreach (DataGridViewRow r in dgSummon.Rows)
                    {
                        string idst = r.Cells["idstatus"].Value.ToString();
                        bool vw = (bool)r.Cells["vw"].Value;
                        if ((idst == "4") || (idst == "21"))
                        {
                            r.DefaultCellStyle.BackColor = Color.LightGreen;
                            if (!vw)
                            {
                                r.DefaultCellStyle.BackColor = Color.Orange;
                                ntfy += r.Cells["ids"].Value.ToString() + ", ";
                            }
                        }
                    }
                    if (ntfy.TrimEnd().LastIndexOf("№") != ntfy.Length - 2)
                    {
                        ntfy = ntfy.Remove(ntfy.LastIndexOf(","));
                        notifyIcon1.ShowBalloonTip(29000, "Новое извещение!",  ntfy, ToolTipIcon.Warning);
                    }
                    break;
                case Roles.Ozis:
                    foreach (DataGridViewRow r in dgSummon.Rows)
                    {
                        string idst = r.Cells["idstatus"].Value.ToString();
                        bool vw = (bool)r.Cells["vw"].Value;
                        if ((idst == "3"))
                        {
                            r.DefaultCellStyle.BackColor = Color.LightGreen;
                            if (!vw)
                            {
                                r.DefaultCellStyle.BackColor = Color.Orange;
                                ntfy += r.Cells["ids"].Value.ToString() + ", ";
                                //notifyIcon1.Icon = Icon.
                            }
                        }
                        if ((int)r.Cells["shild_ordered"].Value == 0)//а-ля paint_ozis
                        {
                            r.Cells["ids"].Style.BackColor = Color.Red;
                        }
                    }
                    if (ntfy.TrimEnd().LastIndexOf("№") != ntfy.Length - 2)
                    {
                        ntfy = ntfy.Remove(ntfy.LastIndexOf(","));
                        notifyIcon1.ShowBalloonTip(29000, "Новое извещение!",  ntfy, ToolTipIcon.Warning);
                    }
                    break;
                case Roles.Wsh:
                    foreach (DataGridViewRow r in dgSummon.Rows)
                    {
                        string idst = r.Cells["idstatus"].Value.ToString();
                        bool vw = (bool)r.Cells["vw"].Value;
                        if ((idst == "5") || (idst == "8") || (idst == "22"))
                        {
                            r.DefaultCellStyle.BackColor = Color.LightGreen;
                            if (!vw)
                            {
                                r.DefaultCellStyle.BackColor = Color.Orange;
                                ntfy += r.Cells["ids"].Value.ToString() + ", ";
                            }
                        }
                    }
                    if (ntfy.TrimEnd().LastIndexOf("№") != ntfy.Length - 2)
                    {
                        ntfy = ntfy.Remove(ntfy.LastIndexOf(","));
                        notifyIcon1.ShowBalloonTip(29000, "Новое извещение!", ntfy, ToolTipIcon.Warning);
                    }
                    break;
                case Roles.Ware:
                    foreach (DataGridViewRow r in dgSummon.Rows)
                    {
                        string idst = r.Cells["idstatus"].Value.ToString();
                        bool vw = (bool)r.Cells["vw"].Value;
                        if (idst == "9")
                        {
                            r.DefaultCellStyle.BackColor = Color.LightGreen;
                            if (!vw)
                            {
                                r.DefaultCellStyle.BackColor = Color.Orange;
                                ntfy += r.Cells["ids"].Value.ToString() + ", ";
                            }
                        }
                    }
                    if (ntfy.TrimEnd().LastIndexOf("№") != ntfy.Length - 2)
                    {
                        ntfy = ntfy.Remove(ntfy.LastIndexOf(","));
                        notifyIcon1.ShowBalloonTip(29000, "Новое извещение!", ntfy, ToolTipIcon.Warning);
                    }
                    break;
                case Roles.OTK:
                    foreach (DataGridViewRow r in dgSummon.Rows)
                    {
                        int paint = (int)r.Cells["paint_otk"].Value;
                        if (paint == 1)
                        {
                            r.Cells["ids"].Style.BackColor = Color.Red;

                            //r.DefaultCellStyle.BackColor = Color.Red;
                        }
                        string idst = r.Cells["idstatus"].Value.ToString();
                        string idsubst = r.Cells["idsubst"].Value.ToString();
                        bool vw = (bool)r.Cells["vw"].Value;
                        if ((idst == "7") || (idsubst == "16") || (idst == "19") || (idst == "20"))
                        {
                            r.DefaultCellStyle.BackColor = Color.LightGreen;
                            if (!vw)
                            {
                                r.DefaultCellStyle.BackColor = Color.Orange;
                                ntfy += r.Cells["ids"].Value.ToString() + ", ";
                            }
                            //if (idst == "16")
                            //{
                            //    r.DefaultCellStyle.BackColor = Color.Orchid;
                            //}
                        }
                    }
                    if (ntfy.TrimEnd().LastIndexOf("№") != ntfy.Length - 2)
                    {
                        ntfy = ntfy.Remove(ntfy.LastIndexOf(","));
                        notifyIcon1.ShowBalloonTip(29000, "Новое извещение!",  ntfy, ToolTipIcon.Warning);
                    }
                    break;
                case Roles.Logist:
                    foreach (DataGridViewRow r in dgSummon.Rows)
                    {
                        string idst = r.Cells["idstatus"].Value.ToString();
                        bool vw = (bool)r.Cells["vw"].Value;
                        if (idst == "12")
                        {
                            r.DefaultCellStyle.BackColor = Color.LightGreen;
                            if (!vw)
                            {
                                r.DefaultCellStyle.BackColor = Color.Orange;
                                ntfy += r.Cells["ids"].Value.ToString() + ", ";
                            }
                        }
                    }
                    if (ntfy.TrimEnd().LastIndexOf("№") != ntfy.Length-2)
                    {
                        ntfy = ntfy.Remove(ntfy.LastIndexOf(","));
                        notifyIcon1.ShowBalloonTip(29000, "Новое извещение!",  ntfy, ToolTipIcon.Warning);
                    }
                    break;
                case Roles.Montage:
                    foreach (DataGridViewRow r in dgSummon.Rows)
                    {
                        string idst = r.Cells["idstatus"].Value.ToString();
                        string idsubst = r.Cells["idsubst"].Value.ToString();
                        bool vw = (bool)r.Cells["vw"].Value;
                        if ((idsubst == "15") || (idsubst == "18"))
                        {
                            r.DefaultCellStyle.BackColor = Color.LightGreen;
                            if (!vw)
                            {
                                r.DefaultCellStyle.BackColor = Color.Orange;
                                ntfy += r.Cells["ids"].Value.ToString() + ", ";
                            }
                        }
                    }
                    if (ntfy.TrimEnd().LastIndexOf("№") != ntfy.Length-2)
                    {
                        ntfy = ntfy.Remove(ntfy.LastIndexOf(","));
                        notifyIcon1.ShowBalloonTip(29000, "Новое извещение!",  ntfy, ToolTipIcon.Warning);
                    }
                    break;
                case Roles.Constructor:
                    foreach (DataGridViewRow r in dgSummon.Rows)
                    {
                        int paint = (int)r.Cells["paint_constr"].Value;
                        if (paint == 1)
                        {
                            r.Cells["ids"].Style.BackColor = Color.Red;

                            //r.DefaultCellStyle.BackColor = Color.Red;
                        }
                    }
                    break;
                case Roles.Inzhener:
                    foreach (DataGridViewRow r in dgSummon.Rows)
                    {
                        int paint = (int)r.Cells["paint_inzh"].Value;
                        if (paint == 1)
                        {
                            r.Cells["ids"].Style.BackColor = Color.Red;

                            //r.DefaultCellStyle.BackColor = Color.Red;
                        }
                    }
                    break;
                case Roles.SimpleInzhener:
                    foreach (DataGridViewRow r in dgSummon.Rows)
                    {
                        int paint = (int)r.Cells["paint_inzh"].Value;
                        if (paint == 1)
                        {
                            r.Cells["ids"].Style.BackColor = Color.Red;

                            //r.DefaultCellStyle.BackColor = Color.Red;
                        }
                    }
                    break;
                case Roles.OTD:
                    foreach (DataGridViewRow r in dgSummon.Rows)
                    {
                        int paint = (int)r.Cells["paint_OTD"].Value;
                        if (paint == 1)
                        {
                            r.Cells["ids"].Style.BackColor = Color.Red;

                            //r.DefaultCellStyle.BackColor = Color.Red;
                        }
                    }
                    break;
                case Roles.Shemotehnik:
                    foreach (DataGridViewRow r in dgSummon.Rows)
                    {
                        int paint = (int)r.Cells["paint_shemotehnik"].Value;
                        if (paint == 1)
                        {
                            r.Cells["ids"].Style.BackColor = Color.Red;

                            //r.DefaultCellStyle.BackColor = Color.Red;
                        }
                    }
                    break;
                case Roles.Tehnolog:
                    
                    break;
            }
            PaintNotesAndPassDateChanged();
            PaintSISPandContractType();
        }

        private void PaintSISPandContractType()
        {
            foreach (DataGridViewRow r in dgSummon.Rows)
            {
                if (r.Cells["sisp"].Value.ToString() == "Да")
                {
                    r.Cells["sisp"].Style.BackColor = Color.Plum;
                }
                if (r.Cells["contract_type"].Value.ToString() != "Стандартный")
                {
                    r.Cells["contract_type"].Style.BackColor = Color.Plum;
                }
            }
        }

        private void PaintNotesAndPassDateChanged()
        {
            foreach (DataGridViewRow r in dgSummon.Rows)
            {

                DateTime dview;
                DateTime pdc;
                DateTime ncre;
                DateTime.TryParse(r.Cells["dview"].Value.ToString(), out dview);
                DateTime.TryParse(r.Cells["pdc"].Value.ToString(), out pdc);
                DateTime.TryParse(r.Cells["ncre"].Value.ToString(), out ncre);
                if (dview < pdc)
                {
                    r.Cells["passd"].Style.BackColor = Color.Orange;
                }
                if (dview < ncre)
                {
                    r.Cells["note"].Style.BackColor = Color.Orange;
                }



            }


        }

        //private void PaintPrivateNote()
        //{
        //    DBPrivateNote dbpn = new DBPrivateNote();
        //    foreach (DataGridViewRow r in dgSummon.Rows)
        //    {
        //        if (dbpn.ExistsPN(UVO.id,r.Cells["id"].Value.ToString()))
        //        {
        //            r.DefaultCellStyle.BackColor = Color.FromArgb(this.PrivateNoteColor);
        //        }

        //    }
        //}



        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            /*{
                if (e.CloseReason != CloseReason.TaskManagerClosing &&
                   e.CloseReason != CloseReason.WindowsShutDown)
                    e.Cancel = true;
                this.Hide();
            }*/
        }

        private void просмотрИРедактированиеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewEditMenuItem_Click(sender, e);
        }

        private void печатьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            PrintMenuItem_Click(sender, e);
        }

      
        private void SearchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fSearchConditions fs = new fSearchConditions(this);
            fs.ShowDialog();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            SearchToolStripMenuItem_Click(sender, e);
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            ReloadData();
            //FillNotifications();

           
        }

        private void RefreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReloadData();
        }
        bool lastSortAscending = false;
        private void InitialSort()
        {
            dgSummon.Sort(dgSummon.Columns["ids_srt"], ListSortDirection.Ascending);
            dgSummon.Columns["ids"].HeaderCell.SortGlyphDirection = System.Windows.Forms.SortOrder.Ascending;
            lastSortAscending = true;
            //PaintDG();
        }
        private void dgSummon_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex == 1)
            {
                lastSortAscending = !lastSortAscending;
                if (lastSortAscending)
                {
                    dgSummon.Sort(dgSummon.Columns["ids_srt"], ListSortDirection.Ascending);
                    dgSummon.Columns["ids"].HeaderCell.SortGlyphDirection = System.Windows.Forms.SortOrder.Ascending;
                }
                else
                {
                    dgSummon.Sort(dgSummon.Columns["ids_srt"], ListSortDirection.Descending);
                    dgSummon.Columns["ids"].HeaderCell.SortGlyphDirection = System.Windows.Forms.SortOrder.Descending;
                }
            }
            else
            {
                
            }
            dgSummon.DefaultCellStyle = new DataGridViewCellStyle();
            PaintDG();
            TStbs_TextChanged(sender, e);
        }

        private void dgSummon_SortCompare(object sender, DataGridViewSortCompareEventArgs e)
        {

        }

        private void CustDeptsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void TimeInDeptToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fTimeInDeptPieChartStat fpc = new fTimeInDeptPieChartStat();
            fpc.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ReloadData();


        }

        private void FillNotifications()
        {
            DBNotification dbn = new DBNotification();
            dbn.FillNotifications();
        }
        private void NotifyMeMANAGER()
        {
            DBNotification dbn = new DBNotification();

            List<Notification> ln = dbn.GetNotByTYPE("5");
            if (ln.Count == 0) return;

            string message = "Счёт оплачен для извещения(ий): ";
            foreach (Notification n in ln)
            {
                message += n.IDS + "; ";
                if (n.CREATED.AddDays(7) < DateTime.Now)
                {
                    dbn.Delete(n);
                }
            }
            if (message == "Счёт оплачен для извещения(ий): ") return;
            message = message.Remove(message.Length - 2);
            message += ".";
            notifyIcon1.Visible = true;
            notifyIcon1.ShowBalloonTip(25000, "Внимание!", message, ToolTipIcon.Warning);

            notifyIcon1.Tag = ln[0].IDSUMMON.ToString();
            
        }

        void notifyIcon1_BalloonTipClicked(object sender, EventArgs e)
        {
            foreach (DataGridViewRow r in dgSummon.Rows)
            {
                if (r.Cells[0].Value.ToString() == notifyIcon1.Tag.ToString())
                {
                    r.Selected = true;
                }
            }
            viewedittoolStripButton_Click(sender, e);
        }
        private void NotifyMeBUH()
        {
            DBNotification dbn = new DBNotification();

            List<Notification> ln = dbn.GetNotByTYPE("4");
            if (ln.Count == 0) return;

            string message = "Необходимо сделать документы по извещению(ям): ";
            foreach (Notification n in ln)
            {
                message += n.IDS + "; ";
            }
            if (message == "Необходимо сделать документы по извещению(ям): ") return;
            message = message.Remove(message.Length - 2);
            message += ".";
            notifyIcon1.Visible = true;
            notifyIcon1.ShowBalloonTip(25000, "Внимание!", message, ToolTipIcon.Warning);

            notifyIcon1.Tag = ln[0].IDSUMMON.ToString();
        }
        private void NotifyMePDB()
        {
            DBNotification dbn = new DBNotification();

            List<Notification> ln = dbn.GetNotByTYPE("3");
            if (ln.Count == 0) return;

            string message = "Шильды готовы для заказа по извещению(ям): ";
            foreach (Notification n in ln)
            {
                    message += n.IDS + "; ";
            }
            if (message == "Шильды готовы для заказа по извещению(ям): ") return;
            message = message.Remove(message.Length - 2);
            message += ".";
            notifyIcon1.Visible = true;
            notifyIcon1.ShowBalloonTip(25000, "Внимание!", message, ToolTipIcon.Warning);

            notifyIcon1.Tag = ln[0].IDSUMMON.ToString();
        }
        private void NotifyMeOTK()
        {
            DBNotification dbn = new DBNotification();

            List<Notification> ln = dbn.GetNotByTYPE("1");
            if (ln.Count == 0) return;

            string message = "Просьба присвоить серийные номера в извещении(ях): ";
            foreach (Notification n in ln)
            {
                    message += n.IDS + "; ";
            }
            if (message == "Просьба присвоить серийные номера в извещении(ях): ") return;

            message = message.Remove(message.Length - 2);
            message += ".";
            notifyIcon1.Visible = true;
            notifyIcon1.ShowBalloonTip(25000, "Внимание!", message, ToolTipIcon.Warning);
            notifyIcon1.Tag = ln[0].IDSUMMON.ToString();
        }
        private void NotifyMeCONSTR()
        {
            DBNotification dbn = new DBNotification();

            List<Notification> ln = dbn.GetNotByTYPE("2");
            if (ln.Count == 0) return;

            string message = "Просьба заполнить ответственные поля в извещении(ях): ";
            foreach (Notification n in ln)
            {
                    message += n.IDS + "; ";
            }
            if (message == "Просьба заполнить ответственные поля в извещении(ях): ") return;
            message = message.Remove(message.Length - 2);
            message += ".";
            notifyIcon1.Visible = true;
            notifyIcon1.ShowBalloonTip(25000, "Внимание!", message, ToolTipIcon.Warning);
            notifyIcon1.Tag = ln[0].IDSUMMON.ToString();
        }
        private void CheckVersion()
        {
            DBVersion dbv = new DBVersion();
            int LastVersion = dbv.GetVersionNumber();
            if (LastVersion > VersionNumber)
            {
                //MessageBox.Show("Появилась новая версия программы!");
                this.Text = "Менеджер извещений (" + UVO.Role.ToString() + " - " + UVO.Fio + ") (эта версия программы устарела)";
            }
            //if (LastVersion < VersionNumber)
            //{
             //   dbv.UpdateVersion(LastVersion);
            //}
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            CheckVersion();
        }


        private void настройкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Preferences p = new Preferences(int.Parse(this.UVO.id),this);
            p.ShowDialog();
            

        }
        public void SetRefreshTime(int rtime)
        {
            this.RefreshTime = rtime;
            timer1.Interval = rtime;
        }
        public void SetNoteColor(int color)
        {
            this.PrivateNoteColor = color;
            //ReloadData();
        }

        private void сменитьПользователяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Main_Load(sender, e);

        }

        private void MySummonsTSB_Click(object sender, EventArgs e)
        {
            
            ReloadData();
        }

        private void TStbs_TextChanged(object sender, EventArgs e)
        {
            dgSummon.CurrentCell = null;
            foreach (DataGridViewRow r in dgSummon.Rows)
            {
                if (TStbs.Text == "")
                {
                    r.Visible = true;
                    continue;
                }
                if (!r.Cells["wname"].Value.ToString().ToLower().Contains(TStbs.Text.ToLower()))
                {
                    r.Visible = false;
                }
                else
                {
                    r.Visible = true;
                }

            }
        }


        private void dgSummon_SelectionChanged(object sender, EventArgs e)
        {
            /*if ((UVO.Role != Roles.Ozis) && (UVO.Role != Roles.Buhgalter) && (UVO.Role != Roles.Manager))
            {
                return;
            }*/
            if (SSI == null) return;
            if (dgSummon.SelectedRows.Count == 0)
            {
                SSI.Visible = false;
                return;
            }
            else
            {
                SSI.Visible = true;
                SSI.Paint(dgSummon.SelectedRows[0].Cells["id"].Value.ToString());
            }
        }


        //private void PaintStatusStrip()
        //{
        //    if (dgSummon.SelectedRows.Count == 0)
        //    {
        //        SetStatusBarForPDBNOTVisible();
        //        return;
        //    }
        //    switch (UVO.Role)
        //    {
        //        case Roles.Ozis:
        //            SetStatusBarForPDBVisible();
        //            pm_s = dbpm_s.Get(dgSummon.SelectedRows[0].Cells["id"].Value.ToString());
        //            PaintStatusForPDB();
        //            break;
        //        case Roles.Buhgalter:
        //            if (tslBillPayedColor == null)
        //            {
        //                return;
        //            }
        //            SummonVO s = SummonVO.SummonVOByID(dgSummon.SelectedRows[0].Cells["id"].Value.ToString());
        //            tslBillPayedColor.BackColor = (s.BILLPAYED) ? System.Drawing.Color.Lime : System.Drawing.Color.Red;
        //            tslDocsReadyColor.BackColor = (s.DOCSREADY) ? System.Drawing.Color.Lime : System.Drawing.Color.Red;
        //            //ToolStripItem[] FindItem = statusStrip1.Items.Find("tslBillPayedColor", true);
        //            //FindItem[0].BackColor = (s.BILLPAYED) ? System.Drawing.Color.Lime : System.Drawing.Color.Red;
        //            //ToolStripItem[] FindItem1 = statusStrip1.Items.Find("tslDocsReadyColor", true);
        //            //FindItem[0].BackColor = (s.DOCSREADY) ? System.Drawing.Color.Lime : System.Drawing.Color.Red;
        //            break;
        //        case Roles.Manager:
        //            if (tslBillPayedColor == null)
        //            {
        //                return;
        //            }
        //            s = SummonVO.SummonVOByID(dgSummon.SelectedRows[0].Cells["id"].Value.ToString());
        //            tslBillPayedColor.BackColor = (s.BILLPAYED) ? System.Drawing.Color.Lime : System.Drawing.Color.Red;
        //            break;
        //    }
        //}
        //private void InitStatusBar()
        //{
        //    switch (UVO.Role)
        //    {
        //        case Roles.Buhgalter:
        //            tslBillPayedColor = new ToolStripStatusLabel();
        //            tslBillPayedColor.Text = "   ";
        //            statusStrip1.Items.Insert(statusStrip1.Items.IndexOf(tslVersionLabel), tslBillPayedColor);
        //            ToolStripStatusLabel tslSpace = new ToolStripStatusLabel();
        //            tslSpace.Text = " ";
        //            statusStrip1.Items.Insert(statusStrip1.Items.IndexOf(tslVersionLabel), tslSpace);
        //            ToolStripStatusLabel tslBillPayedText = new ToolStripStatusLabel();
        //            tslBillPayedText.Text = "Счёт оплачен;";
        //            statusStrip1.Items.Insert(statusStrip1.Items.IndexOf(tslVersionLabel), tslBillPayedText);

        //            tslDocsReadyColor = new ToolStripStatusLabel();
        //            tslDocsReadyColor.Text = "   ";
        //            statusStrip1.Items.Insert(statusStrip1.Items.IndexOf(tslVersionLabel), tslDocsReadyColor);
        //            //ToolStripStatusLabel tslSpace = new ToolStripStatusLabel();
        //            //tslSpace.Text = " ";
        //            statusStrip1.Items.Insert(statusStrip1.Items.IndexOf(tslVersionLabel), tslSpace);
        //            ToolStripStatusLabel tslDocsReadyText = new ToolStripStatusLabel();
        //            tslDocsReadyText.Text = "Документы готовы;";
        //            statusStrip1.Items.Insert(statusStrip1.Items.IndexOf(tslVersionLabel), tslDocsReadyText);

        //            if (dgSummon.SelectedRows.Count != 0)
        //            {
        //                SummonVO s = SummonVO.SummonVOByID(dgSummon.SelectedRows[0].Cells["id"].Value.ToString());
        //                tslBillPayedColor.BackColor = (s.BILLPAYED) ? System.Drawing.Color.Lime : System.Drawing.Color.Red;
        //                tslDocsReadyColor.BackColor = (s.DOCSREADY) ? System.Drawing.Color.Lime : System.Drawing.Color.Red;
        //                tslBillPayedColor.Visible = true;
        //                tslBillPayedText.Visible = true;
        //                tslDocsReadyColor.Visible = true;
        //                tslDocsReadyText.Visible = true;
        //                tslSpace.Visible = true;
        //            }
        //            else
        //            {
        //                tslSpace.Visible = false;
        //                tslBillPayedColor.Visible = false;
        //                tslBillPayedText.Visible = false;
        //                tslDocsReadyColor.Visible = false;
        //                tslDocsReadyText.Visible = false;
        //            }
        //            break;
        //        case Roles.Manager:
        //            tslBillPayedColor = new ToolStripStatusLabel();
        //            tslBillPayedColor.Text = "   ";
        //            statusStrip1.Items.Insert(statusStrip1.Items.IndexOf(tslVersionLabel), tslBillPayedColor);
        //            tslSpace = new ToolStripStatusLabel();
        //            tslSpace.Text = " ";
        //            statusStrip1.Items.Insert(statusStrip1.Items.IndexOf(tslVersionLabel), tslSpace);
        //            tslBillPayedText = new ToolStripStatusLabel();
        //            tslBillPayedText.Text = "Счёт оплачен;";
        //            statusStrip1.Items.Insert(statusStrip1.Items.IndexOf(tslVersionLabel), tslBillPayedText);
        //            break;
        //    }

        //}
        //private void PaintStatusForPDB()
        //{
            

        //}
       

        private void историяВерсийToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VersionHistory vh = new VersionHistory();
            vh.Show();
        }

        private void открытьТТToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgSummon.SelectedRows.Count == 0) return;

            if ((dgSummon.SelectedRows[0].Cells["techreq"].Tag != null) && (dgSummon.SelectedRows[0].Cells["techreq"].Tag.ToString() != string.Empty))
            {
                if (dgSummon.SelectedRows[0].Cells["techreq"].Tag.ToString() != "")
                {
                    Process.Start(@"explorer.exe", @"/select, " + dgSummon.SelectedRows[0].Cells["techreq"].Tag.ToString());
                }
            }
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            //ReloadData();

        }

        private void tsbWorkPart_Click(object sender, EventArgs e)
        {
            WPName wp = new WPName(false, this.UVO, WPTYPE.WPNAMELIST,false);
            wp.ShowDialog();
        }

        private void bkwReloadData_DoWork(object sender, DoWorkEventArgs e)
        {
        }

        private void tsbRemark_Click(object sender, EventArgs e)
        {
            Remarks r = new Remarks(UVO);
            r.ShowDialog();
        }

        private void dgSummon_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex == 3 && (int)dgSummon.Rows[e.RowIndex].Cells["remark_exist_paint"].Value == 1)
            {
                if ((e.PaintParts & DataGridViewPaintParts.Background) != DataGridViewPaintParts.None)
                {
                    e.Graphics.DrawImage(Resources.exclamation, e.CellBounds);
                }
                if (!e.Handled)
                {
                    e.Handled = true;
                    e.PaintContent(e.CellBounds);
                }
            }
        }

       


       


    }
}
