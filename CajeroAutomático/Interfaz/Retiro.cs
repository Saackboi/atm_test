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
    public partial class Retiro : Form
    {
        Cuenta cuenta;
        string pin;
        Consultas con;

        public Retiro(Cuenta cuenta, string pin)
        {
            InitializeComponent();
            this.cuenta = cuenta;
            this.pin = pin;
            con = new Consultas();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnOtro_Click(object sender, EventArgs e)
        {
            Retiro2 retiro2 = new Retiro2(cuenta, pin);
            retiro2.Show();
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (5 <= con.getDinero(pin))
            {
                con.retirarDinero(5, pin);
                MessageBox.Show("Recoga su dinero.");
                Application.Exit();
            }
            else
            {
                MessageBox.Show("La cantidad excede los fondos disponibles.");
                Application.Exit();
            }
        }

        private void btn10_Click(object sender, EventArgs e)
        {
            if (10 <= con.getDinero(pin))
            {
                con.retirarDinero(10, pin);
                MessageBox.Show("Recoga su dinero.");
                Application.Exit();
            }
            else
            {
                MessageBox.Show("La cantidad excede los fondos disponibles.");
                Application.Exit();
            }
        }

        private void btn20_Click(object sender, EventArgs e)
        {
            if (20 <= con.getDinero(pin))
            {
                con.retirarDinero(20, pin);
                MessageBox.Show("Recoga su dinero.");
                Application.Exit();
            }
            else
            {
                MessageBox.Show("La cantidad excede los fondos disponibles.");
                Application.Exit();
            }
        }

        private void btn50_Click(object sender, EventArgs e)
        {
            if (50 <= con.getDinero(pin))
            {
                con.retirarDinero(50, pin);
                MessageBox.Show("Recoga su dinero.");
                Application.Exit();
            }
            else
            {
                MessageBox.Show("La cantidad excede los fondos disponibles.");
                Application.Exit();
            }
        }

        private void btn100_Click(object sender, EventArgs e)
        {
            if (100 <= con.getDinero(pin))
            {
                con.retirarDinero(100, pin);
                MessageBox.Show("Recoga su dinero.");
                Application.Exit();
            }
            else
            {
                MessageBox.Show("La cantidad excede los fondos disponibles.");
                Application.Exit();
            }
        }
    }
}
