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
using SummonManager.Properties;

namespace SummonManager
{
    public partial class NewWPN : Form
    {
        WPNameVO Clone,EditWP,ViewWP;
        //ACCESSMODE: NEW,NEWCLONE,EDIT
        //NEW - форма переделывается под добавление нового изделия; EDIT - форма переделывается под редактирование; NEWCLONE - добавление на основе существующего
        private string AccessMode = "";

        IRole UVO;
        bool RequireVisible = true;
        bool RequireEnabled = false;


        public NewWPN(WPNameVO wp, string accessmode_, IRole uvo)
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

        private void InitVIEWONLY(WPNameVO wp)
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
            tbPowerSupply.Text = wp.PowerSupply;
            tbPowerSupply.Enabled = false;
            tbNote.Text = wp.Note;
            tbNote.Enabled = false;

            pfWIRINGDIAGRAM.Init(wp.WIRINGDIAGRAM, wp.WIRINGDIAGRAMREQ, false, RequireVisible, RequireEnabled, Roles.Shemotehnik, "VIEWONLY", UVO, "WIRINGDIAGRAM",null,wp);
            pfTECHREQ.Init(wp.TECHREQ, wp.TECHREQREQ, false, RequireVisible, RequireEnabled, Roles.Inzhener, "VIEWONLY", UVO, "TECHREQ", null, wp);
            pfComposition.Init(wp.COMPOSITION, wp.COMPOSITIONREQ, false, RequireVisible, RequireEnabled, Roles.Inzhener, "VIEWONLY", UVO, "COMPOSITION", null, wp);
            pfCONFIGURATION.Init(wp.CONFIGURATION, wp.CONFIGURATIONREQ, false, RequireVisible, RequireEnabled, Roles.Inzhener, "VIEWONLY", UVO, "CONFIGURATION", null, wp);
            pfDimDrawing.Init(wp.DIMENDRAWING, wp.DIMENSIONALDRAWINGREQ, false, RequireVisible, RequireEnabled, Roles.Constructor, "VIEWONLY", UVO, "DIMENSIONALDRAWING", null, wp);
            pf3DSBORKA.Init(wp.SBORKA3D, wp.SBORKA3DREQ, false, RequireVisible, RequireEnabled, Roles.Constructor, "VIEWONLY", UVO, "SBORKA3D", null, wp);
            pfMECHPARTS.Init(wp.MECHPARTS, wp.MECHPARTSREQ, false, RequireVisible, RequireEnabled, Roles.Constructor, "VIEWONLY", UVO, "MECHPARTS", null, wp);
            packZHGUT.Init(WPTYPE.ZHGUTLIST, wp.ID, wp.ZHGUTLISTREQ, false, RequireVisible, RequireEnabled, Roles.Constructor, UVO.Role, UVO);
            packCABLE.Init(WPTYPE.CABLELIST, wp.ID, wp.CABLELISTREQ, false, RequireVisible, RequireEnabled, Roles.Constructor, UVO.Role, UVO);
            pfSHILDS.Init(wp.SHILDS, wp.SHILDSREQ, false, RequireVisible, RequireEnabled, Roles.Constructor, "VIEWONLY", UVO, "SHILDS", null, wp);
            //pfPLANKA.Init(wp.PLANKA, wp.PLANKAREQ, false, RequireVisible, RequireEnabled,Roles.Constructor, UVO.Role);
            //pfSERIAL.Init(wp.SERIAL, wp.SERIALREQ, false, RequireVisible, RequireEnabled, Roles.OTK, UVO.Role);
            pfPACKAGING.Init(wp.PACKAGING, wp.PACKAGINGREQ, false, RequireVisible, RequireEnabled, Roles.Constructor, "VIEWONLY", UVO, "PACKAGING", null, wp);
            pfPASSPORT.Init(wp.PASSPORT, wp.PASSPORTREQ, false, RequireVisible, RequireEnabled, Roles.OTD, "VIEWONLY", UVO, "PASSPORT", null, wp);
            pfMANUAL.Init(wp.MANUAL, wp.MANUALREQ, false, RequireVisible, RequireEnabled, Roles.OTD, "VIEWONLY", UVO, "MANUAL", null, wp);
            pfPACKINGLIST.Init(wp.PACKINGLIST, wp.PACKINGLISTREQ, false, RequireVisible, RequireEnabled, Roles.OTD, "VIEWONLY", UVO, "PACKINGLIST", null, wp);

