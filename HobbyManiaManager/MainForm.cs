using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json;
using HobbyManiaManager.Models;

namespace HobbyManiaManager
{
    public partial class MainForm : Form
    {
        private readonly RentalService service;
        private readonly MoviesRepository moviesRepository;
        private readonly CustomersRepository customersRepository;

        public MainForm()
        {
            InitializeComponent();
            service = new RentalService();
            moviesRepository = MoviesRepository.Instance;
            customersRepository = CustomersRepository.Instance;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadMovies();
            Demo();
            BuildMenu();
            labelMoviesCounter.Text = $"{moviesRepository.Count} movies loaded.";
        }

        private void LoadMovies()
        {
            string filePath = "Resources/tmdb_top_movies_small.json";
            string json = File.ReadAllText(filePath);
            List<Movie> movies = JsonConvert.DeserializeObject<List<Movie>>(json);
            moviesRepository.AddAll(movies);
        }

        private void Demo()
        {
         

         var c1 = new Customer(Customer.NextCustomerId, customersRepository.Generate(), "AdminRafa", "rafa@hobbymania.com", "612 345 678", DateTime.Now.AddDays(-5));
        var c2 = new Customer(Customer.NextCustomerId, customersRepository.Generate(), "adminBackup", "adminBackup@hobbymania.com", "611 234 987", DateTime.Now.AddDays(-20));
           
         customersRepository.Add(c1);
         customersRepository.Add(c2);
            
            
        }

        private void btnPeliculas_Click(object sender, EventArgs e)
        {
            FormPeliculas formPeliculas = new FormPeliculas();
            formPeliculas.ShowDialog();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            FormClientes formClientes = new FormClientes();
            formClientes.ShowDialog();
        }

        private void BuildMenu()
        {

            var menu = new MenuStrip();

            var file = new ToolStripMenuItem("Ayuda");

            menu.Items.Add(file);

            var documentacion = new ToolStripMenuItem("Documentación");
            documentacion.ShortcutKeys = Keys.Control | Keys.H;
            file.DropDownItems.Add(documentacion);

            documentacion.Click += (s, e) => Showdocumentation();

            this.Controls.Add(menu);


        }

        private void Showdocumentation()
        {
        FormDocument formDocument = new FormDocument();
            formDocument.ShowDialog();
        }

        private void btnAlquilar_Click(object sender, EventArgs e)
        {
            FormAlquilarDevolver formAlquilarDevolver = new FormAlquilarDevolver();
            formAlquilarDevolver.ShowDialog();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.Control && e.KeyCode == Keys.H)
            {
                Showdocumentation();
            }
        }
    }
}
