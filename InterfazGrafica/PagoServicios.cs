using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BibliotecaLogica;

namespace InterfazGrafica
{
    public partial class PagoServicios : Form
    {
        private Servicios N_servicios;
        bool bandera = false;
        MaskedTextBox dynamicMaskedTextBox = new MaskedTextBox();

        public PagoServicios()
        {
            InitializeComponent();

        }

        private void btnVolverMenu_Click(object sender, EventArgs e)
        {
            MenuPrincipal pantalla = new MenuPrincipal();
            pantalla.Show();
            this.Hide();
        }

        private void btnAsignar_Click(object sender, EventArgs e)
        {
            N_servicios = new Servicios (txtCedulaPag.Text);
            dgvCliente.DataSource = null;
            dgvCliente.DataSource = N_servicios.devolverClientes;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            try
            {
                //condicional para validar que no se deje el campo de texto vacio o que no corresponda a un numero
                int verificar;
                decimal verificar2;
                if (txtCedulaPag.Text == "" || !int.TryParse(txtCedulaPag.Text, out verificar))
                {
                    errorProvider1.SetError(txtCedulaPag, "Debe ingresar el numero de cédula correctamente");
                    txtCedulaPag.Focus();
                    return;
                }
                errorProvider1.SetError(txtCedulaPag, "");

                if (txtNombrePag.Text == "")
                {
                    errorProvider1.SetError(txtNombrePag, "Debe ingresar el nombre");
                    txtNombrePag.Focus();
                    return;
                }
                errorProvider1.SetError(txtNombrePag, "");

                if (txtApellidoPag.Text == "")
                {
                    errorProvider1.SetError(txtApellidoPag, "Debe ingresar el apellido");
                    txtApellidoPag.Focus();
                    return;
                }
                errorProvider1.SetError(txtApellidoPag, "");

                if (mtxtTarjeta.Text == "" || mtxtTarjeta.Text.Length < 19)
                {
                    errorProvider1.SetError(mtxtTarjeta, "Debe ingresar el numero de tarjeta correctamente");
                    mtxtTarjeta.Focus();
                    return;
                }
                errorProvider1.SetError(mtxtTarjeta, "");

                if (txtServicio.Text == "")
                {
                    errorProvider1.SetError(txtServicio, "Debe ingresar el servicio");
                    txtServicio.Focus();
                    return;
                }
                errorProvider1.SetError(txtServicio, "");

                if (txtMontoCancelar.Text == "" || !decimal.TryParse(txtMontoCancelar.Text, out verificar2))
                {
                    errorProvider1.SetError(txtMontoCancelar, "Debe ingresar el monto a retirar");
                    txtMontoCancelar.Focus();
                    return;
                }
                errorProvider1.SetError(txtMontoCancelar, "");

                Clientes myCliente = new Clientes();
                myCliente.Cedula = Convert.ToInt32(txtCedulaPag.Text);
                myCliente.Nombre = txtNombrePag.Text;
                myCliente.Apellidos = txtApellidoPag.Text;
                myCliente.No_Tarjeta = mtxtTarjeta.Text;
                N_servicios.tipoServicio = txtServicio.Text;
                N_servicios.montoCancelar = Convert.ToInt32(txtMontoCancelar.Text);
                myCliente.Transaccion = N_servicios.montoCancelar;
                N_servicios.AgregarCliente(myCliente);


                validarRetiro();
                if (bandera == true)
                {
                    dgvCliente.DataSource = null;
                    dgvCliente.DataSource = N_servicios.devolverClientes;
                    bandera = false;
                }
            }
            catch (Exception x)
            {

                MessageBox.Show("Intente de nuevo, por favor."); ;
            }
        }

        private void validarRetiro()
        {
            N_servicios.CalcularSaldo();

            string mensaje = N_servicios.ValidarTransaccion();

            if (mensaje == "Denegado")
            {
                MessageBox.Show("El saldo es insuficiente, intente cancelar otro servicio");
            }
            else
            {
                MessageBox.Show("Transaccion exitosa");
                bandera = true;
            }
            mensaje = "";
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            MessageBox.Show("El saldo corresponde a: " + N_servicios.CalcularSaldo());
        }

      
    }
}
