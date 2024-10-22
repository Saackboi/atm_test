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
    public partial class Retiro2 : Form
    {
        Cuenta cuenta;
        string pin;
        Consultas con;
        public Retiro2(Cuenta cuenta, string pin)
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

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                double cantidad = Convert.ToDouble(txtCantidad.Text);

                if (cantidad <= 0)
                {
                    MessageBox.Show("Debe ingresar un valor lógico.");
                    txtCantidad.Clear();
                    txtCantidad.Focus();
                } else if (cantidad > con.getDinero(pin))
                {
                    MessageBox.Show("La cantidad ingresada excede los fondos disponibles.");
                } else if (cantidad % 5 != 0)
                {
                    MessageBox.Show("Este sistema solo entrega billetes multiplos de 5.");
                }
                 else if (cantidad <= con.getDinero(pin) && cantidad <= 5000)
                {
                    txtCantidad.Clear();
                    con.retirarDinero(cantidad, pin);
                    MessageBox.Show("Nuevo saldo disponible: B/. " + con.getDinero(pin));
                    Application.Exit();
                }
                else
                {
                    MessageBox.Show("Cantidad inválida.");
                    txtCantidad.Clear();
                    txtCantidad.Focus();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Formato Inválido");
            }


        }
    }
}
