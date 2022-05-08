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
using CapaPresentacion.Utilidades;

namespace CapaPresentacion
{
    public partial class ConsultarVentas : Form
    {
        public ConsultarVentas()
        {
            InitializeComponent();
        }

        private void ConsultarVentas_Load(object sender, EventArgs e)
        {
            string cadena = "IVA 16%  :";
            label1.Text = cadena;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            decimal iva = 16;
            decimal total1 = 0;
            decimal total2 = 0;
            decimal total3 = 0;

            Venta oVentas = new CN_Venta().obtenerVenta(Convert.ToInt32(txtBuscar.Text));
            if (oVentas.idVenta != 0)
            {
                Fecha1.Text = oVentas.fechaRegistro;
                txtidVendedor.Text = oVentas.idVendedor.IdEmpleado.ToString();
                nomVendedor.Text = oVentas.idVendedor.nombreCompleto;
                IDVENTA.Text = oVentas.idVenta.ToString();
                txtidCliente.Text = oVentas.idCliente.idCliente.ToString();
                nombreClient.Text = oVentas.idCliente.nombre;
                TelefonoClient.Text = oVentas.idCliente.telefono;
                correoClient.Text = oVentas.idCliente.correo;
                DatosVentas.Rows.Clear();

                foreach (DetallesVenta dc in oVentas.oDetalleVentas)
                {
                    DatosVentas.Rows.Add(new object[]
                    {
                        dc.idProducto.idProducto,dc.idProducto.nombre,dc.idProducto.modelo,dc.PrecioVenta,dc.Cantidad,dc.PrecioVenta*dc.Cantidad
                    });
                }



                if (DatosVentas.Rows.Count >= 0)
                {
                    foreach (DataGridViewRow row in DatosVentas.Rows)
                        total1 += Convert.ToDecimal(row.Cells["Importe"].Value);
                }
                subrotal.Text = total1.ToString("0.00");
                iva = iva / 100;
                total2 = iva * total1;
                IVAVENTA.Text = total2.ToString("0.00");
                total3 = total1 + total2;
                total.Text = total3.ToString("0.00");
            }
            else
            {
                MessageBox.Show("No existe la venta");
                txtBuscar.Text = "";
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtBuscar.Text = "";
            Fecha1.Text = "";
            IDVENTA.Text = "";
            txtidVendedor.Text = "";
            nomVendedor.Text = "";
            txtidCliente.Text = "";
            nombreClient.Text = "";
            TelefonoClient.Text = "";
            correoClient.Text = "";
            total.Text = "0";
            subrotal.Text = "";
            IVAVENTA.Text = "";
            DatosVentas.Rows.Clear();
        }
    }
}
