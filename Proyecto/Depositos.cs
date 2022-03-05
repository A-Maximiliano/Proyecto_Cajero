using BibliotecaLogica;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaLogica
{
    public class Depositos
    {
        //atributos
        private string clientes { get; set; }
        private DateTime fecha { get; set; }
        private List<Clientes> lista_clientes { get; set; }

        //constructor
        public Depositos(String cliente)
        {
            this.clientes = cliente;
            this.fecha = fecha;
            this.lista_clientes = new List<Clientes>();
        }

        //agrega nuevos clientes  a la lista clientes
        public void AgregarCliente(Clientes clientes)
        {
            lista_clientes.Add(clientes);
        }

        //devuelve la lista de clientes
        public List<Clientes> devolverClientes
        {
            get { return lista_clientes; }
        }

        //calcula el saldo resultante de cada transaccón
        public decimal CalcularSaldo()
        {
            decimal total = 100000;
            foreach (Clientes cliente in lista_clientes)
            {
                total = total + cliente.Transaccion;
            }
            return total;
        }
    }
}
