using CL_Negocios.Entidades;
using System;
using System.Windows.Forms;
using CL_Negocios;
using System.Runtime.InteropServices;


namespace CV_Presentacion
{
    public partial class frmRecuperarPassword : Form
    {
        CL_administrarPreguntasUsuario preguntasUsuario = new CL_administrarPreguntasUsuario();
        #region Movimiento Ventana
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);
        #endregion
        public frmRecuperarPassword()
        {
            InitializeComponent();
            pnlBarra.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlBarra_MouseDown);
        }
        private void pnlBarra_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
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

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
            Program.login.Show();
        }
    }
}
