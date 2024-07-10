using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CL_Negocios;
using CV_Presentacion.Forms;
namespace CV_Presentacion
{
    public partial class frmGuardarRespuestas : Form
    {
        private string nombreUsuario;

        private CL_administrarPreguntas administradorPreguntas = new CL_administrarPreguntas();

        public frmGuardarRespuestas(string nombreUsuario)
        {
            InitializeComponent();
            this.nombreUsuario = nombreUsuario;
            lblNombreUsuario.Text = nombreUsuario;

            // Obtener y mostrar las preguntas al cargar el formulario
            MostrarPreguntas();
        }

        private void MostrarPreguntas()
        {
            List<string> preguntas = administradorPreguntas.ObtenerTresPreguntasAleatorias();

            // Mostrar las preguntas en los labels correspondientes
            if (preguntas.Count >= 3)
            {
                lblPregunta1.Text = preguntas[0];
                lblPregunta2.Text = preguntas[1];
                lblPregunta3.Text = preguntas[2];
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            // Validar que las respuestas no estén vacías
            if (string.IsNullOrWhiteSpace(txtRespuesta1.Text) ||
                string.IsNullOrWhiteSpace(txtRespuesta2.Text) ||
                string.IsNullOrWhiteSpace(txtRespuesta3.Text))
            {
                MessageBox.Show("Por favor, responda todas las preguntas antes de continuar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Salir del método sin guardar respuestas
            }
            // Guardar las respuestas del usuario
            List<Tuple<int, string>> preguntasYRespuestas = new List<Tuple<int, string>>
            {
                new Tuple<int, string>(1, txtRespuesta1.Text), // La pregunta 1 se obtiene aleatoriamente
                new Tuple<int, string>(2, txtRespuesta2.Text), // La pregunta 2 se obtiene aleatoriamente
                new Tuple<int, string>(3, txtRespuesta3.Text)  // La pregunta 3 se obtiene aleatoriamente
            };

            try
            {
                administradorPreguntas.GuardarRespuestasUsuario(nombreUsuario, preguntasYRespuestas);

                // Mostrar mensaje de éxito
                MessageBox.Show("Respuestas guardadas correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Cerrar el formulario actual
                this.Close();

                // Abrir el formulario de configuración
                frm_Configuracion frmCambiar = new frm_Configuracion(nombreUsuario);
                frmCambiar.ShowDialog();
                //this.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar respuestas: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}