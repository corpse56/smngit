namespace SummonManager
{
    partial class ShowReport
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
            this.RepViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // RepViewer
            // 
            this.RepViewer.ActiveViewIndex = -1;
            this.RepViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RepViewer.DisplayGroupTree = false;
            this.RepViewer.DisplayStatusBar = false;
            this.RepViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RepViewer.Location = new System.Drawing.Point(0, 0);
            this.RepViewer.Name = "RepViewer";
            this.RepViewer.SelectionFormula = "";
            this.RepViewer.ShowCloseButton = false;
            this.RepViewer.ShowGotoPageButton = false;
            this.RepViewer.ShowGroupTreeButton = false;
            this.RepViewer.ShowRefreshButton = false;
            this.RepViewer.ShowZoomButton = false;
            this.RepViewer.Size = new System.Drawing.Size(898, 784);
            this.RepViewer.TabIndex = 0;
            this.RepViewer.ViewTimeSelectionFormula = "";
            // 
            // ShowReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 784);
            this.Controls.Add(this.RepViewer);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "ShowReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Просмотр и печать извещения";
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer RepViewer;
    }
}