using CL_Negocios.Entidades;
using System;
using System.Windows.Forms;
using CL_Negocios;


namespace CV_Presentacion
{
    public partial class frmRecuperarPassword : Form
    {
        CL_administrarPreguntasUsuario preguntasUsuario = new CL_administrarPreguntasUsuario();
        public frmRecuperarPassword()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nombreUsuario = txtUsuario.Text.Trim();

            if (preguntasUsuario.VerificarUsuario(nombreUsuario))
            {
                if (preguntasUsuario.UsuarioTienePreguntas(nombreUsuario))
                {
                    Usuario usuario = preguntasUsuario.ObtenerUsuario(nombreUsuario);

                    // Abrir el formulario de respuestas y pasar el objeto Usuario
                    
                    this.Close(); // Ocultar el formulario actual
                    frmRespuestas respuesta = new frmRespuestas(usuario);
                    respuesta.ShowDialog();
                    //this.Show(); // Mostrar nuevamente el formulario actual después de cerrar frmRespuestas
                }
                else
                {
                    MessageBox.Show("El usuario no tiene preguntas de seguridad cargadas.");
                }
            }
            else
            {
                MessageBox.Show("Usuario no encontrado.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Program.login.Show();


        }
    }
}
