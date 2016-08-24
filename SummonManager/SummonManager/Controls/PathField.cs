using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using SummonManager.Properties;
using System.IO;
using SummonManager.CLASSES.IRole_namespace;
using SummonManager.CLASSES;

namespace SummonManager.Controls
{
    public partial class PathField : UserControl
    {
        public string ACCESSMODE;
        public PathField()
        {
            InitializeComponent();
            //this.PATH = "<нет>";
            //tbPath.Text = "<нет>";
            PaintRed();
        }

       
        public void PaintRed()
        {
            if ((chRequired.Checked) && (tbPath.Text == "<нет>")
                && (this.CurrentRole == (Roles)this.Tag)
                || ((this.CurrentRole == Roles.SimpleInzhener) && ((Roles)this.Tag == Roles.Inzhener)))
            {
                tbPath.BackColor = Color.Tomato;
            }
            else
            {
                tbPath.BackColor = SystemColors.ControlLight;
            }
        }
        Roles ResposibleRole,CurrentRole;
        string tmpPATH = "<нет>";
        string PATH;
        public string FullPath
        {
            get { return this.PATH; }
            set 
            {
                if ((value == null) || (value.ToString() == ""))
                {
                    this.PATH = "<нет>";
                    tbPath.Text = "<нет>";
                    //bRemark.Enabled = false;
                    //bRemark.BackgroundImage = Resources.exclamation_disable;

                }
                else
                {
                    this.PATH = value;
                    tbPath.Text = this.FileName;
                    //bRemark.Enabled = true;
                    //bRemark.BackgroundImage = Resources.exclamation;

                }
                PaintRed();
            }
        }
        public string FileName
        {
            get 
            {
                if ((this.PATH == "<нет>") || (this.PATH == null))
                {
                    return "<нет>";
                }
                else
                {
                    return this.PATH.Substring(this.PATH.LastIndexOf("\\") + 1);
                }
            }
        }
        bool EnabledPF = true;
        public new bool Enabled
        {
            get { return EnabledPF; }
            set
            {
                if (value)
                {
                    this.EnabledPF = value;
                    bPath.Enabled = true;
                    bPathDel.Enabled = true;
                    bPathDel.BackgroundImage = Resources.delete_ok;
                    //chRequired.Enabled = true;
                }
                else
                {
                    this.EnabledPF = value;
                    bPath.Enabled = false;
                    bPathDel.Enabled = false;
                    bPathDel.BackgroundImage = Resources.delete_disable;

                    if ((ACCESSMODE != "VIEWONLY") && (CurrentRole == Roles.Inzhener))
                    {
                        bPathDel.Enabled = true;
                        bPathDel.BackgroundImage = Resources.delete_ok;
                    }
                    //chRequired.Enabled = false;
                }
            }
        }
        bool REQ;
        public bool Required
        {
            get { return REQ; }
            set
            {
                this.REQ = value;
                chRequired.Checked = this.REQ;
                if ((ResposibleRole == CurrentRole) || (CurrentRole == Roles.Admin) || ((CurrentRole == Roles.SimpleInzhener) && (ResposibleRole == Roles.Inzhener)))
                {
                    this.Enabled = value;
                }
                if (!value)
                {
                    tmpPATH = this.FullPath;
                    this.FullPath = "<нет>";
                }
                else
                {
                    if (tmpPATH != "<нет>")
                    this.FullPath = tmpPATH;
                }
                PaintRed();
            }
        }
        bool DELVISIBLE;
        public bool bDelVisible
        {
            get { return DELVISIBLE; }
            set
            {
                DELVISIBLE = value;
                bPathDel.Visible = value;
            }
        }
        bool BPATHVISIBLE;
        public bool bPathVisible
        {
            get { return BPATHVISIBLE; }
            set
            {
                BPATHVISIBLE = value;
                bPath.Visible = value;
            }
        }
        public bool RequiredVisible
        {
            set
            {
                if (value)
                {
                    chRequired.Visible = true;
                    panel1.Visible = true;
                }
                else
                {
                    chRequired.Visible = false;
                    panel1.Visible = false;
                }
            }
        }
        public bool RequiredEnabled
        {
            set
            {
                chRequired.Enabled = value;
            }
        }
        

