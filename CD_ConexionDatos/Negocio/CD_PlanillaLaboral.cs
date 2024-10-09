using CapaServicios;
using CapaServicios.Entidades.Diaria;
using CapaServicios.Entidades.Frecuencia;
using CD_ConexionDatos.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity.Core.Mapping;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
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
        public bool ExiteRegistroId(int id, DateTime fecha)
        {
            int valor=0;

            using (con = connectionBD.CreaInstacia().CrearConexion())
            {
                con.Open();
              

                SqlCommand comando = new SqlCommand("spFiltroChoferes", con);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@xid", id);
                comando.Parameters.AddWithValue("@xfecha", fecha);

                using (SqlDataReader reader = comando.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        valor = Convert.ToInt32(reader["id"]);
                    }
                }
                con.Close();            
            }
            if (valor > 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public bool ExisteRegistroUnidadId(int id, DateTime fecha)
        {
            int valor = 0;

            using (con = connectionBD.CreaInstacia().CrearConexion())
            {
                con.Open();


                SqlCommand comando = new SqlCommand("spFiltroUnidades", con);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@xid", id);
                comando.Parameters.AddWithValue("@xfecha", fecha);

                using (SqlDataReader reader = comando.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        valor = Convert.ToInt32(reader["id"]);
                    }
                }
                con.Close();
            }
            if (valor > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