            packZHGUT.Enabled = false;
            packCABLE.Enabled = false;

            tbLENGTH.Text = wp.LENGTH;
            tbLENGTH.Enabled = false;
            tbWIDTH.Text = wp.WIDTH;
            tbWIDTH.Enabled = false;
            tbHEIGHT.Text = wp.HEIGHT;
            tbHEIGHT.Enabled = false;
            tbWEIGHT.Text = wp.WEIGHT;
            tbWEIGHT.Enabled = false;
        }

        private void InitEDIT(WPNameVO wp)
        {
            EditWP = wp;
            tbName.Text = wp.WPName;
            tbName.Enabled = false;
            cbCategory.SelectedValue = wp.IDCat;
            cbCategory.Enabled = false;
            cbSubCategory.SelectedValue = wp.IDSubCat;
            cbSubCategory.Enabled = false;
            tbDecNum.Text = wp.DecNum;
            tbDecNum.Enabled = false;
            tbPowerSupply.Text = wp.PowerSupply;
            tbPowerSupply.Enabled = false;
            tbNote.Text = wp.Note;
            tbNote.Enabled = false;

            pfWIRINGDIAGRAM.Init(wp.WIRINGDIAGRAM, wp.WIRINGDIAGRAMREQ, false, RequireVisible, RequireEnabled, Roles.Shemotehnik, "EDIT", UVO, "WIRINGDIAGRAM", null, wp);
            pfTECHREQ.Init(wp.TECHREQ, wp.TECHREQREQ, false, RequireVisible, RequireEnabled, Roles.Inzhener, "EDIT", UVO, "TECHREQ", null, wp);
            pfComposition.Init(wp.COMPOSITION, wp.COMPOSITIONREQ, false, RequireVisible, RequireEnabled, Roles.Inzhener, "EDIT", UVO, "COMPOSITION", null, wp);
            pfCONFIGURATION.Init(wp.CONFIGURATION, wp.CONFIGURATIONREQ, false, RequireVisible, RequireEnabled, Roles.Inzhener, "EDIT", UVO, "CONFIGURATION", null, wp);
            pfDimDrawing.Init(wp.DIMENDRAWING, wp.DIMENSIONALDRAWINGREQ, false, RequireVisible, RequireEnabled, Roles.Constructor, "EDIT", UVO, "DIMENSIONALDRAWING", null, wp);
            pf3DSBORKA.Init(wp.SBORKA3D, wp.SBORKA3DREQ, false, RequireVisible, RequireEnabled, Roles.Constructor, "EDIT", UVO, "SBORKA3D", null, wp);
            pfMECHPARTS.Init(wp.MECHPARTS, wp.MECHPARTSREQ, false, RequireVisible, RequireEnabled, Roles.Constructor, "EDIT", UVO, "MECHPARTS", null, wp);
            packZHGUT.Init(WPTYPE.ZHGUTLIST, wp.ID, wp.ZHGUTLISTREQ, false, RequireVisible, RequireEnabled, Roles.Constructor, UVO.Role,UVO);
            packCABLE.Init(WPTYPE.CABLELIST, wp.ID, wp.CABLELISTREQ, false, RequireVisible, RequireEnabled, Roles.Constructor, UVO.Role, UVO);
            pfSHILDS.Init(wp.SHILDS, wp.SHILDSREQ, false, RequireVisible, RequireEnabled, Roles.Constructor, "EDIT", UVO, "SHILDS", null, wp);
            //pfPLANKA.Init(wp.PLANKA, wp.PLANKAREQ, false, RequireVisible, RequireEnabled, Roles.Constructor, UVO.Role);
            //pfSERIAL.Init(wp.SERIAL, wp.SERIALREQ, false, RequireVisible, RequireEnabled, Roles.OTK, UVO.Role);
            pfPACKAGING.Init(wp.PACKAGING, wp.PACKAGINGREQ, false, RequireVisible, RequireEnabled, Roles.Constructor, "EDIT", UVO, "PACKAGING", null, wp);
            pfPASSPORT.Init(wp.PASSPORT, wp.PASSPORTREQ, false, RequireVisible, RequireEnabled, Roles.OTD, "EDIT", UVO, "PASSPORT", null, wp);
            pfMANUAL.Init(wp.MANUAL, wp.MANUALREQ, false, RequireVisible, RequireEnabled, Roles.OTD, "EDIT", UVO, "MANUAL", null, wp);
            pfPACKINGLIST.Init(wp.PACKINGLIST, wp.PACKINGLISTREQ, false, RequireVisible, RequireEnabled, Roles.OTD, "EDIT", UVO, "PACKINGLIST", null, wp);

            tbLENGTH.Text = wp.LENGTH;
            tbWIDTH.Text = wp.WIDTH;
            tbHEIGHT.Text = wp.HEIGHT;
            tbWEIGHT.Text = wp.WEIGHT;

            AllocateRoles();

        }

