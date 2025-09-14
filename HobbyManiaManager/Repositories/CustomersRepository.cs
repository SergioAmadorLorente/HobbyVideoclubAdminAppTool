using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using HobbyManiaManager.Models;

namespace HobbyManiaManager
{
    public class CustomersRepository
    {
        private static CustomersRepository instance;
        private List<Customer> customers;
        private readonly Random _random = new Random();
        private CustomersRepository()
        {
            customers = new List<Customer>();
        }

        public static CustomersRepository Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new CustomersRepository();
                }
                return instance;
            }
        }

        public Customer GetById(int id) => customers.Find(m => m.Id == id);

        public void Add(Customer customer)
        {
            if (customers.Exists(c => c.Id == customer.Id))
            {
                throw new ArgumentException($"A customer with ID {customer.Id} already exists.", nameof(customer.Id));
                
            }

            if (customers.Exists(c => c.Name == customer.Name) && customers.Exists(c => c.PhoneNumber == customer.PhoneNumber))
            {
                MessageBox.Show(" El cliente ya existe con ese nombre completo y numero de telefono");
                //ya que nombre completo puede exixtir otra persona pero nombre completo y telefono y es mucha cooincidencia
                return; //siempre me olvido sino salta la lineas de codigo del form despeus de este metodo
            }
            else
            {
                customers.Add(customer);
                Console.Write(customer);
            }
        }
        public void AddRentalToHistory(Customer customer, Rental rental)
        {
            AddRentalToHistory(customer.Id, rental);
        }

        public void AddRentalToHistory(int customerId, Rental rental)
        {
            if (rental == null)
            {
                throw new ArgumentNullException(nameof(rental), "Rental object cannot be null");
            }

            var customer = customers.Find(c => c.Id == customerId);
            if (customer == null)
            {
                throw new ArgumentException($"No customer found with ID {customerId}", nameof(customerId));
            }

            customer.RentalsHistory.Add(rental);
            Console.Write(customer);
        }

        public List<Customer> GetAll()
        {
            return customers.Select(c => (Customer)c)
                .ToList();
        }

        public void Delete(Customer customer)
        {
            customers.RemoveAll(c => c.Id == customer.Id);
        }
        public string Generate()
        {
          
            return  $"https://i.pravatar.cc/200?img={_random.Next() % 70 + 1}";
           
        }
        
        public void Update(Customer oldcustomer)
        {
            var existingCustomer = customers.Find(c => c.Id == oldcustomer.Id);
            if (existingCustomer != null)
            {
                existingCustomer.Name = oldcustomer.Name;
                existingCustomer.Email = oldcustomer.Email;
                existingCustomer.PhoneNumber = oldcustomer.PhoneNumber;
               

            }
            

        }
    }
}

