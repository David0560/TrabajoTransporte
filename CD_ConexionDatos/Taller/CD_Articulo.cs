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
    }
}
