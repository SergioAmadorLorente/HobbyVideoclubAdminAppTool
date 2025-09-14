using System;
using System.Windows.Forms;
using HobbyManiaManager.Models;
using HobbyManiaManager.Repositories;
using Microsoft.ReportingServices.RdlExpressions.ExpressionHostObjectModel;

namespace HobbyManiaManager
{
    public class RentalService
    {
        public MoviesRepository moviesRepository;
        public RentalsRepository rentalsRepository;
        public CustomersRepository customersRepository;

        public RentalService()
        {
            moviesRepository = MoviesRepository.Instance;
            rentalsRepository = RentalsRepository.GetInstance();
            customersRepository = CustomersRepository.Instance;
        }

        public void Rent(Customer customer, Movie movie, string notes = null)
        {

            if (customer == null || movie == null)
            {
                MessageBox.Show("ni pelicula ni el cliente puede ser null o no funcionara lea el manual");
                return;
            }

            if (moviesRepository.comprobarEstadoObjOriginal(movie.Id))
            {

                MessageBox.Show($"La pelicula {movie.OriginalTitle} TIENE UN ALQUILER EN CURSO, no se puede alquilar");
                return;
            }
            else
            {

                moviesRepository.MarcarAlquiler(movie.Id);
                var rental = new Rental(movie.Id, customer.Id, notes);
                if (rental == null)
                {
                    MessageBox.Show("Rental no puede ser null");
                    return;
                }
                customersRepository.AddRentalToHistory(customer.Id, rental);
                MessageBox.Show($"La pelicula {movie.OriginalTitle} a sido ALQUILADA CORRRECTAMENTE ");
                rentalsRepository.Add(rental);
                Log();

            }
            
        }

        public void FinishRental(Customer customer, Movie movie, string notes)
        {

            if (customer == null || movie == null)
            {
                MessageBox.Show("ni pelicula ni el cliente puede ser null o no funcionara lea el manual");
                return;
            }

            if (moviesRepository.comprobarEstadoObjOriginal(movie.Id))
            {

               
                var rentals = rentalsRepository.GetCustomerRentals(customer.Id);

                var rental = rentals.Find(r => r.MovieId == movie.Id);
                if (rental == null)
                {
                  
                    MessageBox.Show("El cliente no tiene esa pelicula");
                    return;
                }
                moviesRepository.MarcarAlquiler(movie.Id);
                rental.EndDate = DateTime.Now;
                rental.Notes = notes;

                customersRepository.AddRentalToHistory(customer.Id, rental);

                rentalsRepository.Remove(rental);
                MessageBox.Show($"La pelicula {movie.OriginalTitle} SE DEVOLVIO CORRECTAMENTE ");
                Log();

            }
            else
            {
                MessageBox.Show("NO se puede devolver una pelicula que NO esta alquilada");
            }
        }

        private void Log()
        {
            foreach (var rental in rentalsRepository.GetAll())
            {
                Console.Write(rental.ToString());
            }

            Console.WriteLine("");

            foreach (var customers in customersRepository.GetAll())
            {
                Console.Write(customers.ToString());
            }
        }
    }
}
