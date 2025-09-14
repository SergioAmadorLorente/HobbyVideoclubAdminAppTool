namespace HobbyManiaManager
{
    partial class FormListaReporte
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
            this.reportViewerListaRental = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // reportViewerListaRental
            // 
            this.reportViewerListaRental.LocalReport.ReportEmbeddedResource = "HobbyManiaManager.recursos.ReportListaRental.rdlc";
            this.reportViewerListaRental.Location = new System.Drawing.Point(1, 2);
            this.reportViewerListaRental.Name = "reportViewerListaRental";
            this.reportViewerListaRental.ServerReport.BearerToken = null;
            this.reportViewerListaRental.Size = new System.Drawing.Size(777, 415);
            this.reportViewerListaRental.TabIndex = 0;
            // 
            // FormListaReporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 418);
            this.Controls.Add(this.reportViewerListaRental);
            this.Name = "FormListaReporte";
            this.Text = "FormListaReporte";
            this.Load += new System.EventHandler(this.FormListaReporte_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewerListaRental;
    }
}