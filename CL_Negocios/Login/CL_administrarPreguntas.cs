using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CD_ConexionDatos;
using CD_ConexionDatos.Password;

namespace CL_Negocios
{
    public class CL_administrarPreguntas
    {
        private CD_Pregunta pregunta = new CD_Pregunta();
        private CD_PreguntaUsuario preguntaUsuario = new CD_PreguntaUsuario();
        private CD_RegistrosPassword _password = new CD_RegistrosPassword();

        // Crea una nueva pregunta en la base de datos si el texto no está vacío
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

        // Elimina una pregunta de la base de datos por su ID
        public void eliminarPregunta(int id)
        {
            pregunta.EliminarPregunta(id);
        }

        // Obtiene tres preguntas aleatorias de la base de datos
        public List<Tuple<int, string>> ObtenerTresPreguntasAleatorias()
        {
            return preguntaUsuario.ObtenerTresPreguntasAleatorias();
        }

        // Guarda las respuestas de seguridad del usuario en la base de datos
        public void GuardarRespuestasUsuario(string nombreUsuario, List<Tuple<int, string>> preguntasYRespuestas)
        {
            int idUsuario = _password.ObtenerIdUsuarioPorNombre(nombreUsuario); // Obtiene el ID del usuario por su nombre
            preguntaUsuario.GuardarRespuestasUsuario(idUsuario, preguntasYRespuestas); // Guarda las respuestas del usuario
        }

    }
}