using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CajeroAutomático
{
    public class Cuenta
    {
        public string pin;
        public double dinero;

        public Cuenta(string pin, double dinero)
        {
            this.pin = pin;
            this.dinero = dinero;
        }

        public void RetirarDinero(double retiro)
        {
            if (this.dinero >= retiro)
            {
                this.dinero -= retiro;
            } else
            {
                MessageBox.Show("La cantidad ingresada excede los fondos disponibles.");
            }
        }

        public void DepositarDinero(int deposito)
        {
            this.dinero += deposito;
        }

        public double getDinero()
        {
            return this.dinero;
        }
    }
}
