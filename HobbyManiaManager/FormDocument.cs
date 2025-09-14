using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Web.WebView2.Core;
using Microsoft.Web.WebView2.WinForms;


namespace HobbyManiaManager
{
    public partial class FormDocument : Form
    {
        public FormDocument()
        {
            InitializeComponent();
        }

        private async void FormDocument_Load(object sender, EventArgs e)
        {
            await initiziated();
        }

        private async Task initiziated()
        { 
        //por alguna extraña razon no me va el html desde resources nis e visualiza
        await webViewDocumentacion.EnsureCoreWebView2Async(null);

            string path = System.IO.Path.Combine(Application.StartupPath, "recursos", "habbyManiaDoc.html");

            webViewDocumentacion.CoreWebView2.Navigate(path);
        
        }
    }
}
