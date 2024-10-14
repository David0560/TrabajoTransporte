using CapaServicios;
using CapaServicios.Entidades.Diaria;
using CapaServicios.Entidades.Frecuencia;
using CD_ConexionDatos.Entidades;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity.Core.Mapping;
using System.Data.SqlClient;
using System.Data.SqlTypes;
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
        
        //CambiarRecursos
        public bool CambiarRecursosChofer(int id_Chofer, int id)
        {
            using (con = connectionBD.CreaInstacia().CrearConexion())
            {
                using (con = connectionBD.CreaInstacia().CrearConexion())
                {

                    con.Open();
                    SqlCommand comando = new SqlCommand("spModificarRegistroEmpleado", con);
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.Add(new SqlParameter("@xid", con));
                    comando.Parameters["@xid"].Value = id;
                    comando.Parameters.Add(new SqlParameter("@xidE", con));
                    comando.Parameters["@xidE"].Value = id_Chofer;

                    comando.ExecuteNonQuery();
                    con.Close();

                    /*con.Open();
                    SqlCommand comando = new SqlCommand("spModificarRegistroEmpleado", con);
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.AddWithValue("@xid", id);
                    comando.Parameters.AddWithValue("@xidE", id_Chofer);
                    comando.ExecuteNonQuery();
                    con.Close();*/
                }
                return true;
            }
        }
        public bool CambiarRecursosUnidad(int id_unidad, int id)
        {
            using (con = connectionBD.CreaInstacia().CrearConexion())
            {
                using (con = connectionBD.CreaInstacia().CrearConexion())
                {
                    con.Open();
                    SqlCommand comando = new SqlCommand("spModificarRegistroUnidad", con);
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.AddWithValue("@xid", id);
                    comando.Parameters.AddWithValue("@xidU", id_unidad);
                    comando.ExecuteNonQuery();
                    con.Close();
                }
                return true;
            }
        }
        public bool CambiarRecursos(int id_chofer, int id_unidad, int id)
        {
            using (con = connectionBD.CreaInstacia().CrearConexion())
            {
                using (con = connectionBD.CreaInstacia().CrearConexion())
                {
                    con.Open();
                    SqlCommand comando = new SqlCommand("spModificarRegistro", con);
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.AddWithValue("@xid", id);
                    comando.Parameters.AddWithValue("@xidU", id_unidad);
                    comando.Parameters.AddWithValue("@xidE", id_chofer);
                    comando.ExecuteNonQuery();
                    con.Close();
                }
                return true;
            }
        }

        //altas
        public DataTable ListaDeRegistros(DateTime  fecha)
        {
            using (con = connectionBD.CreaInstacia().CrearConexion())
            {

                con.Open();
                SqlCommand comando = new SqlCommand("spListaSalida", con);

                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add(new SqlParameter("@xfecha", con));
                comando.Parameters["@xfecha"].Value = fecha;
                comando.CommandType = CommandType.StoredProcedure;
                DataTable lista = new DataTable();
                SqlDataAdapter adaptador = new SqlDataAdapter(comando);
                adaptador.Fill(lista);
                con.Close();
                return lista;
            }
        }
        public DataTable ObtenerRegistro(int id)
        {
            using (con = connectionBD.CreaInstacia().CrearConexion())
            {
                con.Open();
                SqlCommand comando = new SqlCommand("spObtenerRegistroSalida", con);

                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add(new SqlParameter("@xid", con));
                comando.Parameters["@xid"].Value = id;
                comando.CommandType = CommandType.StoredProcedure;
                DataTable tablaDatos = new DataTable();
                SqlDataAdapter adaptador = new SqlDataAdapter(comando);
                adaptador.Fill(tablaDatos);
                con.Close();
                return tablaDatos;

            }
        }
    }
}