        private void InitNEWCLONE(WPNameVO clone)
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
                tbName.Enabled = false;
                cbCategory.Enabled = false;
                cbSubCategory.Enabled = false;
                tbDecNum.Enabled = false;
                tbPowerSupply.Enabled = false;
                tbNote.Enabled = false;

                pfWIRINGDIAGRAM.Init(Clone.WIRINGDIAGRAM, Clone.WIRINGDIAGRAMREQ, false, RequireVisible, RequireEnabled, Roles.Shemotehnik, "NEWCLONE", UVO, "WIRINGDIAGRAM", null, Clone);
                pfTECHREQ.Init(Clone.TECHREQ, Clone.TECHREQREQ, false, RequireVisible, RequireEnabled, Roles.Inzhener, "NEWCLONE", UVO, "TECHREQ", null, Clone);
                pfComposition.Init(Clone.COMPOSITION, Clone.COMPOSITIONREQ, false, RequireVisible, RequireEnabled, Roles.Inzhener, "NEWCLONE", UVO, "COMPOSITION", null, Clone);
                pfCONFIGURATION.Init(Clone.CONFIGURATION, Clone.CONFIGURATIONREQ, false, RequireVisible, RequireEnabled, Roles.Inzhener, "NEWCLONE", UVO, "CONFIGURATION", null, Clone);
                pfDimDrawing.Init(Clone.DIMENDRAWING, Clone.DIMENSIONALDRAWINGREQ, false, RequireVisible, RequireEnabled, Roles.Constructor, "NEWCLONE", UVO, "DIMENSIONALDRAWING", null, Clone);
                pf3DSBORKA.Init(Clone.SBORKA3D, Clone.SBORKA3DREQ, false, RequireVisible, RequireEnabled, Roles.Constructor, "NEWCLONE", UVO, "SBORKA3D", null, Clone);
                pfMECHPARTS.Init(Clone.MECHPARTS, Clone.MECHPARTSREQ, false, RequireVisible, RequireEnabled, Roles.Constructor, "NEWCLONE", UVO, "MECHPARTS", null, Clone);
                packZHGUT.Init(WPTYPE.ZHGUTLIST, Clone.ID, Clone.ZHGUTLISTREQ, false, RequireVisible, RequireEnabled, Roles.Constructor, UVO.Role, UVO);
                packCABLE.Init(WPTYPE.CABLELIST, Clone.ID, Clone.CABLELISTREQ, false, RequireVisible, RequireEnabled, Roles.Constructor, UVO.Role, UVO);
                pfSHILDS.Init(Clone.SHILDS, Clone.SHILDSREQ, false, RequireVisible, RequireEnabled, Roles.Constructor, "NEWCLONE", UVO, "SHILDS", null, Clone);
                //pfPLANKA.Init(Clone.PLANKA, Clone.PLANKAREQ, false, RequireVisible, RequireEnabled, Roles.Constructor, UVO.Role);
                //pfSERIAL.Init(Clone.SERIAL, Clone.SERIALREQ, false, RequireVisible, RequireEnabled, Roles.OTK, UVO.Role);
                pfPACKAGING.Init(Clone.PACKAGING, Clone.PACKAGINGREQ, false, RequireVisible, RequireEnabled, Roles.Constructor, "NEWCLONE", UVO, "PACKAGING", null, Clone);
                pfPASSPORT.Init(Clone.PASSPORT, Clone.PASSPORTREQ, false, RequireVisible, RequireEnabled, Roles.OTD, "NEWCLONE", UVO, "PASSPORT", null, Clone);
                pfMANUAL.Init(Clone.MANUAL, Clone.MANUALREQ, false, RequireVisible, RequireEnabled, Roles.OTD, "NEWCLONE", UVO, "MANUAL", null, Clone);
                pfPACKINGLIST.Init(Clone.PACKINGLIST, Clone.PACKINGLISTREQ, false, RequireVisible, RequireEnabled, Roles.OTD, "NEWCLONE", UVO, "PACKINGLIST", null, Clone);
                tbPowerSupply.Text = Clone.PowerSupply;
                tbNote.Text = Clone.Note;

