/*
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CD_ConexionDatos
{
    public string ObtengoTiempoDeEspera(string id)
    {

        using (var con = connectionBD.CreaInstacia().CrearConexion())
        {
            try
            {
                con.Open();
                SqlCommand command = new SqlCommand("spObtengoTiempo", con)
                {
                    CommandType = CommandType.StoredProcedure
                };
                command.Parameters.AddWithValue("@Id", id);
                SqlDataAdapter adapter = new SqlDataAdapter(command);

            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error al obtener proveedores por empresa: " + ex.Message);
            }
        }

    }
}
*/