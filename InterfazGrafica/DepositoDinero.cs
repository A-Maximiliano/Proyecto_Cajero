using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using BibliotecaLogica;

namespace InterfazGrafica
{
    public partial class DepositoDinero : Form
    {
        DateTime fecha = DateTime.Now;
        //Clientes myCliente = new Clientes();
        private Depositos N_deposito;

        public DepositoDinero()
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
            N_deposito = new Depositos(txtCedulaDep.Text);
            dgvCliente.DataSource = null;
            dgvCliente.DataSource = N_deposito.devolverClientes;
            btnCalcular.Enabled = true;
        }

        private void btnDepositar_Click(object sender, EventArgs e)
        {
            try
            {
                //condicional para validar que no se deje el campo de texto vacio o que no corresponda a un numero
                int verificar;
                decimal verificar2;
                if (txtCedulaDep.Text == "" || !int.TryParse(txtCedulaDep.Text, out verificar))
                {
                    errorProvider1.SetError(txtCedulaDep, "Debe ingresar el numero de cédula correctamente");
                    txtCedulaDep.Focus();
                    return;
                }
                 errorProvider1.SetError(txtCedulaDep, "");

                 if (txtNombreDep.Text == "")
                 {
                     errorProvider1.SetError(txtNombreDep, "Debe ingresar el nombre");
                    txtNombreDep.Focus();
                     return;
                 }
                 errorProvider1.SetError(txtNombreDep, "");

                 if (txtApellidoDep.Text == "")
                 {
                     errorProvider1.SetError(txtApellidoDep, "Debe ingresar el apellido");
                    txtApellidoDep.Focus();
                     return;
                 }
                 errorProvider1.SetError(txtApellidoDep, "");

                 if (txtTarjetaDep.Text == "" || !int.TryParse(txtTarjetaDep.Text, out verificar))
                 {
                     errorProvider1.SetError(txtTarjetaDep, "Debe ingresar el numero de tarjeta");
                    txtTarjetaDep.Focus();
                     return;
                 }
                 errorProvider1.SetError(txtTarjetaDep, "");

                if (txtMontoDepositar.Text == "" || !decimal.TryParse(txtTarjetaDep.Text, out verificar2))
                {
                    errorProvider1.SetError(txtMontoDepositar, "Debe ingresar el monto a depositar");
                    txtMontoDepositar.Focus();
                    return;
                }
                errorProvider1.SetError(txtMontoDepositar, "");

                Clientes myCliente = new Clientes();
                 myCliente.Cedula = Convert.ToInt32(txtCedulaDep.Text);
                 myCliente.Nombre = txtNombreDep.Text;
                 myCliente.Apellidos = txtApellidoDep.Text;
                 myCliente.No_Tarjeta = Convert.ToInt32(txtTarjetaDep.Text);
                 myCliente.Transaccion = Convert.ToDecimal(txtMontoDepositar.Text);
                 N_deposito.AgregarCliente(myCliente);
                 MessageBox.Show("Se guardó correctamente");
                 btnCalcular.Enabled = true;

                //N_deposito.AgregarCliente(myCliente);
                dgvCliente.DataSource = null;
                dgvCliente.DataSource = N_deposito.devolverClientes;

            }
            catch (Exception)
            {

                MessageBox.Show("Intente de nuevo, por favor."); ;
            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            MessageBox.Show("El saldo corresponde a: " + N_deposito.CalcularSaldo());
        }
    }
}
