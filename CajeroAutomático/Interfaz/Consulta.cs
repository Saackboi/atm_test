using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CajeroAutomático.Clases;

namespace CajeroAutomático
{
    public partial class Consulta : Form
    {
        Cuenta cuenta;
        private Consultas con;
        public Consulta(Cuenta cuenta, string pin)
        {
            InitializeComponent();
            this.cuenta = cuenta;
            con = new Consultas();
            txtConsulta.Text = "B/. " + con.ConsultaSaldo(pin);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
