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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Remarks));
            this.dgWP = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.bWPWork = new System.Windows.Forms.Button();
            this.dgSumm = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.bSummWork = new System.Windows.Forms.Button();
            this.bGoToWP = new System.Windows.Forms.Button();
            this.bGoToSummon = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgWP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgSumm)).BeginInit();
            this.SuspendLayout();
            // 
            // dgWP
            // 
            this.dgWP.AllowUserToAddRows = false;
            this.dgWP.AllowUserToDeleteRows = false;
            this.dgWP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgWP.Location = new System.Drawing.Point(12, 32);
            this.dgWP.MultiSelect = false;
            this.dgWP.Name = "dgWP";
            this.dgWP.ReadOnly = true;
            this.dgWP.RowHeadersVisible = false;
            this.dgWP.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgWP.Size = new System.Drawing.Size(1097, 297);
            this.dgWP.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1034, 719);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Выход";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // bWPWork
            // 
            this.bWPWork.Location = new System.Drawing.Point(15, 335);
            this.bWPWork.Name = "bWPWork";
            this.bWPWork.Size = new System.Drawing.Size(254, 23);
            this.bWPWork.TabIndex = 2;
            this.bWPWork.Text = "Отработать замечание к изделию";
            this.bWPWork.UseVisualStyleBackColor = true;
            this.bWPWork.Click += new System.EventHandler(this.bWPWork_Click);
            // 
            // dgSumm
            // 
            this.dgSumm.AllowUserToAddRows = false;
            this.dgSumm.AllowUserToDeleteRows = false;
            this.dgSumm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgSumm.Location = new System.Drawing.Point(9, 409);
            this.dgSumm.MultiSelect = false;
            this.dgSumm.Name = "dgSumm";
            this.dgSumm.ReadOnly = true;
            this.dgSumm.RowHeadersVisible = false;
            this.dgSumm.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgSumm.Size = new System.Drawing.Size(1100, 304);
            this.dgSumm.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 361);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1093, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Замечания к изделиям";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 390);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(197, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Замечания к извещениям";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(13, 371);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(1093, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = resources.GetString("label4.Text");
            // 
            // bSummWork
            // 
            this.bSummWork.Location = new System.Drawing.Point(8, 719);
            this.bSummWork.Name = "bSummWork";
            this.bSummWork.Size = new System.Drawing.Size(261, 23);
            this.bSummWork.TabIndex = 9;
            this.bSummWork.Text = "Отработать замечание к извещению";
            this.bSummWork.UseVisualStyleBackColor = true;
            this.bSummWork.Click += new System.EventHandler(this.bSummWork_Click);
            // 
            // bGoToWP
            // 
            this.bGoToWP.Location = new System.Drawing.Point(275, 335);
            this.bGoToWP.Name = "bGoToWP";
            this.bGoToWP.Size = new System.Drawing.Size(150, 23);
            this.bGoToWP.TabIndex = 10;
            this.bGoToWP.Text = "Перейти к изделию";
            this.bGoToWP.UseVisualStyleBackColor = true;
            this.bGoToWP.Click += new System.EventHandler(this.bGoToWP_Click);
            // 
            // bGoToSummon
            // 
            this.bGoToSummon.Location = new System.Drawing.Point(275, 719);
            this.bGoToSummon.Name = "bGoToSummon";
            this.bGoToSummon.Size = new System.Drawing.Size(163, 23);
            this.bGoToSummon.TabIndex = 11;
            this.bGoToSummon.Text = "Перейти к извещению";
            this.bGoToSummon.UseVisualStyleBackColor = true;
            this.bGoToSummon.Click += new System.EventHandler(this.bGoToSummon_Click);
            // 
            // Remarks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1121, 747);
            this.Controls.Add(this.bGoToSummon);
            this.Controls.Add(this.bGoToWP);
            this.Controls.Add(this.bSummWork);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgSumm);
            this.Controls.Add(this.bWPWork);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgWP);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Remarks";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Замечания";
            this.Load += new System.EventHandler(this.Remarks_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgWP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgSumm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgWP;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button bWPWork;
        private System.Windows.Forms.DataGridView dgSumm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button bSummWork;
        private System.Windows.Forms.Button bGoToWP;
        private System.Windows.Forms.Button bGoToSummon;
    }
}