        ToolTip tt;
        IRole UVO;
        string DOCUMENTNAME;
        SummonVO SVO;
        IProduct PRODUCT;
        public void Init(string path,bool req, bool enbl, bool reqvis, bool reqenbl, Roles resprole, string access_mode,IRole UVO_,string docname,SummonVO SVO_,IProduct product)
        {
            //this.PATH = path;
            //tbPath.Tag = path;
            this.UVO = UVO_;
            this.SVO = SVO_;
            this.PRODUCT = product;
            this.DOCUMENTNAME = docname;
            this.ACCESSMODE = access_mode;
            this.ResposibleRole = resprole;
            this.Tag = ResposibleRole;
            this.CurrentRole = UVO_.Role;
            this.FullPath = path;
            this.Required = req;
            this.RequiredVisible = reqvis;
            this.chRequired.Enabled = reqenbl;
            this.Enabled = enbl;
            tt = new ToolTip();
            tt.SetToolTip(this.tbPath, this.FullPath);
            tt = new ToolTip();
            tt.SetToolTip(this.bRemark, "Добавить замечание");

            //если путь пустой - то выключить замечание нужно в Init
            //эта фича не нужна оказывается...(
            //if (FullPath == "<нет>")
            //{
            //    bRemark.Enabled = false;
            //    bRemark.BackgroundImage = Resources.exclamation_disable;
            //}
            //else
            //{
            //    SetRemarkIcons();
                
            //}
            SetRemarkIcons();
            SetYellow();
            if ((this.ACCESSMODE == "NEW") || (this.ACCESSMODE == "NEWCLONE"))
            {
                bRemark.Enabled = false;
            }


            //this.tbPath.
            //tbPath.Text = this.FileName;
            //SetIcons();
        }
        private void SetYellow()
        {
            if (this.FullPath == "<нет>")
            {
                panel1.BackColor = this.BackColor;
                return;
            }
            FileInfo fi = new FileInfo(this.FullPath);

            if (!fi.Exists)
            {
                //tbPath.BackColor = Color.LightYellow;
                panel1.BackColor = Color.Yellow;
            }
            else
            {
                panel1.BackColor = this.BackColor;

            }
        }
        string IDREMARK;
        private void SetRemarkIcons()
        {
            if (PRODUCT != null) // этот контрол для Продукта
            {
                DBRemarkWP dbr = new DBRemarkWP(UVO);
                IDREMARK = dbr.RemarkExists(PRODUCT.GetID().ToString(), DOCUMENTNAME);
                if (IDREMARK != "")
                {
                    bRemark.Enabled = true;
                    bRemark.BackgroundImage = Resources.exclamation;
                    bRemark.BackgroundImage.Tag = "exclamation";
                    tt = new ToolTip();
                    tt.SetToolTip(this.bRemark, "Отработать замечание");
                }
                else
                {
                    bRemark.Enabled = true;
                    bRemark.BackgroundImage = Resources.remark_reply;
                    bRemark.BackgroundImage.Tag = "reply";
                    tt = new ToolTip();
                    tt.SetToolTip(this.bRemark, "Добавить замечание");
                }

            }
            else  // а этот контрол для извещения. Объекты замечаний к продукту и извещению разные!
            {
                DBRemarkSUMMON dbr = new DBRemarkSUMMON();
                IDREMARK = dbr.RemarkExists(SVO.ID, DOCUMENTNAME);
                if (IDREMARK != "")
                {
                    bRemark.Enabled = true;
                    bRemark.BackgroundImage = Resources.exclamation;
                    bRemark.BackgroundImage.Tag = "exclamation";
                    tt = new ToolTip();
                    tt.SetToolTip(this.bRemark, "Отработать замечание");

                }
                else
                {
                    bRemark.Enabled = true;
                    bRemark.BackgroundImage = Resources.remark_reply;
                    bRemark.BackgroundImage.Tag = "reply";
                    tt = new ToolTip();
                    tt.SetToolTip(this.bRemark, "Добавить замечание");
                }
            }
        }

