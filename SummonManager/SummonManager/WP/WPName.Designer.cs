namespace SummonManager
{
    partial class WPName
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
            this.bAdd = new System.Windows.Forms.Button();
            this.bEdit = new System.Windows.Forms.Button();
            this.bClone = new System.Windows.Forms.Button();
            this.bDelete = new System.Windows.Forms.Button();
            this.cbCAT = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bEditCategory = new System.Windows.Forms.Button();
            this.bChoose = new System.Windows.Forms.Button();
            this.cbSubCat = new System.Windows.Forms.ComboBox();
            this.bEditSubCategory = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.bView = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dgWP = new System.Windows.Forms.DataGridView();
            this.bSummonsOnProduct = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbFilter = new System.Windows.Forms.ComboBox();
            this.tbFilter = new System.Windows.Forms.TextBox();
            this.cbPRODUCTTYPE = new SummonManager.RComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgWP)).BeginInit();
            this.groupBox1.SuspendLayout();
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
            // bAdd
            // 
            this.bAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bAdd.Location = new System.Drawing.Point(12, 456);
            this.bAdd.Name = "bAdd";
            this.bAdd.Size = new System.Drawing.Size(86, 23);
            this.bAdd.TabIndex = 1;
            this.bAdd.Text = "Добавить";
            this.bAdd.UseVisualStyleBackColor = true;
            this.bAdd.Click += new System.EventHandler(this.bAdd_Click);
            // 
            // bEdit
            // 
            this.bEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bEdit.Location = new System.Drawing.Point(218, 456);
            this.bEdit.Name = "bEdit";
            this.bEdit.Size = new System.Drawing.Size(88, 23);
            this.bEdit.TabIndex = 1;
            this.bEdit.Text = "Изменить";
            this.bEdit.UseVisualStyleBackColor = true;
            this.bEdit.Click += new System.EventHandler(this.bEdit_Click);
            // 
            // bClone
            // 
            this.bClone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bClone.Location = new System.Drawing.Point(104, 456);
            this.bClone.Name = "bClone";
            this.bClone.Size = new System.Drawing.Size(108, 23);
            this.bClone.TabIndex = 2;
            this.bClone.Text = "Клонировать";
            this.bClone.UseVisualStyleBackColor = true;
            this.bClone.Click += new System.EventHandler(this.bClone_Click);
            // 
            // bDelete
            // 
            this.bDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bDelete.Location = new System.Drawing.Point(312, 456);
            this.bDelete.Name = "bDelete";
            this.bDelete.Size = new System.Drawing.Size(75, 23);
            this.bDelete.TabIndex = 3;
            this.bDelete.Text = "Удалить";
            this.bDelete.UseVisualStyleBackColor = true;
            this.bDelete.Click += new System.EventHandler(this.bDelete_Click);
            // 
            // cbCAT
            // 
            this.cbCAT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCAT.FormattingEnabled = true;
            this.cbCAT.Location = new System.Drawing.Point(194, 65);
            this.cbCAT.Name = "cbCAT";
            this.cbCAT.Size = new System.Drawing.Size(291, 24);
            this.cbCAT.TabIndex = 4;
            this.cbCAT.SelectedIndexChanged += new System.EventHandler(this.cbCAT_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Выберите категорию";
            // 
            // bEditCategory
            // 
            this.bEditCategory.Location = new System.Drawing.Point(491, 65);
            this.bEditCategory.Name = "bEditCategory";
            this.bEditCategory.Size = new System.Drawing.Size(214, 23);
            this.bEditCategory.TabIndex = 8;
            this.bEditCategory.Text = "Редактировать категории";
            this.bEditCategory.UseVisualStyleBackColor = true;
            this.bEditCategory.Click += new System.EventHandler(this.bEditCategory_Click);
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
            this.cbSubCat.Location = new System.Drawing.Point(194, 102);
            this.cbSubCat.Name = "cbSubCat";
            this.cbSubCat.Size = new System.Drawing.Size(291, 24);
            this.cbSubCat.TabIndex = 4;
            this.cbSubCat.SelectedIndexChanged += new System.EventHandler(this.cbSubCat_SelectedIndexChanged);
            // 
            // bEditSubCategory
            // 
            this.bEditSubCategory.Location = new System.Drawing.Point(491, 105);
            this.bEditSubCategory.Name = "bEditSubCategory";
            this.bEditSubCategory.Size = new System.Drawing.Size(214, 23);
            this.bEditSubCategory.TabIndex = 10;
            this.bEditSubCategory.Text = "Редактировать подкатегории";
            this.bEditSubCategory.UseVisualStyleBackColor = true;
            this.bEditSubCategory.Click += new System.EventHandler(this.bEditSubCategory_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Выберите подкатегорию";
            // 
            // bView
            // 
            this.bView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bView.Location = new System.Drawing.Point(393, 456);
            this.bView.Name = "bView";
            this.bView.Size = new System.Drawing.Size(92, 23);
            this.bView.TabIndex = 11;
            this.bView.Text = "Просмотр";
            this.bView.UseVisualStyleBackColor = true;
            this.bView.Click += new System.EventHandler(this.bView_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Выберите тип продукта";
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
            this.dgWP.Location = new System.Drawing.Point(15, 132);
            this.dgWP.MultiSelect = false;
            this.dgWP.Name = "dgWP";
            this.dgWP.RowHeadersVisible = false;
            this.dgWP.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgWP.Size = new System.Drawing.Size(1186, 318);
            this.dgWP.TabIndex = 12;
            this.dgWP.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgWP_CellDoubleClick);
            // 
            // bSummonsOnProduct
            // 
            this.bSummonsOnProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bSummonsOnProduct.Location = new System.Drawing.Point(491, 456);
            this.bSummonsOnProduct.Name = "bSummonsOnProduct";
            this.bSummonsOnProduct.Size = new System.Drawing.Size(176, 23);
            this.bSummonsOnProduct.TabIndex = 13;
            this.bSummonsOnProduct.Text = "Извещения по изделию";
            this.bSummonsOnProduct.UseVisualStyleBackColor = true;
            this.bSummonsOnProduct.Click += new System.EventHandler(this.bSummonsOnProduct_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.tbFilter);
            this.groupBox1.Controls.Add(this.cbFilter);
            this.groupBox1.Location = new System.Drawing.Point(886, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(315, 77);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Фильтр";
            // 
            // cbFilter
            // 
            this.cbFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilter.FormattingEnabled = true;
            this.cbFilter.Items.AddRange(new object[] {
            "Наименование",
            "Децимальный номер",
            "ТТ"});
            this.cbFilter.Location = new System.Drawing.Point(6, 21);
            this.cbFilter.Name = "cbFilter";
            this.cbFilter.Size = new System.Drawing.Size(303, 24);
            this.cbFilter.TabIndex = 0;
            this.cbFilter.SelectedIndexChanged += new System.EventHandler(this.cbFilter_SelectedIndexChanged);
            // 
            // tbFilter
            // 
            this.tbFilter.Location = new System.Drawing.Point(6, 50);
            this.tbFilter.Name = "tbFilter";
            this.tbFilter.Size = new System.Drawing.Size(303, 22);
            this.tbFilter.TabIndex = 1;
            this.tbFilter.TextChanged += new System.EventHandler(this.tbFilter_TextChanged);
            // 
            // cbPRODUCTTYPE
            // 
            this.cbPRODUCTTYPE.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPRODUCTTYPE.FormattingEnabled = true;
            this.cbPRODUCTTYPE.Items.AddRange(new object[] {
            "РАБОЧЕЕ ИЗДЕЛИЕ",
            "ЖГУТЫ",
            "КАБЕЛИ"});
            this.cbPRODUCTTYPE.Location = new System.Drawing.Point(194, 12);
            this.cbPRODUCTTYPE.Name = "cbPRODUCTTYPE";
            this.cbPRODUCTTYPE.Size = new System.Drawing.Size(291, 24);
            this.cbPRODUCTTYPE.TabIndex = 4;
            this.cbPRODUCTTYPE.SelectedIndexChanged += new System.EventHandler(this.cbPRODUCTTYPE_SelectedIndexChanged);
            // 
            // WPName
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1213, 483);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bSummonsOnProduct);
            this.Controls.Add(this.dgWP);
            this.Controls.Add(this.bView);
            this.Controls.Add(this.bEditSubCategory);
            this.Controls.Add(this.bChoose);
            this.Controls.Add(this.bEditCategory);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbSubCat);
            this.Controls.Add(this.cbPRODUCTTYPE);
            this.Controls.Add(this.cbCAT);
            this.Controls.Add(this.bDelete);
            this.Controls.Add(this.bClone);
            this.Controls.Add(this.bEdit);
            this.Controls.Add(this.bAdd);
            this.Controls.Add(this.bClose);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "WPName";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Справочник продуктов";
            this.Load += new System.EventHandler(this.WPName_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgWP)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bClose;
        private System.Windows.Forms.Button bAdd;
        private System.Windows.Forms.Button bEdit;
        private System.Windows.Forms.Button bClone;
        private System.Windows.Forms.Button bDelete;
        private System.Windows.Forms.ComboBox cbCAT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bEditCategory;
        private System.Windows.Forms.Button bChoose;
        private System.Windows.Forms.ComboBox cbSubCat;
        private System.Windows.Forms.Button bEditSubCategory;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bView;
        private SummonManager.RComboBox cbPRODUCTTYPE;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgWP;
        private System.Windows.Forms.Button bSummonsOnProduct;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbFilter;
        private System.Windows.Forms.ComboBox cbFilter;
    }
}