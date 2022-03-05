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
    public partial class RetiroDinero : Form
    {
        private Retiros N_retiro;
        bool bandera = false;

        public RetiroDinero()
        {
            InitializeComponent();
            //borrar();
        }

        private void btnVolverMenu_Click(object sender, EventArgs e)
        {
            MenuPrincipal pantalla = new MenuPrincipal();
            pantalla.Show();
            this.Hide();
        }

        private void btnAsignarRet_Click(object sender, EventArgs e)
        {
            N_retiro = new Retiros (txtCedulaRet.Text);
            dgvCliente.DataSource = null;
            dgvCliente.DataSource = N_retiro.devolverClientes;
        }

        private void btnRetirar_Click(object sender, EventArgs e)
        {
            try
            {
                //condicional para validar que no se deje el campo de texto vacio o que no corresponda a un numero
                int verificar;
                decimal verificar2;
                if (txtCedulaRet.Text == "" || !int.TryParse(txtCedulaRet.Text, out verificar))
                {
                    errorProvider1.SetError(txtCedulaRet, "Debe ingresar el numero de cédula correctamente");
                    txtCedulaRet.Focus();
                    return;
                }
                errorProvider1.SetError(txtCedulaRet, "");

                if (txtNombreRet.Text == "")
                {
                    errorProvider1.SetError(txtNombreRet, "Debe ingresar el nombre");
                    txtNombreRet.Focus();
                    return;
                }
                errorProvider1.SetError(txtNombreRet, "");

                if (txtApellidoRet.Text == "")
                {
                    errorProvider1.SetError(txtApellidoRet, "Debe ingresar el apellido");
                    txtApellidoRet.Focus();
                    return;
                }
                errorProvider1.SetError(txtApellidoRet, "");

                if (mtxtTarjeta.Text == "" || mtxtTarjeta.Text.Length < 19)
                {
                    errorProvider1.SetError(mtxtTarjeta, "Debe ingresar el numero de tarjeta");
                    mtxtTarjeta.Focus();
                    return;
                }
                errorProvider1.SetError(mtxtTarjeta, "");

                if (txtMontoRetirar.Text == "" || !decimal.TryParse(txtMontoRetirar.Text, out verificar2))
                {
                    errorProvider1.SetError(txtMontoRetirar, "Debe ingresar el monto a retirar");
                    txtMontoRetirar.Focus();
                    return;
                }
                errorProvider1.SetError(txtMontoRetirar, "");

                Clientes myCliente = new Clientes();
                myCliente.Cedula = Convert.ToInt32(txtCedulaRet.Text);
                myCliente.Nombre = txtNombreRet.Text;
                myCliente.Apellidos = txtApellidoRet.Text;
                //myCliente.No_Tarjeta = Convert.ToInt32(txtTarjetaRet.Text);
                myCliente.No_Tarjeta = mtxtTarjeta.Text;
                myCliente.Transaccion = Convert.ToDecimal(txtMontoRetirar.Text);
                N_retiro.AgregarCliente(myCliente);
                //MessageBox.Show("Se guardó correctamente");
                validarRetiro();
                if (bandera == true)
                {
                    dgvCliente.DataSource = null;
                    dgvCliente.DataSource = N_retiro.devolverClientes;
                    bandera = false;
                }              
            }
            catch (Exception)
            {

                MessageBox.Show("Intente de nuevo, por favor."); ;
            }
        }


        private void borrar()
        {
            txtCedulaRet.Text = "5";
            txtNombreRet.Text = "5";
            txtApellidoRet.Text = "5";
            mtxtTarjeta.Text = "5123456789123416";
            txtMontoRetirar.Text = "5";
        }

        private void validarRetiro()
        {
            N_retiro.CalcularSaldo();

            string mensaje = N_retiro.ValidarTransaccion();
 
            if (mensaje == "Denegado")
            {
                MessageBox.Show("El saldo es insuficiente, ingrese una cantidad menor");
            }
            else
            {
                MessageBox.Show("Transaccion exitosa");
                bandera = true;              
            }
            mensaje = "";
        }

        private void btnCalcularRet_Click(object sender, EventArgs e)
        {
            MessageBox.Show("El saldo corresponde a: " + N_retiro.CalcularSaldo());
        }
    }
}
