namespace HobbyManiaManager
{
    partial class FormReporteListaClientes
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
            this.reportViewerListaClientes = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // reportViewerListaClientes
            // 
            this.reportViewerListaClientes.LocalReport.ReportEmbeddedResource = "HobbyManiaManager.recursos.ReportListaClientes.rdlc";
            this.reportViewerListaClientes.Location = new System.Drawing.Point(1, 2);
            this.reportViewerListaClientes.Name = "reportViewerListaClientes";
            this.reportViewerListaClientes.ServerReport.BearerToken = null;
            this.reportViewerListaClientes.Size = new System.Drawing.Size(787, 436);
            this.reportViewerListaClientes.TabIndex = 0;
            // 
            // FormReporteListaClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewerListaClientes);
            this.Name = "FormReporteListaClientes";
            this.Text = "FormReporteListaClientes";
            this.Load += new System.EventHandler(this.FormReporteListaClientes_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewerListaClientes;
    }
}