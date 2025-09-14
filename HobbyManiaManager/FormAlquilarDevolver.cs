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
using HobbyManiaManager.Models;

namespace HobbyManiaManager
{
    public partial class FormAlquilarDevolver : Form
    {
        public MoviesRepository moviesRepository;
        public RentalsRepository rentalsRepository;
        public CustomersRepository customersRepository;
        public  RentalService service;
        List<Movie> movies;
        List<Customer> customer;
        public FormAlquilarDevolver()
        {
            InitializeComponent();
            moviesRepository = MoviesRepository.Instance;
            rentalsRepository = RentalsRepository.GetInstance();
            customersRepository = CustomersRepository.Instance;
            service = new RentalService();
            
        }

        private void FormAlquilarDevolver_Load(object sender, EventArgs e)
        {
            movies = new List<Movie>();
            customer = new List<Customer>();
            InitListBoxesPeliculas();
            InitListBoxesClientes();
            this.Text = "Sección Alquilar/Devolver Peliculas";
            btnAlquilar.Enabled = false;
            btnDevolverPeli.Enabled = false;
        }
        private void InitListBoxesPeliculas()
        {
            moviesRepository.AddAll(movies);
            movies = moviesRepository.GetAll();
            listBoxPeliculas.Items.Clear();

            MoviesRepository.Instance.GetAll().ForEach(p => listBoxPeliculas.Items.Add(string.Format("{0,-7} {1,-38} {2,-10}", p.Id, p.Title, p.estadoAlquiler)));
           
        }

        private void InitListBoxesClientes()
        {
            customer = customersRepository.GetAll();
            listBoxClientes.Items.Clear();

            foreach (var c in customer.OrderBy(c => c.Id))
            {

                listBoxClientes.Items.Add($"{c.Id} - Nombre: {c.Name} - Email: {c.Email}");
            }

        }

        public void recargarPeliculas()
        {
            listBoxPeliculas.Items.Clear();
            labellatieneel.Visible = false;
            MoviesRepository.Instance.GetAll().ForEach(p => listBoxPeliculas.Items.Add(string.Format("{0,-7} {1,-38} {2,-10}", p.Id, p.Title, p.estadoAlquiler)));
        }

        private void btnAlquilar_Click(object sender, EventArgs e)
        {

            var userSeleccionado = GetSelectedUser();
            var movieSelected = GetSelectedMovie();

            if (userSeleccionado == null)
            {
                MessageBox.Show("Error el numero de cliente no existe al alquilar peli");
            }
            else
            {

                if (movieSelected == null)
                {
                    MessageBox.Show("Esa Película no existe");
                    return;
                }
                service.Rent(userSeleccionado, movieSelected, textBoxNotas.Text);
                textBoxNotas.Text = "";
                recargarPeliculas();
            }

        }

        private void btnDevolverPeli_Click(object sender, EventArgs e)
        {
            var userSeleccionado = GetSelectedUser();
            var movieSelected = GetSelectedMovie();

            if (userSeleccionado == null)
            {
                MessageBox.Show("Error el numero de cliente no existe al devolver peli");
            }
            else
            {
                if (movieSelected == null)
                {
                    MessageBox.Show("Esa Película no existe");
                    return;
                }

                service.FinishRental(userSeleccionado, movieSelected, textBoxNotas.Text);
                textBoxNotas.Text = "";
                recargarPeliculas();
            }
        }

        private void btnListaRental_Click(object sender, EventArgs e)
        {
            FormListaReporte formListaReporte = new FormListaReporte();
            formListaReporte.ShowDialog();
        }

        private Customer GetSelectedUser()
        {
            if (listBoxClientes.SelectedItem == null)
            {

                return null;
            }
            else
            {
                var indice = this.listBoxClientes.SelectedItem.ToString().Split(' ')[0];
                var idDelCliente = int.Parse(indice);
                var client = customersRepository.GetById(idDelCliente);
                return client;
            }
        }

        private Movie GetSelectedMovie()
        {
            if (listBoxPeliculas.SelectedItem == null)
            {

                return null;
            }
            else{ 
                var indice = this.listBoxPeliculas.SelectedItem.ToString().Split(' ')[0];
            var idDelapelicula = int.Parse(indice);
            var pelicula = moviesRepository.GetById(idDelapelicula);
            return pelicula;
             }
        }

        private void listBoxPeliculas_SelectedIndexChanged(object sender, EventArgs e)
        {
            var peli = GetSelectedMovie();

            textBoxidpelicula.Text = peli.Id.ToString();
            textBoxnombrepelicula.Text = peli.OriginalTitle;

            if (peli.estadoAlquiler == "No Alquilado")
            {

                btnAlquilar.Enabled = true;
                btnDevolverPeli.Enabled = false;
                labellatieneel.Visible = false;
            }
            else if(peli.estadoAlquiler == "Alquilado")
            {
                var rental = rentalsRepository.GetAll().Find(r => r.MovieId == peli.Id && r.EndDate == null);
                var cliente = customersRepository.GetById(rental.CustomerId);
                labellatieneel.Visible = true;
                labellatieneel.Text = $"Pelicula con alquiler en curso por: {cliente.Name} ID: {cliente.Id}";
                btnAlquilar.Enabled = false;
                btnDevolverPeli.Enabled = true;


            }
        }

        private void listBoxClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listBoxClientes.SelectedItem != null)
            {
                var cliente = GetSelectedUser();
             textBoxidcliente.Text = cliente.Id.ToString();
               textBoxnombrecliente.Text = cliente.Name;
            }
            else
            {
               textBoxidcliente.Text = "";
               textBoxnombrecliente.Text = "";
            }
        }
    }
}
