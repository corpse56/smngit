namespace SummonManager
{
    partial class EditWPN
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbNote = new System.Windows.Forms.TextBox();
            this.tbConfiguration = new System.Windows.Forms.TextBox();
            this.tbPowerSupply = new System.Windows.Forms.TextBox();
            this.tbDecNum = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.cbSubCategory = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.pfDimDrawing = new SummonManager.Controls.PathField();
            this.pfComposition = new SummonManager.Controls.PathField();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(751, 324);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Отмена";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(660, 324);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(85, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Изменить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // cbCategory
            // 
            this.cbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Location = new System.Drawing.Point(225, 40);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(601, 24);
            this.cbCategory.TabIndex = 20;
            this.cbCategory.SelectedIndexChanged += new System.EventHandler(this.cbCategory_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 276);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 16);
            this.label8.TabIndex = 15;
            this.label8.Text = "Примечание";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 238);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 16);
            this.label7.TabIndex = 14;
            this.label7.Text = "Конфигурация";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 210);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "Электропитание";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 16);
            this.label5.TabIndex = 16;
            this.label5.Text = "Габаритный чертёж";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 16);
            this.label4.TabIndex = 19;
            this.label4.Text = "Состав изделия";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 16);
            this.label3.TabIndex = 18;
            this.label3.Text = "Децимальный номер";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 16);
            this.label2.TabIndex = 17;
            this.label2.Text = "Категория";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "Наименование";
            // 
            // tbNote
            // 
            this.tbNote.Location = new System.Drawing.Point(225, 260);
            this.tbNote.Multiline = true;
            this.tbNote.Name = "tbNote";
            this.tbNote.Size = new System.Drawing.Size(601, 58);
            this.tbNote.TabIndex = 7;
            // 
            // tbConfiguration
            // 
            this.tbConfiguration.Location = new System.Drawing.Point(225, 232);
            this.tbConfiguration.Name = "tbConfiguration";
            this.tbConfiguration.Size = new System.Drawing.Size(601, 22);
            this.tbConfiguration.TabIndex = 6;
            // 
            // tbPowerSupply
            // 
            this.tbPowerSupply.Location = new System.Drawing.Point(225, 204);
            this.tbPowerSupply.Name = "tbPowerSupply";
            this.tbPowerSupply.Size = new System.Drawing.Size(601, 22);
            this.tbPowerSupply.TabIndex = 5;
            // 
            // tbDecNum
            // 
            this.tbDecNum.Location = new System.Drawing.Point(225, 100);
            this.tbDecNum.Name = "tbDecNum";
            this.tbDecNum.Size = new System.Drawing.Size(601, 22);
            this.tbDecNum.TabIndex = 10;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(225, 12);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(601, 22);
            this.tbName.TabIndex = 9;
            // 
            // cbSubCategory
            // 
            this.cbSubCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSubCategory.FormattingEnabled = true;
            this.cbSubCategory.Location = new System.Drawing.Point(225, 70);
            this.cbSubCategory.Name = "cbSubCategory";
            this.cbSubCategory.Size = new System.Drawing.Size(601, 24);
            this.cbSubCategory.TabIndex = 26;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(20, 73);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(101, 16);
            this.label9.TabIndex = 25;
            this.label9.Text = "Подкатегория";
            // 
            // pfDimDrawing
            // 
            this.pfDimDrawing.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pfDimDrawing.FullPath = "<нет>";
            this.pfDimDrawing.Location = new System.Drawing.Point(225, 165);
            this.pfDimDrawing.Margin = new System.Windows.Forms.Padding(4);
            this.pfDimDrawing.Name = "pfDimDrawing";
            this.pfDimDrawing.Required = false;
            this.pfDimDrawing.Size = new System.Drawing.Size(596, 32);
            this.pfDimDrawing.TabIndex = 24;
            // 
            // pfComposition
            // 
            this.pfComposition.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pfComposition.FullPath = "<нет>";
            this.pfComposition.Location = new System.Drawing.Point(225, 129);
            this.pfComposition.Margin = new System.Windows.Forms.Padding(4);
            this.pfComposition.Name = "pfComposition";
            this.pfComposition.Required = false;
            this.pfComposition.Size = new System.Drawing.Size(596, 28);
            this.pfComposition.TabIndex = 23;
            // 
            // EditWPN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 356);
            this.Controls.Add(this.cbSubCategory);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.pfDimDrawing);
            this.Controls.Add(this.pfComposition);
            this.Controls.Add(this.cbCategory);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbNote);
            this.Controls.Add(this.tbConfiguration);
            this.Controls.Add(this.tbPowerSupply);
            this.Controls.Add(this.tbDecNum);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "EditWPN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Изменение наименования изделия";
            this.Load += new System.EventHandler(this.EditWPN_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbNote;
        private System.Windows.Forms.TextBox tbConfiguration;
        private System.Windows.Forms.TextBox tbPowerSupply;
        private System.Windows.Forms.TextBox tbDecNum;
        private System.Windows.Forms.TextBox tbName;
        private SummonManager.Controls.PathField pfComposition;
        private SummonManager.Controls.PathField pfDimDrawing;
        private System.Windows.Forms.ComboBox cbSubCategory;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.Button button2;
    }
}