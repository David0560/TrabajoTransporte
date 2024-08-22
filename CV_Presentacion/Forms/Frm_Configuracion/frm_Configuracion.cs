using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaServicios;
using CL_Negocios;

namespace CV_Presentacion.Forms
{
    public partial class frm_Configuracion : Form
    {
        public frm_Configuracion(string nombreUsuario)
        {
            InitializeComponent();
            lblNombreUsuario.Text = nombreUsuario;
        }
        public frm_Configuracion()
        {
            InitializeComponent();
        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string nombreUsuario = lblNombreUsuario.Text;
            string contraseñaActual = txtContraseñaActual.Text;
            string nuevaContraseña = txtNuevaContraseña.Text;
            string repetirContraseña = txtRepetir.Text;

            if (string.IsNullOrWhiteSpace(contraseñaActual))
            {
                MessageBox.Show("Debe ingresar la contraseña actual.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (nuevaContraseña == repetirContraseña)
            {
                try
                {
                    CL_administrarRegistros adminRegistros = new CL_administrarRegistros();
                    adminRegistros.CambiarContraseña(nombreUsuario, contraseñaActual, nuevaContraseña);
                    MessageBox.Show("Contraseña cambiada exitosamente.");

                    // Obtener referencia al formulario de login
                    frmLogin loginForm = (frmLogin)Application.OpenForms["frmLogin"];
                    if (loginForm != null)
                    {
                        loginForm.LimpiarCampos(); // Llama al método para limpiar los campos en frmLogin
                        loginForm.Show(); // Mostrar frmLogin
                    }

                    // Cerrar el formulario actual (frm_Configuracion)
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al cambiar la contraseña: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Las contraseñas no coinciden.");
            }
        }

    }
}
/*private void button1_Click(object sender, EventArgs e)
{

}

*/