using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Producto
    {
        public int idProducto { get; set; }
        public string nombre { get; set; }
        public string modelo { get; set; }
        public string descripcion { get; set; }
        public decimal valorVenta { get; set; }
        public decimal valorCompra { get; set; }
        public int existencias { get; set; }
    }
}
