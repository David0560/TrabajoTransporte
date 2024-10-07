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
    public class CD_PlanillaLaboral
    {
        SqlConnection con = new SqlConnection(); // instancio la cadena para la conexion

        public bool GuardarPlanillas(int idGrilla, List<PlanillaLab> lista)
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
                            comando.Parameters.AddWithValue("@xidFrecuencia", l.Id_Frecuencias);
                            comando.Parameters.AddWithValue("@xidEmpleado", l.Id_Empleados);
                            comando.Parameters.AddWithValue("@xidUnidad", l.Id_Unidad);
                            comando.Parameters.AddWithValue("@xhoraSalida", l.HoraSalida);
                            comando.Parameters.AddWithValue("@xhoraEntrada", l.HoraEntrada);
                            comando.ExecuteNonQuery();
                            
                        }
                        con.Close();
                    }
                    return true;
                }
            }
            else
            {
                return false;
            }
        }
   
    }
}
