using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;
using CapaEntidad;

namespace CapaPresentacion
{
    public partial class RegistrarClientes : Form
    {
        public RegistrarClientes()
        {
            InitializeComponent();
        }

        private void limpiar()
        {
            //LIMPIAR TEXTBOXES
            nombreClient.Text = " ";
            telCliente.Text = " ";
            CorreoClien.Text = " ";
        }

        private void registrar_Click(object sender, EventArgs e)
        {
            string mensaje = string.Empty;
            int id = new CN_Cliente().UltimoId() + 1;
            Cliente objCli = new Cliente()
            {
                idCliente = id,
                nombre = nombreClient.Text,
                telefono = telCliente.Text,
                correo = CorreoClien.Text
            };

            int resuesta = new CN_Cliente().RegistrarClientes(objCli, out mensaje);
            if (resuesta == 0)
            {
                MessageBox.Show(mensaje);
            }
            else
            {
                limpiar();
                MessageBox.Show("Numero identificador: " + resuesta);
            }
        }


    }
}
