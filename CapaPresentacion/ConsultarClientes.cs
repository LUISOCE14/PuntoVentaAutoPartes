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
using CapaEntidad;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class ConsultarClientes : Form
    {
        public ConsultarClientes()
        {
            InitializeComponent();
        }

        private void ConsultarClientes_Load(object sender, EventArgs e)
        {
            foreach (DataGridViewColumn columna in DatosClientes.Columns)
            {
                if (columna.Visible == true)
                {
                    if (columna.HeaderText == "Correo" || columna.HeaderText == "Nombre" || columna.HeaderText == "ID")
                    {
                        cbobusqueda.Items.Add(new OpcionesCombo() { valor = columna.Name, texto = columna.HeaderText });
                    }
                }
            }
            cbobusqueda.DisplayMember = "texto";
            cbobusqueda.ValueMember = "valor";
            cbobusqueda.SelectedIndex = 0;

            //Mostrar Clientes
            List<Cliente> listaCli = new CN_Cliente().Listar();

            foreach (Cliente item in listaCli)
            {
                DatosClientes.Rows.Add(new object[] {"", item.idCliente,item.nombre ,item.correo,item.telefono,
                });

            }
        }
        private void limpiar()
        {
            txtIndi.Text = "-1";
            txtid.Text = "0";
            NombreClien.Text = " ";
            CorreoCliente.Text = " ";
            telCliente.Text = " ";
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string columnaFiltro = ((OpcionesCombo)cbobusqueda.SelectedItem).valor.ToString();

            if (DatosClientes.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in DatosClientes.Rows)
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
            foreach (DataGridViewRow row in DatosClientes.Rows)
            {
                row.Visible = true;
            }
        }

        private void btnEditarClien_Click(object sender, EventArgs e)
        {
            string mensaje = string.Empty;
            Cliente objCli = new Cliente()
            {
                idCliente = Convert.ToInt32(txtid.Text),
                nombre = NombreClien.Text,
                correo = CorreoCliente.Text,
                telefono = telCliente.Text,
            };

            bool resultado = new CN_Cliente().ModificarClientes(objCli, out mensaje);
            if (resultado)
            {
                DataGridViewRow rows = DatosClientes.Rows[Convert.ToInt32(txtIndi.Text)];
                rows.Cells["IDCliente"].Value = txtid.Text;
                rows.Cells["Nombre"].Value = NombreClien.Text;
                rows.Cells["Correo"].Value = CorreoCliente.Text;
                rows.Cells["telCli"].Value = telCliente.Text;
                limpiar();
            }
            else
            {
                MessageBox.Show(mensaje);
            }
        }

        private void DatosClientes_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
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
            if (e.ColumnIndex == 5)
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

        private void DatosClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DatosClientes.Columns[e.ColumnIndex].Name == "btnSelecccionar")
            {
                int indice = e.RowIndex;

                if (indice >= 0)
                {
                    txtIndi.Text = indice.ToString();
                    txtid.Text = DatosClientes.Rows[indice].Cells["IDCliente"].Value.ToString();
                    NombreClien.Text = DatosClientes.Rows[indice].Cells["Nombre"].Value.ToString();
                    CorreoCliente.Text = DatosClientes.Rows[indice].Cells["Correo"].Value.ToString();
                    telCliente.Text = DatosClientes.Rows[indice].Cells["telCli"].Value.ToString();
                }
            }

            if (DatosClientes.Columns[e.ColumnIndex].Name == "btnEliminar")
            {
                int indice = e.RowIndex;
                string mensaje;

                if (indice >= 0)
                {
                    Cliente objcli = new Cliente()
                    {
                        idCliente = Convert.ToInt32(DatosClientes.Rows[indice].Cells["ID"].Value)
                    };

                    if (MessageBox.Show("¿Desea Eliminar al usuario?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {

                        bool respuesta = new CN_Cliente().EliminarCliente(objcli,out mensaje);
                        if (respuesta == true)
                        {
                            MessageBox.Show("Se elimino correctamente");
                            DatosClientes.Rows.RemoveAt(indice);
                        }
                        else
                        {
                            MessageBox.Show("Este empleado no se puede eliminar por que esta relacionado con una venta");
                        }
                    }



                }
            }
        }
    }
}
