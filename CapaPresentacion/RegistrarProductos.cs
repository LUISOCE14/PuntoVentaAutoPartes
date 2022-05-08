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
    public partial class RegistrarProductos : Form
    {
        public RegistrarProductos()
        {
            InitializeComponent();
        }

        private void RegistrarProductos_Load(object sender, EventArgs e)
        {

        }

        private void limpiar()
        {
            //LIMPIAR TEXTBOX
            nombreProducto.Text = " ";
            Modelo.Text = " ";
            DescrProducto.Text = " ";

            ValorCompra.Text = " ";
        }

        private void registrar_Click(object sender, EventArgs e)
        {
            int band = 0;
            if (int.TryParse(ValorCompra.Text, out int ejemp))
            {

            }
            else if (ValorCompra.Text == "")
            {
                ValorCompra.Text = Convert.ToDecimal(0).ToString();
            }
            else
            {
                MessageBox.Show("Solo se aceptan numeros en el campo de valor de compra");
                band = 1;

            }

            if (band == 0)
            {
                //Registrar Productos
                string mensaje = string.Empty;
                int id = new CN_Producto().obtenerID() + 1;
                Producto objProd = new Producto()
                {
                    idProducto = id,
                    nombre = nombreProducto.Text,
                    modelo = Modelo.Text,
                    descripcion = DescrProducto.Text,
                    valorCompra = Convert.ToDecimal(ValorCompra.Text),
                    existencias = 0
                };

                int resuesta = new CN_Producto().RegistrarProductos(objProd, out mensaje);
                if (resuesta == 0)
                {
                    MessageBox.Show(mensaje);
                }
                else
                {
                    limpiar();
                    MessageBox.Show("Registro Exitoso");
                }
            }
        }

        private void VentaProducto_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
