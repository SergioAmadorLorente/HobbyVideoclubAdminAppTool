using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using HobbyManiaManager.Models;

namespace HobbyManiaManager
{
    public partial class FormCreateEditClient : Form
    {

        private CustomersRepository customerRepository;
        private FormClientes formClientes;
        private Customer customer;
        public FormCreateEditClient(FormClientes formClientes, Customer customer = null)
        {
            InitializeComponent();
            customerRepository = CustomersRepository.Instance;
            this.formClientes = formClientes;
            this.customer = customer;
        }

        private void FormCreateEditClient_Load(object sender, EventArgs e)
        {
            this.Text = "Crear Cliente";

            if (customer != null)
            {
                this.Text = "Editar Cliente";
                textBoxName.Text = customer.Name;
                textBoxEmail.Text = customer.Email;
                textBoxPhoneNumber.Text = customer.PhoneNumber;
                pictureBox1.ImageLocation = customer.Avatar;
                btnCrear.Text = "Actualizar Cliente";
            }

        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            string validTlf = textBoxPhoneNumber.Text.Trim();
            if (!Regex.IsMatch(validTlf, @"^[0-9\-\+\s]{7,15}$"))
            {
                MessageBox.Show("El formato de teléfono no válido. Debe contener mínimo 7 dígitos",
                                "Error ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxPhoneNumber.Focus();
                return;
            }

            if (customer == null) {

                if (string.IsNullOrWhiteSpace(textBoxName.Text) || string.IsNullOrWhiteSpace(textBoxEmail.Text) || string.IsNullOrWhiteSpace(textBoxPhoneNumber.Text))
                {
                    MessageBox.Show("Por favor campos obligatorios, deben de estar rellenados");
                }
                else {

                    var newc = new Customer(Customer.NextCustomerId, customerRepository.Generate(), textBoxName.Text, textBoxEmail.Text, textBoxPhoneNumber.Text, DateTime.Now);
                    customerRepository.Add(newc);
                    formClientes.RefreshFormclients();
                    this.Close();
                }

            }
            else {
                if (string.IsNullOrWhiteSpace(textBoxName.Text) || string.IsNullOrWhiteSpace(textBoxEmail.Text) || string.IsNullOrWhiteSpace(textBoxPhoneNumber.Text))
                {
                    MessageBox.Show("Por favor campos obligatorios, deben de estar rellenados");
                }
                else
                {
                    customer.Name = textBoxName.Text;
                    customer.Email = textBoxEmail.Text;
                    customer.PhoneNumber = textBoxPhoneNumber.Text;

                    customerRepository.Update(customer);
                    formClientes.RefreshFormclients();
                    this.Close();
                }


            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
