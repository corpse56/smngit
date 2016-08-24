namespace SummonManager
{
    partial class SummonsOnProduct
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
            this.dgSummOnProd = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgSummOnProd)).BeginInit();
            this.SuspendLayout();
            // 
            // dgSummOnProd
            // 
            this.dgSummOnProd.AllowUserToAddRows = false;
            this.dgSummOnProd.AllowUserToDeleteRows = false;
            this.dgSummOnProd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgSummOnProd.Location = new System.Drawing.Point(12, 12);
            this.dgSummOnProd.MultiSelect = false;
            this.dgSummOnProd.Name = "dgSummOnProd";
            this.dgSummOnProd.ReadOnly = true;
            this.dgSummOnProd.RowHeadersVisible = false;
            this.dgSummOnProd.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgSummOnProd.Size = new System.Drawing.Size(459, 455);
            this.dgSummOnProd.TabIndex = 0;
            this.dgSummOnProd.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgSummOnProd_CellMouseDoubleClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(396, 473);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Закрыть";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(184, 473);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(206, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Просмотр/редактирование";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // SummonsOnProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 508);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgSummOnProd);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "SummonsOnProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Список извещений по изделию:";
            ((System.ComponentModel.ISupportInitialize)(this.dgSummOnProd)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgSummOnProd;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}