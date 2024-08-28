using System.Data;
using System.Data.SqlClient;
using System.Runtime.InteropServices.ComTypes;


namespace CD_ConexionDatos
{
    public class CD_Pregunta
    {
        SqlConnection con = new SqlConnection(); // prepara el objeto para recibir los valores

        public void guardarPregunta(string texto)
        {
            using (con = connectionBD.CreaInstacia().CrearConexion()) // realizo la conexion
            {
                con.Open();
                using (SqlCommand comando = new SqlCommand("spGuardarNuevaPregunta", con))
                {
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.Add(new SqlParameter("@xpregunta", con));
                    comando.Parameters["@xpregunta"].Value = texto;
                    
                    comando.ExecuteNonQuery();
                    
                }

            }
        }
        public void EliminarPregunta(int id)
        {
            using (con = connectionBD.CreaInstacia().CrearConexion())
            {
                con.Open();
                SqlCommand comando = new SqlCommand("spBorrarPregunta", con);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add(new SqlParameter("@xid", con));
                comando.Parameters["@xid"].Value = id;

                comando.ExecuteNonQuery();
            }
        }

    }
}