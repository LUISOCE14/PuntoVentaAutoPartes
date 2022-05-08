using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
using CapaEntidad;
using CapaNegocio;
using FontAwesome.Sharp;

namespace CapaPresentacion
{
    public partial class Inicio : Form
    {
        private static IconMenuItem menuActivo = null;
        private static Form formularioActivo = null;
        public static Empleado empleadoAct;
        public Inicio(Empleado objEmpleado)
        {
            empleadoAct = objEmpleado;
            InitializeComponent();
        }

        private void AbrirFormulario(IconMenuItem menu, Form formulario)
        {
            if (menuActivo != null)
            {
                menuActivo.BackColor = Color.White;
            }
            menu.BackColor = Color.Silver;
            menuActivo = menu;
            if (formularioActivo != null)
            {
                formularioActivo.Close();
            }
            formularioActivo = formulario;
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;

            Contenedor.Controls.Add(formulario);
            formulario.Show();


        }

        private void CerrarAplicacion_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void RegistrarClientes_Click(object sender, EventArgs e)
        {
            AbrirFormulario(RegistrarClientes, new RegistrarClientes());
        }

        private void consultarClientes_Click(object sender, EventArgs e)
        {
            AbrirFormulario(consultarClientes, new ConsultarClientes());
        }

        private void registrarVenta_Click(object sender, EventArgs e)
        {
            AbrirFormulario(registrarVenta, new RegistrarVentas(empleadoAct));
        }

        private void registrarProducto_Click(object sender, EventArgs e)
        {
            AbrirFormulario(registrarProducto, new RegistrarProductos());
        }

        private void ConsultarProductos_Click(object sender, EventArgs e)
        {
            AbrirFormulario(ConsultarProductos, new ConsultarProductos());
        }

        private void registrarEmpleados_Click(object sender, EventArgs e)
        {
            AbrirFormulario(registrarEmpleados, new RegistrarEmpleados());
        }

        private void consultarEmpleados_Click(object sender, EventArgs e)
        {
            AbrirFormulario(consultarEmpleados, new ConsultarEmpleados());
        }

        private void iconPictureBox1_Click(object sender, EventArgs e)
        {
            Contenedor.Controls.Clear();
            if (menuActivo != null)
            {
                menuActivo.BackColor = Color.White;
            }
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea salir?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            NombreUsuario.Text = empleadoAct.nombreCompleto;
        }

        private void consultarVenta_Click(object sender, EventArgs e)
        {
            AbrirFormulario(consultarEmpleados, new ConsultarVentas());
        }
    }
}
