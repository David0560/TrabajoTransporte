using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CD_ConexionDatos;

namespace CL_Negocios
{
    public class CL_administrarComboBox
    {
        private CD_cargarComboBox cn = new CD_cargarComboBox();
        public void seleccionCombo( ComboBox combo, string query)
        {
            try
            {
                combo.DataSource = cn.ObtenerDatosComboBox(query); 
                // indicamos las tablas a mostrar  y el valor que va a tomar.
                combo.DisplayMember = "nombre"; // acá indicamos que es lo que queremos visualizar
                combo.ValueMember = "id"; // en esta nos dice que valor va a tomar ese combo
                combo.AutoCompleteSource = AutoCompleteSource.ListItems;
                combo.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                combo.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                // Manejar cualquier excepción que pueda ocurrir durante la ejecución de la consulta. 
                Console.WriteLine("Ocurrió un error: " + ex.Message);
            }
            

        }
    }
}
