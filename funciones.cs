using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Registro.mysql
{
    public class funciones
    {
        public static int agregar(user add)
        {
            int retorno = 0;
            MySqlCommand comando = new MySqlCommand(String.Format("insert into usuarios(nombre, ticket)values('{0}','{1}')", add.nombre, add.ticket), conexion.obtenerConexion());
            retorno = comando.ExecuteNonQuery();
            return retorno;
        }
    }
}
