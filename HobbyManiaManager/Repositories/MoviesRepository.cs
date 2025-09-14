using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using HobbyManiaManager.Models;

namespace HobbyManiaManager
{
    public class MoviesRepository
    {
        private static MoviesRepository instance;
        List<Movie> movies;

        private MoviesRepository() {
            movies = new List<Movie>();
        }

        public static MoviesRepository Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new MoviesRepository();
                }
                return instance;
            }
        }
        
        public Movie GetById(int id) => (Movie)(movies.Find(m => m.Id == id)?.Clone());

        public void AddAll(List<Movie> movies) { 
            this.movies.AddRange(movies.Select(m => (Movie) m.Clone()));
        }

        public int Count => movies.Count;

        public List<Movie> GetAll() => movies.Select(m => (Movie)m.Clone()).ToList();

        //Necesario para evitar los clones una vez que es seguro
        public void MarcarAlquiler(int movieId)
        {
            var movie = movies.Find(m => m.Id == movieId);
           
            if (movie.estadoAlquiler.Equals("No Alquilado"))
            {
                movie.estadoAlquiler = "Alquilado";
            }
            else { 

            movie.estadoAlquiler = "No Alquilado";
        }
            //funciona :):):):)
        }

        public bool comprobarEstadoObjOriginal(int movieId)
        {
            bool estadoObjOriginal = false;

            var movie = movies.Find(m => m.Id == movieId);

            if (movie.estadoAlquiler.Equals("Alquilado"))
            {
                estadoObjOriginal = true;

            }
            
            return estadoObjOriginal;
           
        }

    }
}
