  using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CD_ConexionDatos.Entidades;
using CL_Negocios.Entidades;
using CapaServicios.Entidades.Diaria;

namespace CD_ConexionDatos.Negocio
{
    public class CD_GrillaDiaria
    {
        SqlConnection con = new SqlConnection(); // instancio la cadena para la conexion
        int cantidad;
        public void guardarNuevaGrilla(GrillaDiaria grilla)
        {
            using (con = connectionBD.CreaInstacia().CrearConexion())
            {
                con.Open();
                SqlCommand comando = new SqlCommand("spGuardarNuevaGrilla", con);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@xfecha", grilla.Fecha);
                comando.Parameters.AddWithValue("@xhora_alta", DateTime.Now);
                comando.ExecuteNonQuery();
                con.Close();
            }
        }
        public int obtenerUltimoRegistroGrilla()
        {
            using (con = connectionBD.CreaInstacia().CrearConexion()) // realizo la conexion
            {
                using (SqlCommand comando = new SqlCommand("spVerUltimoRegistroGrilla", con))
                {
                    comando.CommandType = CommandType.StoredProcedure;
                    con.Open();// abro la conexion.
                    using (SqlDataReader leer = comando.ExecuteReader())
                    {
                        while (leer.Read())
                        {
                            cantidad = Convert.ToInt32(leer["id"]);
                        }

                    }
                    con.Close();
                }
            }
            return cantidad;
        }


        /*public void guardarDiaria(int id, List<PlanillaLab> planilla)// guarda toda la lista de registros que se crearon para el dia X.
        {
            using (con = connectionBD.CreaInstacia().CrearConexion())
            {
                con.Open();
                try
                {
                    foreach (var objetos in planilla)
                    {
                        using (SqlCommand command = new SqlCommand("sp", con))
                        {
                            command.Parameters.AddWithValue("@xidGrilla", id);
                            command.Parameters.AddWithValue("@xidFrecuencia", planilla.Id_Frecuencias);
                            command.Parameters.AddWithValue("@xidEmpleado", planilla.Id_Empleados);
                            command.Parameters.AddWithValue("@xidUnidad", planilla.Id_Unidad);

                            command.ExecuteNonQuery();
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al guardar las respuestas del usuario", ex);
                }
            }
        }




        // ***** metodos con listas y LINQ *******
        */
    }
}
