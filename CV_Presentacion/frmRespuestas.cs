using CL_Negocios.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CV_Presentacion
{
    public partial class frmRespuestas : Form
    {
        private frmLogin loginForm;
        private Usuario usuario;
        private int intentosFallidos = 0; // Contador de intentos fallidos

        public frmRespuestas(Usuario usuario)
        {
            InitializeComponent();
            this.usuario = usuario;

            // Mostrar preguntas del usuario en los labels correspondientes
            MostrarPreguntas();
        }

        private void MostrarPreguntas()
        {
            // Mostrar las preguntas en los labels correspondientes
            if (usuario.PreguntasSeguridad.Count >= 1)
                lblPregunta1.Text = usuario.PreguntasSeguridad[0];
            if (usuario.PreguntasSeguridad.Count >= 2)
                lblPregunta2.Text = usuario.PreguntasSeguridad[1];
            if (usuario.PreguntasSeguridad.Count >= 3)
                lblPregunta3.Text = usuario.PreguntasSeguridad[2];
        }


        private void btnAceptar_Click_1(object sender, EventArgs e)
        {
            // Obtener respuestas ingresadas por el usuario
            List<string> respuestasUsuario = new List<string>
            {
                txtRespuesta1.Text.Trim(),
                txtRespuesta2.Text.Trim(),
                txtRespuesta3.Text.Trim()
            };

            // Validar respuestas con las respuestas almacenadas del usuario
            bool respuestasCorrectas = usuario.ValidarRespuestasSeguridad(respuestasUsuario);

            if (respuestasCorrectas)
            {
                MessageBox.Show("Contraseña enviada.");

                // Cerrar el formulario actual (frmRespuestas)
                this.Close();

                // Mostrar el formulario frmLogin
                if (loginForm == null || loginForm.IsDisposed)
                    loginForm = new frmLogin();
                loginForm.Show();
            }
            else
            {
                intentosFallidos++;

                if (intentosFallidos >= 3)
                {
                    MessageBox.Show("Usuario bloqueado. Contacte al administrador.");
                    // Cerrar todo y mostrar el formulario frmLogin
                    this.Close();
                    MostrarLoginForm();
                }
                else
                {
                    MessageBox.Show("Respuestas incorrectas. Intente nuevamente.");
                    // Puedes decidir si quieres cerrar el formulario o permitir más intentos
                }
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            frmLogin home = new frmLogin();
            this.Close();
            home.Show();
            //if (MessageBox.Show("Estas por Cerrar la sesion, ¿Estas seguro?", "Atencion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            //this.Close();
        }

        private void MostrarLoginForm()
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form is frmLogin)
                {
                    loginForm = (frmLogin)form;
                    loginForm.Show();
                }
                else
                {
                    form.Close();
                }
            }
        }
        
    }
}
