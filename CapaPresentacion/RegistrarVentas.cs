using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaPresentacion.Utilidades;
using CapaNegocio;
using CapaEntidad;

namespace CapaPresentacion
{
    public partial class RegistrarVentas : Form
    {

        Cliente _clientes;
        Producto productos;
        Producto oProducto = null;
        List<Producto> lista = new CN_Producto().Listar();
        bool ProductoExiste = false;
        List<Empleado> listaEmps = new List<Empleado>();
        private Empleado Emp;
        int folio = new CN_Venta().obtenerFolio() +1;

        public RegistrarVentas(Empleado emp = null)
        {
            Emp = emp;
            InitializeComponent();
        }
        void limpiar()
        {
            txtIdCliente.Text = "";
            txtIdCliente.BackColor = Color.White;
            nombreCliente.Text = "";
            telefonoCliente.Text = "";
            CorreoCliente.Text = "";
            total.Text = "0.00";
            Subtotal.Text = "0.00";
            Iva.Text = "0.00";

        }

        private void RegistrarVentas_Load(object sender, EventArgs e)
        {
            int IVA = 0;

            IdEmpleado.Text = Emp.IdEmpleado.ToString();
            nombreEmpleado.Text = Emp.nombreCompleto;
            fechaVenta.Text = DateTime.Now.ToString("dd/MM/yyyy");
            Subtotal.Text = "0.00";
            Iva.Text = "0.00";
            total.Text = "0.00";
            IDVENTA.Text = folio.ToString();

            string cadena = "IVA 16%:";
            label21.Text = cadena;

        }

        private void txtIdCliente_KeyDown(object sender, KeyEventArgs e)
        {
            
                if (e.KeyData == Keys.Enter)
                {
              
                    Cliente oCliente = new CN_Cliente().Listar().Where(c => c.idCliente == Convert.ToInt32(txtIdCliente.Text)).FirstOrDefault();

                    if (oCliente != null)
                    {
                        txtIdCliente.BackColor = Color.Honeydew;
                        txtIdCliente.Text = oCliente.idCliente.ToString();
                        nombreCliente.Text = oCliente.nombre;
                        telefonoCliente.Text = oCliente.telefono;
                        CorreoCliente.Text = oCliente.correo;
                    }
                    else
                    {
                        txtIdCliente.BackColor = Color.MistyRose;
                        MessageBox.Show("No existe el cliente con ese id");

                    }
                
                }
            
        }

        private void CodigoProducto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                foreach (Producto item in lista)
                {
                    if (item.idProducto == Convert.ToInt32(CodigoProducto.Text))
                    {
                        oProducto = item;

                        break;
                    }

                }

