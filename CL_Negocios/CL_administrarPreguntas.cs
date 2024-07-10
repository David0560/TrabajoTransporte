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
        public bool crearNuevaPregunta(string text)
        {
            if (text != "")
            {
                string preg = Convert.ToString(text);
                pregunta.guardarPregunta(preg);
                return true;
               
            }
            else
            {
                return false;
            }
        }

        public void eliminarPregunta(int id)
        {
            pregunta.EliminarPregunta(id);
        }
        
        //gestionar data grid
    }
}
