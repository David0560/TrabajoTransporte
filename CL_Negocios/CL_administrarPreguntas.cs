using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CD_ConexionDatos;

namespace CL_Negocios
{

    public class CL_administrarPreguntas
    {
        private CD_Pregunta pregunta = new CD_Pregunta();
        public void crearNuevaPregunta(string text)
        {
            string preg = Convert.ToString(text);
            pregunta.guardarPregunta( preg);
            MessageBox.Show("pregunta guardad");
        }
        
        //gestionar data grid
    }
}
