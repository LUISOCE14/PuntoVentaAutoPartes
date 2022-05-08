using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidad;


namespace CapaNegocio
{
    public class CN_Cliente
    {
        private CD_Cliente obj_cli = new CD_Cliente();

        public List<Cliente> Listar()
        {
            return obj_cli.Listar();
        }

        public int UltimoId()
        {
            return obj_cli.obtenerCorrelativo();
        }

        public int RegistrarClientes(Cliente objclie, out string mensaje)
        {
            mensaje = string.Empty;

            if (objclie.nombre == "")
            {
                mensaje += "Es necesario el nombre del cliente";
            }
            if (objclie.telefono == "" || objclie.telefono.All(char.IsLetter))
            {
                mensaje += "Es necesario el numero del cliente";
            }
            if (objclie.correo == "")
            {
                mensaje += "Es necesario llenar el campo correo";
            }
            if (mensaje != string.Empty)
            {
                return 0;
            }
            else
            {
                return obj_cli.RegistrarClientes(objclie, out mensaje);
            }
        }

        public bool ModificarClientes(Cliente objclie, out string mensaje)
        {
            mensaje = string.Empty;
            if (objclie.nombre == "")
            {
                mensaje += "Es necesario el nombre del cliente";
            }
            if (objclie.telefono == "" || objclie.telefono.All(char.IsLetter))
            {
                mensaje += "Es necesario el telefono del cliente";
            }
           
            if (objclie.correo == "")
            {
                mensaje += "Es necesario llenar el campo correo";
            }
            if (mensaje != string.Empty)
            {
                return false;
            }
            else
            {

                return obj_cli.ModificarCliente(objclie, out mensaje);
            }
        }

        public bool EliminarCliente(Cliente objClie, out string mensaje)
        {
            return obj_cli.EliminarCliente(objClie, out mensaje);
        }
    }
}
