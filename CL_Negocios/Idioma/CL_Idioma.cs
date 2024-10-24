using System;
using System.Collections.Generic;
using System.Windows.Forms;
using CD_ConexionDatos.Idioma; // Importando la clase Idioma

namespace CL_Negocios.Idioma
{
    public class CL_Idioma
    {
        private CD_Idioma cd_idioma;

        public CL_Idioma()
        {
            cd_idioma = new CD_Idioma(); // Instancia de la clase de datos
        }

        // Método para obtener la lista de idiomas
        public List<Idiomas> ObtenerIdiomas()
        {
            try
            {
                return cd_idioma.ObtenerIdiomas(); // Llama al método de la capa de datos
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener idiomas desde la lógica: " + ex.Message);
            }
        }

        // Método para cargar idiomas en el ComboBox
        public void CargarIdiomas(ComboBox comboBox)
        {
            try
            {
                List<Idiomas> idiomas = ObtenerIdiomas(); // Obtiene la lista de idiomas
                comboBox.Items.Clear(); // Limpia el ComboBox de idiomas
                foreach (var idioma in idiomas)
                {
                    comboBox.Items.Add(idioma.Nombre); // Agrega cada idioma al ComboBox
                }
                if (comboBox.Items.Count > 0)
                    comboBox.SelectedIndex = 0; // Selecciona el primer idioma por defecto
            }
            catch (Exception ex)
            {
                throw new Exception("Error al cargar idiomas: " + ex.Message);
            }
        }
    }
}