        public bool IsPath = false;
        public bool ISPATH
        {
            get { return IsPath; }
            set { IsPath = value; }
        }
        private void bPath_Click(object sender, EventArgs e)
        {
            if (IsPath)
            {
                FolderBrowserDialog dialog = new FolderBrowserDialog();
                dialog.Description = "Выберите директорию с составом металла";
                dialog.SelectedPath = @"X:\Fileserver\Конструкторский отдел\ЗАКАЗ МЕТАЛЛА";
                //dialog.SelectedPath = @"G:\torrent\харламов\ХАРЛАМОВ Листья";
                SendKeys.Send("{TAB}{TAB}{DOWN}{DOWN}{UP}{UP}");
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    DirectoryInfo di = new DirectoryInfo(dialog.SelectedPath);
                    string str = di.Name;
                    //tbMETAL.Text = di.Name; ;
                    //tbMETAL.Text = dialog.SelectedPath.Substring(dialog.SelectedPath.LastIndexOf(@"\") + 1); ;
                    //bMETALOpen.Tag = dialog.SelectedPath;
                    //SetIcons();
                    this.FullPath = dialog.SelectedPath;
                }
            }
            else
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "All files (*.*)|*.*";
                //dialog.InitialDirectory = @"\\10.177.150.135\server\поездки\карта";
                dialog.InitialDirectory = @"c:\";
                dialog.Title = "Выберите файл";
                dialog.Multiselect = false;
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    this.FullPath = dialog.FileName;
                    tbPath.Text = this.FileName;
                    //SetIcons();
                }
            }

        }
        //private void SetIcons()
        //{
        //    if (tbPath.Tag.ToString() == "")
        //    {
        //        tbPath.Text = "<нет>";
        //        this.FullPath = "<нет>";
        //    }
        //    else
        //    {
        //        //this.PATH = 
        //        tbPath.Text = this.FileName;// 

        //    }
        //}
        
        private void bPathDel_Click(object sender, EventArgs e)
        {
            this.FullPath = "<нет>";
            //tbPath.Tag = "";
            //tbPath.Text = "";
            //SetIcons();
        }

        private void textBox1_MouseLeave(object sender, EventArgs e)
        {
            tbPath.ForeColor = Color.Black;
        }

      

        private void tbPath_MouseEnter(object sender, EventArgs e)
        {
            tbPath.ForeColor = Color.Blue;
            
        }

        private void tbPath_MouseLeave(object sender, EventArgs e)
        {
            tbPath.ForeColor = Color.Black;
        }

        private void chRequired_CheckedChanged(object sender, EventArgs e)
        {
            this.Required = chRequired.Checked;
        }

        private void bRemark_Click(object sender, EventArgs e)
        {
            contextMenuStrip2.Tag = null;
            if (bRemark.BackgroundImage.Tag.ToString() == "reply")//если надо добавить замечание
            {


                if (PRODUCT != null)//если замечние по продукту
                {
                    if (PRODUCT.GetProductType() != WPTYPE.WPNAMELIST)
                    {
                        MessageBox.Show("Замечания для жгутов и кабелей ещё не реализовано. Замечания можно добавлять к полям-путям сущности \"Извещение\" и сущности \"Изделие\"");
                        return;
                    }
                    WP_RVO RVO = new WP_RVO();
                    RVO.DOCUMENTNAME = this.DOCUMENTNAME;
                    RVO.IDWP = PRODUCT.GetID().ToString();
                    NewREMARKWP nrwp = new NewREMARKWP(RVO, null, this.UVO);
                    nrwp.ShowDialog();
                    SetRemarkIcons();
                }
                else //если замечание по извещению
                {
                    SummonRVO RVOS = new SummonRVO();
                    RVOS.DOCUMENTNAME = this.DOCUMENTNAME;
                    RVOS.IDSUMMON = SVO.ID;
                    NewREMARKWP nrwp = new NewREMARKWP(null, RVOS, this.UVO);
                    nrwp.ShowDialog();
                    SetRemarkIcons();
                }
            }
            else   //если надо отработать замечание
            {
                if (PRODUCT != null) //если надо отработать замечание по продукту
                {
                    DBRemarkWP dbrwp = new DBRemarkWP(UVO);
                    DataTable t = dbrwp.GetRemarksByIDWPDOC(this.DOCUMENTNAME, PRODUCT.GetID().ToString());
                    if (t.Rows.Count == 0)
                    {
                        SetRemarkIcons();
                        return;
                    }
                    else //так как замечание уже есть, то надо дать выбор добавлять ещё одно замечние или отрабатывать существующее
                    {
                        int x = 0;
                        int y = bRemark.Height;
                        contextMenuStrip2.Tag = t;
                        contextMenuStrip2.Show(bRemark, x, y);
                    }
                }
                else  //если надо отработать замечание по извещению
                {
                    DBRemarkSUMMON dbrs = new DBRemarkSUMMON();
                    DataTable t = dbrs.GetRemarksByIDSDOC(this.DOCUMENTNAME, SVO.ID);
                    if (t.Rows.Count == 0)
                    {
                        SetRemarkIcons();
                        return;
                    }
                    else     //так как замечание уже есть, то надо дать выбор добавлять ещё одно замечние или отрабатывать существующее
                    {
                        int x = 0;
                        int y = bRemark.Height;
                        contextMenuStrip2.Tag = t;
                        contextMenuStrip2.Show(bRemark, x, y);
                    }
                }
            }
        }

        private void copyToClipboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(this.FullPath);
        }

       

        private void tbPath_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (this.FullPath != "<нет>")
                {
                    //Process.Start(@"explorer.exe", this.FullPath);
                    Process.Start(@"explorer.exe", @"/select, " + this.FullPath);
                }
            }
        }
        private void tbPath_Click(object sender, EventArgs e)
        {
            
        }

        private void AddOneMoreRemarkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (PRODUCT != null)
            {
                WP_RVO RVO = new WP_RVO();
                RVO.DOCUMENTNAME = this.DOCUMENTNAME;
                RVO.IDWP = PRODUCT.GetID().ToString();
                NewREMARKWP nrwp = new NewREMARKWP(RVO, null, this.UVO);
                nrwp.ShowDialog();
            }
            else
            {
                SummonRVO RVOS = new SummonRVO();
                RVOS.DOCUMENTNAME = this.DOCUMENTNAME;
                RVOS.IDSUMMON = SVO.ID;
                NewREMARKWP nrwp = new NewREMARKWP(null, RVOS, this.UVO);
                nrwp.ShowDialog();
            }
            SetRemarkIcons();

        }

        private void WorkExistingRemarkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string RMType = "";
            string id = "";
            if (PRODUCT != null)
            {
                RMType = "WP";
                id = PRODUCT.GetID().ToString();
            }
            else
            {
                RMType = "SUMMON";
                id = SVO.ID;
            }
            DataTable t = (DataTable)contextMenuStrip2.Tag;
            if (t.Rows.Count > 1)
            {
                ChooseRemarkToWork crtw = new ChooseRemarkToWork(this.DOCUMENTNAME, UVO, RMType, id);
                crtw.ShowDialog();
            }
            else
            {
                if (RMType == "WP")
                {
                    if (!UVO.IsMyWPRemark(this.DOCUMENTNAME))
                    {
                        MessageBox.Show("Нельзя отработать замечание по документу, за который вы не ответственны!");
                        return;
                    }
                }
                else
                {
                    if (!UVO.IsMySmmRemark(this.DOCUMENTNAME))
                    {
                        MessageBox.Show("Нельзя отработать замечание по документу, за который вы не ответственны!");
                        return;
                    }
                }

                RemarkWork rw = new RemarkWork(t.Rows[0]["ID"].ToString(), UVO, RMType);
                rw.ShowDialog();
            }
            SetRemarkIcons();

        }

        private void tbPath_TextChanged(object sender, EventArgs e)
        {
            SetYellow();
        }

       


        //tbPath.Image = Resources.document_open_disabled;
        //tbPath.Enabled = false;
        //tbPath.Image = Resources.document_open;
        //tbPath.Enabled = true;
   





    }
}
