using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Registro.mysql
{
    class conexion
    {
        public static MySqlConnection obtenerConexion()
        {
            MySqlConnection conexion = new MySqlConnection("server=127.0.0.1; database=registros; Uid=root; pwd=;");
            conexion.Open();
            return conexion;
        }
    }
}
