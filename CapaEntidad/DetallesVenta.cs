using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class DetallesVenta
    {
        public int idDetalleVenta { get; set; }
        public Venta idVenta { get; set; }
        public Producto idProducto { get; set; }
        public int Cantidad { get; set; }
        public decimal PrecioVenta { get; set; }

    }
}
