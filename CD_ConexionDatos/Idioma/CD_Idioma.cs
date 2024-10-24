using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;

namespace CD_ConexionDatos.Idioma
{
    public class Idiomas // Clase que representa un idioma
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
    }

    public class CD_Idioma
    {
        // Método para obtener la lista de idiomas desde la base de datos
        public List<Idiomas> ObtenerIdiomas()
        {
            List<Idiomas> listaIdiomas = new List<Idiomas>(); // Cambia el nombre aquí

            // Obtiene la instancia de la conexión
            connectionBD conexionBD = connectionBD.CreaInstacia();
            using (SqlConnection conn = conexionBD.CrearConexion())
            {
                // Crea el comando para ejecutar el procedimiento almacenado
                SqlCommand cmd = new SqlCommand("spObtenerIdiomas", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                try
                {
                    // Abre la conexión
                    conn.Open();
                    // Ejecuta el comando y obtiene un SqlDataReader
                    SqlDataReader reader = cmd.ExecuteReader();

                    // Lee los datos devueltos por el SP
                    while (reader.Read())
                    {
                        listaIdiomas.Add(new Idiomas
                        {
                            Nombre = reader.GetString(1) // Obtiene el Nombre
                        });
                    }
                }
                catch (Exception ex)
                {
                    // Manejo de excepciones
                    throw new Exception("Error al obtener idiomas: " + ex.Message);
                }
            }

            return listaIdiomas; // Devuelve la lista de idiomas
        }
    }
}
