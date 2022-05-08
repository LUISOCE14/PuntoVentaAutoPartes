using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Venta
    {
        public int idVenta { get; set; }
        public Cliente idCliente { get; set; }
        public Empleado idVendedor { get; set; }
        public List<DetallesVenta> oDetalleVentas { get; set; }
        public string fechaRegistro { get; set; }
    }
}
