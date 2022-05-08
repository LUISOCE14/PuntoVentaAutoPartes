using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidad;

namespace CapaNegocio
{
    public class CN_Empleado
    {
        private CD_Empleado obj_Emp = new CD_Empleado();
        public List<Empleado> Listar()
        {
            return obj_Emp.Listar();
        }

        public int RegistrarEmpleado(Empleado objEmp, out string mensaje)
        {
            mensaje = string.Empty;
            if (objEmp.nombreCompleto == "")
            {
                mensaje += "Es necesario capturar el nombre del empleado";
            }
            if (objEmp.telefono == "")
            {
                mensaje += "Es necesario el telefono del empleado";
            }
            if (mensaje != string.Empty)
            {
                return 0;
            }
            else
            {

                return obj_Emp.RegistrarEmpleado(objEmp, out mensaje);
            }
        }

        public bool EditarEmpleado(Empleado objEmp, out string mensaje)
        {
            return obj_Emp.EditarEmpleado(objEmp, out mensaje);
        }
        
        public bool EliminarEmpleado(Empleado objEmp, out string mensaje)
        {
            return obj_Emp.EliminarEmpleado(objEmp, out mensaje);
        }
        
        public int UltimoId()
        {
            return obj_Emp.ultimoId();
        }
    }
}
