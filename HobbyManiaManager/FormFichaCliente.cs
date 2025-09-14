using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HobbyManiaManager.Models;//OJOOOOO no siempre se agrega automaticamnete
//ide, 25 min para saber porque no me reconocia el Customer

namespace HobbyManiaManager
{
    public partial class FormFichaCliente : Form
    {
        private Customer usuario;
        public FormFichaCliente(Customer userSeleccionado)
        {
            InitializeComponent();
            this.usuario = userSeleccionado;
        }

        private void FormFichaCliente_Load(object sender, EventArgs e)
        {
            string idAString = usuario.Id.ToString();

            labelId.Text = idAString;
            labelNameClient.Text = usuario.Name;
            labelEmailCliente.Text = usuario.Email;
            labelPhoneNumber.Text = usuario.PhoneNumber;
            labelFechaRegistro.Text = usuario.RegistrationDate.ToString();

            listBoxHistorialCliente.Items.Clear();
            listBoxAlquileresFinalizados.Items.Clear();

            var rentalsUnicos = usuario.RentalsHistory
                .GroupBy(r => r.MovieId)
                .Select(grupo =>
                    grupo.Any(r => r.EndDate != null)
                        ? grupo.First(r => r.EndDate != null) 
                        : grupo.First()                      
                );

            foreach (var rental in rentalsUnicos)
            {
                if (rental.EndDate == null)
                    listBoxHistorialCliente.Items.Add(rental);
                else
                    listBoxAlquileresFinalizados.Items.Add(rental);
            }

        }
    }
}
