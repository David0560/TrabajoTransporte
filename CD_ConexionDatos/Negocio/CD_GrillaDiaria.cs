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
        int idUltimo;
        public void guardarNuevaGrilla(DateTime fecha)
        {
            using (con = connectionBD.CreaInstacia().CrearConexion())
            {
                con.Open();
                SqlCommand comando = new SqlCommand("spGuardarNuevaGrilla", con);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@xFecha", fecha);
                comando.Parameters.AddWithValue("@xHoraEmision", DateTime.Now);
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
                    idUltimo = 0;
                    using (SqlDataReader leer = comando.ExecuteReader())
                    {
                        while (leer.Read())
                        {
                            idUltimo = Convert.ToInt32(leer["id"]);
                        }

                    }
                    con.Close();
                }
            }
            return idUltimo;
        }

        public bool revisarRemalCargado(int id, DateTime fecha)
        {
            using (con = connectionBD.CreaInstacia().CrearConexion())
            {
                int valor = 0;
                con.Open();
                SqlCommand comando = new SqlCommand("spRevisarRamalExistente", con);
            
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
            
                if (valor > 0)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }
    }
}
