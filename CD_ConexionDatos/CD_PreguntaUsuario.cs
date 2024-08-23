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

        /// Obtiene tres preguntas aleatorias de la base de datos.
        public List<Tuple<int, string>> ObtenerTresPreguntasAleatorias()
        {
            List<Tuple<int, string>> preguntas = new List<Tuple<int, string>>();
            using (con = connectionBD.CreaInstacia().CrearConexion())
            {
                string query = "SELECT TOP 3 id, pregunta FROM Pregunta ORDER BY NEWID()";
                SqlCommand command = new SqlCommand(query, con);

                try
                {
                    con.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        preguntas.Add(new Tuple<int, string>((int)reader["id"], reader["pregunta"].ToString()));
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al obtener preguntas aleatorias", ex);
                }
            }
            return preguntas;
        }

        // Guarda las respuestas de seguridad del usuario en la base de datos
        public void GuardarRespuestasUsuario(int idUsuario, List<Tuple<int, string>> preguntasYRespuestas)
        {
            using (con = connectionBD.CreaInstacia().CrearConexion())
            {
                con.Open();
                SqlTransaction transaction = con.BeginTransaction();

                try
                {
                    foreach (var par in preguntasYRespuestas)
                    {
                        string query = "INSERT INTO Respuesta_Usuario (id_pregunta, id_usuario, respuesta) VALUES (@id_pregunta, @id_usuario, @respuesta)";
                        SqlCommand command = new SqlCommand(query, con, transaction);
                        command.Parameters.AddWithValue("@id_pregunta", par.Item1);
                        command.Parameters.AddWithValue("@id_usuario", idUsuario);
                        command.Parameters.AddWithValue("@respuesta", par.Item2);
                        command.ExecuteNonQuery();
                    }
                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    throw new Exception("Error al guardar las respuestas del usuario", ex);
                }
            }
        }
    }
}