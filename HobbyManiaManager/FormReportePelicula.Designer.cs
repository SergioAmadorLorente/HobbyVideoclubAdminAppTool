namespace HobbyManiaManager
{
    partial class FormReportePelicula
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
            this.reportViewerPelicula = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // reportViewerPelicula
            // 
            this.reportViewerPelicula.Location = new System.Drawing.Point(1, 2);
            this.reportViewerPelicula.Name = "reportViewerPelicula";
            this.reportViewerPelicula.ServerReport.BearerToken = null;
            this.reportViewerPelicula.Size = new System.Drawing.Size(795, 444);
            this.reportViewerPelicula.TabIndex = 0;
            // 
            // FormReportePelicula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewerPelicula);
            this.Name = "FormReportePelicula";
            this.Text = "FormReportePelicula";
            this.Load += new System.EventHandler(this.FormReportePelicula_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewerPelicula;
    }
}