                tbLENGTH.Text = Clone.LENGTH;
                tbWIDTH.Text = Clone.WIDTH;
                tbHEIGHT.Text = Clone.HEIGHT;
                tbWEIGHT.Text = Clone.WEIGHT;


                AllocateRoles();
            }
        }

        private void InitNEW()
        {

            pfWIRINGDIAGRAM.Init("", false, false, RequireVisible, RequireEnabled, Roles.Shemotehnik, "NEW", UVO, "WIRINGDIAGRAM",null, new WPNameVO());
            pfTECHREQ.Init("", false, false, RequireVisible, RequireEnabled, Roles.Inzhener, "NEW", UVO, "TECHREQ", null, new WPNameVO());
            pfComposition.Init("", false, false, RequireVisible, RequireEnabled, Roles.Inzhener, "NEW", UVO, "COMPOSITION", null, new WPNameVO());
            pfCONFIGURATION.Init("", false, false, RequireVisible, RequireEnabled, Roles.Inzhener, "NEW", UVO, "CONFIGURATION", null, new WPNameVO());
            pfDimDrawing.Init("", false, false, RequireVisible, RequireEnabled, Roles.Constructor, "NEW", UVO, "DIMENSIONALDRAWING", null, new WPNameVO());
            pf3DSBORKA.Init("", false, false, RequireVisible, RequireEnabled, Roles.Constructor, "NEW", UVO, "SBORKA3D", null, new WPNameVO());
            pfMECHPARTS.Init("", false, false, RequireVisible, RequireEnabled, Roles.Constructor, "NEW", UVO, "MECHPARTS", null, new WPNameVO());
            packZHGUT.Init(WPTYPE.ZHGUTLIST, 0, false, false, RequireVisible, RequireEnabled, Roles.Constructor, UVO.Role, UVO);
            packCABLE.Init(WPTYPE.CABLELIST, 0, false, false, RequireVisible, RequireEnabled, Roles.Constructor, UVO.Role, UVO);
            pfSHILDS.Init("", false, false, RequireVisible, RequireEnabled, Roles.Constructor, "NEW", UVO, "SHILDS", null, new WPNameVO());
           // pfPLANKA.Init("", false, false, RequireVisible, RequireEnabled, Roles.Constructor, UVO.Role);
            //pfSERIAL.Init("", false, false, RequireVisible, RequireEnabled, Roles.OTK, UVO.Role);
            pfPACKAGING.Init("", false, false, RequireVisible, RequireEnabled, Roles.Constructor, "NEW", UVO, "PACKAGING", null, new WPNameVO());
            pfPASSPORT.Init("", false, false, RequireVisible, RequireEnabled, Roles.OTD, "NEW", UVO, "PASSPORT", null, new WPNameVO());
            pfMANUAL.Init("", false, false, RequireVisible, RequireEnabled, Roles.OTD, "NEW", UVO, "MANUAL", null, new WPNameVO());
            pfPACKINGLIST.Init("", false, false, RequireVisible, RequireEnabled, Roles.OTD, "NEW", UVO, "PACKINGLIST", null, new WPNameVO());
            AllocateRoles();
        }

        private void AllocateRoles()
        {
            switch (UVO.Role)
            {
                case Roles.Admin:
                    EnableAdmin();
                    break;
                case Roles.Inzhener:
                case Roles.SimpleInzhener:
                    EnableInzhener();
                    break;
                case Roles.Constructor:
                    EnableConstructor();
                    break;
                case Roles.Shemotehnik:
                    EnableShemotehnik();
                    break;
                case Roles.Tehnolog:
                    EnableTehnolog();
                    break;
                case Roles.OTD:
                    EnableOTD();
                    break;
                case Roles.OTK:
                    EnableOTK();
                    break;
            }
        }

        private void EnableOTK()
        {
            tbNote.Enabled = true;
            tbLENGTH.Enabled = true;
            tbWIDTH.Enabled = true;
            tbHEIGHT.Enabled = true;
            tbWEIGHT.Enabled = true;

        }



        private void EnableInzhener()
        {
            tbName.Enabled = true;
            cbCategory.Enabled = true;
            cbSubCategory.Enabled = true;
            tbDecNum.Enabled = true;
            tbNote.Enabled = true;
            tbPowerSupply.Enabled = true;

            pfTECHREQ.Enabled = pfTECHREQ.Required;
            pfComposition.Enabled = pfComposition.Required;
            pfCONFIGURATION.Enabled = pfCONFIGURATION.Required;

            foreach (Control c in this.Controls)
            {
                if (c.GetType() == typeof(PathField))
                {
                    (c as PathField).RequiredEnabled = true;
                }
            }
            packCABLE.RequiredEnabled = true;
            packZHGUT.RequiredEnabled = true;
            tbLENGTH.Enabled = false;
            tbWIDTH.Enabled = false;
            tbHEIGHT.Enabled = false;
            tbWEIGHT.Enabled = false;

        }

        private void EnableOTD()
        {
            pfPASSPORT.Enabled = pfPASSPORT.Required;
            pfPASSPORT.RequiredEnabled = true;
            pfMANUAL.Enabled = pfMANUAL.Required;
            pfMANUAL.RequiredEnabled = true;
            pfPACKINGLIST.Enabled = pfPACKINGLIST.Required;
            pfPACKINGLIST.RequiredEnabled = true;
            tbNote.Enabled = true;
        }

        private void EnableTehnolog()
        {
            tbNote.Enabled = true;
        }

        private void EnableShemotehnik()
        {
            pfWIRINGDIAGRAM.Enabled = pfWIRINGDIAGRAM.Required;
            pfWIRINGDIAGRAM.RequiredEnabled = true;
            tbNote.Enabled = true;
        }
        private void EnableConstructor()
        {
            tbName.Enabled = true;
            cbCategory.Enabled = true;
            cbSubCategory.Enabled = true;
            tbDecNum.Enabled = true;
            tbNote.Enabled = true;

            pfDimDrawing.Enabled = pfDimDrawing.Required;
            pfDimDrawing.RequiredEnabled = true;
            pf3DSBORKA.Enabled = pf3DSBORKA.Required;
            pf3DSBORKA.RequiredEnabled = true;
            pfMECHPARTS.Enabled = pfMECHPARTS.Required;
            pfMECHPARTS.RequiredEnabled = true;
            pfSHILDS.Enabled = pfSHILDS.Required;
            pfSHILDS.RequiredEnabled = true;
            //pfPLANKA.Enabled = pfPLANKA.Required;
            pfPACKAGING.Enabled = pfPACKAGING.Required;
            pfPACKAGING.RequiredEnabled = true;
            if ((AccessMode != "NEW") || (AccessMode != "NEWCLONE"))
            {
                packCABLE.Enabled = packCABLE.Required;
                packZHGUT.Enabled = packZHGUT.Required;
            }
            packCABLE.RequiredEnabled = true;
            packZHGUT.RequiredEnabled = true;
            tbLENGTH.Enabled = false;
            tbWIDTH.Enabled = false;
            tbHEIGHT.Enabled = false;
            tbWEIGHT.Enabled = false;

        }

        private void EnableAdmin()
        {
            tbName.Enabled = true;
            cbCategory.Enabled = true;
            cbSubCategory.Enabled = true;
            tbDecNum.Enabled = true;
            tbPowerSupply.Enabled = true;
            tbNote.Enabled = true;

            
            pfWIRINGDIAGRAM.Enabled = pfWIRINGDIAGRAM.Required;
            pfTECHREQ.Enabled = pfTECHREQ.Required;
            pfComposition.Enabled = pfComposition.Required;
            pfCONFIGURATION.Enabled = pfCONFIGURATION.Required;
            pfDimDrawing.Enabled = pfDimDrawing.Required;
            pf3DSBORKA.Enabled = pf3DSBORKA.Required;
            pfMECHPARTS.Enabled = pfMECHPARTS.Required;
            pfSHILDS.Enabled = pfSHILDS.Required;
            //pfPLANKA.Enabled = pfPLANKA.Required;
            //pfSERIAL.Enabled = pfSERIAL.Required;
            pfPACKAGING.Enabled = pfPACKAGING.Required;
            pfPASSPORT.Enabled = pfPASSPORT.Required;
            pfMANUAL.Enabled = pfMANUAL.Required;
            pfPACKINGLIST.Enabled = pfPACKINGLIST.Required;
            if ((AccessMode != "NEW") || (AccessMode != "NEWCLONE"))
            {
                packCABLE.Enabled = packCABLE.Required;
                packZHGUT.Enabled = packZHGUT.Required;
            }
            foreach (Control c in this.Controls)
            {
                if (c.GetType() == typeof(PathField))
                {
                    (c as PathField).RequiredEnabled = true;
                }
            }
            packCABLE.RequiredEnabled = true;
            packZHGUT.RequiredEnabled = true;

            tbLENGTH.Enabled = true;
            tbWIDTH.Enabled = true;
            tbHEIGHT.Enabled = true;
            tbWEIGHT.Enabled = true;


        }


        private void button1_Click(object sender, EventArgs e)//cancel
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)//save
        {
            WPNameVO wp = new WPNameVO();
            if (tbName.Text == "")
            {
                MessageBox.Show("Введите наименование!");
                return;
            }
            
            wp.WPType                   = WPTYPE.WPNAMELIST;
            //wp.ID = (int)r["ID"];
            wp.WPName                   = tbName.Text;
            wp.IDCat                    = Convert.ToInt32(cbCategory.SelectedValue);
            wp.IDSubCat                 = (cbSubCategory.SelectedValue == null) ? new DBSubCategory().GetIDNotAwardedByIDCat(wp.IDCat)  : (int)cbSubCategory.SelectedValue;
            wp.DecNum                   = tbDecNum.Text;
            wp.WIRINGDIAGRAM            = (pfWIRINGDIAGRAM.FullPath == "<нет>") ? null : pfWIRINGDIAGRAM.FullPath;
            wp.TECHREQ                  = (pfTECHREQ.FullPath == "<нет>") ? null : pfTECHREQ.FullPath;
            wp.COMPOSITION              = (pfComposition.FullPath == "<нет>") ? null : pfComposition.FullPath;
            wp.CONFIGURATION            = (pfCONFIGURATION.FullPath == "<нет>") ? null : pfCONFIGURATION.FullPath;
            wp.DIMENDRAWING             = (pfDimDrawing.FullPath == "<нет>") ? null : pfDimDrawing.FullPath; ;
            wp.SBORKA3D                 = (pf3DSBORKA.FullPath == "<нет>") ? null : pf3DSBORKA.FullPath;
            wp.MECHPARTS                = (pfMECHPARTS.FullPath == "<нет>") ? null : pfMECHPARTS.FullPath;
            wp.ZHGUTS                   = new DBZhgutList().GetPackageForVO(wp.ID);
            wp.CABLES                   =  new DBCableList().GetPackageForVO(wp.ID);
            wp.SHILDS                   = (pfSHILDS.FullPath == "<нет>") ? null : pfSHILDS.FullPath;
            //wp.PLANKA                   = (pfPLANKA.FullPath == "<нет>") ? null : pfPLANKA.FullPath;
            //wp.SERIAL                   = (pfSERIAL.FullPath == "<нет>") ? null : pfSERIAL.FullPath;
            wp.PACKAGING                = (pfPACKAGING.FullPath == "<нет>") ? null : pfPACKAGING.FullPath;
            wp.PASSPORT                 = (pfPASSPORT.FullPath == "<нет>") ? null : pfPASSPORT.FullPath;
            wp.MANUAL                   = (pfMANUAL.FullPath == "<нет>") ? null : pfMANUAL.FullPath;
            wp.PACKINGLIST              = (pfPACKINGLIST.FullPath == "<нет>") ? null : pfPACKINGLIST.FullPath; 
            wp.PowerSupply              = tbPowerSupply.Text;
            wp.Note                     = tbNote.Text;
            wp.COMPOSITIONREQ           = pfComposition.Required;
            wp.DIMENSIONALDRAWINGREQ    = pfDimDrawing.Required	;
            //wp.POWERSUPPLYREQ	        = pfpowe;
            wp.CONFIGURATIONREQ         = pfCONFIGURATION.Required;	
            wp.WIRINGDIAGRAMREQ         = pfWIRINGDIAGRAM.Required;	
            wp.TECHREQREQ	            = pfTECHREQ.Required;
            wp.SBORKA3DREQ	            = pf3DSBORKA.Required;
            wp.MECHPARTSREQ             = pfMECHPARTS.Required;	
            wp.SHILDSREQ	            = pfSHILDS.Required;
            //wp.PLANKAREQ	            = pfPLANKA.Required;
            //wp.SERIALREQ	            = pfSERIAL.Required;
            wp.PACKAGINGREQ	            = pfPACKAGING.Required;
            wp.PASSPORTREQ              = pfPASSPORT.Required;
            wp.MANUALREQ	            = pfMANUAL.Required;
            wp.PACKINGLISTREQ	        = pfPACKINGLIST.Required;
            //wp.SOFTWAREREQ	;
            wp.CABLELISTREQ             = packCABLE.Required;	
            wp.ZHGUTLISTREQ             = packZHGUT.Required;	
            //wp.RUNCARDLISTREQ	;
            //wp.CIRCUITBOARDLISTREQ;
            wp.LENGTH = tbLENGTH.Text;
            wp.WIDTH = tbWIDTH.Text;
            wp.HEIGHT = tbHEIGHT.Text;
            wp.WEIGHT = tbWEIGHT.Text;


            DBWPName dbwp = new DBWPName();
            if (AccessMode == "EDIT")
            {
                wp.ID = EditWP.ID;
                if (UVO.Role == Roles.Admin)                                dbwp.EditWP(wp);
                if (UVO.Role == Roles.Constructor)                          dbwp.EditWP_Constructor(wp);
                if ((UVO.Role == Roles.Inzhener) ||
                    (UVO.Role == Roles.SimpleInzhener))                     dbwp.EditWP_Inzhener(wp);
                if (UVO.Role == Roles.Tehnolog)                             dbwp.EditWP_Tehnolog(wp);
                if (UVO.Role == Roles.Shemotehnik)                          dbwp.EditWP_Shemotehnik(wp);
                if (UVO.Role == Roles.OTD)                                  dbwp.EditWP_OTD(wp);
                if (UVO.Role == Roles.OTK)                                  dbwp.EditWP_OTK(wp);
                if (UVO.Role == Roles.OTK) dbwp.EditWP_OTK(wp);

                MessageBox.Show("Изделие успешно сохранено!");
            }
            if ((AccessMode == "NEW") || (AccessMode == "NEWCLONE"))
            {
                wp.COMPOSITIONREQ = true;
                wp.DIMENSIONALDRAWINGREQ = true;
                wp.CONFIGURATIONREQ = true;
                wp.WIRINGDIAGRAMREQ = true;
                wp.TECHREQREQ = true;
                wp.SBORKA3DREQ = true;
                wp.MECHPARTSREQ = true;
                wp.SHILDSREQ = true;
                wp.PACKAGINGREQ = true;
                wp.PASSPORTREQ = true;
                wp.MANUALREQ = true;
                wp.PACKINGLISTREQ = true;
                wp.CABLELISTREQ = true;
                wp.ZHGUTLISTREQ = true;	

                dbwp.AddNewWP(wp);
                MessageBox.Show("Изделие успешно добавлено!");
            }
            Close();
        }

        private void NewWPN_Load(object sender, EventArgs e)
        {
            DBCategory dbc = new DBCategory("WPNAMELIST");
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
                    cbCategory.SelectedValue = 1;
                }
            }
            if (AccessMode == "NEW")
            {
                cbCategory.SelectedValue = 1;
            }
            if (AccessMode == "EDIT")
            {
                if (EditWP.IDCat != 0)
                {
                    cbCategory.SelectedValue = EditWP.IDCat;
                }
                else
                {
                    cbCategory.SelectedValue = 1;
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

            button1.Select();

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
