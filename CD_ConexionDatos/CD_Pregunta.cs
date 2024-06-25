﻿using System.Data;
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
                //string query = "INSERT INTO Pregunta (pregunta) VALUES (@xpregunta)";
                using (SqlCommand comando = new SqlCommand("spGuardarNuevaPregunta", con))
                {
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.Add(new SqlParameter("@xpregunta", con));
                    comando.Parameters["@xpregunta"].Value = texto;
                    
                    comando.ExecuteNonQuery();
                    
                }

            }

            // cargar data grid
        }
    }
}