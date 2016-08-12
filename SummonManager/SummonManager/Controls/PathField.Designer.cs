namespace SummonManager.Controls
{
    partial class PathField
    {
        /// <summary> 
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Обязательный метод для поддержки конструктора - не изменяйте 
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.bPathDel = new System.Windows.Forms.Button();
            this.bPath = new System.Windows.Forms.Button();
            this.tbPath = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.copyToClipboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bRemark = new System.Windows.Forms.Button();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.добавитьЕщёОдноЗамечаниеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отработатьСуществующиеЗамечанияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chRequired = new System.Windows.Forms.CheckBox();
            this.contextMenuStrip1.SuspendLayout();
            this.contextMenuStrip2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bPathDel
            // 
            this.bPathDel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.bPathDel.BackgroundImage = global::SummonManager.Properties.Resources.delete_ok;
            this.bPathDel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bPathDel.Location = new System.Drawing.Point(511, 3);
            this.bPathDel.Margin = new System.Windows.Forms.Padding(4);
            this.bPathDel.Name = "bPathDel";
            this.bPathDel.Size = new System.Drawing.Size(31, 25);
            this.bPathDel.TabIndex = 25;
            this.bPathDel.UseVisualStyleBackColor = true;
            this.bPathDel.Click += new System.EventHandler(this.bPathDel_Click);
            // 
            // bPath
            // 
            this.bPath.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.bPath.Location = new System.Drawing.Point(423, 2);
            this.bPath.Margin = new System.Windows.Forms.Padding(4);
            this.bPath.Name = "bPath";
            this.bPath.Size = new System.Drawing.Size(50, 25);
            this.bPath.TabIndex = 23;
            this.bPath.Text = "Путь";
            this.bPath.UseVisualStyleBackColor = true;
            this.bPath.Click += new System.EventHandler(this.bPath_Click);
            // 
            // tbPath
            // 
            this.tbPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPath.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tbPath.ContextMenuStrip = this.contextMenuStrip1;
            this.tbPath.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tbPath.Location = new System.Drawing.Point(34, 3);
            this.tbPath.Name = "tbPath";
            this.tbPath.Size = new System.Drawing.Size(382, 22);
            this.tbPath.TabIndex = 26;
            this.tbPath.TextChanged += new System.EventHandler(this.tbPath_TextChanged);
            this.tbPath.MouseLeave += new System.EventHandler(this.tbPath_MouseLeave);
            this.tbPath.Click += new System.EventHandler(this.tbPath_Click);
            this.tbPath.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tbPath_MouseClick);
            this.tbPath.MouseEnter += new System.EventHandler(this.tbPath_MouseEnter);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyToClipboardToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(266, 26);
            // 
            // copyToClipboardToolStripMenuItem
            // 
            this.copyToClipboardToolStripMenuItem.Name = "copyToClipboardToolStripMenuItem";
            this.copyToClipboardToolStripMenuItem.Size = new System.Drawing.Size(265, 22);
            this.copyToClipboardToolStripMenuItem.Text = "Скопировать путь в буфер обмена";
            this.copyToClipboardToolStripMenuItem.Click += new System.EventHandler(this.copyToClipboardToolStripMenuItem_Click);
            // 
            // bRemark
            // 
            this.bRemark.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.bRemark.BackgroundImage = global::SummonManager.Properties.Resources.remark_reply;
            this.bRemark.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bRemark.Location = new System.Drawing.Point(477, 3);
            this.bRemark.Name = "bRemark";
            this.bRemark.Size = new System.Drawing.Size(31, 25);
            this.bRemark.TabIndex = 28;
            this.bRemark.UseVisualStyleBackColor = true;
            this.bRemark.Click += new System.EventHandler(this.bRemark_Click);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьЕщёОдноЗамечаниеToolStripMenuItem,
            this.отработатьСуществующиеЗамечанияToolStripMenuItem});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(289, 48);
            // 
            // добавитьЕщёОдноЗамечаниеToolStripMenuItem
            // 
            this.добавитьЕщёОдноЗамечаниеToolStripMenuItem.Name = "добавитьЕщёОдноЗамечаниеToolStripMenuItem";
            this.добавитьЕщёОдноЗамечаниеToolStripMenuItem.Size = new System.Drawing.Size(288, 22);
            this.добавитьЕщёОдноЗамечаниеToolStripMenuItem.Text = "Добавить ещё одно замечание";
            this.добавитьЕщёОдноЗамечаниеToolStripMenuItem.Click += new System.EventHandler(this.AddOneMoreRemarkToolStripMenuItem_Click);
            // 
            // отработатьСуществующиеЗамечанияToolStripMenuItem
            // 
            this.отработатьСуществующиеЗамечанияToolStripMenuItem.Name = "отработатьСуществующиеЗамечанияToolStripMenuItem";
            this.отработатьСуществующиеЗамечанияToolStripMenuItem.Size = new System.Drawing.Size(288, 22);
            this.отработатьСуществующиеЗамечанияToolStripMenuItem.Text = "Отработать существующие замечания";
            this.отработатьСуществующиеЗамечанияToolStripMenuItem.Click += new System.EventHandler(this.WorkExistingRemarkToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Fuchsia;
            this.panel1.Controls.Add(this.chRequired);
            this.panel1.Location = new System.Drawing.Point(4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(24, 21);
            this.panel1.TabIndex = 29;
            // 
            // chRequired
            // 
            this.chRequired.AutoSize = true;
            this.chRequired.Location = new System.Drawing.Point(5, 3);
            this.chRequired.Name = "chRequired";
            this.chRequired.Size = new System.Drawing.Size(15, 14);
            this.chRequired.TabIndex = 28;
            this.chRequired.UseVisualStyleBackColor = true;
            // 
            // PathField
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tbPath);
            this.Controls.Add(this.bRemark);
            this.Controls.Add(this.bPathDel);
            this.Controls.Add(this.bPath);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PathField";
            this.Size = new System.Drawing.Size(546, 28);
            this.contextMenuStrip1.ResumeLayout(false);
            this.contextMenuStrip2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button bPathDel;
        public System.Windows.Forms.Button bPath;
        public System.Windows.Forms.TextBox tbPath;
        public System.Windows.Forms.Button bRemark;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem copyToClipboardToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem добавитьЕщёОдноЗамечаниеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отработатьСуществующиеЗамечанияToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox chRequired;


    }
}
