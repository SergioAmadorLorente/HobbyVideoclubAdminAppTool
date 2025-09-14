namespace HobbyManiaManager
{
    partial class FormDocument
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
            this.webViewDocumentacion = new Microsoft.Web.WebView2.WinForms.WebView2();
            ((System.ComponentModel.ISupportInitialize)(this.webViewDocumentacion)).BeginInit();
            this.SuspendLayout();
            // 
            // webViewDocumentacion
            // 
            this.webViewDocumentacion.AllowExternalDrop = true;
            this.webViewDocumentacion.CreationProperties = null;
            this.webViewDocumentacion.DefaultBackgroundColor = System.Drawing.Color.White;
            this.webViewDocumentacion.Location = new System.Drawing.Point(-1, 1);
            this.webViewDocumentacion.Name = "webViewDocumentacion";
            this.webViewDocumentacion.Size = new System.Drawing.Size(799, 450);
            this.webViewDocumentacion.TabIndex = 0;
            this.webViewDocumentacion.ZoomFactor = 1D;
            // 
            // FormDocument
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.webViewDocumentacion);
            this.Name = "FormDocument";
            this.Text = "FormDocument";
            this.Load += new System.EventHandler(this.FormDocument_Load);
            ((System.ComponentModel.ISupportInitialize)(this.webViewDocumentacion)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Web.WebView2.WinForms.WebView2 webViewDocumentacion;
    }
}