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

namespace HobbyManiaManager
{
    public partial class FormPeliculas : Form
    {

        private MoviesRepository moviesRepository;
        List<Movie> movies;

        public FormPeliculas()
        {
            InitializeComponent();
            moviesRepository = MoviesRepository.Instance;
        }

        private void FormPeliculas_Load(object sender, EventArgs e)
        { 
                movies = new List<Movie>();
            InitListBoxes();
            btnPeliABuscar.Enabled = false;
            btnRating.Enabled = false;
            this.Text = "Listado de Películas";

        }

        private void InitListBoxes()
        {
            moviesRepository.AddAll(movies);
            movies = moviesRepository.GetAll();
            listBoxPeliculas.Items.Clear();


            MoviesRepository.Instance.GetAll().ForEach(p => listBoxPeliculas.Items.Add(string.Format("{0,-7} {1,-50} {2,-10} {3,-15}", p.Id, p.Title, p.VoteAverage, p.estadoAlquiler)));
          

        }

        private void btnPeliABuscar_Click(object sender, EventArgs e)
        {
            string nombrePelicula = textBoxTextABuscar.Text;

            

            listBoxPeliculas.Items.Clear();

            foreach (var movie in movies)
            {
                //asi si fuerzo a to lower las dos variables antes de que el contains intervenga 
                if (movie.OriginalTitle.ToLower().Contains(nombrePelicula.ToLower()))
                {

                    listBoxPeliculas.Items.Add(movie);
                    return;
                }
              
            }
        }

        private void btnRating_Click(object sender, EventArgs e)
        {
            string ratingABuscar = textBoxRating.Text;

            
            double numeroDecimal = double.Parse(ratingABuscar);

            listBoxPeliculas.Items.Clear();

            foreach (var movie in movies)
            {
                if (numeroDecimal <= movie.VoteAverage)
                {
                    listBoxPeliculas.Items.Add(movie);
                }
            }
        }

        private void btnInforme_Click(object sender, EventArgs e)
        {


            if (listBoxPeliculas.SelectedItem == null)
            {
                MessageBox.Show("No has seleccionado ninguna pelicula");
                return;
            }
            var movie = GetSelectedMovie();

            FormReportePelicula formReportePelicula = new FormReportePelicula(movie);
            formReportePelicula.ShowDialog();
        }

        private Movie GetSelectedMovie()
        {
            if (listBoxPeliculas.SelectedItem == null)
            {

                return null;
            }
            else
            {

                var indiceMovie = this.listBoxPeliculas.SelectedItem.ToString().Split(' ')[0];
                var selectedMovieID = int.Parse(indiceMovie);
                var movie = moviesRepository.GetById(selectedMovieID);
                return movie;
            }

        }

        private void listBoxPeliculas_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnInforme.Enabled = true;

            int catalogoIndex = listBoxPeliculas.SelectedIndex;
            if (catalogoIndex != -1)
            {
                textBoxSinopsis.Visible = true;
                var id = this.listBoxPeliculas.SelectedItem.ToString().Split(' ')[0];
                var movieId = int.Parse(id);
                var movie = moviesRepository.GetById(movieId);

                pictureBoxPelicula.SizeMode = PictureBoxSizeMode.Zoom; // Asegura que se mantenga la relación de aspecto  
                pictureBoxPelicula.ImageLocation = movie.PosterPathUrl;
                textBoxSinopsis.Text = movie.Overview;
            }
            else
            {
                return;
            }
        }

        private void textBoxTextABuscar_TextChanged(object sender, EventArgs e)
        {
            if (textBoxTextABuscar.Text != "")

            {
                btnPeliABuscar.Enabled = true;


            }
            else {

                btnPeliABuscar.Enabled = false;
            }

            if (!textBoxTextABuscar.Text.Trim().Equals(""))
            {
                listBoxPeliculas.Items.Clear();
                var movie = moviesRepository.GetAll().Where(m => m.Title.ToLower().Contains(textBoxTextABuscar.Text.Trim().ToLower()));

                foreach (var m in movie)
                {
                    listBoxPeliculas.Items.Add($"{m.Id,-7} {m.Title,-50} {m.VoteAverage,-10} {m.estadoAlquiler,-15}");
                   
                }
            }
            else
            {
                listBoxPeliculas.Items.Clear();
                InitListBoxes();
            }
        }

        private void textBoxRating_TextChanged(object sender, EventArgs e)
        {
            if (textBoxRating.Text != "")

            {
                btnRating.Enabled = true;


            }
            else
            {

                btnRating.Enabled = false;
            }
        }
    }
}
