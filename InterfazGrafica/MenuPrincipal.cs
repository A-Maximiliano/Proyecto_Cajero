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
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void btnDeposito_Click(object sender, EventArgs e)
        {
            DepositoDinero pantalla = new DepositoDinero();
            pantalla.Show();
            this.Hide();
        }

        private void btnRetiro_Click(object sender, EventArgs e)
        {
            RetiroDinero pantalla = new RetiroDinero();
            pantalla.Show();
            this.Hide();
        }

        private void btnCompraDolares_Click(object sender, EventArgs e)
        {
            CompraDolares pantalla = new CompraDolares();
            pantalla.Show();
            this.Hide();
        }

        private void btnPagoServicios_Click(object sender, EventArgs e)
        {
            PagoServicios pantalla = new PagoServicios();
            pantalla.Show();
            this.Hide();
        }
    }
}
