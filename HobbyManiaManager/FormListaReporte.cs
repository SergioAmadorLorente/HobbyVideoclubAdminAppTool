using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HobbyManiaManager.Repositories;
using Microsoft.Reporting.WinForms;

namespace HobbyManiaManager
{
    public partial class FormListaReporte : Form
    {
        private RentalsRepository repositoryRental;
        public FormListaReporte()
        {
            InitializeComponent();
            repositoryRental = RentalsRepository.GetInstance();
        }

        private void FormListaReporte_Load(object sender, EventArgs e)
        {

            ReportDataSource rdm = new ReportDataSource("DataSetListaRental", repositoryRental.GetAll());
            this.reportViewerListaRental.LocalReport.DataSources.Add(rdm);
            this.reportViewerListaRental.RefreshReport();
        }
    }
}
