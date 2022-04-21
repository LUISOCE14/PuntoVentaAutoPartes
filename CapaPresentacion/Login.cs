using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btningresar_Click(object sender, EventArgs e)
        {
            //Empleado oempleado = new CN_Empleado().Listar().Where(u => u.IdEmpleado == Convert.ToInt32(txtusuario.Text)).FirstOrDefault();
            if (Convert.ToInt32(txtusuario.Text) == 1)
            {
                Inicio form = new Inicio();
                form.Show();
                this.Hide();
                form.FormClosing += frm_closing;
            }
            else
            {
                MessageBox.Show("No existe usuario", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_closing(object sender, EventArgs e)
        {
            txtusuario.Text = "";
            this.Show();
        }

        private void txtusuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                //Empleado oempleado = new CN_Empleado().Listar().Where(u => u.IdEmpleado == Convert.ToInt32(txtusuario.Text)).FirstOrDefault();
                if (Convert.ToInt32(txtusuario.Text) == 1)
                {
                    Inicio form = new Inicio();
                    form.Show();
                    this.Hide();
                    form.FormClosing += frm_closing;
                }
                else
                {
                    MessageBox.Show("No existe usuario", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }
    }
}
