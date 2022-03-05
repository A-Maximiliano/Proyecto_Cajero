using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaLogica
{
    public class Retiros
    {
        //Atributos
        private string clientes { get; set; }
        private DateTime fecha { get; set; }
        private List<Clientes> lista_clientes { get; set; }

        //Contructor
        public Retiros(String cliente)
        {
            this.clientes = cliente;
            this.fecha = fecha;
            this.lista_clientes = new List<Clientes>();
        }

        //Metodo para agregar el cliente a la lista
        public void AgregarCliente(Clientes clientes)
        {
            lista_clientes.Add(clientes);
        }

        //retoorno la lista de clientes
        public List<Clientes> devolverClientes
        {
            get { return lista_clientes; }
        }

        //variables
        static string notificacion = "";
        bool bandera = true;

        //clacula el saldo despues de cada transacción
        public decimal CalcularSaldo()
        {          
            decimal total = 100000;

            foreach (Clientes cliente in lista_clientes)
            {
                bandera = true;
                if (total >= cliente.Transaccion) { total -= cliente.Transaccion;}

                else {bandera = false;}

                ValidarTransaccion();
            }
            return total;
        }

        //valida que el retiro no sea mayor al saldo dsiponible.
        public string ValidarTransaccion()
        {
            if (bandera == false) { notificacion = "Denegado";}

            else { notificacion = "Aprobado";}

            return notificacion;
        }
    }
}
