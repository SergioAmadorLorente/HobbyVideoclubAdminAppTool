using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HobbyManiaManager.Models;
using Microsoft.Reporting.WinForms;

namespace HobbyManiaManager
{
    public partial class FormReportePelicula : Form
    {

        private Movie movie;
        public FormReportePelicula(Movie movieImport)
        {
            InitializeComponent();
            this.movie = movieImport;
        }

        private void FormReportePelicula_Load(object sender, EventArgs e)
        {

            reportViewerPelicula.LocalReport.EnableExternalImages = true;

            this.reportViewerPelicula.LocalReport.ReportPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "recursos\\ReportPeliculas.rdlc");

            ReportParameter[] parameters = new ReportParameter[7];

                parameters[0] = new ReportParameter("Id", movie.Id.ToString());
            parameters[1] = new ReportParameter("OriginalTitle", movie.OriginalTitle);
            parameters[2] = new ReportParameter("ReleaseDate", movie.ReleaseDate);
            parameters[3] = new ReportParameter("Overview", movie.Overview);
            parameters[4] = new ReportParameter("PosterPathUrl", movie.PosterPathUrl);
            parameters[5] = new ReportParameter("VoteCount", movie.VoteCount.ToString());
            parameters[6] = new ReportParameter("estadoAlquiler", movie.estadoAlquiler);

            this.reportViewerPelicula.LocalReport.SetParameters(parameters);

            this.reportViewerPelicula.RefreshReport();
        }
    }
}
