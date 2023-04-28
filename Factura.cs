using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OracleClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test
{
    public partial class Factura : Form
    {
        OracleConnection oracle = new OracleConnection("DATA SOURCE = XE; PASSWORD=1234; USER ID = SYSTEM");
        private string pkgName = "system.pkg_abm_gabriel.";
        public Factura()
        {
            InitializeComponent();
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            BuscarCliente bscCliente = new BuscarCliente();
            bscCliente.Show();
        }
    }
}
