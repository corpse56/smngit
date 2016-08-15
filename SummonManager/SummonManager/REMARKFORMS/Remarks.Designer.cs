namespace SummonManager
{
    partial class Remarks
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
            this.rbFinishedRemarks = new System.Windows.Forms.RadioButton();
            this.rbAllRemarks = new System.Windows.Forms.RadioButton();
            this.rbMyRemarks = new System.Windows.Forms.RadioButton();
            this.bGoToWP = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.bWPWork = new System.Windows.Forms.Button();
            this.dgWP = new System.Windows.Forms.DataGridView();
            this.bGoToSummon = new System.Windows.Forms.Button();
            this.bSummonWork = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.bSummWork = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dgSumm = new System.Windows.Forms.DataGridView();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgWP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgSumm)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.rbFinishedRemarks);
            this.splitContainer1.Panel1.Controls.Add(this.rbAllRemarks);
            this.splitContainer1.Panel1.Controls.Add(this.rbMyRemarks);
            this.splitContainer1.Panel1.Controls.Add(this.bGoToWP);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.bWPWork);
            this.splitContainer1.Panel1.Controls.Add(this.dgWP);
            this.splitContainer1.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.bGoToSummon);
            this.splitContainer1.Panel2.Controls.Add(this.bSummonWork);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Panel2.Controls.Add(this.bSummWork);
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Panel2.Controls.Add(this.dgSumm);
            this.splitContainer1.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.splitContainer1.Size = new System.Drawing.Size(1121, 747);
            this.splitContainer1.SplitterDistance = 373;
            this.splitContainer1.TabIndex = 12;
            // 
            // rbFinishedRemarks
            // 
            this.rbFinishedRemarks.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rbFinishedRemarks.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbFinishedRemarks.AutoSize = true;
            this.rbFinishedRemarks.Location = new System.Drawing.Point(928, 4);
            this.rbFinishedRemarks.Name = "rbFinishedRemarks";
            this.rbFinishedRemarks.Size = new System.Drawing.Size(179, 26);
            this.rbFinishedRemarks.TabIndex = 16;
            this.rbFinishedRemarks.Text = "Показать отработанные";
            this.rbFinishedRemarks.UseVisualStyleBackColor = true;
            this.rbFinishedRemarks.CheckedChanged += new System.EventHandler(this.rbFinishedRemarks_CheckedChanged);
            // 
            // rbAllRemarks
            // 
            this.rbAllRemarks.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rbAllRemarks.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbAllRemarks.AutoSize = true;
            this.rbAllRemarks.Location = new System.Drawing.Point(815, 4);
            this.rbAllRemarks.Name = "rbAllRemarks";
            this.rbAllRemarks.Size = new System.Drawing.Size(107, 26);
            this.rbAllRemarks.TabIndex = 16;
            this.rbAllRemarks.Text = "Показать все";
            this.rbAllRemarks.UseVisualStyleBackColor = true;
            this.rbAllRemarks.CheckedChanged += new System.EventHandler(this.rbAllRemarks_CheckedChanged);
            // 
            // rbMyRemarks
            // 
            this.rbMyRemarks.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rbMyRemarks.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbMyRemarks.AutoSize = true;
            this.rbMyRemarks.Checked = true;
            this.rbMyRemarks.Location = new System.Drawing.Point(700, 4);
            this.rbMyRemarks.Name = "rbMyRemarks";
            this.rbMyRemarks.Size = new System.Drawing.Size(109, 26);
            this.rbMyRemarks.TabIndex = 16;
            this.rbMyRemarks.TabStop = true;
            this.rbMyRemarks.Text = "Показать мои";
            this.rbMyRemarks.UseVisualStyleBackColor = true;
            this.rbMyRemarks.CheckedChanged += new System.EventHandler(this.rbMyRemarks_CheckedChanged);
            // 
            // bGoToWP
            // 
            this.bGoToWP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bGoToWP.Location = new System.Drawing.Point(275, 345);
            this.bGoToWP.Name = "bGoToWP";
            this.bGoToWP.Size = new System.Drawing.Size(150, 23);
            this.bGoToWP.TabIndex = 14;
            this.bGoToWP.Text = "Перейти к изделию";
            this.bGoToWP.UseVisualStyleBackColor = true;
            this.bGoToWP.Click += new System.EventHandler(this.bGoToWP_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "Замечания к изделиям";
            // 
            // bWPWork
            // 
            this.bWPWork.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bWPWork.Location = new System.Drawing.Point(15, 345);
            this.bWPWork.Name = "bWPWork";
            this.bWPWork.Size = new System.Drawing.Size(254, 23);
            this.bWPWork.TabIndex = 12;
            this.bWPWork.Text = "Отработать замечание к изделию";
            this.bWPWork.UseVisualStyleBackColor = true;
            this.bWPWork.Click += new System.EventHandler(this.bWPWork_Click);
            // 
            // dgWP
            // 
            this.dgWP.AllowUserToAddRows = false;
            this.dgWP.AllowUserToDeleteRows = false;
            this.dgWP.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgWP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgWP.Location = new System.Drawing.Point(15, 36);
            this.dgWP.MultiSelect = false;
            this.dgWP.Name = "dgWP";
            this.dgWP.ReadOnly = true;
            this.dgWP.RowHeadersVisible = false;
            this.dgWP.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgWP.Size = new System.Drawing.Size(1092, 303);
            this.dgWP.TabIndex = 11;
            // 
            // bGoToSummon
            // 
            this.bGoToSummon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bGoToSummon.Location = new System.Drawing.Point(282, 338);
            this.bGoToSummon.Name = "bGoToSummon";
            this.bGoToSummon.Size = new System.Drawing.Size(163, 23);
            this.bGoToSummon.TabIndex = 19;
            this.bGoToSummon.Text = "Перейти к извещению";
            this.bGoToSummon.UseVisualStyleBackColor = true;
            this.bGoToSummon.Click += new System.EventHandler(this.bGoToSummon_Click);
            // 
            // bSummonWork
            // 
            this.bSummonWork.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bSummonWork.Location = new System.Drawing.Point(15, 338);
            this.bSummonWork.Name = "bSummonWork";
            this.bSummonWork.Size = new System.Drawing.Size(261, 23);
            this.bSummonWork.TabIndex = 18;
            this.bSummonWork.Text = "Отработать замечание к извещению";
            this.bSummonWork.UseVisualStyleBackColor = true;
            this.bSummonWork.Click += new System.EventHandler(this.bSummWork_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 16);
            this.label1.TabIndex = 17;
            this.label1.Text = "Замечания к извещениям";
            // 
            // bSummWork
            // 
            this.bSummWork.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bSummWork.Location = new System.Drawing.Point(130, 369);
            this.bSummWork.Name = "bSummWork";
            this.bSummWork.Size = new System.Drawing.Size(261, 23);
            this.bSummWork.TabIndex = 14;
            this.bSummWork.Text = "Отработать замечание к извещению";
            this.bSummWork.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(134, -25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(197, 16);
            this.label3.TabIndex = 13;
            this.label3.Text = "Замечания к извещениям";
            // 
            // dgSumm
            // 
            this.dgSumm.AllowUserToAddRows = false;
            this.dgSumm.AllowUserToDeleteRows = false;
            this.dgSumm.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgSumm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgSumm.Location = new System.Drawing.Point(15, 30);
            this.dgSumm.MultiSelect = false;
            this.dgSumm.Name = "dgSumm";
            this.dgSumm.ReadOnly = true;
            this.dgSumm.RowHeadersVisible = false;
            this.dgSumm.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgSumm.Size = new System.Drawing.Size(1092, 302);
            this.dgSumm.TabIndex = 12;
            // 
            // Remarks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1121, 747);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Remarks";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Замечания";
            this.Load += new System.EventHandler(this.Remarks_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgWP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgSumm)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button bGoToWP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bWPWork;
        private System.Windows.Forms.DataGridView dgWP;
        private System.Windows.Forms.Button bSummWork;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgSumm;
        private System.Windows.Forms.Button bGoToSummon;
        private System.Windows.Forms.Button bSummonWork;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbFinishedRemarks;
        private System.Windows.Forms.RadioButton rbAllRemarks;
        private System.Windows.Forms.RadioButton rbMyRemarks;
    }
}