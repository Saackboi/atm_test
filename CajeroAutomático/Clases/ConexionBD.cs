using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace CajeroAutomático
{
    public class ConexionBD
    {
        private MySqlConnection conexion;
        private string server = "localhost";
        private string database = "cajero";
        private string user = "root";
        private string password = "SackBoy0602";
        private string cn;

        public ConexionBD()
        {
            cn = "Database=" + database +
                "; DataSource=" + server +
                "; User id= " + user +
                "; Password=" + password;
        }

        public MySqlConnection GetConnection()
        {
            if (conexion == null)
            {
                conexion = new MySqlConnection(cn);
                conexion.Open();
            }

            return conexion;
        }
    }
}
