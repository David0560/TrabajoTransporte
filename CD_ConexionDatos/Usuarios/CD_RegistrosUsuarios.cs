using CL_Negocios.Entidades;
using System;
using System.Data.SqlClient;
using System.Data;

namespace CD_ConexionDatos.Usuarios
{
    public class CD_RegistrosUsuarios
    {
        SqlConnection con = new SqlConnection(); // instancio la cadena para la conexion
        int cantidad;
        //
        // relacionados al Usuario
        //
        public void guardarNuevoUsuario(Usuario usuario)
        {
            using (con = connectionBD.CreaInstacia().CrearConexion())
            {
                con.Open();
                SqlCommand comando = new SqlCommand("spGuardarNuevoUsuario", con);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@xnombre", usuario.Nombre);
                comando.Parameters.AddWithValue("@xestado", usuario.Estado);
                comando.Parameters.AddWithValue("@xid_persona", usuario.Id_persona);
                comando.Parameters.AddWithValue("@xpassword_user", usuario.Password_user);
                comando.Parameters.AddWithValue("@xfecha_vence_pass", usuario.Fecha_vence_pass);
                comando.Parameters.AddWithValue("@xfecha_user_temporal", usuario.Fecha_user_temporal);
                comando.Parameters.AddWithValue("@xfecha_alta", DateTime.Now);
                comando.Parameters.AddWithValue("@xid_familia", usuario.Id_familia);

                comando.ExecuteNonQuery();
                con.Close();
            }
        }
        public void borrarUsuario(string nombreUsuario)
        {
            using (con = connectionBD.CreaInstacia().CrearConexion())
            {
                con.Open();
                SqlCommand comando = new SqlCommand("spBorrarUsuario", con);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add(new SqlParameter("@xnombre", con));
                comando.Parameters["@xpregunta"].Value = nombreUsuario;

                comando.ExecuteNonQuery();
                con.Close();
            }
        }
        public void bloqueoDeUsuario(int id, bool valor)
        {
            using (con = connectionBD.CreaInstacia().CrearConexion())
            {
                con.Open();
                SqlCommand comando = new SqlCommand("spBloquearUsuario", con);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add(new SqlParameter("@xid", con));
                comando.Parameters["@xid"].Value = id;
                comando.Parameters.Add(new SqlParameter("@xestado", con));
                comando.Parameters["@xestado"].Value = valor;

                comando.ExecuteNonQuery();
                con.Close();
            }
        }
        public int obtenerUltimoUsuario()
        {
            using (con = connectionBD.CreaInstacia().CrearConexion()) // realizo la conexion
            {
                using (SqlCommand comando = new SqlCommand("spVerUltimoUsuairo", con))
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
        public int ObtenerIdUsuarioPorNombre(string nombreUsuario)
        {
            int idUsuario = 0;

            using (con = connectionBD.CreaInstacia().CrearConexion())
            {
                con.Open();
                SqlCommand comando = new SqlCommand("spUbicarUsuarioLogin", con);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@xnombre", nombreUsuario);

                using (SqlDataReader reader = comando.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        idUsuario = Convert.ToInt32(reader["id"]);
                    }
                }
                con.Close();
            }

            return idUsuario;
        }

    }
}
