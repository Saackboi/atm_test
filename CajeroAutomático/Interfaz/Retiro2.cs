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
    public partial class Retiro2 : Form
    {
        Cuenta cuenta;
        public Retiro2(Cuenta cuenta)
        {
            InitializeComponent();
            this.cuenta = cuenta;
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
                } else if (cantidad > cuenta.dinero)
                {
                    MessageBox.Show("La cantidad ingresada excede los fondos disponibles.");
                } else if (cantidad % 5 != 0)
                {
                    MessageBox.Show("Este sistema solo entrega billetes multiplos de 5.");
                }
                 else if (cantidad <= cuenta.dinero && cantidad <= 5000)
                {
                    txtCantidad.Clear();
                    cuenta.dinero -= cantidad;
                    MessageBox.Show("Nuevo saldo disponible: B/. " + cuenta.getDinero());
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
