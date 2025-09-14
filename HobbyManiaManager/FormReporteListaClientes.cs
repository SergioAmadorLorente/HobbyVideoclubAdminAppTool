using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HobbyManiaManager.Models;
using Microsoft.Reporting.WinForms;

namespace HobbyManiaManager
{
    public partial class FormReporteListaClientes : Form
    {
        private CustomersRepository customerRepository;
        public FormReporteListaClientes()
        {
            InitializeComponent();
            customerRepository = CustomersRepository.Instance;
        }

        private void FormReporteListaClientes_Load(object sender, EventArgs e)
        {
            ReportDataSource rdm = new ReportDataSource("DataSet1", customerRepository.GetAll());
            this.reportViewerListaClientes.LocalReport.DataSources.Add(rdm);
            this.reportViewerListaClientes.RefreshReport();

            
        }
    }
}
