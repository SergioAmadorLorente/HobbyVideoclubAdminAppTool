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
            var c3 = new Customer(Customer.NextCustomerId, customersRepository.Generate(), "LauraGomez", "laura.gomez@correo.com", "623 456 789", DateTime.Now.AddDays(-12));
            var c4 = new Customer(Customer.NextCustomerId, customersRepository.Generate(), "CarlosRuiz", "carlos.ruiz@correo.com", "634 567 890", DateTime.Now.AddDays(-18));
            var c5 = new Customer(Customer.NextCustomerId, customersRepository.Generate(), "AnaLopez", "ana.lopez@correo.com", "645 678 901", DateTime.Now.AddDays(-7));
            var c6 = new Customer(Customer.NextCustomerId, customersRepository.Generate(), "MiguelSantos", "miguel.santos@correo.com", "656 789 012", DateTime.Now.AddDays(-25));
            var c7 = new Customer(Customer.NextCustomerId, customersRepository.Generate(), "ElenaMartin", "elena.martin@correo.com", "667 890 123", DateTime.Now.AddDays(-3));
            var c8 = new Customer(Customer.NextCustomerId, customersRepository.Generate(), "DavidPerez", "david.perez@correo.com", "678 901 234", DateTime.Now.AddDays(-15));
            var c9 = new Customer(Customer.NextCustomerId, customersRepository.Generate(), "SaraNavarro", "sara.navarro@correo.com", "689 012 345", DateTime.Now.AddDays(-30));
            var c10 = new Customer(Customer.NextCustomerId, customersRepository.Generate(), "JavierMoreno", "javier.moreno@correo.com", "690 123 456", DateTime.Now.AddDays(-10));
            var c11 = new Customer(Customer.NextCustomerId, customersRepository.Generate(), "LuciaTorres", "lucia.torres@correo.com", "601 234 567", DateTime.Now.AddDays(-22));
            var c12 = new Customer(Customer.NextCustomerId, customersRepository.Generate(), "PabloVega", "pablo.vega@correo.com", "612 987 654", DateTime.Now.AddDays(-1));
            var c13 = new Customer(Customer.NextCustomerId, customersRepository.Generate(), "AlbertoDiaz", "alberto.diaz@correo.com", "622 111 222", DateTime.Now.AddDays(-9));
            var c14 = new Customer(Customer.NextCustomerId, customersRepository.Generate(), "MartaSanchez", "marta.sanchez@correo.com", "633 222 333", DateTime.Now.AddDays(-14));
            var c15 = new Customer(Customer.NextCustomerId, customersRepository.Generate(), "IvanCastro", "ivan.castro@correo.com", "644 333 444", DateTime.Now.AddDays(-6));
            var c16 = new Customer(Customer.NextCustomerId, customersRepository.Generate(), "NuriaGil", "nuria.gil@correo.com", "655 444 555", DateTime.Now.AddDays(-28));
            var c17 = new Customer(Customer.NextCustomerId, customersRepository.Generate(), "SergioLuna", "sergio.luna@correo.com", "666 555 666", DateTime.Now.AddDays(-2));


            customersRepository.Add(c1);
            customersRepository.Add(c2);
            customersRepository.Add(c3);
            customersRepository.Add(c4);
            customersRepository.Add(c5);
            customersRepository.Add(c6);
            customersRepository.Add(c7);
            customersRepository.Add(c8);
            customersRepository.Add(c9);
            customersRepository.Add(c10);
            customersRepository.Add(c11);
            customersRepository.Add(c12);
            customersRepository.Add(c13);
            customersRepository.Add(c14);
            customersRepository.Add(c15);
            customersRepository.Add(c16);
            customersRepository.Add(c17);


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
