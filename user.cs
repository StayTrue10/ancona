using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registro.mysql
{

    public class user
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public string ticket { get; set; }

        public user() { }
        public user(int uid, string unombre, string uticket)
        {
            this.id = uid;
            this.nombre = unombre;
            this.ticket = uticket;
        }
    }
}
