namespace SummonManager
{
    partial class fSearchResults
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
            this.dgSummon = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.ContMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.просмотрИРедактированиеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.печатьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.просмотрИсторииСтатусовToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgSummon)).BeginInit();
            this.ContMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgSummon
            // 
            this.dgSummon.AllowUserToAddRows = false;
            this.dgSummon.AllowUserToDeleteRows = false;
            this.dgSummon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgSummon.Location = new System.Drawing.Point(5, 13);
            this.dgSummon.Margin = new System.Windows.Forms.Padding(4);
            this.dgSummon.MultiSelect = false;
            this.dgSummon.Name = "dgSummon";
            this.dgSummon.ReadOnly = true;
            this.dgSummon.RowHeadersVisible = false;
            this.dgSummon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgSummon.Size = new System.Drawing.Size(1255, 636);
            this.dgSummon.TabIndex = 4;
            this.dgSummon.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgSummon_ColumnHeaderMouseClick);
            this.dgSummon.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgSummon_CellMouseDown);
            this.dgSummon.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgSummon_CellMouseDoubleClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1127, 656);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 33);
            this.button1.TabIndex = 5;
            this.button1.Text = "Закрыть";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(926, 656);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(195, 33);
            this.button2.TabIndex = 6;
            this.button2.Text = "Изменить условия поиска";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ContMenu
            // 
            this.ContMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.просмотрИРедактированиеToolStripMenuItem,
            this.печатьToolStripMenuItem1,
            this.просмотрИсторииСтатусовToolStripMenuItem});
            this.ContMenu.Name = "ContMenu";
            this.ContMenu.Size = new System.Drawing.Size(234, 70);
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
            // fSearchResults
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 695);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgSummon);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "fSearchResults";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Результаты поиска";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fSearchResults_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dgSummon)).EndInit();
            this.ContMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgSummon;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ContextMenuStrip ContMenu;
        private System.Windows.Forms.ToolStripMenuItem просмотрИРедактированиеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem печатьToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem просмотрИсторииСтатусовToolStripMenuItem;
    }
}