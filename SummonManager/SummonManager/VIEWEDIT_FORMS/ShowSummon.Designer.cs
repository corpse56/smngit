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
    partial class ShowSummon
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.bRemarks = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label30 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.chbDocsRdy = new System.Windows.Forms.CheckBox();
            this.chbBillPayed = new System.Windows.Forms.CheckBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.tbSubStatus = new System.Windows.Forms.TextBox();
            this.tbStatus = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.bEditCustomers = new System.Windows.Forms.Button();
            this.dtpPTIME = new System.Windows.Forms.DateTimePicker();
            this.dtpCREATED = new System.Windows.Forms.DateTimePicker();
            this.tbDELIVERY = new System.Windows.Forms.TextBox();
            this.tbSHIPPING = new System.Windows.Forms.TextBox();
            this.tbPayStatus = new System.Windows.Forms.TextBox();
            this.tbBillNumber = new System.Windows.Forms.TextBox();
            this.tbCONTRACT = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbIDS = new System.Windows.Forms.TextBox();
            this.bPurchMat = new System.Windows.Forms.Button();
            this.bDelSummon = new System.Windows.Forms.Button();
            this.bEdit = new System.Windows.Forms.Button();
            this.bSave = new System.Windows.Forms.Button();
            this.bPrint = new System.Windows.Forms.Button();
            this.bChangeProduct = new System.Windows.Forms.Button();
            this.bCancel = new System.Windows.Forms.Button();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.bViewWP = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.bEditWP = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.pfPACKINGLIST = new SummonManager.Controls.PathField();
            this.pfMANUAL = new SummonManager.Controls.PathField();
            this.pfPASSPORT = new SummonManager.Controls.PathField();
            this.pfSERIAL = new SummonManager.Controls.PathField();
            this.pfPLANKA = new SummonManager.Controls.PathField();
            this.cbCONTRACTTYPE = new SummonManager.RComboBox();
            this.wpNameView1 = new SummonManager.Controls.WPNameView();
            this.cbCustDept = new SummonManager.RComboBox();
            this.cbPacking = new SummonManager.RComboBox();
            this.cbAccept = new SummonManager.RComboBox();
            this.tbQUANTITY = new SummonManager.RNumericUpDown();
            this.cbSISP = new SummonManager.RComboBox();
            this.cbCustomers = new SummonManager.RComboBox();
            this.summonTransfer2 = new SummonManager.SummonTransfer();
            this.summonTransfer1 = new SummonManager.SummonTransfer();
            this.summonNotes1 = new SummonManager.SummonNotes();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbQUANTITY)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.bRemarks);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            this.splitContainer1.Panel1.Controls.Add(this.summonTransfer2);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.summonTransfer1);
            this.splitContainer1.Panel1.Controls.Add(this.tbIDS);
            this.splitContainer1.Panel1.Controls.Add(this.bPurchMat);
            this.splitContainer1.Panel1.Controls.Add(this.bDelSummon);
            this.splitContainer1.Panel1.Controls.Add(this.bEdit);
            this.splitContainer1.Panel1.Controls.Add(this.bSave);
            this.splitContainer1.Panel1.Controls.Add(this.bPrint);
            this.splitContainer1.Panel1.Controls.Add(this.bChangeProduct);
            this.splitContainer1.Panel1.Controls.Add(this.bCancel);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1292, 891);
            this.splitContainer1.SplitterDistance = 678;
            this.splitContainer1.TabIndex = 277;
            // 
            // bRemarks
            // 
            this.bRemarks.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bRemarks.Location = new System.Drawing.Point(517, 833);
            this.bRemarks.Name = "bRemarks";
            this.bRemarks.Size = new System.Drawing.Size(89, 49);
            this.bRemarks.TabIndex = 335;
            this.bRemarks.Text = "Замечания";
            this.bRemarks.UseVisualStyleBackColor = true;
            this.bRemarks.Click += new System.EventHandler(this.bRemarks_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Location = new System.Drawing.Point(11, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(662, 649);
            this.groupBox1.TabIndex = 334;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Сведения об извещении";
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.label31);
            this.panel1.Controls.Add(this.label27);
            this.panel1.Controls.Add(this.label26);
            this.panel1.Controls.Add(this.label25);
            this.panel1.Controls.Add(this.label24);
            this.panel1.Controls.Add(this.label30);
            this.panel1.Controls.Add(this.label28);
            this.panel1.Controls.Add(this.label29);
            this.panel1.Controls.Add(this.pfPACKINGLIST);
            this.panel1.Controls.Add(this.pfMANUAL);
            this.panel1.Controls.Add(this.pfPASSPORT);
            this.panel1.Controls.Add(this.pfSERIAL);
            this.panel1.Controls.Add(this.pfPLANKA);
            this.panel1.Controls.Add(this.label18);
            this.panel1.Controls.Add(this.label22);
            this.panel1.Controls.Add(this.cbCONTRACTTYPE);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.chbDocsRdy);
            this.panel1.Controls.Add(this.chbBillPayed);
            this.panel1.Controls.Add(this.label19);
            this.panel1.Controls.Add(this.label21);
            this.panel1.Controls.Add(this.tbSubStatus);
            this.panel1.Controls.Add(this.tbStatus);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.wpNameView1);
            this.panel1.Controls.Add(this.cbCustDept);
            this.panel1.Controls.Add(this.label20);
            this.panel1.Controls.Add(this.cbPacking);
            this.panel1.Controls.Add(this.bEditCustomers);
            this.panel1.Controls.Add(this.cbAccept);
            this.panel1.Controls.Add(this.tbQUANTITY);
            this.panel1.Controls.Add(this.dtpPTIME);
            this.panel1.Controls.Add(this.dtpCREATED);
            this.panel1.Controls.Add(this.cbSISP);
            this.panel1.Controls.Add(this.cbCustomers);
            this.panel1.Controls.Add(this.tbDELIVERY);
            this.panel1.Controls.Add(this.tbSHIPPING);
            this.panel1.Controls.Add(this.tbPayStatus);
            this.panel1.Controls.Add(this.tbBillNumber);
            this.panel1.Controls.Add(this.tbCONTRACT);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label23);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 18);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(656, 628);
            this.panel1.TabIndex = 0;
            this.panel1.MouseEnter += new System.EventHandler(this.panel1_MouseEnter);
            // 
            // label30
            // 
            this.label30.Location = new System.Drawing.Point(11, 711);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(137, 18);
            this.label30.TabIndex = 389;
            this.label30.Text = "Лист упаковочный";
            // 
            // label28
            // 
            this.label28.Location = new System.Drawing.Point(16, 643);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(120, 18);
            this.label28.TabIndex = 389;
            this.label28.Text = "Паспорт";
            // 
            // label29
            // 
            this.label29.Location = new System.Drawing.Point(15, 675);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(120, 18);
            this.label29.TabIndex = 389;
            this.label29.Text = "РЭ";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(13, 483);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(126, 16);
            this.label18.TabIndex = 373;
            this.label18.Text = "Серийные номера";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(13, 451);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(135, 16);
            this.label22.TabIndex = 374;
            this.label22.Text = "Планка фирменная";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(11, 301);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(98, 16);
            this.label16.TabIndex = 371;
            this.label16.Text = "Тип договора";
            // 
            // chbDocsRdy
            // 
            this.chbDocsRdy.AutoSize = true;
            this.chbDocsRdy.Checked = true;
            this.chbDocsRdy.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbDocsRdy.Location = new System.Drawing.Point(189, 609);
            this.chbDocsRdy.Name = "chbDocsRdy";
            this.chbDocsRdy.Size = new System.Drawing.Size(149, 20);
            this.chbDocsRdy.TabIndex = 369;
            this.chbDocsRdy.Text = "Документы готовы";
            this.chbDocsRdy.UseVisualStyleBackColor = true;
            // 
            // chbBillPayed
            // 
            this.chbBillPayed.AutoSize = true;
            this.chbBillPayed.Checked = true;
            this.chbBillPayed.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbBillPayed.Location = new System.Drawing.Point(189, 581);
            this.chbBillPayed.Name = "chbBillPayed";
            this.chbBillPayed.Size = new System.Drawing.Size(154, 20);
            this.chbBillPayed.TabIndex = 370;
            this.chbBillPayed.Text = "Счёт оплачен 100%";
            this.chbBillPayed.UseVisualStyleBackColor = true;
            // 
            // label19
            // 
            this.label19.Location = new System.Drawing.Point(14, 609);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(167, 18);
            this.label19.TabIndex = 367;
            this.label19.Text = "Состояние документов";
            // 
            // label21
            // 
            this.label21.Location = new System.Drawing.Point(14, 581);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(120, 18);
            this.label21.TabIndex = 368;
            this.label21.Text = "Состояние счёта";
            // 
            // tbSubStatus
            // 
            this.tbSubStatus.Location = new System.Drawing.Point(188, 549);
            this.tbSubStatus.Name = "tbSubStatus";
            this.tbSubStatus.Size = new System.Drawing.Size(284, 22);
            this.tbSubStatus.TabIndex = 365;
            // 
            // tbStatus
            // 
            this.tbStatus.Location = new System.Drawing.Point(188, 521);
            this.tbStatus.Name = "tbStatus";
            this.tbStatus.Size = new System.Drawing.Size(284, 22);
            this.tbStatus.TabIndex = 366;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(15, 549);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(135, 16);
            this.label14.TabIndex = 363;
            this.label14.Text = "Текущий субстатус";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 521);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 16);
            this.label8.TabIndex = 364;
            this.label8.Text = "Текущий статус";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(11, 218);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(138, 16);
            this.label20.TabIndex = 360;
            this.label20.Text = "Отдел организации";
            // 
            // bEditCustomers
            // 
            this.bEditCustomers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bEditCustomers.Location = new System.Drawing.Point(553, 190);
            this.bEditCustomers.Name = "bEditCustomers";
            this.bEditCustomers.Size = new System.Drawing.Size(16, 55);
            this.bEditCustomers.TabIndex = 358;
            this.bEditCustomers.Text = "+";
            this.bEditCustomers.UseVisualStyleBackColor = true;
            // 
            // dtpPTIME
            // 
            this.dtpPTIME.Location = new System.Drawing.Point(188, 132);
            this.dtpPTIME.Name = "dtpPTIME";
            this.dtpPTIME.Size = new System.Drawing.Size(200, 22);
            this.dtpPTIME.TabIndex = 355;
            // 
            // dtpCREATED
            // 
            this.dtpCREATED.Enabled = false;
            this.dtpCREATED.Location = new System.Drawing.Point(188, 15);
            this.dtpCREATED.Name = "dtpCREATED";
            this.dtpCREATED.Size = new System.Drawing.Size(200, 22);
            this.dtpCREATED.TabIndex = 354;
            // 
            // tbDELIVERY
            // 
            this.tbDELIVERY.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tbDELIVERY.Location = new System.Drawing.Point(185, 387);
            this.tbDELIVERY.Name = "tbDELIVERY";
            this.tbDELIVERY.Size = new System.Drawing.Size(362, 22);
            this.tbDELIVERY.TabIndex = 348;
            // 
            // tbSHIPPING
            // 
            this.tbSHIPPING.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSHIPPING.Location = new System.Drawing.Point(185, 359);
            this.tbSHIPPING.Name = "tbSHIPPING";
            this.tbSHIPPING.Size = new System.Drawing.Size(362, 22);
            this.tbSHIPPING.TabIndex = 347;
            // 
            // tbPayStatus
            // 
            this.tbPayStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPayStatus.Location = new System.Drawing.Point(185, 331);
            this.tbPayStatus.Name = "tbPayStatus";
            this.tbPayStatus.Size = new System.Drawing.Size(362, 22);
            this.tbPayStatus.TabIndex = 351;
            // 
            // tbBillNumber
            // 
            this.tbBillNumber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tbBillNumber.Location = new System.Drawing.Point(187, 273);
            this.tbBillNumber.Name = "tbBillNumber";
            this.tbBillNumber.Size = new System.Drawing.Size(360, 22);
            this.tbBillNumber.TabIndex = 350;
            // 
            // tbCONTRACT
            // 
            this.tbCONTRACT.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tbCONTRACT.Location = new System.Drawing.Point(187, 245);
            this.tbCONTRACT.Name = "tbCONTRACT";
            this.tbCONTRACT.Size = new System.Drawing.Size(360, 22);
            this.tbCONTRACT.TabIndex = 349;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(18, 416);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(60, 16);
            this.label13.TabIndex = 338;
            this.label13.Text = "СИ и СП";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(16, 389);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(127, 16);
            this.label12.TabIndex = 339;
            this.label12.Text = "Условия поставки";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(15, 360);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(126, 16);
            this.label11.TabIndex = 340;
            this.label11.Text = "Условия отгрузки";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(15, 331);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(105, 16);
            this.label10.TabIndex = 334;
            this.label10.Text = "Статус оплаты";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(12, 245);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(88, 16);
            this.label23.TabIndex = 336;
            this.label23.Text = "№ Договора";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(11, 276);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 16);
            this.label9.TabIndex = 335;
            this.label9.Text = "№ Счёта";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 191);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(160, 16);
            this.label7.TabIndex = 337;
            this.label7.Text = "Организация заказчик";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 163);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 16);
            this.label6.TabIndex = 344;
            this.label6.Text = "Приемка";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 16);
            this.label5.TabIndex = 345;
            this.label5.Text = "Срок сдачи изделия";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 16);
            this.label4.TabIndex = 346;
            this.label4.Text = "Количество*";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(11, 20);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(115, 16);
            this.label15.TabIndex = 341;
            this.label15.Text = "Дата извещения";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(13, 79);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(71, 16);
            this.label17.TabIndex = 342;
            this.label17.Text = "Упаковка";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 16);
            this.label2.TabIndex = 343;
            this.label2.Text = "Наименование продукта";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(145, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 16);
            this.label1.TabIndex = 322;
            this.label1.Text = "Извещение №";
            // 
            // tbIDS
            // 
            this.tbIDS.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.tbIDS.Location = new System.Drawing.Point(255, 6);
            this.tbIDS.Name = "tbIDS";
            this.tbIDS.ReadOnly = true;
            this.tbIDS.Size = new System.Drawing.Size(133, 22);
            this.tbIDS.TabIndex = 285;
            // 
            // bPurchMat
            // 
            this.bPurchMat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bPurchMat.Location = new System.Drawing.Point(239, 833);
            this.bPurchMat.Name = "bPurchMat";
            this.bPurchMat.Size = new System.Drawing.Size(90, 49);
            this.bPurchMat.TabIndex = 284;
            this.bPurchMat.Text = "Покупные материалы";
            this.bPurchMat.UseVisualStyleBackColor = true;
            this.bPurchMat.Click += new System.EventHandler(this.bPurchMat_Click);
            // 
            // bDelSummon
            // 
            this.bDelSummon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bDelSummon.Location = new System.Drawing.Point(335, 833);
            this.bDelSummon.Name = "bDelSummon";
            this.bDelSummon.Size = new System.Drawing.Size(90, 49);
            this.bDelSummon.TabIndex = 283;
            this.bDelSummon.Text = "Удалить извещение";
            this.bDelSummon.UseVisualStyleBackColor = true;
            this.bDelSummon.Click += new System.EventHandler(this.bDelSummon_Click);
            // 
            // bEdit
            // 
            this.bEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bEdit.Location = new System.Drawing.Point(71, 833);
            this.bEdit.Name = "bEdit";
            this.bEdit.Size = new System.Drawing.Size(71, 49);
            this.bEdit.TabIndex = 281;
            this.bEdit.Text = "Редактировать";
            this.bEdit.UseVisualStyleBackColor = true;
            this.bEdit.Click += new System.EventHandler(this.bEdit_Click);
            // 
            // bSave
            // 
            this.bSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bSave.Location = new System.Drawing.Point(148, 833);
            this.bSave.Name = "bSave";
            this.bSave.Size = new System.Drawing.Size(85, 49);
            this.bSave.TabIndex = 280;
            this.bSave.Text = "Сохранить";
            this.bSave.UseVisualStyleBackColor = true;
            this.bSave.Click += new System.EventHandler(this.bSave_Click);
            // 
            // bPrint
            // 
            this.bPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bPrint.Enabled = false;
            this.bPrint.Location = new System.Drawing.Point(1, 833);
            this.bPrint.Name = "bPrint";
            this.bPrint.Size = new System.Drawing.Size(64, 49);
            this.bPrint.TabIndex = 279;
            this.bPrint.Text = "Печать";
            this.bPrint.UseVisualStyleBackColor = true;
            this.bPrint.Click += new System.EventHandler(this.bPrint_Click);
            // 
            // bChangeProduct
            // 
            this.bChangeProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bChangeProduct.Location = new System.Drawing.Point(428, 833);
            this.bChangeProduct.Name = "bChangeProduct";
            this.bChangeProduct.Size = new System.Drawing.Size(83, 49);
            this.bChangeProduct.TabIndex = 278;
            this.bChangeProduct.Text = "Изменить продукт";
            this.bChangeProduct.UseVisualStyleBackColor = true;
            this.bChangeProduct.Click += new System.EventHandler(this.bChangeProduct_Click);
            // 
            // bCancel
            // 
            this.bCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bCancel.Location = new System.Drawing.Point(609, 833);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(68, 49);
            this.bCancel.TabIndex = 278;
            this.bCancel.Text = "Отмена";
            this.bCancel.UseVisualStyleBackColor = true;
            this.bCancel.Click += new System.EventHandler(this.bCancel_Click);
            // 
            // splitContainer2
            // 
            this.splitContainer2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.bViewWP);
            this.splitContainer2.Panel1.Controls.Add(this.label3);
            this.splitContainer2.Panel1.Controls.Add(this.bEditWP);
            this.splitContainer2.Panel1.Controls.Add(this.tableLayoutPanel1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.summonNotes1);
            this.splitContainer2.Size = new System.Drawing.Size(610, 891);
            this.splitContainer2.SplitterDistance = 471;
            this.splitContainer2.TabIndex = 0;
            // 
            // bViewWP
            // 
            this.bViewWP.Location = new System.Drawing.Point(456, 5);
            this.bViewWP.Name = "bViewWP";
            this.bViewWP.Size = new System.Drawing.Size(84, 23);
            this.bViewWP.TabIndex = 43;
            this.bViewWP.Text = "Просмотр";
            this.bViewWP.UseVisualStyleBackColor = true;
            this.bViewWP.Click += new System.EventHandler(this.bViewWP_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(166, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(239, 16);
            this.label3.TabIndex = 42;
            this.label3.Text = "Необходимые сведения о продукте";
            // 
            // bEditWP
            // 
            this.bEditWP.Location = new System.Drawing.Point(3, 6);
            this.bEditWP.Name = "bEditWP";
            this.bEditWP.Size = new System.Drawing.Size(122, 23);
            this.bEditWP.TabIndex = 41;
            this.bEditWP.Text = "Редактировать";
            this.bEditWP.UseVisualStyleBackColor = true;
            this.bEditWP.Click += new System.EventHandler(this.bEditWP_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.AutoScroll = true;
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 46);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 484F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(602, 420);
            this.tableLayoutPanel1.TabIndex = 38;
            this.tableLayoutPanel1.MouseEnter += new System.EventHandler(this.tableLayoutPanel1_MouseEnter);
            // 
            // label24
            // 
            this.label24.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(575, 456);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(54, 16);
            this.label24.TabIndex = 390;
            this.label24.Text = "Констр";
            // 
            // label25
            // 
            this.label25.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(575, 487);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(35, 16);
            this.label25.TabIndex = 391;
            this.label25.Text = "ОТК";
            // 
            // label26
            // 
            this.label26.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(575, 645);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(36, 16);
            this.label26.TabIndex = 391;
            this.label26.Text = "ОТД";
            // 
            // label27
            // 
            this.label27.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(575, 677);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(36, 16);
            this.label27.TabIndex = 391;
            this.label27.Text = "ОТД";
            // 
            // label31
            // 
            this.label31.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(575, 713);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(36, 16);
            this.label31.TabIndex = 391;
            this.label31.Text = "ОТД";
            // 
            // pfPACKINGLIST
            // 
            this.pfPACKINGLIST.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pfPACKINGLIST.bDelVisible = true;
            this.pfPACKINGLIST.bPathVisible = true;
            this.pfPACKINGLIST.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pfPACKINGLIST.FullPath = "<нет>";
            this.pfPACKINGLIST.ISPATH = false;
            this.pfPACKINGLIST.Location = new System.Drawing.Point(152, 703);
            this.pfPACKINGLIST.Margin = new System.Windows.Forms.Padding(4);
            this.pfPACKINGLIST.Name = "pfPACKINGLIST";
            this.pfPACKINGLIST.Required = false;
            this.pfPACKINGLIST.Size = new System.Drawing.Size(415, 32);
            this.pfPACKINGLIST.TabIndex = 379;
            this.pfPACKINGLIST.Tag = SummonManager.CLASSES.IRole_namespace.Roles.OTD;
            // 
            // pfMANUAL
            // 
            this.pfMANUAL.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pfMANUAL.bDelVisible = true;
            this.pfMANUAL.bPathVisible = true;
            this.pfMANUAL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pfMANUAL.FullPath = "<нет>";
            this.pfMANUAL.ISPATH = false;
            this.pfMANUAL.Location = new System.Drawing.Point(152, 668);
            this.pfMANUAL.Margin = new System.Windows.Forms.Padding(4);
            this.pfMANUAL.Name = "pfMANUAL";
            this.pfMANUAL.Required = false;
            this.pfMANUAL.Size = new System.Drawing.Size(415, 32);
            this.pfMANUAL.TabIndex = 378;
            this.pfMANUAL.Tag = SummonManager.CLASSES.IRole_namespace.Roles.OTD;
            // 
            // pfPASSPORT
            // 
            this.pfPASSPORT.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pfPASSPORT.bDelVisible = true;
            this.pfPASSPORT.bPathVisible = true;
            this.pfPASSPORT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pfPASSPORT.FullPath = "<нет>";
            this.pfPASSPORT.ISPATH = false;
            this.pfPASSPORT.Location = new System.Drawing.Point(152, 636);
            this.pfPASSPORT.Margin = new System.Windows.Forms.Padding(4);
            this.pfPASSPORT.Name = "pfPASSPORT";
            this.pfPASSPORT.Required = false;
            this.pfPASSPORT.Size = new System.Drawing.Size(415, 32);
            this.pfPASSPORT.TabIndex = 377;
            this.pfPASSPORT.Tag = SummonManager.CLASSES.IRole_namespace.Roles.OTD;
            // 
            // pfSERIAL
            // 
            this.pfSERIAL.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pfSERIAL.bDelVisible = true;
            this.pfSERIAL.bPathVisible = true;
            this.pfSERIAL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pfSERIAL.FullPath = "<нет>";
            this.pfSERIAL.ISPATH = false;
            this.pfSERIAL.Location = new System.Drawing.Point(152, 478);
            this.pfSERIAL.Margin = new System.Windows.Forms.Padding(4);
            this.pfSERIAL.Name = "pfSERIAL";
            this.pfSERIAL.Required = false;
            this.pfSERIAL.Size = new System.Drawing.Size(415, 32);
            this.pfSERIAL.TabIndex = 375;
            this.pfSERIAL.Tag = SummonManager.CLASSES.IRole_namespace.Roles.OTK;
            // 
            // pfPLANKA
            // 
            this.pfPLANKA.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pfPLANKA.bDelVisible = true;
            this.pfPLANKA.bPathVisible = true;
            this.pfPLANKA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pfPLANKA.FullPath = "<нет>";
            this.pfPLANKA.ISPATH = false;
            this.pfPLANKA.Location = new System.Drawing.Point(152, 444);
            this.pfPLANKA.Margin = new System.Windows.Forms.Padding(4);
            this.pfPLANKA.Name = "pfPLANKA";
            this.pfPLANKA.Required = false;
            this.pfPLANKA.Size = new System.Drawing.Size(416, 32);
            this.pfPLANKA.TabIndex = 376;
            this.pfPLANKA.Tag = SummonManager.CLASSES.IRole_namespace.Roles.Constructor;
            // 
            // cbCONTRACTTYPE
            // 
            this.cbCONTRACTTYPE.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cbCONTRACTTYPE.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCONTRACTTYPE.FormattingEnabled = true;
            this.cbCONTRACTTYPE.Items.AddRange(new object[] {
            "Стандартный",
            "По 275 ФЗ"});
            this.cbCONTRACTTYPE.Location = new System.Drawing.Point(185, 301);
            this.cbCONTRACTTYPE.Name = "cbCONTRACTTYPE";
            this.cbCONTRACTTYPE.Size = new System.Drawing.Size(362, 24);
            this.cbCONTRACTTYPE.TabIndex = 372;
            // 
            // wpNameView1
            // 
            this.wpNameView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.wpNameView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.wpNameView1.Location = new System.Drawing.Point(184, 39);
            this.wpNameView1.Margin = new System.Windows.Forms.Padding(4);
            this.wpNameView1.Name = "wpNameView1";
            this.wpNameView1.Size = new System.Drawing.Size(385, 31);
            this.wpNameView1.TabIndex = 362;
            // 
            // cbCustDept
            // 
            this.cbCustDept.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cbCustDept.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCustDept.FormattingEnabled = true;
            this.cbCustDept.Location = new System.Drawing.Point(189, 218);
            this.cbCustDept.Name = "cbCustDept";
            this.cbCustDept.Size = new System.Drawing.Size(358, 24);
            this.cbCustDept.TabIndex = 361;
            // 
            // cbPacking
            // 
            this.cbPacking.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cbPacking.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPacking.FormattingEnabled = true;
            this.cbPacking.Location = new System.Drawing.Point(188, 75);
            this.cbPacking.Name = "cbPacking";
            this.cbPacking.Size = new System.Drawing.Size(381, 24);
            this.cbPacking.TabIndex = 359;
            // 
            // cbAccept
            // 
            this.cbAccept.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cbAccept.FormattingEnabled = true;
            this.cbAccept.Location = new System.Drawing.Point(188, 160);
            this.cbAccept.Name = "cbAccept";
            this.cbAccept.Size = new System.Drawing.Size(359, 24);
            this.cbAccept.TabIndex = 357;
            // 
            // tbQUANTITY
            // 
            this.tbQUANTITY.Location = new System.Drawing.Point(187, 105);
            this.tbQUANTITY.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.tbQUANTITY.Name = "tbQUANTITY";
            this.tbQUANTITY.Size = new System.Drawing.Size(201, 22);
            this.tbQUANTITY.TabIndex = 356;
            // 
            // cbSISP
            // 
            this.cbSISP.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cbSISP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSISP.FormattingEnabled = true;
            this.cbSISP.Items.AddRange(new object[] {
            "НЕТ",
            "ДА"});
            this.cbSISP.Location = new System.Drawing.Point(184, 413);
            this.cbSISP.Name = "cbSISP";
            this.cbSISP.Size = new System.Drawing.Size(363, 24);
            this.cbSISP.TabIndex = 353;
            // 
            // cbCustomers
            // 
            this.cbCustomers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cbCustomers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCustomers.FormattingEnabled = true;
            this.cbCustomers.Location = new System.Drawing.Point(188, 188);
            this.cbCustomers.Name = "cbCustomers";
            this.cbCustomers.Size = new System.Drawing.Size(359, 24);
            this.cbCustomers.TabIndex = 352;
            // 
            // summonTransfer2
            // 
            this.summonTransfer2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.summonTransfer2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.summonTransfer2.Location = new System.Drawing.Point(1, 754);
            this.summonTransfer2.Margin = new System.Windows.Forms.Padding(4);
            this.summonTransfer2.Name = "summonTransfer2";
            this.summonTransfer2.Size = new System.Drawing.Size(477, 72);
            this.summonTransfer2.TabIndex = 323;
            // 
            // summonTransfer1
            // 
            this.summonTransfer1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.summonTransfer1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.summonTransfer1.Location = new System.Drawing.Point(4, 682);
            this.summonTransfer1.Margin = new System.Windows.Forms.Padding(4);
            this.summonTransfer1.Name = "summonTransfer1";
            this.summonTransfer1.Size = new System.Drawing.Size(488, 76);
            this.summonTransfer1.TabIndex = 316;
            // 
            // summonNotes1
            // 
            this.summonNotes1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.summonNotes1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.summonNotes1.Location = new System.Drawing.Point(0, 0);
            this.summonNotes1.Margin = new System.Windows.Forms.Padding(4);
            this.summonNotes1.Name = "summonNotes1";
            this.summonNotes1.Size = new System.Drawing.Size(608, 414);
            this.summonNotes1.TabIndex = 0;
            // 
            // ShowSummon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1292, 891);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ShowSummon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Просмотр извещения (менеджер)";
            this.Load += new System.EventHandler(this.ShowSummon_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tbQUANTITY)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private SplitContainer splitContainer1;
        private Label label1;
        private SplitContainer splitContainer2;
        private Label label3;
        public SummonTransfer summonTransfer1;
        public Button bPurchMat;
        public Button bDelSummon;
        public Button bEdit;
        public Button bSave;
        public Button bPrint;
        public Button bCancel;
        public TableLayoutPanel tableLayoutPanel1;
        public SummonTransfer summonTransfer2;
        public Button bEditWP;
        public TextBox tbIDS;
        private Button bViewWP;
        public Button bChangeProduct;
        private GroupBox groupBox1;
        private Panel panel1;
        public SummonManager.Controls.PathField pfSERIAL;
        public SummonManager.Controls.PathField pfPLANKA;
        private Label label18;
        private Label label22;
        public RComboBox cbCONTRACTTYPE;
        private Label label16;
        public CheckBox chbDocsRdy;
        public CheckBox chbBillPayed;
        private Label label19;
        private Label label21;
        public TextBox tbSubStatus;
        public TextBox tbStatus;
        private Label label14;
        private Label label8;
        public SummonManager.Controls.WPNameView wpNameView1;
        public RComboBox cbCustDept;
        private Label label20;
        public RComboBox cbPacking;
        public Button bEditCustomers;
        public RComboBox cbAccept;
        public RNumericUpDown tbQUANTITY;
        public DateTimePicker dtpPTIME;
        public DateTimePicker dtpCREATED;
        public RComboBox cbSISP;
        public RComboBox cbCustomers;
        public TextBox tbDELIVERY;
        public TextBox tbSHIPPING;
        public TextBox tbPayStatus;
        public TextBox tbBillNumber;
        public TextBox tbCONTRACT;
        private Label label13;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label23;
        private Label label9;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label15;
        private Label label17;
        private Label label2;
        public SummonManager.Controls.PathField pfPACKINGLIST;
        public SummonManager.Controls.PathField pfMANUAL;
        public SummonManager.Controls.PathField pfPASSPORT;
        private Label label30;
        private Label label29;
        private Label label28;
        private Button bRemarks;
        public SummonNotes summonNotes1;
        private Label label31;
        private Label label27;
        private Label label26;
        private Label label25;
        private Label label24;
    }
}