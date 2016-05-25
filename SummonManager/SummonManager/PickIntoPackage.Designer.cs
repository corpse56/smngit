namespace SummonManager
{
    partial class PickIntoPackage
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
            this.bClose = new System.Windows.Forms.Button();
            this.cbCAT = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bArchive = new System.Windows.Forms.Button();
            this.bArcShow = new System.Windows.Forms.Button();
            this.bChoose = new System.Windows.Forms.Button();
            this.cbSubCat = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgWP = new System.Windows.Forms.DataGridView();
            this.bview = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dgWP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // bClose
            // 
            this.bClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bClose.Location = new System.Drawing.Point(1126, 456);
            this.bClose.Name = "bClose";
            this.bClose.Size = new System.Drawing.Size(75, 23);
            this.bClose.TabIndex = 1;
            this.bClose.Text = "Закрыть";
            this.bClose.UseVisualStyleBackColor = true;
            this.bClose.Click += new System.EventHandler(this.bClose_Click);
            // 
            // cbCAT
            // 
            this.cbCAT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCAT.FormattingEnabled = true;
            this.cbCAT.Location = new System.Drawing.Point(192, 12);
            this.cbCAT.Name = "cbCAT";
            this.cbCAT.Size = new System.Drawing.Size(291, 24);
            this.cbCAT.TabIndex = 4;
            this.cbCAT.SelectedIndexChanged += new System.EventHandler(this.cbCAT_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Выберите категорию";
            // 
            // bArchive
            // 
            this.bArchive.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bArchive.Location = new System.Drawing.Point(939, 244);
            this.bArchive.Name = "bArchive";
            this.bArchive.Size = new System.Drawing.Size(40, 23);
            this.bArchive.TabIndex = 6;
            this.bArchive.Text = "Архивировать состав изделия";
            this.bArchive.UseVisualStyleBackColor = true;
            this.bArchive.Visible = false;
            // 
            // bArcShow
            // 
            this.bArcShow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bArcShow.Location = new System.Drawing.Point(985, 244);
            this.bArcShow.Name = "bArcShow";
            this.bArcShow.Size = new System.Drawing.Size(36, 23);
            this.bArcShow.TabIndex = 7;
            this.bArcShow.Text = "Показать архив составов изделия";
            this.bArcShow.UseVisualStyleBackColor = true;
            this.bArcShow.Visible = false;
            // 
            // bChoose
            // 
            this.bChoose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bChoose.Location = new System.Drawing.Point(1043, 456);
            this.bChoose.Name = "bChoose";
            this.bChoose.Size = new System.Drawing.Size(77, 23);
            this.bChoose.TabIndex = 9;
            this.bChoose.Text = "Выбрать";
            this.bChoose.UseVisualStyleBackColor = true;
            this.bChoose.Click += new System.EventHandler(this.bChoose_Click);
            // 
            // cbSubCat
            // 
            this.cbSubCat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSubCat.FormattingEnabled = true;
            this.cbSubCat.Location = new System.Drawing.Point(192, 49);
            this.cbSubCat.Name = "cbSubCat";
            this.cbSubCat.Size = new System.Drawing.Size(291, 24);
            this.cbSubCat.TabIndex = 4;
            this.cbSubCat.SelectedIndexChanged += new System.EventHandler(this.cbSubCat_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Выберите подкатегорию";
            // 
            // dgWP
            // 
            this.dgWP.AllowUserToAddRows = false;
            this.dgWP.AllowUserToDeleteRows = false;
            this.dgWP.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgWP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgWP.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgWP.Location = new System.Drawing.Point(15, 79);
            this.dgWP.MultiSelect = false;
            this.dgWP.Name = "dgWP";
            this.dgWP.RowHeadersVisible = false;
            this.dgWP.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgWP.Size = new System.Drawing.Size(1186, 371);
            this.dgWP.TabIndex = 12;
            this.dgWP.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgWP_CellDoubleClick);
            // 
            // bview
            // 
            this.bview.Location = new System.Drawing.Point(15, 456);
            this.bview.Name = "bview";
            this.bview.Size = new System.Drawing.Size(87, 23);
            this.bview.TabIndex = 13;
            this.bview.Text = "Просмотр";
            this.bview.UseVisualStyleBackColor = true;
            this.bview.Click += new System.EventHandler(this.bview_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(431, 459);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(228, 16);
            this.label3.TabIndex = 14;
            this.label3.Text = "Укажите количество в комплекте";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(665, 456);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(73, 22);
            this.numericUpDown1.TabIndex = 15;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // PickIntoPackage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1213, 483);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bview);
            this.Controls.Add(this.dgWP);
            this.Controls.Add(this.bChoose);
            this.Controls.Add(this.bArcShow);
            this.Controls.Add(this.bArchive);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbSubCat);
            this.Controls.Add(this.cbCAT);
            this.Controls.Add(this.bClose);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PickIntoPackage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Выбор для комплекта";
            this.Load += new System.EventHandler(this.WPName_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgWP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bClose;
        private System.Windows.Forms.ComboBox cbCAT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bArchive;
        private System.Windows.Forms.Button bArcShow;
        private System.Windows.Forms.Button bChoose;
        private System.Windows.Forms.ComboBox cbSubCat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgWP;
        private System.Windows.Forms.Button bview;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
    }
}