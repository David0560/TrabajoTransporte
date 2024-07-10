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
        private CD_PreguntaUsuario preguntaUsuario = new CD_PreguntaUsuario();
        private CD_crearRegistros crearRegistros = new CD_crearRegistros(); // Instancia de CD_crearRegistros
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

        public List<string> ObtenerTresPreguntasAleatorias()
        {
            return preguntaUsuario.ObtenerTresPreguntasAleatorias();
        }

        public void GuardarRespuestasUsuario(string nombreUsuario, List<Tuple<int, string>> preguntasYRespuestas)
        {
            int idUsuario = crearRegistros.ObtenerIdUsuarioPorNombre(nombreUsuario); // Llama al método desde CD_crearRegistros
            preguntaUsuario.GuardarRespuestasUsuario(idUsuario, preguntasYRespuestas);
        }

        //gestionar data grid
    }
}
