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
    public partial class Inicio : Form
    {
        Cuenta c1, c2, c3, c4, c5, cuenta;
        Consultas con;

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        Cuenta[] cuentas;
        bool pinCorrecto = false;
        public Inicio()
        {
            InitializeComponent();
            con = new Consultas();
        }



        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                string pin = txtPin.Text;
                if (con.ValidarPin(pin))
                {
                    txtPin.Clear();
                    Opciones opc = new Opciones(cuenta, pin);
                    opc.Show();
                }
            } catch (Exception)
            {
                MessageBox.Show("Formato Inválido");
            }
            

        }
    }
}
