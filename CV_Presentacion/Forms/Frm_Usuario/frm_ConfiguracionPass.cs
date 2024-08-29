using CL_Negocios;
using System;
using System.Windows.Forms;

namespace CV_Presentacion.Frm_Usuario
{
    public partial class frm_ConfiguracionPass : Form
    {
        private ConfiguracionPasswordBLL configuracionPasswordBLL;
        public frm_ConfiguracionPass()
        {
            InitializeComponent();

        }
/*        private void btnGuardarConfiguracion_Click(object sender, EventArgs e)
        {

            try
            {
                // Obtener valores de los controles del formulario
         
                int minimo = Convert.ToInt32(txtMinCaracter.Text);
                int maximo = Convert.ToInt32(txtMaxCaracter.Text);
                int intentos = Convert.ToInt32(txtCantIntentos.Text);
                bool mayusMinus = chkMayusMinus.Checked;
                bool numerosLetras = chkNumLetras.Checked;
                bool especial = chkCaracterEspecial.Checked;
                bool dosPasos = chkDosPasos.Checked;
                bool repetir = chkPassAnterior.Checked;
                bool datosPersonales = chkDatosPersonales.Checked;
                bool preguntaSeguridad = chkPreguntaSeguridad.Checked;
                bool nuevasPreguntas = ckbPregunta.Checked;
                bool bloqueoAuto = chkBolqueoAuto.Checked;
                int diasBloqueo = Convert.ToInt32(txtCantidadDias.Text);

                if (configuracionPasswordBLL != null)
                {
                    // Llamar al método en la capa de lógica de negocio para guardar la configuración
                    configuracionPasswordBLL.GuardarConfiguracion(minimo, maximo, intentos, mayusMinus, numerosLetras, especial, dosPasos, repetir, datosPersonales, preguntaSeguridad, nuevasPreguntas, bloqueoAuto, diasBloqueo);

                    MessageBox.Show("Configuración guardada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else

                {
                    MessageBox.Show("Configuración NO  guardada correctamente.", "NO Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, ingrese valores numéricos válidos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar la configuración: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
*/
        private void btnGuardarConfiguracion_Click_1(object sender, EventArgs e)
        {
            try
            {
                // Obtener valores de los controles del formulario
                
                int minimo = Convert.ToInt32(txtMinCaracter.Text);
                int maximo = Convert.ToInt32(txtMaxCaracter.Text);
                int intentos = Convert.ToInt32(txtCantIntentos.Text);
                bool mayusMinus = chkMayusMinus.Checked;
                bool numerosLetras = chkNumLetras.Checked;
                bool especial = chkCaracterEspecial.Checked;
                bool dosPasos = chkDosPasos.Checked;
                bool repetir = chkPassAnterior.Checked;
                bool datosPersonales = chkDatosPersonales.Checked;
                bool preguntaSeguridad = chkPreguntaSeguridad.Checked;
                bool nuevasPreguntas = ckbPregunta.Checked;
                bool bloqueoAuto = chkBolqueoAuto.Checked;
                int diasBloqueo = Convert.ToInt32(txtCantidadDias.Text);
                if (configuracionPasswordBLL != null)
                {
                    // Llamar al método en la capa de lógica de negocio para guardar la configuración
                    configuracionPasswordBLL.GuardarConfiguracion(minimo, maximo, intentos, mayusMinus, numerosLetras, especial, dosPasos, repetir, datosPersonales, preguntaSeguridad, nuevasPreguntas, bloqueoAuto, diasBloqueo);

                    MessageBox.Show("Configuración guardada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else

                {
                    MessageBox.Show("Configuración NO  guardada correctamente.", "NO Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, ingrese valores numéricos válidos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar la configuración: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
    }

