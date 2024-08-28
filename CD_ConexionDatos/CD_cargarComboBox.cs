﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CD_ConexionDatos;

namespace CD_ConexionDatos
{
    public class CD_cargarComboBox
    {
        SqlConnection con = new SqlConnection(); // instancio la cadena para la conexion

        public DataTable ObtenerDatosComboBox(string query)
        {
            using (con = connectionBD.CreaInstacia().CrearConexion())
            {
                con.Open();
                SqlCommand comando = new SqlCommand(query, con);
                comando.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter adaptador = new SqlDataAdapter(comando);
                DataTable tablaDatos = new DataTable();
                adaptador.Fill(tablaDatos);
                con.Close();
                return tablaDatos;
            }
        }
    }
}