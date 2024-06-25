using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CL_Negocios.Entidades;

namespace CD_ConexionDatos
{
    public class CD_crearRegistros
    {

        SqlConnection con = new SqlConnection(); // instancio la cadena para la conexion
        public CD_crearRegistros() { }
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
            }
        }
        public void bloqueoDeUsuario(string nombreUsuario)
        {
            using (con = connectionBD.CreaInstacia().CrearConexion())
            {
                con.Open();
                SqlCommand comando = new SqlCommand("spBloquearUsuario", con);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add(new SqlParameter("@xnombre", con));
                comando.Parameters["@xpregunta"].Value = nombreUsuario;

                comando.ExecuteNonQuery();
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
                    
                }
               
            }
            return cantidad;
        }


        //
        // relacionados con los roles
        //
        public void guardarNuevoPermiso(Permisos permiso)
        {
            using (con = connectionBD.CreaInstacia().CrearConexion())
            {
                con.Open();
                SqlCommand comando = new SqlCommand("spGuardarNuevoPermiso", con);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@xid_famil_rol", permiso.Id_familia_rol);
                comando.Parameters.AddWithValue("@xid_usuario", permiso.Id_usuario);
                comando.Parameters.AddWithValue("@xfecha_alta", DateTime.Now);
                comando.Parameters.AddWithValue("@xfecha_baja", permiso.Fecha_baja);
                
                comando.ExecuteNonQuery();
            }
        }
        public void EliminarPermisoDeUsuario(int id)
        {

            using (con = connectionBD.CreaInstacia().CrearConexion())
            {
                con.Open();
                SqlCommand comando = new SqlCommand("spBorrarPermisoUsuario", con);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add(new SqlParameter("@xid", con));
                comando.Parameters["@xid"].Value = id;

                comando.ExecuteNonQuery();
            }
        }
        public void ActualizarFechaVencimiento(int id, DateTime? nuevafecha)
        {
            using(con = connectionBD.CreaInstacia().CrearConexion())
            {
                con.Open();
                SqlCommand comando = new SqlCommand("spActualizarFechaPermiso", con);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add(new SqlParameter("@xid", con));
                comando.Parameters["@xid"].Value = id;
                comando.Parameters.Add(new SqlParameter("@xfecha_baja", con));
                comando.Parameters["@xfecha_baja"].Value = nuevafecha;

                comando.ExecuteNonQuery();
            }
        }
   }
}
