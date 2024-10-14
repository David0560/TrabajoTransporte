using CapaServicios.Entidades.Taller;
using System;
using System.Data;
using System.Data.SqlClient;

namespace CD_ConexionDatos.Taller
{
    public class CD_Articulo
    {
        public CD_Articulo() { }

        public DataTable ObtenerArticulosPorNombre(string nombreArticulo)
        {
            DataTable dtArticulos = new DataTable();
            using (SqlConnection connection = connectionBD.CreaInstacia().CrearConexion())
            {
                try
                {
                    using (SqlCommand cmd = new SqlCommand("spObtenerArticulosPorNombre", connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@NombreArticulo", nombreArticulo);
                        connection.Open();

                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                        {
                            da.Fill(dtArticulos);
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al obtener los artículos: " + ex.Message);
                }
            }
            return dtArticulos;
        }

        // Método para guardar un nuevo artículo usando el SP
        public void GuardarArticulo(Articulo articulo)
        {
            using (SqlConnection connection = connectionBD.CreaInstacia().CrearConexion())
            {
                try
                {
                    using (SqlCommand cmd = new SqlCommand("SPGuardarNuevoArticulo", connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        // Pasar los parámetros necesarios al SP
                        cmd.Parameters.AddWithValue("@Nombre", articulo.Nombre);
                        cmd.Parameters.AddWithValue("@Descripcion", articulo.Descripcion);
                        connection.Open();

                        cmd.ExecuteNonQuery(); // Ejecuta el procedimiento almacenado
                    }
                }
                catch (SqlException ex)
                {
                    // Manejar el error específico lanzado por el SP
                    if (ex.Number == 50000) // Error específico de RAISERROR
                    {
                        throw new Exception("El artículo ya existe en la base de datos.");
                    }
                    else
                    {
                        throw new Exception("Error al guardar el artículo: " + ex.Message);
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al guardar el artículo: " + ex.Message);
                }
            }
        }
    }
}
