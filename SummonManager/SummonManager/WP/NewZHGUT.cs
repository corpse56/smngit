using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SummonManager.CLASSES;
using SummonManager.Controls;
using SummonManager.CLASSES.IRole_namespace;

namespace SummonManager
{
    public partial class NewZHGUT : Form
    {
        ZhgutVO Clone, EditWP,ViewWP;
        //ACCESSMODE: NEW,NEWCLONE,EDIT
        //NEW - форма переделывается под добавление нового изделия; EDIT - форма переделывается под редактирование; NEWCLONE - добавление на основе существующего
        private string AccessMode = "";

        IRole UVO;
        bool RequireVisible = true;
        bool RequireEnabled = false;


        public NewZHGUT(ZhgutVO wp, string accessmode_, IRole uvo)
        {
            InitializeComponent();

            this.AccessMode = accessmode_;
            this.UVO = uvo;
            RequireVisible = true;//((UVO.Role == Roles.Inzhener) || (UVO.Role == Roles.Admin)) ? true : false;
            RequireEnabled = false;
            if (AccessMode == "NEW")
            {
                InitNEW();
                this.Text = "Создание нового изделия";
                
            }
            if (AccessMode == "NEWCLONE")
            {
                InitNEWCLONE(wp);
                this.Text = "Создание нового изделия на основе существующего";
            }
            if (AccessMode == "EDIT")
            {
                InitEDIT(wp);
                this.Text = "Редактирование изделия";
            }
            if (AccessMode == "VIEWONLY")
            {
                InitVIEWONLY(wp);
                this.Text = "Просмотр сведений об изделии";
                button2.Visible = false;
            }


        }

        private void InitVIEWONLY(ZhgutVO wp)
        {
            ViewWP = wp;
            RequireVisible = true;
            tbName.Text = wp.WPName;
            tbName.Enabled = false;
            cbCategory.SelectedValue = wp.IDCat;
            cbCategory.Enabled = false;
            cbSubCategory.SelectedValue = wp.IDSubCat;
            cbSubCategory.Enabled = false;
            tbDecNum.Text = wp.DecNum;
            tbDecNum.Enabled = false;
            tbNote.Text = wp.NOTE;
            tbNote.Enabled = false;
            pfZHGUTPATH.Init(wp.ZHGUTPATH, true, false, false, RequireEnabled, Roles.Constructor, "VIEWONLY", UVO, "ZHGUTPATH",null,wp);

        }

        private void InitEDIT(ZhgutVO wp)
        {
            EditWP = wp;
            tbName.Text = wp.WPName;
            cbCategory.SelectedValue = wp.IDCat;
            cbSubCategory.SelectedValue = wp.IDSubCat;
            tbDecNum.Text = wp.DecNum;
            tbNote.Text = wp.NOTE;

            pfZHGUTPATH.Init(wp.ZHGUTPATH, true, true, false, RequireEnabled, Roles.Constructor, "EDIT",UVO, "ZHGUTPATH",null,wp);


            //AllocateRoles();

        }

        private void InitNEWCLONE(ZhgutVO clone)
        {
            if (clone.WPName != "")
            {
                this.Clone = clone;

                //wp.WPType = WPTYPE.WPNAMELIST;
                //wp.ID = (int)r["ID"];

                tbName.Text = Clone.WPName;
                cbCategory.SelectedValue = Clone.IDCat;
                cbSubCategory.SelectedValue = Clone.IDSubCat;
                tbDecNum.Text = Clone.DecNum;
                cbCategory.SelectedValue = Clone.IDCat;//CHECK!!!!!!!!
                cbSubCategory.SelectedValue = Clone.IDSubCat;//CHECK!!!!!!!!!
                pfZHGUTPATH.Init(Clone.ZHGUTPATH, true, true, false, RequireEnabled, Roles.Constructor, "NEWCLONE", UVO,"ZHGUTPATH",null,Clone);
                tbNote.Text = Clone.NOTE;
                //AllocateRoles();
            }
        }

        private void InitNEW()
        {
            pfZHGUTPATH.Init("", true, true, false, RequireEnabled, Roles.Constructor, "NEW", UVO,"ZHGUTPATH",null,new ZhgutVO());
        }


        private void button1_Click(object sender, EventArgs e)//cancel
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)//save
        {
            ZhgutVO wp = new ZhgutVO();
            if (tbName.Text == "")
            {
                MessageBox.Show("Введите наименование!");
                return;
            }
            
            wp.WPType                   = WPTYPE.ZHGUTLIST;
            wp.WPName                   = tbName.Text;
            wp.IDCat                    = Convert.ToInt32(cbCategory.SelectedValue);
            wp.IDSubCat                 = (cbSubCategory.SelectedValue == null) ? new DBSubCategory().GetIDNotAwardedByIDCat(wp.IDCat) : (int)cbSubCategory.SelectedValue;
            wp.DecNum                   = tbDecNum.Text;
            wp.ZHGUTPATH                = (pfZHGUTPATH.FullPath == "<нет>") ? null : pfZHGUTPATH.FullPath; ;
            wp.NOTE                     = tbNote.Text;

            DBZhgutList dbc = new DBZhgutList();
            if (AccessMode == "EDIT")
            {
                wp.ID = EditWP.ID;
                dbc.EditZhgut(wp);

                MessageBox.Show("Жгут успешно сохранён!");
            }
            if ((AccessMode == "NEW") || (AccessMode == "NEWCLONE"))
            {
                dbc.AddNewZhgut(wp);
                MessageBox.Show("Жгут успешно добавлен!");
            }
            Close();
        }

        private void NewWPN_Load(object sender, EventArgs e)
        {
            DBCategory dbc = new DBCategory("ZHGUTLIST");
            cbCategory.ValueMember = "ID";
            cbCategory.DisplayMember = "CATEGORYNAME";
            cbCategory.DataSource = dbc.GetAllExceptAll();

            if (AccessMode == "NEWCLONE")
            {
                if (Clone.IDCat != 0)
                {
                    cbCategory.SelectedValue = Clone.IDCat;
                }
                else
                {
                    cbCategory.SelectedIndex = 0;
                }
            }
            if (AccessMode == "NEW")
            {
                cbCategory.SelectedIndex = 0;
            }
            if (AccessMode == "EDIT")
            {
                if (EditWP.IDCat != 0)
                {
                    cbCategory.SelectedValue = EditWP.IDCat;
                }
                else
                {
                    cbCategory.SelectedIndex = 0;
                }

            }
            if (AccessMode == "VIEWONLY")
            {
                if (ViewWP.IDCat != 0)
                {
                    cbCategory.SelectedValue = ViewWP.IDCat;
                }
                else
                {
                    cbCategory.SelectedIndex = 0;
                }

            }
            LoadSubs((int)cbCategory.SelectedValue);
            if (AccessMode == "NEWCLONE")
                cbSubCategory.SelectedValue = Clone.IDSubCat;
            if (AccessMode == "EDIT")
                cbSubCategory.SelectedValue = EditWP.IDSubCat;
            if (AccessMode == "VIEWONLY")
            {
                cbSubCategory.SelectedValue = ViewWP.IDSubCat;
            }



        }
        private void LoadSubs(int idCat)
        {
            DBSubCategory dbs = new DBSubCategory();
            cbSubCategory.ValueMember = "ID";
            cbSubCategory.DisplayMember = "SUBCATNAME";
            cbSubCategory.DataSource = dbs.GetAllExceptAll(idCat);
        }
        private void cbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadSubs((int)cbCategory.SelectedValue);
        }

       
    }
}
