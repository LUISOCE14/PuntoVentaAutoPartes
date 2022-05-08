using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaDatos;
using CapaEntidad;

namespace CapaNegocio
{
    public class CN_Venta
    {
        private CD_Venta obj_ventas = new CD_Venta();

        public int obtenerFolio()
        {
            return obj_ventas.obtenerCorrelativo();

        }



        public Venta obtenerVenta(int idventa)
        {
            Venta oventa = obj_ventas.obtenerVenta(idventa);

            if (oventa.idVenta != 0)
            {
                List<DetallesVenta> odetalleventa = obj_ventas.DetallesVenta(oventa.idVenta);
                oventa.oDetalleVentas = odetalleventa;
            }

            return oventa;
        }

        public int RegistrarVenta(Venta objven, DataTable detalleVenta, out string mensaje)
        {

            return obj_ventas.RegistrarVenta(objven, detalleVenta, out mensaje);

        }
    }
}
