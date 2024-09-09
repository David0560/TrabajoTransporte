using System;
using System.Collections.Generic;
using System.Windows.Forms;
using CL_Negocios;
using CV_Presentacion.Forms;

namespace CV_Presentacion
{
    public partial class frmGuardarRespuestas : Form
    {
        private string nombreUsuario;
        private CL_administrarPreguntas administradorPreguntas = new CL_administrarPreguntas();
        private List<Tuple<int, string>> preguntasAleatorias;

        public frmGuardarRespuestas(string nombreUsuario)
        {
            InitializeComponent();
            this.nombreUsuario = nombreUsuario;
            lblNombreUsuario.Text = nombreUsuario;

            // Obtener y mostrar las preguntas al cargar el formulario
            MostrarPreguntas();
        }

        // Obtiene y muestra tres preguntas aleatorias
        private void MostrarPreguntas()
        {
            preguntasAleatorias = administradorPreguntas.ObtenerTresPreguntasAleatorias();

            // Mostrar las preguntas en los labels correspondientes
            if (preguntasAleatorias.Count >= 3)
            {
                lblPregunta1.Text = preguntasAleatorias[0].Item2;
                lblPregunta2.Text = preguntasAleatorias[1].Item2;
                lblPregunta3.Text = preguntasAleatorias[2].Item2;
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
                new Tuple<int, string>(preguntasAleatorias[0].Item1, txtRespuesta1.Text),
                new Tuple<int, string>(preguntasAleatorias[1].Item1, txtRespuesta2.Text),
                new Tuple<int, string>(preguntasAleatorias[2].Item1, txtRespuesta3.Text)
            };

            try
            {
                administradorPreguntas.GuardarRespuestasUsuario(nombreUsuario, preguntasYRespuestas);

                // Mostrar mensaje de éxito
                MessageBox.Show("Respuestas guardadas correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                // Cerrar el formulario actual
                                this.Close();
                // Abrir el formulario de configuración antes de cerrar el formulario actual
                frm_Actualizar frmCambiar = new frm_Actualizar(nombreUsuario);
                frmCambiar.ShowDialog();

                
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