                if (oProducto != null)
                {
                    foreach (DataGridViewRow fila in DatosVentas.Rows)
                    {
                        if (fila.Cells["ID"].Value.ToString() == CodigoProducto.Text)
                        {
                            ProductoExiste = true;
                            break;
                        }
                    }

                    CodigoProducto.BackColor = Color.Honeydew;
                    NombreProd.Text = oProducto.nombre;
                    CodigoProducto.Text = oProducto.idProducto.ToString();
                    PrecioP.Text = oProducto.valorVenta.ToString("0.00");
                    stock.Text = oProducto.existencias.ToString();
                    modelo.Text = oProducto.modelo.ToString();


                }
                else
                {
                    CodigoProducto.BackColor = Color.MistyRose;
                    MessageBox.Show("El producto no existe");
                }


            }
        }

        private void AgrProdVen_Click(object sender, EventArgs e)
        {
            decimal precioventa = 0;

            if (CodigoProducto.Text == "")
            {
                MessageBox.Show("Debe seleccionar un producto", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (Convert.ToInt32(stock.Text) < CantidadPro.Value || CantidadPro.Value > Convert.ToInt32(stock.Text))
            {
                MessageBox.Show("No hay suficiente stock");
                return;
            }


            precioventa = Convert.ToDecimal(PrecioP.Text);

            if (!ProductoExiste)
            {

                DatosVentas.Rows.Add(new object[] {
                CodigoProducto.Text,
                NombreProd.Text,
                modelo.Text,
                precioventa.ToString("0.00"),
                CantidadPro.Value,
                (CantidadPro.Value * precioventa).ToString("0.00")
                });

                CalcularSubtotal();
                lista.Where(w => w.idProducto == Convert.ToInt32(CodigoProducto.Text)).Select(w => w.existencias = (int)(w.existencias - CantidadPro.Value)).ToList();
                limpiarProduto();
                CodigoProducto.Select();
            }
            else
            {
                foreach (DataGridViewRow fila in DatosVentas.Rows)
                {
                    if (fila.Cells["ID"].Value.ToString() == CodigoProducto.Text)
                    {
                        fila.Cells["Cantidad"].Value = Convert.ToInt32(fila.Cells["Cantidad"].Value) + CantidadPro.Value;
                        fila.Cells["Importe"].Value = Convert.ToDecimal(fila.Cells["PrecioVenta"].Value) * Convert.ToInt32(fila.Cells["Cantidad"].Value);
                        CalcularSubtotal();
                        lista.Where(w => w.idProducto == Convert.ToInt32(CodigoProducto.Text)).Select(w => w.existencias = (int)(w.existencias - CantidadPro.Value)).ToList();
                        limpiarProduto();
                        CodigoProducto.Select();
                        break;
                    }
                }
            }
        }

        private void limpiarProduto()
        {
            CodigoProducto.Text = "";
            NombreProd.Text = "";
            modelo.Text = "";
            PrecioP.Text = "";
            CantidadPro.Value = 1;
            stock.Text = "";
            CodigoProducto.BackColor = Color.White;
            ProductoExiste = false;
        }
        private void CalcularSubtotal()
        {
            decimal total1 = 0;
            if (DatosVentas.Rows.Count >= 0)
            {
                foreach (DataGridViewRow row in DatosVentas.Rows)
                    total1 += Convert.ToDecimal(row.Cells["Importe"].Value.ToString());
            }

            Subtotal.Text = total1.ToString("0.00");
            CalcularIva();
        }

        private void CalcularIva()
        {
            decimal total = 0;
            decimal iva = 16;
            iva = iva / 100;
            total = iva * Convert.ToDecimal(Subtotal.Text);

            Iva.Text = total.ToString("0.00");
            Calculartotal();
        }
        private void Calculartotal()
        {
            decimal total1 = 0;
            total1 = Convert.ToDecimal(Subtotal.Text) + Convert.ToDecimal(Iva.Text);

            total.Text = total1.ToString("0.00");
        }

        private void DatosVentas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DatosVentas.Columns[e.ColumnIndex].Name == "btnEliminar")
            {

                int indice = e.RowIndex;
                int i = 0;
                foreach (DataGridViewRow row in DatosVentas.Rows)
                {
                    if (i == indice)
                    {
                        lista.Where(w => w.idProducto == Convert.ToInt32(row.Cells["ID"].Value)).Select(w => w.existencias = (int)(w.existencias + Convert.ToInt32(row.Cells["Cantidad"].Value))).ToList();
                        break;
                    }
                    i++;
                }

                if (indice >= 0)
                {
                    DatosVentas.Rows.RemoveAt(indice);
                    CalcularSubtotal();

                }
            }
        }

        private void DatosVentas_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }
            if (e.ColumnIndex == 6)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                var w = Properties.Resources.delete.Width;
                var h = Properties.Resources.delete.Height;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(Properties.Resources.delete, new Rectangle(x, y, w, h));
                e.Handled = true;
            }
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txtIdCliente.Text) == 0)
            {
                MessageBox.Show("Debe seleccionar un cliente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (DatosVentas.Rows.Count < 1)
            {
                MessageBox.Show("Agrega productos para poder registrar la venta");
                return;
            }
            DataTable detalleVenta = new DataTable();
            detalleVenta.Columns.Add("IdProduto", typeof(int));
            detalleVenta.Columns.Add("Cantidad", typeof(int));
            detalleVenta.Columns.Add("PrecioVenta", typeof(decimal));

            foreach (DataGridViewRow row in DatosVentas.Rows)
            {
                detalleVenta.Rows.Add(new object[]
                {
                    row.Cells["ID"].Value.ToString(),
                    row.Cells["Cantidad"].Value.ToString(),
                    row.Cells["PrecioVenta"].Value.ToString()
                });

            }

            Venta oVentas = new Venta()
            {
                idCliente = new Cliente() { idCliente = Convert.ToInt32(txtIdCliente.Text), },
                idVendedor = new Empleado() { IdEmpleado = Convert.ToInt32(IdEmpleado.Text) },

            };


            string mensaje = string.Empty;
            int respuesta = new CN_Venta().RegistrarVenta(oVentas, detalleVenta, out mensaje);
            if (respuesta > 0)
            {
                var result = MessageBox.Show("Numero de venta:\n" + folio.ToString());
                CodigoProducto.Text = "";
                DatosVentas.Rows.Clear();
                folio = new CN_Venta().obtenerFolio()+1;
                IDVENTA.Text = folio.ToString();
                fechaVenta.Text = DateTime.Now.ToString("dd/MM/yyyy");
                limpiarProduto();
                limpiar();
                Calculartotal();

            }
            else
            {
                MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
