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
    public partial class CompraDolares : Form
    {
        private Dolares N_compra;
        bool bandera = false;

        public CompraDolares()
        {
            InitializeComponent();
            borrar();
        }

        private void borrar()
        {
            txtCedulaCom.Text = "5";
            txtNobreCom.Text = "5";
            txtApellidoCom.Text = "5";
            txtNumTarjeta.Text = "5";
            txtTipoCambio.Text = "5";
            txtCantidadDolares.Text = "5";
        }

        private void btnVolverMenu_Click(object sender, EventArgs e)
        {
            MenuPrincipal pantalla = new MenuPrincipal();
            pantalla.Show();
            this.Hide();
        }

        private void btnAsignar_Click(object sender, EventArgs e)
        {
            N_compra = new Dolares (txtCedulaCom.Text);
            dgvCliente.DataSource = null;
            dgvCliente.DataSource = N_compra.devolverClientes;
        }

        private void btnComprar_Click(object sender, EventArgs e)
        {
            try
            {
                //condicional para validar que no se deje el campo de texto vacio o que no corresponda a un numero
                int verificar;
                decimal verificar2;
                if (txtCedulaCom.Text == "" || !int.TryParse(txtCedulaCom.Text, out verificar))
                {
                    errorProvider1.SetError(txtCedulaCom, "Debe ingresar el numero de cédula correctamente");
                    txtCedulaCom.Focus();
                    return;
                }
                errorProvider1.SetError(txtCedulaCom, "");

                if (txtNobreCom.Text == "")
                {
                    errorProvider1.SetError(txtNobreCom, "Debe ingresar el nombre");
                    txtNobreCom.Focus();
                    return;
                }
                errorProvider1.SetError(txtNobreCom, "");

                if (txtApellidoCom.Text == "")
                {
                    errorProvider1.SetError(txtApellidoCom, "Debe ingresar el apellido");
                    txtApellidoCom.Focus();
                    return;
                }
                errorProvider1.SetError(txtApellidoCom, "");

                if (txtCantidadDolares.Text == "" || !decimal.TryParse(txtCantidadDolares.Text, out verificar2))
                {
                    errorProvider1.SetError(txtCantidadDolares, "Debe ingresar el numero de tarjeta");
                    txtCantidadDolares.Focus();
                    return;
                }
                errorProvider1.SetError(txtCantidadDolares, "");

                if (txtTipoCambio.Text == "" || !decimal.TryParse(txtTipoCambio.Text, out verificar2))
                {
                    errorProvider1.SetError(txtTipoCambio, "Debe ingresar el monto a retirar");
                    txtTipoCambio.Focus();
                    return;
                }
                errorProvider1.SetError(txtTipoCambio, "");

                Clientes myCliente = new Clientes();
                myCliente.Cedula = Convert.ToInt32(txtCantidadDolares.Text);
                myCliente.Nombre = txtNobreCom.Text;
                myCliente.Apellidos = txtApellidoCom.Text;
                myCliente.No_Tarjeta = Convert.ToInt32(txtNumTarjeta.Text);
                //myCliente.saldo = Convert.ToDecimal(txtTipoCambio.Text);
                N_compra.tipoCambio = Convert.ToDecimal(txtTipoCambio.Text);
                N_compra.cantidadDolares = Convert.ToInt32(txtCantidadDolares.Text);
                myCliente.Transaccion = N_compra.totalDolares;
                N_compra.AgregarCliente(myCliente);
                

                validarRetiro();
                if (bandera == true)
                {
                    dgvCliente.DataSource = null;
                    dgvCliente.DataSource = N_compra.devolverClientes;
                    bandera = false;
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Intente de nuevo, por favor."); ;
            }
        }

        private void validarRetiro()
        {
            N_compra.CalcularSaldo();

            string mensaje = N_compra.ValidarTransaccion();

            if (mensaje == "Denegado")
            {
                MessageBox.Show("El saldo es insuficiente, ingrese una cantidad de dólares menor");
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
            MessageBox.Show("El saldo corresponde a: " + N_compra.CalcularSaldo());
        }
    }
}
