using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace CajeroAutomático.Clases
{

    public class Consultas
    {
        private ConexionBD cn;
        public double dinero;
        public Consultas()
        {
            this.cn = new ConexionBD();
        }

        public string ConsultaSaldo(string pin)
        {
            MySqlDataReader reader = null;
            string cadena = "";
            string consulta = "select dinero from cuentas where pin=" + pin + ";";


            if (cn.GetConnection() != null)
            {
                MySqlCommand cmd = new MySqlCommand(consulta);
                cmd.Connection = cn.GetConnection();
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    cadena = reader.GetDouble("dinero").ToString();
                }
                reader.Close();
            }
            else
            {
                MessageBox.Show("Error al conectar.");
            }


            return cadena;
        }


        public bool ValidarPin(string pin)
        {
            MySqlDataReader reader = null;
            string cadena = "";
            string consulta = "select * from cuentas";


            if (cn.GetConnection() != null)
            {
                MySqlCommand cmd = new MySqlCommand(consulta);
                cmd.Connection = cn.GetConnection();
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    cadena = reader.GetString("pin");
                    if (cadena == pin)
                    {
                        return true;
                    }
                }
            }
            else
            {
                MessageBox.Show("Error al conectar.");
            }

            MessageBox.Show("El pin no coincide.");
            return false;
        }

        public bool retirarDinero(double retiro, string pin)
        {
            MySqlDataReader reader = null;
            string consulta = "select dinero from cuentas where pin=" + pin + ";";


            if (cn.GetConnection() != null)
            {
                MySqlCommand cmd = new MySqlCommand(consulta);
                cmd.Connection = cn.GetConnection();
                reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    dinero = reader.GetDouble("dinero");
                    reader.Close();

                    consulta = "update cuentas set dinero=" + (dinero - retiro) + " where pin=" + pin + ";";
                    cmd = new MySqlCommand(consulta);
                    cmd.Connection = cn.GetConnection();
                    int r = cmd.ExecuteNonQuery();
                    return true;
                }


            }
            else
            {
                MessageBox.Show("Error al conectar.");
            }

            return false;
        }

        public double getDinero(string pin)
        {
            MySqlDataReader reader = null;
            string consulta = "select dinero from cuentas where pin=" + pin + ";";


            if (cn.GetConnection() != null)
            {
                MySqlCommand cmd = new MySqlCommand(consulta);
                cmd.Connection = cn.GetConnection();
                reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    dinero = reader.GetDouble("dinero");
                }
                reader.Close();

            }
            else
            {
                MessageBox.Show("Error al conectar.");
            }

            return dinero;
        }
    }

}
