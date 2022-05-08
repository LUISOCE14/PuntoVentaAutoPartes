using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidad;
using CapaNegocio;


namespace CapaPresentacion
{
    public partial class RegistrarEmpleados : Form
    {
        public RegistrarEmpleados()
        {
            InitializeComponent();
        }
        private void limpiar()
        {
            //LIMPIAR TEXTBOX
            nombreEmpleado.Text = " ";
            correoEmpleado.Text = " ";
            telEmpleado.Text = " ";
        }

        private void RegistrarEmpleados_Load(object sender, EventArgs e)
        {

        }

        private void registrar_Click(object sender, EventArgs e)
        {
            //Registrar Empleados
            string mensaje = string.Empty;
            int id = new CN_Empleado().UltimoId() + 1;
            Empleado objEmp = new Empleado()
            {
                IdEmpleado = id,
                nombreCompleto = nombreEmpleado.Text,
                telefono = telEmpleado.Text,
                correo = correoEmpleado.Text,
            };

            int idUsuarioGenerado = new CN_Empleado().RegistrarEmpleado(objEmp, out mensaje);
            if (idUsuarioGenerado == 0)
            {
                MessageBox.Show(mensaje);
            }
            else
            {
                MessageBox.Show("Registro Exitoso");
                limpiar();
            }
        }
    }
}
