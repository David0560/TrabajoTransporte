using CapaServicios;
using CapaServicios.Entidades.Diaria;
using CapaServicios.Entidades.Frecuencia;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity.Core.Mapping;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CD_ConexionDatos.Negocio
{
    internal class CD_PlanillaLaboral
    {
        SqlConnection con = new SqlConnection(); // instancio la cadena para la conexion

        /*public bool GuardarPlanillas(List<PlanillaLab> lista, int idGrilla)
        {
            if (lista != null)
            {
                using (con = connectionBD.CreaInstacia().CrearConexion())
                {
                    using (con = connectionBD.CreaInstacia().CrearConexion())
                    {
                        con.Open();
                        foreach (var l in lista)
                        {
                            SqlCommand comando = new SqlCommand("spGuardarPlanillaDia", con);
                            comando.CommandType = CommandType.StoredProcedure;
                            comando.Parameters.AddWithValue("@xidGrillaDelDia", idGrilla);
                            comando.Parameters.AddWithValue("@xidEmpleado", lista.Id_Empleados);
                            comando.Parameters.AddWithValue("@xidUnidad", lista.Id_Unidad);
                            comando.Parameters.AddWithValue("@xidFrecuencia", lista.Id_Frecuencias);
                            comando.Parameters.AddWithValue("@xhoraSalida", lista.HoraSalida);
                            comando.ExecuteNonQuery();
                            con.Close();
                        }
                    }
                    return true;
                }
            }
            else
            {
                return false;
            }
        }*/
   
    }
}
