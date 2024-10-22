using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CajeroAutomático
{
    public partial class Opciones : Form
    {
        Cuenta cuenta;
        string pin;
        public Opciones(Cuenta cuenta, string pin)
        {
            InitializeComponent();
            this.cuenta = cuenta;
            this.pin = pin;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnRetirar_Click(object sender, EventArgs e)
        {
            Retiro ret = new Retiro(cuenta, pin.ToString());
            ret.Show();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            Consulta cons = new Consulta(cuenta, pin.ToString());
            cons.Show();
            this.Hide();
        }
    }
}
