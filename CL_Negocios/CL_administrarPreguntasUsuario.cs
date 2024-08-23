using CL_Negocios.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CD_ConexionDatos;

namespace CL_Negocios
{
    public class CL_administrarPreguntasUsuario
    {

        private CD_PreguntaUsuario  _preguntaUsuario;

        public CL_administrarPreguntasUsuario()
        {
            _preguntaUsuario = new CD_PreguntaUsuario();
        }

        // Método para verificar si un usuario existe
        public bool VerificarUsuario(string nombreUsuario)
        {
            try
            {
                return _preguntaUsuario.ExisteUsuario(nombreUsuario);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al verificar la existencia del usuario", ex);
            }
        }

        // Método para verificar si un usuario tiene preguntas de seguridad cargadas
        public bool UsuarioTienePreguntas(string nombreUsuario)
        {
            try
            {
                // Consulta a la capa de datos para obtener las preguntas de seguridad
                var preguntas = _preguntaUsuario.ObtenerPreguntasUsuario(nombreUsuario);
                return preguntas.Count > 0; // Retorna verdadero si hay preguntas asociadas
            }
            catch (Exception ex)
            {
                throw new Exception("Error al verificar preguntas de seguridad del usuario", ex);
            }
        }

        // Método para obtener un objeto Usuario
        public Usuario ObtenerUsuario(string nombreUsuario)
        {
            try
            {
                var usuario = new Usuario
                {
                    Nombre = nombreUsuario,
                    PreguntasSeguridad = _preguntaUsuario.ObtenerPreguntasUsuario(nombreUsuario),
                    RespuestasSeguridad = _preguntaUsuario.ObtenerRespuestasUsuario(nombreUsuario)
                };

                return usuario;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener el usuario", ex);
            }
        }
    }
}
