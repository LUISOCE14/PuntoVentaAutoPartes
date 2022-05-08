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
    public partial class ConsultarEmpleados : Form
    {
        public ConsultarEmpleados()
        {
            InitializeComponent();
        }

        private void ConsultarEmpleados_Load(object sender, EventArgs e)
        {

            foreach (DataGridViewColumn columna in DatosEmpleados.Columns)
            {
                if (columna.Visible == true)
                {
                    if (columna.HeaderText == "Correo" || columna.HeaderText == "Nombre" || columna.HeaderText == "Cargo" || columna.HeaderText == "ID")
                    {
                        cbobusqueda.Items.Add(new OpcionesCombo() { valor = columna.Name, texto = columna.HeaderText });
                    }
                }
            }
            cbobusqueda.DisplayMember = "texto";
            cbobusqueda.ValueMember = "valor";
            cbobusqueda.SelectedIndex = 0;

            //Mostrar Lista desde base de datos en tabla 
            List<Empleado> listaEmpl = new CN_Empleado().Listar();

            foreach (Empleado item in listaEmpl)
            {
                DatosEmpleados.Rows.Add(new object[] {"", item.IdEmpleado,item.nombreCompleto ,item.telefono,item.correo,
    
                });

            }
        }

        private void DatosEmpleados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DatosEmpleados.Columns[e.ColumnIndex].Name == "btnSelecccionar")
            {

                int indice = e.RowIndex;

                if (indice >= 0)
                {
                    txtIn.Text = indice.ToString();
                    txtid.Text = DatosEmpleados.Rows[indice].Cells["ID"].Value.ToString();
                    NombreEmpl.Text = DatosEmpleados.Rows[indice].Cells["NombreEm"].Value.ToString();
                    telEmple.Text = DatosEmpleados.Rows[indice].Cells["Telefono"].Value.ToString();
                    CorreoEmple.Text = DatosEmpleados.Rows[indice].Cells["CorreoEmpleado"].Value.ToString();


                }
            }
            if (DatosEmpleados.Columns[e.ColumnIndex].Name == "btnElimimar")
            {

                int indice = e.RowIndex;
                string mensaje;

                if (indice >= 0)
                {
                    Empleado objempl = new Empleado()
                    {
                        IdEmpleado = Convert.ToInt32(DatosEmpleados.Rows[indice].Cells["ID"].Value)
                    };

                    if (MessageBox.Show("¿Desea Eliminar al usuario?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {

                        bool respuesta = new CN_Empleado().EliminarEmpleado(objempl, out mensaje);
                        if (respuesta == true)
                        {
                            MessageBox.Show("Se elimino correctamente");
                            DatosEmpleados.Rows.RemoveAt(indice);
                        }
                        else
                        {
                            MessageBox.Show("Este empleado no se puede eliminar por que esta relacionado con una venta");
                        }
                    }



                }
            }
        }

        private void DatosEmpleados_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
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

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string columnaFiltro = ((OpcionesCombo)cbobusqueda.SelectedItem).valor.ToString();

            if (DatosEmpleados.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in DatosEmpleados.Rows)
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
            foreach (DataGridViewRow row in DatosEmpleados.Rows)
            {
                row.Visible = true;
            }
        }

        private void EditarEmpl_Click(object sender, EventArgs e)
        {
            string mensaje = string.Empty;
            Empleado objEmp = new Empleado()
            {
                IdEmpleado = Convert.ToInt32(txtid.Text),
                nombreCompleto = NombreEmpl.Text,
                telefono = telEmple.Text,
                correo = CorreoEmple.Text,
               
            };

            bool resultado = new CN_Empleado().EditarEmpleado(objEmp, out mensaje);
            if (resultado)
            {
                DataGridViewRow rows = DatosEmpleados.Rows[Convert.ToInt32(txtIn.Text)];
                rows.Cells["ID"].Value = txtid.Text;
                rows.Cells["NombreEm"].Value = NombreEmpl.Text;
                rows.Cells["Telefono"].Value = telEmple.Text;
                rows.Cells["CorreoEmpleado"].Value = CorreoEmple.Text;
                limpiar();
            }
            else
            {
                MessageBox.Show(mensaje);
            }
        }

        private void limpiar()
        {
            txtIn.Text = "-1";
            txtid.Text = "0";
            NombreEmpl.Text = " ";
            CorreoEmple.Text = " ";
            telEmple.Text = " ";
        }
    }
}
