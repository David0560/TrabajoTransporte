using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CD_ConexionDatos
{
    public class CD_PreguntaUsuario
    {
        /// Verifica si existe un usuario en la base de datos con el nombre especificado.
        SqlConnection con = new SqlConnection(); // prepara el objeto para recibir los valores
        public bool ExisteUsuario(string nombreUsuario)
        {
            using (con = connectionBD.CreaInstacia().CrearConexion())
            {
                // Consulta SQL para contar los usuarios que coinciden con el nombre proporcionado
                string query = "SELECT COUNT(*) FROM Usuario WHERE nombre = @NombreUsuario COLLATE SQL_Latin1_General_CP1_CS_AS";
                SqlCommand command = new SqlCommand(query, con);
                command.Parameters.AddWithValue("@NombreUsuario", nombreUsuario);

                try
                {
                    con.Open();
                    int count = (int)command.ExecuteScalar(); // Ejecuta la consulta y obtiene el resultado
                    return count > 0; // Devuelve true si hay al menos un usuario con ese nombre
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al verificar si el usuario existe", ex);
                }
            }
        }

        // Obtiene las preguntas de seguridad asociadas a un usuario específico.

        public List<string> ObtenerPreguntasUsuario(string nombreUsuario)
        {
            List<string> preguntas = new List<string>();
            using (con = connectionBD.CreaInstacia().CrearConexion())
            {
                // Consulta SQL para obtener las preguntas de seguridad del usuario
                string query = "SELECT P.pregunta FROM Pregunta P " +
                               "JOIN Respuesta_Usuario RU ON P.id = RU.id_pregunta " +
                               "JOIN Usuario U ON RU.id_usuario = U.id WHERE U.nombre = @NombreUsuario";
                SqlCommand command = new SqlCommand(query, con);
                command.Parameters.AddWithValue("@NombreUsuario", nombreUsuario);

                try
                {
                    con.Open();
                    SqlDataReader reader = command.ExecuteReader(); // Ejecuta la consulta y obtiene el lector de datos
                    while (reader.Read())
                    {
                        preguntas.Add(reader["pregunta"].ToString()); // Agrega las preguntas al listado
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al obtener las preguntas del usuario", ex);
                }
            }
            return preguntas; // Devuelve la lista de preguntas de seguridad
        }

        // Obtiene las respuestas de seguridad asociadas a un usuario específico.

        public List<string> ObtenerRespuestasUsuario(string nombreUsuario)
        {
            List<string> respuestas = new List<string>();
            using (con = connectionBD.CreaInstacia().CrearConexion())
            {
                // Consulta SQL para obtener las respuestas de seguridad del usuario
                string query = "SELECT RU.respuesta FROM Respuesta_Usuario RU " +
                               "JOIN Usuario U ON RU.id_usuario = U.id WHERE U.nombre = @NombreUsuario";
                SqlCommand command = new SqlCommand(query, con);
                command.Parameters.AddWithValue("@NombreUsuario", nombreUsuario);

                try
                {
                    con.Open();
                    SqlDataReader reader = command.ExecuteReader(); // Ejecuta la consulta y obtiene el lector de datos
                    while (reader.Read())
                    {
                        respuestas.Add(reader["respuesta"].ToString()); // Agrega las respuestas al listado
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al obtener las respuestas del usuario", ex);
                }
            }
            return respuestas; // Devuelve la lista de respuestas de seguridad
        }
    }

}

