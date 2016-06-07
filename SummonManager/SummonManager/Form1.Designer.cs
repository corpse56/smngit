namespace SummonManager
{
    partial class MainF
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainF));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.извещениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NewMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ViewEditMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FinishedMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HistoryMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SearchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PrintMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.обновитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сервисToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справочникиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.заказчикиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.пользователиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.наименованиеИзделияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.упаковкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.статистикаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.общаяПродолжительностьПребыванияИзвещенияПоОтделамToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.настройкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сменитьПользователяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.помощьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.историяВерсийToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.viewedittoolStripButton = new System.Windows.Forms.ToolStripButton();
            this.FinishedtoolStripButton = new System.Windows.Forms.ToolStripButton();
            this.HistorytoolStripButton = new System.Windows.Forms.ToolStripButton();
            this.PrinttoolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.MySummonsTSB = new System.Windows.Forms.ToolStripButton();
            this.tsbWorkPart = new System.Windows.Forms.ToolStripButton();
            this.tsbRemark = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.TStbs = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tslVersionLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.dgSummon = new System.Windows.Forms.DataGridView();
            this.ContMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.просмотрИРедактированиеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.печатьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.просмотрИсторииСтатусовToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьТТToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.bkwReloadData = new System.ComponentModel.BackgroundWorker();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgSummon)).BeginInit();
            this.ContMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.извещениеToolStripMenuItem,
            this.сервисToolStripMenuItem,
            this.помощьToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1264, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // извещениеToolStripMenuItem
            // 
            this.извещениеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewMenuItem,
            this.ViewEditMenuItem,
            this.FinishedMenuItem,
            this.HistoryMenuItem,
            this.SearchToolStripMenuItem,
            this.PrintMenuItem,
            this.обновитьToolStripMenuItem,
            this.toolStripSeparator1,
            this.выходToolStripMenuItem});
            this.извещениеToolStripMenuItem.Name = "извещениеToolStripMenuItem";
            this.извещениеToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.извещениеToolStripMenuItem.Text = "Извещение";
            // 
            // NewMenuItem
            // 
            this.NewMenuItem.Image = global::SummonManager.Properties.Resources.document_new;
            this.NewMenuItem.Name = "NewMenuItem";
            this.NewMenuItem.Size = new System.Drawing.Size(233, 22);
            this.NewMenuItem.Text = "Новое";
            this.NewMenuItem.Click += new System.EventHandler(this.NewMenuItem_Click);
            // 
            // ViewEditMenuItem
            // 
            this.ViewEditMenuItem.Image = global::SummonManager.Properties.Resources.old_edit_find_3642;
            this.ViewEditMenuItem.Name = "ViewEditMenuItem";
            this.ViewEditMenuItem.Size = new System.Drawing.Size(233, 22);
            this.ViewEditMenuItem.Text = "Просмотр и редактирование";
            this.ViewEditMenuItem.Click += new System.EventHandler(this.ViewEditMenuItem_Click);
            // 
            // FinishedMenuItem
            // 
            this.FinishedMenuItem.Image = global::SummonManager.Properties.Resources.endturn_9113;
            this.FinishedMenuItem.Name = "FinishedMenuItem";
            this.FinishedMenuItem.Size = new System.Drawing.Size(233, 22);
            this.FinishedMenuItem.Text = "Просмотр завершенных";
            this.FinishedMenuItem.Click += new System.EventHandler(this.FinishedMenuItem_Click);
            // 
            // HistoryMenuItem
            // 
            this.HistoryMenuItem.Image = global::SummonManager.Properties.Resources.history_3610;
            this.HistoryMenuItem.Name = "HistoryMenuItem";
            this.HistoryMenuItem.Size = new System.Drawing.Size(233, 22);
            this.HistoryMenuItem.Text = "Просмотр истории статусов";
            this.HistoryMenuItem.Click += new System.EventHandler(this.HistoryMenuItem_Click);
            // 
            // SearchToolStripMenuItem
            // 
            this.SearchToolStripMenuItem.Image = global::SummonManager.Properties.Resources.binoculars_8272;
            this.SearchToolStripMenuItem.Name = "SearchToolStripMenuItem";
            this.SearchToolStripMenuItem.Size = new System.Drawing.Size(233, 22);
            this.SearchToolStripMenuItem.Text = "Поиск...";
            this.SearchToolStripMenuItem.Click += new System.EventHandler(this.SearchToolStripMenuItem_Click);
            // 
            // PrintMenuItem
            // 
            this.PrintMenuItem.Image = global::SummonManager.Properties.Resources.fileprint_7424;
            this.PrintMenuItem.Name = "PrintMenuItem";
            this.PrintMenuItem.Size = new System.Drawing.Size(233, 22);
            this.PrintMenuItem.Text = "Печать";
            this.PrintMenuItem.Click += new System.EventHandler(this.PrintMenuItem_Click);
            // 
            // обновитьToolStripMenuItem
            // 
            this.обновитьToolStripMenuItem.Image = global::SummonManager.Properties.Resources.Refresh;
            this.обновитьToolStripMenuItem.Name = "обновитьToolStripMenuItem";
            this.обновитьToolStripMenuItem.Size = new System.Drawing.Size(233, 22);
            this.обновитьToolStripMenuItem.Text = "Обновить";
            this.обновитьToolStripMenuItem.ToolTipText = "Обновить";
            this.обновитьToolStripMenuItem.Click += new System.EventHandler(this.RefreshToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(230, 6);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(233, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // сервисToolStripMenuItem
            // 
            this.сервисToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.справочникиToolStripMenuItem,
            this.статистикаToolStripMenuItem,
            this.настройкиToolStripMenuItem,
            this.сменитьПользователяToolStripMenuItem});
            this.сервисToolStripMenuItem.Name = "сервисToolStripMenuItem";
            this.сервисToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.сервисToolStripMenuItem.Text = "Сервис";
            // 
            // справочникиToolStripMenuItem
            // 
            this.справочникиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.заказчикиToolStripMenuItem,
            this.пользователиToolStripMenuItem,
            this.наименованиеИзделияToolStripMenuItem,
            this.упаковкаToolStripMenuItem});
            this.справочникиToolStripMenuItem.Name = "справочникиToolStripMenuItem";
            this.справочникиToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.справочникиToolStripMenuItem.Text = "Справочники";
            // 
            // заказчикиToolStripMenuItem
            // 
            this.заказчикиToolStripMenuItem.Name = "заказчикиToolStripMenuItem";
            this.заказчикиToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.заказчикиToolStripMenuItem.Text = "Заказчики";
            this.заказчикиToolStripMenuItem.Click += new System.EventHandler(this.заказчикиToolStripMenuItem_Click);
            // 
            // пользователиToolStripMenuItem
            // 
            this.пользователиToolStripMenuItem.Name = "пользователиToolStripMenuItem";
            this.пользователиToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.пользователиToolStripMenuItem.Text = "Пользователи";
            this.пользователиToolStripMenuItem.Click += new System.EventHandler(this.пользователиToolStripMenuItem_Click);
            // 
            // наименованиеИзделияToolStripMenuItem
            // 
            this.наименованиеИзделияToolStripMenuItem.Name = "наименованиеИзделияToolStripMenuItem";
            this.наименованиеИзделияToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.наименованиеИзделияToolStripMenuItem.Text = "Изделия";
            this.наименованиеИзделияToolStripMenuItem.Click += new System.EventHandler(this.наименованиеИзделияToolStripMenuItem_Click);
            // 
            // упаковкаToolStripMenuItem
            // 
            this.упаковкаToolStripMenuItem.Name = "упаковкаToolStripMenuItem";
            this.упаковкаToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.упаковкаToolStripMenuItem.Text = "Упаковка";
            this.упаковкаToolStripMenuItem.Click += new System.EventHandler(this.упаковкаToolStripMenuItem_Click);
            // 
            // статистикаToolStripMenuItem
            // 
            this.статистикаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.общаяПродолжительностьПребыванияИзвещенияПоОтделамToolStripMenuItem});
            this.статистикаToolStripMenuItem.Name = "статистикаToolStripMenuItem";
            this.статистикаToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.статистикаToolStripMenuItem.Text = "Статистика";
            // 
            // общаяПродолжительностьПребыванияИзвещенияПоОтделамToolStripMenuItem
            // 
            this.общаяПродолжительностьПребыванияИзвещенияПоОтделамToolStripMenuItem.Name = "общаяПродолжительностьПребыванияИзвещенияПоОтделамToolStripMenuItem";
            this.общаяПродолжительностьПребыванияИзвещенияПоОтделамToolStripMenuItem.Size = new System.Drawing.Size(429, 22);
            this.общаяПродолжительностьПребыванияИзвещенияПоОтделамToolStripMenuItem.Text = "Общая продолжительность пребывания извещения по отделам";
            this.общаяПродолжительностьПребыванияИзвещенияПоОтделамToolStripMenuItem.Click += new System.EventHandler(this.TimeInDeptToolStripMenuItem_Click);
            // 
            // настройкиToolStripMenuItem
            // 
            this.настройкиToolStripMenuItem.Name = "настройкиToolStripMenuItem";
            this.настройкиToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.настройкиToolStripMenuItem.Text = "Настройки";
            this.настройкиToolStripMenuItem.Click += new System.EventHandler(this.настройкиToolStripMenuItem_Click);
            // 
            // сменитьПользователяToolStripMenuItem
            // 
            this.сменитьПользователяToolStripMenuItem.Name = "сменитьПользователяToolStripMenuItem";
            this.сменитьПользователяToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.сменитьПользователяToolStripMenuItem.Text = "Сменить пользователя";
            this.сменитьПользователяToolStripMenuItem.Click += new System.EventHandler(this.сменитьПользователяToolStripMenuItem_Click);
            // 
            // помощьToolStripMenuItem
            // 
            this.помощьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.оПрограммеToolStripMenuItem,
            this.историяВерсийToolStripMenuItem});
            this.помощьToolStripMenuItem.Name = "помощьToolStripMenuItem";
            this.помощьToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.помощьToolStripMenuItem.Text = "Помощь";
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click);
            // 
            // историяВерсийToolStripMenuItem
            // 
            this.историяВерсийToolStripMenuItem.Name = "историяВерсийToolStripMenuItem";
            this.историяВерсийToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.историяВерсийToolStripMenuItem.Text = "История версий";
            this.историяВерсийToolStripMenuItem.Click += new System.EventHandler(this.историяВерсийToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.toolStrip1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.viewedittoolStripButton,
            this.FinishedtoolStripButton,
            this.HistorytoolStripButton,
            this.PrinttoolStripButton,
            this.toolStripButton2,
            this.toolStripButton3,
            this.MySummonsTSB,
            this.tsbWorkPart,
            this.tsbRemark,
            this.toolStripSeparator2,
            this.toolStripLabel1,
            this.TStbs,
            this.toolStripSeparator3});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1264, 39);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::SummonManager.Properties.Resources.document_new;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(36, 36);
            this.toolStripButton1.Text = "NewtoolStripButton";
            this.toolStripButton1.ToolTipText = "Новое";
            this.toolStripButton1.Click += new System.EventHandler(this.newtoolStripButton);
            // 
            // viewedittoolStripButton
            // 
            this.viewedittoolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.viewedittoolStripButton.Image = global::SummonManager.Properties.Resources.old_edit_find_3642;
            this.viewedittoolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.viewedittoolStripButton.Name = "viewedittoolStripButton";
            this.viewedittoolStripButton.Size = new System.Drawing.Size(36, 36);
            this.viewedittoolStripButton.Text = "toolStripButton2";
            this.viewedittoolStripButton.ToolTipText = "Просмотр и редактирование";
            this.viewedittoolStripButton.Click += new System.EventHandler(this.viewedittoolStripButton_Click);
            // 
            // FinishedtoolStripButton
            // 
            this.FinishedtoolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.FinishedtoolStripButton.Image = global::SummonManager.Properties.Resources.endturn_9113;
            this.FinishedtoolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.FinishedtoolStripButton.Name = "FinishedtoolStripButton";
            this.FinishedtoolStripButton.Size = new System.Drawing.Size(36, 36);
            this.FinishedtoolStripButton.Text = "toolStripButton3";
            this.FinishedtoolStripButton.ToolTipText = "Просмотр завершенных";
            this.FinishedtoolStripButton.Click += new System.EventHandler(this.FinishedtoolStripButton_Click);
            // 
            // HistorytoolStripButton
            // 
            this.HistorytoolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.HistorytoolStripButton.Image = global::SummonManager.Properties.Resources.history_3610;
            this.HistorytoolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.HistorytoolStripButton.Name = "HistorytoolStripButton";
            this.HistorytoolStripButton.Size = new System.Drawing.Size(36, 36);
            this.HistorytoolStripButton.Text = "toolStripButton4";
            this.HistorytoolStripButton.ToolTipText = "Просмотр истории статусов";
            this.HistorytoolStripButton.Click += new System.EventHandler(this.HistorytoolStripButton_Click);
            // 
            // PrinttoolStripButton
            // 
            this.PrinttoolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.PrinttoolStripButton.Image = global::SummonManager.Properties.Resources.fileprint_7424;
            this.PrinttoolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.PrinttoolStripButton.Name = "PrinttoolStripButton";
            this.PrinttoolStripButton.Size = new System.Drawing.Size(36, 36);
            this.PrinttoolStripButton.Text = "toolStripButton5";
            this.PrinttoolStripButton.ToolTipText = "Печать";
            this.PrinttoolStripButton.Click += new System.EventHandler(this.PrinttoolStripButton_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = global::SummonManager.Properties.Resources.binoculars_8272;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(36, 36);
            this.toolStripButton2.Text = "SearchtoolStripButton";
            this.toolStripButton2.ToolTipText = "Поиск";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = global::SummonManager.Properties.Resources.Refresh;
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(36, 36);
            this.toolStripButton3.Text = "RefreshtoolStripButton3";
            this.toolStripButton3.ToolTipText = "Обновить";
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // MySummonsTSB
            // 
            this.MySummonsTSB.CheckOnClick = true;
            this.MySummonsTSB.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.MySummonsTSB.Image = global::SummonManager.Properties.Resources._1437084170_emblem_people;
            this.MySummonsTSB.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.MySummonsTSB.Name = "MySummonsTSB";
            this.MySummonsTSB.Size = new System.Drawing.Size(36, 36);
            this.MySummonsTSB.Text = "MySummonsToolStripButton";
            this.MySummonsTSB.ToolTipText = "Мои извещения";
            this.MySummonsTSB.Click += new System.EventHandler(this.MySummonsTSB_Click);
            // 
            // tsbWorkPart
            // 
            this.tsbWorkPart.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbWorkPart.Image = global::SummonManager.Properties.Resources.product;
            this.tsbWorkPart.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbWorkPart.Name = "tsbWorkPart";
            this.tsbWorkPart.Size = new System.Drawing.Size(36, 36);
            this.tsbWorkPart.Text = "Изделия";
            this.tsbWorkPart.Click += new System.EventHandler(this.tsbWorkPart_Click);
            // 
            // tsbRemark
            // 
            this.tsbRemark.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbRemark.Image = global::SummonManager.Properties.Resources.exclamation_form1;
            this.tsbRemark.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbRemark.Name = "tsbRemark";
            this.tsbRemark.Size = new System.Drawing.Size(36, 36);
            this.tsbRemark.Text = "Система замечаний";
            this.tsbRemark.Click += new System.EventHandler(this.tsbRemark_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 39);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(198, 36);
            this.toolStripLabel1.Text = "Фильтр по наименованию:";
            // 
            // TStbs
            // 
            this.TStbs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TStbs.Name = "TStbs";
            this.TStbs.Size = new System.Drawing.Size(150, 39);
            this.TStbs.TextChanged += new System.EventHandler(this.TStbs_TextChanged);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 39);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslVersionLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 613);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1264, 22);
            this.statusStrip1.TabIndex = 2;
            // 
            // tslVersionLabel
            // 
            this.tslVersionLabel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tslVersionLabel.Name = "tslVersionLabel";
            this.tslVersionLabel.Size = new System.Drawing.Size(1249, 17);
            this.tslVersionLabel.Spring = true;
            this.tslVersionLabel.Text = "v";
            this.tslVersionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tslVersionLabel.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            // 
            // dgSummon
            // 
            this.dgSummon.AllowUserToAddRows = false;
            this.dgSummon.AllowUserToDeleteRows = false;
            this.dgSummon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgSummon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgSummon.Location = new System.Drawing.Point(0, 63);
            this.dgSummon.MultiSelect = false;
            this.dgSummon.Name = "dgSummon";
            this.dgSummon.ReadOnly = true;
            this.dgSummon.RowHeadersVisible = false;
            this.dgSummon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgSummon.Size = new System.Drawing.Size(1264, 550);
            this.dgSummon.TabIndex = 3;
            this.dgSummon.SortCompare += new System.Windows.Forms.DataGridViewSortCompareEventHandler(this.dgSummon_SortCompare);
            this.dgSummon.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgSummon_ColumnHeaderMouseClick);
            this.dgSummon.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgSummon_CellMouseDown);
            this.dgSummon.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgSummon_CellMouseDoubleClick);
            this.dgSummon.SelectionChanged += new System.EventHandler(this.dgSummon_SelectionChanged);
            // 
            // ContMenu
            // 
            this.ContMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.просмотрИРедактированиеToolStripMenuItem,
            this.печатьToolStripMenuItem1,
            this.просмотрИсторииСтатусовToolStripMenuItem,
            this.открытьТТToolStripMenuItem});
            this.ContMenu.Name = "ContMenu";
            this.ContMenu.Size = new System.Drawing.Size(234, 92);
            // 
            // просмотрИРедактированиеToolStripMenuItem
            // 
            this.просмотрИРедактированиеToolStripMenuItem.Name = "просмотрИРедактированиеToolStripMenuItem";
            this.просмотрИРедактированиеToolStripMenuItem.Size = new System.Drawing.Size(233, 22);
            this.просмотрИРедактированиеToolStripMenuItem.Text = "Просмотр и редактирование";
            this.просмотрИРедактированиеToolStripMenuItem.Click += new System.EventHandler(this.просмотрИРедактированиеToolStripMenuItem_Click);
            // 
            // печатьToolStripMenuItem1
            // 
            this.печатьToolStripMenuItem1.Name = "печатьToolStripMenuItem1";
            this.печатьToolStripMenuItem1.Size = new System.Drawing.Size(233, 22);
            this.печатьToolStripMenuItem1.Text = "Печать";
            this.печатьToolStripMenuItem1.Click += new System.EventHandler(this.печатьToolStripMenuItem1_Click);
            // 
            // просмотрИсторииСтатусовToolStripMenuItem
            // 
            this.просмотрИсторииСтатусовToolStripMenuItem.Name = "просмотрИсторииСтатусовToolStripMenuItem";
            this.просмотрИсторииСтатусовToolStripMenuItem.Size = new System.Drawing.Size(233, 22);
            this.просмотрИсторииСтатусовToolStripMenuItem.Text = "Просмотр истории статусов";
            this.просмотрИсторииСтатусовToolStripMenuItem.Click += new System.EventHandler(this.просмотрИсторииСтатусовToolStripMenuItem_Click);
            // 
            // открытьТТToolStripMenuItem
            // 
            this.открытьТТToolStripMenuItem.Name = "открытьТТToolStripMenuItem";
            this.открытьТТToolStripMenuItem.Size = new System.Drawing.Size(233, 22);
            this.открытьТТToolStripMenuItem.Text = "Открыть ТТ";
            this.открытьТТToolStripMenuItem.Click += new System.EventHandler(this.открытьТТToolStripMenuItem_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Менеджер извещений";
            this.notifyIcon1.BalloonTipClicked += new System.EventHandler(this.notifyIcon1_BalloonTipClicked);
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 300000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 3600000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // bkwReloadData
            // 
            this.bkwReloadData.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bkwReloadData_DoWork);
            // 
            // MainF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 635);
            this.Controls.Add(this.dgSummon);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainF";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Менеджер извещений";
            this.Load += new System.EventHandler(this.Main_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.Resize += new System.EventHandler(this.Main_Resize);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgSummon)).EndInit();
            this.ContMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem извещениеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem NewMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.DataGridView dgSummon;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem сервисToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справочникиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem заказчикиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem пользователиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ViewEditMenuItem;
        private System.Windows.Forms.ToolStripMenuItem FinishedMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HistoryMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PrintMenuItem;
        private System.Windows.Forms.ToolStripMenuItem наименованиеИзделияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem упаковкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem помощьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip ContMenu;
        private System.Windows.Forms.ToolStripMenuItem просмотрИРедактированиеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem печатьToolStripMenuItem1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton viewedittoolStripButton;
        private System.Windows.Forms.ToolStripButton FinishedtoolStripButton;
        private System.Windows.Forms.ToolStripButton HistorytoolStripButton;
        private System.Windows.Forms.ToolStripButton PrinttoolStripButton;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ToolStripMenuItem просмотрИсторииСтатусовToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripMenuItem SearchToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripMenuItem обновитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem статистикаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem общаяПродолжительностьПребыванияИзвещенияПоОтделамToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripStatusLabel tslVersionLabel;
        private System.Windows.Forms.ToolStripMenuItem настройкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сменитьПользователяToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton MySummonsTSB;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripTextBox TStbs;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.ToolStripMenuItem историяВерсийToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьТТToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton tsbWorkPart;
        private System.ComponentModel.BackgroundWorker bkwReloadData;
        private System.Windows.Forms.ToolStripButton tsbRemark;
    }
}

