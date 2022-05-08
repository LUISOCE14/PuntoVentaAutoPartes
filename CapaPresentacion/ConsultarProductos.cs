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
using CapaPresentacion.Utilidades;

namespace CapaPresentacion
{
    public partial class ConsultarProductos : Form
    {
        public ConsultarProductos()
        {
            InitializeComponent();
        }

        private void ConsultarProductos_Load(object sender, EventArgs e)
        {
            txtindice.Text = "-1";
            txtId.Text = "0";


            //Mostrar Lista desde base de datos en tabla 
            List<Producto> listaProd = new CN_Producto().Listar();

            foreach (Producto item in listaProd)
            {
                DatosProd.Rows.Add(new object[] {"", item.idProducto,item.nombre ,item.modelo,item.descripcion,
                    item.valorVenta,
                    item.valorCompra,
                    item.existencias

                });

            }
            foreach (DataGridViewColumn columna in DatosProd.Columns)
            {
                if (columna.Visible == true)
                {
                    if (columna.HeaderText == "ID" || columna.HeaderText == "Nombre" || columna.HeaderText == "Modelo")
                    {
                        cbobusqueda.Items.Add(new OpcionesCombo() { valor = columna.Name, texto = columna.HeaderText });
                    }
                }
            }
            cbobusqueda.DisplayMember = "texto";
            cbobusqueda.ValueMember = "valor";
            cbobusqueda.SelectedIndex = 0;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string columnaFiltro = ((OpcionesCombo)cbobusqueda.SelectedItem).valor.ToString();

            if (DatosProd.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in DatosProd.Rows)
                {
                    if (row.Cells[columnaFiltro].Value.ToString().Trim().ToUpper().Contains(txtBus.Text.Trim().ToUpper()))

                        row.Visible = true;

                    else

                        row.Visible = false;

                }
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtBus.Text = "";
            foreach (DataGridViewRow row in DatosProd.Rows)
            {
                row.Visible = true;
            }
        }

        private void limpiarBoxes()
        {
            txtId.Text = "0";
            txtindice.Text = "-1";
            DescripcionProd.Text = " ";
            nombreProducto.Text = " ";
            ModeloP.Text = " ";
            ValorVentaPr.Text = " ";
            valorCompraPr.Text = "";
            Exis.Text = "";
        }

        private void DatosProd_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DatosProd.Columns[e.ColumnIndex].Name == "btnSelecccionar")
            {

                int indice = e.RowIndex;

                if (indice >= 0)
                {
                    txtindice.Text = indice.ToString();
                    txtId.Text = DatosProd.Rows[indice].Cells["ID"].Value.ToString();
                    nombreProducto.Text = DatosProd.Rows[indice].Cells["nombre"].Value.ToString();
                    ModeloP.Text = DatosProd.Rows[indice].Cells["Modelo"].Value.ToString();
                    DescripcionProd.Text = DatosProd.Rows[indice].Cells["Descripcion"].Value.ToString();
                    ValorVentaPr.Text = DatosProd.Rows[indice].Cells["valorVenta"].Value.ToString();
                    valorCompraPr.Text = DatosProd.Rows[indice].Cells["valorCompra"].Value.ToString();
                    Exis.Text = DatosProd.Rows[indice].Cells["Existencias"].Value.ToString();
                }
            }

            if (DatosProd.Columns[e.ColumnIndex].Name == "btnEliminar")
            {

                int indice = e.RowIndex;
                string mensaje;

                if (indice >= 0)
                {
                    Producto objempl = new Producto()
                    {
                        idProducto = Convert.ToInt32(DatosProd.Rows[indice].Cells["ID"].Value)
                    };

                    if (MessageBox.Show("¿Desea Eliminar al usuario?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {

                        bool respuesta = new CN_Producto().EliminarProducto(objempl, out mensaje);
                        if (respuesta == true)
                        {
                            MessageBox.Show("Se elimino correctamente");
                            DatosProd.Rows.RemoveAt(indice);
                        }
                        else
                        {
                            MessageBox.Show("Este empleado no se puede eliminar por que esta relacionado con una venta");
                        }
                    }



                }
            }
        }

        private void DatosProd_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }
            if (e.ColumnIndex == 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                var w = Properties.Resources.seleccionar.Width;
                var h = Properties.Resources.seleccionar.Height;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(Properties.Resources.seleccionar, new Rectangle(x, y, w, h));
                e.Handled = true;
            }
            if (e.ColumnIndex == 8)
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

        private void EditarProd_Click(object sender, EventArgs e)
        {
            //Editar Productos
            string mensaje = string.Empty;
            Producto objProd = new Producto()
            {
                idProducto = Convert.ToInt32(txtId.Text),
                nombre = nombreProducto.Text,
                modelo = ModeloP.Text,
                descripcion = DescripcionProd.Text,
                valorVenta = Convert.ToDecimal(ValorVentaPr.Text),
                valorCompra = Convert.ToDecimal(valorCompraPr.Text),
                existencias = Convert.ToInt32(Exis.Text),
            };

            bool resuesta = new CN_Producto().ModificarProductos(objProd, out mensaje);
            if (resuesta == false)
            {
                MessageBox.Show(mensaje);
            }
            else
            {
                DataGridViewRow rows = DatosProd.Rows[Convert.ToInt32(txtindice.Text)];
                rows.Cells["ID"].Value = txtId.Text;
                rows.Cells["nombre"].Value = nombreProducto.Text;
                rows.Cells["Modelo"].Value = ModeloP.Text;
                rows.Cells["Descripcion"].Value = DescripcionProd.Text;
                rows.Cells["valorVenta"].Value = ValorVentaPr.Text;
                rows.Cells["valorCompra"].Value = valorCompraPr.Text;
                rows.Cells["Existencias"].Value = Exis.Text;
                limpiarBoxes();
            }
        }

        private void Exis_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
