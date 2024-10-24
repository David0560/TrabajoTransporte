using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using CapaSesion;
using CL_Negocios.Entidades;

namespace CD_ConexionDatos
{
    public class CD_loginUsuario
    {
        SqlConnection con = new SqlConnection(); // instancio la cadena para la conexion
        int cantidad;
        int cant;

        public int ubicarUsuarioExistent(string nombreUsuario)
        {
            using (con = connectionBD.CreaInstacia().CrearConexion()) // realizo la conexion
            {
                using (SqlCommand comando = new SqlCommand("spUbicarUsuarioLogin", con))
                {

                    comando.CommandType = CommandType.StoredProcedure;
                    con.Open();// abro la conexion.
                    comando.Parameters.Add(new SqlParameter("@xnombre", con));
                    comando.Parameters["@xnombre"].Value = nombreUsuario;

                    using (SqlDataReader leer = comando.ExecuteReader())
                    {
                        while (leer.Read())
                        {
                            cantidad = Convert.ToInt32(leer["id"]);
                        }
                    }
                }
            }
            return cantidad;
        }
        public DataTable valoresParaLogin(int id_usuario)
        {
            try
            {
                using (con = connectionBD.CreaInstacia().CrearConexion())
                {
                    using (SqlCommand comando = new SqlCommand("spValoresParaLogin", con))
                    {
                        comando.CommandType = CommandType.StoredProcedure;
                        comando.Parameters.Add(new SqlParameter("@xid", con));
                        comando.Parameters["@xid"].Value = id_usuario;
                        DataTable dt = new DataTable();
                        SqlDataAdapter da = new SqlDataAdapter(comando);
                        con.Open();
                        da.Fill(dt);
                        return dt;
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally // permite colocar una condicion para saber el estado de la conexión
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close(); // cierra la conexión
                }
            }
        }
        public void CargarUsuarioLogeado(int id_usuario)
        {
            //try
            //{
                using (con = connectionBD.CreaInstacia().CrearConexion())
                {
                    using (SqlCommand comando = new SqlCommand("spUsuarioLogeado", con))
                    {
                        
                        comando.CommandType = CommandType.StoredProcedure;
                        comando.Parameters.Add(new SqlParameter("@xid", con));
                        comando.Parameters["@xid"].Value = id_usuario;
                        con.Open();
                        SqlDataReader leer = comando.ExecuteReader();
                        //if (leer.HasRows)
                        //{
                            while (leer.Read())
                            {
                                UsuarioLoginCache.Id_usuario = leer.GetInt32(0);
                                UsuarioLoginCache.Nombre = leer.GetString(1);
                                UsuarioLoginCache.Apellido = leer.GetString(2);
                                UsuarioLoginCache.Email = leer.GetString(3);
                                UsuarioLoginCache.Familia= leer.GetString(4);
                            }
                        //}
                    }
                }
            //}
            /*catch (Exception ex)
            {
                throw ex;
            }
            finally // permite colocar una condicion para saber el estado de la conexión
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close(); // cierra la conexión
                }
            }*/
        }

        // intentos en el login.
        public void primerIngresoNuevoIntento(int idU)
        {
            using (con = connectionBD.CreaInstacia().CrearConexion())
            {
                con.Open();
                SqlCommand comando = new SqlCommand("spGuardarNuevointento", con);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@xidU", idU);
                comando.Parameters.AddWithValue("@xfecha", DateTime.Today);
                comando.Parameters.AddWithValue("@xcant", 0);
                comando.ExecuteNonQuery();
                con.Close();
            }
        }
        public int cantidadDeIntentosDeUsuario(int idU)
        {
            using (con = connectionBD.CreaInstacia().CrearConexion()) // realizo la conexion
            {
                using (SqlCommand comando = new SqlCommand("spVerIntentosDelUsuario", con))
                {
                    
                    comando.CommandType = CommandType.StoredProcedure;
                    con.Open();// abro la conexion.
                    comando.Parameters.Add(new SqlParameter("@xidU", con));
                    comando.Parameters["@xidU"].Value = idU;

                    using (SqlDataReader leer = comando.ExecuteReader())
                    {
                        while (leer.Read())
                        {
                            cant = Convert.ToInt32(leer["cantidad"]);
                        }
                    }
                }
            }
            return cant;
        }
        public void AumentarIntentosDeUsuario(int idU, int CantInt)
        {
            using (con = connectionBD.CreaInstacia().CrearConexion())
            {
                con.Open();
                SqlCommand comando = new SqlCommand("spActualizarIntentosDeUsuario", con);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@xidU", idU);
                comando.Parameters.AddWithValue("@xfecha", DateTime.Today);
                comando.Parameters.AddWithValue("@xcant", CantInt);
                comando.ExecuteNonQuery();
                con.Close();
            }
        }

















        /*public Usuario traerValoresUsuario(int id_usuario)
        {
            using (SqlCommand comando = new SqlCommand("spCargarDatosUsuario", con))
            {
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add(new SqlParameter("@id", con));
                comando.Parameters["@id"].Value = id_usuario;
                con.Open();// abro la conexion.
                using (SqlDataReader leer = comando.ExecuteReader())
                {
                    while (leer.Read())// mientras tenga algo para leer
                    {
                        Usuario usuario = new Usuario
                        (

                            leer["nombre"].ToString(),
                            Convert.ToInt32(leer["estado"],
                            Convert.ToInt32(leer["id_persona"],
                            leer["password_user"].ToString(),
                            Convert.ToInt32(leer["id_familia"],
                            Convert.ToDateTime(leer["fecha_vence_pass"],
                            Convert.ToDateTime(leer["fecha_vence_pass"],
                            Convert.ToInt32(leer["id"],
                            Convert.ToDateTime(leer["fecha_vence_pass"],
                        );
                        return usuario;
                           // instancio el objeto cachePermisos
                       // los agrego a la lista llamada roles
                    }

                }
            }
        }*/




    }

}
