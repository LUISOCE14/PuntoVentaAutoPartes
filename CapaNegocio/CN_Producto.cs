using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidad;


namespace CapaNegocio
{
    public class CN_Producto
    {
        private CD_Producto obj_Prod = new CD_Producto();

        public List<Producto> Listar()
        {
            return obj_Prod.Listar();
        }

        public int obtenerID()
        {
            return obj_Prod.obtenerCorrelativo();
        }

        public int RegistrarProductos(Producto objProd, out string mensaje)
        {
            mensaje = string.Empty;
            if (objProd.nombre == "")
            {
                mensaje += "Es necesario el nombre del producto";
            }
            if (objProd.modelo == "")
            {
                mensaje += "Es necesario el modelo del producto";
            }
            if (objProd.descripcion == "")
            {
                mensaje += "Es necesario la descripcion del producto";
            }
            if (mensaje != string.Empty)
            {
                return 0;
            }
            else
            {

                return obj_Prod.RegistrarProductos(objProd, out mensaje);
            }
        }

        public bool ModificarProductos(Producto objProd, out string mensaje)
        {
            mensaje = string.Empty;
            if (objProd.nombre == "")
            {
                mensaje += "Es necesario el nombre del producto";
            }
            if (objProd.modelo == "")
            {
                mensaje += "Es necesario el modelo del producto";
            }
            if (objProd.descripcion == "")
            {
                mensaje += "Es necesario la descripcion del producto";
            }
            if (mensaje != string.Empty)
            {
                return false;
            }
            else
            {

                return obj_Prod.ModificarProducto(objProd, out mensaje);
            }
        }

        public bool EliminarProducto(Producto objEmp, out string mensaje)
        {
            return obj_Prod.EliminarProducto(objEmp, out mensaje);
        }

    }
}
