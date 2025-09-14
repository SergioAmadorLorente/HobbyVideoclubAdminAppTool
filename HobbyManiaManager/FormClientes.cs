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
using Microsoft.ReportingServices.RdlExpressions.ExpressionHostObjectModel;

namespace HobbyManiaManager
{
    public partial class FormClientes : Form
    {

        private CustomersRepository customerRepository;
        
        List<Customer> customer;
        public FormClientes()
        {
            InitializeComponent();
            customerRepository = CustomersRepository.Instance;
        }

        private void FormClientes_Load(object sender, EventArgs e)
        {
            customer = new List<Customer>();
            InitListBoxes();
            this.Text = "Listado de Clientes";
        }

        private void InitListBoxes()
        { 
            customer = customerRepository.GetAll();
            listBoxCustomers.Items.Clear();

            CustomersRepository.Instance.GetAll().ForEach(p => listBoxCustomers.Items.Add(string.Format("{0,-5} {1,-15} {2,-30} {3,-15} Registro: {4}", p.Id, p.Name, p.Email, p.PhoneNumber, p.RegistrationDate)));

        }

        private void btnCreateCustomer_Click(object sender, EventArgs e)
        {
            FormCreateEditClient formCrearEditarCliente = new FormCreateEditClient(this);
            formCrearEditarCliente.ShowDialog();
        }

        public void RefreshFormclients()
        {
            InitListBoxes();
        }

        private void btnFicha_Click(object sender, EventArgs e)
        {
            var userSeleccionado = GetSelectedUser();

            if (userSeleccionado == null)
            {
                MessageBox.Show("NO SE SELECCIONO NINGUN CLIENTE A MOSTRAR, PORFAVOR SELECCIONE UNO DE LA LISTA");
                return;
                
            }
            else
            {

                FormFichaCliente formFichaCliente = new FormFichaCliente(userSeleccionado);
                formFichaCliente.ShowDialog();
            }
        }

        private Customer GetSelectedUser()
        {

            if (listBoxCustomers.SelectedItem == null)
            {
                
                return null;
            }
            else { 

            var indice = this.listBoxCustomers.SelectedItem.ToString().Split(' ')[0];

            var idDelCliente = int.Parse(indice);
            var client = customerRepository.GetById(idDelCliente);
            return client;
        }
        }

        private void listBoxCustomers_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnFicha.Enabled = true;
            btnDelete.Enabled = true;

            int clientesindex = listBoxCustomers.SelectedIndex;
            if (clientesindex != -1)
            {
                var id = this.listBoxCustomers.SelectedItem.ToString().Split(' ')[0];
                var clienteid = int.Parse(id);
                var cliente = customerRepository.GetById(clienteid);

                pictureBoxAvatarCliente.ImageLocation = cliente.Avatar;
            }
            else
            {
                return;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show(
                "Seguro desea eliminar",
                 "Confirmación",
                  MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

            if (resultado == DialogResult.Yes)
            {
                var userSeleccionado = GetSelectedUser();

                if (userSeleccionado == null)
                {
                    MessageBox.Show("NO SE SELECCIONO NINGUN CLIENTE A ELIMINAR");
                    return;
                }
                else if (userSeleccionado.RentalsHistory.Count > 0)
                {
                   
                    MessageBox.Show("NO SE PUEDE ELIMINAR UN CLIENTE QUE TENGA ALQUILERES");
                    return;
                }
                else
                {
                    customerRepository.Delete(userSeleccionado);
                    MessageBox.Show("USUARIO ELIMINADO CORRECTAMENTE");
                    RefreshFormclients();
                }
            }
            else { 

            //no hagas nada mejor
            }
        }

        private void btnlista_Click(object sender, EventArgs e)
        {
            FormReporteListaClientes formReporteListaClientes = new FormReporteListaClientes();
            formReporteListaClientes.ShowDialog();

        }

        private void listBoxCustomers_DoubleClick(object sender, EventArgs e)
        {
            var userSeleccionado = GetSelectedUser();
            FormCreateEditClient formCrearEditarCliente = new FormCreateEditClient(this, userSeleccionado);
            formCrearEditarCliente.ShowDialog();
        }
    }
}
