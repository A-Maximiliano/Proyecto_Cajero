using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaLogica
{
    public class Clientes
    {
        public int Cedula { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public int No_Tarjeta { get; set; }
        //public decimal saldo { get; set; }
        public decimal Transaccion { get; set; }
        //public decimal TotalSaldo { get { return saldo; } }
    }
}
