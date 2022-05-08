using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Cliente
    {
       public int idCliente { get; set; }
        public string nombre { get; set; }

        public string telefono { get; set; }

        public string correo { get; set; }

        public bool estado { get; set; }
    }
}
