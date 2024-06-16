using System.Data;
using System.Data.SqlClient;
using System.Runtime.InteropServices.ComTypes;


namespace CD_ConexionDatos
{
    internal class CD_Pregunta
    {
        SqlConnection con = new SqlConnection(); // prepara el objeto para recibir los valores

        public void guardarPregunta(object objeto)
        {
            using (con = connectionBD.CreaInstacia().CrearConexion()) // realizo la conexion
            {
                con.Open();
                using (SqlCommand comando = new SqlCommand("spGuardarNuevaPregunta", con))
                {
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.Add(new SqlParameter("@xpregunta", con));
                    //comando.Parameters["@xpregunta"].Value = valor;
                    //comand0.Parameters.AddWithValue("@xpregunta", pregunta.pregunta);
                    //comando.Parameters.Add("@xpregunta", pregunta.varvchar,50)
                    comando.Parameters.AddWithValue("@xpregunta", objeto);
                    comando.ExecuteNonQuery();
                    
                }
            }
        }
    }
}